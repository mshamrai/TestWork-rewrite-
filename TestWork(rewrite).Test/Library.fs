namespace TestWork_rewrite_.Test

open NUnit.Framework
open FsUnit
open TestWork_rewrite_

module ``1`` =
    open TestWork_rewrite_.``1``

    [<Test>]
    let ``should be [sin 1, cos 1, sin 2, cos 2, sin 3, cos 3]``() =   (psevdoMap [1.; 2.; 3.] [sin; cos])  |> should equal [0.8414709848078965; 0.90929742682568171; 0.14112000805986721; 0.54030230586813977; -0.41614683654714241; -0.98999249660044542]



module ``2`` =
    open TestWork_rewrite_.``2``

    [<Test>]
    let ``should print square  with length 4``() = 
        let square = "****\n*  *\n*  *\n****\n"
        4 |> printSquare |> should equal square