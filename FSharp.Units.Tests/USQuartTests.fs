namespace FSharp.Units.Tests

module USQuartTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // US quart to X and back

    [<Property>]
    let ``From US quart to millilitre and back`` () =
        let property value = 
            let millilitres = usqt.toMillilitres (usqt.create value)
            let usQuarts = ml.toUSQuarts millilitres

            usQuarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to litre and back`` () =
        let property value = 
            let litres = usqt.toLitres (usqt.create value)
            let usQuarts = l.toUSQuarts litres

            usQuarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to kilolitre and back`` () =
        let property value = 
            let kilolitres = usqt.toKilolitres (usqt.create value)
            let usQuarts = kl.toUSQuarts kilolitres

            usQuarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to teaspoon and back`` () =
        let property value = 
            let teaspoons = usqt.toTeaspoons (usqt.create value)
            let usQuarts = tsp.toUSQuarts teaspoons

            usQuarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to tablespoon and back`` () =
        let property value = 
            let tablespoons = usqt.toTablespoons (usqt.create value)
            let usQuarts = tbsp.toUSQuarts tablespoons

            usQuarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to quarts and back`` () =
        let property value = 
            let quarts = usqt.toQuarts (usqt.create value)
            let usQuarts = qt.toUSQuarts quarts

            usQuarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to pints and back`` () =
        let property value = 
            let pints = usqt.toPints (usqt.create value)
            let usQuarts = pt.toUSQuarts pints

            usQuarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to gallons and back`` () =
        let property value = 
            let gallons = usqt.toGallons (usqt.create value)
            let usQuarts = gal.toUSQuarts gallons

            usQuarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = usqt.toFluidOunces (usqt.create value)
            let usQuarts = floz.toUSQuarts fluidOunces

            usQuarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to US teaspoons and back`` () =
        let property value = 
            let teaSpoons = usqt.toUSTeaspoons (usqt.create value)
            let usQuarts = ustsp.toUSQuarts teaSpoons

            usQuarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = usqt.toUSTablespoons (usqt.create value)
            let usQuarts = ustbsp.toUSQuarts usTablespoons

            usQuarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to US pints and back`` () =
        let property value = 
            let usPints = usqt.toUSPints (usqt.create value)
            let usQuarts = uspt.toUSQuarts usPints

            usQuarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to US gallons and back`` () =
        let property value = 
            let usGallons = usqt.toUSGallons (usqt.create value)
            let usQuarts = usgal.toUSQuarts usGallons

            usQuarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = usqt.toUSFluidOunces (usqt.create value)
            let usQuarts = usfloz.toUSQuarts usFluidOunces

            usQuarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to US cups and back`` () =
        let property value = 
            let usCups = usqt.toUSCups (usqt.create value)
            let usQuarts = uscup.toUSQuarts usCups

            usQuarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.01<usqt>, 9.46352946)>]
    let ``Convert known US quarts to millilitres`` (input, expectation) =
        usqt.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(23.<usqt>, 21.766117758)>]
    let ``Convert known US quarts to litres`` (input, expectation) =
        usqt.toLitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(304.<usqt>, 0.2876912956)>]
    let ``Convert known US quarts to kilolitres`` (input, expectation) =
        usqt.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.09<usqt>, 14.3886039633)>]
    let ``Convert known US quarts to teaspoons`` (input, expectation) =
        usqt.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.6<usqt>, 31.9746754739)>]
    let ``Convert known US quarts to tablespoons`` (input, expectation) =
        usqt.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.<usqt>, 9.9920860856)>]
    let ``Convert known US quarts to quarts`` (input, expectation) =
        usqt.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(45.8<usqt>, 76.2729237867)>]
    let ``Convert known US quarts to pints`` (input, expectation) =
        usqt.toPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(56.<usqt>, 11.6574337665)>]
    let ``Convert known US quarts to gallons`` (input, expectation) =
        usqt.toGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(56.<usqt>, 1865.1894026447)>]
    let ``Convert known US quarts to fluid ounces`` (input, expectation) =
        usqt.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.5<usqt>, 96.)>]
    let ``Convert known US quarts to US teaspoons`` (input, expectation) =
        usqt.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.4<usqt>, 25.6)>]
    let ``Convert known US quarts to US tablespoons`` (input, expectation) =
        usqt.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(7.<usqt>, 14.)>]
    let ``Convert known US quarts to US pints`` (input, expectation) =
        usqt.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(44.<usqt>, 11.)>]
    let ``Convert known US quarts to US gallons`` (input, expectation) =
        usqt.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1.2<usqt>, 38.4)>]
    let ``Convert known US quarts to US fluid ounces`` (input, expectation) =
        usqt.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(123.<usqt>, 492.)>]
    let ``Convert known US quarts to US cups`` (input, expectation) =
        usqt.toUSCups input
        |> should (equalWithin 0.01) expectation
