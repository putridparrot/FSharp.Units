namespace FSharp.Units.Tests

module BarTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Pressure
    open Helpers

    // Bar to X and back

    [<Property>]
    let ``From Bar to Atmosphere and back`` () =
        let property value = 
            let atmospehere = b.toAtmosphere (b.create value)
            let bar = atm.toBar atmospehere

            bar
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Bar to Pascal and back`` () =
        let property value = 
            let pascal = b.toPascal (b.create value)
            let bar = Pa.toBar pascal

            bar
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Bar to Torr and back`` () =
        let property value = 
            let torr = b.toTorr (b.create value)
            let bar = Torr.toBar torr

            bar
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Bar to psi and back`` () =
        let property value = 
            let poundsPerSquareInch = b.toPsi (b.create value)
            let bar = psi.toBar poundsPerSquareInch

            bar
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Bar to Atmospehere`` () =
        let atmosphere = b.toAtmosphere 34.4<b>

        atmosphere
        |> should (equalWithin 0.1) 33.95016

    [<Test>]
    let ``Convert known Bar to Pascal`` () =
        let pascal = b.toPascal 0.67<b>

        pascal
        |> should (equalWithin 0.1) 67000.

    [<Test>]
    let ``Convert known Bar to Torr`` () =
        let torr = b.toTorr 5.<b>

        torr
        |> should (equalWithin 0.1) 3750.31

    [<Test>]
    let ``Convert known Bar to psi`` () =
        let psi = b.toPsi 3.45<b>

        psi
        |> should (equalWithin 0.1) 50.03802