---
layout: control
name: RepeatButton
group: controls
---
[RepeatButton]: https://docs.avaloniaui.net/docs/controls/repeatbutton
[RepeatButton API]: http://reference.avaloniaui.net/api/Avalonia.Controls/RepeatButton/
[RepeatButton.fs]: https://github.com/AvaloniaCommunity/Avalonia.FuncUI/blob/master/src/Avalonia.FuncUI.DSL/RepeatButton.fs
[Views and Attributes]: guides/Views-and-Attributes.html
[Click Mode]: http://reference.avaloniaui.net/api/Avalonia.Controls/ClickMode/

> *Note*: You can check the Avalonia docs for the [RepeatButton] and [RepeatButton API] if you need more information.
>
> For Avalonia.FuncUI's DSL properties you can check [RepeatButton.fs]


A `RepeatButton` is a subclasses of [Button] so they share all the same
attributes as described on that documentation page. The biggest difference is
that when a `RepeatButton` is held down, the button submits multiple `onClick`
events.

**Creating a RepeatButton**

The `RepeatButton.delay` sets the amount of time in milliseconds before the
extra `onClick` events start triggering. The `RepeatButton.interval` sets the
amount of time in milliseconds between successive `onClick` events

```fsharp
RepeatButton.create [
    RepeatButton.delay 100 // ms
    RepeatButton.interval 250 // ms
    RepeatButton.onClick (fun _ -> dispatch RepeatButtonCicked)
]
```
