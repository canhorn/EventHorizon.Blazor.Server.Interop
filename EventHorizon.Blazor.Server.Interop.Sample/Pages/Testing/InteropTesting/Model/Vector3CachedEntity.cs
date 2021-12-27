namespace EventHorizon.Blazor.Server.Interop.Sample.Pages.Testing.InteropTesting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[System.Text.Json.Serialization.JsonConverter(typeof(CachedEntityConverter<Vector3CachedEntity>))]
public class Vector3CachedEntity
    : CachedEntity
{
    public ValueTask<string> get_X()
    {
        return EventHorizonBlazorInterop.Get<string>(
            this.___guid,
            "X"
        );
    }
    public ValueTask set_X(string value)
    {
        return EventHorizonBlazorInterop.Set(
            this.___guid,
            "X",
            value
        );
    }

    public ValueTask<string> get_Y()
    {
        return EventHorizonBlazorInterop.Get<string>(
            this.___guid,
            "Y"
        );
    }
    public ValueTask set_Y(string value)
    {
        return EventHorizonBlazorInterop.Set(
            this.___guid,
            "Y",
            value
        );
    }
    public ValueTask<string> get_Z()
    {
        return EventHorizonBlazorInterop.Get<string>(
            this.___guid,
            "Z"
        );
    }
    public ValueTask set_Z(string value)
    {
        return EventHorizonBlazorInterop.Set(
            this.___guid,
            "Z",
            value
        );
    }

    public Vector3CachedEntity(
        ICachedEntity entity
    )
    {
        ___guid = entity.___guid;
    }
}
