// F# の詳細については、http://fsharp.org を参照してください
// 詳細については、'F# チュートリアル' プロジェクトを参照してください。

open System 
open System.Windows.Forms 
open System.Drawing 
 
//do 
//    Application.Run(mainForm) // #2 
let form = new Form(Text = "ボタンテスト", Height = 600,Width = 800)
let btn = new Button(Text = "OK")


let array = [|for i in 0..10 -> [|for j in 0..10 -> new Button(Text = "OK", Top = i * 30, Left = j * 70) |] |]

for i in 0..10 do
    for j in 0..10 do
        array.[i].[j].Click.AddHandler(fun _ _ -> (if array.[i].[j].Text = "OK" then array.[i].[j].Text <- "NG" else array.[i].[j].Text <- "OK") |> ignore)
        form.Controls.Add(array.[i].[j])
    done
done
        


//btn.Click.AddHandler(fun _ _ -> (if btn.Text = "OK" then btn.Text <- "NG" else btn.Text <- "OK") |> ignore)

//form.Controls.Add(btn)

Application.Run(form)