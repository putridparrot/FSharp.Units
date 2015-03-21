namespace FSharp.Units.Tests

module YardTests =

    open System
    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit
    open FsUnit.Xunit
    open FSharp.Units
    open FSharp.Units.Length
    open Helpers

   // yard to X and back

    [<Property>]
    let ``From yard to millimetre and back`` () =
        let property value = 
            let millimetres = yard.toMillimetres (yard.create value)
            let yard = mm.toYards millimetres

            yard
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From yard to centimetre and back`` () =
        let property value = 
            let centimetres = yard.toCentimetres (yard.create value)
            let yard = cm.toYards centimetres

            yard
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From yard to metre and back`` () =
        let property value = 
            let metres = yard.toMetres (yard.create value)
            let yard = m.toYards metres

            yard
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From yard to kilometre and back`` () =
        let property value = 
            let kilometres = yard.toKilometres (yard.create value)
            let yard = km.toYards kilometres

            yard
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From yard to inch and back`` () =
        let property value = 
            let inches = yard.toInches (yard.create value)
            let yard = inch.toYards inches

            yard
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From yard to feet and back`` () =
        let property value = 
            let feet = yard.toFeet (yard.create value)
            let yard = ft.toYards feet

            yard
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From yard to miles and back`` () =
        let property value = 
            let miles = yard.toMiles (yard.create value)
            let yard = mile.toYards miles

            yard
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From yard to nautical miles and back`` () =
        let property value = 
            let nauticalmiles = yard.toNauticalMiles (yard.create value)
            let yard = NM.toYards nauticalmiles

            yard
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known yard to millimetre`` () =
        let millimetres = yard.toMillimetres 34.<yard>

        millimetres
        |> should (equalWithin 0.1) 31089.6

    [<Fact>]
    let ``Convert known yard to centimetre`` () =
        let centimetres = yard.toCentimetres 23.<yard>

        centimetres
        |> should (equalWithin 0.1) 2103.12

    [<Fact>]
    let ``Convert known yard to metre`` () =
        let metres = yard.toMetres 23.<yard>

        metres
        |> should (equalWithin 0.1) 21.0312

    [<Fact>]
    let ``Convert known yard to kilometre`` () =
        let kilometres = yard.toKilometres 1200.<yard>

        kilometres
        |> should (equalWithin 0.1) 1.09728

    [<Fact>]
    let ``Convert known yard to inch`` () =
        let inches = yard.toInches 12.<yard>

        inches
        |> should (equalWithin 0.1) 432.

    [<Fact>]
    let ``Convert known yard to feet`` () =
        let f = yard.toFeet 23.<yard>

        f
        |> should (equalWithin 0.1) 69.

    [<Fact>]
    let ``Convert known yard to mile`` () =
        let miles = yard.toMiles 1245.<yard>

        miles
        |> should (equalWithin 0.1) 0.70738636

    [<Fact>]
    let ``Convert known yard to nautical mile`` () =
        let nauticalmiles = yard.toNauticalMiles 7000.<yard>

        nauticalmiles
        |> should (equalWithin 0.1) 3.456156
