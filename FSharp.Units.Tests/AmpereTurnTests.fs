namespace FSharp.Units.Tests

module AmpereTurnTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.MagnetomotiveForce
    open Helpers
       
    // AT to X and back

    [<Property>]
    let ``From AT to Gi and back`` () =
        let property value = 
            let gi = AT.toGilbert (AT.create value)
            let at = Gi.toAmpereTurn gi

            at 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(999.<AT>, 1255.380424374)>]
    let ``Convert known Ampere turn to Gilbert`` (input, expectation) =
        AT.toGilbert input
        |> should (equalWithin 0.0001) expectation