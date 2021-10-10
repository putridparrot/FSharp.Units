namespace FSharp.Units.Tests

module CentimetreTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Length
    open Helpers

   // centimetre to X and back

    [<Property>]
    let ``From centimetre to millimetre and back`` () =
        let property value = 
            let millimetres = cm.toMillimetres (cm.create value)
            let centimetres = mm.toCentimetres millimetres

            centimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From centimetre to metre and back`` () =
        let property value = 
            let metres = cm.toMetres (cm.create value)
            let centimetres = m.toCentimetres metres

            centimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From centimetre to kilometre and back`` () =
        let property value = 
            let kilometres = cm.toKilometres (cm.create value)
            let centimetres = km.toCentimetres kilometres

            centimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From centimetre to inch and back`` () =
        let property value = 
            let inches = cm.toInches (cm.create value)
            let centimetres = inch.toCentimetres inches

            centimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From centimetre to feet and back`` () =
        let property value = 
            let f = cm.toFeet (cm.create value)
            let centimetres = ft.toCentimetres f

            centimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From centimetre to yard and back`` () =
        let property value = 
            let yards = cm.toYards (cm.create value)
            let centimetres = yard.toCentimetres yards

            centimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From centimetre to miles and back`` () =
        let property value = 
            let miles = cm.toMiles (cm.create value)
            let centimetres = mile.toCentimetres miles

            centimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From centimetre to nautical miles and back`` () =
        let property value = 
            let nauticalmiles = cm.toNauticalMiles (cm.create value)
            let centimetres = NM.toCentimetres nauticalmiles

            centimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.3<cm>, 123)>]
    let ``Convert known centimetre to millimetre`` (input, expectation) =
        cm.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.3<cm>, 0.123)>]
    let ``Convert known centimetre to metre`` (input, expectation) =
        cm.toMetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(142.24<cm>, 56.)>]
    let ``Convert known centimetre to inch`` (input, expectation) =
        cm.toInches input
        |> should (equalWithin 0.01) expectation

    [<TestCase(456.<cm>, 14.96062992)>]
    let ``Convert known centimetre to feet`` (input, expectation) =
        cm.toFeet input
        |> should (equalWithin 0.01) expectation

    [<TestCase(567.<cm>, 6.2007874)>]
    let ``Convert known centimetre to yard`` (input, expectation) =
        cm.toYards input
        |> should (equalWithin 0.01) expectation

    [<TestCase(67880.<cm>, 0.42178677)>]
    let ``Convert known centimetre to mile`` (input, expectation) =
        cm.toMiles input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1200000.<cm>, 6.479481641)>]
    let ``Convert known centimetre to nauticalmile`` (input, expectation) =
        cm.toNauticalMiles input
        |> should (equalWithin 0.01) expectation
