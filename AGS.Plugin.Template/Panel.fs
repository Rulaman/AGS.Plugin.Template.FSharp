namespace AGS.Plugin.Template

open AGS.Types


type Panel (document: ContentDocument, panel: AGSPanel) =
    member public x.Document = document
    member public x.Panel = panel
