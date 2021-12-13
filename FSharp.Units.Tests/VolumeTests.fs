namespace FSharp.Units.Tests

module VolumeTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers


    [<Property>]
    let ``From Fluid Ounces to Millilitres and back`` () =
        let property value =
            let convertTo = floz.toMillilitres (floz.create value)
            let convertBack = ml.toFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<floz>, 340.957)>]
    [<TestCase(6.01<floz>, 170.7625)>]
    [<TestCase(0.78<floz>, 22.16219)>]
    let ``Convert known Fluid Ounces to Millilitres`` (input, expectation) = 
        floz.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fluid Ounces to Litres and back`` () =
        let property value =
            let convertTo = floz.toLitres (floz.create value)
            let convertBack = l.toFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(800.0<floz>, 22.7305)>]
    [<TestCase(4.5<floz>, 0.127859)>]
    [<TestCase(109.0<floz>, 3.09702)>]
    let ``Convert known Fluid Ounces to Litres`` (input, expectation) = 
        floz.toLitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fluid Ounces to Kilolitres and back`` () =
        let property value =
            let convertTo = floz.toKilolitres (floz.create value)
            let convertBack = kl.toFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(56909.0<floz>, 1.616959)>]
    [<TestCase(9009.0<floz>, 0.2559733)>]
    [<TestCase(123456.0<floz>, 3.50776304)>]
    let ``Convert known Fluid Ounces to Kilolitres`` (input, expectation) = 
        floz.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fluid Ounces to Teaspoons and back`` () =
        let property value =
            let convertTo = floz.toTeaspoons (floz.create value)
            let convertBack = tsp.toFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.0<floz>, 590.4)>]
    [<TestCase(9.12<floz>, 43.77598)>]
    [<TestCase(0.2<floz>, 0.96)>]
    let ``Convert known Fluid Ounces to Teaspoons`` (input, expectation) = 
        floz.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fluid Ounces to Tablespoons and back`` () =
        let property value =
            let convertTo = floz.toTablespoons (floz.create value)
            let convertBack = tbsp.toFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(7.0<floz>, 11.2)>]
    [<TestCase(165.4<floz>, 264.63989)>]
    [<TestCase(80.1<floz>, 128.1599)>]
    let ``Convert known Fluid Ounces to Tablespoons`` (input, expectation) = 
        floz.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fluid Ounces to Quarts and back`` () =
        let property value =
            let convertTo = floz.toQuarts (floz.create value)
            let convertBack = qt.toFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(89.0<floz>, 2.225)>]
    [<TestCase(5.9<floz>, 0.1475)>]
    [<TestCase(1300.0<floz>, 32.5)>]
    let ``Convert known Fluid Ounces to Quarts`` (input, expectation) = 
        floz.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fluid Ounces to Pints and back`` () =
        let property value =
            let convertTo = floz.toPints (floz.create value)
            let convertBack = pt.toFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1300.0<floz>, 65.0)>]
    [<TestCase(5.7<floz>, 0.285)>]
    [<TestCase(1900.0<floz>, 95.0)>]
    let ``Convert known Fluid Ounces to Pints`` (input, expectation) = 
        floz.toPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fluid Ounces to Gallons and back`` () =
        let property value =
            let convertTo = floz.toGallons (floz.create value)
            let convertBack = gal.toFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1900.0<floz>, 11.875)>]
    [<TestCase(5.6<floz>, 0.035)>]
    [<TestCase(12345.0<floz>, 77.15625)>]
    let ``Convert known Fluid Ounces to Gallons`` (input, expectation) = 
        floz.toGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fluid Ounces to US Teaspoons and back`` () =
        let property value =
            let convertTo = floz.toUSTeaspoons (floz.create value)
            let convertBack = ustsp.toFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12345.0<floz>, 71163.512)>]
    [<TestCase(8.9<floz>, 51.3046)>]
    [<TestCase(0.005<floz>, 0.028822808)>]
    let ``Convert known Fluid Ounces to US Teaspoons`` (input, expectation) = 
        floz.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fluid Ounces to US Tablespoons and back`` () =
        let property value =
            let convertTo = floz.toUSTablespoons (floz.create value)
            let convertBack = ustbsp.toFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190.0<floz>, 365.089)>]
    [<TestCase(6.8<floz>, 13.0663)>]
    [<TestCase(2340.0<floz>, 4496.357)>]
    let ``Convert known Fluid Ounces to US Tablespoons`` (input, expectation) = 
        floz.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fluid Ounces to US Quarts and back`` () =
        let property value =
            let convertTo = floz.toUSQuarts (floz.create value)
            let convertBack = usqt.toFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(45.0<floz>, 1.35107)>]
    [<TestCase(1090.0<floz>, 32.72589)>]
    [<TestCase(777.0<floz>, 23.3285)>]
    let ``Convert known Fluid Ounces to US Quarts`` (input, expectation) = 
        floz.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fluid Ounces to US Pints and back`` () =
        let property value =
            let convertTo = floz.toUSPints (floz.create value)
            let convertBack = uspt.toFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(678.0<floz>, 40.7122)>]
    [<TestCase(4.5<floz>, 0.270214)>]
    [<TestCase(1900.0<floz>, 114.0902)>]
    let ``Convert known Fluid Ounces to US Pints`` (input, expectation) = 
        floz.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fluid Ounces to US Gallons and back`` () =
        let property value =
            let convertTo = floz.toUSGallons (floz.create value)
            let convertBack = usgal.toFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1890.0<floz>, 14.18622)>]
    [<TestCase(5.8<floz>, 0.0435344)>]
    [<TestCase(10090.0<floz>, 75.734905)>]
    let ``Convert known Fluid Ounces to US Gallons`` (input, expectation) = 
        floz.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fluid Ounces to US Fluid Ounces and back`` () =
        let property value =
            let convertTo = floz.toUSFluidOunces (floz.create value)
            let convertBack = usfloz.toFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190.0<floz>, 182.544)>]
    [<TestCase(54.8<floz>, 52.64964)>]
    [<TestCase(1.7<floz>, 1.63329)>]
    let ``Convert known Fluid Ounces to US Fluid Ounces`` (input, expectation) = 
        floz.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fluid Ounces to US Cups and back`` () =
        let property value =
            let convertTo = floz.toUSCups (floz.create value)
            let convertBack = uscup.toFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.0<floz>, 0.72057)>]
    [<TestCase(1800.0<floz>, 216.171)>]
    [<TestCase(6.9<floz>, 0.828655)>]
    let ``Convert known Fluid Ounces to US Cups`` (input, expectation) = 
        floz.toUSCups input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gallons to Millilitres and back`` () =
        let property value =
            let convertTo = gal.toMillilitres (gal.create value)
            let convertBack = ml.toGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.3<gal>, 5909.92)>]
    [<TestCase(0.45<gal>, 2045.741)>]
    [<TestCase(1.8<gal>, 8182.96)>]
    let ``Convert known Gallons to Millilitres`` (input, expectation) = 
        gal.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gallons to Litres and back`` () =
        let property value =
            let convertTo = gal.toLitres (gal.create value)
            let convertBack = l.toGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.0<gal>, 559.169)>]
    [<TestCase(9.3<gal>, 42.2786)>]
    [<TestCase(0.67<gal>, 3.04588)>]
    let ``Convert known Gallons to Litres`` (input, expectation) = 
        gal.toLitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gallons to Kilolitres and back`` () =
        let property value =
            let convertTo = gal.toKilolitres (gal.create value)
            let convertBack = kl.toGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1009.0<gal>, 4.587005)>]
    [<TestCase(9.6<gal>, 0.0436425)>]
    [<TestCase(123456.0<gal>, 561.242087)>]
    let ``Convert known Gallons to Kilolitres`` (input, expectation) = 
        gal.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gallons to Teaspoons and back`` () =
        let property value =
            let convertTo = gal.toTeaspoons (gal.create value)
            let convertBack = tsp.toGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.0<gal>, 4608.0)>]
    [<TestCase(78.12<gal>, 59996.16)>]
    [<TestCase(0.34<gal>, 261.1199)>]
    let ``Convert known Gallons to Teaspoons`` (input, expectation) = 
        gal.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gallons to Tablespoons and back`` () =
        let property value =
            let convertTo = gal.toTablespoons (gal.create value)
            let convertBack = tbsp.toGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<gal>, 230.4)>]
    [<TestCase(1.6<gal>, 409.6)>]
    [<TestCase(0.33<gal>, 84.47997)>]
    let ``Convert known Gallons to Tablespoons`` (input, expectation) = 
        gal.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gallons to Quarts and back`` () =
        let property value =
            let convertTo = gal.toQuarts (gal.create value)
            let convertBack = qt.toGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<gal>, 436.0)>]
    [<TestCase(5.8<gal>, 23.2)>]
    [<TestCase(0.23<gal>, 0.92)>]
    let ``Convert known Gallons to Quarts`` (input, expectation) = 
        gal.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gallons to Pints and back`` () =
        let property value =
            let convertTo = gal.toPints (gal.create value)
            let convertBack = pt.toGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.23<gal>, 1.84)>]
    [<TestCase(190.0<gal>, 1520.0)>]
    [<TestCase(24.7<gal>, 197.6)>]
    let ``Convert known Gallons to Pints`` (input, expectation) = 
        gal.toPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gallons to Fluid Ounces and back`` () =
        let property value =
            let convertTo = gal.toFluidOunces (gal.create value)
            let convertBack = floz.toGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(24.7<gal>, 3952.0)>]
    [<TestCase(13.09<gal>, 2094.4)>]
    [<TestCase(5.8<gal>, 928.0)>]
    let ``Convert known Gallons to Fluid Ounces`` (input, expectation) = 
        gal.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gallons to US Teaspoons and back`` () =
        let property value =
            let convertTo = gal.toUSTeaspoons (gal.create value)
            let convertBack = ustsp.toGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.8<gal>, 5349.51)>]
    [<TestCase(0.44<gal>, 405.8251)>]
    [<TestCase(1.9<gal>, 1752.43)>]
    let ``Convert known Gallons to US Teaspoons`` (input, expectation) = 
        gal.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gallons to US Tablespoons and back`` () =
        let property value =
            let convertTo = gal.toUSTablespoons (gal.create value)
            let convertBack = ustbsp.toGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.8<gal>, 553.398)>]
    [<TestCase(0.33<gal>, 101.4562)>]
    [<TestCase(100.0<gal>, 30744.33080)>]
    let ``Convert known Gallons to US Tablespoons`` (input, expectation) = 
        gal.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gallons to US Quarts and back`` () =
        let property value =
            let convertTo = gal.toUSQuarts (gal.create value)
            let convertBack = usqt.toGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(78.0<gal>, 374.696)>]
    [<TestCase(1.7<gal>, 8.16646)>]
    [<TestCase(16.9<gal>, 81.18421)>]
    let ``Convert known Gallons to US Quarts`` (input, expectation) = 
        gal.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gallons to US Pints and back`` () =
        let property value =
            let convertTo = gal.toUSPints (gal.create value)
            let convertBack = uspt.toGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(13.4<gal>, 128.7418)>]
    [<TestCase(8.12<gal>, 78.01371)>]
    [<TestCase(0.99<gal>, 9.511523)>]
    let ``Convert known Gallons to US Pints`` (input, expectation) = 
        gal.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gallons to US Gallons and back`` () =
        let property value =
            let convertTo = gal.toUSGallons (gal.create value)
            let convertBack = usgal.toGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.5<gal>, 1.80142)>]
    [<TestCase(0.78<gal>, 0.9367409)>]
    [<TestCase(103.0<gal>, 123.698)>]
    let ``Convert known Gallons to US Gallons`` (input, expectation) = 
        gal.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gallons to US Fluid Ounces and back`` () =
        let property value =
            let convertTo = gal.toUSFluidOunces (gal.create value)
            let convertBack = usfloz.toGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(111.0<gal>, 17063.1)>]
    [<TestCase(89.9<gal>, 13819.57)>]
    [<TestCase(1.2<gal>, 184.466)>]
    let ``Convert known Gallons to US Fluid Ounces`` (input, expectation) = 
        gal.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gallons to US Cups and back`` () =
        let property value =
            let convertTo = gal.toUSCups (gal.create value)
            let convertBack = uscup.toGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<gal>, 23.0582)>]
    [<TestCase(0.55<gal>, 10.56836)>]
    [<TestCase(890.0<gal>, 17101.534007630)>]
    let ``Convert known Gallons to US Cups`` (input, expectation) = 
        gal.toUSCups input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilolitres to Millilitres and back`` () =
        let property value =
            let convertTo = kl.toMillilitres (kl.create value)
            let convertBack = ml.toKilolitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.09<kl>, 90000.0)>]
    [<TestCase(0.00123<kl>, 1230.0)>]
    [<TestCase(1.2<kl>, 1.2e+6)>]
    let ``Convert known Kilolitres to Millilitres`` (input, expectation) = 
        kl.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilolitres to Litres and back`` () =
        let property value =
            let convertTo = kl.toLitres (kl.create value)
            let convertBack = l.toKilolitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<kl>, 1200.0)>]
    [<TestCase(0.8<kl>, 800.0)>]
    [<TestCase(456.0<kl>, 456000.0)>]
    let ``Convert known Kilolitres to Litres`` (input, expectation) = 
        kl.toLitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilolitres to Teaspoons and back`` () =
        let property value =
            let convertTo = kl.toTeaspoons (kl.create value)
            let convertBack = tsp.toKilolitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.7<kl>, 118255.41900799)>]
    [<TestCase(0.01<kl>, 1689.363)>]
    [<TestCase(4.5<kl>, 760213.407908)>]
    let ``Convert known Kilolitres to Teaspoons`` (input, expectation) = 
        kl.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilolitres to Tablespoons and back`` () =
        let property value =
            let convertTo = kl.toTablespoons (kl.create value)
            let convertBack = tbsp.toKilolitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.3<kl>, 16893.631286856)>]
    [<TestCase(2.9<kl>, 163305.10243961)>]
    [<TestCase(0.067<kl>, 3772.911)>]
    let ``Convert known Kilolitres to Tablespoons`` (input, expectation) = 
        kl.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilolitres to Quarts and back`` () =
        let property value =
            let convertTo = kl.toQuarts (kl.create value)
            let convertBack = qt.toKilolitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.09<kl>, 79.18893)>]
    [<TestCase(2.3<kl>, 2023.72)>]
    [<TestCase(0.67<kl>, 589.5176)>]
    let ``Convert known Kilolitres to Quarts`` (input, expectation) = 
        kl.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilolitres to Pints and back`` () =
        let property value =
            let convertTo = kl.toPints (kl.create value)
            let convertBack = pt.toKilolitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.4<kl>, 703.902)>]
    [<TestCase(67.0<kl>, 117903.46835618)>]
    [<TestCase(9.3<kl>, 16365.7)>]
    let ``Convert known Kilolitres to Pints`` (input, expectation) = 
        kl.toPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilolitres to Gallons and back`` () =
        let property value =
            let convertTo = kl.toGallons (kl.create value)
            let convertBack = gal.toKilolitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<kl>, 23976.638149)>]
    [<TestCase(7.2<kl>, 1583.78)>]
    [<TestCase(0.4<kl>, 87.9877)>]
    let ``Convert known Kilolitres to Gallons`` (input, expectation) = 
        kl.toGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilolitres to Fluid Ounces and back`` () =
        let property value =
            let convertTo = kl.toFluidOunces (kl.create value)
            let convertBack = floz.toKilolitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.2<kl>, 7039.02)>]
    [<TestCase(4.8<kl>, 168936.31286856)>]
    [<TestCase(6.0<kl>, 211170.391085)>]
    let ``Convert known Kilolitres to Fluid Ounces`` (input, expectation) = 
        kl.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilolitres to US Teaspoons and back`` () =
        let property value =
            let convertTo = kl.toUSTeaspoons (kl.create value)
            let convertBack = ustsp.toKilolitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.0<kl>, 811536.5448442)>]
    [<TestCase(0.2<kl>, 40576.82724221160)>]
    [<TestCase(2.4<kl>, 486921.92690653)>]
    let ``Convert known Kilolitres to US Teaspoons`` (input, expectation) = 
        kl.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilolitres to US Tablespoons and back`` () =
        let property value =
            let convertTo = kl.toUSTablespoons (kl.create value)
            let convertBack = ustbsp.toKilolitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.3<kl>, 87916.45902479)>]
    [<TestCase(0.6<kl>, 40576.82724221)>]
    [<TestCase(0.03<kl>, 2028.841)>]
    let ``Convert known Kilolitres to US Tablespoons`` (input, expectation) = 
        kl.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilolitres to US Quarts and back`` () =
        let property value =
            let convertTo = kl.toUSQuarts (kl.create value)
            let convertBack = usqt.toKilolitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.09<kl>, 95.10194)>]
    [<TestCase(2.5<kl>, 2641.72)>]
    [<TestCase(178.9<kl>, 189041.52)>]
    let ``Convert known Kilolitres to US Quarts`` (input, expectation) = 
        kl.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilolitres to US Pints and back`` () =
        let property value =
            let convertTo = kl.toUSPints (kl.create value)
            let convertBack = uspt.toKilolitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(67.0<kl>, 141596.2200639)>]
    [<TestCase(4.7<kl>, 9932.87)>]
    [<TestCase(108.9<kl>, 230146.69)>]
    let ``Convert known Kilolitres to US Pints`` (input, expectation) = 
        kl.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilolitres to US Gallons and back`` () =
        let property value =
            let convertTo = kl.toUSGallons (kl.create value)
            let convertBack = usgal.toKilolitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.6<kl>, 422.675)>]
    [<TestCase(57.0<kl>, 15057.8)>]
    [<TestCase(0.88<kl>, 232.4714)>]
    let ``Convert known Kilolitres to US Gallons`` (input, expectation) = 
        kl.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilolitres to US Fluid Ounces and back`` () =
        let property value =
            let convertTo = kl.toUSFluidOunces (kl.create value)
            let convertBack = usfloz.toKilolitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.07<kl>, 2366.982)>]
    [<TestCase(4.2<kl>, 142018.89516765)>]
    [<TestCase(12.0<kl>, 405768.27190759)>]
    let ``Convert known Kilolitres to US Fluid Ounces`` (input, expectation) = 
        kl.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilolitres to US Cups and back`` () =
        let property value =
            let convertTo = kl.toUSCups (kl.create value)
            let convertBack = uscup.toKilolitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<kl>, 50721.03405276)>]
    [<TestCase(0.8<kl>, 3381.4)>]
    [<TestCase(6.2<kl>, 26205.86759392)>]
    let ``Convert known Kilolitres to US Cups`` (input, expectation) = 
        kl.toUSCups input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Litres to Millilitres and back`` () =
        let property value =
            let convertTo = l.toMillilitres (l.create value)
            let convertBack = ml.toLitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(34.0<l>, 34000.0)>]
    [<TestCase(0.67<l>, 670.0)>]
    [<TestCase(1.09<l>, 1090.0)>]
    let ``Convert known Litres to Millilitres`` (input, expectation) = 
        l.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Litres to Kilolitres and back`` () =
        let property value =
            let convertTo = l.toKilolitres (l.create value)
            let convertBack = kl.toLitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(200.0<l>, 0.2)>]
    [<TestCase(12345.0<l>, 12.345)>]
    [<TestCase(80.0<l>, 0.08)>]
    let ``Convert known Litres to Kilolitres`` (input, expectation) = 
        l.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Litres to Teaspoons and back`` () =
        let property value =
            let convertTo = l.toTeaspoons (l.create value)
            let convertBack = tsp.toLitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.0<l>, 506.809)>]
    [<TestCase(0.2<l>, 33.7873)>]
    [<TestCase(4.2<l>, 709.533)>]
    let ``Convert known Litres to Teaspoons`` (input, expectation) = 
        l.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Litres to Tablespoons and back`` () =
        let property value =
            let convertTo = l.toTablespoons (l.create value)
            let convertBack = tbsp.toLitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.0<l>, 168.936)>]
    [<TestCase(0.4<l>, 22.5248)>]
    [<TestCase(67.0<l>, 3772.91)>]
    let ``Convert known Litres to Tablespoons`` (input, expectation) = 
        l.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Litres to Quarts and back`` () =
        let property value =
            let convertTo = l.toQuarts (l.create value)
            let convertBack = qt.toLitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(54.0<l>, 47.5134)>]
    [<TestCase(2.0<l>, 1.75975)>]
    [<TestCase(0.7<l>, 0.615914)>]
    let ``Convert known Litres to Quarts`` (input, expectation) = 
        l.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Litres to Pints and back`` () =
        let property value =
            let convertTo = l.toPints (l.create value)
            let convertBack = pt.toLitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.5<l>, 0.879877)>]
    [<TestCase(145.0<l>, 255.164)>]
    [<TestCase(9.1<l>, 16.0138)>]
    let ``Convert known Litres to Pints`` (input, expectation) = 
        l.toPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Litres to Gallons and back`` () =
        let property value =
            let convertTo = l.toGallons (l.create value)
            let convertBack = gal.toLitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.9<l>, 2.837603)>]
    [<TestCase(109.0<l>, 23.9766)>]
    [<TestCase(67.0<l>, 14.7379)>]
    let ``Convert known Litres to Gallons`` (input, expectation) = 
        l.toGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Litres to Fluid Ounces and back`` () =
        let property value =
            let convertTo = l.toFluidOunces (l.create value)
            let convertBack = floz.toLitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.0<l>, 175.975)>]
    [<TestCase(0.3<l>, 10.5585)>]
    [<TestCase(1.1<l>, 38.7146)>]
    let ``Convert known Litres to Fluid Ounces`` (input, expectation) = 
        l.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Litres to US Teaspoons and back`` () =
        let property value =
            let convertTo = l.toUSTeaspoons (l.create value)
            let convertBack = ustsp.toLitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<l>, 2434.61)>]
    [<TestCase(0.7<l>, 142.019)>]
    [<TestCase(89.9<l>, 18239.29)>]
    let ``Convert known Litres to US Teaspoons`` (input, expectation) = 
        l.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Litres to US Tablespoons and back`` () =
        let property value =
            let convertTo = l.toUSTablespoons (l.create value)
            let convertBack = ustbsp.toLitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<l>, 811.537)>]
    [<TestCase(5.6<l>, 378.717)>]
    [<TestCase(0.5<l>, 33.814)>]
    let ``Convert known Litres to US Tablespoons`` (input, expectation) = 
        l.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Litres to US Quarts and back`` () =
        let property value =
            let convertTo = l.toUSQuarts (l.create value)
            let convertBack = usqt.toLitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<l>, 12.6803)>]
    [<TestCase(1.09<l>, 1.15179)>]
    [<TestCase(5.5<l>, 5.81179)>]
    let ``Convert known Litres to US Quarts`` (input, expectation) = 
        l.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Litres to US Pints and back`` () =
        let property value =
            let convertTo = l.toUSPints (l.create value)
            let convertBack = uspt.toLitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.4<l>, 7.18548)>]
    [<TestCase(0.8<l>, 1.6907)>]
    [<TestCase(3000.0<l>, 6340.129)>]
    let ``Convert known Litres to US Pints`` (input, expectation) = 
        l.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Litres to US Gallons and back`` () =
        let property value =
            let convertTo = l.toUSGallons (l.create value)
            let convertBack = usgal.toLitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.1<l>, 28.821171)>]
    [<TestCase(41.5<l>, 10.96314)>]
    [<TestCase(0.8<l>, 0.211338)>]
    let ``Convert known Litres to US Gallons`` (input, expectation) = 
        l.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Litres to US Fluid Ounces and back`` () =
        let property value =
            let convertTo = l.toUSFluidOunces (l.create value)
            let convertBack = usfloz.toLitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(81.0<l>, 2738.94)>]
    [<TestCase(7.3<l>, 246.842)>]
    [<TestCase(0.65<l>, 21.97911)>]
    let ``Convert known Litres to US Fluid Ounces`` (input, expectation) = 
        l.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Litres to US Cups and back`` () =
        let property value =
            let convertTo = l.toUSCups (l.create value)
            let convertBack = uscup.toLitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<l>, 3.80408)>]
    [<TestCase(103.9<l>, 439.15962)>]
    [<TestCase(71.6<l>, 302.6355)>]
    let ``Convert known Litres to US Cups`` (input, expectation) = 
        l.toUSCups input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millilitres to Litres and back`` () =
        let property value =
            let convertTo = ml.toLitres (ml.create value)
            let convertBack = l.toMillilitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1900.0<ml>, 1.9)>]
    [<TestCase(56789.0<ml>, 56.789)>]
    [<TestCase(567.0<ml>, 0.567)>]
    let ``Convert known Millilitres to Litres`` (input, expectation) = 
        ml.toLitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millilitres to Kilolitres and back`` () =
        let property value =
            let convertTo = ml.toKilolitres (ml.create value)
            let convertBack = kl.toMillilitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(10060000.0<ml>, 10.06)>]
    [<TestCase(987654.0<ml>, 0.987654)>]
    [<TestCase(405000.0<ml>, 0.405)>]
    let ``Convert known Millilitres to Kilolitres`` (input, expectation) = 
        ml.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millilitres to Teaspoons and back`` () =
        let property value =
            let convertTo = ml.toTeaspoons (ml.create value)
            let convertBack = tsp.toMillilitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.0<ml>, 0.168936)>]
    [<TestCase(56.0<ml>, 9.46043)>]
    [<TestCase(12.3<ml>, 2.077917)>]
    let ``Convert known Millilitres to Teaspoons`` (input, expectation) = 
        ml.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millilitres to Tablespoons and back`` () =
        let property value =
            let convertTo = ml.toTablespoons (ml.create value)
            let convertBack = tbsp.toMillilitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<ml>, 6.13802)>]
    [<TestCase(88.0<ml>, 4.95547)>]
    [<TestCase(12.0<ml>, 0.675745)>]
    let ``Convert known Millilitres to Tablespoons`` (input, expectation) = 
        ml.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millilitres to Quarts and back`` () =
        let property value =
            let convertTo = ml.toQuarts (ml.create value)
            let convertBack = qt.toMillilitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(890.0<ml>, 0.783091)>]
    [<TestCase(12345.0<ml>, 10.862081)>]
    [<TestCase(129.0<ml>, 0.113504)>]
    let ``Convert known Millilitres to Quarts`` (input, expectation) = 
        ml.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millilitres to Pints and back`` () =
        let property value =
            let convertTo = ml.toPints (ml.create value)
            let convertBack = pt.toMillilitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(124.0<ml>, 0.218209)>]
    [<TestCase(99.0<ml>, 0.174216)>]
    [<TestCase(607.3<ml>, 1.0686986)>]
    let ``Convert known Millilitres to Pints`` (input, expectation) = 
        ml.toPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millilitres to Gallons and back`` () =
        let property value =
            let convertTo = ml.toGallons (ml.create value)
            let convertBack = gal.toMillilitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1234.0<ml>, 0.2714421)>]
    [<TestCase(9000.0<ml>, 1.979723)>]
    [<TestCase(10209.98<ml>, 2.2458816257)>]
    let ``Convert known Millilitres to Gallons`` (input, expectation) = 
        ml.toGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millilitres to Fluid Ounces and back`` () =
        let property value =
            let convertTo = ml.toFluidOunces (ml.create value)
            let convertBack = floz.toMillilitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(78.0<ml>, 2.74522)>]
    [<TestCase(12.9<ml>, 0.4540165)>]
    [<TestCase(1009.0<ml>, 35.51184)>]
    let ``Convert known Millilitres to Fluid Ounces`` (input, expectation) = 
        ml.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millilitres to US Teaspoons and back`` () =
        let property value =
            let convertTo = ml.toUSTeaspoons (ml.create value)
            let convertBack = ustsp.toMillilitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100.0<ml>, 20.2884)>]
    [<TestCase(12.3<ml>, 2.495476)>]
    [<TestCase(69.0<ml>, 13.999)>]
    let ``Convert known Millilitres to US Teaspoons`` (input, expectation) = 
        ml.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millilitres to US Tablespoons and back`` () =
        let property value =
            let convertTo = ml.toUSTablespoons (ml.create value)
            let convertBack = ustbsp.toMillilitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(38.0<ml>, 2.56987)>]
    [<TestCase(1023.0<ml>, 69.18349)>]
    [<TestCase(88.8<ml>, 6.00537)>]
    let ``Convert known Millilitres to US Tablespoons`` (input, expectation) = 
        ml.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millilitres to US Quarts and back`` () =
        let property value =
            let convertTo = ml.toUSQuarts (ml.create value)
            let convertBack = usqt.toMillilitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1009.0<ml>, 1.066198)>]
    [<TestCase(4567.0<ml>, 4.825895)>]
    [<TestCase(8009.0<ml>, 8.463016)>]
    let ``Convert known Millilitres to US Quarts`` (input, expectation) = 
        ml.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millilitres to US Pints and back`` () =
        let property value =
            let convertTo = ml.toUSPints (ml.create value)
            let convertBack = uspt.toMillilitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(110.0<ml>, 0.232471)>]
    [<TestCase(2032.0<ml>, 4.294381)>]
    [<TestCase(1000.9<ml>, 2.11527846)>]
    let ``Convert known Millilitres to US Pints`` (input, expectation) = 
        ml.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millilitres to US Gallons and back`` () =
        let property value =
            let convertTo = ml.toUSGallons (ml.create value)
            let convertBack = usgal.toMillilitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5000.0<ml>, 1.32086)>]
    [<TestCase(123456.0<ml>, 32.6136249)>]
    [<TestCase(900.0<ml>, 0.237755)>]
    let ``Convert known Millilitres to US Gallons`` (input, expectation) = 
        ml.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millilitres to US Fluid Ounces and back`` () =
        let property value =
            let convertTo = ml.toUSFluidOunces (ml.create value)
            let convertBack = usfloz.toMillilitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(67.0<ml>, 2.26554)>]
    [<TestCase(12.6<ml>, 0.4260567)>]
    [<TestCase(11009.0<ml>, 372.25858)>]
    let ``Convert known Millilitres to US Fluid Ounces`` (input, expectation) = 
        ml.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Millilitres to US Cups and back`` () =
        let property value =
            let convertTo = ml.toUSCups (ml.create value)
            let convertBack = uscup.toMillilitres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(348.0<ml>, 1.47091)>]
    [<TestCase(12.9<ml>, 0.05452511)>]
    [<TestCase(700.0<ml>, 2.95873)>]
    let ``Convert known Millilitres to US Cups`` (input, expectation) = 
        ml.toUSCups input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pints to Millilitres and back`` () =
        let property value =
            let convertTo = pt.toMillilitres (pt.create value)
            let convertBack = ml.toPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.7<pt>, 397.783)>]
    [<TestCase(5.6<pt>, 3182.26)>]
    [<TestCase(6.0<pt>, 3409.57)>]
    let ``Convert known Pints to Millilitres`` (input, expectation) = 
        pt.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pints to Litres and back`` () =
        let property value =
            let convertTo = pt.toLitres (pt.create value)
            let convertBack = l.toPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.0<pt>, 3.40957)>]
    [<TestCase(0.123<pt>, 0.069896134)>]
    [<TestCase(45.9<pt>, 26.08319)>]
    let ``Convert known Pints to Litres`` (input, expectation) = 
        pt.toLitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pints to Kilolitres and back`` () =
        let property value =
            let convertTo = pt.toKilolitres (pt.create value)
            let convertBack = kl.toPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(456.0<pt>, 0.259127)>]
    [<TestCase(10450.0<pt>, 5.9383301)>]
    [<TestCase(9000.9<pt>, 5.11486269)>]
    let ``Convert known Pints to Kilolitres`` (input, expectation) = 
        pt.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pints to Teaspoons and back`` () =
        let property value =
            let convertTo = pt.toTeaspoons (pt.create value)
            let convertBack = tsp.toPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.0<pt>, 480.0)>]
    [<TestCase(0.3<pt>, 28.8)>]
    [<TestCase(190.0<pt>, 18240.0)>]
    let ``Convert known Pints to Teaspoons`` (input, expectation) = 
        pt.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pints to Tablespoons and back`` () =
        let property value =
            let convertTo = pt.toTablespoons (pt.create value)
            let convertBack = tbsp.toPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(187.0<pt>, 5984.0)>]
    [<TestCase(54.5<pt>, 1743.999)>]
    [<TestCase(0.33<pt>, 10.56)>]
    let ``Convert known Pints to Tablespoons`` (input, expectation) = 
        pt.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pints to Quarts and back`` () =
        let property value =
            let convertTo = pt.toQuarts (pt.create value)
            let convertBack = qt.toPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.6<pt>, 2.8)>]
    [<TestCase(109.0<pt>, 54.5)>]
    [<TestCase(0.3<pt>, 0.15)>]
    let ``Convert known Pints to Quarts`` (input, expectation) = 
        pt.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pints to Gallons and back`` () =
        let property value =
            let convertTo = pt.toGallons (pt.create value)
            let convertBack = gal.toPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.3<pt>, 0.0375)>]
    [<TestCase(800.<pt>, 100.0)>]
    [<TestCase(1.5<pt>, 0.1875)>]
    let ``Convert known Pints to Gallons`` (input, expectation) = 
        pt.toGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pints to Fluid Ounces and back`` () =
        let property value =
            let convertTo = pt.toFluidOunces (pt.create value)
            let convertBack = floz.toPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.5<pt>, 30.0)>]
    [<TestCase(789.0<pt>, 15780.0)>]
    [<TestCase(1020.8<pt>, 20416.0)>]
    let ``Convert known Pints to Fluid Ounces`` (input, expectation) = 
        pt.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pints to US Teaspoons and back`` () =
        let property value =
            let convertTo = pt.toUSTeaspoons (pt.create value)
            let convertBack = ustsp.toPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1020.8<pt>, 117689.298303295)>]
    [<TestCase(0.4<pt>, 46.1165)>]
    [<TestCase(104.0<pt>, 11990.2890120912)>]
    let ``Convert known Pints to US Teaspoons`` (input, expectation) = 
        pt.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pints to US Tablespoons and back`` () =
        let property value =
            let convertTo = pt.toUSTablespoons (pt.create value)
            let convertBack = ustbsp.toPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(104.0<pt>, 3996.76)>]
    [<TestCase(5.6<pt>, 215.21)>]
    [<TestCase(0.4<pt>, 15.3722)>]
    let ``Convert known Pints to US Tablespoons`` (input, expectation) = 
        pt.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pints to US Quarts and back`` () =
        let property value =
            let convertTo = pt.toUSQuarts (pt.create value)
            let convertBack = usqt.toPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.55<pt>, 0.3302612)>]
    [<TestCase(80.6<pt>, 48.39828)>]
    [<TestCase(12.0<pt>, 7.2057)>]
    let ``Convert known Pints to US Quarts`` (input, expectation) = 
        pt.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pints to US Pints and back`` () =
        let property value =
            let convertTo = pt.toUSPints (pt.create value)
            let convertBack = uspt.toPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<pt>, 14.4114)>]
    [<TestCase(4.7<pt>, 5.64446)>]
    [<TestCase(0.44<pt>, 0.528418)>]
    let ``Convert known Pints to US Pints`` (input, expectation) = 
        pt.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pints to US Gallons and back`` () =
        let property value =
            let convertTo = pt.toUSGallons (pt.create value)
            let convertBack = usgal.toPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<pt>, 0.180142)>]
    [<TestCase(9000.0<pt>, 1351.069)>]
    [<TestCase(108.4<pt>, 16.272871)>]
    let ``Convert known Pints to US Gallons`` (input, expectation) = 
        pt.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pints to US Fluid Ounces and back`` () =
        let property value =
            let convertTo = pt.toUSFluidOunces (pt.create value)
            let convertBack = usfloz.toPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(108.0<pt>, 2075.24)>]
    [<TestCase(23.4<pt>, 449.6357)>]
    [<TestCase(8.65<pt>, 166.2115)>]
    let ``Convert known Pints to US Fluid Ounces`` (input, expectation) = 
        pt.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pints to US Cups and back`` () =
        let property value =
            let convertTo = pt.toUSCups (pt.create value)
            let convertBack = uscup.toPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(23.0<pt>, 55.2437)>]
    [<TestCase(3.0<pt>, 7.2057)>]
    [<TestCase(50.6<pt>, 121.5361)>]
    let ``Convert known Pints to US Cups`` (input, expectation) = 
        pt.toUSCups input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Quarts to Millilitres and back`` () =
        let property value =
            let convertTo = qt.toMillilitres (qt.create value)
            let convertBack = ml.toQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.4<qt>, 1591.13)>]
    [<TestCase(800.0<qt>, 909218.37579999)>]
    [<TestCase(0.7<qt>, 795.566)>]
    let ``Convert known Quarts to Millilitres`` (input, expectation) = 
        qt.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Quarts to Litres and back`` () =
        let property value =
            let convertTo = qt.toLitres (qt.create value)
            let convertBack = l.toQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(675.0<qt>, 767.153)>]
    [<TestCase(45.8<qt>, 52.05273)>]
    [<TestCase(0.8<qt>, 0.909218)>]
    let ``Convert known Quarts to Litres`` (input, expectation) = 
        qt.toLitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Quarts to Kilolitres and back`` () =
        let property value =
            let convertTo = qt.toKilolitres (qt.create value)
            let convertBack = kl.toQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8009.0<qt>, 9.102409)>]
    [<TestCase(12345.0<qt>, 14.03037)>]
    [<TestCase(601.0<qt>, 0.68305)>]
    let ``Convert known Quarts to Kilolitres`` (input, expectation) = 
        qt.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Quarts to Teaspoons and back`` () =
        let property value =
            let convertTo = qt.toTeaspoons (qt.create value)
            let convertBack = tsp.toQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.0<qt>, 1152.0)>]
    [<TestCase(0.9<qt>, 172.8)>]
    [<TestCase(0.03<qt>, 5.759998)>]
    let ``Convert known Quarts to Teaspoons`` (input, expectation) = 
        qt.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Quarts to Tablespoons and back`` () =
        let property value =
            let convertTo = qt.toTablespoons (qt.create value)
            let convertBack = tbsp.toQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.9<qt>, 377.6)>]
    [<TestCase(0.34<qt>, 21.75999)>]
    [<TestCase(2.9<qt>, 185.6)>]
    let ``Convert known Quarts to Tablespoons`` (input, expectation) = 
        qt.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Quarts to Pints and back`` () =
        let property value =
            let convertTo = qt.toPints (qt.create value)
            let convertBack = pt.toQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.5<qt>, 9.0)>]
    [<TestCase(102.8<qt>, 205.6)>]
    [<TestCase(0.46<qt>, 0.92)>]
    let ``Convert known Quarts to Pints`` (input, expectation) = 
        qt.toPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Quarts to Gallons and back`` () =
        let property value =
            let convertTo = qt.toGallons (qt.create value)
            let convertBack = gal.toQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.46<qt>, 0.115)>]
    [<TestCase(190.0<qt>, 47.5)>]
    [<TestCase(67.6<qt>, 16.9)>]
    let ``Convert known Quarts to Gallons`` (input, expectation) = 
        qt.toGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Quarts to Fluid Ounces and back`` () =
        let property value =
            let convertTo = qt.toFluidOunces (qt.create value)
            let convertBack = floz.toQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(67.6<qt>, 2704)>]
    [<TestCase(1009.0<qt>, 40360.0)>]
    [<TestCase(6.2<qt>, 248.0)>]
    let ``Convert known Quarts to Fluid Ounces`` (input, expectation) = 
        qt.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Quarts to US Teaspoons and back`` () =
        let property value =
            let convertTo = qt.toUSTeaspoons (qt.create value)
            let convertBack = ustsp.toQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.2<qt>, 1429.61)>]
    [<TestCase(0.7<qt>, 161.408)>]
    [<TestCase(80.3<qt>, 18515.77)>]
    let ``Convert known Quarts to US Teaspoons`` (input, expectation) = 
        qt.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Quarts to US Tablespoons and back`` () =
        let property value =
            let convertTo = qt.toUSTablespoons (qt.create value)
            let convertBack = ustbsp.toQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(80.0<qt>, 6148.86)>]
    [<TestCase(5.7<qt>, 438.107)>]
    [<TestCase(0.44<qt>, 33.81875)>]
    let ``Convert known Quarts to US Tablespoons`` (input, expectation) = 
        qt.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Quarts to US Quarts and back`` () =
        let property value =
            let convertTo = qt.toUSQuarts (qt.create value)
            let convertBack = usqt.toQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.44<qt>, 0.528418)>]
    [<TestCase(12.7<qt>, 15.25206)>]
    [<TestCase(109.0<qt>, 130.904)>]
    let ``Convert known Quarts to US Quarts`` (input, expectation) = 
        qt.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Quarts to US Pints and back`` () =
        let property value =
            let convertTo = qt.toUSPints (qt.create value)
            let convertBack = uspt.toQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(18.0<qt>, 43.2342)>]
    [<TestCase(2.5<qt>, 6.00475)>]
    [<TestCase(0.4<qt>, 0.96076)>]
    let ``Convert known Quarts to US Pints`` (input, expectation) = 
        qt.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Quarts to US Gallons and back`` () =
        let property value =
            let convertTo = qt.toUSGallons (qt.create value)
            let convertBack = usgal.toQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.8<qt>, 1.44114)>]
    [<TestCase(0.3<qt>, 0.0900712)>]
    [<TestCase(1.5<qt>, 0.450356)>]
    let ``Convert known Quarts to US Gallons`` (input, expectation) = 
        qt.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Quarts to US Fluid Ounces and back`` () =
        let property value =
            let convertTo = qt.toUSFluidOunces (qt.create value)
            let convertBack = usfloz.toQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.0<qt>, 230.582)>]
    [<TestCase(0.46<qt>, 17.67798)>]
    [<TestCase(2.0<qt>, 76.8608)>]
    let ``Convert known Quarts to US Fluid Ounces`` (input, expectation) = 
        qt.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Quarts to US Cups and back`` () =
        let property value =
            let convertTo = qt.toUSCups (qt.create value)
            let convertBack = uscup.toQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.0<qt>, 9.6076)>]
    [<TestCase(800.9<qt>, 3847.3632)>]
    [<TestCase(0.23<qt>, 1.104874)>]
    let ``Convert known Quarts to US Cups`` (input, expectation) = 
        qt.toUSCups input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tablespoons to Millilitres and back`` () =
        let property value =
            let convertTo = tbsp.toMillilitres (tbsp.create value)
            let convertBack = ml.toTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.7<tbsp>, 47.9471)>]
    [<TestCase(0.65<tbsp>, 11.54281)>]
    [<TestCase(80.1<tbsp>, 1422.43)>]
    let ``Convert known Tablespoons to Millilitres`` (input, expectation) = 
        tbsp.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tablespoons to Litres and back`` () =
        let property value =
            let convertTo = tbsp.toLitres (tbsp.create value)
            let convertBack = l.toTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(55.0<tbsp>, 0.976699)>]
    [<TestCase(190.0<tbsp>, 3.37405)>]
    [<TestCase(4000.0<tbsp>, 71.0397889)>]
    let ``Convert known Tablespoons to Litres`` (input, expectation) = 
        tbsp.toLitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tablespoons to Kilolitres and back`` () =
        let property value =
            let convertTo = tbsp.toKilolitres (tbsp.create value)
            let convertBack = kl.toTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(10000.0<tbsp>, 0.1775817)>]
    [<TestCase(98765.0<tbsp>, 1.7538858)>]
    [<TestCase(666999.0<tbsp>, 11.8446826)>]
    let ``Convert known Tablespoons to Kilolitres`` (input, expectation) = 
        tbsp.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tablespoons to Teaspoons and back`` () =
        let property value =
            let convertTo = tbsp.toTeaspoons (tbsp.create value)
            let convertBack = tsp.toTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<tbsp>, 36.0)>]
    [<TestCase(0.24<tbsp>, 0.72)>]
    [<TestCase(19.9<tbsp>, 59.7)>]
    let ``Convert known Tablespoons to Teaspoons`` (input, expectation) = 
        tbsp.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tablespoons to Quarts and back`` () =
        let property value =
            let convertTo = tbsp.toQuarts (tbsp.create value)
            let convertBack = qt.toTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190.0<tbsp>, 2.96875)>]
    [<TestCase(9.0<tbsp>, 0.140625)>]
    [<TestCase(3.7<tbsp>, 0.0578125)>]
    let ``Convert known Tablespoons to Quarts`` (input, expectation) = 
        tbsp.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tablespoons to Pints and back`` () =
        let property value =
            let convertTo = tbsp.toPints (tbsp.create value)
            let convertBack = pt.toTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.7<tbsp>, 0.146875)>]
    [<TestCase(190.0<tbsp>, 5.9375)>]
    [<TestCase(1090.9<tbsp>, 34.0906391)>]
    let ``Convert known Tablespoons to Pints`` (input, expectation) = 
        tbsp.toPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tablespoons to Gallons and back`` () =
        let property value =
            let convertTo = tbsp.toGallons (tbsp.create value)
            let convertBack = gal.toTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8000.0<tbsp>, 31.25001)>]
    [<TestCase(54.0<tbsp>, 0.210938)>]
    [<TestCase(99.3<tbsp>, 0.3878908)>]
    let ``Convert known Tablespoons to Gallons`` (input, expectation) = 
        tbsp.toGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tablespoons to Fluid Ounces and back`` () =
        let property value =
            let convertTo = tbsp.toFluidOunces (tbsp.create value)
            let convertBack = floz.toTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(80.8<tbsp>, 50.50002)>]
    [<TestCase(9009.0<tbsp>, 5630.627)>]
    [<TestCase(12.6<tbsp>, 7.875003)>]
    let ``Convert known Tablespoons to Fluid Ounces`` (input, expectation) = 
        tbsp.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tablespoons to US Teaspoons and back`` () =
        let property value =
            let convertTo = tbsp.toUSTeaspoons (tbsp.create value)
            let convertBack = ustsp.toTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<tbsp>, 43.2342)>]
    [<TestCase(0.6<tbsp>, 2.16171)>]
    [<TestCase(52.9<tbsp>, 190.5909)>]
    let ``Convert known Tablespoons to US Teaspoons`` (input, expectation) = 
        tbsp.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tablespoons to US Tablespoons and back`` () =
        let property value =
            let convertTo = tbsp.toUSTablespoons (tbsp.create value)
            let convertBack = ustbsp.toTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(67.0<tbsp>, 80.4637)>]
    [<TestCase(5.8<tbsp>, 6.96551)>]
    [<TestCase(0.23<tbsp>, 0.2762186)>]
    let ``Convert known Tablespoons to US Tablespoons`` (input, expectation) = 
        tbsp.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tablespoons to US Quarts and back`` () =
        let property value =
            let convertTo = tbsp.toUSQuarts (tbsp.create value)
            let convertBack = usqt.toTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(54.0<tbsp>, 1.0133)>]
    [<TestCase(1005.9<tbsp>, 18.875563)>]
    [<TestCase(0.9<tbsp>, 0.0168884)>]
    let ``Convert known Tablespoons to US Quarts`` (input, expectation) = 
        tbsp.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tablespoons to US Pints and back`` () =
        let property value =
            let convertTo = tbsp.toUSPints (tbsp.create value)
            let convertBack = uspt.toTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(34.0<tbsp>, 1.27601)>]
    [<TestCase(109.3<tbsp>, 4.1019963)>]
    [<TestCase(190.0<tbsp>, 7.13064)>]
    let ``Convert known Tablespoons to US Pints`` (input, expectation) = 
        tbsp.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tablespoons to US Gallons and back`` () =
        let property value =
            let convertTo = tbsp.toUSGallons (tbsp.create value)
            let convertBack = usgal.toTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<tbsp>, 4.22209)>]
    [<TestCase(2.8<tbsp>, 0.0131354)>]
    [<TestCase(1469.0<tbsp>, 6.891391)>]
    let ``Convert known Tablespoons to US Gallons`` (input, expectation) = 
        tbsp.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tablespoons to US Fluid Ounces and back`` () =
        let property value =
            let convertTo = tbsp.toUSFluidOunces (tbsp.create value)
            let convertBack = usfloz.toTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1009.0<tbsp>, 605.8795)>]
    [<TestCase(8.2<tbsp>, 4.9239)>]
    [<TestCase(190.5<tbsp>, 114.39053)>]
    let ``Convert known Tablespoons to US Fluid Ounces`` (input, expectation) = 
        tbsp.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Tablespoons to US Cups and back`` () =
        let property value =
            let convertTo = tbsp.toUSCups (tbsp.create value)
            let convertBack = uscup.toTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<tbsp>, 8.18147)>]
    [<TestCase(3.4<tbsp>, 0.255202)>]
    [<TestCase(1000.0<tbsp>, 75.0594)>]
    let ``Convert known Tablespoons to US Cups`` (input, expectation) = 
        tbsp.toUSCups input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Teaspoons to Millilitres and back`` () =
        let property value =
            let convertTo = tsp.toMillilitres (tsp.create value)
            let convertBack = ml.toTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.6<tsp>, 3.55163)>]
    [<TestCase(1.3<tsp>, 7.69521)>]
    [<TestCase(0.07<tsp>, 0.4143573)>]
    let ``Convert known Teaspoons to Millilitres`` (input, expectation) = 
        tsp.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Teaspoons to Litres and back`` () =
        let property value =
            let convertTo = tsp.toLitres (tsp.create value)
            let convertBack = l.toTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(32.0<tsp>, 0.18942)>]
    [<TestCase(180.0<tsp>, 1.06549)>]
    [<TestCase(4567.0<tsp>, 27.03386)>]
    let ``Convert known Teaspoons to Litres`` (input, expectation) = 
        tsp.toLitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Teaspoons to Kilolitres and back`` () =
        let property value =
            let convertTo = tsp.toKilolitres (tsp.create value)
            let convertBack = kl.toTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(236511.0<tsp>, 1.4)>]
    [<TestCase(33787.3<tsp>, 0.2)>]
    [<TestCase(1689.363<tsp>, 0.01)>]
    let ``Convert known Teaspoons to Kilolitres`` (input, expectation) = 
        tsp.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Teaspoons to Tablespoons and back`` () =
        let property value =
            let convertTo = tsp.toTablespoons (tsp.create value)
            let convertBack = tbsp.toTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<tsp>, 4.0)>]
    [<TestCase(900.8<tsp>, 300.26667)>]
    [<TestCase(1.23<tsp>, 0.41)>]
    let ``Convert known Teaspoons to Tablespoons`` (input, expectation) = 
        tsp.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Teaspoons to Quarts and back`` () =
        let property value =
            let convertTo = tsp.toQuarts (tsp.create value)
            let convertBack = qt.toTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<tsp>, 0.567709)>]
    [<TestCase(4500.0<tsp>, 23.43751)>]
    [<TestCase(89.0<tsp>, 0.463542)>]
    let ``Convert known Teaspoons to Quarts`` (input, expectation) = 
        tsp.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Teaspoons to Pints and back`` () =
        let property value =
            let convertTo = tsp.toPints (tsp.create value)
            let convertBack = pt.toTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(678.0<tsp>, 7.0625)>]
    [<TestCase(109.0<tsp>, 1.13542)>]
    [<TestCase(12.5<tsp>, 0.1302084)>]
    let ``Convert known Teaspoons to Pints`` (input, expectation) = 
        tsp.toPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Teaspoons to Gallons and back`` () =
        let property value =
            let convertTo = tsp.toGallons (tsp.create value)
            let convertBack = gal.toTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190.0<tsp>, 0.247396)>]
    [<TestCase(8090.0<tsp>, 10.53386)>]
    [<TestCase(238.9<tsp>, 0.31106784)>]
    let ``Convert known Teaspoons to Gallons`` (input, expectation) = 
        tsp.toGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Teaspoons to Fluid Ounces and back`` () =
        let property value =
            let convertTo = tsp.toFluidOunces (tsp.create value)
            let convertBack = floz.toTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<tsp>, 22.7083)>]
    [<TestCase(55.7<tsp>, 11.60417)>]
    [<TestCase(609.0<tsp>, 126.875)>]
    let ``Convert known Teaspoons to Fluid Ounces`` (input, expectation) = 
        tsp.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Teaspoons to US Teaspoons and back`` () =
        let property value =
            let convertTo = tsp.toUSTeaspoons (tsp.create value)
            let convertBack = ustsp.toTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(90.0<tsp>, 108.086)>]
    [<TestCase(1.45<tsp>, 1.741379)>]
    [<TestCase(80.1<tsp>, 96.19616)>]
    let ``Convert known Teaspoons to US Teaspoons`` (input, expectation) = 
        tsp.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Teaspoons to US Tablespoons and back`` () =
        let property value =
            let convertTo = tsp.toUSTablespoons (tsp.create value)
            let convertBack = ustbsp.toTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(56.0<tsp>, 22.4177)>]
    [<TestCase(7.0<tsp>, 2.80222)>]
    [<TestCase(109.0<tsp>, 43.6345)>]
    let ``Convert known Teaspoons to US Tablespoons`` (input, expectation) = 
        tsp.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Teaspoons to US Quarts and back`` () =
        let property value =
            let convertTo = tsp.toUSQuarts (tsp.create value)
            let convertBack = usqt.toTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(199.0<tsp>, 1.24474)>]
    [<TestCase(5.9<tsp>, 0.0369042)>]
    [<TestCase(23.0<tsp>, 0.143864)>]
    let ``Convert known Teaspoons to US Quarts`` (input, expectation) = 
        tsp.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Teaspoons to US Pints and back`` () =
        let property value =
            let convertTo = tsp.toUSPints (tsp.create value)
            let convertBack = uspt.toTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(106.0<tsp>, 1.32605)>]
    [<TestCase(34.0<tsp>, 0.425337)>]
    [<TestCase(6.21<tsp>, 0.07656059)>]
    let ``Convert known Teaspoons to US Pints`` (input, expectation) = 
        tsp.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Teaspoons to US Gallons and back`` () =
        let property value =
            let convertTo = tsp.toUSGallons (tsp.create value)
            let convertBack = usgal.toTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<tsp>, 1.40736)>]
    [<TestCase(1234.6<tsp>, 1.93059035)>]
    [<TestCase(88.0<tsp>, 0.137609)>]
    let ``Convert known Teaspoons to US Gallons`` (input, expectation) = 
        tsp.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Teaspoons to US Fluid Ounces and back`` () =
        let property value =
            let convertTo = tsp.toUSFluidOunces (tsp.create value)
            let convertBack = usfloz.toTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(56.0<tsp>, 11.2089)>]
    [<TestCase(2.9<tsp>, 0.580459)>]
    [<TestCase(1020.0<tsp>, 204.1616)>]
    let ``Convert known Teaspoons to US Fluid Ounces`` (input, expectation) = 
        tsp.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Teaspoons to US Cups and back`` () =
        let property value =
            let convertTo = tsp.toUSCups (tsp.create value)
            let convertBack = uscup.toTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8000.0<tsp>, 200.1584)>]
    [<TestCase(34.0<tsp>, 0.850673)>]
    [<TestCase(109.9<tsp>, 2.7496761)>]
    let ``Convert known Teaspoons to US Cups`` (input, expectation) = 
        tsp.toUSCups input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Cups to Millilitres and back`` () =
        let property value =
            let convertTo = uscup.toMillilitres (uscup.create value)
            let convertBack = ml.toUSCups convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(11.0<uscup>, 2602.47)>]
    [<TestCase(109.0<uscup>, 25788.1177)>]
    [<TestCase(4.5<uscup>, 1064.65)>]
    let ``Convert known US Cups to Millilitres`` (input, expectation) = 
        uscup.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Cups to Litres and back`` () =
        let property value =
            let convertTo = uscup.toLitres (uscup.create value)
            let convertBack = l.toUSCups convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(56.0<uscup>, 13.2489)>]
    [<TestCase(4.1<uscup>, 0.970012)>]
    [<TestCase(399.0<uscup>, 94.3987)>]
    let ``Convert known US Cups to Litres`` (input, expectation) = 
        uscup.toLitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Cups to Kilolitres and back`` () =
        let property value =
            let convertTo = uscup.toKilolitres (uscup.create value)
            let convertBack = kl.toUSCups convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(67.0<uscup>, 0.0158514)>]
    [<TestCase(1009.7<uscup>, 0.238883142)>]
    [<TestCase(918273.0<uscup>, 217.25259)>]
    let ``Convert known US Cups to Kilolitres`` (input, expectation) = 
        uscup.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Cups to Teaspoons and back`` () =
        let property value =
            let convertTo = uscup.toTeaspoons (uscup.create value)
            let convertBack = tsp.toUSCups convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.0<uscup>, 159.873)>]
    [<TestCase(0.2<uscup>, 7.99367)>]
    [<TestCase(6.12<uscup>, 244.6063)>]
    let ``Convert known US Cups to Teaspoons`` (input, expectation) = 
        uscup.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Cups to Tablespoons and back`` () =
        let property value =
            let convertTo = uscup.toTablespoons (uscup.create value)
            let convertBack = tbsp.toUSCups convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.3<uscup>, 57.288)>]
    [<TestCase(120.6<uscup>, 1606.7274)>]
    [<TestCase(0.66<uscup>, 8.793036)>]
    let ``Convert known US Cups to Tablespoons`` (input, expectation) = 
        uscup.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Cups to Quarts and back`` () =
        let property value =
            let convertTo = uscup.toQuarts (uscup.create value)
            let convertBack = qt.toUSCups convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1009.0<uscup>, 210.0421)>]
    [<TestCase(66.98<uscup>, 13.943129)>]
    [<TestCase(0.123<uscup>, 0.025604731)>]
    let ``Convert known US Cups to Quarts`` (input, expectation) = 
        uscup.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Cups to Pints and back`` () =
        let property value =
            let convertTo = uscup.toPints (uscup.create value)
            let convertBack = pt.toUSCups convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.0<uscup>, 2.08169)>]
    [<TestCase(0.43<uscup>, 0.1790249)>]
    [<TestCase(800.4<uscup>, 333.23621)>]
    let ``Convert known US Cups to Pints`` (input, expectation) = 
        uscup.toPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Cups to Gallons and back`` () =
        let property value =
            let convertTo = uscup.toGallons (uscup.create value)
            let convertBack = gal.toUSCups convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(56.0<uscup>, 2.91436)>]
    [<TestCase(104.12<uscup>, 5.41862726)>]
    [<TestCase(6.1<uscup>, 0.317457)>]
    let ``Convert known US Cups to Gallons`` (input, expectation) = 
        uscup.toGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Cups to Fluid Ounces and back`` () =
        let property value =
            let convertTo = uscup.toFluidOunces (uscup.create value)
            let convertBack = floz.toUSCups convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(55.0<uscup>, 457.971)>]
    [<TestCase(0.4<uscup>, 3.3307)>]
    [<TestCase(88.4<uscup>, 736.084)>]
    let ``Convert known US Cups to Fluid Ounces`` (input, expectation) = 
        uscup.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Cups to US Teaspoons and back`` () =
        let property value =
            let convertTo = uscup.toUSTeaspoons (uscup.create value)
            let convertBack = ustsp.toUSCups convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<uscup>, 576.0)>]
    [<TestCase(5.12<uscup>, 245.7601)>]
    [<TestCase(6701.0<uscup>, 321648.0)>]
    let ``Convert known US Cups to US Teaspoons`` (input, expectation) = 
        uscup.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Cups to US Tablespoons and back`` () =
        let property value =
            let convertTo = uscup.toUSTablespoons (uscup.create value)
            let convertBack = ustbsp.toUSCups convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(677.0<uscup>, 10832.0)>]
    [<TestCase(1.9<uscup>, 30.4)>]
    [<TestCase(800.8<uscup>, 12812.8)>]
    let ``Convert known US Cups to US Tablespoons`` (input, expectation) = 
        uscup.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Cups to US Quarts and back`` () =
        let property value =
            let convertTo = uscup.toUSQuarts (uscup.create value)
            let convertBack = usqt.toUSCups convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(800.8<uscup>, 200.2)>]
    [<TestCase(4.84<uscup>, 1.21)>]
    [<TestCase(0.99<uscup>, 0.2475)>]
    let ``Convert known US Cups to US Quarts`` (input, expectation) = 
        uscup.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Cups to US Pints and back`` () =
        let property value =
            let convertTo = uscup.toUSPints (uscup.create value)
            let convertBack = uspt.toUSCups convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.99<uscup>, 0.495)>]
    [<TestCase(358.9<uscup>, 179.45)>]
    [<TestCase(1000.0<uscup>, 500.0)>]
    let ``Convert known US Cups to US Pints`` (input, expectation) = 
        uscup.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Cups to US Gallons and back`` () =
        let property value =
            let convertTo = uscup.toUSGallons (uscup.create value)
            let convertBack = usgal.toUSCups convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1000.0<uscup>, 62.5)>]
    [<TestCase(0.78<uscup>, 0.04875)>]
    [<TestCase(123.123<uscup>, 7.6951875)>]
    let ``Convert known US Cups to US Gallons`` (input, expectation) = 
        uscup.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Cups to US Fluid Ounces and back`` () =
        let property value =
            let convertTo = uscup.toUSFluidOunces (uscup.create value)
            let convertBack = usfloz.toUSCups convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.123<uscup>, 984.984)>]
    [<TestCase(4.0<uscup>, 32.0)>]
    [<TestCase(0.9<uscup>, 7.2)>]
    let ``Convert known US Cups to US Fluid Ounces`` (input, expectation) = 
        uscup.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Fluid Ounces to Millilitres and back`` () =
        let property value =
            let convertTo = usfloz.toMillilitres (usfloz.create value)
            let convertBack = ml.toUSFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.98<usfloz>, 28.98206)>]
    [<TestCase(8.2<usfloz>, 242.503)>]
    [<TestCase(100.3<usfloz>, 2966.225)>]
    let ``Convert known US Fluid Ounces to Millilitres`` (input, expectation) = 
        usfloz.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Fluid Ounces to Litres and back`` () =
        let property value =
            let convertTo = usfloz.toLitres (usfloz.create value)
            let convertBack = l.toUSFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<usfloz>, 0.354882)>]
    [<TestCase(150.6<usfloz>, 4.4537736)>]
    [<TestCase(5.9<usfloz>, 0.174484)>]
    let ``Convert known US Fluid Ounces to Litres`` (input, expectation) = 
        usfloz.toLitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Fluid Ounces to Kilolitres and back`` () =
        let property value =
            let convertTo = usfloz.toKilolitres (usfloz.create value)
            let convertBack = kl.toUSFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(34.0<usfloz>, 0.0010055)>]
    [<TestCase(109.1<usfloz>, 0.0032264721)>]
    [<TestCase(45678.0<usfloz>, 1.3508597)>]
    let ``Convert known US Fluid Ounces to Kilolitres`` (input, expectation) = 
        usfloz.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Fluid Ounces to Teaspoons and back`` () =
        let property value =
            let convertTo = usfloz.toTeaspoons (usfloz.create value)
            let convertBack = tsp.toUSFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.0<usfloz>, 19.9842)>]
    [<TestCase(0.12<usfloz>, 0.5995252)>]
    [<TestCase(2.99<usfloz>, 14.93817)>]
    let ``Convert known US Fluid Ounces to Teaspoons`` (input, expectation) = 
        usfloz.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Fluid Ounces to Tablespoons and back`` () =
        let property value =
            let convertTo = usfloz.toTablespoons (usfloz.create value)
            let convertBack = tbsp.toUSFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(800.0<usfloz>, 1332.28)>]
    [<TestCase(0.02<usfloz>, 0.03330695)>]
    [<TestCase(2.7<usfloz>, 4.49644)>]
    let ``Convert known US Fluid Ounces to Tablespoons`` (input, expectation) = 
        usfloz.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Fluid Ounces to Quarts and back`` () =
        let property value =
            let convertTo = usfloz.toQuarts (usfloz.create value)
            let convertBack = qt.toUSFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.5<usfloz>, 0.0910737)>]
    [<TestCase(0.76<usfloz>, 0.01977601)>]
    [<TestCase(2.0<usfloz>, 0.0520421)>]
    let ``Convert known US Fluid Ounces to Quarts`` (input, expectation) = 
        usfloz.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Fluid Ounces to Pints and back`` () =
        let property value =
            let convertTo = usfloz.toPints (usfloz.create value)
            let convertBack = pt.toUSFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<usfloz>, 0.624506)>]
    [<TestCase(0.4<usfloz>, 0.0208169)>]
    [<TestCase(1.99<usfloz>, 0.1035639)>]
    let ``Convert known US Fluid Ounces to Pints`` (input, expectation) = 
        usfloz.toPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Fluid Ounces to Gallons and back`` () =
        let property value =
            let convertTo = usfloz.toGallons (usfloz.create value)
            let convertBack = gal.toUSFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.0<usfloz>, 0.0195158)>]
    [<TestCase(100.5<usfloz>, 0.65377934)>]
    [<TestCase(0.9<usfloz>, 0.00585474)>]
    let ``Convert known US Fluid Ounces to Gallons`` (input, expectation) = 
        usfloz.toGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Fluid Ounces to Fluid Ounces and back`` () =
        let property value =
            let convertTo = usfloz.toFluidOunces (usfloz.create value)
            let convertBack = floz.toUSFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.6<usfloz>, 0.624506)>]
    [<TestCase(123.0<usfloz>, 128.024)>]
    [<TestCase(8009.0<usfloz>, 8336.109)>]
    let ``Convert known US Fluid Ounces to Fluid Ounces`` (input, expectation) = 
        usfloz.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Fluid Ounces to US Teaspoons and back`` () =
        let property value =
            let convertTo = usfloz.toUSTeaspoons (usfloz.create value)
            let convertBack = ustsp.toUSFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(45.0<usfloz>, 270.0)>]
    [<TestCase(1.5<usfloz>, 9.0)>]
    [<TestCase(400.8<usfloz>, 2404.8008)>]
    let ``Convert known US Fluid Ounces to US Teaspoons`` (input, expectation) = 
        usfloz.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Fluid Ounces to US Tablespoons and back`` () =
        let property value =
            let convertTo = usfloz.toUSTablespoons (usfloz.create value)
            let convertBack = ustbsp.toUSFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.0<usfloz>, 8.0)>]
    [<TestCase(170.2<usfloz>, 340.4)>]
    [<TestCase(8811.0<usfloz>, 17622.0)>]
    let ``Convert known US Fluid Ounces to US Tablespoons`` (input, expectation) = 
        usfloz.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Fluid Ounces to US Quarts and back`` () =
        let property value =
            let convertTo = usfloz.toUSQuarts (usfloz.create value)
            let convertBack = usqt.toUSFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8811.0<usfloz>, 275.3438)>]
    [<TestCase(4.2<usfloz>, 0.13125)>]
    [<TestCase(109.0<usfloz>, 3.40625)>]
    let ``Convert known US Fluid Ounces to US Quarts`` (input, expectation) = 
        usfloz.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Fluid Ounces to US Pints and back`` () =
        let property value =
            let convertTo = usfloz.toUSPints (usfloz.create value)
            let convertBack = uspt.toUSFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<usfloz>, 6.8125)>]
    [<TestCase(77.09<usfloz>, 4.818125)>]
    [<TestCase(180.4<usfloz>, 11.275)>]
    let ``Convert known US Fluid Ounces to US Pints`` (input, expectation) = 
        usfloz.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Fluid Ounces to US Gallons and back`` () =
        let property value =
            let convertTo = usfloz.toUSGallons (usfloz.create value)
            let convertBack = usgal.toUSFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(45.0<usfloz>, 0.351563)>]
    [<TestCase(1.8<usfloz>, 0.0140625)>]
    [<TestCase(778.9<usfloz>, 6.0851562)>]
    let ``Convert known US Fluid Ounces to US Gallons`` (input, expectation) = 
        usfloz.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Fluid Ounces to US Cups and back`` () =
        let property value =
            let convertTo = usfloz.toUSCups (usfloz.create value)
            let convertBack = uscup.toUSFluidOunces convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(45.0<usfloz>, 5.625)>]
    [<TestCase(66.9<usfloz>, 8.3625)>]
    [<TestCase(0.29<usfloz>, 0.03625)>]
    let ``Convert known US Fluid Ounces to US Cups`` (input, expectation) = 
        usfloz.toUSCups input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Gallons to Millilitres and back`` () =
        let property value =
            let convertTo = usgal.toMillilitres (usgal.create value)
            let convertBack = ml.toUSGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.0<usgal>, 7570.82)>]
    [<TestCase(0.1<usgal>, 378.541)>]
    [<TestCase(56.0<usgal>, 211983.0599039)>]
    let ``Convert known US Gallons to Millilitres`` (input, expectation) = 
        usgal.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Gallons to Litres and back`` () =
        let property value =
            let convertTo = usgal.toLitres (usgal.create value)
            let convertBack = l.toUSGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(56.0<usgal>, 211.983)>]
    [<TestCase(5.1<usgal>, 19.3056)>]
    [<TestCase(2.5<usgal>, 9.46353)>]
    let ``Convert known US Gallons to Litres`` (input, expectation) = 
        usgal.toLitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Gallons to Kilolitres and back`` () =
        let property value =
            let convertTo = usgal.toKilolitres (usgal.create value)
            let convertBack = kl.toUSGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(111.0<usgal>, 0.420181)>]
    [<TestCase(9090.0<usgal>, 34.40939)>]
    [<TestCase(12345.0<usgal>, 46.730908)>]
    let ``Convert known US Gallons to Kilolitres`` (input, expectation) = 
        usgal.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Gallons to Teaspoons and back`` () =
        let property value =
            let convertTo = usgal.toTeaspoons (usgal.create value)
            let convertBack = tsp.toUSGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.0<usgal>, 3197.47)>]
    [<TestCase(0.4<usgal>, 255.797)>]
    [<TestCase(8000.0<usgal>, 5115948.07582550)>]
    let ``Convert known US Gallons to Teaspoons`` (input, expectation) = 
        usgal.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Gallons to Tablespoons and back`` () =
        let property value =
            let convertTo = usgal.toTablespoons (usgal.create value)
            let convertBack = tbsp.toUSGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(79.0<usgal>, 16840.0)>]
    [<TestCase(12.67<usgal>, 2700.7943)>]
    [<TestCase(55.1<usgal>, 11745.36)>]
    let ``Convert known US Gallons to Tablespoons`` (input, expectation) = 
        usgal.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Gallons to Quarts and back`` () =
        let property value =
            let convertTo = usgal.toQuarts (usgal.create value)
            let convertBack = qt.toUSGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(54.0<usgal>, 179.858)>]
    [<TestCase(2.9<usgal>, 9.65902)>]
    [<TestCase(0.2<usgal>, 0.666139)>]
    let ``Convert known US Gallons to Quarts`` (input, expectation) = 
        usgal.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Gallons to Pints and back`` () =
        let property value =
            let convertTo = usgal.toPints (usgal.create value)
            let convertBack = pt.toUSGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.0<usgal>, 13.3228)>]
    [<TestCase(0.12<usgal>, 0.7993672)>]
    [<TestCase(500.0<usgal>, 3330.7)>]
    let ``Convert known US Gallons to Pints`` (input, expectation) = 
        usgal.toPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Gallons to Gallons and back`` () =
        let property value =
            let convertTo = usgal.toGallons (usgal.create value)
            let convertBack = gal.toUSGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(23.0<usgal>, 19.1515)>]
    [<TestCase(8.2<usgal>, 6.82793)>]
    [<TestCase(1.09<usgal>, 0.9076149)>]
    let ``Convert known US Gallons to Gallons`` (input, expectation) = 
        usgal.toGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Gallons to Fluid Ounces and back`` () =
        let property value =
            let convertTo = usgal.toFluidOunces (usgal.create value)
            let convertBack = floz.toUSGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.09<usgal>, 145.2184)>]
    [<TestCase(34.0<usgal>, 4529.75)>]
    [<TestCase(666.0<usgal>, 88729.724440098)>]
    let ``Convert known US Gallons to Fluid Ounces`` (input, expectation) = 
        usgal.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Gallons to US Teaspoons and back`` () =
        let property value =
            let convertTo = usgal.toUSTeaspoons (usgal.create value)
            let convertBack = ustsp.toUSGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.0<usgal>, 3072.0)>]
    [<TestCase(1.28<usgal>, 983.0403)>]
    [<TestCase(6.99<usgal>, 5368.322)>]
    let ``Convert known US Gallons to US Teaspoons`` (input, expectation) = 
        usgal.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Gallons to US Tablespoons and back`` () =
        let property value =
            let convertTo = usgal.toUSTablespoons (usgal.create value)
            let convertBack = ustbsp.toUSGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(34.0<usgal>, 8704.0)>]
    [<TestCase(8.4<usgal>, 2150.4)>]
    [<TestCase(0.091<usgal>, 23.296)>]
    let ``Convert known US Gallons to US Tablespoons`` (input, expectation) = 
        usgal.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Gallons to US Quarts and back`` () =
        let property value =
            let convertTo = usgal.toUSQuarts (usgal.create value)
            let convertBack = usqt.toUSGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.091<usgal>, 0.364)>]
    [<TestCase(23.0<usgal>, 92.0)>]
    [<TestCase(1000.8<usgal>, 4003.2)>]
    let ``Convert known US Gallons to US Quarts`` (input, expectation) = 
        usgal.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Gallons to US Pints and back`` () =
        let property value =
            let convertTo = usgal.toUSPints (usgal.create value)
            let convertBack = uspt.toUSGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1000.8<usgal>, 8006.4)>]
    [<TestCase(23.6<usgal>, 188.8)>]
    [<TestCase(0.71<usgal>, 5.68)>]
    let ``Convert known US Gallons to US Pints`` (input, expectation) = 
        usgal.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Gallons to US Fluid Ounces and back`` () =
        let property value =
            let convertTo = usgal.toUSFluidOunces (usgal.create value)
            let convertBack = usfloz.toUSGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.71<usgal>, 90.88)>]
    [<TestCase(83.2<usgal>, 10649.6)>]
    [<TestCase(777.0<usgal>, 99456.0)>]
    let ``Convert known US Gallons to US Fluid Ounces`` (input, expectation) = 
        usgal.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Gallons to US Cups and back`` () =
        let property value =
            let convertTo = usgal.toUSCups (usgal.create value)
            let convertBack = uscup.toUSGallons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(777.0<usgal>, 12432.0)>]
    [<TestCase(5.71<usgal>, 91.36)>]
    [<TestCase(0.98<usgal>, 15.68)>]
    let ``Convert known US Gallons to US Cups`` (input, expectation) = 
        usgal.toUSCups input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Pints to Millilitres and back`` () =
        let property value =
            let convertTo = uspt.toMillilitres (uspt.create value)
            let convertBack = ml.toUSPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.66<uspt>, 312.2965)>]
    [<TestCase(9.1<uspt>, 4305.91)>]
    [<TestCase(0.8<uspt>, 378.541)>]
    let ``Convert known US Pints to Millilitres`` (input, expectation) = 
        uspt.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Pints to Litres and back`` () =
        let property value =
            let convertTo = uspt.toLitres (uspt.create value)
            let convertBack = l.toUSPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.5<uspt>, 0.709765)>]
    [<TestCase(0.6<uspt>, 0.283906)>]
    [<TestCase(1367.0<uspt>, 646.8322)>]
    let ``Convert known US Pints to Litres`` (input, expectation) = 
        uspt.toLitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Pints to Kilolitres and back`` () =
        let property value =
            let convertTo = uspt.toKilolitres (uspt.create value)
            let convertBack = kl.toUSPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1900.0<uspt>, 0.8990353)>]
    [<TestCase(8888.0<uspt>, 4.205592)>]
    [<TestCase(123456.0<uspt>, 58.4164747)>]
    let ``Convert known US Pints to Kilolitres`` (input, expectation) = 
        uspt.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Pints to Teaspoons and back`` () =
        let property value =
            let convertTo = uspt.toTeaspoons (uspt.create value)
            let convertBack = tsp.toUSPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.0<uspt>, 479.62)>]
    [<TestCase(0.08<uspt>, 6.394935)>]
    [<TestCase(3.1<uspt>, 247.804)>]
    let ``Convert known US Pints to Teaspoons`` (input, expectation) = 
        uspt.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Pints to Tablespoons and back`` () =
        let property value =
            let convertTo = uspt.toTablespoons (uspt.create value)
            let convertBack = tbsp.toUSPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.0<uspt>, 53.2911)>]
    [<TestCase(0.09<uspt>, 2.398101)>]
    [<TestCase(1678.0<uspt>, 44711.25)>]
    let ``Convert known US Pints to Tablespoons`` (input, expectation) = 
        uspt.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Pints to Quarts and back`` () =
        let property value =
            let convertTo = uspt.toQuarts (uspt.create value)
            let convertBack = qt.toUSPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<uspt>, 4.99605)>]
    [<TestCase(503.8<uspt>, 209.75063)>]
    [<TestCase(0.65<uspt>, 0.2706191)>]
    let ``Convert known US Pints to Quarts`` (input, expectation) = 
        uspt.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Pints to Pints and back`` () =
        let property value =
            let convertTo = uspt.toPints (uspt.create value)
            let convertBack = pt.toUSPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<uspt>, 0.749407)>]
    [<TestCase(102.0<uspt>, 84.9328)>]
    [<TestCase(8000.7<uspt>, 6661.97635)>]
    let ``Convert known US Pints to Pints`` (input, expectation) = 
        uspt.toPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Pints to Gallons and back`` () =
        let property value =
            let convertTo = uspt.toGallons (uspt.create value)
            let convertBack = gal.toUSPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(80.0<uspt>, 8.32674)>]
    [<TestCase(6.2<uspt>, 0.645322)>]
    [<TestCase(0.7<uspt>, 0.072859)>]
    let ``Convert known US Pints to Gallons`` (input, expectation) = 
        uspt.toGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Pints to Fluid Ounces and back`` () =
        let property value =
            let convertTo = uspt.toFluidOunces (uspt.create value)
            let convertBack = floz.toUSPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<uspt>, 199.842)>]
    [<TestCase(9.7<uspt>, 161.539)>]
    [<TestCase(124.0<uspt>, 2065.03)>]
    let ``Convert known US Pints to Fluid Ounces`` (input, expectation) = 
        uspt.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Pints to US Teaspoons and back`` () =
        let property value =
            let convertTo = uspt.toUSTeaspoons (uspt.create value)
            let convertBack = ustsp.toUSPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.0<uspt>, 384.0)>]
    [<TestCase(2.5<uspt>, 240.0)>]
    [<TestCase(8001.9<uspt>, 768182.4)>]
    let ``Convert known US Pints to US Teaspoons`` (input, expectation) = 
        uspt.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Pints to US Tablespoons and back`` () =
        let property value =
            let convertTo = uspt.toUSTablespoons (uspt.create value)
            let convertBack = ustbsp.toUSPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(80.0<uspt>, 2560.0)>]
    [<TestCase(12.7<uspt>, 406.4)>]
    [<TestCase(0.6<uspt>, 19.2)>]
    let ``Convert known US Pints to US Tablespoons`` (input, expectation) = 
        uspt.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Pints to US Quarts and back`` () =
        let property value =
            let convertTo = uspt.toUSQuarts (uspt.create value)
            let convertBack = usqt.toUSPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.6<uspt>, 0.3)>]
    [<TestCase(10090.0<uspt>, 5045.0)>]
    [<TestCase(4.56<uspt>, 2.28)>]
    let ``Convert known US Pints to US Quarts`` (input, expectation) = 
        uspt.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Pints to US Gallons and back`` () =
        let property value =
            let convertTo = uspt.toUSGallons (uspt.create value)
            let convertBack = usgal.toUSPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.56<uspt>, 0.57)>]
    [<TestCase(9000.0<uspt>, 1125.0)>]
    [<TestCase(47.2<uspt>, 5.9)>]
    let ``Convert known US Pints to US Gallons`` (input, expectation) = 
        uspt.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Pints to US Fluid Ounces and back`` () =
        let property value =
            let convertTo = uspt.toUSFluidOunces (uspt.create value)
            let convertBack = usfloz.toUSPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(47.2<uspt>, 755.2)>]
    [<TestCase(1001.0<uspt>, 16016.0)>]
    [<TestCase(23.9<uspt>, 382.4)>]
    let ``Convert known US Pints to US Fluid Ounces`` (input, expectation) = 
        uspt.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Pints to US Cups and back`` () =
        let property value =
            let convertTo = uspt.toUSCups (uspt.create value)
            let convertBack = uscup.toUSPints convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(23.9<uspt>, 47.8)>]
    [<TestCase(1009.0<uspt>, 2018.0)>]
    [<TestCase(45.9<uspt>, 91.8)>]
    let ``Convert known US Pints to US Cups`` (input, expectation) = 
        uspt.toUSCups input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Quarts to Millilitres and back`` () =
        let property value =
            let convertTo = usqt.toMillilitres (usqt.create value)
            let convertBack = ml.toUSQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9000.0<usqt>, 8517176.51400)>]
    [<TestCase(5.0<usqt>, 4731.76)>]
    [<TestCase(0.7<usqt>, 662.447)>]
    let ``Convert known US Quarts to Millilitres`` (input, expectation) = 
        usqt.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Quarts to Litres and back`` () =
        let property value =
            let convertTo = usqt.toLitres (usqt.create value)
            let convertBack = l.toUSQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9.0<usqt>, 8.51718)>]
    [<TestCase(1024.0<usqt>, 969.0654)>]
    [<TestCase(0.8<usqt>, 0.757082)>]
    let ``Convert known US Quarts to Litres`` (input, expectation) = 
        usqt.toLitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Quarts to Kilolitres and back`` () =
        let property value =
            let convertTo = usqt.toKilolitres (usqt.create value)
            let convertBack = kl.toUSQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1000.0<usqt>, 0.946353)>]
    [<TestCase(6789.0<usqt>, 6.42479)>]
    [<TestCase(45.0<usqt>, 0.0425859)>]
    let ``Convert known US Quarts to Kilolitres`` (input, expectation) = 
        usqt.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Quarts to Teaspoons and back`` () =
        let property value =
            let convertTo = usqt.toTeaspoons (usqt.create value)
            let convertBack = tsp.toUSQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(45.0<usqt>, 7194.3)>]
    [<TestCase(6.5<usqt>, 1039.18)>]
    [<TestCase(0.9<usqt>, 143.886)>]
    let ``Convert known US Quarts to Teaspoons`` (input, expectation) = 
        usqt.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Quarts to Tablespoons and back`` () =
        let property value =
            let convertTo = usqt.toTablespoons (usqt.create value)
            let convertBack = tbsp.toUSQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.0<usqt>, 319.747)>]
    [<TestCase(89.4<usqt>, 4764.227)>]
    [<TestCase(4.67<usqt>, 248.8696)>]
    let ``Convert known US Quarts to Tablespoons`` (input, expectation) = 
        usqt.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Quarts to Quarts and back`` () =
        let property value =
            let convertTo = usqt.toQuarts (usqt.create value)
            let convertBack = qt.toUSQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.6<usqt>, 3.8303)>]
    [<TestCase(0.9<usqt>, 0.749407)>]
    [<TestCase(134.0<usqt>, 111.578)>]
    let ``Convert known US Quarts to Quarts`` (input, expectation) = 
        usqt.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Quarts to Pints and back`` () =
        let property value =
            let convertTo = usqt.toPints (usqt.create value)
            let convertBack = pt.toUSQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.0<usqt>, 204.838)>]
    [<TestCase(1090.9<usqt>, 1816.72854)>]
    [<TestCase(56.0<usqt>, 93.2595)>]
    let ``Convert known US Quarts to Pints`` (input, expectation) = 
        usqt.toPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Quarts to Gallons and back`` () =
        let property value =
            let convertTo = usqt.toGallons (usqt.create value)
            let convertBack = gal.toUSQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(56.0<usqt>, 11.6574)>]
    [<TestCase(7.12<usqt>, 1.48216)>]
    [<TestCase(800.0<usqt>, 166.535)>]
    let ``Convert known US Quarts to Gallons`` (input, expectation) = 
        usqt.toGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Quarts to Fluid Ounces and back`` () =
        let property value =
            let convertTo = usqt.toFluidOunces (usqt.create value)
            let convertBack = floz.toUSQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(800.0<usqt>, 26645.56289492)>]
    [<TestCase(6.8<usqt>, 226.487)>]
    [<TestCase(0.9<usqt>, 29.9763)>]
    let ``Convert known US Quarts to Fluid Ounces`` (input, expectation) = 
        usqt.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Quarts to US Teaspoons and back`` () =
        let property value =
            let convertTo = usqt.toUSTeaspoons (usqt.create value)
            let convertBack = ustsp.toUSQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.0<usqt>, 576.0)>]
    [<TestCase(0.12<usqt>, 23.04001)>]
    [<TestCase(4.5<usqt>, 864.0)>]
    let ``Convert known US Quarts to US Teaspoons`` (input, expectation) = 
        usqt.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Quarts to US Tablespoons and back`` () =
        let property value =
            let convertTo = usqt.toUSTablespoons (usqt.create value)
            let convertBack = ustbsp.toUSQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.5<usqt>, 288.0)>]
    [<TestCase(0.777<usqt>, 49.728)>]
    [<TestCase(1.8<usqt>, 115.2)>]
    let ``Convert known US Quarts to US Tablespoons`` (input, expectation) = 
        usqt.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Quarts to US Pints and back`` () =
        let property value =
            let convertTo = usqt.toUSPints (usqt.create value)
            let convertBack = uspt.toUSQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.8<usqt>, 3.6)>]
    [<TestCase(900.0<usqt>, 1800.0)>]
    [<TestCase(12.45<usqt>, 24.9)>]
    let ``Convert known US Quarts to US Pints`` (input, expectation) = 
        usqt.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Quarts to US Gallons and back`` () =
        let property value =
            let convertTo = usqt.toUSGallons (usqt.create value)
            let convertBack = usgal.toUSQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.45<usqt>, 3.1125)>]
    [<TestCase(0.8<usqt>, 0.2)>]
    [<TestCase(100.9<usqt>, 25.225)>]
    let ``Convert known US Quarts to US Gallons`` (input, expectation) = 
        usqt.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Quarts to US Fluid Ounces and back`` () =
        let property value =
            let convertTo = usqt.toUSFluidOunces (usqt.create value)
            let convertBack = usfloz.toUSQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100.9<usqt>, 3228.8)>]
    [<TestCase(12345.0<usqt>, 395040.0)>]
    [<TestCase(8.7<usqt>, 278.4)>]
    let ``Convert known US Quarts to US Fluid Ounces`` (input, expectation) = 
        usqt.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Quarts to US Cups and back`` () =
        let property value =
            let convertTo = usqt.toUSCups (usqt.create value)
            let convertBack = uscup.toUSQuarts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8.7<usqt>, 34.8)>]
    [<TestCase(123.9<usqt>, 495.6)>]
    [<TestCase(0.66<usqt>, 2.64)>]
    let ``Convert known US Quarts to US Cups`` (input, expectation) = 
        usqt.toUSCups input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Tablespoons to Millilitres and back`` () =
        let property value =
            let convertTo = ustbsp.toMillilitres (ustbsp.create value)
            let convertBack = ml.toUSTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<ustbsp>, 177.441)>]
    [<TestCase(0.8<ustbsp>, 11.8294)>]
    [<TestCase(4500.0<ustbsp>, 66540.44)>]
    let ``Convert known US Tablespoons to Millilitres`` (input, expectation) = 
        ustbsp.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Tablespoons to Litres and back`` () =
        let property value =
            let convertTo = ustbsp.toLitres (ustbsp.create value)
            let convertBack = l.toUSTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(567.0<ustbsp>, 8.3841)>]
    [<TestCase(80.9<ustbsp>, 1.196249)>]
    [<TestCase(10000.0<ustbsp>, 147.8676)>]
    let ``Convert known US Tablespoons to Litres`` (input, expectation) = 
        ustbsp.toLitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Tablespoons to Kilolitres and back`` () =
        let property value =
            let convertTo = ustbsp.toKilolitres (ustbsp.create value)
            let convertBack = kl.toUSTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9900.0<ustbsp>, 0.146389)>]
    [<TestCase(123456.0<ustbsp>, 1.82551483)>]
    [<TestCase(18009.0<ustbsp>, 0.26629485)>]
    let ``Convert known US Tablespoons to Kilolitres`` (input, expectation) = 
        ustbsp.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Tablespoons to Teaspoons and back`` () =
        let property value =
            let convertTo = ustbsp.toTeaspoons (ustbsp.create value)
            let convertBack = tsp.toUSTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(14.0<ustbsp>, 34.9723)>]
    [<TestCase(0.9<ustbsp>, 2.24822)>]
    [<TestCase(180.0<ustbsp>, 449.644)>]
    let ``Convert known US Tablespoons to Teaspoons`` (input, expectation) = 
        ustbsp.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Tablespoons to Tablespoons and back`` () =
        let property value =
            let convertTo = ustbsp.toTablespoons (ustbsp.create value)
            let convertBack = tbsp.toUSTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<ustbsp>, 90.7614)>]
    [<TestCase(89.0<ustbsp>, 74.108)>]
    [<TestCase(5.2<ustbsp>, 4.3299)>]
    let ``Convert known US Tablespoons to Tablespoons`` (input, expectation) = 
        ustbsp.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Tablespoons to Quarts and back`` () =
        let property value =
            let convertTo = ustbsp.toQuarts (ustbsp.create value)
            let convertBack = qt.toUSTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(345.0<ustbsp>, 4.48863)>]
    [<TestCase(89.9<ustbsp>, 1.169647)>]
    [<TestCase(12.88<ustbsp>, 0.16757568)>]
    let ``Convert known US Tablespoons to Quarts`` (input, expectation) = 
        ustbsp.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Tablespoons to Pints and back`` () =
        let property value =
            let convertTo = ustbsp.toPints (ustbsp.create value)
            let convertBack = pt.toUSTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<ustbsp>, 0.312253)>]
    [<TestCase(809.7<ustbsp>, 21.069259)>]
    [<TestCase(0.4<ustbsp>, 0.0104084)>]
    let ``Convert known US Tablespoons to Pints`` (input, expectation) = 
        ustbsp.toPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Tablespoons to Gallons and back`` () =
        let property value =
            let convertTo = ustbsp.toGallons (ustbsp.create value)
            let convertBack = gal.toUSTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(400.0<ustbsp>, 1.30105)>]
    [<TestCase(1200.9<ustbsp>, 3.90608761)>]
    [<TestCase(8.0<ustbsp>, 0.0260211)>]
    let ``Convert known US Tablespoons to Gallons`` (input, expectation) = 
        ustbsp.toGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Tablespoons to Fluid Ounces and back`` () =
        let property value =
            let convertTo = ustbsp.toFluidOunces (ustbsp.create value)
            let convertBack = floz.toUSTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.0<ustbsp>, 2.08169)>]
    [<TestCase(50.9<ustbsp>, 26.48945)>]
    [<TestCase(123.0<ustbsp>, 64.0118)>]
    let ``Convert known US Tablespoons to Fluid Ounces`` (input, expectation) = 
        ustbsp.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Tablespoons to US Teaspoons and back`` () =
        let property value =
            let convertTo = ustbsp.toUSTeaspoons (ustbsp.create value)
            let convertBack = ustsp.toUSTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(90.0<ustbsp>, 270.0)>]
    [<TestCase(4.5<ustbsp>, 13.5)>]
    [<TestCase(4608.0<ustbsp>, 13824.0)>]
    let ``Convert known US Tablespoons to US Teaspoons`` (input, expectation) = 
        ustbsp.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Tablespoons to US Quarts and back`` () =
        let property value =
            let convertTo = ustbsp.toUSQuarts (ustbsp.create value)
            let convertBack = usqt.toUSTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(456.0<ustbsp>, 7.125)>]
    [<TestCase(7.12<ustbsp>, 0.11125)>]
    [<TestCase(194.9<ustbsp>, 3.0453125)>]
    let ``Convert known US Tablespoons to US Quarts`` (input, expectation) = 
        ustbsp.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Tablespoons to US Pints and back`` () =
        let property value =
            let convertTo = ustbsp.toUSPints (ustbsp.create value)
            let convertBack = uspt.toUSTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(194.9<ustbsp>, 6.090625)>]
    [<TestCase(2000.0<ustbsp>, 62.5)>]
    [<TestCase(18.7<ustbsp>, 0.584375)>]
    let ``Convert known US Tablespoons to US Pints`` (input, expectation) = 
        ustbsp.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Tablespoons to US Gallons and back`` () =
        let property value =
            let convertTo = ustbsp.toUSGallons (ustbsp.create value)
            let convertBack = usgal.toUSTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(18.7<ustbsp>, 0.07304687)>]
    [<TestCase(1900.0<ustbsp>, 7.421875)>]
    [<TestCase(12345.0<ustbsp>, 48.222656)>]
    let ``Convert known US Tablespoons to US Gallons`` (input, expectation) = 
        ustbsp.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Tablespoons to US Fluid Ounces and back`` () =
        let property value =
            let convertTo = ustbsp.toUSFluidOunces (ustbsp.create value)
            let convertBack = usfloz.toUSTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1234.0<ustbsp>, 617.0)>]
    [<TestCase(89.3<ustbsp>, 44.65)>]
    [<TestCase(90.99<ustbsp>, 45.495)>]
    let ``Convert known US Tablespoons to US Fluid Ounces`` (input, expectation) = 
        ustbsp.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Tablespoons to US Cups and back`` () =
        let property value =
            let convertTo = ustbsp.toUSCups (ustbsp.create value)
            let convertBack = uscup.toUSTablespoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(90.99<ustbsp>, 5.686875)>]
    [<TestCase(1230.0<ustbsp>, 76.875)>]
    [<TestCase(9000.9<ustbsp>, 562.55625)>]
    let ``Convert known US Tablespoons to US Cups`` (input, expectation) = 
        ustbsp.toUSCups input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Teaspoons to Millilitres and back`` () =
        let property value =
            let convertTo = ustsp.toMillilitres (ustsp.create value)
            let convertBack = ml.toUSTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.9<ustsp>, 34.0095)>]
    [<TestCase(1.6<ustsp>, 7.88627)>]
    [<TestCase(800.0<ustsp>, 3943.14)>]
    let ``Convert known US Teaspoons to Millilitres`` (input, expectation) = 
        ustsp.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Teaspoons to Litres and back`` () =
        let property value =
            let convertTo = ustsp.toLitres (ustsp.create value)
            let convertBack = l.toUSTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(7.0<ustsp>, 0.0345024)>]
    [<TestCase(90.0<ustsp>, 0.443603)>]
    [<TestCase(56.7<ustsp>, 0.2794698)>]
    let ``Convert known US Teaspoons to Litres`` (input, expectation) = 
        ustsp.toLitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Teaspoons to Kilolitres and back`` () =
        let property value =
            let convertTo = ustsp.toKilolitres (ustsp.create value)
            let convertBack = kl.toUSTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(10009000.0<ustsp>, 49.33356028)>]
    [<TestCase(1234567.8<ustsp>, 6.08508592078)>]
    [<TestCase(9800.0<ustsp>, 0.04830342)>]
    let ``Convert known US Teaspoons to Kilolitres`` (input, expectation) = 
        ustsp.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Teaspoons to Teaspoons and back`` () =
        let property value =
            let convertTo = ustsp.toTeaspoons (ustsp.create value)
            let convertBack = tsp.toUSTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(122.0<ustsp>, 101.586)>]
    [<TestCase(89.2<ustsp>, 74.27448)>]
    [<TestCase(900.0<ustsp>, 749.406)>]
    let ``Convert known US Teaspoons to Teaspoons`` (input, expectation) = 
        ustsp.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Teaspoons to Tablespoons and back`` () =
        let property value =
            let convertTo = ustsp.toTablespoons (ustsp.create value)
            let convertBack = tbsp.toUSTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(500.0<ustsp>, 138.779)>]
    [<TestCase(12.34<ustsp>, 3.425064)>]
    [<TestCase(667.0<ustsp>, 185.131)>]
    let ``Convert known US Teaspoons to Tablespoons`` (input, expectation) = 
        ustsp.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Teaspoons to Quarts and back`` () =
        let property value =
            let convertTo = ustsp.toQuarts (ustsp.create value)
            let convertBack = qt.toUSTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(78.0<ustsp>, 0.338274)>]
    [<TestCase(900.1<ustsp>, 3.9035927)>]
    [<TestCase(116.9<ustsp>, 0.50697698)>]
    let ``Convert known US Teaspoons to Quarts`` (input, expectation) = 
        ustsp.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Teaspoons to Pints and back`` () =
        let property value =
            let convertTo = ustsp.toPints (ustsp.create value)
            let convertBack = pt.toUSTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(116.0<ustsp>, 1.00615)>]
    [<TestCase(59.5<ustsp>, 0.5160844)>]
    [<TestCase(1900.0<ustsp>, 16.48)>]
    let ``Convert known US Teaspoons to Pints`` (input, expectation) = 
        ustsp.toPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Teaspoons to Gallons and back`` () =
        let property value =
            let convertTo = ustsp.toGallons (ustsp.create value)
            let convertBack = gal.toUSTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(199.0<ustsp>, 0.215758)>]
    [<TestCase(12345.0<ustsp>, 13.384583)>]
    [<TestCase(90001.0<ustsp>, 97.580059)>]
    let ``Convert known US Teaspoons to Gallons`` (input, expectation) = 
        ustsp.toGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Teaspoons to Fluid Ounces and back`` () =
        let property value =
            let convertTo = ustsp.toFluidOunces (ustsp.create value)
            let convertBack = floz.toUSTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.0<ustsp>, 21.3373)>]
    [<TestCase(89.0<ustsp>, 15.4392)>]
    [<TestCase(1009.0<ustsp>, 175.035)>]
    let ``Convert known US Teaspoons to Fluid Ounces`` (input, expectation) = 
        ustsp.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Teaspoons to US Tablespoons and back`` () =
        let property value =
            let convertTo = ustsp.toUSTablespoons (ustsp.create value)
            let convertBack = ustbsp.toUSTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190.0<ustsp>, 63.3333)>]
    [<TestCase(5.6<ustsp>, 1.86667)>]
    [<TestCase(0.7<ustsp>, 0.233333)>]
    let ``Convert known US Teaspoons to US Tablespoons`` (input, expectation) = 
        ustsp.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Teaspoons to US Quarts and back`` () =
        let property value =
            let convertTo = ustsp.toUSQuarts (ustsp.create value)
            let convertBack = usqt.toUSTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100.4<ustsp>, 0.5229165)>]
    [<TestCase(9000.0<ustsp>, 46.87498)>]
    [<TestCase(1234.0<ustsp>, 6.427081)>]
    let ``Convert known US Teaspoons to US Quarts`` (input, expectation) = 
        ustsp.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Teaspoons to US Pints and back`` () =
        let property value =
            let convertTo = ustsp.toUSPints (ustsp.create value)
            let convertBack = uspt.toUSTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<ustsp>, 1.13542)>]
    [<TestCase(3400.0<ustsp>, 35.41666)>]
    [<TestCase(10.7<ustsp>, 0.1114583)>]
    let ``Convert known US Teaspoons to US Pints`` (input, expectation) = 
        ustsp.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Teaspoons to US Gallons and back`` () =
        let property value =
            let convertTo = ustsp.toUSGallons (ustsp.create value)
            let convertBack = usgal.toUSTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<ustsp>, 0.141927)>]
    [<TestCase(9876.0<ustsp>, 12.85937)>]
    [<TestCase(10900.0<ustsp>, 14.192704)>]
    let ``Convert known US Teaspoons to US Gallons`` (input, expectation) = 
        ustsp.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Teaspoons to US Fluid Ounces and back`` () =
        let property value =
            let convertTo = ustsp.toUSFluidOunces (ustsp.create value)
            let convertBack = usfloz.toUSTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(180.0<ustsp>, 30.0)>]
    [<TestCase(5.6<ustsp>, 0.933333)>]
    [<TestCase(900.5<ustsp>, 150.08328)>]
    let ``Convert known US Teaspoons to US Fluid Ounces`` (input, expectation) = 
        ustsp.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Teaspoons to US Cups and back`` () =
        let property value =
            let convertTo = ustsp.toUSCups (ustsp.create value)
            let convertBack = uscup.toUSTeaspoons convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(90.0<ustsp>, 1.875)>]
    [<TestCase(4500.8<ustsp>, 93.7666363)>]
    [<TestCase(0.9<ustsp>, 0.01875)>]
    let ``Convert known US Teaspoons to US Cups`` (input, expectation) = 
        ustsp.toUSCups input
        |> should (equalWithin 0.01) expectation
