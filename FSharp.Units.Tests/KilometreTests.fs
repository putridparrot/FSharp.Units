namespace FSharp.Units.Tests

module KilometreTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Length
    open Helpers

   // metre to X and back

    [<Property>]
    let ``From kilometre to millimetre and back`` () =
        let property value = 
            let millimetres = km.toMillimetres (km.create value)
            let kilometres = mm.toKilometres millimetres

            kilometres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilometre to centimetre and back`` () =
        let property value = 
            let centimetres = km.toCentimetres (km.create value)
            let kilometres = cm.toKilometres centimetres

            kilometres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilometre to metre and back`` () =
        let property value = 
            let metres = km.toMetres (km.create value)
            let kilometres = m.toKilometres metres

            kilometres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilometre to inch and back`` () =
        let property value = 
            let inches = km.toInches (km.create value)
            let kilometres = inch.toKilometres inches

            kilometres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilometre to feet and back`` () =
        let property value = 
            let feet = km.toFeet (km.create value)
            let kilometres = ft.toKilometres feet

            kilometres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilometre to yards and back`` () =
        let property value = 
            let yards = km.toYards (km.create value)
            let kilometres = yard.toKilometres yards

            kilometres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilometre to miles and back`` () =
        let property value = 
            let miles = km.toMiles (km.create value)
            let kilometres = mile.toKilometres miles

            kilometres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilometre to nautical miles and back`` () =
        let property value = 
            let nauticalmiles = km.toNauticalMiles (km.create value)
            let kilometres = NM.toKilometres nauticalmiles

            kilometres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.3<km>, 2300000.)>]
    let ``Convert known kilometre to millimetre`` (input, expectation) =
        km.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1.5<km>, 150000.)>]
    let ``Convert known kilometre to centimetre`` (input, expectation) =
        km.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1.025<km>, 1025.)>]
    let ``Convert known kilometre to metre`` (input, expectation) =
        km.toMetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.0480314<km>, 1891.)>]
    let ``Convert known kilometre to inch`` (input, expectation) =
        km.toInches input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.0480314<km>, 157.58333333)>]
    let ``Convert known kilometre to feet`` (input, expectation) =
        km.toFeet input
        |> should (equalWithin 0.01) expectation

    [<TestCase(43.<km>, 47025.37182852)>]
    let ``Convert known kilometre to yards`` (input, expectation) =
        km.toYards input
        |> should (equalWithin 0.01) expectation

    [<TestCase(123.<km>, 76.42865665)>]
    let ``Convert known kilometre to mile`` (input, expectation) =
        km.toMiles input
        |> should (equalWithin 0.01) expectation

    [<TestCase(800.<km>, 431.965)>]
    let ``Convert known kilometre to nautical mile`` (input, expectation) =
        km.toNauticalMiles input
        |> should (equalWithin 0.01) expectation
