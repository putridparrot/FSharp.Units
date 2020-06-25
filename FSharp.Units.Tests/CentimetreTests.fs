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
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From centimetre to metre and back`` () =
        let property value = 
            let metres = cm.toMetres (cm.create value)
            let centimetres = m.toCentimetres metres

            centimetres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From centimetre to kilometre and back`` () =
        let property value = 
            let kilometres = cm.toKilometres (cm.create value)
            let centimetres = km.toCentimetres kilometres

            centimetres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From centimetre to inch and back`` () =
        let property value = 
            let inches = cm.toInches (cm.create value)
            let centimetres = inch.toCentimetres inches

            centimetres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From centimetre to feet and back`` () =
        let property value = 
            let f = cm.toFeet (cm.create value)
            let centimetres = ft.toCentimetres f

            centimetres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From centimetre to yard and back`` () =
        let property value = 
            let yards = cm.toYards (cm.create value)
            let centimetres = yard.toCentimetres yards

            centimetres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From centimetre to miles and back`` () =
        let property value = 
            let miles = cm.toMiles (cm.create value)
            let centimetres = mile.toCentimetres miles

            centimetres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From centimetre to nautical miles and back`` () =
        let property value = 
            let nauticalmiles = cm.toNauticalMiles (cm.create value)
            let centimetres = NM.toCentimetres nauticalmiles

            centimetres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known centimetre to millimetre`` () =
        let millimetres = cm.toMillimetres 12.3<cm>

        millimetres
        |> should (equalWithin 0.1) 123

    [<Test>]
    let ``Convert known centimetre to metre`` () =
        let metres = cm.toMetres 12.3<cm>

        metres
        |> should (equalWithin 0.1) 0.123

    [<Test>]
    let ``Convert known centimetre to inch`` () =
        let inches = cm.toInches 142.24<cm>

        inches
        |> should (equalWithin 0.1) 56

    [<Test>]
    let ``Convert known centimetre to feet`` () =
        let ft = cm.toFeet 456.<cm>

        ft
        |> should (equalWithin 0.1) 14.96062992

    [<Test>]
    let ``Convert known centimetre to yard`` () =
        let yards = cm.toYards 567.<cm>

        yards
        |> should (equalWithin 0.1) 6.2007874

    [<Test>]
    let ``Convert known centimetre to mile`` () =
        let miles = cm.toMiles 67880.<cm>

        miles
        |> should (equalWithin 0.1) 0.42178677

    [<Test>]
    let ``Convert known centimetre to nauticalmile`` () =
        let inches = cm.toNauticalMiles 1200000.<cm>

        inches
        |> should (equalWithin 0.1) 6.479481641
