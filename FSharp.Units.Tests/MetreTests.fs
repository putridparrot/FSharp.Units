namespace FSharp.Units.Tests

module MetreTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Length
    open Helpers

   // metre to X and back

    [<Property>]
    let ``From metre to millimetre and back`` () =
        let property value = 
            let millimetres = m.toMillimetres (m.create value)
            let metres = mm.toMetres millimetres

            metres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From metre to centimetre and back`` () =
        let property value = 
            let centimetres = m.toCentimetres (m.create value)
            let metres = cm.toMetres centimetres

            metres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From metre to kilometre and back`` () =
        let property value = 
            let kilometres = m.toKilometres(m.create value)
            let metres = km.toMetres kilometres

            metres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From metre to inch and back`` () =
        let property value = 
            let inches = m.toInches(m.create value)
            let metres = inch.toMetres inches

            metres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From metre to feet and back`` () =
        let property value = 
            let feet = m.toFeet(m.create value)
            let metres = ft.toMetres feet

            metres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From metre to yards and back`` () =
        let property value = 
            let yards = m.toYards (m.create value)
            let metres = yard.toMetres yards

            metres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From metre to miles and back`` () =
        let property value = 
            let miles = m.toMiles (m.create value)
            let metres = mile.toMetres miles

            metres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From metre to nautical miles and back`` () =
        let property value = 
            let nauticalmiles = m.toNauticalMiles (m.create value)
            let metres = NM.toMetres nauticalmiles

            metres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.<m>, 123000.)>]
    let ``Convert known metre to millimetre`` (input, expectation) =
        m.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(123.<m>, 12300.)>]
    let ``Convert known metre to centimetre`` (input, expectation) =
        m.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1025.<m>, 1.025)>]
    let ``Convert known metre to kilometre`` (input, expectation) =
        m.toKilometres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3.1242<m>, 123.)>]
    let ``Convert known metre to inch`` (input, expectation) =
        m.toInches input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.<m>, 39.37007874)>]
    let ``Convert known metre to feet`` (input, expectation) =
        m.toFeet input
        |> should (equalWithin 0.01) expectation

    [<TestCase(24.<m>, 26.24671916)>]
    let ``Convert known metre to yard`` (input, expectation) =
        m.toYards input
        |> should (equalWithin 0.01) expectation

    [<TestCase(10460.736<m>, 6.5)>]
    let ``Convert known metre to mile`` (input, expectation) =
        m.toMiles input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1234.<m>, 0.6663067)>]
    let ``Convert known metre to nauticalmile`` (input, expectation) =
        m.toNauticalMiles input
        |> should (equalWithin 0.01) expectation
