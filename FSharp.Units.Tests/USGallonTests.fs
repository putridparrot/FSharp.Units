namespace FSharp.Units.Tests

module USGallonTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // US gallon to X and back

    [<Property>]
    let ``From US Gallons to millilitre and back`` () =
        let property value = 
            let millilitres = usgal.toMillilitres (usgal.create value)
            let usGallons = ml.toUSGallons millilitres

            usGallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to litre and back`` () =
        let property value = 
            let litres = usgal.toLitres (usgal.create value)
            let usGallons = l.toUSGallons litres

            usGallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to kilolitre and back`` () =
        let property value = 
            let kilolitres = usgal.toKilolitres (usgal.create value)
            let usGallons = kl.toUSGallons kilolitres

            usGallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to teaspoon and back`` () =
        let property value = 
            let teaspoons = usgal.toTeaspoons (usgal.create value)
            let usGallons = tsp.toUSGallons teaspoons

            usGallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to tablespoon and back`` () =
        let property value = 
            let tablespoons = usgal.toTablespoons (usgal.create value)
            let usGallons = tbsp.toUSGallons tablespoons

            usGallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to quarts and back`` () =
        let property value = 
            let quarts = usgal.toQuarts (usgal.create value)
            let usGallons = qt.toUSGallons quarts

            usGallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to pints and back`` () =
        let property value = 
            let pints = usgal.toPints (usgal.create value)
            let usGallons = pt.toUSGallons pints

            usGallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to gallons and back`` () =
        let property value = 
            let gallons = usgal.toGallons (usgal.create value)
            let usGallons = gal.toUSGallons gallons

            usGallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = usgal.toFluidOunces (usgal.create value)
            let usGallons = floz.toUSGallons fluidOunces

            usGallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to US teaspoons and back`` () =
        let property value = 
            let teaSpoons = usgal.toUSTeaspoons (usgal.create value)
            let usGallons = ustsp.toUSGallons teaSpoons

            usGallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = usgal.toUSTablespoons (usgal.create value)
            let usGallons = ustbsp.toUSGallons usTablespoons

            usGallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to US quarts and back`` () =
        let property value = 
            let usQuarts = usgal.toUSQuarts (usgal.create value)
            let usGallons = usqt.toUSGallons usQuarts

            usGallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to US pints and back`` () =
        let property value = 
            let usPints = usgal.toUSPints (usgal.create value)
            let usGallons = uspt.toUSGallons usPints

            usGallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to US fluid ounces and back`` () =
        let property value = 
            let usFluidOUnces = usgal.toUSFluidOunces (usgal.create value)
            let usGallons = usfloz.toUSGallons usFluidOUnces

            usGallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to US cups and back`` () =
        let property value = 
            let usCups = usgal.toUSCups (usgal.create value)
            let usGallons = uscup.toUSGallons usCups

            usGallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.01<usgal>, 37.85411784)>]
    let ``Convert known US gallons to millilitres`` (input, expectation) =
        usgal.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(2.5<usgal>, 9.46352946)>]
    let ``Convert known US gallons to litres`` (input, expectation) =
        usgal.toLitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(34.<usgal>, 0.1287040007)>]
    let ``Convert known US gallons to kilolitres`` (input, expectation) =
        usgal.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.003<usgal>, 1.9184805284)>]
    let ``Convert known US gallons to teaspoons`` (input, expectation) =
        usgal.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.009<usgal>, 1.9184805284)>]
    let ``Convert known US gallons to tablespoons`` (input, expectation) =
        usgal.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.8<usgal>, 2.6645562895)>]
    let ``Convert known US gallons to quarts`` (input, expectation) =
        usgal.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5.1<usgal>, 33.973092691)>]
    let ``Convert known US gallons to pints`` (input, expectation) =
        usgal.toPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(506.<usgal>, 421.332963276)>]
    let ``Convert known US gallons to gallons`` (input, expectation) =
        usgal.toGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.98<usgal>, 130.5632581851)>]
    let ``Convert known US gallons to fluid ounces`` (input, expectation) =
        usgal.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.34<usgal>, 261.12)>]
    let ``Convert known US gallons to US teaspoons`` (input, expectation) =
        usgal.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.9<usgal>, 230.4)>]
    let ``Convert known US gallons to US tablespoons`` (input, expectation) =
        usgal.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.3<usgal>, 49.2)>]
    let ``Convert known US gallons to US quarts`` (input, expectation) =
        usgal.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.09<usgal>, 0.72)>]
    let ``Convert known US gallons to US pints`` (input, expectation) =
        usgal.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.9<usgal>, 115.2)>]
    let ``Convert known US gallons to US fluid ounces`` (input, expectation) =
        usgal.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(56.<usgal>, 896.)>]
    let ``Convert known US gallons to US cups`` (input, expectation) =
        usgal.toUSCups input
        |> should (equalWithin 0.01) expectation
