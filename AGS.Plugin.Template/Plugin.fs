namespace AGS.Plugin.Template

open AGS.Types
open System.Drawing

type MyPlugin (host: IAGSEditor) as this =
    let COMPONENT_ID = "Template-Plugin"
    let COMPONENT_MENU_COMMAND = "Template-MenuCommand"
    let CONTROL_ID_ROOT_NODE = "Template-Root"
    let ICON_KEY = "Template-Icon"
    let TREE_ROOT_NAME = "Template"

    let assembly = System.Reflection.Assembly.GetExecutingAssembly()
    let stream = assembly.GetManifestResourceStream("AGS.Plugin.Template.Resources.template.ico")
    let icon = new Icon(stream)

    let _ = host.GUIController.RegisterIcon(ICON_KEY, icon)
    let _ = host.GUIController.ProjectTree.AddTreeRoot(this, CONTROL_ID_ROOT_NODE, TREE_ROOT_NAME, ICON_KEY)
    let _ = host.GUIController.ProjectTree.add_BeforeShowContextMenu(fun(evArgs) -> this.ProjectTree_BeforeShowContextMenu(evArgs))

    let pane = new AGSPanel()
    let document = new ContentDocument(pane, "Template window", this, ICON_KEY)

    interface IEditorComponent with
        member this.BeforeSaveGame(): unit =
            ()

        member this.CommandClick(controlID: string): unit =
            if CONTROL_ID_ROOT_NODE = controlID then
                host.GUIController.AddOrShowPane(document)
                ()
            else
                ()


        member this.ComponentID: string = COMPONENT_ID

        member this.EditorShutdown(): unit =
            ()

        member this.FromXml(node: System.Xml.XmlNode): unit =
            ()

        member this.GameSettingsChanged(): unit =
            ()

        member this.GetContextMenu(controlID: string): System.Collections.Generic.IList<MenuCommand> =
            null

        member this.PropertyChanged(propertyName: string, oldValue: obj): unit =
            ()

        member this.RefreshDataFromGame(): unit =
            ()

        member this.ToXml(writer: System.Xml.XmlTextWriter): unit =
            ()


    member this.LocalHost = host

    member this.ProjectTree_BeforeShowContextMenu(evArgs: BeforeShowContextMenuEventArgs) =
        let nodeId = evArgs.SelectedNodeID;
        ()

    member this.MenuCommand = host.GUIController.CreateMenuCommand(this, COMPONENT_MENU_COMMAND, "Edit Template")
