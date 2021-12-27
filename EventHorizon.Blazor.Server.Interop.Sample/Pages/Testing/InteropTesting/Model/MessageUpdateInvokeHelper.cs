namespace EventHorizon.Blazor.BabylonJS.Pages.Testing.InteropTesting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.JSInterop;

public class MessageUpdateInvokeHelper
{
    [JSInvokable]
    public Task CallAfterRenderAction()
    {
        return Task.CompletedTask;
    }
}
