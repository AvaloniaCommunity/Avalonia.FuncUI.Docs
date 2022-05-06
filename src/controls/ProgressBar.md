---
layout: control
name: ProgressBar
group: controls
---
[ProgressBar]: https://docs.avaloniaui.net/docs/controls/progressbar
[ProgressBar API]: http://reference.avaloniaui.net/api/Avalonia.Controls/ProgressBar/
[ProgressBar.fs]: https://github.com/fsprojects/Avalonia.FuncUI/blob/master/src/Avalonia.FuncUI.DSL/ProgressBar.fs

> *Note*: You can check the Avalonia docs for the [ProgressBar] and [ProgressBar API] if you need more information.
>
> For Avalonia.FuncUI's DSL properties you can check [ProgressBar.fs]

The ProgressBar control allow for showing dynamic progress status.

## Usage

**Basic Progress Bar**
```fsharp
ProgressBar.create [
    ProgressBar.value 50.
    ProgressBar.maximum 100.
    // Minimum default value is set to 0
]
```

**Indeterminate Animated Progress Bar**
```fsharp
ProgressBar.create [
    ProgressBar.isIndeterminate true
]
```
