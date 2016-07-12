// F# の詳細については、http://fsharp.org を参照してください
// 詳細については、'F# チュートリアル' プロジェクトを参照してください。

open System 
open System.Windows.Forms 
open System.Drawing 

module Map = 
    let BombsMap =
        let BombsCount = 10
        let MapHigh = 10
        let MapWidth = 10
        let rand = System.Random()

        let rec generateBombs n col =
            if Set.count col = n
            then col
            else generateBombs n (Set.add (rand.Next(MapHigh), rand.Next(MapWidth)) col)

        generateBombs BombsCount Set.empty



let form = new Form(Text = "ボタンテスト", Height = 600,Width = 800)


type Square = class
    inherit Button
    val mutable isBomb : Boolean
    val mutable isOpened : Boolean
    val mutable count : int
    new(text, top, left) = {inherit Button(Text = text, Top = top,  Left = left);isBomb = false; isOpened = false; count = 0}

    member x.changeIsBomb input = x.isBomb <- input

end




let array = [|for i in 0..10 -> [|for j in 0..10 -> new Square("OK" , i * 30 , j * 70) |] |]

for i in 0..10 do
    for j in 0..10 do
        array.[i].[j].Click.AddHandler(fun _ _ -> (if array.[i].[j].Text = "OK" then array.[i].[j].Text <- "NG" else array.[i].[j].Text <- "OK") |> ignore)
        form.Controls.Add(array.[i].[j])
    done
done
        


//btn.Click.AddHandler(fun _ _ -> (if btn.Text = "OK" then btn.Text <- "NG" else btn.Text <- "OK") |> ignore)

//form.Controls.Add(btn)

Application.Run(form)



Map.BombsMap |> ignore
