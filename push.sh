#!/usr/bin/env bash
# Build, run, commit and push PracticePrograms repo

set -e

MSG=${1:-"Auto-commit"}

echo "🔨 Building project..."
dotnet build

echo "🚀 Running project..."
dotnet run

echo "📂 Adding files to Git..."
git add .

echo "💬 Commit message: Auto-commit: $MSG"
git commit -m "Auto-commit: $MSG"

echo "📤 Pushing to origin/main..."
git push origin main
