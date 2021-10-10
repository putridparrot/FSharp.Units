namespace FSharp.Units.Tests

module NauticalMileTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Length
    open Helpers

   // NM to X and back

    [<Property>]
    let ``From nautical miles to millimetre and back`` () =
        let property value = 
            let millimetres = NM.toMillimetres (NM.create value)
            let nauticalmiles = mm.toNauticalMiles millimetres

            nauticalmiles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From nautical miles to centimetre and back`` () =
        let property value = 
            let centimetres = NM.toCentimetres (NM.create value)
            let nauticalmiles = cm.toNauticalMiles centimetres

            nauticalmiles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From nautical miles to kilometre and back`` () =
        let property value = 
            let kilometres = NM.toKilometres (NM.create value)
            let nauticalmiles = km.toNauticalMiles kilometres

            nauticalmiles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From nautical miles to inches and back`` () =
        let property value = 
            let inches = NM.toInches (NM.create value)
            let nauticalmiles = inch.toNauticalMiles inches

            nauticalmiles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From nautical miles to feet and back`` () =
        let property value = 
            let f = NM.toFeet (NM.create value)
            let nauticalmiles = ft.toNauticalMiles f

            nauticalmiles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From nautical miles to yard and back`` () =
        let property value = 
            let yards = NM.toYards (NM.create value)
            let nauticalmiles = yard.toNauticalMiles yards

            nauticalmiles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From nautical miles to miles and back`` () =
        let property value = 
            let miles = NM.toMiles (NM.create value)
            let nauticalmiles = mile.toNauticalMiles miles

            nauticalmiles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.1<NM>, 185200.)>]
    let ``Convert known nautical miles to millimetre`` (input, expectation) =
        NM.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.7<NM>, 129640.)>]
    let ``Convert known nautical miles to centimetre`` (input, expectation) =
        NM.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(2.3<NM>, 4259.6)>]
    let ``Convert known nautical miles to metre`` (input, expectation) =
        NM.toMetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1.45<NM>, 2.6854)>]
    let ``Convert known nautical miles to kilometre`` (input, expectation) =
        NM.toKilometres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.2<NM>, 14582.68)>]
    let ``Convert known nautical miles to inch`` (input, expectation) =
        NM.toInches input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.9<NM>, 1822.83)>]
    let ``Convert known nautical miles to yard`` (input, expectation) =
        NM.toYards input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.7<NM>, 4253.28)>]
    let ``Convert known nautical miles to feet`` (input, expectation) =
        NM.toFeet input
        |> should (equalWithin 0.01) expectation

    [<TestCase(22.8<NM>, 26.23777)>]
    let ``Convert known nautical miles to miles`` (input, expectation) =
        NM.toMiles input
        |> should (equalWithin 0.01) expectation
