namespace FSharp.Units.Tests

module MassTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Mass
    open Helpers


    [<Property>]
    let ``From Grams to Milligrams and back`` () =
        let property value =
            let convertTo = g.toMilligrams (g.create value)
            let convertBack = mg.toGrams convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<g>, 1200.0)>]
    [<TestCase(0.9<g>, 900.0)>]
    [<TestCase(2.0<g>, 2000.0)>]
    let ``Convert known Grams to Milligrams`` (input, expectation) = 
        g.toMilligrams input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Grams to Kilograms and back`` () =
        let property value =
            let convertTo = g.toKilograms (g.create value)
            let convertBack = kg.toGrams convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<g>, 0.9)>]
    [<TestCase(12345.0<g>, 12.345)>]
    [<TestCase(670.0<g>, 0.67)>]
    let ``Convert known Grams to Kilograms`` (input, expectation) = 
        g.toKilograms input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Grams to Tonnes and back`` () =
        let property value =
            let convertTo = g.toTonnes (g.create value)
            let convertBack = tonne.toGrams convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6700000.0<g>, 6.7)>]
    [<TestCase(123456.0<g>, 0.123456)>]
    [<TestCase(9809789.0<g>, 9.809789)>]
    let ``Convert known Grams to Tonnes`` (input, expectation) = 
        g.toTonnes input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Grams to Ounces and back`` () =
        let property value =
            let convertTo = g.toOunces (g.create value)
            let convertBack = oz.toGrams convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.3<g>, 0.151678)>]
    [<TestCase(170.0<g>, 5.99657)>]
    [<TestCase(9.0<g>, 0.317466)>]
    let ``Convert known Grams to Ounces`` (input, expectation) = 
        g.toOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Grams to Pounds and back`` () =
        let property value =
            let convertTo = g.toPounds (g.create value)
            let convertBack = lb.toGrams convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(80.0<g>, 0.17637)>]
    [<TestCase(190.0<g>, 0.418878)>]
    [<TestCase(4500.0<g>, 9.920802)>]
    let ``Convert known Grams to Pounds`` (input, expectation) = 
        g.toPounds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Grams to Stones and back`` () =
        let property value =
            let convertTo = g.toStones (g.create value)
            let convertBack = stone.toGrams convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8000.0<g>, 1.259784)>]
    [<TestCase(12345.0<g>, 1.9440047)>]
    [<TestCase(900.0<g>, 0.141726)>]
    let ``Convert known Grams to Stones`` (input, expectation) = 
        g.toStones input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilograms to Milligrams and back`` () =
        let property value =
            let convertTo = kg.toMilligrams (kg.create value)
            let convertBack = mg.toKilograms convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<kg>, 900000.0)>]
    [<TestCase(0.56<kg>, 560000.0)>]
    [<TestCase(0.007<kg>, 7000.0)>]
    let ``Convert known Kilograms to Milligrams`` (input, expectation) = 
        kg.toMilligrams input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilograms to Grams and back`` () =
        let property value =
            let convertTo = kg.toGrams (kg.create value)
            let convertBack = g.toKilograms convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.8<kg>, 800.0)>]
    [<TestCase(12.0<kg>, 12000.0)>]
    [<TestCase(0.2<kg>, 200.0)>]
    let ``Convert known Kilograms to Grams`` (input, expectation) = 
        kg.toGrams input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilograms to Tonnes and back`` () =
        let property value =
            let convertTo = kg.toTonnes (kg.create value)
            let convertBack = tonne.toKilograms convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.0<kg>, 0.123)>]
    [<TestCase(9000.0<kg>, 9.0)>]
    [<TestCase(2300.0<kg>, 2.3)>]
    let ``Convert known Kilograms to Tonnes`` (input, expectation) = 
        kg.toTonnes input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilograms to Ounces and back`` () =
        let property value =
            let convertTo = kg.toOunces (kg.create value)
            let convertBack = oz.toKilograms convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2300.0<kg>, 81130.19)>]
    [<TestCase(12.0<kg>, 423.288)>]
    [<TestCase(3.4<kg>, 119.931)>]
    let ``Convert known Kilograms to Ounces`` (input, expectation) = 
        kg.toOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilograms to Pounds and back`` () =
        let property value =
            let convertTo = kg.toPounds (kg.create value)
            let convertBack = lb.toKilograms convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.4<kg>, 7.49572)>]
    [<TestCase(0.9<kg>, 1.98416)>]
    [<TestCase(3.0<kg>, 6.61387)>]
    let ``Convert known Kilograms to Pounds`` (input, expectation) = 
        kg.toPounds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilograms to Stones and back`` () =
        let property value =
            let convertTo = kg.toStones (kg.create value)
            let convertBack = stone.toKilograms convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.0<kg>, 0.472419)>]
    [<TestCase(98.0<kg>, 15.4324)>]
    [<TestCase(1.2<kg>, 0.188968)>]
    let ``Convert known Kilograms to Stones`` (input, expectation) = 
        kg.toStones input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Milligrams to Grams and back`` () =
        let property value =
            let convertTo = mg.toGrams (mg.create value)
            let convertBack = g.toMilligrams convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190.0<mg>, 0.19)>]
    [<TestCase(2300.0<mg>, 2.3)>]
    [<TestCase(19000.0<mg>, 19.0)>]
    let ``Convert known Milligrams to Grams`` (input, expectation) = 
        mg.toGrams input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Milligrams to Kilograms and back`` () =
        let property value =
            let convertTo = mg.toKilograms (mg.create value)
            let convertBack = kg.toMilligrams convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1234567.0<mg>, 1.234567)>]
    [<TestCase(900800.0<mg>, 0.9008)>]
    [<TestCase(7800000.0<mg>, 7.8)>]
    let ``Convert known Milligrams to Kilograms`` (input, expectation) = 
        mg.toKilograms input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Milligrams to Tonnes and back`` () =
        let property value =
            let convertTo = mg.toTonnes (mg.create value)
            let convertBack = tonne.toMilligrams convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900000000.0<mg>, 0.9)>]
    [<TestCase(60000000.0<mg>, 0.06)>]
    [<TestCase(123456789.0<mg>, 0.123456789)>]
    let ``Convert known Milligrams to Tonnes`` (input, expectation) = 
        mg.toTonnes input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Milligrams to Ounces and back`` () =
        let property value =
            let convertTo = mg.toOunces (mg.create value)
            let convertBack = oz.toMilligrams convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6000.0<mg>, 0.2116438)>]
    [<TestCase(123456.0<mg>, 4.35478225)>]
    [<TestCase(8001.0<mg>, 0.282227)>]
    let ``Convert known Milligrams to Ounces`` (input, expectation) = 
        mg.toOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Milligrams to Pounds and back`` () =
        let property value =
            let convertTo = mg.toPounds (mg.create value)
            let convertBack = lb.toMilligrams convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123456.0<mg>, 0.27217389)>]
    [<TestCase(800900.0<mg>, 1.76568226)>]
    [<TestCase(666666.0<mg>, 1.46974694)>]
    let ``Convert known Milligrams to Pounds`` (input, expectation) = 
        mg.toPounds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Milligrams to Stones and back`` () =
        let property value =
            let convertTo = mg.toStones (mg.create value)
            let convertBack = stone.toMilligrams convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900000.0<mg>, 0.14172574)>]
    [<TestCase(12345678.0<mg>, 1.9441115001)>]
    [<TestCase(800100.0<mg>, 0.125994183)>]
    let ``Convert known Milligrams to Stones`` (input, expectation) = 
        mg.toStones input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Ounces to Milligrams and back`` () =
        let property value =
            let convertTo = oz.toMilligrams (oz.create value)
            let convertBack = mg.toOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.2<oz>, 5669.9)>]
    [<TestCase(12.0<oz>, 340194.2772)>]
    [<TestCase(1.8<oz>, 51029.141579)>]
    let ``Convert known Ounces to Milligrams`` (input, expectation) = 
        oz.toMilligrams input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Ounces to Grams and back`` () =
        let property value =
            let convertTo = oz.toGrams (oz.create value)
            let convertBack = g.toOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.0<oz>, 56.699)>]
    [<TestCase(0.3<oz>, 8.50486)>]
    [<TestCase(7.0<oz>, 198.447)>]
    let ``Convert known Ounces to Grams`` (input, expectation) = 
        oz.toGrams input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Ounces to Kilograms and back`` () =
        let property value =
            let convertTo = oz.toKilograms (oz.create value)
            let convertBack = kg.toOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(56.0<oz>, 1.58757)>]
    [<TestCase(123.0<oz>, 3.48699)>]
    [<TestCase(100.9<oz>, 2.8604669)>]
    let ``Convert known Ounces to Kilograms`` (input, expectation) = 
        oz.toKilograms input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Ounces to Tonnes and back`` () =
        let property value =
            let convertTo = oz.toTonnes (oz.create value)
            let convertBack = tonne.toOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8000.0<oz>, 0.2267962)>]
    [<TestCase(1234567.0<oz>, 34.99938572)>]
    [<TestCase(900800.0<oz>, 25.5372504)>]
    let ``Convert known Ounces to Tonnes`` (input, expectation) = 
        oz.toTonnes input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Ounces to Pounds and back`` () =
        let property value =
            let convertTo = oz.toPounds (oz.create value)
            let convertBack = lb.toOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(90.0<oz>, 5.625)>]
    [<TestCase(5.2<oz>, 0.325)>]
    [<TestCase(12.0<oz>, 0.75)>]
    let ``Convert known Ounces to Pounds`` (input, expectation) = 
        oz.toPounds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Ounces to Stones and back`` () =
        let property value =
            let convertTo = oz.toStones (oz.create value)
            let convertBack = stone.toOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(167.0<oz>, 0.745536)>]
    [<TestCase(800.7<oz>, 3.5745536)>]
    [<TestCase(1234.5<oz>, 5.51116071)>]
    let ``Convert known Ounces to Stones`` (input, expectation) = 
        oz.toStones input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pounds to Milligrams and back`` () =
        let property value =
            let convertTo = lb.toMilligrams (lb.create value)
            let convertBack = mg.toPounds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.2<lb>, 997903.214)>]
    [<TestCase(0.7<lb>, 317514.6589)>]
    [<TestCase(0.32<lb>, 145149.5584)>]
    let ``Convert known Pounds to Milligrams`` (input, expectation) = 
        lb.toMilligrams input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pounds to Grams and back`` () =
        let property value =
            let convertTo = lb.toGrams (lb.create value)
            let convertBack = g.toPounds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.3<lb>, 136.078)>]
    [<TestCase(1.2<lb>, 544.311)>]
    [<TestCase(9.0<lb>, 4082.33)>]
    let ``Convert known Pounds to Grams`` (input, expectation) = 
        lb.toGrams input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pounds to Kilograms and back`` () =
        let property value =
            let convertTo = lb.toKilograms (lb.create value)
            let convertBack = kg.toPounds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.0<lb>, 2.26796)>]
    [<TestCase(1.1<lb>, 0.498952)>]
    [<TestCase(0.7<lb>, 0.317515)>]
    let ``Convert known Pounds to Kilograms`` (input, expectation) = 
        lb.toKilograms input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pounds to Tonnes and back`` () =
        let property value =
            let convertTo = lb.toTonnes (lb.create value)
            let convertBack = tonne.toPounds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1233.0<lb>, 0.5592794)>]
    [<TestCase(656565.0<lb>, 297.812874)>]
    [<TestCase(900.0<lb>, 0.408233)>]
    let ``Convert known Pounds to Tonnes`` (input, expectation) = 
        lb.toTonnes input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pounds to Ounces and back`` () =
        let property value =
            let convertTo = lb.toOunces (lb.create value)
            let convertBack = oz.toPounds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(45.0<lb>, 720.0)>]
    [<TestCase(6.7<lb>, 107.2)>]
    [<TestCase(89.1<lb>, 1425.6)>]
    let ``Convert known Pounds to Ounces`` (input, expectation) = 
        lb.toOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pounds to Stones and back`` () =
        let property value =
            let convertTo = lb.toStones (lb.create value)
            let convertBack = stone.toPounds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(89.1<lb>, 6.364286)>]
    [<TestCase(1.2<lb>, 0.0857143)>]
    [<TestCase(789.0<lb>, 56.3571)>]
    let ``Convert known Pounds to Stones`` (input, expectation) = 
        lb.toStones input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Stones to Milligrams and back`` () =
        let property value =
            let convertTo = stone.toMilligrams (stone.create value)
            let convertBack = mg.toStones convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.009<stone>, 57152.63861)>]
    [<TestCase(0.002<stone>, 12700.586)>]
    [<TestCase(0.0006<stone>, 3810.17591)>]
    let ``Convert known Stones to Milligrams`` (input, expectation) = 
        stone.toMilligrams input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Stones to Grams and back`` () =
        let property value =
            let convertTo = stone.toGrams (stone.create value)
            let convertBack = g.toStones convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<stone>, 7620.35)>]
    [<TestCase(8.0<stone>, 50802.34543)>]
    [<TestCase(90.0<stone>, 571526.38619)>]
    let ``Convert known Stones to Grams`` (input, expectation) = 
        stone.toGrams input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Stones to Kilograms and back`` () =
        let property value =
            let convertTo = stone.toKilograms (stone.create value)
            let convertBack = kg.toStones convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(90.0<stone>, 571.526)>]
    [<TestCase(3.4<stone>, 21.591)>]
    [<TestCase(66.0<stone>, 419.119)>]
    let ``Convert known Stones to Kilograms`` (input, expectation) = 
        stone.toKilograms input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Stones to Tonnes and back`` () =
        let property value =
            let convertTo = stone.toTonnes (stone.create value)
            let convertBack = tonne.toStones convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100.0<stone>, 0.635029)>]
    [<TestCase(12345.0<stone>, 78.394369)>]
    [<TestCase(10099.0<stone>, 64.131611)>]
    let ``Convert known Stones to Tonnes`` (input, expectation) = 
        stone.toTonnes input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Stones to Ounces and back`` () =
        let property value =
            let convertTo = stone.toOunces (stone.create value)
            let convertBack = oz.toStones convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(34.0<stone>, 7616.0)>]
    [<TestCase(1.2<stone>, 268.8)>]
    [<TestCase(800.0<stone>, 179200.0)>]
    let ``Convert known Stones to Ounces`` (input, expectation) = 
        stone.toOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Stones to Pounds and back`` () =
        let property value =
            let convertTo = stone.toPounds (stone.create value)
            let convertBack = lb.toStones convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(800.0<stone>, 11200.0)>]
    [<TestCase(0.5<stone>, 7.0)>]
    [<TestCase(52.1<stone>, 729.4)>]
    let ``Convert known Stones to Pounds`` (input, expectation) = 
        stone.toPounds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tonnes to Milligrams and back`` () =
        let property value =
            let convertTo = tonne.toMilligrams (tonne.create value)
            let convertBack = mg.toTonnes convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.009<tonne>, 9000000.0)>]
    [<TestCase(0.00081<tonne>, 810000.0)>]
    [<TestCase(0.00123<tonne>, 1230000.0)>]
    let ``Convert known Tonnes to Milligrams`` (input, expectation) = 
        tonne.toMilligrams input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tonnes to Grams and back`` () =
        let property value =
            let convertTo = tonne.toGrams (tonne.create value)
            let convertBack = g.toTonnes convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.00123<tonne>, 1230.0)>]
    [<TestCase(0.8<tonne>, 800000.0)>]
    [<TestCase(0.03<tonne>, 30000.0)>]
    let ``Convert known Tonnes to Grams`` (input, expectation) = 
        tonne.toGrams input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tonnes to Kilograms and back`` () =
        let property value =
            let convertTo = tonne.toKilograms (tonne.create value)
            let convertBack = kg.toTonnes convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.03<tonne>, 30.0)>]
    [<TestCase(4.0<tonne>, 4000.0)>]
    [<TestCase(1.2<tonne>, 1200.0)>]
    let ``Convert known Tonnes to Kilograms`` (input, expectation) = 
        tonne.toKilograms input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tonnes to Ounces and back`` () =
        let property value =
            let convertTo = tonne.toOunces (tonne.create value)
            let convertBack = oz.toTonnes convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<tonne>, 42328.754376824065)>]
    [<TestCase(0.8<tonne>, 28219.169584549378)>]
    [<TestCase(0.001<tonne>, 35.273962)>]
    let ``Convert known Tonnes to Ounces`` (input, expectation) = 
        tonne.toOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tonnes to Pounds and back`` () =
        let property value =
            let convertTo = tonne.toPounds (tonne.create value)
            let convertBack = lb.toTonnes convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<tonne>, 2645.55)>]
    [<TestCase(0.9<tonne>, 1984.16)>]
    [<TestCase(34.0<tonne>, 74957.08)>]
    let ``Convert known Tonnes to Pounds`` (input, expectation) = 
        tonne.toPounds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tonnes to Stones and back`` () =
        let property value =
            let convertTo = tonne.toStones (tonne.create value)
            let convertBack = stone.toTonnes convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<tonne>, 1889.68)>]
    [<TestCase(8.4<tonne>, 1322.77)>]
    [<TestCase(0.3<tonne>, 47.2419)>]
    let ``Convert known Tonnes to Stones`` (input, expectation) = 
        tonne.toStones input
        |> should (equalWithin 0.01) expectation
