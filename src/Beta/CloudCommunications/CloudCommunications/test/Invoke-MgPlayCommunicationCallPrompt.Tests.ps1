$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgPlayCommunicationCallPrompt.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-MgPlayCommunicationCallPrompt' {
    It 'PlayExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Play' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PlayViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PlayViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
