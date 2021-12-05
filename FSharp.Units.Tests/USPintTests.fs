namespace FSharp.Units.Tests

module USPintTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // US pint to X and back

    [<Property>]
    let ``From US pint to millilitre and back`` () =
        let property value = 
            let millilitres = uspt.toMillilitres (uspt.create value)
            let usPints = ml.toUSPints millilitres

            usPints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to litre and back`` () =
        let property value = 
            let litres = uspt.toLitres (uspt.create value)
            let usPints = l.toUSPints litres

            usPints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to kilolitre and back`` () =
        let property value = 
            let kilolitres = uspt.toKilolitres (uspt.create value)
            let usPints = kl.toUSPints kilolitres

            usPints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to teaspoon and back`` () =
        let property value = 
            let teaspoons = uspt.toTeaspoons (uspt.create value)
            let usPints = tsp.toUSPints teaspoons

            usPints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to tablespoon and back`` () =
        let property value = 
            let tablespoons = uspt.toTablespoons (uspt.create value)
            let usPints = tbsp.toUSPints tablespoons

            usPints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to quarts and back`` () =
        let property value = 
            let quarts = uspt.toQuarts (uspt.create value)
            let usPints = qt.toUSPints quarts

            usPints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to pints and back`` () =
        let property value = 
            let pints = uspt.toPints (uspt.create value)
            let usPints = pt.toUSPints pints

            usPints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to gallons and back`` () =
        let property value = 
            let gallons = uspt.toGallons (uspt.create value)
            let usPints = gal.toUSPints gallons

            usPints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = uspt.toFluidOunces (uspt.create value)
            let usPints = floz.toUSPints fluidOunces

            usPints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to US teaspoons and back`` () =
        let property value = 
            let teaSpoons = uspt.toUSTeaspoons (uspt.create value)
            let usPints = ustsp.toUSPints teaSpoons

            usPints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = uspt.toUSTablespoons (uspt.create value)
            let usPints = ustbsp.toUSPints usTablespoons

            usPints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to US quarts and back`` () =
        let property value = 
            let usQuarts = uspt.toUSQuarts (uspt.create value)
            let usPints = usqt.toUSPints usQuarts

            usPints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to US gallons and back`` () =
        let property value = 
            let usGallons = uspt.toUSGallons (uspt.create value)
            let usPints = usgal.toUSPints usGallons

            usPints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = uspt.toUSFluidOunces (uspt.create value)
            let usPints = usfloz.toUSPints usFluidOunces

            usPints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to US cups and back`` () =
        let property value = 
            let usCups = uspt.toUSCups (uspt.create value)
            let usPints = uscup.toUSPints usCups

            usPints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(17.8<uspt>, 8422.541)>]
    [<TestCase(0.78<uspt>, 369.0776)>]
    [<TestCase(5.6<uspt>, 2649.7882488)>]
    let ``Convert known US pints to millilitres`` (input, expectation) =
        uspt.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5.<uspt>, 2.36588)>]
    [<TestCase(190.8<uspt>, 90.282071)>]
    [<TestCase(239.<uspt>, 113.089177047)>]
    let ``Convert known US pints to litres`` (input, expectation) =
        uspt.toLitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5.<uspt>, 0.00236588)>]
    [<TestCase(190.8<uspt>, 0.090282071)>]
    [<TestCase(1020.<uspt>, 0.4826400025)>]
    let ``Convert known US pints to kilolitres`` (input, expectation) =
        uspt.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(7.1<uspt>, 567.55)>]
    [<TestCase(18.8<uspt>, 1502.81)>]
    [<TestCase(0.87<uspt>, 69.5449191558)>]
    let ``Convert known US pints to teaspoons`` (input, expectation) =
        uspt.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(8.9<uspt>, 237.146)>]
    [<TestCase(0.98<uspt>, 26.11265)>]
    [<TestCase(4.<uspt>, 106.5822515797)>]
    let ``Convert known US pints to tablespoons`` (input, expectation) =
        uspt.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.9<uspt>, 0.374703)>]
    [<TestCase(12.76<uspt>, 5.3124613)>]
    [<TestCase(45.<uspt>, 18.7351614105)>]
    let ``Convert known US pints to quarts`` (input, expectation) =
        uspt.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(89.<uspt>, 74.108)>]
    [<TestCase(7.8<uspt>, 6.49486)>]
    [<TestCase(23.<uspt>, 19.1514983307)>]
    let ``Convert known US pints to pints`` (input, expectation) =
        uspt.toPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(18.<uspt>, 1.87352)>]
    [<TestCase(809.<uspt>, 84.2042)>]
    [<TestCase(45.2<uspt>, 4.7046071986)>]
    let ``Convert known US pints to gallons`` (input, expectation) =
        uspt.toGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(77.<uspt>, 1282.32)>]
    [<TestCase(18.9<uspt>, 314.7508)>]
    [<TestCase(44.<uspt>, 732.7529796104)>]
    let ``Convert known US pints to fluid ounces`` (input, expectation) =
        uspt.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(18.<uspt>, 1728)>]
    [<TestCase(899<uspt>, 86304.)>]
    [<TestCase(0.04<uspt>, 3.84)>]
    let ``Convert known US pints to US teaspoons`` (input, expectation) =
        uspt.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(190.7<uspt>, 6102.4)>]
    [<TestCase(0.9<uspt>, 28.8)>]
    [<TestCase(0.45<uspt>, 14.4)>]
    let ``Convert known US pints to US tablespoons`` (input, expectation) =
        uspt.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.9<uspt>, 0.45)>]
    [<TestCase(781.9<uspt>, 390.95)>]
    [<TestCase(12.<uspt>, 6.)>]
    let ``Convert known US pints to US quarts`` (input, expectation) =
        uspt.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(781.9<uspt>, 97.7375)>]
    [<TestCase(0.98<uspt>, 0.1225)>]
    [<TestCase(600.<uspt>, 75.)>]
    let ``Convert known US pints to US gallons`` (input, expectation) =
        uspt.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.98<uspt>, 15.68)>]
    [<TestCase(6.78<uspt>, 108.48)>]
    [<TestCase(0.123<uspt>, 1.968)>]
    let ``Convert known US pints to US fluid ounces`` (input, expectation) =
        uspt.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(17.6<uspt>, 35.2)>]
    [<TestCase(9.<uspt>, 18.)>]
    [<TestCase(546.<uspt>, 1092.)>]
    let ``Convert known US pints to US cups`` (input, expectation) =
        uspt.toUSCups input
        |> should (equalWithin 0.01) expectation
