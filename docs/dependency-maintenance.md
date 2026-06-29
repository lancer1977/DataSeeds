# Dependency Maintenance

## 2026-06-29 PFAExcelToXML package review

The .NET Framework projects keep package versions in their project files.

- `Newtonsoft.Json` is updated to `13.0.4` in `PFAExcelToXML` and
  `Pathfinder.DocConverter`.
- `Pathfinder.DocConverter` was retargeted from .NET Framework 4.6.1 to 4.7.2
  so the solution has one supported full-framework baseline.
- `PolyhydraGames.Extensions` stays on `2.0.8` for both projects because newer
  package versions no longer restore for the full-framework target; restore
  reports that `2.1.1.78` supports `net8.0` and `net9.0` only.
- `PFAExcelToXML/PFAExcelToXML.sln` now includes both legacy Windows projects,
  so the documented validation command covers the app and converter together.

Validation commands:

```bash
dotnet restore PFAExcelToXML/PFAExcelToXML.sln
```

Full build validation is intentionally kept on Windows MSBuild because these
are WinForms .NET Framework projects:

```powershell
msbuild PFAExcelToXML\PFAExcelToXML.sln /t:Restore /p:Configuration=Release
msbuild PFAExcelToXML\PFAExcelToXML.sln /p:Configuration=Release /p:RestorePackages=false
```

The Linux SDK restore command is still useful as a package compatibility check,
but Linux cannot build the WinForms projects without .NET Framework reference
assemblies.

## 2026-06-29 CI artifact scope

The repository CI validates the Linux-compatible `CsvToJson` project and uploads
both the validation log and the published `CsvToJson` output as workflow
artifacts. CI also runs a Windows MSBuild job for `PFAExcelToXML` and uploads
the Release outputs from both legacy projects as `dataseeds-pfaexceltoxml`.
