namespace TestWork_rewrite_

module ``1`` =
    
    let psevdoMap l lf =
        let f h = List.map h l
        let rec map acc list = 
            match list with
            | h :: t -> map (acc @ (f h)) t
            | _ -> acc
        map [] lf

module ``2`` = 
    
    let printSquare length = 
        let print = "*" 
        let newLine = "\n"
        let backspace = " "
        let (^) l r = sprintf "%s%s" l r
        let rec printS acc x y =
            
            match x with
            | _ when x < length && (y = 0 || y = length - 1) -> printS (acc ^ print) (x + 1) y
            | _ when x = length -> printS (acc ^ newLine) 0 (y + 1)
            | _ when x = 0 && y > 0 && y < length -> printS (acc ^ print) (x + 1) y
            | _ when x < length - 1 && y > 0 && y < length -> printS (acc ^ backspace) (x + 1) y
            | _ when x = length - 1 && y < length -> printS (acc ^ print) (x + 1) y
            | _ -> acc

        printS "" 0 0

module ``3`` =
    open System.Collections.Generic
    open System.Linq

    [<AllowNullLiteral>]
    type Linked<'a>(value) =
        
        member val Value : 'a = value with get, set

        member val Next : Linked<'a> = null with get, set
        
        


    type Queue<'a>() =
        let queue : Dictionary<int, Linked<'a>> = new Dictionary<int, Linked<'a>>()

        let highPriority : int = queue.Keys.Max()        

        let getTail (elem : Linked<'a>) =
            let rec get tail = if elem.Next <> null then get elem.Next else tail 
            get elem
        

        member this.Enqueue (elem : 'a) priority = if queue.ContainsKey(priority) then (getTail queue.[priority]).Next <- new Linked<'a>(elem) 
                                                   else queue.Add(priority, new Linked<'a>(elem))

        member this.Dequeue = 
            let elem = getTail queue.[highPriority]
            //time....
            