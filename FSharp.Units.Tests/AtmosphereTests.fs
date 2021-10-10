namespace FSharp.Units.Tests

module AtmosphereTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Pressure
    open Helpers

    // Atmosphere to X and back

    [<Property>]
    let ``From Atmosphere to Bar and back`` () =
        let property value = 
            let bar = atm.toBar (atm.create value)
            let atmospehere = b.toAtmosphere bar

            atmospehere 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Atmosphere to Pascal and back`` () =
        let property value = 
            let pascal = atm.toPascal (atm.create value)
            let atmospehere = Pa.toAtmosphere pascal

            atmospehere 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Atmosphere to Torr and back`` () =
        let property value = 
            let torr = atm.toTorr (atm.create value)
            let atmospehere = Torr.toAtmosphere torr

            atmospehere 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Atmosphere to psi and back`` () =
        let property value = 
            let poundsPerSquareInch = atm.toPsi (atm.create value)
            let atmospehere = psi.toAtmosphere poundsPerSquareInch

            atmospehere
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)


    [<TestCase(940.<atm>, 952.455)>]
    let ``Convert known Atmosphere to Bar`` (input, expectation) =
        atm.toBar input
        |> should (equalWithin 0.01) expectation

    [<TestCase(2.3<atm>, 233047.5)>]
    let ``Convert known Atmosphere to Pascal`` (input, expectation) =
        atm.toPascal input
        |> should (equalWithin 0.01) expectation

    [<TestCase(98.<atm>, 74480.)>]
    let ``Convert known Atmosphere to Torr`` (input, expectation) =
        atm.toTorr input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.6<atm>, 185.169)>]
    let ``Convert known Atmosphere to psi`` (input, expectation) =
        atm.toPsi input
        |> should (equalWithin 0.01) expectation