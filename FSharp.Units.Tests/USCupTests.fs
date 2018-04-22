namespace FSharp.Units.Tests

module USCupTests =

    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit.Xunit
    open FSharp.Units.Volume
    open Helpers
       
    // US cup to X and back

    [<Property>]
    let ``From US Cups to millilitre and back`` () =
        let property value = 
            let millilitres = uscup.toMillilitres (uscup.create value)
            let usCups = ml.toUSCups millilitres

            usCups
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to litre and back`` () =
        let property value = 
            let litres = uscup.toLitres (uscup.create value)
            let usCups = l.toUSCups litres

            usCups
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to kilolitre and back`` () =
        let property value = 
            let kilolitres = uscup.toKilolitres (uscup.create value)
            let usCups = kl.toUSCups kilolitres

            usCups
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to teaspoon and back`` () =
        let property value = 
            let teaspoons = uscup.toTeaspoons (uscup.create value)
            let usCups = tsp.toUSCups teaspoons

            usCups
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to tablespoon and back`` () =
        let property value = 
            let tablespoons = uscup.toTablespoons (uscup.create value)
            let usCups = tbsp.toUSCups tablespoons

            usCups
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to quarts and back`` () =
        let property value = 
            let quarts = uscup.toQuarts (uscup.create value)
            let usCups = qt.toUSCups quarts

            usCups
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to pints and back`` () =
        let property value = 
            let pints = uscup.toPints (uscup.create value)
            let usCups = pt.toUSCups pints

            usCups
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to gallons and back`` () =
        let property value = 
            let gallons = uscup.toGallons (uscup.create value)
            let usCups = gal.toUSCups gallons

            usCups
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = uscup.toFluidOunces (uscup.create value)
            let usCups = floz.toUSCups fluidOunces

            usCups
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to US teaspoons and back`` () =
        let property value = 
            let teaSpoons = uscup.toUSTeaspoons (uscup.create value)
            let usCups = ustsp.toUSCups teaSpoons

            usCups
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = uscup.toUSTablespoons (uscup.create value)
            let usCups = ustbsp.toUSCups usTablespoons

            usCups
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to US quarts and back`` () =
        let property value = 
            let usQuarts = uscup.toUSQuarts (uscup.create value)
            let usCups = usqt.toUSCups usQuarts

            usCups
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to US pints and back`` () =
        let property value = 
            let usPints = uscup.toUSPints (uscup.create value)
            let usCups = uspt.toUSCups usPints

            usCups
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to US gallons and back`` () =
        let property value = 
            let usGallons = uscup.toUSGallons (uscup.create value)
            let usCups = usgal.toUSCups usGallons

            usCups
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US Cups to US fluid ounces and back`` () =
        let property value = 
            let usFluidOUnces = uscup.toUSFluidOunces (uscup.create value)
            let usCups = usfloz.toUSCups usFluidOUnces

            usCups
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known US cup to millilitres`` () =
        let millilitres = uscup.toMillilitres 1.2<uscup>

        millilitres
        |> should (equalWithin 0.1) 283.9058838

    [<Fact>]
    let ``Convert known US cup to litres`` () =
        let litres = uscup.toLitres 23.8<uscup>

        litres
        |> should (equalWithin 0.1) 5.6308000287

    [<Fact>]
    let ``Convert known US cup to kilolitres`` () =
        let kilolitres = uscup.toKilolitres 5079.<uscup>

        kilolitres
        |> should (equalWithin 0.1) 1.2016316532

    [<Fact>]
    let ``Convert known US cup to teaspoons`` () =
        let teaspoons = uscup.toTeaspoons 1.8<uscup>

        teaspoons
        |> should (equalWithin 0.1) 71.9430198163

    [<Fact>]
    let ``Convert known US cup to tablespoons`` () =
        let tablespoons = uscup.toTablespoons 0.5<uscup>

        tablespoons
        |> should (equalWithin 0.1) 6.6613907237

    [<Fact>]
    let ``Convert known US cup to quarts`` () =
        let quarts = uscup.toQuarts 43.2<uscup>

        quarts
        |> should (equalWithin 0.1) 8.992877477

    [<Fact>]
    let ``Convert known US cup to pints`` () =
        let pints = uscup.toPints 45.6<uscup>

        pints
        |> should (equalWithin 0.1) 18.9849635626

    [<Fact>]
    let ``Convert known US cup to gallons`` () =
        let gallons = uscup.toGallons 800.<uscup>

        gallons
        |> should (equalWithin 0.1) 41.6336920233

    [<Fact>]
    let ``Convert known US cup to fluid ounces`` () =
        let fluidOunces = uscup.toFluidOunces 1.3<uscup>

        fluidOunces
        |> should (equalWithin 0.1) 10.8247599261

    [<Fact>]
    let ``Convert known US cup to US teaspoons`` () =
        let usTeaspoons = uscup.toUSTeaspoons 102.<uscup>

        usTeaspoons
        |> should (equalWithin 0.1) 4896.

    [<Fact>]
    let ``Convert known US cup to US tablespoons`` () =
        let usTablespoons = uscup.toUSTablespoons 0.3<uscup>

        usTablespoons
        |> should (equalWithin 0.1) 4.8

    [<Fact>]
    let ``Convert known US cup to US quarts`` () =
        let usQuarts = uscup.toUSQuarts 13.9<uscup>

        usQuarts
        |> should (equalWithin 0.1) 3.475

    [<Fact>]
    let ``Convert known US cup to US pints`` () =
        let usPints = uscup.toUSPints 4.3<uscup>

        usPints
        |> should (equalWithin 0.1) 2.15

    [<Fact>]
    let ``Convert known US cup to US gallons`` () =
        let usGallons = uscup.toUSGallons 45.6<uscup>

        usGallons
        |> should (equalWithin 0.1) 2.85

    [<Fact>]
    let ``Convert known US cup to US fluid ounces`` () =
        let usFluidOunces = uscup.toUSFluidOunces 3.2<uscup>

        usFluidOunces
        |> should (equalWithin 0.1) 25.6
