namespace FSharp.Units.Tests

module USGallonTests =

    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit.Xunit
    open FSharp.Units.Volume
    open Helpers
       
    // US gallon to X and back

    [<Property>]
    let ``From US Gallons to millilitre and back`` () =
        let property value = 
            let millilitres = usgal.toMillilitres (usgal.create value)
            let usGallons = ml.toUSGallons millilitres

            usGallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to litre and back`` () =
        let property value = 
            let litres = usgal.toLitres (usgal.create value)
            let usGallons = l.toUSGallons litres

            usGallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to kilolitre and back`` () =
        let property value = 
            let kilolitres = usgal.toKilolitres (usgal.create value)
            let usGallons = kl.toUSGallons kilolitres

            usGallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to teaspoon and back`` () =
        let property value = 
            let teaspoons = usgal.toTeaspoons (usgal.create value)
            let usGallons = tsp.toUSGallons teaspoons

            usGallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to tablespoon and back`` () =
        let property value = 
            let tablespoons = usgal.toTablespoons (usgal.create value)
            let usGallons = tbsp.toUSGallons tablespoons

            usGallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to quarts and back`` () =
        let property value = 
            let quarts = usgal.toQuarts (usgal.create value)
            let usGallons = qt.toUSGallons quarts

            usGallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to pints and back`` () =
        let property value = 
            let pints = usgal.toPints (usgal.create value)
            let usGallons = pt.toUSGallons pints

            usGallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to gallons and back`` () =
        let property value = 
            let gallons = usgal.toGallons (usgal.create value)
            let usGallons = gal.toUSGallons gallons

            usGallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = usgal.toFluidOunces (usgal.create value)
            let usGallons = floz.toUSGallons fluidOunces

            usGallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to US teaspoons and back`` () =
        let property value = 
            let teaSpoons = usgal.toUSTeaspoons (usgal.create value)
            let usGallons = ustsp.toUSGallons teaSpoons

            usGallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = usgal.toUSTablespoons (usgal.create value)
            let usGallons = ustbsp.toUSGallons usTablespoons

            usGallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to US quarts and back`` () =
        let property value = 
            let usQuarts = usgal.toUSQuarts (usgal.create value)
            let usGallons = usqt.toUSGallons usQuarts

            usGallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to US pints and back`` () =
        let property value = 
            let usPints = usgal.toUSPints (usgal.create value)
            let usGallons = uspt.toUSGallons usPints

            usGallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to US fluid ounces and back`` () =
        let property value = 
            let usFluidOUnces = usgal.toUSFluidOunces (usgal.create value)
            let usGallons = usfloz.toUSGallons usFluidOUnces

            usGallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Gallons to US cups and back`` () =
        let property value = 
            let usCups = usgal.toUSCups (usgal.create value)
            let usGallons = uscup.toUSGallons usCups

            usGallons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known US gallons to millilitres`` () =
        let millilitres = usgal.toMillilitres 0.01<usgal>

        millilitres
        |> should (equalWithin 0.1) 37.85411784

    [<Fact>]
    let ``Convert known US gallons to litres`` () =
        let litres = usgal.toLitres 2.5<usgal>

        litres
        |> should (equalWithin 0.1) 9.46352946

    [<Fact>]
    let ``Convert known US gallons to kilolitres`` () =
        let kilolitres = usgal.toKilolitres 34.<usgal>

        kilolitres
        |> should (equalWithin 0.1) 0.1287040007

    [<Fact>]
    let ``Convert known US gallons to teaspoons`` () =
        let teaspoons = usgal.toTeaspoons 0.003<usgal>

        teaspoons
        |> should (equalWithin 0.1) 1.9184805284

    [<Fact>]
    let ``Convert known US gallons to tablespoons`` () =
        let tablespoons = usgal.toTablespoons 0.009<usgal>

        tablespoons
        |> should (equalWithin 0.1) 1.9184805284

    [<Fact>]
    let ``Convert known US gallons to quarts`` () =
        let quarts = usgal.toQuarts 0.8<usgal>

        quarts
        |> should (equalWithin 0.1) 2.6645562895

    [<Fact>]
    let ``Convert known US gallons to pints`` () =
        let pints = usgal.toPints 5.1<usgal>

        pints
        |> should (equalWithin 0.1) 33.973092691

    [<Fact>]
    let ``Convert known US gallons to gallons`` () =
        let gallons = usgal.toGallons 506.<usgal>

        gallons
        |> should (equalWithin 0.1) 421.332963276

    [<Fact>]
    let ``Convert known US gallons to fluid ounces`` () =
        let fluidOunces = usgal.toFluidOunces 0.98<usgal>

        fluidOunces
        |> should (equalWithin 0.1) 130.5632581851

    [<Fact>]
    let ``Convert known US gallons to US teaspoons`` () =
        let usTeaspoons = usgal.toUSTeaspoons 0.34<usgal>

        usTeaspoons
        |> should (equalWithin 0.1) 261.12

    [<Fact>]
    let ``Convert known US gallons to US tablespoons`` () =
        let ustablespoons = usgal.toUSTablespoons 0.9<usgal>

        ustablespoons
        |> should (equalWithin 0.1) 230.4

    [<Fact>]
    let ``Convert known US gallons to US quarts`` () =
        let usQuarts = usgal.toUSQuarts 12.3<usgal>

        usQuarts
        |> should (equalWithin 0.1) 49.2

    [<Fact>]
    let ``Convert known US gallons to US pints`` () =
        let usPints = usgal.toUSPints 0.09<usgal>

        usPints
        |> should (equalWithin 0.1) 0.72

    [<Fact>]
    let ``Convert known US gallons to US fluid ounces`` () =
        let usFluidOunces = usgal.toUSFluidOunces 0.9<usgal>

        usFluidOunces
        |> should (equalWithin 0.1) 115.2

    [<Fact>]
    let ``Convert known US gallons to US cups`` () =
        let usCups = usgal.toUSCups 56.<usgal>

        usCups
        |> should (equalWithin 0.1) 896.
