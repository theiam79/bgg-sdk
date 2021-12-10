# bgg-sdk
A dotnet client for the BoardGameGeek XMLAPI2. The core library is a simple wrapper for the API using [refit](https://github.com/reactiveui/refit), while the main library provides a useful client that interacts with the api and then maps the results into more consistent objects before returning them.

[![Release](https://github.com/theiam79/bgg-sdk/actions/workflows/publish-release.yml/badge.svg)](https://github.com/theiam79/bgg-sdk/actions/workflows/publish-release.yml)
[![Prerelease](https://github.com/theiam79/bgg-sdk/actions/workflows/publish-test.yml/badge.svg?branch=dev)](https://github.com/theiam79/bgg-sdk/actions/workflows/publish-test.yml)
## install
You can install via the dotnet cli
```
dotnet add package Bgg.Sdk
```
or with NuGet cli
```
Install-Package Bgg.Sdk
```

## setup
The client is intended to be setup bia dependency injection. An extension method exists to make the necessary registrations

```csharp
services.AddBgg();
```

## usage
The `IBggClient` is the primary service you'll interact with. It provides base methods for all of the API endpoints with custom query parameter objects, as well as helpful shortcut methods for most endpoints with reasonable defaults.

First, take a dependency on `IBggClient`
```csharp
public class MyClass{
    private readonly IBggClient _bggClient;

    public MyClass(IBggClient bggClient){
        _bggClient = bggClient;
    }
}
```

Then call any of the endpoints. For example, to retrieve my BGG Collection
```csharp
var collection = await _bggClient.CollectionAsync("theiam79");
```

## more info
You can view the details of the BGG XMLAPI2 [here](https://boardgamegeek.com/wiki/page/BGG_XML_API2). All endpoints have a query parameter object to match the documentation, with the exception of those marked not in use.