namespace AGS.Plugin.Template

open AGS.Types
open System.Windows.Forms
open System.Drawing

type AGSPanel () =
    inherit EditorContentPanel()
    do
        let label = new Label()
        label.Location <- new Point (10, 20)
        label.Text <- "My Label"

        base.SuspendLayout()

        base.Controls.Add label

        base.ResumeLayout false


