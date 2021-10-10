namespace FSharp.Units.Tests

module PascalTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Pressure
    open Helpers

    // Pascal to X and back

    [<Property>]
    let ``From Pascal to Atmosphere and back`` () =
        let property value = 
            let atmosphere = Pa.toAtmosphere (Pa.create value)
            let pascal = atm.toPascal atmosphere

            pascal 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Pascal to Bar and back`` () =
        let property value = 
            let bar = Pa.toBar (Pa.create value)
            let pascal = b.toPascal bar

            pascal
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Pascal to Torr and back`` () =
        let property value = 
            let torr = Pa.toTorr (Pa.create value)
            let pascal = Torr.toPascal torr

            pascal
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Pascal to psi and back`` () =
        let property value = 
            let poundsPerSqaureInch = Pa.toPsi (Pa.create value)
            let pascal = psi.toPascal poundsPerSqaureInch

            pascal
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2300.<Pa>, 0.02269924)>]
    let ``Convert known Pascal to Atmosphere`` (input, expectation) =
        Pa.toAtmosphere input
        |> should (equalWithin 0.01) expectation

    [<TestCase(6789.<Pa>, 0.06789)>]
    let ``Convert known Pascal to Bar`` (input, expectation) =
        Pa.toBar input
        |> should (equalWithin 0.01) expectation

    [<TestCase(7899.<Pa>, 59.24737)>]
    let ``Convert known Pascal to Torr`` (input, expectation) =
        Pa.toTorr input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1090.<Pa>, 0.1580911)>]
    let ``Convert known Pascal to psi`` (input, expectation) =
        Pa.toPsi input
        |> should (equalWithin 0.01) expectation