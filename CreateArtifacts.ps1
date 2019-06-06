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
Write-Output $fullname 
# Get-ChildItem -Path "**/CreateArtifacts.ps1" | ForEach-Object { "$_" + " $fullname" } | Invoke-Expression 
Get-ChildItem -Path "**/CreateArtifacts.ps1" | ForEach-Object { Write-Output "$_" + " $fullname" }

Pop-Location
