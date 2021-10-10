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
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From feet to centimetre and back`` () =
        let property value = 
            let centimetres = ft.toCentimetres (ft.create value)
            let feet = cm.toFeet centimetres

            feet
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From feet to metre and back`` () =
        let property value = 
            let metres = ft.toMetres (ft.create value)
            let feet = m.toFeet metres

            feet
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From feet to kilometre and back`` () =
        let property value = 
            let kilometres = ft.toKilometres (ft.create value)
            let feet = km.toFeet kilometres

            feet
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From feet to inches and back`` () =
        let property value = 
            let inches = ft.toInches (ft.create value)
            let feet = inch.toFeet inches

            feet
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From feet to yards and back`` () =
        let property value = 
            let yards = ft.toYards (ft.create value)
            let feet = yard.toFeet yards

            feet
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From feet to miles and back`` () =
        let property value = 
            let miles = ft.toMiles (ft.create value)
            let feet = mile.toFeet miles

            feet
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From feet to nautical miles and back`` () =
        let property value = 
            let nauticalmiles = ft.toNauticalMiles (ft.create value)
            let feet = NM.toFeet nauticalmiles

            feet
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.4<ft>, 426.72)>]
    let ``Convert known feet to millimetre`` (input, expectation) =
        ft.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5.8<ft>, 176.784)>]
    let ``Convert known feet to centimetre`` (input, expectation) =
        ft.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(13.<ft>, 3.9624)>]
    let ``Convert known feet to metre`` (input, expectation) =
        ft.toMetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1234.<ft>, 0.3761232)>]
    let ``Convert known feet to kilometre`` (input, expectation) =
        ft.toKilometres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(23.<ft>, 276.)>]
    let ``Convert known feet to inches`` (input, expectation) =
        ft.toInches input
        |> should (equalWithin 0.01) expectation

    [<TestCase(23.<ft>, 7.66666667)>]
    let ``Convert known feet to yards`` (input, expectation) =
        ft.toYards input
        |> should (equalWithin 0.01) expectation

    [<TestCase(2345.<ft>, 0.44412879)>]
    let ``Convert known feet to miles`` (input, expectation) =
        ft.toMiles input
        |> should (equalWithin 0.01) expectation

    [<TestCase(8912.<ft>, 1.466727)>]
    let ``Convert known feet to nautical miles`` (input, expectation) =
        ft.toNauticalMiles input
        |> should (equalWithin 0.01) expectation
