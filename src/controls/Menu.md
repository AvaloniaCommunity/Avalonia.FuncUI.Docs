---
layout: control
name: Menu
group: controls
---
[Menu API]: http://reference.avaloniaui.net/api/Avalonia.Controls/Menu/
[Menu.fs]: https://github.com/AvaloniaCommunity/Avalonia.FuncUI/blob/master/src/Avalonia.FuncUI.DSL/Menu.fs
[Menu]: http://avaloniaui.net/docs/controls/menu
[Image]: http://avaloniaui.net/docs/controls/image
[sample]: https://github.com/AvaloniaCommunity/Avalonia.FuncUI/blob/master/src/Examples/Examples.MusicPlayer/Shell.fs#L162
[this file]: https://github.com/AvaloniaCommunity/Avalonia.FuncUI/blob/master/src/Examples/Examples.MusicPlayer/Extensions.fs#L5

> *Note*: You can check the Avalonia docs for the [Menu API] and [Menu] if you need more information.
>
> For Avalonia.FuncUI's DSL properties you can check [Menu.fs]

The menu control allows you to add a list of buttons in a horizontal manner which supports sub-items, it's usually put at the top of the application inside a DockPanel, but it can be placed anywhere in the application.


## Usage

**Top-Level Menu Items**

To create top-level navigation menus you just need to provide a list of `MenuItem` controls and use the `.viewItems` property on the [Menu] control
```fsharp
let menuItems = [
    MenuItem.Create [
        MenuItem.header "File"
    ]
    MenuItem.Create [
        MenuItem.header "Edit"
    ]
]

Menu.create [
  Menu.viewItems menuItems
]
```

**Set Sub-Menus**

Each MenuItem can contain MenuItems themselves if you need a sub-menu you just need to provide the appropriate children
```fsharp
let fileItems = [
  MenuItem.Create [
        MenuItem.header "Open File"
  ]
  MenuItem.Create [
      MenuItem.header "Open Folder"
  ]
]

let menuItems = [
    MenuItem.Create [
        MenuItem.header "Files"
        MenuItem.viewItems fleItems
    ]
    MenuItem.Create [
        MenuItem.header "Preferences"
    ]
]

Menu.create [
  Menu.viewItems menuItems
]
```

**Set Icons**

To add Icons to the menu item you just need to provide an [Image],
you can check this [sample] which uses an extension method defined in [this file]

```fsharp
let icon = (* obtain an Image instance *)
let menuItems = [
    MenuItem.Create [
        MenuItem.header "Files"
        MenuItem.icon icon
    ]
    MenuItem.Create [
        MenuItem.header "Preferences"
    ]
]

Menu.create [
  Menu.viewItems menuItems
]
```

**Dispatch Actions From Menu Items**
```fsharp
let menuItems = [
    MenuItem.Create [
        MenuItem.header "About"
        MenuItem.onClick(fun _ -> dispatch GoToAbout)
    ]
]

Menu.create [
  Menu.viewItems menuItems
]
```
