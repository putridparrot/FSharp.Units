namespace FSharp.Units.Tests

module InchTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Length
    open Helpers

   // inch to X and back

    [<Property>]
    let ``From inch to millimetre and back`` () =
        let property value = 
            let millimetres = inch.toMillimetres (inch.create value)
            let inches = mm.toInches millimetres

            inches
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From inch to centimetre and back`` () =
        let property value = 
            let centimetres = inch.toCentimetres (inch.create value)
            let inches = cm.toInches centimetres

            inches
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From inch to metre and back`` () =
        let property value = 
            let metres = inch.toMetres (inch.create value)
            let inches = m.toInches metres

            inches
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From inch to kilometre and back`` () =
        let property value = 
            let kilometres = inch.toKilometres (inch.create value)
            let inches = km.toInches kilometres

            inches
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From inch to feet and back`` () =
        let property value = 
            let feet = inch.toFeet (inch.create value)
            let inches = ft.toInches feet

            inches
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From inch to yards and back`` () =
        let property value = 
            let yards = inch.toYards (inch.create value)
            let inches = yard.toInches yards

            inches
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From inch to miles and back`` () =
        let property value = 
            let miles = inch.toMiles (inch.create value)
            let inches = mile.toInches miles

            inches
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From inch to nautical miles and back`` () =
        let property value = 
            let nauticalmiles = inch.toNauticalMiles (inch.create value)
            let inches = NM.toInches nauticalmiles

            inches
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known inch to millimetre`` () =
        let millimetres = inch.toMillimetres 123.<inch>

        millimetres
        |> should (equalWithin 0.1) 3124.2

    [<Test>]
    let ``Convert known inch to centimetre`` () =
        let centimetres = inch.toCentimetres 56.<inch>

        centimetres
        |> should (equalWithin 0.1) 142.24

    [<Test>]
    let ``Convert known inch to metre`` () =
        let metres = inch.toMetres 123.<inch>

        metres
        |> should (equalWithin 0.1) 3.1242

    [<Test>]
    let ``Convert known inch to kilometre`` () =
        let kilometres = inch.toKilometres 1891.<inch>

        kilometres
        |> should (equalWithin 0.1) 0.0480314

    [<Test>]
    let ``Convert known inch to feet`` () =
        let ft = inch.toFeet 1891.<inch>

        ft
        |> should (equalWithin 0.1) 157.58333333

    [<Test>]
    let ``Convert known inch to yards`` () =
        let yards = inch.toYards 1891.<inch>

        yards
        |> should (equalWithin 0.1) 52.52777778

    [<Test>]
    let ``Convert known inch to miles`` () =
        let miles = inch.toMiles 1891.<inch>

        miles
        |> should (equalWithin 0.1) 0.02984533

    [<Test>]
    let ``Convert known inch to nauticalmiles`` () =
        let nauticalmiles = inch.toNauticalMiles 8900.<inch>

        nauticalmiles
        |> should (equalWithin 0.1) 0.1220626
