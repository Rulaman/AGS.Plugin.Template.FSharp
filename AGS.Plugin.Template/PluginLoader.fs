namespace AGS.Plugin.Template

open AGS.Types

[<RequiredAGSVersion("3.0.0.0")>]
type PluginLoader (host: IAGSEditor) =
    let myplugin = new MyPlugin(host)
    let _ = host.AddComponent(myplugin)

    interface IAGSEditorPlugin with
        member this.Dispose(): unit = ()
