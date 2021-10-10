namespace FSharp.Units.Tests

module USCupTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // US cup to X and back

    [<Property>]
    let ``From US Cups to millilitre and back`` () =
        let property value = 
            let millilitres = uscup.toMillilitres (uscup.create value)
            let usCups = ml.toUSCups millilitres

            usCups
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to litre and back`` () =
        let property value = 
            let litres = uscup.toLitres (uscup.create value)
            let usCups = l.toUSCups litres

            usCups
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to kilolitre and back`` () =
        let property value = 
            let kilolitres = uscup.toKilolitres (uscup.create value)
            let usCups = kl.toUSCups kilolitres

            usCups
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to teaspoon and back`` () =
        let property value = 
            let teaspoons = uscup.toTeaspoons (uscup.create value)
            let usCups = tsp.toUSCups teaspoons

            usCups
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to tablespoon and back`` () =
        let property value = 
            let tablespoons = uscup.toTablespoons (uscup.create value)
            let usCups = tbsp.toUSCups tablespoons

            usCups
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to quarts and back`` () =
        let property value = 
            let quarts = uscup.toQuarts (uscup.create value)
            let usCups = qt.toUSCups quarts

            usCups
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to pints and back`` () =
        let property value = 
            let pints = uscup.toPints (uscup.create value)
            let usCups = pt.toUSCups pints

            usCups
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to gallons and back`` () =
        let property value = 
            let gallons = uscup.toGallons (uscup.create value)
            let usCups = gal.toUSCups gallons

            usCups
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = uscup.toFluidOunces (uscup.create value)
            let usCups = floz.toUSCups fluidOunces

            usCups
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to US teaspoons and back`` () =
        let property value = 
            let teaSpoons = uscup.toUSTeaspoons (uscup.create value)
            let usCups = ustsp.toUSCups teaSpoons

            usCups
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = uscup.toUSTablespoons (uscup.create value)
            let usCups = ustbsp.toUSCups usTablespoons

            usCups
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to US quarts and back`` () =
        let property value = 
            let usQuarts = uscup.toUSQuarts (uscup.create value)
            let usCups = usqt.toUSCups usQuarts

            usCups
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to US pints and back`` () =
        let property value = 
            let usPints = uscup.toUSPints (uscup.create value)
            let usCups = uspt.toUSCups usPints

            usCups
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to US gallons and back`` () =
        let property value = 
            let usGallons = uscup.toUSGallons (uscup.create value)
            let usCups = usgal.toUSCups usGallons

            usCups
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to US fluid ounces and back`` () =
        let property value = 
            let usFluidOUnces = uscup.toUSFluidOunces (uscup.create value)
            let usCups = usfloz.toUSCups usFluidOUnces

            usCups
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<uscup>, 283.9058838)>]
    let ``Convert known US cup to millilitres`` (input, expectation) =
        uscup.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(23.8<uscup>, 5.6308000287)>]
    let ``Convert known US cup to litres`` (input, expectation) =
        uscup.toLitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5079.<uscup>, 1.2016316532)>]
    let ``Convert known US cup to kilolitres`` (input, expectation) =
        uscup.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1.8<uscup>, 71.9430198163)>]
    let ``Convert known US cup to teaspoons`` (input, expectation) =
        uscup.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.5<uscup>, 6.6613907237)>]
    let ``Convert known US cup to tablespoons`` (input, expectation) =
        uscup.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(43.2<uscup>, 8.992877477)>]
    let ``Convert known US cup to quarts`` (input, expectation) =
        uscup.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(45.6<uscup>, 18.9849635626)>]
    let ``Convert known US cup to pints`` (input, expectation) =
        uscup.toPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(800.<uscup>, 41.6336920233)>]
    let ``Convert known US cup to gallons`` (input, expectation) =
        uscup.toGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1.3<uscup>, 10.8247599261)>]
    let ``Convert known US cup to fluid ounces`` (input, expectation) =
        uscup.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(102.<uscup>, 4896.)>]
    let ``Convert known US cup to US teaspoons`` (input, expectation) =
        uscup.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.3<uscup>, 4.8)>]
    let ``Convert known US cup to US tablespoons`` (input, expectation) =
        uscup.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(13.9<uscup>, 3.475)>]
    let ``Convert known US cup to US quarts`` (input, expectation) =
        uscup.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(4.3<uscup>, 2.15)>]
    let ``Convert known US cup to US pints`` (input, expectation) =
        uscup.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(45.6<uscup>, 2.85)>]
    let ``Convert known US cup to US gallons`` (input, expectation) =
        uscup.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3.2<uscup>, 25.6)>]
    let ``Convert known US cup to US fluid ounces`` (input, expectation) =
        uscup.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation
