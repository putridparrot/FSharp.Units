namespace FSharp.Units.Tests

module KilolitreTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // kilolitres to X and back

    [<Property>]
    let ``From kilolitre to millilitre and back`` () =
        let property value = 
            let millilitres = kl.toMillilitres (kl.create value)
            let kilolitres = ml.toKilolitres millilitres

            kilolitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to litre and back`` () =
        let property value = 
            let litres = kl.toLitres (kl.create value)
            let kilolitres = l.toKilolitres litres

            kilolitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to teaspoons and back`` () =
        let property value = 
            let teaspoons = kl.toTeaspoons (kl.create value)
            let kilolitres = tsp.toKilolitres teaspoons

            kilolitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to tablespoons and back`` () =
        let property value = 
            let tablespoons = kl.toLitres (kl.create value)
            let kilolitres = l.toKilolitres tablespoons

            kilolitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to quarts and back`` () =
        let property value = 
            let quarts = kl.toQuarts (kl.create value)
            let kilolitres = qt.toKilolitres quarts

            kilolitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to gallons and back`` () =
        let property value = 
            let gallons = kl.toGallons (kl.create value)
            let kilolitres = gal.toKilolitres gallons

            kilolitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = kl.toFluidOunces (kl.create value)
            let kilolitres = floz.toKilolitres fluidOunces

            kilolitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to US teaspoon and back`` () =
        let property value = 
            let usteaspoons = kl.toUSTeaspoons (kl.create value)
            let kilolitres = ustsp.toKilolitres usteaspoons

            kilolitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to US tablespoon and back`` () =
        let property value = 
            let ustablespoons = kl.toUSTablespoons (kl.create value)
            let kilolitres = ustbsp.toKilolitres ustablespoons

            kilolitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to US quarts and back`` () =
        let property value = 
            let usquarts = kl.toUSQuarts (kl.create value)
            let kilolitres = usqt.toKilolitres usquarts

            kilolitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to US pints and back`` () =
        let property value = 
            let uspints = kl.toUSPints (kl.create value)
            let kilolitres = uspt.toKilolitres uspints

            kilolitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to US gallons and back`` () =
        let property value = 
            let usgallons = kl.toUSGallons (kl.create value)
            let kilolitres = usgal.toKilolitres usgallons

            kilolitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to US fluid ounces and back`` () =
        let property value = 
            let usfluidounces = kl.toUSFluidOunces (kl.create value)
            let kilolitres = usfloz.toKilolitres usfluidounces

            kilolitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to US fluid cups and back`` () =
        let property value = 
            let uscups = kl.toUSCups (kl.create value)
            let kilolitres = uscup.toKilolitres uscups

            kilolitres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.063<kl>, 63000.0)>]
    let ``Convert known kilolitre to millilitre`` (input, expectation) =
        kl.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(123.9<kl>, 123900.0)>]
    let ``Convert known kilolitre to litre`` (input, expectation) =
        kl.toLitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.098<kl>, 16555.7586611197)>]
    let ``Convert known kilolitre to teaspoons`` (input, expectation) =
        kl.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.086<kl>, 4842.8409688989)>]
    let ``Convert known kilolitre to tablespoons`` (input, expectation) =
        kl.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.75<kl>, 659.9074721428)>]
    let ``Convert known kilolitre to quarts`` (input, expectation) =
        kl.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.56<kl>, 985.4618250666)>]
    let ``Convert known kilolitre to pints`` (input, expectation) =
        kl.toPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1456.<kl>, 320275.0931466601)>]
    let ``Convert known kilolitre to gallons`` (input, expectation) =
        kl.toGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.76<kl>, 26748.2495375233)>]
    let ``Convert known kilolitre to fluid ounces`` (input, expectation) =
        kl.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.00876<kl>, 1777.2650332089)>]
    let ``Convert known kilolitre to US teaspoons`` (input, expectation) =
        kl.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.007<kl>, 473.3963178258)>]
    let ``Convert known kilolitre to US tablespoons`` (input, expectation) =
        kl.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.098<kl>, 103.5554445244)>]
    let ``Convert known kilolitre to US quarts`` (input, expectation) =
        kl.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.03<kl>, 63.401292566)>]
    let ``Convert known kilolitre to US pints`` (input, expectation) =
        kl.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5.<kl>, 1320.8602617907)>]
    let ``Convert known kilolitre to US gallons`` (input, expectation) =
        kl.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.03<kl>, 1014.420679769)>]
    let ``Convert known kilolitre to US fluid ounces`` (input, expectation) =
        kl.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.02<kl>, 84.5350567546)>]
    let ``Convert known kilolitre to US cups`` (input, expectation) =
        kl.toUSCups input
        |> should (equalWithin 0.01) expectation
