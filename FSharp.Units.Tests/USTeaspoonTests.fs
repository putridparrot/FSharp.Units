namespace FSharp.Units.Tests

module USTeaspoonTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // US teaspoon to X and back    

    [<Property>]
    let ``From US teaspoon to millilitre and back`` () =
        let property value = 
            let millilitres = ustsp.toMillilitres (ustsp.create value)
            let usTeaspoons = ml.toUSTeaspoons millilitres

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to litre and back`` () =
        let property value = 
            let litres = ustsp.toLitres (ustsp.create value)
            let usTeaspoons = l.toUSTeaspoons litres

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to kilolitre and back`` () =
        let property value = 
            let kilolitres = ustsp.toKilolitres (ustsp.create value)
            let usTeaspoons = kl.toUSTeaspoons kilolitres

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to teaspoon and back`` () =
        let property value = 
            let teaspoons = ustsp.toTeaspoons (ustsp.create value)
            let usTeaspoons = tsp.toUSTeaspoons teaspoons

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to tablespoon and back`` () =
        let property value = 
            let tablespoons = ustsp.toTablespoons (ustsp.create value)
            let usTeaspoons = tbsp.toUSTeaspoons tablespoons

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to quarts and back`` () =
        let property value = 
            let quarts = ustsp.toQuarts (ustsp.create value)
            let usTeaspoons = qt.toUSTeaspoons quarts

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to pints and back`` () =
        let property value = 
            let pints = ustsp.toPints (ustsp.create value)
            let usTeaspoons = pt.toUSTeaspoons pints

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to gallons and back`` () =
        let property value = 
            let gallons = ustsp.toGallons (ustsp.create value)
            let usTeaspoons = gal.toUSTeaspoons gallons

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = ustsp.toFluidOunces (ustsp.create value)
            let usTeaspoons = floz.toUSTeaspoons fluidOunces

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to US tablespoons and back`` () =
        let property value = 
            let tableSpoons = ustsp.toUSTablespoons (ustsp.create value)
            let usTeaspoons = ustbsp.toUSTeaspoons tableSpoons

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to US quarts and back`` () =
        let property value = 
            let usQuarts = ustsp.toUSQuarts (ustsp.create value)
            let usTeaspoons = usqt.toUSTeaspoons usQuarts

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to US pints and back`` () =
        let property value = 
            let usPints = ustsp.toUSPints (ustsp.create value)
            let usTeaspoons = uspt.toUSTeaspoons usPints

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to US gallons and back`` () =
        let property value = 
            let usGallons = ustsp.toUSGallons (ustsp.create value)
            let usTeaspoons = usgal.toUSTeaspoons usGallons

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = ustsp.toUSFluidOunces (ustsp.create value)
            let usTeaspoons = usfloz.toUSTeaspoons usFluidOunces

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to US cups and back`` () =
        let property value = 
            let usCups = ustsp.toUSCups (ustsp.create value)
            let usTeaspoons = uscup.toUSTeaspoons usCups

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.9<ustsp>, 34.0095589969)>]
    let ``Convert known US teaspoons to millilitres`` (input, expectation) =
        ustsp.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(56090.<ustsp>, 276.4632121934)>]
    let ``Convert known US teaspoons to litres`` (input, expectation) =
        ustsp.toLitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(9600.<ustsp>, 0.0473176473)>]
    let ``Convert known US teaspoons to kilolitres`` (input, expectation) =
        ustsp.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5.<ustsp>, 4.1633692023)>]
    let ``Convert known US teaspoons to teaspoons`` (input, expectation) =
        ustsp.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(80.<ustsp>, 22.2046357458)>]
    let ``Convert known US teaspoons to tablespoons`` (input, expectation) =
        ustsp.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(19000.<ustsp>, 82.4000154628)>]
    let ``Convert known US teaspoons to quarts`` (input, expectation) =
        ustsp.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1000.<ustsp>, 8.6736858382)>]
    let ``Convert known US teaspoons to pints`` (input, expectation) =
        ustsp.toPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(4555.<ustsp>, 4.9385798741)>]
    let ``Convert known US teaspoons to gallons`` (input, expectation) =
        ustsp.toGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(400.<ustsp>, 69.3894867055)>]
    let ``Convert known US teaspoons to fluid ounces`` (input, expectation) =
        ustsp.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(700.<ustsp>, 233.3333333333)>]
    let ``Convert known US teaspoons to US tablespoons`` (input, expectation) =
        ustsp.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(46009.<ustsp>, 239.6302083333)>]
    let ``Convert known US teaspoons to US quarts`` (input, expectation) =
        ustsp.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(900.<ustsp>, 9.375)>]
    let ``Convert known US teaspoons to US pints`` (input, expectation) =
        ustsp.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(50000.<ustsp>, 65.1041666667)>]
    let ``Convert known US teaspoons to US gallons`` (input, expectation) =
        ustsp.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3099.<ustsp>, 516.5)>]
    let ``Convert known US teaspoons to US fluid ounces`` (input, expectation) =
        ustsp.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(6000.<ustsp>, 125.)>]
    let ``Convert known US teaspoons to US cups`` (input, expectation) =
        ustsp.toUSCups input
        |> should (equalWithin 0.01) expectation
