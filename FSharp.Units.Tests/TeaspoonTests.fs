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
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to litre and back`` () =
        let property value = 
            let litres = tsp.toLitres (tsp.create value)
            let teaspoon = l.toTeaspoons litres

            teaspoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to kilolitre and back`` () =
        let property value = 
            let kilolitres = tsp.toKilolitres (tsp.create value)
            let teaspoon = kl.toTeaspoons kilolitres

            teaspoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to tablespoon and back`` () =
        let property value = 
            let tablespoons = tsp.toTablespoons (tsp.create value)
            let teaspoon = tbsp.toTeaspoons tablespoons

            teaspoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to quart and back`` () =
        let property value = 
            let quarts = tsp.toQuarts (tsp.create value)
            let teaspoon = qt.toTeaspoons quarts

            teaspoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to pint and back`` () =
        let property value = 
            let pints = tsp.toPints (tsp.create value)
            let teaspoon = pt.toTeaspoons pints

            teaspoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to gallons and back`` () =
        let property value = 
            let gallons = tsp.toGallons (tsp.create value)
            let teaspoon = gal.toTeaspoons gallons

            teaspoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = tsp.toFluidOunces (tsp.create value)
            let teaspoon = floz.toTeaspoons fluidOunces

            teaspoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to US teaspoons and back`` () =
        let property value = 
            let usTeaspoons = tsp.toUSTeaspoons (tsp.create value)
            let teaspoon = ustsp.toTeaspoons usTeaspoons

            teaspoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = tsp.toUSTablespoons (tsp.create value)
            let teaspoon = ustbsp.toTeaspoons usTablespoons

            teaspoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to US quarts and back`` () =
        let property value = 
            let usQuarts = tsp.toUSQuarts (tsp.create value)
            let teaspoon = usqt.toTeaspoons usQuarts

            teaspoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to US pints and back`` () =
        let property value = 
            let usPints = tsp.toUSPints (tsp.create value)
            let teaspoon = uspt.toTeaspoons usPints

            teaspoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to US gallons and back`` () =
        let property value = 
            let usGallons = tsp.toUSGallons (tsp.create value)
            let teaspoon = usgal.toTeaspoons usGallons

            teaspoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = tsp.toUSFluidOunces (tsp.create value)
            let teaspoon = usfloz.toTeaspoons usFluidOunces

            teaspoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From teaspoon to US cups and back`` () =
        let property value = 
            let usCups = tsp.toUSCups (tsp.create value)
            let teaspoon = uscup.toTeaspoons usCups

            teaspoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.<tsp>, 11.8387809349)>]
    let ``Convert known teaspoon to millilitre`` (input, expectation) =
        tsp.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(45900.<tsp>, 271.7000224559)>]
    let ``Convert known teaspoon to litre`` (input, expectation) =
        tsp.toLitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5666.<tsp>, 0.0335392664)>]
    let ``Convert known teaspoon to kilolitre`` (input, expectation) =
        tsp.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(67.4<tsp>, 22.4666666667)>]
    let ``Convert known teaspoon to tablespoons`` (input, expectation) =
        tsp.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(900.8<tsp>, 4.6916666667)>]
    let ``Convert known teaspoon to quarts`` (input, expectation) =
        tsp.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5900.<tsp>, 61.4583333333)>]
    let ``Convert known teaspoon to pints`` (input, expectation) =
        tsp.toPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(8700.9<tsp>, 11.329296875)>]
    let ``Convert known teaspoon to gallons`` (input, expectation) =
        tsp.toGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(9467.<tsp>, 1972.2916666667)>]
    let ``Convert known teaspoon to fluid ounces`` (input, expectation) =
        tsp.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(8.<tsp>, 9.6076033751)>]
    let ``Convert known teaspoon to US teaspoons`` (input, expectation) =
        tsp.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(89.4<tsp>, 35.7883225721)>]
    let ``Convert known teaspoon to US tablespoons`` (input, expectation) =
        tsp.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(9000.<tsp>, 56.2945510258)>]
    let ``Convert known teaspoon to US quarts`` (input, expectation) =
        tsp.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(99888.<tsp>, 1249.5889139704)>]
    let ``Convert known teaspoon to US pints`` (input, expectation) =
        tsp.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(23000.<tsp>, 35.9659631554)>]
    let ``Convert known teaspoon to US gallons`` (input, expectation) =
        tsp.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(4577.<tsp>, 916.125013494)>]
    let ``Convert known teaspoon to US fluid ounces`` (input, expectation) =
        tsp.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(700.<tsp>, 17.5138603191)>]
    let ``Convert known teaspoon to US cups`` (input, expectation) =
        tsp.toUSCups input
        |> should (equalWithin 0.01) expectation
