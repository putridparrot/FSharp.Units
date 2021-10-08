namespace FSharp.Units.Tests

module MileTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Length
    open Helpers

   // mile to X and back

    [<Property>]
    let ``From mile to millimetre and back`` () =
        let property value = 
            let millimetres = mile.toMillimetres (mile.create value)
            let miles = mm.toMiles millimetres

            miles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From mile to centimetre and back`` () =
        let property value = 
            let centimetres = mile.toCentimetres (mile.create value)
            let miles = cm.toMiles centimetres

            miles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From mile to kilometre and back`` () =
        let property value = 
            let kilometres = mile.toKilometres (mile.create value)
            let miles = km.toMiles kilometres

            miles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From mile to inches and back`` () =
        let property value = 
            let inches = mile.toInches (mile.create value)
            let miles = inch.toMiles inches

            miles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From mile to feet and back`` () =
        let property value = 
            let f = mile.toFeet (mile.create value)
            let miles = ft.toMiles f

            miles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From mile to yard and back`` () =
        let property value = 
            let yards = mile.toYards (mile.create value)
            let miles = yard.toMiles yards

            miles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From mile to nautical miles and back`` () =
        let property value = 
            let nauticalmiles = mile.toNauticalMiles (mile.create value)
            let miles = NM.toMiles nauticalmiles

            miles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known mile to millimetre`` () =
        let millimetres = mile.toMillimetres 0.03<mile>

        millimetres
        |> should (equalWithin 0.01) 48280.32

    [<Test>]
    let ``Convert known mile to centimetre`` () =
        let centimetres = mile.toCentimetres 2.<mile>

        centimetres
        |> should (equalWithin 0.01) 321868.8

    [<Test>]
    let ``Convert known mile to metre`` () =
        let metres = mile.toMetres 0.9<mile>

        metres
        |> should (equalWithin 0.01) 1448.41

    [<Test>]
    let ``Convert known mile to kilometre`` () =
        let kilometres = mile.toKilometres 3.<mile>

        kilometres
        |> should (equalWithin 0.01) 4.82803

    [<Test>]
    let ``Convert known mile to inch`` () =
        let inches = mile.toInches 1.2<mile>

        inches
        |> should (equalWithin 0.01) 76032.

    [<Test>]
    let ``Convert known mile to yard`` () =
        let inches = mile.toYards 2.1<mile>

        inches
        |> should (equalWithin 0.01) 3696.

    [<Test>]
    let ``Convert known mile to feet`` () =
        let f = mile.toFeet 2.2<mile>

        f
        |> should (equalWithin 0.01) 11616.

    [<Test>]
    let ``Convert known mile to nautical mile`` () =
        let nauticalmiles = mile.toNauticalMiles 5.<mile>

        nauticalmiles
        |> should (equalWithin 0.01) 4.34488
