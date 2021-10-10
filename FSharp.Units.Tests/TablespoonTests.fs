namespace FSharp.Units.Tests

module TablespoonTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // tablespoon to X and back

    [<Property>]
    let ``tablespoon to millilitres and back`` () =
        let property value = 
            let millilitres = tbsp.toMillilitres (tbsp.create value)
            let tablepoon = ml.toTablespoons millilitres

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to litres and back`` () =
        let property value = 
            let litres = tbsp.toLitres (tbsp.create value)
            let tablepoon = l.toTablespoons litres

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to kilolitres and back`` () =
        let property value = 
            let kilolitres = tbsp.toKilolitres (tbsp.create value)
            let tablepoon = kl.toTablespoons kilolitres

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to teaspoons and back`` () =
        let property value = 
            let teaspoons = tbsp.toTeaspoons (tbsp.create value)
            let tablepoon = tsp.toTablespoons teaspoons

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to quarts and back`` () =
        let property value = 
            let quarts = tbsp.toQuarts (tbsp.create value)
            let tablepoon = qt.toTablespoons quarts

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to pints and back`` () =
        let property value = 
            let pints = tbsp.toPints (tbsp.create value)
            let tablepoon = pt.toTablespoons pints

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to gallons and back`` () =
        let property value = 
            let gallons = tbsp.toGallons (tbsp.create value)
            let tablepoon = gal.toTablespoons gallons

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = tbsp.toFluidOunces (tbsp.create value)
            let tablepoon = floz.toTablespoons fluidOunces

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to US teaspoons and back`` () =
        let property value = 
            let usTeaspoons = tbsp.toUSTeaspoons (tbsp.create value)
            let tablepoon = ustsp.toTablespoons usTeaspoons

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = tbsp.toUSTablespoons (tbsp.create value)
            let tablepoon = ustbsp.toTablespoons usTablespoons

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to US quarts and back`` () =
        let property value = 
            let usQuarts = tbsp.toUSQuarts (tbsp.create value)
            let tablepoon = usqt.toTablespoons usQuarts

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to US pints and back`` () =
        let property value = 
            let usPints = tbsp.toUSPints (tbsp.create value)
            let tablepoon = uspt.toTablespoons usPints

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to US gallons and back`` () =
        let property value = 
            let usGallons = tbsp.toUSGallons (tbsp.create value)
            let tablepoon = usgal.toTablespoons usGallons

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = tbsp.toUSFluidOunces (tbsp.create value)
            let tablepoon = usfloz.toTablespoons usFluidOunces

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to US cups and back`` () =
        let property value = 
            let usCups = tbsp.toUSCups (tbsp.create value)
            let tablepoon = uscup.toTablespoons usCups

            tablepoon
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.5<tbsp>, 44.3954285059)>]
    let ``Convert known tablepoon to millilitre`` (input, expectation) =
        tbsp.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(998.9<tbsp>, 17.7386374138)>]
    let ``Convert known tablepoon to litre`` (input, expectation) =
        tbsp.toLitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(180007.<tbsp>, 3.1965951596)>]
    let ``Convert known tablepoon to kilolitre`` (input, expectation) =
        tbsp.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(20.04<tbsp>, 60.12)>]
    let ``Convert known tablepoon to teaspoons`` (input, expectation) =
        tbsp.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1690.<tbsp>, 26.40625)>]
    let ``Convert known tablepoon to quarts`` (input, expectation) =
        tbsp.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(109.98<tbsp>, 3.436875)>]
    let ``Convert known tablepoon to pints`` (input, expectation) =
        tbsp.toPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(999.1<tbsp>, 3.902734375)>]
    let ``Convert known tablepoon to gallons`` (input, expectation) =
        tbsp.toGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1098.<tbsp>, 686.25)>]
    let ``Convert known tablepoon to fluid ounces`` (input, expectation) =
        tbsp.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3.<tbsp>, 10.808553797)>]
    let ``Convert known tablepoon to US teaspoons`` (input, expectation) =
        tbsp.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.7<tbsp>, 15.2520703579)>]
    let ``Convert known tablepoon to US tablespoons`` (input, expectation) =
        tbsp.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(777.34<tbsp>, 14.5866687648)>]
    let ``Convert known tablepoon to US quarts`` (input, expectation) =
        tbsp.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5930.123<tbsp>, 222.5557412086)>]
    let ``Convert known tablepoon to US pints`` (input, expectation) =
        tbsp.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(8000.9<tbsp>, 37.5339227752)>]
    let ``Convert known tablepoon to US gallons`` (input, expectation) =
        tbsp.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(304.<tbsp>, 182.5444641264)>]
    let ``Convert known tablepoon to US fluid ounces`` (input, expectation) =
        tbsp.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(600.<tbsp>, 45.0356408207)>]
    let ``Convert known tablepoon to US cups`` (input, expectation) =
        tbsp.toUSCups input
        |> should (equalWithin 0.01) expectation
