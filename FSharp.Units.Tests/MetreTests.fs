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

    [<Test>]
    let ``Convert known metre to millimetre`` () =
        let millimetres = m.toMillimetres 123.<m>

        millimetres
        |> should (equalWithin 0.01) 123000.

    [<Test>]
    let ``Convert known metre to centimetre`` () =
        let centimetres = m.toCentimetres 123.<m>

        centimetres
        |> should (equalWithin 0.01) 12300.

    [<Test>]
    let ``Convert known metre to kilometre`` () =
        let kilometres = m.toKilometres 1025.<m>

        kilometres
        |> should (equalWithin 0.01) 1.025

    [<Test>]
    let ``Convert known metre to inch`` () =
        let inches = m.toInches 3.1242<m>

        inches
        |> should (equalWithin 0.01) 123.

    [<Test>]
    let ``Convert known metre to feet`` () =
        let f = m.toFeet 12.<m>

        f
        |> should (equalWithin 0.01) 39.37007874

    [<Test>]
    let ``Convert known metre to yard`` () =
        let yards = m.toYards 24.<m>

        yards
        |> should (equalWithin 0.01) 26.24671916

    [<Test>]
    let ``Convert known metre to mile`` () =
        let miles = m.toMiles 10460.736<m>

        miles
        |> should (equalWithin 0.01) 6.5

    [<Test>]
    let ``Convert known metre to nauticalmile`` () =
        let nauticalmiles = m.toNauticalMiles 1234.<m>

        nauticalmiles
        |> should (equalWithin 0.01) 0.6663067
