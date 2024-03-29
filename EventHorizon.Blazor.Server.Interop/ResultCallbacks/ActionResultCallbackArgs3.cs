﻿namespace EventHorizon.Blazor.Server.Interop.ResultCallbacks;

using System;
using System.Threading.Tasks;

using Microsoft.JSInterop;

/// <summary>
/// A platform provided abstraction to help with creation of a action that will trigger when called from the Client side.
/// </summary>
/// <typeparam name="TArg1"></typeparam>
/// <typeparam name="TArg2"></typeparam>
/// <typeparam name="TArg3"></typeparam>
/// <typeparam name="TResult"></typeparam>
public class ActionResultCallback<TArg1, TArg2, TArg3, TResult>
{
    /// <summary>
    /// This is a type that gets passed to the Client side to help with the client side marshal of arguments.
    /// </summary>
    public string ___type => "action_result_callback";
    /// <summary>
    /// The .NET representation that the Client will call back to on Action trigger.
    /// </summary>
    public DotNetObjectReference<ActionResultCallback<TArg1, TArg2, TArg3, TResult>> invokableReference { get; }
    /// <summary>
    /// The method on the <see cref="invokableReference" /> that will be called when the Action is triggered.
    /// </summary>
    public string method => "HandleCallback";

    private Func<TArg1, TArg2, TArg3, ValueTask<TResult>> _callback;

    /// <summary>
    /// Create a new Action callback representation that will be triggered when the Client calls the method.
    /// </summary>
    /// <param name="callback">The custom action that should be triggered.</param>
    public ActionResultCallback(
        Func<TArg1, TArg2, TArg3, ValueTask<TResult>> callback
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
    /// <param name="arg3">Argument that is passed from client side.</param>
    /// <returns>Make this method async for usage with Client side.</returns>
    [JSInvokable]
    public ValueTask<TResult> HandleCallback(TArg1 arg1, TArg2 arg2, TArg3 arg3)
    {
        return _callback(arg1, arg2, arg3);
    }
}
