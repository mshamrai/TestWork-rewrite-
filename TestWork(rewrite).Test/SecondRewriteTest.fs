namespace SecondRewriteTest.Test

open NUnit.Framework
open FsUnit

module ``1`` = 
    open SecondRewrite.``1``
    [<Test>]
    let sumOfEvenFibLessOfBillion () = 
        sumOfLessBillionEvenFib |> should equal 2178308I

module ``3`` =
    open SecondRewrite.``3``
    open System
    [<Test>]
    let ``should be true (empty stack)``() = 
        let stack = new Stack<int>()
        stack.IsEmpty |> should equal true
    
    [<Test>]
    let ``should be false (no empty stack)``() = 
        let stack = new Stack<int>()
        stack.Push 10
        stack.IsEmpty |> should equal false
    
    [<Test>]
    let ``should fail (empty stack)``() = 
        let stack = new Stack<int>()
        (fun () -> stack.Pop |> ignore) |> should throw typeof<InvalidOperationException>
    
    [<Test>]
    let ``should pop 10``() = 
        let stack = new Stack<int>()
        stack.Push 10
        stack.Pop |> should equal 10

    [<Test>]
    let ``should pop 2``() = 
        let stack = new Stack<int>()
        stack.Push 10
        stack.Push 2
        stack.Push 2
        stack.Pop |> should equal 2
    
