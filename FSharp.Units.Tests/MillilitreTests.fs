namespace FSharp.Units.Tests

module MillilitreTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // millilitre to X and back

    [<Property>]
    let ``From millilitre to litre and back`` () =
        let property value = 
            let litres = ml.toLitres (ml.create value)
            let millilitres = l.toMillilitres litres

            millilitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to kilolitre and back`` () =
        let property value = 
            let kilolitres = ml.toKilolitres (ml.create value)
            let millilitres = kl.toMillilitres kilolitres

            millilitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to teaspoon and back`` () =
        let property value = 
            let teaspoons = ml.toTeaspoons (ml.create value)
            let millilitres = tsp.toMillilitres teaspoons

            millilitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to tablespoon and back`` () =
        let property value = 
            let tablespoons = ml.toTablespoons (ml.create value)
            let millilitres = tbsp.toMillilitres tablespoons

            millilitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to quart and back`` () =
        let property value = 
            let quarts = ml.toQuarts (ml.create value)
            let millilitres = qt.toMillilitres quarts

            millilitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to pint and back`` () =
        let property value = 
            let pints = ml.toPints (ml.create value)
            let millilitres = pt.toMillilitres pints

            millilitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to gallon and back`` () =
        let property value = 
            let gallons = ml.toGallons (ml.create value)
            let millilitres = gal.toMillilitres gallons

            millilitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = ml.toFluidOunces (ml.create value)
            let millilitres = floz.toMillilitres fluidOunces

            millilitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to US teaspoon and back`` () =
        let property value = 
            let usTeaspoons = ml.toUSTeaspoons (ml.create value)
            let millilitres = ustsp.toMillilitres usTeaspoons

            millilitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to US tablespoon and back`` () =
        let property value = 
            let usTablespoons = ml.toUSTablespoons (ml.create value)
            let millilitres = ustbsp.toMillilitres usTablespoons

            millilitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to US quarts and back`` () =
        let property value = 
            let usQuarts = ml.toUSQuarts (ml.create value)
            let millilitres = usqt.toMillilitres usQuarts

            millilitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to US pints and back`` () =
        let property value = 
            let usPints = ml.toUSPints (ml.create value)
            let millilitres = uspt.toMillilitres usPints

            millilitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to US gallons and back`` () =
        let property value = 
            let usGallons = ml.toUSGallons (ml.create value)
            let millilitres = usgal.toMillilitres usGallons

            millilitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = ml.toUSFluidOunces (ml.create value)
            let millilitres = usfloz.toMillilitres usFluidOunces

            millilitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to US cups and back`` () =
        let property value = 
            let usCups = ml.toUSCups (ml.create value)
            let millilitres = uscup.toMillilitres usCups

            millilitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2567.0<ml>, 2.567)>]
    let ``Convert known millilitre to litre`` (input, expectation) =
        ml.toLitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(145.0<ml>, 0.000145)>]
    let ``Convert known millilitre to kilolitre`` (input, expectation) =
        ml.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1230.0<ml>, 207.7916648283)>]
    let ``Convert known millilitre to teaspoon`` (input, expectation) =
        ml.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(4000.0<ml>, 225.2484171581)>]
    let ``Convert known millilitre to tablespoon`` (input, expectation) =
        ml.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3900.<ml>, 3.4315188551)>]
    let ``Convert known millilitre to quarts`` (input, expectation) =
        ml.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(19099.<ml>, 33.6095274945)>]
    let ``Convert known millilitre to pints`` (input, expectation) =
        ml.toPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(129000.<ml>, 28.3760213021)>]
    let ``Convert known millilitre to gallons`` (input, expectation) =
        ml.toGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(2900.<ml>, 102.0656890248)>]
    let ``Convert known millilitre to fluid ounces`` (input, expectation) =
        ml.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1234.<ml>, 250.3590240844)>]
    let ``Convert known millilitre to US teaspoons`` (input, expectation) =
        ml.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5009.<ml>, 338.7488794271)>]
    let ``Convert known millilitre to US tablespoons`` (input, expectation) =
        ml.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(8888.<ml>, 9.3918448054)>]
    let ``Convert known millilitre to US quarts`` (input, expectation) =
        ml.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(48903.<ml>, 103.3504470118)>]
    let ``Convert known millilitre to US pints`` (input, expectation) =
        ml.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(50600.<ml>, 13.3671058493)>]
    let ``Convert known millilitre to US gallons`` (input, expectation) =
        ml.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5900.<ml>, 199.5027339409)>]
    let ``Convert known millilitre to US fluid ounces`` (input, expectation) =
        ml.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(9000.0<ml>, 38.0407755396)>]
    let ``Convert known millilitre to US cups`` (input, expectation) =
        ml.toUSCups input
        |> should (equalWithin 0.01) expectation
