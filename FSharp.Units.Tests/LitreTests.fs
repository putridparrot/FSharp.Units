namespace FSharp.Units.Tests

module LitreTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // litre to X and back

    [<Property>]
    let ``From litre to millilitre and back`` () =
        let property value = 
            let millilitres = l.toMillilitres (l.create value)
            let litres = ml.toLitres millilitres

            litres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to kilolitre and back`` () =
        let property value = 
            let kilometres = l.toKilolitres (l.create value)
            let litres = kl.toLitres kilometres

            litres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to teaspoons and back`` () =
        let property value = 
            let teaspoons = l.toTeaspoons (l.create value)
            let litres = tsp.toLitres teaspoons

            litres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to tablespoons and back`` () =
        let property value = 
            let tablespoons = l.toTablespoons (l.create value)
            let litres = tbsp.toLitres tablespoons

            litres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to quarts and back`` () =
        let property value = 
            let quarts = l.toQuarts (l.create value)
            let litres = qt.toLitres quarts

            litres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to pints and back`` () =
        let property value = 
            let pints = l.toPints (l.create value)
            let litres = pt.toLitres pints

            litres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to gallons and back`` () =
        let property value = 
            let gallons = l.toGallons (l.create value)
            let litres = gal.toLitres gallons

            litres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = l.toFluidOunces (l.create value)
            let litres = floz.toLitres fluidOunces

            litres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to US teaspoons and back`` () =
        let property value = 
            let teaspoons = l.toUSTeaspoons (l.create value)
            let litres = ustsp.toLitres teaspoons

            litres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to US tablespoons and back`` () =
        let property value = 
            let tablespoons = l.toUSTablespoons (l.create value)
            let litres = ustbsp.toLitres tablespoons

            litres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to US quarts and back`` () =
        let property value = 
            let quarts = l.toUSQuarts (l.create value)
            let litres = usqt.toLitres quarts

            litres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to US pints and back`` () =
        let property value = 
            let pints = l.toUSPints (l.create value)
            let litres = uspt.toLitres pints

            litres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to US gallons and back`` () =
        let property value = 
            let gallons = l.toUSGallons (l.create value)
            let litres = usgal.toLitres gallons

            litres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to US fluid ounces and back`` () =
        let property value = 
            let fluidOunces = l.toUSFluidOunces (l.create value)
            let litres = usfloz.toLitres fluidOunces

            litres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to US cups and back`` () =
        let property value = 
            let cups = l.toUSCups (l.create value)
            let litres = uscup.toLitres cups

            litres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)
    
    [<TestCase(123.9<l>, 123900.0)>]
    let ``Convert known litre to millilitre`` (input, expectation) =
        l.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1900000.<l>, 1900.)>]
    let ``Convert known litre to kilolitre`` (input, expectation) =
        l.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.006<l>, 1.0136178772)>]
    let ``Convert known litre to teaspoons`` (input, expectation) =
        l.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.009<l>, 0.5068089386)>]
    let ``Convert known litre to tablespoons`` (input, expectation) =
        l.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.34<l>, 0.299158054)>]
    let ``Convert known litre to quarts`` (input, expectation) =
        l.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.8<l>, 1.4078026072)>]
    let ``Convert known litre to pints`` (input, expectation) =
        l.toPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1234.<l>, 271.4419402081)>]
    let ``Convert known litre to gallons`` (input, expectation) =
        l.toGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.45<l>, 438.1785615028)>]
    let ``Convert known litre to fluid ounces`` (input, expectation) =
        l.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.007<l>, 1.4201889535)>]
    let ``Convert known litre to US teaspoons`` (input, expectation) =
        l.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.9<l>, 60.8652408633)>]
    let ``Convert known litre to US tablespoons`` (input, expectation) =
        l.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(80.7<l>, 85.2747385012)>]
    let ``Convert known litre to US quarts`` (input, expectation) =
        l.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(80.<l>, 169.0701135092)>]
    let ``Convert known litre to US pints`` (input, expectation) =
        l.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(123.5<l>, 32.6252484662)>]
    let ``Convert known litre to US gallons`` (input, expectation) =
        l.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.1<l>, 409.1496746923)>]
    let ``Convert known litre to US fluid ounces`` (input, expectation) =
        l.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1.2<l>, 5.0721034053)>]
    let ``Convert known litre to US cups`` (input, expectation) =
        l.toUSCups input
        |> should (equalWithin 0.01) expectation
