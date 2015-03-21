namespace FSharp.Units.Tests

module KilolitreTests =

    open System
    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit
    open FsUnit.Xunit
    open FSharp.Units
    open FSharp.Units.Volume
    open Helpers
       
    // kilolitres to X and back

    [<Property>]
    let ``From kilolitre to millilitre and back`` () =
        let property value = 
            let millilitres = kl.toMillilitres (kl.create value)
            let kilolitres = ml.toKilolitres millilitres

            kilolitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to litre and back`` () =
        let property value = 
            let litres = kl.toLitres (kl.create value)
            let kilolitres = l.toKilolitres litres

            kilolitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to teaspoons and back`` () =
        let property value = 
            let teaspoons = kl.toTeaspoons (kl.create value)
            let kilolitres = tsp.toKilolitres teaspoons

            kilolitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to tablespoons and back`` () =
        let property value = 
            let tablespoons = kl.toLitres (kl.create value)
            let kilolitres = l.toKilolitres tablespoons

            kilolitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to quarts and back`` () =
        let property value = 
            let quarts = kl.toQuarts (kl.create value)
            let kilolitres = qt.toKilolitres quarts

            kilolitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to gallons and back`` () =
        let property value = 
            let gallons = kl.toGallons (kl.create value)
            let kilolitres = gal.toKilolitres gallons

            kilolitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = kl.toFluidOunces (kl.create value)
            let kilolitres = floz.toKilolitres fluidOunces

            kilolitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to US teaspoon and back`` () =
        let property value = 
            let usteaspoons = kl.toUSTeaspoons (kl.create value)
            let kilolitres = ustsp.toKilolitres usteaspoons

            kilolitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to US tablespoon and back`` () =
        let property value = 
            let ustablespoons = kl.toUSTablespoons (kl.create value)
            let kilolitres = ustbsp.toKilolitres ustablespoons

            kilolitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to US quarts and back`` () =
        let property value = 
            let usquarts = kl.toUSQuarts (kl.create value)
            let kilolitres = usqt.toKilolitres usquarts

            kilolitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to US pints and back`` () =
        let property value = 
            let uspints = kl.toUSPints (kl.create value)
            let kilolitres = uspt.toKilolitres uspints

            kilolitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to US gallons and back`` () =
        let property value = 
            let usgallons = kl.toUSGallons (kl.create value)
            let kilolitres = usgal.toKilolitres usgallons

            kilolitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to US fluid ounces and back`` () =
        let property value = 
            let usfluidounces = kl.toUSFluidOunces (kl.create value)
            let kilolitres = usfloz.toKilolitres usfluidounces

            kilolitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilolitre to US fluid cups and back`` () =
        let property value = 
            let uscups = kl.toUSCups (kl.create value)
            let kilolitres = uscup.toKilolitres uscups

            kilolitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known kilolitre to millilitre`` () =
        let millilitres = kl.toMillilitres 0.063<kl>

        millilitres
        |> should (equalWithin 0.1) 63000.0

    [<Fact>]
    let ``Convert known kilolitre to litre`` () =
        let litres = kl.toLitres 123.9<kl>

        litres
        |> should (equalWithin 0.1) 123900.0

    [<Fact>]
    let ``Convert known kilolitre to teaspoons`` () =
        let teaspoons = kl.toTeaspoons 0.098<kl>

        teaspoons
        |> should (equalWithin 0.1) 16555.7586611197

    [<Fact>]
    let ``Convert known kilolitre to tablespoons`` () =
        let tablespoons = kl.toTablespoons 0.086<kl>

        tablespoons
        |> should (equalWithin 0.1) 4842.8409688989

    [<Fact>]
    let ``Convert known kilolitre to quarts`` () =
        let quarts = kl.toQuarts 0.75<kl>

        quarts
        |> should (equalWithin 0.1) 659.9074721428

    [<Fact>]
    let ``Convert known kilolitre to pints`` () =
        let pints = kl.toPints 0.56<kl>

        pints
        |> should (equalWithin 0.1) 985.4618250666

    [<Fact>]
    let ``Convert known kilolitre to gallons`` () =
        let gallons = kl.toGallons 1456.<kl>

        gallons
        |> should (equalWithin 0.1) 320275.0931466601

    [<Fact>]
    let ``Convert known kilolitre to fluid ounces`` () =
        let fluidOunces = kl.toFluidOunces 0.76<kl>

        fluidOunces
        |> should (equalWithin 0.1) 26748.2495375233

    [<Fact>]
    let ``Convert known kilolitre to US teaspoons`` () =
        let usTeaspoons = kl.toUSTeaspoons 0.00876<kl>

        usTeaspoons
        |> should (equalWithin 0.1) 1777.2650332089

    [<Fact>]
    let ``Convert known kilolitre to US tablespoons`` () =
        let usTablespoons = kl.toUSTablespoons 0.007<kl>

        usTablespoons
        |> should (equalWithin 0.1) 473.3963178258

    [<Fact>]
    let ``Convert known kilolitre to US quarts`` () =
        let usQuarts = kl.toUSQuarts 0.098<kl>

        usQuarts
        |> should (equalWithin 0.1) 103.5554445244

    [<Fact>]
    let ``Convert known kilolitre to US pints`` () =
        let usPints = kl.toUSPints 0.03<kl>

        usPints
        |> should (equalWithin 0.1) 63.401292566

    [<Fact>]
    let ``Convert known kilolitre to US gallons`` () =
        let usGallons = kl.toUSGallons 5.<kl>

        usGallons
        |> should (equalWithin 0.1) 1320.8602617907

    [<Fact>]
    let ``Convert known kilolitre to US fluid ounces`` () =
        let usFluidOunces = kl.toUSFluidOunces 0.03<kl>

        usFluidOunces
        |> should (equalWithin 0.1) 1014.420679769

    [<Fact>]
    let ``Convert known kilolitre to US cups`` () =
        let usCups = kl.toUSCups 0.02<kl>

        usCups
        |> should (equalWithin 0.1) 84.5350567546
