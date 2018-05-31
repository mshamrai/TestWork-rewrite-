namespace SecondRewrite

module ``1`` =
    let sumOfLessBillionEvenFib = 
        let infiniteFibSeq = 
            let nextFib prevFib prevprevFib = 
                prevFib + prevprevFib
            let rec fibSeq prevNumber number = 
                seq { yield prevNumber
                      yield number
                      yield! nextFib number prevNumber |> fibSeq number }
            fibSeq 0I 1I
        infiniteFibSeq |> Seq.takeWhile (fun x -> x < 1000000I) |> Seq.where (fun x -> x % 2I = 0I) |> Seq.sum

module ``3`` =
    open System
    type Stack<'a>() =
        let mutable elems = []
        member this.Push (elem : 'a) = 
            elems <- elem :: elems
        member this.Pop =
            match elems with
            | h :: t -> elems <- t
                        h
            | [] -> raise (InvalidOperationException())
        member this.IsEmpty = 
            match elems with
            | [] -> true
            | _ -> false