[![Build Status](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Factions-badge.atrox.dev%2Fcanhorn%2FEventHorizon.Blazor.Server.Interop%2Fbadge%3Fref%3Dmain&style=for-the-badge)](https://actions-badge.atrox.dev/canhorn/EventHorizon.Blazor.Server.Interop/goto?ref=main)
[![Nuget](https://img.shields.io/nuget/vpre/EventHorizon.Blazor.Server.Interop?style=for-the-badge)](https://www.nuget.org/packages/EventHorizon.Blazor.Server.Interop)

[![GitHub](https://img.shields.io/github/license/canhorn/EventHorizon.Blazor.Server.Interop?style=for-the-badge)](https://github.com/canhorn/EventHorizon.Blazor.Server.Interop/blob/main/LICENSE)
[![GitHub tag (latest SemVer pre-release)](https://img.shields.io/github/v/tag/canhorn/EventHorizon.Blazor.Server.Interop?include_prereleases&label=latest%20tag&style=for-the-badge)](https://github.com/canhorn/EventHorizon.Blazor.Server.Interop/tags)

# About

The EventHorizon.Blazor.Server.Interop is a slim project I created to help with common Blazor JavaScript Interop actions. 
This project is a derived work from the <a href="">canhorn/EventHorizon.Blazor.Interop</a> project that works with Blazor Server, with the caveat of not having the performance the other has. 

The <a href="">canhorn/EventHorizon.Blazor.Interop</a> is focused on WASM, and provides the best interop performance between .NET and the JavaScript client code.

## Usage

This library requires the usage of the IJSRuntime, you will need to attach one manually before usage.

In "App.razor"
~~~ csharp
@code {
    [Inject]
    public IJSRuntime JSRuntime { get; set; }

    protected override void OnInitialized()
    {
        await EventHorizonBlazorInterop.JSRuntime = JSRuntime;
    }
}
~~~

## Sample

The EventHorizon.Blazor.Server.Interop.Sample Project contains a suite of performance tests.

## Use Libraries

[MediatR](https://github.com/jbogard/MediatR)

## Inspiration

- [BlazorUnmarshalledCanvas](https://github.com/jhwcn/BlazorUnmarshalledCanvas/blob/master/UmCanvas/Canvas.cs)
