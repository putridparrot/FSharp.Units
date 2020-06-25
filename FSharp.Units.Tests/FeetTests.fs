namespace FSharp.Units.Tests

module FeetTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Length
    open Helpers

   // feet to X and back

    [<Property>]
    let ``From feet to millimetre and back`` () =
        let property value = 
            let millimetres = ft.toMillimetres (ft.create value)
            let feet = mm.toFeet millimetres

            feet
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From feet to centimetre and back`` () =
        let property value = 
            let centimetres = ft.toCentimetres (ft.create value)
            let feet = cm.toFeet centimetres

            feet
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From feet to metre and back`` () =
        let property value = 
            let metres = ft.toMetres (ft.create value)
            let feet = m.toFeet metres

            feet
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From feet to kilometre and back`` () =
        let property value = 
            let kilometres = ft.toKilometres (ft.create value)
            let feet = km.toFeet kilometres

            feet
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From feet to inches and back`` () =
        let property value = 
            let inches = ft.toInches (ft.create value)
            let feet = inch.toFeet inches

            feet
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From feet to yards and back`` () =
        let property value = 
            let yards = ft.toYards (ft.create value)
            let feet = yard.toFeet yards

            feet
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From feet to miles and back`` () =
        let property value = 
            let miles = ft.toMiles (ft.create value)
            let feet = mile.toFeet miles

            feet
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From feet to nautical miles and back`` () =
        let property value = 
            let nauticalmiles = ft.toNauticalMiles (ft.create value)
            let feet = NM.toFeet nauticalmiles

            feet
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known feet to millimetre`` () =
        let millimetres = ft.toMillimetres 1.4<ft>

        millimetres
        |> should (equalWithin 0.1) 426.72

    [<Test>]
    let ``Convert known feet to centimetre`` () =
        let centimetres = ft.toCentimetres 5.8<ft>

        centimetres
        |> should (equalWithin 0.1) 176.784

    [<Test>]
    let ``Convert known feet to metre`` () =
        let metres = ft.toMetres 13.<ft>

        metres
        |> should (equalWithin 0.1) 3.9624

    [<Test>]
    let ``Convert known feet to kilometre`` () =
        let kilometres = ft.toKilometres 1234.<ft>

        kilometres
        |> should (equalWithin 0.1) 0.3761232

    [<Test>]
    let ``Convert known feet to inches`` () =
        let inches = ft.toInches 23.<ft>

        inches
        |> should (equalWithin 0.1) 276.

    [<Test>]
    let ``Convert known feet to yards`` () =
        let yards = ft.toYards 23.<ft>

        yards
        |> should (equalWithin 0.1) 7.66666667

    [<Test>]
    let ``Convert known feet to miles`` () =
        let miles = ft.toMiles 2345.<ft>

        miles
        |> should (equalWithin 0.1) 0.44412879

    [<Test>]
    let ``Convert known feet to nautical miles`` () =
        let nauticalmiles = ft.toNauticalMiles 8912.<ft>

        nauticalmiles
        |> should (equalWithin 0.1) 1.466727
