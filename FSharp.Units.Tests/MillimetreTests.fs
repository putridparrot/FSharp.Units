﻿namespace FSharp.Units.Tests

module MillimetreTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Length
    open Helpers

   // millimetre to X and back

    [<Property>]
    let ``From millimetre to centimetres and back`` () =
        let property value = 
            let centimetres = mm.toCentimetres (mm.create value)
            let millimetres = cm.toMillimetres centimetres

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millimetre to metres and back`` () =
        let property value = 
            let metres = mm.toMetres (mm.create value)
            let millimetres = m.toMillimetres metres

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millimetre to kilometres and back`` () =
        let property value = 
            let kilometres = mm.toKilometres (mm.create value)
            let millimetres = km.toMillimetres kilometres

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millimetre to inches and back`` () =
        let property value = 
            let inches = mm.toInches (mm.create value)
            let millimetres = inch.toMillimetres inches

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millimetre to feet and back`` () =
        let property value = 
            let f = mm.toFeet (mm.create value)
            let millimetres = ft.toMillimetres f

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millimetre to yards and back`` () =
        let property value = 
            let yards = mm.toYards (mm.create value)
            let millimetres = yard.toMillimetres yards

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millimetre to miles and back`` () =
        let property value = 
            let miles = mm.toMiles (mm.create value)
            let millimetres = mile.toMillimetres miles

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millimetre to nautical miles and back`` () =
        let property value = 
            let nauticalmiles = mm.toNauticalMiles (mm.create value)
            let millimetres = NM.toMillimetres nauticalmiles

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known millimetre to centimetre`` () =
        let centimetres = mm.toCentimetres 123.<mm>

        centimetres
        |> should (equalWithin 0.01) 12.3

    [<Test>]
    let ``Convert known millimetre to metre`` () =
        let metres = mm.toMetres 123.<mm>

        metres
        |> should (equalWithin 0.01) 0.123

    [<Test>]
    let ``Convert known millimetre to kilometre`` () =
        let metres = mm.toKilometres 10981.<mm>

        metres
        |> should (equalWithin 0.01) 0.010981

    [<Test>]
    let ``Convert known millimetre to inch`` () =
        let metres = mm.toInches 1422.4<mm>

        metres
        |> should (equalWithin 0.01) 56.

    [<Test>]
    let ``Convert known millimetre to feet`` () =
        let ft = mm.toFeet 1234.<mm>

        ft
        |> should (equalWithin 0.01) 4.04855643

    [<Test>]
    let ``Convert known millimetre to yard`` () =
        let yard = mm.toYards 3940.<mm>

        yard
        |> should (equalWithin 0.01) 4.3088364

    [<Test>]
    let ``Convert known millimetre to mile`` () =
        let miles = mm.toMiles 4023360.<mm>

        miles
        |> should (equalWithin 0.01) 2.5

    [<Test>]
    let ``Convert known millimetre to nauticalmile`` () =
        let ft = mm.toNauticalMiles 123456.<mm>

        ft
        |> should (equalWithin 0.01) 0.0666609071
