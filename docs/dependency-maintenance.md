# Dependency Maintenance

## 2026-06-29 PFAExcelToXML package review

The .NET Framework projects keep package versions in their project files.

- `Newtonsoft.Json` is updated to `13.0.4` in `PFAExcelToXML` and
  `Pathfinder.DocConverter`.
- `PolyhydraGames.Extensions` stays on `2.0.8` for both projects because the
  latest available package no longer restores for `net461`/`net472`; restore
  reports that `2.1.1.78` supports `net8.0` and `net9.0` only.

Validation commands:

```bash
dotnet restore PFAExcelToXML/PFAExcelToXML.sln
dotnet list PFAExcelToXML/Pathfinder.DocConverter/Pathfinder.DocConverter.csproj package --outdated
dotnet list PFAExcelToXML/PFAExcelToXML/PFAExcelToXML.csproj package --outdated
```

Full build validation still requires .NET Framework targeting packs for
`net461` and `net472`, which are not available in the current Linux runner
environment.

## 2026-06-29 CI artifact scope

The repository CI validates the Linux-compatible `CsvToJson` project and uploads
both the validation log and the published `CsvToJson` output as workflow
artifacts. `PFAExcelToXML` remains excluded from the Linux CI path until the
repo either retargets those projects or adds a runner with .NET Framework
developer packs.
