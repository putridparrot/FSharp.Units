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

    [<TestCase(6000.<Gi>, 4774.648292757)>]
    let ``Convert known Gilbert to Ampere turn`` (input, expectation) =
        Gi.toAmpereTurn input
        |> should equal expectation