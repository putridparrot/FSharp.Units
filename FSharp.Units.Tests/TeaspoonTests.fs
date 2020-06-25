namespace FSharp.Units.Tests

module TeaspoonTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // teaspoon to X and back

    [<Property>]
    let ``From teaspoon to millilitre and back`` () =
        let property value = 
            let millilitres = tsp.toMillilitres (tsp.create value)
            let teaspoon = ml.toTeaspoons millilitres

            teaspoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to litre and back`` () =
        let property value = 
            let litres = tsp.toLitres (tsp.create value)
            let teaspoon = l.toTeaspoons litres

            teaspoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to kilolitre and back`` () =
        let property value = 
            let kilolitres = tsp.toKilolitres (tsp.create value)
            let teaspoon = kl.toTeaspoons kilolitres

            teaspoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to tablespoon and back`` () =
        let property value = 
            let tablespoons = tsp.toTablespoons (tsp.create value)
            let teaspoon = tbsp.toTeaspoons tablespoons

            teaspoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to quart and back`` () =
        let property value = 
            let quarts = tsp.toQuarts (tsp.create value)
            let teaspoon = qt.toTeaspoons quarts

            teaspoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to pint and back`` () =
        let property value = 
            let pints = tsp.toPints (tsp.create value)
            let teaspoon = pt.toTeaspoons pints

            teaspoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to gallons and back`` () =
        let property value = 
            let gallons = tsp.toGallons (tsp.create value)
            let teaspoon = gal.toTeaspoons gallons

            teaspoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = tsp.toFluidOunces (tsp.create value)
            let teaspoon = floz.toTeaspoons fluidOunces

            teaspoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to US teaspoons and back`` () =
        let property value = 
            let usTeaspoons = tsp.toUSTeaspoons (tsp.create value)
            let teaspoon = ustsp.toTeaspoons usTeaspoons

            teaspoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = tsp.toUSTablespoons (tsp.create value)
            let teaspoon = ustbsp.toTeaspoons usTablespoons

            teaspoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to US quarts and back`` () =
        let property value = 
            let usQuarts = tsp.toUSQuarts (tsp.create value)
            let teaspoon = usqt.toTeaspoons usQuarts

            teaspoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to US pints and back`` () =
        let property value = 
            let usPints = tsp.toUSPints (tsp.create value)
            let teaspoon = uspt.toTeaspoons usPints

            teaspoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to US gallons and back`` () =
        let property value = 
            let usGallons = tsp.toUSGallons (tsp.create value)
            let teaspoon = usgal.toTeaspoons usGallons

            teaspoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = tsp.toUSFluidOunces (tsp.create value)
            let teaspoon = usfloz.toTeaspoons usFluidOunces

            teaspoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to US cups and back`` () =
        let property value = 
            let usCups = tsp.toUSCups (tsp.create value)
            let teaspoon = uscup.toTeaspoons usCups

            teaspoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known teaspoon to millilitre`` () =
        let millilitre = tsp.toMillilitres 2.<tsp>

        millilitre
        |> should (equalWithin 0.1) 11.8387809349

    [<Test>]
    let ``Convert known teaspoon to litre`` () =
        let litres = tsp.toLitres 45900.<tsp>

        litres
        |> should (equalWithin 0.1) 271.7000224559

    [<Test>]
    let ``Convert known teaspoon to kilolitre`` () =
        let kilolitres = tsp.toKilolitres 5666.<tsp>

        kilolitres
        |> should (equalWithin 0.1) 0.0335392664

    [<Test>]
    let ``Convert known teaspoon to tablespoons`` () =
        let tablespoons = tsp.toTablespoons 67.4<tsp>

        tablespoons
        |> should (equalWithin 0.1) 22.4666666667

    [<Test>]
    let ``Convert known teaspoon to quarts`` () =
        let quarts = tsp.toQuarts 900.8<tsp>

        quarts
        |> should (equalWithin 0.1) 4.6916666667

    [<Test>]
    let ``Convert known teaspoon to pints`` () =
        let pints = tsp.toPints 5900.<tsp>

        pints
        |> should (equalWithin 0.1) 61.4583333333

    [<Test>]
    let ``Convert known teaspoon to gallons`` () =
        let gallons = tsp.toGallons 8700.9<tsp>

        gallons
        |> should (equalWithin 0.1) 11.329296875

    [<Test>]
    let ``Convert known teaspoon to fluid ounces`` () =
        let fluidOunces = tsp.toFluidOunces 9467.<tsp>

        fluidOunces
        |> should (equalWithin 0.1) 1972.2916666667

    [<Test>]
    let ``Convert known teaspoon to US teaspoons`` () =
        let usTeaspoons = tsp.toUSTeaspoons 8.<tsp>

        usTeaspoons
        |> should (equalWithin 0.1) 9.6076033751

    [<Test>]
    let ``Convert known teaspoon to US tablespoons`` () =
        let usTablespoons = tsp.toUSTablespoons 89.4<tsp>

        usTablespoons
        |> should (equalWithin 0.1) 35.7883225721

    [<Test>]
    let ``Convert known teaspoon to US quarts`` () =
        let usQuarts = tsp.toUSQuarts 9000.<tsp>

        usQuarts
        |> should (equalWithin 0.1) 56.2945510258

    [<Test>]
    let ``Convert known teaspoon to US pints`` () =
        let usPints = tsp.toUSPints 99888.<tsp>

        usPints
        |> should (equalWithin 0.1) 1249.5889139704

    [<Test>]
    let ``Convert known teaspoon to US gallons`` () =
        let usGallons = tsp.toUSGallons 23000.<tsp>

        usGallons
        |> should (equalWithin 0.1) 35.9659631554

    [<Test>]
    let ``Convert known teaspoon to US fluid ounces`` () =
        let usFluidOunces = tsp.toUSFluidOunces 4577.<tsp>

        usFluidOunces
        |> should (equalWithin 0.1) 916.125013494

    [<Test>]
    let ``Convert known teaspoon to US cups`` () =
        let usCups = tsp.toUSCups 700.<tsp>

        usCups
        |> should (equalWithin 0.1) 17.5138603191
