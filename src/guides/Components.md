---
layout: guide
title: Components
author: Avalonia Community
list-order: 4
guide-category: beginner
---

[hooks]: guides/Hooks.html

While MVU suits many simple scenarios, there is some friction with bigger projects, scaling up past a few child pages can create a lot of boilerplate for Avalonia applications.

From v0.5.0 and onwards Avalonia.FuncUI offers a completely new programming model inspired by web frameworks like React and Sutil.

Creating a component is done in the following way

```fsharp
// An Instance of a Component (which can be used on plain avalonia component instances)
Component(fun context -> TextBlock.create [ TextBlock.text "That's it!" ])
// and Component.create which can be used to create DSL compatible components
Component.create("an identifier", fun context -> TextBlock.create [ TextBlock.text "That's it!" ])
```

let's check a more complete example and how you can setup your new components within FuncUI applications.

```fsharp
open Avalonia
open Avalonia.Controls

open Avalonia.FuncUI
open Avalonia.FuncUI.DSL
open Avalonia.FuncUI.Hosts


let counter (id: string) (initial: int)=
    // Component id creates a DSL compatible  version which
    // you can use on any of your existing views
    Component.create(id, fun ctx ->
        let state = ctx.useState initial

        // The rest of the DSL
        StackPanel.create [
            StackPanel.children [
                TextBlock.create [
                    TextBlock.text (string state.Current)
                ]
                Button.create [
                    Button.width 64
                    Button.content "Increment"
                    Button.onClick (fun _ -> state.Current + 1 |> state.Set)
                ]
            ]
        ]
    )

let view =
    // Component creates an instance that can be assigned to
    // any other Avalonia component's Content
    Component(fun ctx ->
        StackPanel.create [
            StackPanel.children [
                TextBlock.create [
                    TextBlock.text "We can still use our existing components"
                ]
                counter "counter-1" 0
                counter "counter-2" 100
            ]
        ]
    )

type MainWindow() as this =
    inherit HostWindow()
    do
        base.Title <- "Basic Component Example"
        base.Width <- 400.0
        base.Height <- 400.0
        // Note this line
        this.Content <- Counter.view
```

Components still use the same DSL for Avalonia.FuncUI, but the way they handle updates is different, it is mostly guided by `IWritable<'T>`'s updates, so if you have sections in your views that are _stateful_ by nature, components are a natural fit for that. In other cases you can still use normal F# functions, they will get updated if the values of their parameters change.

MVU is also not going anywhere, in the Hooks section you will be able to see how to use the new `useElmish` hook that can help you mix and match these two different approaches without compromises.

### Looking for more advanced uses?

For more Advanced uses check [Hooks]
