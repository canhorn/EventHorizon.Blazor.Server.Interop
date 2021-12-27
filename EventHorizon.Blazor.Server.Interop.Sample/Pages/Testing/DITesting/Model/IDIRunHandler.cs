namespace EventHorizon.Blazor.Server.Interop.Sample.Pages.DITesting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface IDIRunHandler
{
    Task Handle(
        DIRunEvent @event
    );
}
