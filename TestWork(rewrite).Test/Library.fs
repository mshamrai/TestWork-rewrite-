namespace TestWork_rewrite_.Test

open NUnit.Framework
open FsUnit
open TestWork_rewrite_

module ``1`` =
    [<Test>]
    let ``say hello Max``() = "Max" |> Say.hello |> should equal "Hello Max"