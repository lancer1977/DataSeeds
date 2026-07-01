#!/usr/bin/env bash
set -euo pipefail

repo_root="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
cd "$repo_root"

required_paths=(
  "README.md"
  "CsvToJson/CsvToJson.sln"
  "PFAExcelToXML/PFAExcelToXML.sln"
  "code_health.md"
  "docs/project-atlas/README.md"
  ".devstudio/project.yaml"
)

for path in "${required_paths[@]}"; do
  if [[ ! -e "$path" ]]; then
    echo "Missing required path: $path" >&2
    exit 1
  fi
done

dotnet restore CsvToJson/CsvToJson.sln
dotnet build CsvToJson/CsvToJson.sln --configuration Release --no-restore

if command -v devstudio >/dev/null 2>&1; then
  devstudio validate --repo "$repo_root"
else
  echo "devstudio not available; skipping DevStudio validation"
fi

echo "DataSeeds validation passed for the Linux-compatible CsvToJson project."
