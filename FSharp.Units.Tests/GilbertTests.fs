namespace FSharp.Units.Tests

module GilbertTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.MagnetomotiveForce
    open Helpers
       
    // AT to X and back

    [<Property>]
    let ``From Gi to AT and back`` () =
        let property value = 
            let at = Gi.toAmpereTurn (Gi.create value)
            let gi = AT.toGilbert at

            gi
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Gilbert to Ampere turn`` () =
        let at = Gi.toAmpereTurn 6000.<Gi>

        at
        |> should equal 4774.648292757