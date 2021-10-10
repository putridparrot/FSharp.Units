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
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Bar to Pascal and back`` () =
        let property value = 
            let pascal = b.toPascal (b.create value)
            let bar = Pa.toBar pascal

            bar
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Bar to Torr and back`` () =
        let property value = 
            let torr = b.toTorr (b.create value)
            let bar = Torr.toBar torr

            bar
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Bar to psi and back`` () =
        let property value = 
            let poundsPerSquareInch = b.toPsi (b.create value)
            let bar = psi.toBar poundsPerSquareInch

            bar
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(34.4<b>, 33.95016)>]
    let ``Convert known Bar to Atmospehere`` (input, expectation) =
        b.toAtmosphere input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.67<b>, 67000.)>]
    let ``Convert known Bar to Pascal`` (input, expectation) =
        b.toPascal input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5.<b>, 3750.31)>]
    let ``Convert known Bar to Torr`` (input, expectation) =
        b.toTorr input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3.45<b>, 50.03802)>]
    let ``Convert known Bar to psi`` (input, expectation) =
        b.toPsi input
        |> should (equalWithin 0.01) expectation