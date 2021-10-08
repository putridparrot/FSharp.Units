namespace FSharp.Units.Tests

module USFluidOunceTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // US fluid ounce to X and back

    [<Property>]
    let ``From US fluid ounces to millilitre and back`` () =
        let property value = 
            let millilitres = usfloz.toMillilitres (usfloz.create value)
            let usFluidOunces = ml.toUSFluidOunces millilitres

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to litre and back`` () =
        let property value = 
            let litres = usfloz.toLitres (usfloz.create value)
            let usFluidOunces = l.toUSFluidOunces litres

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to kilolitre and back`` () =
        let property value = 
            let kilolitres = usfloz.toKilolitres (usfloz.create value)
            let usFluidOunces = kl.toUSFluidOunces kilolitres

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to teaspoon and back`` () =
        let property value = 
            let teaspoons = usfloz.toTeaspoons (usfloz.create value)
            let usFluidOunces = tsp.toUSFluidOunces teaspoons

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to tablespoon and back`` () =
        let property value = 
            let tablespoons = usfloz.toTablespoons (usfloz.create value)
            let usFluidOunces = tbsp.toUSFluidOunces tablespoons

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to quarts and back`` () =
        let property value = 
            let quarts = usfloz.toQuarts (usfloz.create value)
            let usFluidOunces = qt.toUSFluidOunces quarts

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to pints and back`` () =
        let property value = 
            let pints = usfloz.toPints (usfloz.create value)
            let usFluidOunces = pt.toUSFluidOunces pints

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to gallons and back`` () =
        let property value = 
            let gallons = usfloz.toGallons (usfloz.create value)
            let usFluidOunces = gal.toUSFluidOunces gallons

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = usfloz.toFluidOunces (usfloz.create value)
            let usFluidOunces = floz.toUSFluidOunces fluidOunces

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to US teaspoons and back`` () =
        let property value = 
            let teaSpoons = usfloz.toUSTeaspoons (usfloz.create value)
            let usFluidOunces = ustsp.toUSFluidOunces teaSpoons

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = usfloz.toUSTablespoons (usfloz.create value)
            let usFluidOunces = ustbsp.toUSFluidOunces usTablespoons

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to US quarts and back`` () =
        let property value = 
            let usQuarts = usfloz.toUSQuarts (usfloz.create value)
            let usFluidOunces = usqt.toUSFluidOunces usQuarts

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to US pints and back`` () =
        let property value = 
            let usPints = usfloz.toUSPints (usfloz.create value)
            let usFluidOunces = uspt.toUSFluidOunces usPints

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to US gallons and back`` () =
        let property value = 
            let usGallons = usfloz.toUSGallons (usfloz.create value)
            let usFluidOunces = usgal.toUSFluidOunces usGallons

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to US cups and back`` () =
        let property value = 
            let usCups = usfloz.toUSCups (usfloz.create value)
            let usFluidOunces = uscup.toUSFluidOunces usCups

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known US fluid ounces to millilitres`` () =
        let millilitres = usfloz.toMillilitres 8.7<usfloz>

        millilitres
        |> should (equalWithin 0.01) 257.2897071937

    [<Test>]
    let ``Convert known US fluid ounces to litres`` () =
        let litres = usfloz.toLitres 450.<usfloz>

        litres
        |> should (equalWithin 0.01) 13.3080883031

    [<Test>]
    let ``Convert known US fluid ounces to kilolitres`` () =
        let kilolitres = usfloz.toKilolitres 567.<usfloz>

        kilolitres
        |> should (equalWithin 0.01) 0.0167681913

    [<Test>]
    let ``Convert known US fluid ounces to teaspoons`` () =
        let teaspoons = usfloz.toTeaspoons 0.1<usfloz>

        teaspoons
        |> should (equalWithin 0.01) 0.4996043043

    [<Test>]
    let ``Convert known US fluid ounces to tablespoons`` () =
        let tablespoons = usfloz.toTablespoons 0.56<usfloz>

        tablespoons
        |> should (equalWithin 0.01) 0.9325947013

    [<Test>]
    let ``Convert known US fluid ounces to quarts`` () =
        let quarts = usfloz.toQuarts 600.<usfloz>

        quarts
        |> should (equalWithin 0.01) 15.6126345087

    [<Test>]
    let ``Convert known US fluid ounces to pints`` () =
        let pints = usfloz.toPints 67.<usfloz>

        pints
        |> should (equalWithin 0.01) 3.486821707

    [<Test>]
    let ``Convert known US fluid ounces to gallons`` () =
        let gallons = usfloz.toGallons 3450.<usfloz>

        gallons
        |> should (equalWithin 0.01) 22.4431621063

    [<Test>]
    let ``Convert known US fluid ounces to fluid ounces`` () =
        let fluidOunces = usfloz.toFluidOunces 23.<usfloz>

        fluidOunces
        |> should (equalWithin 0.01) 23.9393729134

    [<Test>]
    let ``Convert known US fluid ounces to US teaspoons`` () =
        let usTeaspoons = usfloz.toUSTeaspoons 466.<usfloz>

        usTeaspoons
        |> should (equalWithin 0.01) 2796.

    [<Test>]
    let ``Convert known US fluid ounces to US tablespoons`` () =
        let usTablespoons = usfloz.toUSTablespoons 15.<usfloz>

        usTablespoons
        |> should (equalWithin 0.01) 30.

    [<Test>]
    let ``Convert known US fluid ounces to US quarts`` () =
        let usQuarts = usfloz.toUSQuarts 45.<usfloz>

        usQuarts
        |> should (equalWithin 0.01) 1.40625

    [<Test>]
    let ``Convert known US fluid ounces to US pints`` () =
        let usPints = usfloz.toUSPints 12.<usfloz>

        usPints
        |> should (equalWithin 0.01) 0.75

    [<Test>]
    let ``Convert known US fluid ounces to US gallons`` () =
        let usGallons = usfloz.toUSGallons 190.<usfloz>

        usGallons
        |> should (equalWithin 0.01) 1.484375

    [<Test>]
    let ``Convert known US fluid ounces to US cups`` () =
        let usCups = usfloz.toUSCups 899.<usfloz>

        usCups
        |> should (equalWithin 0.01) 112.375
