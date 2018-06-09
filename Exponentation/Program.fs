open System
let values = [| [|0|]; [|1|]; [|6;2;4;8|]; [|1;3;9;7|]; [|6;4|]; [|5;|]; [|6;|]; [|1;7;9;3|]; [|6;8;4;2|]; [|1;9|] |]

let printLastDigit a b = printfn "%d" values.[a].[b % values.[a].Length] 

let extractNumbers s =  printLastDigit ((s.ToString().Split(' ').[0] |> int)%10)  (s.ToString().Split(' ').[1] |> int)

Array.iter (fun (a) ->  extractNumbers a) [| for i in 1 .. Console.ReadLine() |>int -> Console.ReadLine()|]