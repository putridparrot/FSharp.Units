namespace FSharp.Units.Tests

module AmpereTurnTests =

    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit.Xunit
    open FSharp.Units.MagnetomotiveForce
    open Helpers
       
    // AT to X and back

    [<Property>]
    let ``From AT to Gi and back`` () =
        let property value = 
            let gi = AT.toGilbert (AT.create value)
            let at = Gi.toAmpereTurn gi

            at 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known Ampere turn to Gilbert`` () =
        let gi = AT.toGilbert 999.<AT>

        gi
        |> should (equalWithin 0.0001) 1255.380424374