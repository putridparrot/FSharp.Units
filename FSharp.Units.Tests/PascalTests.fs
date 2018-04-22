namespace FSharp.Units.Tests

module PascalTests =

    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit.Xunit
    open FSharp.Units.Pressure
    open Helpers

    // Pascal to X and back

    [<Property>]
    let ``From Pascal to Atmosphere and back`` () =
        let property value = 
            let atmosphere = Pa.toAtmosphere (Pa.create value)
            let pascal = atm.toPascal atmosphere

            pascal 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Pascal to Bar and back`` () =
        let property value = 
            let bar = Pa.toBar (Pa.create value)
            let pascal = b.toPascal bar

            pascal
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Pascal to Torr and back`` () =
        let property value = 
            let torr = Pa.toTorr (Pa.create value)
            let pascal = Torr.toPascal torr

            pascal
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Pascal to psi and back`` () =
        let property value = 
            let poundsPerSqaureInch = Pa.toPsi (Pa.create value)
            let pascal = psi.toPascal poundsPerSqaureInch

            pascal
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known Pascal to Atmosphere`` () =
        let atmosphere = Pa.toAtmosphere 2300.<Pa>

        atmosphere
        |> should (equalWithin 0.1) 0.02269924

    [<Fact>]
    let ``Convert known Pascal to Bar`` () =
        let bar = Pa.toBar 6789.<Pa>

        bar
        |> should (equalWithin 0.1) 0.06789

    [<Fact>]
    let ``Convert known Pascal to Torr`` () =
        let torr = Pa.toTorr 7899.<Pa>

        torr
        |> should (equalWithin 0.1) 59.24737

    [<Fact>]
    let ``Convert known Pascal to psi`` () =
        let psi = Pa.toPsi 1090.<Pa>

        psi
        |> should (equalWithin 0.1) 0.1580911