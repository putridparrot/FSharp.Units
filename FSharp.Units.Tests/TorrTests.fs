namespace FSharp.Units.Tests

module TorrTests =

    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit.Xunit
    open FSharp.Units.Pressure
    open Helpers

    // Torr to X and back

    [<Property>]
    let ``From Torr to Atmosphere and back`` () =
        let property value = 
            let atmosphere = Torr.toAtmosphere (Torr.create value)
            let torr = atm.toTorr atmosphere

            torr 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Torr to Pascal and back`` () =
        let property value = 
            let pascal = Torr.toPascal (Torr.create value)
            let torr = Pa.toTorr pascal

            torr 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Torr to Bar and back`` () =
        let property value = 
            let bar = Torr.toBar (Torr.create value)
            let torr = b.toTorr bar

            torr 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Torr to Psi and back`` () =
        let property value = 
            let poundsPerSquareInch = Torr.toPsi (Torr.create value)
            let torr = psi.toTorr poundsPerSquareInch

            torr 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known Torr to Pascal`` () =
        let pascal = Torr.toPascal 1.34<Torr>

        pascal
        |> should (equalWithin 0.1) 178.652

    [<Fact>]
    let ``Convert known Torr to Atmosphere`` () =
        let atmosphere = Torr.toAtmosphere 9002.<Torr>

        atmosphere
        |> should (equalWithin 0.1) 11.84474

    [<Fact>]
    let ``Convert known Torr to Bar`` () =
        let bar = Torr.toBar 4567.<Torr>

        bar
        |> should (equalWithin 0.1) 6.088833

    [<Fact>]
    let ``Convert known Torr to Psi`` () =
        let poundsPerSquareInch = Torr.toPsi 1901.<Torr>

        poundsPerSquareInch
        |> should (equalWithin 0.1) 36.75921
