<#
.SYNOPSIS
    Build, run, commit, and push PracticePrograms repo in one shot.

.DESCRIPTION
    1. dotnet build
    2. dotnet run (to make sure code runs)
    3. git add .
    4. git commit -m "Auto‑commit: <msg>"
    5. git push origin main

.PARAMETER Message
    Commit message. Default = "Auto‑commit"
#>

param(
    [string]$Message = "Auto‑commit"
)

Write-Host "Building project..." -ForegroundColor Cyan
dotnet build
if ($LASTEXITCODE -ne 0) { Write-Error "Build failed. Aborting."; exit 1 }

Write-Host "Running project..." -ForegroundColor Cyan
dotnet run
if ($LASTEXITCODE -ne 0) { Write-Error "Run failed. Aborting."; exit 1 }

Write-Host "Adding files to Git..." -ForegroundColor Cyan
git add .

$commitMsg = "Auto‑commit: $Message"
Write-Host "Commit message: $commitMsg"
git commit -m "$commitMsg"

Write-Host "Pushing to origin/main..." -ForegroundColor Cyan
git push origin main
