# DataSeeds
A project focused on DataSeeds.

## Tags

- data-seeds
- docs
- website
- data
- seeds
- ui

## Overview
This repository contains the DataSeeds project. It is designed to provide robust functionality and seamless integration within its ecosystem.

## 🚀 Key Features
- Sub Module Definitions
- General Purpose Utility
- Core Application Logic
- Sub Module Pfaexceltoxml
- Standardized Project Layout
- Core Capabilities
- Sub Module From Website
- [Feature 3 (Beyond the App capability)]

## 🛠 Technology Stack
- [Language/Framework determined by project structure]

## 📖 Documentation
Detailed documentation can be found in the following sections:
- [Docs README](./docs/README.md)
- [Feature Index](./docs/features/README.md)
- [Core Capabilities](./docs/features/core-capabilities.md)
- [Roadmap Index](./docs/roadmaps/README.md)

## 🚦 Getting Started
Run the Linux-compatible validation path with:

```bash
bash scripts/validate.sh
```

The validation script restores and builds `CsvToJson/CsvToJson.sln`. The
`PFAExcelToXML` solution targets .NET Framework 4.7.2 and is validated by the
Windows MSBuild lane in `.github/workflows/ci.yml`.

Run the legacy Windows validation path on a machine with Visual Studio Build
Tools and the .NET Framework 4.7.2 developer pack:

```powershell
msbuild PFAExcelToXML\PFAExcelToXML.sln /t:Restore /p:Configuration=Release
msbuild PFAExcelToXML\PFAExcelToXML.sln /p:Configuration=Release /p:RestorePackages=false
```
