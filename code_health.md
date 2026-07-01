# Code Health

## Current state

- CI validates the SDK-style `CsvToJson` solution with .NET 8.
- `PFAExcelToXML` contains older .NET Framework projects and is documented as a follow-up modernization/build lane.
- Build outputs, artifacts, dependencies, and DevStudio runtime data are ignored.

## Validation

- `bash scripts/validate.sh`

## Follow-ups

- Modernize or isolate the .NET Framework conversion projects so they can run in cross-platform CI.
- Add tests around data conversion behavior after the build surface is stabilized.
