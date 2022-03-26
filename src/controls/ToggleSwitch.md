---
layout: control
name: ToggleSwitch
group: controls
---
[ToggleSwitch API]: http://reference.avaloniaui.net/api/Avalonia.Controls/ToggleSwitch/
[ToggleSwitch.fs]: https://github.com/AvaloniaCommunity/Avalonia.FuncUI/blob/master/src/Avalonia.FuncUI.DSL/ToggleSwitch.fs
[Views and Attributes]: guides/Views-and-Attributes.html
[Click Mode]: http://reference.avaloniaui.net/api/Avalonia.Controls/ClickMode/
[CheckBox]: controls/CheckBox.html

> *Note*: You can check the Avalonia docs for the [ToggleSwitch API] if you need more information.
>
> For Avalonia.FuncUI's DSL properties you can check [ToggleSwitch.fs]

A `ToggleSwitch` is a switch that toggles between on (checked) and off
(unchecked) states. This control functions similarly to a [CheckBox] but
displays the content with an on/off slider instead.

## Usage

**Create a ToggleSwitch**

```fsharp
ToggleSwitch.create [
    ToggleSwitch.content "Title"
]
```

**Register State Change**

```fsharp
ToggleSwitch.create [
    ToggleSwitch.isChecked state.toggleSwitch
    ToggleSwitch.onIsPressedChanged (fun value -> SwitchToggled value |> dispatch)
]
```

**Handle state changes Separately**

```fsharp
ToggleSwitch.create [
    ToggleSwitch.content "Fullscreen"
    ToggleSwitch.onChecked (fun _ -> dispatch Fullscreen)
    ToggleSwitch.onUnchecked (fun _ -> dispatch Windowed)
]
```

**Tristate Toggling**

`ToggleSwitch.isChecked` can take values that are `bool`, `Nullable<bool>`, or
`bool option`. When using tristate options however, you must use either
`Nullable<bool>` or `bool option`. You can also handle each event state like
above using `onChecked`, `onUncheked`, and `onIndeterminate`.

```fsharp 
ToggleSwitch.create [
    // can be either true or false
    ToggleSwitch.isThreeState state.indeterminate
    // this value is required to be either a nullable boolean
    // or a boolean option
    ToggleSwitch.isChecked state.checked
    // Returns a Nullable<bool> value
    ToggleSwitch.onIsCheckedChanged (fun nullabelVal -> OnChecked val |> dispatch)
]
```



