[![Build Status](https://github.com/CapitalOnTap/marqeta-csharp-core-sdk/actions/workflows/dotnet.yml/badge.svg?event=push)
[![NuGet Version](https://img.shields.io/nuget/v/Marqeta.Core.Sdk)](https://www.nuget.org/packages/Marqeta.Core.Sdk)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Marqeta.Core.Sdk)](https://www.nuget.org/packages/Marqeta.Core.Sdk)

# marqeta-csharp-core-sdk

Marqeta C# Software Development Kit

## Documentation

For complete reference documentation, see the [Marqeta Core API Reference](https://www.marqeta.com/api/docs/WYDH6igAAL8FnF21/api-introduction).

## Generating SDK

Make sure dotnet SDK is installed first

Run command `dotnet fsi GenerateSdkFromSourceUrl.fsx`
## Running tests

To run tests locally, user secrets need to be configured to use your developer public sandbox instance.
```
dotnet user-secrets set "Marqeta:BaseUrl" "https://sandbox-api.marqeta.com/v3/"
dotnet user-secrets set "Marqeta:UserName" "<Application token>"
dotnet user-secrets set "Marqeta:Password" "<Access Token>"
```
You can obtain a developer public sandbox by signing up to marqeta as per instructions [here](https://www.marqeta.com/docs/developer-guides/core-api-quick-start#_create_an_account)
