namespace SecondRewriteTest.Test

open NUnit.Framework
open FsUnit

module ``1`` = 
    open SecondRewrite.``1``
    [<Test>]
    let sumOfEvenFibLessOfBillion () = 
        sumOfLessBillionEvenFib |> should equal 2178308I