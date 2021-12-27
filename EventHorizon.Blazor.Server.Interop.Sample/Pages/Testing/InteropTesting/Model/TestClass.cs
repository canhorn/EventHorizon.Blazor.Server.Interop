namespace EventHorizon.Blazor.Server.Interop.Sample.Pages.Testing.InteropTesting.Model;

using System.Text.Json.Serialization;
using System.Threading.Tasks;

[JsonConverter(typeof(CachedEntityConverter<TestClass>))]
public class TestClass : CachedEntity
{
    public async Task<bool> get_Found()
    {
        return await EventHorizonBlazorInterop.Get<bool>(
            ___guid,
            "found"
        );
    }

    public async Task set_Found(bool value)
    {
        await EventHorizonBlazorInterop.Set(
            ___guid,
            "found",
            value
        );
    }

    public async Task<string> get_Arg1()
    {
        return await EventHorizonBlazorInterop.Get<string>(
            ___guid,
            "arg1"
        );
    }

    public async Task set_Arg1(string value)
    {
        await EventHorizonBlazorInterop.Set(
            ___guid,
            "arg1",
            value
        );
    }

    public TestClass(
        ICachedEntity entity
    )
    {
        ___guid = entity.___guid;
    }

    public static async Task<TestClass> NewTestClass()
    {
        var entity = await EventHorizonBlazorInterop.New(
            new string[] { "Vector3" },
            1,
            2,
            3
        );

        return new TestClass(entity);
    }
}
