open System

let factorial n =  [1..n] |> List.reduce (*)
let modulo a b = a % b
let printLastPart y = printfn "%d %d" ((modulo y 100) / 10) (modulo y 10)
let chooseVersion x = 
    if(x>9) then printfn "0 0" else if(x=0) then printfn "0 1" else printLastPart (factorial x)

Array.iter (fun (a) ->  chooseVersion a) [| for i in 1 .. Console.ReadLine() |>int -> Console.ReadLine() |>int|]