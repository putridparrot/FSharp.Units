namespace FSharp.Units.Tests

module LengthTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Length
    open Helpers


    [<Property>]
    let ``From Centimetres to Millimetres and back`` () =
        let property value =
            let convertTo = cm.toMillimetres (cm.create value)
            let convertBack = mm.toCentimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<cm>, 9000.0)>]
    [<TestCase(34.9<cm>, 349.0)>]
    [<TestCase(2.0<cm>, 20.0)>]
    let ``Convert known Centimetres to Millimetres`` (input, expectation) = 
        cm.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Centimetres to Metres and back`` () =
        let property value =
            let convertTo = cm.toMetres (cm.create value)
            let convertBack = m.toCentimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(13.0<cm>, 0.13)>]
    [<TestCase(3900.0<cm>, 39.0)>]
    [<TestCase(1.0<cm>, 0.01)>]
    let ``Convert known Centimetres to Metres`` (input, expectation) = 
        cm.toMetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Centimetres to Kilometres and back`` () =
        let property value =
            let convertTo = cm.toKilometres (cm.create value)
            let convertBack = km.toCentimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123456.0<cm>, 1.23456)>]
    [<TestCase(8900.0<cm>, 0.089)>]
    [<TestCase(6009000.0<cm>, 60.09)>]
    let ``Convert known Centimetres to Kilometres`` (input, expectation) = 
        cm.toKilometres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Centimetres to Inches and back`` () =
        let property value =
            let convertTo = cm.toInches (cm.create value)
            let convertBack = inch.toCentimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(600.0<cm>, 236.22)>]
    [<TestCase(12.0<cm>, 4.72441)>]
    [<TestCase(7.8<cm>, 3.07087)>]
    let ``Convert known Centimetres to Inches`` (input, expectation) = 
        cm.toInches input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Centimetres to Feet and back`` () =
        let property value =
            let convertTo = cm.toFeet (cm.create value)
            let convertBack = ft.toCentimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.3<cm>, 0.4035433)>]
    [<TestCase(89.0<cm>, 2.91995)>]
    [<TestCase(0.7<cm>, 0.0229659)>]
    let ``Convert known Centimetres to Feet`` (input, expectation) = 
        cm.toFeet input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Centimetres to Yards and back`` () =
        let property value =
            let convertTo = cm.toYards (cm.create value)
            let convertBack = yard.toCentimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(700.0<cm>, 7.65529)>]
    [<TestCase(56.3<cm>, 0.6157043)>]
    [<TestCase(8.0<cm>, 0.0874891)>]
    let ``Convert known Centimetres to Yards`` (input, expectation) = 
        cm.toYards input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Centimetres to Miles and back`` () =
        let property value =
            let convertTo = cm.toMiles (cm.create value)
            let convertBack = mile.toCentimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(80000.0<cm>, 0.49709695)>]
    [<TestCase(123456.0<cm>, 0.767120019)>]
    [<TestCase(90909090.0<cm>, 564.88289639)>]
    let ``Convert known Centimetres to Miles`` (input, expectation) = 
        cm.toMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Centimetres to Nautical Miles and back`` () =
        let property value =
            let convertTo = cm.toNauticalMiles (cm.create value)
            let convertBack = NM.toCentimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(30000.0<cm>, 0.16198704)>]
    [<TestCase(987654.0<cm>, 5.33290497)>]
    [<TestCase(100200.0<cm>, 0.541036717)>]
    let ``Convert known Centimetres to Nautical Miles`` (input, expectation) = 
        cm.toNauticalMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Feet to Millimetres and back`` () =
        let property value =
            let convertTo = ft.toMillimetres (ft.create value)
            let convertBack = mm.toFeet convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.3<ft>, 91.44)>]
    [<TestCase(2.0<ft>, 609.6)>]
    [<TestCase(0.06<ft>, 18.288)>]
    let ``Convert known Feet to Millimetres`` (input, expectation) = 
        ft.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Feet to Centimetres and back`` () =
        let property value =
            let convertTo = ft.toCentimetres (ft.create value)
            let convertBack = cm.toFeet convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.07<ft>, 2.1336)>]
    [<TestCase(3.5<ft>, 106.68)>]
    [<TestCase(89.0<ft>, 2712.72)>]
    let ``Convert known Feet to Centimetres`` (input, expectation) = 
        ft.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Feet to Metres and back`` () =
        let property value =
            let convertTo = ft.toMetres (ft.create value)
            let convertBack = m.toFeet convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<ft>, 274.32)>]
    [<TestCase(1.2<ft>, 0.36576)>]
    [<TestCase(0.8<ft>, 0.24384)>]
    let ``Convert known Feet to Metres`` (input, expectation) = 
        ft.toMetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Feet to Kilometres and back`` () =
        let property value =
            let convertTo = ft.toKilometres (ft.create value)
            let convertBack = km.toFeet convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1999.0<ft>, 0.6092952)>]
    [<TestCase(123456.0<ft>, 37.6293888)>]
    [<TestCase(800.0<ft>, 0.24384)>]
    let ``Convert known Feet to Kilometres`` (input, expectation) = 
        ft.toKilometres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Feet to Inches and back`` () =
        let property value =
            let convertTo = ft.toInches (ft.create value)
            let convertBack = inch.toFeet convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8.0<ft>, 96.0)>]
    [<TestCase(1.2<ft>, 14.4)>]
    [<TestCase(0.4<ft>, 4.8)>]
    let ``Convert known Feet to Inches`` (input, expectation) = 
        ft.toInches input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Feet to Yards and back`` () =
        let property value =
            let convertTo = ft.toYards (ft.create value)
            let convertBack = yard.toFeet convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(78.0<ft>, 26.0)>]
    [<TestCase(0.1<ft>, 0.0333333)>]
    [<TestCase(7162.0<ft>, 2387.333)>]
    let ``Convert known Feet to Yards`` (input, expectation) = 
        ft.toYards input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Feet to Miles and back`` () =
        let property value =
            let convertTo = ft.toMiles (ft.create value)
            let convertBack = mile.toFeet convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9000.0<ft>, 1.704545)>]
    [<TestCase(1999.0<ft>, 0.3785985)>]
    [<TestCase(5020.0<ft>, 0.9507576)>]
    let ``Convert known Feet to Miles`` (input, expectation) = 
        ft.toMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Feet to Nautical Miles and back`` () =
        let property value =
            let convertTo = ft.toNauticalMiles (ft.create value)
            let convertBack = NM.toFeet convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8765.0<ft>, 1.442533)>]
    [<TestCase(19000.0<ft>, 3.1269978)>]
    [<TestCase(1000.0<ft>, 0.164579)>]
    let ``Convert known Feet to Nautical Miles`` (input, expectation) = 
        ft.toNauticalMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Inches to Millimetres and back`` () =
        let property value =
            let convertTo = inch.toMillimetres (inch.create value)
            let convertBack = mm.toInches convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.0<inch>, 25.4)>]
    [<TestCase(0.6<inch>, 15.24)>]
    [<TestCase(456.0<inch>, 11582.4)>]
    let ``Convert known Inches to Millimetres`` (input, expectation) = 
        inch.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Inches to Centimetres and back`` () =
        let property value =
            let convertTo = inch.toCentimetres (inch.create value)
            let convertBack = cm.toInches convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.0<inch>, 312.42)>]
    [<TestCase(0.9<inch>, 2.286)>]
    [<TestCase(3.4<inch>, 8.636)>]
    let ``Convert known Inches to Centimetres`` (input, expectation) = 
        inch.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Inches to Metres and back`` () =
        let property value =
            let convertTo = inch.toMetres (inch.create value)
            let convertBack = m.toInches convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.4<inch>, 0.08636)>]
    [<TestCase(1002.0<inch>, 25.4508)>]
    [<TestCase(56.0<inch>, 1.4224)>]
    let ``Convert known Inches to Metres`` (input, expectation) = 
        inch.toMetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Inches to Kilometres and back`` () =
        let property value =
            let convertTo = inch.toKilometres (inch.create value)
            let convertBack = km.toInches convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(17890.0<inch>, 0.454406)>]
    [<TestCase(999000.0<inch>, 25.3746)>]
    [<TestCase(100200.0<inch>, 2.54508)>]
    let ``Convert known Inches to Kilometres`` (input, expectation) = 
        inch.toKilometres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Inches to Feet and back`` () =
        let property value =
            let convertTo = inch.toFeet (inch.create value)
            let convertBack = ft.toInches convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(23.0<inch>, 1.91667)>]
    [<TestCase(0.9<inch>, 0.075)>]
    [<TestCase(479.0<inch>, 39.9167)>]
    let ``Convert known Inches to Feet`` (input, expectation) = 
        inch.toFeet input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Inches to Yards and back`` () =
        let property value =
            let convertTo = inch.toYards (inch.create value)
            let convertBack = yard.toInches convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.0<inch>, 3.41667)>]
    [<TestCase(6.7<inch>, 0.186111)>]
    [<TestCase(9.0<inch>, 0.25)>]
    let ``Convert known Inches to Yards`` (input, expectation) = 
        inch.toYards input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Inches to Miles and back`` () =
        let property value =
            let convertTo = inch.toMiles (inch.create value)
            let convertBack = mile.toInches convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9000.0<inch>, 0.1420455)>]
    [<TestCase(123456.0<inch>, 1.94848485)>]
    [<TestCase(8800.0<inch>, 0.1388889)>]
    let ``Convert known Inches to Miles`` (input, expectation) = 
        inch.toMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Inches to Nautical Miles and back`` () =
        let property value =
            let convertTo = inch.toNauticalMiles (inch.create value)
            let convertBack = NM.toInches convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9000.0<inch>, 0.1234341)>]
    [<TestCase(123456.0<inch>, 1.69318704)>]
    [<TestCase(100200.0<inch>, 1.37423326)>]
    let ``Convert known Inches to Nautical Miles`` (input, expectation) = 
        inch.toNauticalMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilometres to Millimetres and back`` () =
        let property value =
            let convertTo = km.toMillimetres (km.create value)
            let convertBack = mm.toKilometres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.09<km>, 90000.0)>]
    [<TestCase(0.12<km>, 120000.0)>]
    [<TestCase(2.3<km>, 2.3e+6)>]
    let ``Convert known Kilometres to Millimetres`` (input, expectation) = 
        km.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilometres to Centimetres and back`` () =
        let property value =
            let convertTo = km.toCentimetres (km.create value)
            let convertBack = cm.toKilometres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(7.9<km>, 790000.0)>]
    [<TestCase(0.2<km>, 20000.0)>]
    [<TestCase(0.09<km>, 9000.0)>]
    let ``Convert known Kilometres to Centimetres`` (input, expectation) = 
        km.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilometres to Metres and back`` () =
        let property value =
            let convertTo = km.toMetres (km.create value)
            let convertBack = m.toKilometres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.8<km>, 800.0)>]
    [<TestCase(45.0<km>, 45000.0)>]
    [<TestCase(1.2<km>, 1200)>]
    let ``Convert known Kilometres to Metres`` (input, expectation) = 
        km.toMetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilometres to Inches and back`` () =
        let property value =
            let convertTo = km.toInches (km.create value)
            let convertBack = inch.toKilometres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<km>, 47244.1)>]
    [<TestCase(0.65<km>, 25590.55)>]
    [<TestCase(5.0<km>, 196850.3937)>]
    let ``Convert known Kilometres to Inches`` (input, expectation) = 
        km.toInches input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilometres to Feet and back`` () =
        let property value =
            let convertTo = km.toFeet (km.create value)
            let convertBack = ft.toKilometres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.8<km>, 12467.2)>]
    [<TestCase(1.2<km>, 3937.01)>]
    [<TestCase(0.65<km>, 2132.546)>]
    let ``Convert known Kilometres to Feet`` (input, expectation) = 
        km.toFeet input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilometres to Yards and back`` () =
        let property value =
            let convertTo = km.toYards (km.create value)
            let convertBack = yard.toKilometres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.08<km>, 87.48906)>]
    [<TestCase(1.2<km>, 1312.34)>]
    [<TestCase(34.0<km>, 37182.852143)>]
    let ``Convert known Kilometres to Yards`` (input, expectation) = 
        km.toYards input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilometres to Miles and back`` () =
        let property value =
            let convertTo = km.toMiles (km.create value)
            let convertBack = mile.toKilometres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<km>, 7.45645)>]
    [<TestCase(0.9<km>, 0.559234)>]
    [<TestCase(3.9<km>, 2.42335)>]
    let ``Convert known Kilometres to Miles`` (input, expectation) = 
        km.toMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilometres to Nautical Miles and back`` () =
        let property value =
            let convertTo = km.toNauticalMiles (km.create value)
            let convertBack = NM.toKilometres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<km>, 0.647948)>]
    [<TestCase(0.2<km>, 0.107991)>]
    [<TestCase(99.9<km>, 53.94168)>]
    let ``Convert known Kilometres to Nautical Miles`` (input, expectation) = 
        km.toNauticalMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Metres to Millimetres and back`` () =
        let property value =
            let convertTo = m.toMillimetres (m.create value)
            let convertBack = mm.toMetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.0<m>, 123000.0)>]
    [<TestCase(0.9<m>, 900.0)>]
    [<TestCase(0.0023<m>, 2.3)>]
    let ``Convert known Metres to Millimetres`` (input, expectation) = 
        m.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Metres to Centimetres and back`` () =
        let property value =
            let convertTo = m.toCentimetres (m.create value)
            let convertBack = cm.toMetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.3<m>, 230.0)>]
    [<TestCase(34.0<m>, 3400.0)>]
    [<TestCase(0.9<m>, 90.0)>]
    let ``Convert known Metres to Centimetres`` (input, expectation) = 
        m.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Metres to Kilometres and back`` () =
        let property value =
            let convertTo = m.toKilometres (m.create value)
            let convertBack = km.toMetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100.0<m>, 0.1)>]
    [<TestCase(123456.0<m>, 123.456)>]
    [<TestCase(91.1<m>, 0.0911)>]
    let ``Convert known Metres to Kilometres`` (input, expectation) = 
        m.toKilometres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Metres to Inches and back`` () =
        let property value =
            let convertTo = m.toInches (m.create value)
            let convertBack = inch.toMetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<m>, 472.441)>]
    [<TestCase(9.3<m>, 366.142)>]
    [<TestCase(0.1<m>, 3.93701)>]
    let ``Convert known Metres to Inches`` (input, expectation) = 
        m.toInches input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Metres to Feet and back`` () =
        let property value =
            let convertTo = m.toFeet (m.create value)
            let convertBack = ft.toMetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(67.0<m>, 219.816)>]
    [<TestCase(1.2<m>, 3.93701)>]
    [<TestCase(0.7<m>, 2.29659)>]
    let ``Convert known Metres to Feet`` (input, expectation) = 
        m.toFeet input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Metres to Yards and back`` () =
        let property value =
            let convertTo = m.toYards (m.create value)
            let convertBack = yard.toMetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.8<m>, 0.874891)>]
    [<TestCase(34.5<m>, 37.72966)>]
    [<TestCase(1.23<m>, 1.345144)>]
    let ``Convert known Metres to Yards`` (input, expectation) = 
        m.toYards input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Metres to Miles and back`` () =
        let property value =
            let convertTo = m.toMiles (m.create value)
            let convertBack = mile.toMetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(7900.0<m>, 4.908832)>]
    [<TestCase(123456.0<m>, 76.7120019)>]
    [<TestCase(1000.0<m>, 0.621371)>]
    let ``Convert known Metres to Miles`` (input, expectation) = 
        m.toMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Metres to Nautical Miles and back`` () =
        let property value =
            let convertTo = m.toNauticalMiles (m.create value)
            let convertBack = NM.toMetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<m>, 0.485961)>]
    [<TestCase(71819.0<m>, 38.779158)>]
    [<TestCase(123456.0<m>, 66.6609071)>]
    let ``Convert known Metres to Nautical Miles`` (input, expectation) = 
        m.toNauticalMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Miles to Millimetres and back`` () =
        let property value =
            let convertTo = mile.toMillimetres (mile.create value)
            let convertBack = mm.toMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.09<mile>, 144840.95999)>]
    [<TestCase(0.001<mile>, 1609.344)>]
    [<TestCase(0.5<mile>, 804672.0)>]
    let ``Convert known Miles to Millimetres`` (input, expectation) = 
        mile.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Miles to Centimetres and back`` () =
        let property value =
            let convertTo = mile.toCentimetres (mile.create value)
            let convertBack = cm.toMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.23<mile>, 37014.91)>]
    [<TestCase(0.01<mile>, 1609.344)>]
    [<TestCase(0.8<mile>, 128747.52)>]
    let ``Convert known Miles to Centimetres`` (input, expectation) = 
        mile.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Miles to Metres and back`` () =
        let property value =
            let convertTo = mile.toMetres (mile.create value)
            let convertBack = m.toMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.1<mile>, 160.934)>]
    [<TestCase(0.08<mile>, 128.7475)>]
    [<TestCase(0.002<mile>, 3.218688)>]
    let ``Convert known Miles to Metres`` (input, expectation) = 
        mile.toMetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Miles to Kilometres and back`` () =
        let property value =
            let convertTo = mile.toKilometres (mile.create value)
            let convertBack = km.toMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.0<mile>, 3.21869)>]
    [<TestCase(0.8<mile>, 1.28748)>]
    [<TestCase(23.0<mile>, 37.0149)>]
    let ``Convert known Miles to Kilometres`` (input, expectation) = 
        mile.toKilometres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Miles to Inches and back`` () =
        let property value =
            let convertTo = mile.toInches (mile.create value)
            let convertBack = inch.toMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.7<mile>, 44352.0)>]
    [<TestCase(0.09<mile>, 5702.4)>]
    [<TestCase(2.0<mile>, 126720.0)>]
    let ``Convert known Miles to Inches`` (input, expectation) = 
        mile.toInches input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Miles to Feet and back`` () =
        let property value =
            let convertTo = mile.toFeet (mile.create value)
            let convertBack = ft.toMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.0<mile>, 10560.0)>]
    [<TestCase(0.6<mile>, 3168.0)>]
    [<TestCase(0.07<mile>, 369.6)>]
    let ``Convert known Miles to Feet`` (input, expectation) = 
        mile.toFeet input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Miles to Yards and back`` () =
        let property value =
            let convertTo = mile.toYards (mile.create value)
            let convertBack = yard.toMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.07<mile>, 123.2)>]
    [<TestCase(2.0<mile>, 3520.0)>]
    [<TestCase(8.1<mile>, 14256.0)>]
    let ``Convert known Miles to Yards`` (input, expectation) = 
        mile.toYards input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Miles to Nautical Miles and back`` () =
        let property value =
            let convertTo = mile.toNauticalMiles (mile.create value)
            let convertBack = NM.toMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8.1<mile>, 7.03871)>]
    [<TestCase(0.8<mile>, 0.695181)>]
    [<TestCase(1.2<mile>, 1.04277)>]
    let ``Convert known Miles to Nautical Miles`` (input, expectation) = 
        mile.toNauticalMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millimetres to Centimetres and back`` () =
        let property value =
            let convertTo = mm.toCentimetres (mm.create value)
            let convertBack = cm.toMillimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<mm>, 90.0)>]
    [<TestCase(190.0<mm>, 19.0)>]
    [<TestCase(5000.0<mm>, 500.0)>]
    let ``Convert known Millimetres to Centimetres`` (input, expectation) = 
        mm.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millimetres to Metres and back`` () =
        let property value =
            let convertTo = mm.toMetres (mm.create value)
            let convertBack = m.toMillimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1090.0<mm>, 1.09)>]
    [<TestCase(9000.0<mm>, 9.0)>]
    [<TestCase(12345.0<mm>, 12.345)>]
    let ``Convert known Millimetres to Metres`` (input, expectation) = 
        mm.toMetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millimetres to Kilometres and back`` () =
        let property value =
            let convertTo = mm.toKilometres (mm.create value)
            let convertBack = km.toMillimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109000.0<mm>, 0.109)>]
    [<TestCase(9876543.0<mm>, 9.876543)>]
    [<TestCase(900800.0<mm>, 0.9008)>]
    let ``Convert known Millimetres to Kilometres`` (input, expectation) = 
        mm.toKilometres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millimetres to Inches and back`` () =
        let property value =
            let convertTo = mm.toInches (mm.create value)
            let convertBack = inch.toMillimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<mm>, 35.4331)>]
    [<TestCase(123.0<mm>, 4.84252)>]
    [<TestCase(80.0<mm>, 3.14961)>]
    let ``Convert known Millimetres to Inches`` (input, expectation) = 
        mm.toInches input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millimetres to Feet and back`` () =
        let property value =
            let convertTo = mm.toFeet (mm.create value)
            let convertBack = ft.toMillimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(800.0<mm>, 2.62467)>]
    [<TestCase(1234.0<mm>, 4.048556)>]
    [<TestCase(600.8<mm>, 1.9711286)>]
    let ``Convert known Millimetres to Feet`` (input, expectation) = 
        mm.toFeet input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millimetres to Yards and back`` () =
        let property value =
            let convertTo = mm.toYards (mm.create value)
            let convertBack = yard.toMillimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(800.0<mm>, 0.874891)>]
    [<TestCase(1200.0<mm>, 1.312336)>]
    [<TestCase(909.0<mm>, 0.994094)>]
    let ``Convert known Millimetres to Yards`` (input, expectation) = 
        mm.toYards input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millimetres to Miles and back`` () =
        let property value =
            let convertTo = mm.toMiles (mm.create value)
            let convertBack = mile.toMillimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900000.0<mm>, 0.559234073)>]
    [<TestCase(12345678.9<mm>, 7.671249217072)>]
    [<TestCase(100200300.0<mm>, 62.2615798735)>]
    let ``Convert known Millimetres to Miles`` (input, expectation) = 
        mm.toMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millimetres to Nautical Miles and back`` () =
        let property value =
            let convertTo = mm.toNauticalMiles (mm.create value)
            let convertBack = NM.toMillimetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9000000.0<mm>, 4.859611231)>]
    [<TestCase(12345678.0<mm>, 6.6661328294)>]
    [<TestCase(926000.0<mm>, 0.5)>]
    let ``Convert known Millimetres to Nautical Miles`` (input, expectation) = 
        mm.toNauticalMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Nautical Miles to Millimetres and back`` () =
        let property value =
            let convertTo = NM.toMillimetres (NM.create value)
            let convertBack = mm.toNauticalMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.08<NM>, 148160.0)>]
    [<TestCase(0.001<NM>, 1852.0)>]
    [<TestCase(0.02<NM>, 37040.0)>]
    let ``Convert known Nautical Miles to Millimetres`` (input, expectation) = 
        NM.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Nautical Miles to Centimetres and back`` () =
        let property value =
            let convertTo = NM.toCentimetres (NM.create value)
            let convertBack = cm.toNauticalMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<NM>, 166680.0)>]
    [<TestCase(1.2<NM>, 222240.0)>]
    [<TestCase(0.1<NM>, 18520.0)>]
    let ``Convert known Nautical Miles to Centimetres`` (input, expectation) = 
        NM.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Nautical Miles to Metres and back`` () =
        let property value =
            let convertTo = NM.toMetres (NM.create value)
            let convertBack = m.toNauticalMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.1<NM>, 185.2)>]
    [<TestCase(1.2<NM>, 2222.4)>]
    [<TestCase(89.0<NM>, 164828.0)>]
    let ``Convert known Nautical Miles to Metres`` (input, expectation) = 
        NM.toMetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Nautical Miles to Kilometres and back`` () =
        let property value =
            let convertTo = NM.toKilometres (NM.create value)
            let convertBack = km.toNauticalMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(23.0<NM>, 42.596)>]
    [<TestCase(1.7<NM>, 3.1484)>]
    [<TestCase(56.0<NM>, 103.712)>]
    let ``Convert known Nautical Miles to Kilometres`` (input, expectation) = 
        NM.toKilometres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Nautical Miles to Inches and back`` () =
        let property value =
            let convertTo = NM.toInches (NM.create value)
            let convertBack = inch.toNauticalMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.1<NM>, 7291.34)>]
    [<TestCase(2.0<NM>, 145826.7999)>]
    [<TestCase(3.5<NM>, 255196.899)>]
    let ``Convert known Nautical Miles to Inches`` (input, expectation) = 
        NM.toInches input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Nautical Miles to Feet and back`` () =
        let property value =
            let convertTo = NM.toFeet (NM.create value)
            let convertBack = ft.toNauticalMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.4<NM>, 8506.56)>]
    [<TestCase(0.1<NM>, 607.612)>]
    [<TestCase(8.9<NM>, 54077.4680)>]
    let ``Convert known Nautical Miles to Feet`` (input, expectation) = 
        NM.toFeet input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Nautical Miles to Yards and back`` () =
        let property value =
            let convertTo = NM.toYards (NM.create value)
            let convertBack = yard.toNauticalMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9.0<NM>, 18228.329)>]
    [<TestCase(1.5<NM>, 3038.06)>]
    [<TestCase(0.8<NM>, 1620.3)>]
    let ``Convert known Nautical Miles to Yards`` (input, expectation) = 
        NM.toYards input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Nautical Miles to Miles and back`` () =
        let property value =
            let convertTo = NM.toMiles (NM.create value)
            let convertBack = mile.toNauticalMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.5<NM>, 0.57539)>]
    [<TestCase(23.0<NM>, 26.4679)>]
    [<TestCase(8.2<NM>, 9.43639)>]
    let ``Convert known Nautical Miles to Miles`` (input, expectation) = 
        NM.toMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Yards to Millimetres and back`` () =
        let property value =
            let convertTo = yard.toMillimetres (yard.create value)
            let convertBack = mm.toYards convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(34.0<yard>, 31089.6)>]
    [<TestCase(0.9<yard>, 822.96)>]
    [<TestCase(2.0<yard>, 1828.8)>]
    let ``Convert known Yards to Millimetres`` (input, expectation) = 
        yard.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Yards to Centimetres and back`` () =
        let property value =
            let convertTo = yard.toCentimetres (yard.create value)
            let convertBack = cm.toYards convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9.8<yard>, 896.112)>]
    [<TestCase(0.8<yard>, 73.152)>]
    [<TestCase(12.0<yard>, 1097.28)>]
    let ``Convert known Yards to Centimetres`` (input, expectation) = 
        yard.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Yards to Metres and back`` () =
        let property value =
            let convertTo = yard.toMetres (yard.create value)
            let convertBack = m.toYards convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<yard>, 10.9728)>]
    [<TestCase(0.7<yard>, 0.64008)>]
    [<TestCase(3.0<yard>, 2.7432)>]
    let ``Convert known Yards to Metres`` (input, expectation) = 
        yard.toMetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Yards to Kilometres and back`` () =
        let property value =
            let convertTo = yard.toKilometres (yard.create value)
            let convertBack = km.toYards convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(400.0<yard>, 0.36576)>]
    [<TestCase(1900.0<yard>, 1.73736)>]
    [<TestCase(12345.0<yard>, 11.288268)>]
    let ``Convert known Yards to Kilometres`` (input, expectation) = 
        yard.toKilometres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Yards to Inches and back`` () =
        let property value =
            let convertTo = yard.toInches (yard.create value)
            let convertBack = inch.toYards convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(23.0<yard>, 828.0)>]
    [<TestCase(0.9<yard>, 32.4)>]
    [<TestCase(12.0<yard>, 432.0)>]
    let ``Convert known Yards to Inches`` (input, expectation) = 
        yard.toInches input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Yards to Feet and back`` () =
        let property value =
            let convertTo = yard.toFeet (yard.create value)
            let convertBack = ft.toYards convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<yard>, 36.0)>]
    [<TestCase(1.8<yard>, 5.4)>]
    [<TestCase(67.0<yard>, 201.0)>]
    let ``Convert known Yards to Feet`` (input, expectation) = 
        yard.toFeet input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Yards to Miles and back`` () =
        let property value =
            let convertTo = yard.toMiles (yard.create value)
            let convertBack = mile.toYards convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8900.0<yard>, 5.056818)>]
    [<TestCase(5000.0<yard>, 2.840909)>]
    [<TestCase(123456.0<yard>, 70.1454545)>]
    let ``Convert known Yards to Miles`` (input, expectation) = 
        yard.toMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Yards to Nautical Miles and back`` () =
        let property value =
            let convertTo = yard.toNauticalMiles (yard.create value)
            let convertBack = NM.toYards convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1000.0<yard>, 0.493737)>]
    [<TestCase(202020.0<yard>, 99.7446479)>]
    [<TestCase(71928.0<yard>, 35.513479)>]
    let ``Convert known Yards to Nautical Miles`` (input, expectation) = 
        yard.toNauticalMiles input
        |> should (equalWithin 0.01) expectation

