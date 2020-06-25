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
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From nautical miles to centimetre and back`` () =
        let property value = 
            let centimetres = NM.toCentimetres (NM.create value)
            let nauticalmiles = cm.toNauticalMiles centimetres

            nauticalmiles
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From nautical miles to kilometre and back`` () =
        let property value = 
            let kilometres = NM.toKilometres (NM.create value)
            let nauticalmiles = km.toNauticalMiles kilometres

            nauticalmiles
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From nautical miles to inches and back`` () =
        let property value = 
            let inches = NM.toInches (NM.create value)
            let nauticalmiles = inch.toNauticalMiles inches

            nauticalmiles
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From nautical miles to feet and back`` () =
        let property value = 
            let f = NM.toFeet (NM.create value)
            let nauticalmiles = ft.toNauticalMiles f

            nauticalmiles
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From nautical miles to yard and back`` () =
        let property value = 
            let yards = NM.toYards (NM.create value)
            let nauticalmiles = yard.toNauticalMiles yards

            nauticalmiles
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From nautical miles to miles and back`` () =
        let property value = 
            let miles = NM.toMiles (NM.create value)
            let nauticalmiles = mile.toNauticalMiles miles

            nauticalmiles
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known nautical miles to millimetre`` () =
        let millimetres = NM.toMillimetres 0.1<NM>

        millimetres
        |> should (equalWithin 0.1) 185200.

    [<Test>]
    let ``Convert known nautical miles to centimetre`` () =
        let centimetres = NM.toCentimetres 0.7<NM>

        centimetres
        |> should (equalWithin 0.1) 129640

    [<Test>]
    let ``Convert known nautical miles to metre`` () =
        let metres = NM.toMetres 2.3<NM>

        metres
        |> should (equalWithin 0.1) 4259.6

    [<Test>]
    let ``Convert known nautical miles to kilometre`` () =
        let kilometres = NM.toKilometres 1.45<NM>

        kilometres
        |> should (equalWithin 0.1) 2.6854

    [<Test>]
    let ``Convert known nautical miles to inch`` () =
        let inches = NM.toInches 0.2<NM>

        inches
        |> should (equalWithin 0.1) 14582.7

    [<Test>]
    let ``Convert known nautical miles to yard`` () =
        let yards = NM.toYards 0.9<NM>

        yards
        |> should (equalWithin 0.1) 1822.83

    [<Test>]
    let ``Convert known nautical miles to feet`` () =
        let f = NM.toFeet 0.7<NM>

        f
        |> should (equalWithin 0.1) 4253.28

    [<Test>]
    let ``Convert known nautical miles to miles`` () =
        let miles = NM.toMiles 22.8<NM>

        miles
        |> should (equalWithin 0.1) 26.23777
