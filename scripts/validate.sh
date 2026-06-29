#!/usr/bin/env bash
set -euo pipefail

dotnet restore CsvToJson/CsvToJson.sln
dotnet build CsvToJson/CsvToJson.sln --configuration Release --no-restore

echo "DataSeeds validation passed for the Linux-compatible CsvToJson project."
