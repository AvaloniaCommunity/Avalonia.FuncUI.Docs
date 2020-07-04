#r "../_lib/Fornax.Core.dll"

type SiteInfo = {
    title: string
    baseUrl: string
    description: string
    showSideBar: bool
}

let loader (projectRoot: string) (siteContent: SiteContents) =

// Determine baseUrl based on build or watch
#if FORNAX && WATCH
    let baseUrl = "/"
#else
    let baseUrl = "/Avalonia.FuncUI.Docs/"
#endif

    siteContent.Add(
        { title = "Avalonia.FuncUI"
          description = "Avalonia.FuncUI Website"
          showSideBar = true
          baseUrl = baseUrl
        })
    siteContent
