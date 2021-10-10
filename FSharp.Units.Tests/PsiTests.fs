namespace FSharp.Units.Tests

module PsiTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Pressure
    open Helpers

    // psi to X and back

    [<Property>]
    let ``From psi to Atmosphere and back`` () =
        let property value = 
            let atmosphere = psi.toAtmosphere (psi.create value)
            let poundsPerSquareInch = atm.toPsi atmosphere

            poundsPerSquareInch 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From psi to Bar and back`` () =
        let property value = 
            let bar = psi.toBar (psi.create value)
            let poundsPerSquareInch = b.toPsi bar

            poundsPerSquareInch 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From psi to Torr and back`` () =
        let property value = 
            let torr = psi.toTorr (psi.create value)
            let poundsPerSquareInch = Torr.toPsi torr

            poundsPerSquareInch 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From psi to Pascal and back`` () =
        let property value = 
            let pascal = psi.toPascal (psi.create value)
            let poundsPerSquareInch = Pa.toPsi pascal

            poundsPerSquareInch 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(121.<psi>, 8.34266)>]
    let ``Convert known Psi to Bar`` (input, expectation) =
        psi.toBar input
        |> should (equalWithin 0.01) expectation

    [<TestCase(345.<psi>, 23.4759)>]
    let ``Convert known Psi to Atmosphere`` (input, expectation) =
        psi.toAtmosphere input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5.6<psi>, 38610.6)>]
    let ``Convert known Psi to Pascal`` (input, expectation) =
        psi.toPascal input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1.34<psi>, 69.29801)>]
    let ``Convert known Psi to Torr`` (input, expectation) =
        psi.toTorr input
        |> should (equalWithin 0.01) expectation
