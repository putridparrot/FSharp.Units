namespace FSharp.Units.Tests

module PsiTests =

    open System
    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit
    open FsUnit.Xunit
    open FSharp.Units
    open FSharp.Units.Pressure
    open Helpers

    // psi to X and back

    [<Property>]
    let ``From psi to Atmosphere and back`` () =
        let property value = 
            let atmosphere = psi.toAtmosphere (psi.create value)
            let poundsPerSquareInch = atm.toPsi atmosphere

            poundsPerSquareInch 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From psi to Bar and back`` () =
        let property value = 
            let bar = psi.toBar (psi.create value)
            let poundsPerSquareInch = b.toPsi bar

            poundsPerSquareInch 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From psi to Torr and back`` () =
        let property value = 
            let torr = psi.toTorr (psi.create value)
            let poundsPerSquareInch = Torr.toPsi torr

            poundsPerSquareInch 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From psi to Pascal and back`` () =
        let property value = 
            let pascal = psi.toPascal (psi.create value)
            let poundsPerSquareInch = Pa.toPsi pascal

            poundsPerSquareInch 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known Psi to Bar`` () =
        let bar = psi.toBar 121.<psi>

        bar
        |> should (equalWithin 0.1) 8.34266

    [<Fact>]
    let ``Convert known Psi to Atmosphere`` () =
        let atmosphere = psi.toAtmosphere 345.<psi>

        atmosphere
        |> should (equalWithin 0.1) 23.4759

    [<Fact>]
    let ``Convert known Psi to Pascal`` () =
        let pascal = psi.toPascal 5.6<psi>

        pascal
        |> should (equalWithin 0.1) 38610.6

    [<Fact>]
    let ``Convert known Psi to Torr`` () =
        let torr = psi.toTorr 1.34<psi>

        torr
        |> should (equalWithin 0.1) 69.29801
