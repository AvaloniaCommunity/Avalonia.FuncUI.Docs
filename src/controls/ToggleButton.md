---
layout: control
name: ToggleButton
group: controls
---
[ToggleButton]: https://docs.avaloniaui.net/docs/controls/togglebutton
[ToggleButton API]: http://reference.avaloniaui.net/api/Avalonia.Controls.Primitives/ToggleButton/
[ToggleButton.fs]: https://github.com/AvaloniaCommunity/Avalonia.FuncUI/blob/master/src/Avalonia.FuncUI.DSL/ToggleButton.fs
[Views and Attributes]: guides/Views-and-Attributes.html
[Click Mode]: http://reference.avaloniaui.net/api/Avalonia.Controls/ClickMode/
[Button]: controls/Button.html
[CheckBox]: controls/CheckBox.html

> *Note*: You can check the Avalonia docs for the [ToggleButton] and [ToggleButton API] if you need more information.
>
> For Avalonia.FuncUI's DSL properties you can check [ToggleButton.fs]

If you are looking for a button to behave more like a checkbox you can use a
`ToggleButton`. A `ToggleButton` toggles between checked and unchecked on click.

A `ToggleButton` is a subclasses of [Button] so they share all the same
attributes as described on that documentation page. A `ToggleButton` behaves
similar to a [CheckBox] and shares similar attributes like making tristate
ToggleButtons.

> You need to `open Avaloina.Controls.Primatives` to access `ToggleButton` attributes.

## Usage

**Toggling for Checked/Unchecked**

```fsharp 
ToggleButton.create [
    ToggleButton.isChecked state.checked
    // Returns a bool value
    ToggleButton.onIsPressedChanged (fun val -> OnChecked val |> dispatch)
]
```

**Handling Checked and Unchecked Differently**
```fsharp 
ToggleButton.create [
    ToggleButton.onChecked (fun _ -> dispatch Enabled)
    ToggleButton.onUnchecked (fun _ -> dispatch Disabled)
]
```

**Tristate Toggling**

`ToggleButton.isChecked` can take values that are `bool`, `Nullable<bool>`, or
`bool option`. When using tristate options however, you must use either
`Nullable<bool>` or `bool option`. You can also handle each event state like
above using `onChecked`, `onUncheked`, and `onIndeterminate`.

```fsharp 
ToggleButton.create [
    // can be either true or false
    ToggleButton.isThreeState state.indeterminate
    // this value is required to be either a nullable boolean
    // or a boolean option
    ToggleButton.isChecked state.checked
    // Returns a Nullable<boo> value
    ToggleButton.onIsCheckedChanged (fun nullabelVal -> OnChecked val |> dispatch
]
```

