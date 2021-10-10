namespace FSharp.Units.Tests

module QuartTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // quart to X and back

    [<Property>]
    let ``quart to millilitres and back`` () =
        let property value = 
            let millilitres = qt.toMillilitres (qt.create value)
            let tablepoon = ml.toQuarts millilitres

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to litres and back`` () =
        let property value = 
            let litres = qt.toLitres (qt.create value)
            let quarts = l.toQuarts litres

            quarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to kilolitres and back`` () =
        let property value = 
            let kilolitres = qt.toKilolitres (qt.create value)
            let quarts = kl.toQuarts kilolitres

            quarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to teaspoons and back`` () =
        let property value = 
            let teaspoons = qt.toTeaspoons (qt.create value)
            let quarts = tsp.toQuarts teaspoons

            quarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to tablespoons and back`` () =
        let property value = 
            let tablespoons = qt.toTablespoons (qt.create value)
            let quarts = tbsp.toQuarts tablespoons

            quarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to pints and back`` () =
        let property value = 
            let pints = qt.toPints (qt.create value)
            let quarts = pt.toQuarts pints

            quarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to gallons and back`` () =
        let property value = 
            let gallons = qt.toGallons (qt.create value)
            let quarts = gal.toQuarts gallons

            quarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = qt.toFluidOunces (qt.create value)
            let quarts = floz.toQuarts fluidOunces

            quarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to US teaspoons and back`` () =
        let property value = 
            let usTeaspoons = qt.toUSTeaspoons (qt.create value)
            let quarts = ustsp.toQuarts usTeaspoons

            quarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = qt.toUSTablespoons (qt.create value)
            let quarts = ustbsp.toQuarts usTablespoons

            quarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to US quarts and back`` () =
        let property value = 
            let usQuarts = qt.toUSQuarts (qt.create value)
            let quarts = usqt.toQuarts usQuarts

            quarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to US pints and back`` () =
        let property value = 
            let usPints = qt.toUSPints (qt.create value)
            let quarts = uspt.toQuarts usPints

            quarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to US gallons and back`` () =
        let property value = 
            let usGallons = qt.toUSGallons (qt.create value)
            let quarts = usgal.toQuarts usGallons

            quarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = qt.toUSFluidOunces (qt.create value)
            let quarts = usfloz.toQuarts usFluidOunces

            quarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to US cups and back`` () =
        let property value = 
            let usCups = qt.toUSCups (qt.create value)
            let quarts = uscup.toQuarts usCups

            quarts
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.567<qt>, 644.4085238483)>]
    let ``Convert known quart to millilitres`` (input, expectation) =
        qt.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(8.9<qt>, 10.1150544308)>]
    let ``Convert known quart to litres`` (input, expectation) =
        qt.toLitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1200.<qt>, 1.3638275637)>]
    let ``Convert known quart to kilolitres`` (input, expectation) =
        qt.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.008<qt>, 1.536)>]
    let ``Convert known quart to teaspoons`` (input, expectation) =
        qt.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.09<qt>, 5.76)>]
    let ``Convert known quart to tablespoons`` (input, expectation) =
        qt.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(16.98<qt>, 33.96)>]
    let ``Convert known quart to pints`` (input, expectation) =
        qt.toPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(109.2<qt>, 27.3)>]
    let ``Convert known quart to gallons`` (input, expectation) =
        qt.toGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3.12<qt>, 124.8)>]
    let ``Convert known quart to fluid ounces`` (input, expectation) =
        qt.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.001<qt>, 0.230582481)>]
    let ``Convert known quart to US teaspoons`` (input, expectation) =
        qt.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.006<qt>, 0.461164962)>]
    let ``Convert known quart to US tablespoons`` (input, expectation) =
        qt.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(87.<qt>, 104.4826867039)>]
    let ``Convert known quart to US quarts`` (input, expectation) =
        qt.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(908.2<qt>, 2181.4063463104)>]
    let ``Convert known quart to US pints`` (input, expectation) =
        qt.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(108.3<qt>, 32.5157326725)>]
    let ``Convert known quart to US gallons`` (input, expectation) =
        qt.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(34.<qt>, 1306.6340590099)>]
    let ``Convert known quart to US fluid ounces`` (input, expectation) =
        qt.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.8<qt>, 61.4886616005)>]
    let ``Convert known quart to US cups`` (input, expectation) =
        qt.toUSCups input
        |> should (equalWithin 0.01) expectation
