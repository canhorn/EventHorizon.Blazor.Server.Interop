﻿namespace EventHorizon.Blazor.Server.Interop.Callbacks;

using System;
using System.Threading.Tasks;

using Microsoft.JSInterop;

/// <summary>
/// A platform provided abstraction to help with creation of a action that will trigger when called from the Client side.
/// </summary>
/// <typeparam name="TArg1"></typeparam>
/// <typeparam name="TArg2"></typeparam>
public class ActionCallback<TArg1, TArg2>
{
    /// <summary>
    /// This is a type that gets passed to the Client side to help with the client side marshal of arguments.
    /// </summary>
    public string ___type => "action_callback";
    /// <summary>
    /// The .NET representation that the Client will call back to on Action trigger.
    /// </summary>
    public DotNetObjectReference<ActionCallback<TArg1, TArg2>> invokableReference { get; }
    /// <summary>
    /// The method on the <see cref="invokableReference" /> that will be called when the Action is triggered.
    /// </summary>
    public string method => "HandleCallback";

    private Func<TArg1, TArg2, Task> _callback;

    /// <summary>
    /// Create a new Action callback representation that will be triggered when the Client calls the method.
    /// </summary>
    /// <param name="callback">The custom action that should be triggered.</param>
    public ActionCallback(
        Func<TArg1, TArg2, Task> callback
    )
    {
        _callback = callback;
        invokableReference = DotNetObjectReference.Create(
            this
        );
    }

    /// <summary>
    /// The public method that will be called by the Client when an Action should be triggered.
    /// </summary>
    /// <param name="arg1">Argument that is passed from client side.</param>
    /// <param name="arg2">Argument that is passed from client side.</param>
    /// <returns>Make this method async for usage with Client side.</returns>
    [JSInvokable]
    public Task HandleCallback(TArg1 arg1, TArg2 arg2)
    {
        return _callback(arg1, arg2);
    }
}
