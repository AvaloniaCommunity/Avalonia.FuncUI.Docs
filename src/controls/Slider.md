---
layout: control
name: Slider
group: controls
---
[Slider]: https://docs.avaloniaui.net/docs/controls/slider
[Slider API]: http://reference.avaloniaui.net/api/Avalonia.Controls/Slider/
[Slider.fs]: https://github.com/fsprojects/Avalonia.FuncUI/blob/master/src/Avalonia.FuncUI.DSL/Slider.fs
[Slider Selection Modes]: https://docs.avaloniaui.net/docs/controls/listbox#selectionmode

> *Note*: You can check the Avalonia docs for the [Slider] and [Slider API] if you need more information.
>
> For Avalonia.FuncUI's DSL properties you can check [Slider.fs]

The Slider control is a control that lets the user select from a range of
values by moving a Thumb control along a track.

**Percentage Slider**
```fsharp
Slider.create [
    Slider.minimum 0.
    Slider.maximum 0.
    Slider.value state.Percentage
    Slider.onValueChanged (fun newPercentage -> ChangePercentage newPercentage |> dispatch)

]
```
