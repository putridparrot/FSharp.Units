namespace FSharp.Units.Tests

module KilometreTests =

    open System
    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit
    open FsUnit.Xunit
    open FSharp.Units
    open FSharp.Units.Length
    open Helpers

   // metre to X and back

    [<Property>]
    let ``From kilometre to millimetre and back`` () =
        let property value = 
            let millimetres = km.toMillimetres (km.create value)
            let kilometres = mm.toKilometres millimetres

            kilometres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilometre to centimetre and back`` () =
        let property value = 
            let centimetres = km.toCentimetres (km.create value)
            let kilometres = cm.toKilometres centimetres

            kilometres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilometre to metre and back`` () =
        let property value = 
            let metres = km.toMetres (km.create value)
            let kilometres = m.toKilometres metres

            kilometres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilometre to inch and back`` () =
        let property value = 
            let inches = km.toInches (km.create value)
            let kilometres = inch.toKilometres inches

            kilometres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilometre to feet and back`` () =
        let property value = 
            let feet = km.toFeet (km.create value)
            let kilometres = ft.toKilometres feet

            kilometres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilometre to yards and back`` () =
        let property value = 
            let yards = km.toYards (km.create value)
            let kilometres = yard.toKilometres yards

            kilometres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilometre to miles and back`` () =
        let property value = 
            let miles = km.toMiles (km.create value)
            let kilometres = mile.toKilometres miles

            kilometres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilometre to nautical miles and back`` () =
        let property value = 
            let nauticalmiles = km.toNauticalMiles (km.create value)
            let kilometres = NM.toKilometres nauticalmiles

            kilometres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known kilometre to millimetre`` () =
        let millimetres = km.toMillimetres 2.3<km>

        millimetres
        |> should (equalWithin 0.1) 2300000.

    [<Fact>]
    let ``Convert known kilometre to centimetre`` () =
        let centimetres = km.toCentimetres 1.5<km>

        centimetres
        |> should (equalWithin 0.1) 150000.

    [<Fact>]
    let ``Convert known kilometre to metre`` () =
        let metres = km.toMetres 1.025<km>

        metres
        |> should (equalWithin 0.1) 1025.

    [<Fact>]
    let ``Convert known kilometre to inch`` () =
        let inches = km.toInches 0.0480314<km>

        inches
        |> should (equalWithin 0.1) 1891.

    [<Fact>]
    let ``Convert known kilometre to feet`` () =
        let feet = km.toFeet 0.0480314<km>

        feet
        |> should (equalWithin 0.1) 157.58333333

    [<Fact>]
    let ``Convert known kilometre to yards`` () =
        let yards = km.toYards 43.<km>

        yards
        |> should (equalWithin 0.1) 47025.37182852

    [<Fact>]
    let ``Convert known kilometre to mile`` () =
        let miles = km.toMiles 123.<km>

        miles
        |> should (equalWithin 0.1) 76.42865665

    [<Fact>]
    let ``Convert known kilometre to nautical mile`` () =
        let miles = km.toNauticalMiles 800.<km>

        miles
        |> should (equalWithin 0.1) 431.965
