namespace EventHorizon.Blazor.Server.Interop.Sample.Pages.Testing.InteropTesting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Primitives;

[System.Text.Json.Serialization.JsonConverter(typeof(CachedEntityConverter<ClassIdCachedEntity>))]
public class ClassIdCachedEntity
    : CachedEntity
{
    public ValueTask<string> get_Id()
    {
        return EventHorizonBlazorInterop.Get<string>(
            this.___guid,
            "id"
        );
    }
    public ValueTask set_Id(string value)
    {
        return EventHorizonBlazorInterop.Set(
            this.___guid,
            "id",
            value
        );
    }

    public ClassIdCachedEntity()
    {

    }

    public ClassIdCachedEntity(
        ICachedEntity entity
    )
    {
        ___guid = entity.___guid;
    }
}
