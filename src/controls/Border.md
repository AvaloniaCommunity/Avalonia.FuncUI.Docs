---
layout: control
name: Border
group: controls
---
[Border]: https://docs.avaloniaui.net/docs/controls/border
[Border API]: http://reference.avaloniaui.net/api/Avalonia.Controls/Border/
[Border.fs]: https://github.com/AvaloniaCommunity/Avalonia.FuncUI/blob/master/src/Avalonia.FuncUI.DSL/Border.fs
[Views and Attributes]: guides/Views-and-Attributes.html
[IBrush]: http://reference.avaloniaui.net/api/Avalonia.Media/IBrush/
[Thickness]: http://reference.avaloniaui.net/api/Avalonia/Thickness/
[Corner Radius]: http://reference.avaloniaui.net/api/Avalonia/CornerRadius/

> *Note*: You can check the Avalonia docs for the [Border] and [Border Api] if you need more information.
>
> For Avalonia.FuncUI's DSL properties you can check [Border.fs]

The Border control allows you to decorate child controls

## Usage

**Set Background**
Avalonia.FuncUI has some overloads for you to take advantage of

```fsharp
Border.create [
	Border.background "black"
	Border.child (StackPanel.create [ /* ... definition ... */ ])
]
Border.create [
	Border.background "#000000"
	Border.child (StackPanel.create [ /* ... definition ... */ ])
]
```
> You can pass any [IBrush] compatible instance to the background for more control

**Set Border Brush**
Avalonia.FuncUI has some overloads for you to take advantage of

```fsharp
Border.create [
	Border.borderBrush "red"
	Border.child (StackPanel.create [ /* ... definition ... */ ])
]
```
```fsharp
Border.create [
	Border.borderBrush "#FF0000"
	Border.child (StackPanel.create [ /* ... definition ... */ ])
]
```
> You can pass any [IBrush] compatible instance to the background for more control


**Thickness**
```fsharp
Border.create [
	Border.borderThickness 2.0
	Border.child (StackPanel.create [ /* ... definition ... */ ])
]
```

**Horizontal and Vertical Thickness**
```fsharp
Border.create [
	Border.borderThickness (2.0, 5.0)
	Border.child (StackPanel.create [ /* ... definition ... */ ])
]
```

**Left, Top, Right, Bottom Thickness**
```fsharp
Border.create [
	Border.borderThickness (1.0, 2.0, 3.0, 4.0)
	Border.child (StackPanel.create [ /* ... definition ... */ ])
]
```
> You can also pass a [Thickness] struct to the borderThickness property


**Corner Radius**
```fsharp
Border.create [
	Border.cornerRadius 3.0
	Border.child (StackPanel.create [ /* ... definition ... */ ])
]
```

**Horizontal and Vertical Corner Radius**
```fsharp
Border.create [
	Border.cornerRadius (2.0, 5.0)
	Border.child (StackPanel.create [ /* ... definition ... */ ])
]
```

**Left, Top, Right, Bottom Corner Radius**
```fsharp
Border.create [
	Border.cornerRadius (1.0, 2.0, 3.0, 4.0)
	Border.child (StackPanel.create [ /* ... definition ... */ ])
]
```
> You can also pass a [Corner Radius] struct to the cornerRadius property

```fsharp
Border.create [
	Border.cornerRadius (CornerRadius 3.0)
	Border.child (StackPanel.create [ /* ... definition ... */ ])
]
```
