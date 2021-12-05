namespace FSharp.Units.Tests

module TorrTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Pressure
    open Helpers

    // Torr to X and back

    [<Property>]
    let ``From Torr to Atmosphere and back`` () =
        let property value = 
            let atmosphere = Torr.toAtmosphere (Torr.create value)
            let torr = atm.toTorr atmosphere

            torr 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Torr to Pascal and back`` () =
        let property value = 
            let pascal = Torr.toPascal (Torr.create value)
            let torr = Pa.toTorr pascal

            torr 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Torr to Bar and back`` () =
        let property value = 
            let bar = Torr.toBar (Torr.create value)
            let torr = b.toTorr bar

            torr 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Torr to Psi and back`` () =
        let property value = 
            let poundsPerSquareInch = Torr.toPsi (Torr.create value)
            let torr = psi.toTorr poundsPerSquareInch

            torr 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(88.7<Torr>, 11825.69)>]
    [<TestCase(0.08<Torr>, 10.66579)>]
    [<TestCase(1.34<Torr>, 178.652)>]
    let ``Convert known Torr to Pascal`` (input, expectation) =
        Torr.toPascal input
        |> should (equalWithin 0.01) expectation

    [<TestCase(899.<Torr>, 1.18289)>]
    [<TestCase(553.<Torr>, 0.727632)>]
    [<TestCase(9002.<Torr>, 11.84474)>]
    let ``Convert known Torr to Atmosphere`` (input, expectation) =
        Torr.toAtmosphere input
        |> should (equalWithin 0.01) expectation

    [<TestCase(890.<Torr>, 1.18657)>]
    [<TestCase(6789.<Torr>, 9.051256)>]
    [<TestCase(4567.<Torr>, 6.088833)>]
    let ``Convert known Torr to Bar`` (input, expectation) =
        Torr.toBar input
        |> should (equalWithin 0.01) expectation

    [<TestCase(800.<Torr>, 15.4694)>]
    [<TestCase(66.<Torr>, 1.27623)>]
    [<TestCase(1901.<Torr>, 36.75921)>]
    let ``Convert known Torr to Psi`` (input, expectation) =
        Torr.toPsi input
        |> should (equalWithin 0.01) expectation
