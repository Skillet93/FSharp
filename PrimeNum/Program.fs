open System
let isprime n =
        let rec check i =
            i > n/2 || (n % i <> 0 && check (i + 1))
        check 2
let printIfPrime x =
        if(x <> 1 && isprime x) then printfn "TAK" else printfn "NIE"
        
Array.iter (fun (a) ->  printIfPrime a) [| for i in 1 .. Console.ReadLine() |>int -> Console.ReadLine() |>int|]