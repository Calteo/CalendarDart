Param (
[Parameter(Position=1)]
[String]$artifacts="artifacts"
)

Push-Location $PSScriptRoot
Write-Host $PSCommandPath

if (Test-Path $artifacts)
{
    Remove-Item -Recurse -Force $artifacts
}
$folder = New-Item -ItemType Directory -Path $artifacts 

Copy-Item README.md -Destination $artifacts -PassThru | ForEach-Object { Write-Output "--> $($_.Name)" }
Copy-Item LICENSE -Destination $artifacts -PassThru | ForEach-Object { Write-Output "--> $($_.Name)" }

$fullname = $folder.FullName
Get-ChildItem -Path "source/**/CreateArtifacts.ps1" | ForEach-Object { "$_" + " $fullname" } | Invoke-Expression 

Pop-Location
