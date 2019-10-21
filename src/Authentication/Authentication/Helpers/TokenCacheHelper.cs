// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    using Microsoft.Identity.Client;
    using System;
    using System.IO;
    using System.Security.Cryptography;

    internal class TokenCacheHelper
    {
        private readonly object fileLock = new object();
        private string tokenCachePath;

        public TokenCacheHelper(string filePath, string cacheFileName)
        {
            this.tokenCachePath =Path.Combine(filePath, cacheFileName);
        }

        public static TokenCacheHelper Create(string filePath, string cacheFileName)
        {
            return new TokenCacheHelper(filePath, cacheFileName);
        }

        public void RegisterCache(ITokenCache tokenCache)
        {
            if (tokenCache is null)
                throw new ArgumentNullException(nameof(tokenCache));

            tokenCache.SetBeforeAccess((TokenCacheNotificationArgs args) => {
                lock (fileLock)
                {
                    args.TokenCache.DeserializeMsalV3(File.Exists(tokenCachePath)
                        ? UnprotectData(File.ReadAllBytes(tokenCachePath))
                        : null, shouldClearExistingCache: true);
                }
            });

            tokenCache.SetAfterAccess((TokenCacheNotificationArgs args) => {
                lock (fileLock)
                {
                    if (args.HasStateChanged)
                    {
                        File.WriteAllBytes(tokenCachePath, ProtectData(args.TokenCache.SerializeMsalV3()));
                    }
                }
            });
        }

        public void Logout()
        {
            lock (fileLock)
            {
                File.Delete(tokenCachePath);
            }
        }

        private byte[] ProtectData(byte[] originalData)
        {
            if (PlatformHelpers.IsWindowsPlatform())
                return ProtectedData.Protect(originalData, optionalEntropy: null, scope: DataProtectionScope.CurrentUser);

            return originalData;
        }

        private byte[] UnprotectData(byte[] originalData)
        {
            if (PlatformHelpers.IsWindowsPlatform())
                return ProtectedData.Unprotect(originalData, optionalEntropy: null, scope: DataProtectionScope.CurrentUser);

            return originalData;
        }
    }
}
