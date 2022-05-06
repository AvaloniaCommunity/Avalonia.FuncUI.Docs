---
layout: control
name: TabControl
group: controls
---
[TabControl]: http://docs.avaloniaui.net/docs/controls/tabcontrol
[TabControl API]: http://reference.avaloniaui.net/api/Avalonia.Controls/TabControl/
[TabControl.fs]: https://github.com/AvaloniaCommunity/Avalonia.FuncUI/blob/master/src/Avalonia.FuncUI.DSL/TabControl.fs
[example]: https://github.com/AvaloniaCommunity/Avalonia.FuncUI/blob/master/src/Avalonia.FuncUI.ControlCatalog/Views/MainView.fs
[ViewBuilder]: https://github.com/AvaloniaCommunity/Avalonia.FuncUI/blob/master/src/Avalonia.FuncUI.ControlCatalog/Views/MainView.fs#L36
[HostControl]: controls/HostControl.html

> *Note*: You can check the Avalonia docs for the [TabControl] and [TabControl API] if you need more information.
>
> For Avalonia.FuncUI's DSL properties you can check [TabControl.fs]

The [TabControl] offers you a way to present content inside your application, each tab contains a different set of controls.



**Set Tabs**
```fsharp
let homePageContent = 
    DockPanel.create [ 
        DockPanel.children [
            TextBox.create [ TextBox.text "Home" ]
        ]
    ]
let aboutPageContent = 
    DockPanel.create [ 
        DockPanel.children [
            TextBox.create [ TextBox.text "About" ]
        ]
    ]

let tabs : IView list = [
    TabItem.create [
        TabItem.header "Home"
        TabItem.content homePageContent
    ]
    TabItem.create [
        TabItem.header "About"
        TabItem.content aboutPageContent
    ]
]

TabControl.create [
    TabControl.tabStripPlacement Dock.Left // Change this property to tell the app where to show the tab bar
    TabControl.viewItems tabs
]
```

**Set HostControl as content**

You can also include individual Elmish Controls as the content of your tabs by using the [ViewBuilder]. Visit the [example] to see it in action

```fsharp
// counter.fs
module Counter =
    type State = (* state definition *)
    type Msg = (* message definition *)
    let init = (* init definition *)
    let update state msg = (* update definition *)
    let view state dispatch = (* view definition *)

    // encapsule the Elmish architecture in this Host Control
    type Host() as this =
        inherit HostControl()
        do
            Elmish.Program.mkSimple (fun () -> init) update view
            |> Program.withHost this
            |> Program.run

// Program.fs
let aboutPageContent = 
    DockPanel.create [ 
        DockPanel.children [
            TextBox.create [ TextBox.text "About" ]
        ]
    ]
let tabs : IView list = [
    TabItem.create [
        TabItem.header "Counter"
        // use the ViewBuilder to be able to use the Counter module in a stand alone
        TabItem.content (ViewBuilder.Create<Counter.Host>([]))
    ]
    TabItem.create [
        TabItem.header "About"
        TabItem.content aboutPageContent
    ]
]

TabControl.create [
    TabControl.viewItems tabs
]
```
In the example above the `Counter` module defines a `HostControl` to allow that module to work by itself. This means you don't need to nest every view/control inside the main Elmish module of your app, this can help you reduce boilerplate and complexity in the main module of your application
