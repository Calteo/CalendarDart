﻿Param (
[Parameter(Position=1,Mandatory=$true)]
[String]$artifacts
)

Push-Location $PSScriptRoot
Write-Host $PSCommandPath

$destinationFolder = $artifacts + "\bin"

if (!(Test-Path -path $destinationFolder)) {$rc = New-Item $destinationFolder -Type Directory }

Write-Output $destinationFolder
Copy-Item bin\Release\*.exe -Destination $destinationFolder -Force -PassThru | ForEach-Object { Write-Output "--> $($_.Name)" }
Copy-Item bin\Release\*.exe.config -Destination $destinationFolder -Force -PassThru | ForEach-Object { Write-Output "--> $($_.Name)" }
Copy-Item bin\Release\*.dll -Exclude "System.*" -Destination $destinationFolder -Force -Container -PassThru | ForEach-Object { Write-Output "--> $($_.Name)" }

# add supported languages here
Copy-Item bin\Release\de -filter *.dll -Recurse -Destination $destinationFolder -Force -Container -PassThru | ForEach-Object { Write-Output "--> $($_.Name)" }

Copy-Item Games -Recurse -Filter *.xml -Destination $destinationFolder -Force -PassThru | ForEach-Object { Write-Output "--> $($_.Name)" }

Pop-Location