namespace FSharp.Units.Tests

module GallonTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // gallon to X and back

    [<Property>]
    let ``gallon to millilitres and back`` () =
        let property value = 
            let millilitres = gal.toMillilitres (gal.create value)
            let gallons = ml.toGallons millilitres

            gallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to litres and back`` () =
        let property value = 
            let litres = gal.toLitres (gal.create value)
            let gallons = l.toGallons litres

            gallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to kilolitres and back`` () =
        let property value = 
            let kilolitres = gal.toKilolitres (gal.create value)
            let gallons = kl.toGallons kilolitres

            gallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to teaspoons and back`` () =
        let property value = 
            let teaspoons = gal.toTeaspoons (gal.create value)
            let gallons = tsp.toGallons teaspoons

            gallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to tablespoons and back`` () =
        let property value = 
            let tablespoons = gal.toTablespoons (gal.create value)
            let gallons = tbsp.toGallons tablespoons

            gallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to quarts and back`` () =
        let property value = 
            let quarts = gal.toQuarts (gal.create value)
            let gallons = qt.toGallons quarts

            gallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to pints and back`` () =
        let property value = 
            let pints = gal.toPints (gal.create value)
            let gallons = pt.toGallons pints

            gallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = gal.toFluidOunces (gal.create value)
            let gallons = floz.toGallons fluidOunces

            gallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to US teaspoons and back`` () =
        let property value = 
            let usTeaspoons = gal.toUSTeaspoons (gal.create value)
            let gallons = ustsp.toGallons usTeaspoons

            gallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = gal.toUSTablespoons (gal.create value)
            let gallons = ustbsp.toGallons usTablespoons

            gallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to US quarts and back`` () =
        let property value = 
            let usQuarts = gal.toUSQuarts (gal.create value)
            let gallons = usqt.toGallons usQuarts

            gallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to US pints and back`` () =
        let property value = 
            let usPints = gal.toUSPints (gal.create value)
            let gallons = uspt.toGallons usPints

            gallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to US gallons and back`` () =
        let property value = 
            let usGallons = gal.toUSGallons (gal.create value)
            let gallons = usgal.toGallons usGallons

            gallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = gal.toUSFluidOunces (gal.create value)
            let gallons = usfloz.toGallons usFluidOunces

            gallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to US cups and back`` () =
        let property value = 
            let usCups = gal.toUSCups (gal.create value)
            let gallons = uscup.toGallons usCups

            gallons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.15<gal>, 681.91378185)>]
    let ``Convert known gallon to millilitre`` (input, expectation) =
        gal.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.9<gal>, 4.0914826911)>]
    let ``Convert known gallon to litre`` (input, expectation) =
        gal.toLitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(15.<gal>, 0.0681913782)>]
    let ``Convert known gallon to kilolitre`` (input, expectation) =
        gal.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.7<gal>, 537.6)>]
    let ``Convert known gallon to teaspoons`` (input, expectation) =
        gal.toTeaspoons input 
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.87<gal>, 222.72)>]
    let ``Convert known gallon to tablespoons`` (input, expectation) =
        gal.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.67<gal>, 2.68)>]
    let ``Convert known gallon to quarts`` (input, expectation) =
        gal.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3.1<gal>, 24.8)>]
    let ``Convert known gallon to pints`` (input, expectation) =
        gal.toPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.123<gal>, 19.68)>]
    let ``Convert known gallon to fluid ounces`` (input, expectation) =
        gal.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.2<gal>, 184.4659848014)>]
    let ``Convert known gallon to US teaspoons`` (input, expectation) =
        gal.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.9<gal>, 276.6989772021)>]
    let ``Convert known gallon to US tablespoons`` (input, expectation) =
        gal.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.4<gal>, 59.5671409255)>]
    let ``Convert known gallon to US quarts`` (input, expectation) =
        gal.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5.123<gal>, 49.2197520905)>]
    let ``Convert known gallon to US pints`` (input, expectation) =
        gal.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(50.2<gal>, 60.2877111786)>]
    let ``Convert known gallon to US gallons`` (input, expectation) =
        gal.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(8.<gal>, 1229.7732320094)>]
    let ``Convert known gallon to US fluid ounces`` (input, expectation) =
        gal.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(7.5<gal>, 144.1140506261)>]
    let ``Convert known gallon to US cups`` (input, expectation) =
        gal.toUSCups input
        |> should (equalWithin 0.01) expectation
