namespace FSharp.Units.Tests

module USFluidOunceTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // US fluid ounce to X and back

    [<Property>]
    let ``From US fluid ounces to millilitre and back`` () =
        let property value = 
            let millilitres = usfloz.toMillilitres (usfloz.create value)
            let usFluidOunces = ml.toUSFluidOunces millilitres

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to litre and back`` () =
        let property value = 
            let litres = usfloz.toLitres (usfloz.create value)
            let usFluidOunces = l.toUSFluidOunces litres

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to kilolitre and back`` () =
        let property value = 
            let kilolitres = usfloz.toKilolitres (usfloz.create value)
            let usFluidOunces = kl.toUSFluidOunces kilolitres

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to teaspoon and back`` () =
        let property value = 
            let teaspoons = usfloz.toTeaspoons (usfloz.create value)
            let usFluidOunces = tsp.toUSFluidOunces teaspoons

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to tablespoon and back`` () =
        let property value = 
            let tablespoons = usfloz.toTablespoons (usfloz.create value)
            let usFluidOunces = tbsp.toUSFluidOunces tablespoons

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to quarts and back`` () =
        let property value = 
            let quarts = usfloz.toQuarts (usfloz.create value)
            let usFluidOunces = qt.toUSFluidOunces quarts

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to pints and back`` () =
        let property value = 
            let pints = usfloz.toPints (usfloz.create value)
            let usFluidOunces = pt.toUSFluidOunces pints

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to gallons and back`` () =
        let property value = 
            let gallons = usfloz.toGallons (usfloz.create value)
            let usFluidOunces = gal.toUSFluidOunces gallons

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = usfloz.toFluidOunces (usfloz.create value)
            let usFluidOunces = floz.toUSFluidOunces fluidOunces

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to US teaspoons and back`` () =
        let property value = 
            let teaSpoons = usfloz.toUSTeaspoons (usfloz.create value)
            let usFluidOunces = ustsp.toUSFluidOunces teaSpoons

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = usfloz.toUSTablespoons (usfloz.create value)
            let usFluidOunces = ustbsp.toUSFluidOunces usTablespoons

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to US quarts and back`` () =
        let property value = 
            let usQuarts = usfloz.toUSQuarts (usfloz.create value)
            let usFluidOunces = usqt.toUSFluidOunces usQuarts

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to US pints and back`` () =
        let property value = 
            let usPints = usfloz.toUSPints (usfloz.create value)
            let usFluidOunces = uspt.toUSFluidOunces usPints

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to US gallons and back`` () =
        let property value = 
            let usGallons = usfloz.toUSGallons (usfloz.create value)
            let usFluidOunces = usgal.toUSFluidOunces usGallons

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US fluid ounces to US cups and back`` () =
        let property value = 
            let usCups = usfloz.toUSCups (usfloz.create value)
            let usFluidOunces = uscup.toUSFluidOunces usCups

            usFluidOunces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8.7<usfloz>, 257.2897071937)>]
    let ``Convert known US fluid ounces to millilitres`` (input, expectation) =
        usfloz.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(450.<usfloz>, 13.3080883031)>]
    let ``Convert known US fluid ounces to litres`` (input, expectation) =
        usfloz.toLitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(567.<usfloz>, 0.0167681913)>]
    let ``Convert known US fluid ounces to kilolitres`` (input, expectation) =
        usfloz.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.1<usfloz>, 0.4996043043)>]
    let ``Convert known US fluid ounces to teaspoons`` (input, expectation) =
        usfloz.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.56<usfloz>, 0.9325947013)>]
    let ``Convert known US fluid ounces to tablespoons`` (input, expectation) =
        usfloz.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(600.<usfloz>, 15.6126345087)>]
    let ``Convert known US fluid ounces to quarts`` (input, expectation) =
        usfloz.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(67.<usfloz>, 3.486821707)>]
    let ``Convert known US fluid ounces to pints`` (input, expectation) =
        usfloz.toPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3450.<usfloz>, 22.4431621063)>]
    let ``Convert known US fluid ounces to gallons`` (input, expectation) =
        usfloz.toGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(23.<usfloz>, 23.9393729134)>]
    let ``Convert known US fluid ounces to fluid ounces`` (input, expectation) =
        usfloz.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(466.<usfloz>, 2796.)>]
    let ``Convert known US fluid ounces to US teaspoons`` (input, expectation) =
        usfloz.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(15.<usfloz>, 30.)>]
    let ``Convert known US fluid ounces to US tablespoons`` (input, expectation) =
        usfloz.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(45.<usfloz>, 1.40625)>]
    let ``Convert known US fluid ounces to US quarts`` (input, expectation) =
        usfloz.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.<usfloz>, 0.75)>]
    let ``Convert known US fluid ounces to US pints`` (input, expectation) =
        usfloz.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(190.<usfloz>, 1.484375)>]
    let ``Convert known US fluid ounces to US gallons`` (input, expectation) =
        usfloz.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(899.<usfloz>, 112.375)>]
    let ``Convert known US fluid ounces to US cups`` (input, expectation) =
        usfloz.toUSCups input
        |> should (equalWithin 0.01) expectation
