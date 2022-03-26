---
layout: control
name: StackPanel
group: controls
---
[StackPanel]: https://docs.avaloniaui.net/docs/controls/stackpanel
[StackPanel API]: http://reference.avaloniaui.net/api/Avalonia.Controls/StackPanel/
[StackPanel.fs]: https://github.com/AvaloniaCommunity/Avalonia.FuncUI/blob/master/src/Avalonia.FuncUI.DSL/Panels/StackPanel.fs

> *Note*: You can check the Avalonia docs for the [StackPanel] and [StackPanel API] if you need more information.
>
> For Avalonia.FuncUI's DSL properties you can check [StackPanel.fs]

The StackPanel is a layout construct that stacks its children in horizontal or vertical direction.

## Usage

### Basic Usage
```fsharp
StackPanel.create [
    StackPanel.orientation Orientation.Horizontal // Orientation can be Horizontal or Vertical
    StackPanel.children [
        // This can be a list of different controls, which are stacked inside of the StackPanel
    ]
]
```

**Example**

![StackPanel](images/controls/stackpanel/basic.png)

```fsharp
StackPanel.create [
    StackPanel.orientation Orientation.Vertical
    StackPanel.children [
        Button.create [
            Button.content "Import"
            Button.padding (40., 14.)
        ]
        Button.create [
            Button.content "Analyse"
            Button.padding (40., 14.)
        ]
        Button.create [
            Button.content "Publish"
            Button.padding (40., 14.)
        ]
    ]
]
```

### Spacing
```fsharp
StackPanel.create [
    StackPanel.orientation Orientation.Horizontal
    StackPanel.spacing 10. // Adds space between stacked items
    StackPanel.children [
        // List of stacked controls
    ]
]
```

**Example**

![StackPanel Spacing](images/controls/stackpanel/spacing.png)

```fsharp
StackPanel.create [
    StackPanel.orientation Orientation.Vertical
    StackPanel.spacing 10.
    StackPanel.children [
        Button.create [
            Button.content "Import"
            Button.padding (40., 14.)
        ]
        Button.create [
            Button.content "Analyse"
            Button.padding (40., 14.)
        ]
        Button.create [
            Button.content "Publish"
            Button.padding (40., 14.)
        ]
    ]
]
```
