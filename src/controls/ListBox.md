---
layout: control
name: ListBox
group: controls
---
[ListBox]: https://docs.avaloniaui.net/docs/controls/listbox
[ListBox API]: http://reference.avaloniaui.net/api/Avalonia.Controls/ListBox/
[ListBox.fs]: https://github.com/fsprojects/Avalonia.FuncUI/blob/master/src/Avalonia.FuncUI.DSL/ListBox.fs
[ListBox Selection Modes]: https://docs.avaloniaui.net/docs/controls/listbox#selectionmode

> *Note*: You can check the Avalonia docs for the [ListBox] and [ListBox API] if you need more information.
>
> For Avalonia.FuncUI's DSL properties you can check [ListBox.fs]

The list box is a multi-line control box for allowing a user to choose value.

## Usage

**Basic**
```fsharp
ListBox.create [
    ListBox.dataItems [ "Linux"; "Mac"; "Windows" ]
]
```

**Multiple Item Selection Mode**
You can choose different [ListBox Selection Modes]. The default is to only select a single element.
```fsharp
ListBox.create [
    ListBox.dataItems [ "Linux"; "Mac"; "Windows" ]
    ListBox.selectionMode Selection.Multiple
]
```

**Using Discriminated Unions**
```fsharp
type OperatingSystem =
    | Linux
    | Mac
    | Windows

ListBox.create [
    ListBox.dataItems [ Linux; Mac; Windows ]
]
```

**Controlling Selected Item**
To override the controls default behavior you need to add both `selectedItem` and `onSelectedItemChanged`
```fsharp
ListBox.create [
    ListBox.dataItems [ "Linux"; "Mac"; "Windows" ]
    ListBox.selectedItem state.os
    // remember to use OnChangeOf to give FuncUI hints about when to dispatch the messages
    ListBox.onSelectedItemChanged (fun os -> dispatch ChangeOs)
]
```

**Controlling Selected Item by Index**
To override the controls default behavior you need to add both `selectedItem` and `onSelectedItemChanged`
```fsharp
ListBox.create [
    ListBox.dataItems [ "Linux"; "Mac"; "Windows" ]
    ListBox.selectedIndex state.osIndex
    // remember to use OnChangeOf to give FuncUI hints about when to dispatch the messages
    ListBox.onSelectedIndexChanged (fun os -> dispatch ChangeOsIndex)
]
```
