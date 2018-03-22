open System
open System.Net
open System.Windows.Forms

let browser = 
  let webClient = new WebClient()
  let fSharpDotOrg = webClient.DownloadString(Uri "http://fsharp.org")
  new WebBrowser(ScriptErrorsSuppressed = true,
                 Dock = DockStyle.Fill,
                 DocumentText = fSharpDotOrg)

let form = new Form(Text = "Hello From F#!")
form.Controls.Add browser
form.Show()