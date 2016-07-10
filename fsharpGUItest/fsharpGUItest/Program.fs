// F# の詳細については、http://fsharp.org を参照してください
// 詳細については、'F# チュートリアル' プロジェクトを参照してください。

open System 
open System.Windows.Forms 
open System.Drawing 
 
//do 
//    Application.Run(mainForm) // #2 
let form = new Form(Text = "ボタンテスト")
let btn = new Button(Text = "OK")
btn.Click.AddHandler(fun _ _ -> (if btn.Text = "OK" then btn.Text <- "NG" else btn.Text <- "OK") |> ignore)

form.Controls.Add(btn)

Application.Run(form)