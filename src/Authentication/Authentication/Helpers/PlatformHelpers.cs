// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    using System;
    public class PlatformHelpers
    {
        /// <summary>
        /// Detects if the platform we are running on is Windows or not.
        /// </summary>
        /// <returns>True if we are runnning on Windows or False if we are not.</returns>
        public static bool IsWindowsPlatform()
        {
            return Environment.OSVersion.Platform == PlatformID.Win32NT;
        }
    }
}
