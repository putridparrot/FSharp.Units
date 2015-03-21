namespace FSharp.Units.Tests

module GallonTests =

    open System
    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit
    open FsUnit.Xunit
    open FSharp.Units
    open FSharp.Units.Volume
    open Helpers
       
    // gallon to X and back

    [<Property>]
    let ``gallon to millilitres and back`` () =
        let property value = 
            let millilitres = gal.toMillilitres (gal.create value)
            let gallons = ml.toGallons millilitres

            gallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to litres and back`` () =
        let property value = 
            let litres = gal.toLitres (gal.create value)
            let gallons = l.toGallons litres

            gallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to kilolitres and back`` () =
        let property value = 
            let kilolitres = gal.toKilolitres (gal.create value)
            let gallons = kl.toGallons kilolitres

            gallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to teaspoons and back`` () =
        let property value = 
            let teaspoons = gal.toTeaspoons (gal.create value)
            let gallons = tsp.toGallons teaspoons

            gallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to tablespoons and back`` () =
        let property value = 
            let tablespoons = gal.toTablespoons (gal.create value)
            let gallons = tbsp.toGallons tablespoons

            gallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to quarts and back`` () =
        let property value = 
            let quarts = gal.toQuarts (gal.create value)
            let gallons = qt.toGallons quarts

            gallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to pints and back`` () =
        let property value = 
            let pints = gal.toPints (gal.create value)
            let gallons = pt.toGallons pints

            gallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = gal.toFluidOunces (gal.create value)
            let gallons = floz.toGallons fluidOunces

            gallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to US teaspoons and back`` () =
        let property value = 
            let usTeaspoons = gal.toUSTeaspoons (gal.create value)
            let gallons = ustsp.toGallons usTeaspoons

            gallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = gal.toUSTablespoons (gal.create value)
            let gallons = ustbsp.toGallons usTablespoons

            gallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to US quarts and back`` () =
        let property value = 
            let usQuarts = gal.toUSQuarts (gal.create value)
            let gallons = usqt.toGallons usQuarts

            gallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to US pints and back`` () =
        let property value = 
            let usPints = gal.toUSPints (gal.create value)
            let gallons = uspt.toGallons usPints

            gallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to US gallons and back`` () =
        let property value = 
            let usGallons = gal.toUSGallons (gal.create value)
            let gallons = usgal.toGallons usGallons

            gallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = gal.toUSFluidOunces (gal.create value)
            let gallons = usfloz.toGallons usFluidOunces

            gallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``gallon to US cups and back`` () =
        let property value = 
            let usCups = gal.toUSCups (gal.create value)
            let gallons = uscup.toGallons usCups

            gallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known gallon to millilitre`` () =
        let millilitres = gal.toMillilitres 0.15<gal>

        millilitres
        |> should (equalWithin 0.1) 681.91378185

    [<Fact>]
    let ``Convert known gallon to litre`` () =
        let litres = gal.toLitres 0.9<gal>

        litres
        |> should (equalWithin 0.1) 4.0914826911

    [<Fact>]
    let ``Convert known gallon to kilolitre`` () =
        let kilolitres = gal.toKilolitres 15.<gal>

        kilolitres
        |> should (equalWithin 0.1) 0.0681913782

    [<Fact>]
    let ``Convert known gallon to teaspoons`` () =
        let teaspoons = gal.toTeaspoons 0.7<gal>

        teaspoons
        |> should (equalWithin 0.1) 537.6

    [<Fact>]
    let ``Convert known gallon to tablespoons`` () =
        let tablespoons = gal.toTablespoons 0.87<gal>

        tablespoons
        |> should (equalWithin 0.1) 222.72

    [<Fact>]
    let ``Convert known gallon to quarts`` () =
        let quarts = gal.toQuarts 0.67<gal>

        quarts
        |> should (equalWithin 0.1) 2.68

    [<Fact>]
    let ``Convert known gallon to pints`` () =
        let pints = gal.toPints 3.1<gal>

        pints
        |> should (equalWithin 0.1) 24.8

    [<Fact>]
    let ``Convert known gallon to fluid ounces`` () =
        let fluidOunces = gal.toFluidOunces 0.123<gal>

        fluidOunces
        |> should (equalWithin 0.1) 19.68

    [<Fact>]
    let ``Convert known gallon to US teaspoons`` () =
        let usTeaspoons = gal.toUSTeaspoons 0.2<gal>

        usTeaspoons
        |> should (equalWithin 0.1) 184.4659848014

    [<Fact>]
    let ``Convert known gallon to US tablespoons`` () =
        let usTablespoons = gal.toUSTablespoons 0.9<gal>

        usTablespoons
        |> should (equalWithin 0.1) 276.6989772021

    [<Fact>]
    let ``Convert known gallon to US quarts`` () =
        let usQuarts = gal.toUSQuarts 12.4<gal>

        usQuarts
        |> should (equalWithin 0.1) 59.5671409255

    [<Fact>]
    let ``Convert known gallon to US pints`` () =
        let usPints = gal.toUSPints 5.123<gal>

        usPints
        |> should (equalWithin 0.1) 49.2197520905

    [<Fact>]
    let ``Convert known gallon to US gallons`` () =
        let usGallons = gal.toUSGallons 50.2<gal>

        usGallons
        |> should (equalWithin 0.1) 60.2877111786

    [<Fact>]
    let ``Convert known gallon to US fluid ounces`` () =
        let usFluidOunces = gal.toUSFluidOunces 8.<gal>

        usFluidOunces
        |> should (equalWithin 0.1) 1229.7732320094

    [<Fact>]
    let ``Convert known gallon to US cups`` () =
        let usCups = gal.toUSCups 7.5<gal>

        usCups
        |> should (equalWithin 0.1) 144.1140506261
