---
layout: guide
title: Hooks
author: Avalonia Community
list-order: 5
guide-category: beginner
---

[components]: guides/Components.html

> Hooks can only be used with [Components], so feel free to check them out first before reviewing this page.

## useState

This is the most basic hook which allows you to create an instance of a value which can be both read and updated in your component's code, the state is kept between renders and any updates to it will cause it to re-render by default

```fsharp
Component(fun ctx ->
    let state = ctx.useState 0
    // Component's UI
)
```

## useElmish

WIP

## useEffect

WIP

## IReadable<'T>

```fsharp
type IReadable<'value> =
    inherit IAnyReadable
    abstract member Current: 'value with get
    abstract member Subscribe : ('value -> unit) -> IDisposable
```

As is in the source comments:

> Readable state value that can be subscribed to.

Readables are values which you can subscribe to get updates, this are common values used

An example would be the following

```fsharp
Component(fun ctx ->
    let state = ctx.useState 0

    Button.create [
        Button.content $"Count: {state.Current}"
    ]
)
```

At this point this component will be pretty much static, it won't ever be re-rendered because there are no changes to it's state.

## IWritable<'T>

```fsharp
type IWritable<'value> =
    inherit IReadable<'value>
    abstract member Set : 'value -> unit
```

As is in the source comments:

> Readable and writable state value that can be subscribed to.

If we take the previous example and add mutations it would look like the following:

```fsharp
Component(fun ctx ->
    let state = ctx.useState 0

    Button.create [
        Button.content $"Count: {state.Current}"
        Button.onClick (fun _ -> state.Current + 1 |> state.Set)
    ]
)
```

### Passed Values

Sometimes when you already have an `IWritable<'T>` value, you would like to use it on sibling components so they can show the same data in different formats or just to communicate changes between different component trees without having to drill the values into the component's tree.

For that we can use Passed Values.

```fsharp

let ComponentA id (value: IWrittable<string>) =
    Component(id, fun ctx ->
        // Right here we can use ctx.usePassed to ensure we can both read/update a value
        let value = ctx.usePassed value
        StackPanel.create [
            StackPanel.children [
                TextBlock.create [
                    TextBlock.text $"This component can read and update this value: \"{value.Current}\""
                ]
                Button.create [
                    Button.content "Add 3"
                    Button.onClick (fun _ -> $"{value.Current}3" |> value.Set )
                ]
            ]
        ]
    )

let ComponentB id (value: IReadable<string>) =
    Component(id, fun ctx ->
        // Right here we can use ctx.usePassedRead to ensure we can only read a value
        let value = ctx.usePassedRead value
        StackPanel.create [
            StackPanel.children [
                TextBlock.create [
                    TextBlock.text $"This component can only read this value: \"{value.Current}\""
                ]
            ]
        ]
    )

let View =
    Component(fun ctx ->
        let value = ctx.useState "This is my value"
        StackPanel.create [
            StackPanel.spacing 12.
            StackPanel.children [
                // here we can use our components with the existing value
                // in other implementations these could also be called
                // "Stores"
                ComponentA "component-a" value
                ComponentB "component-b" value
                Button.create [
                    Button.content "I can add 4 from outside"
                    // since state is both readable and writable we can also
                    // modify the values from outside the children components
                    // as usual
                    Button.onClick (fun _ -> $"{value.Current}4" |> value.Set )
                ]
            ]
        ]
    )
```
