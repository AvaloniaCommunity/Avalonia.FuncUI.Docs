#r "paket:
nuget Fake.DotNet.Cli
nuget Fake.IO.FileSystem
nuget Fake.Core.Target //"

#load ".fake/build.fsx/intellisense.fsx"

open Fake.Core
open Fake.DotNet
open Fake.IO
open Fake.Core.TargetOperators

let setWorkingDir (options: DotNet.Options) =
    { options with
        WorkingDirectory = "./src" }

Target.initEnvironment ()
let docsOutputPath = Path.getFullName "./docs"

Target.create "Clean" (fun _ ->
    let processResult = DotNet.exec setWorkingDir "fornax" "clean"
    Trace.tracefn "Build ExitCode: %i" processResult.ExitCode)

Target.create "Build" (fun _ ->
    let processResult = DotNet.exec setWorkingDir "fornax" "build"
    Trace.tracefn "Build ExitCode: %i" processResult.ExitCode)

Target.create "CleanDocs" (fun _ ->
    printfn "%s" docsOutputPath
    Shell.rm_rf docsOutputPath)

Target.create "CopyDocs" (fun _ ->
    Trace.tracefn "Creating Output Directory: %s" docsOutputPath
    Shell.mkdir docsOutputPath
    let src = Path.getFullName "./src/_public"

    let copied =
        match Path.isDirectory src with
        | true -> Shell.copyRecursive src docsOutputPath false
        | false ->
            Trace.tracefn "No _public directory detected aborting..."
            List.empty

    Trace.tracefn "Publishing docs to %s" docsOutputPath

    for path in copied do
        Trace.tracefn "%s" path)

"Clean" ==> "CleanDocs" ==> "Build" ==> "CopyDocs"

Target.create "All" ignore

"Clean" ==> "Build" ==> "All"

Target.runOrDefaultWithArguments "All"
