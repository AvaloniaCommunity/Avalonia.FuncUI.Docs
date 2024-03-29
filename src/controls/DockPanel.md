---
layout: control
name: DockPanel
group: controls
---
[DockPanel]: https://docs.avaloniaui.net/docs/controls/dockpanel
[DockPanel API]: http://reference.avaloniaui.net/api/Avalonia.Controls/DockPanel/
[DockPanel.fs]: https://github.com/AvaloniaCommunity/Avalonia.FuncUI/blob/master/src/Avalonia.FuncUI.DSL/Panels/DockPanel.fs

> *Note*: You can check the Avalonia docs for the [DockPanel] and [DockPanel API] if you need more information.
>
> For Avalonia.FuncUI's DSL properties you can check [DockPanel.fs]

The DockPanel is a layout construct that allows docking its children to the different sides of it.

## Usage

### Basic Usage
```fsharp
DockPanel.create [
    DockPanel.children [
        // Some child control
        [..].dock Dock.Top // you can use Left, Right, Top and Bottom
    ]
]
```

You can use multiple dockings inside of one panel. It will dock in order of the children list
(you can see that in the example).

**Example**

![DockPanel](images/controls/dockpanel/basic.png)

```fsharp
DockPanel.create [
    DockPanel.children [
        Border.create [
            Border.background "blue"
            Border.dock Dock.Left
            Border.padding 20.
        ]
        Border.create [
            Border.background "green"
            Border.dock Dock.Bottom
            Border.padding 20.
        ]
        Border.create [
            Border.background "red"
            Border.dock Dock.Right
            Border.padding 20.
        ]
        Border.create [
            Border.background "orange"
            Border.dock Dock.Top
            Border.padding 20.
        ]
        Border.create [
            Border.background "purple"
            Border.dock Dock.Left
            Border.padding 20.
        ]
        Border.create [
            Border.background "yellow"
        ]
    ]
]
```
