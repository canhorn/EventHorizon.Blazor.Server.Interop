namespace EventHorizon.Blazor.Server.Interop.Sample.Pages.DITesting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class DIRunHandlerImplementation : IDIRunHandler
{
    public Task Handle(
        DIRunEvent @event
    )
    {
        return Task.CompletedTask;
    }
}
