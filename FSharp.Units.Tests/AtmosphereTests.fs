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


    [<Test>]
    let ``Convert known Atmosphere to Bar`` () =
        let bar = atm.toBar 940.<atm>

        bar
        |> should (equalWithin 0.01) 952.455

    [<Test>]
    let ``Convert known Atmosphere to Pascal`` () =
        let pascals = atm.toPascal 2.3<atm>

        pascals
        |> should (equalWithin 0.01) 233047.5

    [<Test>]
    let ``Convert known Atmosphere to Torr`` () =
        let torr = atm.toTorr 98.<atm>

        torr
        |> should (equalWithin 0.01) 74480.

    [<Test>]
    let ``Convert known Atmosphere to psi`` () =
        let psi = atm.toPsi 12.6<atm>

        psi
        |> should (equalWithin 0.01) 185.169