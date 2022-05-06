---
layout: control
name: RadioButton
group: controls
---
[RadioButton]: https://docs.avaloniaui.net/docs/controls/radiobutton
[RadioButton API]: http://reference.avaloniaui.net/api/Avalonia.Controls/RadioButton/
[RadioButton.fs]: https://github.com/AvaloniaCommunity/Avalonia.FuncUI/blob/master/src/Avalonia.FuncUI.DSL/RadioButton.fs

> *Note*: You can check the Avalonia docs for the [RadioButton] and [RadioButton API] if you need more information.
>
> For Avalonia.FuncUI's DSL properties you can check [RadioButton.fs]

The RadioButton is a control that allows a user to choose a single value between different options

## Usage

**Set Label**
```fsharp
RadioButton.create [
    RadioButton.content "Opt in to the newsletter"
]
RadioButton.create [
    RadioButton.content "Opt out to the newsletter"
]
```

**Set Is Checked**

```fsharp
RadioButton.create [
    RadioButton.content "Opt in to the newsletter"
    RadioButton.isChecked state.newsLetterOptIn
]
```

**Use A Group of RadioButtons**
```fsharp
RadioButton.create [
    RadioButton.groupName "newsletter"
    RadioButton.content "Opt in to the newsletter"
    RadioButton.isChecked state.newsLetterOptIn
    // remember to use OnChangeOf to give FuncUI hints about when to dispatch the messages
    RadioButton.onChecked ((fun _ -> dispatch OptIn), OnChangeOf(state.newsLetterOptIn))
]
RadioButton.create [
    RadioButton.groupName "newsletter"
    RadioButton.content "Opt out to the newsletter"
    RadioButton.isChecked (not state.newsLetterOptIn)
    // remember to use OnChangeOf to give FuncUI hints about when to dispatch the messages
    RadioButton.onChecked ((fun _ -> dispatch OptOut), OnChangeOf(state.newsLetterOptIn))
]
```

