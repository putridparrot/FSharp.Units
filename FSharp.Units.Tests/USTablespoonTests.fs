namespace FSharp.Units.Tests

module USTablespoonTests =

    open System
    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit
    open FsUnit.Xunit
    open FSharp.Units
    open FSharp.Units.Volume
    open Helpers
       
    // US tablespoon to X and back
    
    [<Property>]
    let ``From US tablespoon to millilitre and back`` () =
        let property value = 
            let millilitres = ustbsp.toMillilitres (ustbsp.create value)
            let usTeaspoons = ml.toUSTablespoons millilitres

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to litre and back`` () =
        let property value = 
            let litres = ustbsp.toLitres (ustbsp.create value)
            let usTeaspoons = l.toUSTablespoons litres

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to kilolitre and back`` () =
        let property value = 
            let kilolitres = ustbsp.toKilolitres (ustbsp.create value)
            let usTeaspoons = kl.toUSTablespoons kilolitres

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to teaspoon and back`` () =
        let property value = 
            let teaspoons = ustbsp.toTeaspoons (ustbsp.create value)
            let usTeaspoons = tsp.toUSTablespoons teaspoons

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to tablespoon and back`` () =
        let property value = 
            let tablespoons = ustbsp.toTablespoons (ustbsp.create value)
            let usTeaspoons = tbsp.toUSTablespoons tablespoons

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to quarts and back`` () =
        let property value = 
            let quarts = ustbsp.toQuarts (ustbsp.create value)
            let usTeaspoons = qt.toUSTablespoons quarts

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to pints and back`` () =
        let property value = 
            let pints = ustbsp.toPints (ustbsp.create value)
            let usTeaspoons = pt.toUSTablespoons pints

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to gallons and back`` () =
        let property value = 
            let gallons = ustbsp.toGallons (ustbsp.create value)
            let usTeaspoons = gal.toUSTablespoons gallons

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = ustbsp.toFluidOunces (ustbsp.create value)
            let usTeaspoons = floz.toUSTablespoons fluidOunces

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to US teaspoons and back`` () =
        let property value = 
            let teaSpoons = ustbsp.toUSTeaspoons (ustbsp.create value)
            let usTeaspoons = ustsp.toUSTablespoons teaSpoons

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to US quarts and back`` () =
        let property value = 
            let usQuarts = ustbsp.toUSQuarts (ustbsp.create value)
            let usTeaspoons = usqt.toUSTablespoons usQuarts

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to US pints and back`` () =
        let property value = 
            let usPints = ustbsp.toUSPints (ustbsp.create value)
            let usTeaspoons = uspt.toUSTablespoons usPints

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to US gallons and back`` () =
        let property value = 
            let usGallons = ustbsp.toUSGallons (ustbsp.create value)
            let usTeaspoons = usgal.toUSTablespoons usGallons

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = ustbsp.toUSFluidOunces (ustbsp.create value)
            let usTeaspoons = usfloz.toUSTablespoons usFluidOunces

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to US cups and back`` () =
        let property value = 
            let usCups = ustbsp.toUSCups (ustbsp.create value)
            let usTeaspoons = uscup.toUSTablespoons usCups

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known US tablespoons to millilites`` () =
        let millilitres = ustbsp.toMillilitres 5.<ustbsp>

        millilitres
        |> should (equalWithin 0.1) 73.9338239062

    [<Fact>]
    let ``Convert known US tablespoons to lites`` () =
        let litres = ustbsp.toLitres 1020.<ustbsp>

        litres
        |> should (equalWithin 0.1) 15.0825000769

    [<Fact>]
    let ``Convert known US tablespoons to kilolites`` () =
        let kilolitres = ustbsp.toKilolitres 7009.<ustbsp>

        kilolitres
        |> should (equalWithin 0.1) 0.1036404344

    [<Fact>]
    let ``Convert known US tablespoons to teaspoons`` () =
        let teaspoons = ustbsp.toTeaspoons 23.<ustbsp>

        teaspoons
        |> should (equalWithin 0.1) 57.4544949922

    [<Fact>]
    let ``Convert known US tablespoons to tablespoons`` () =
        let tablespoons = ustbsp.toTablespoons 101.<ustbsp>

        tablespoons
        |> should (equalWithin 0.1) 84.1000578871

    [<Fact>]
    let ``Convert known US tablespoons to quarts`` () =
        let quarts = ustbsp.toQuarts 3400.<ustbsp>

        quarts
        |> should (equalWithin 0.1) 44.2357977748

    [<Fact>]
    let ``Convert known US tablespoons to pints`` () =
        let pints = ustbsp.toPints 3000.<ustbsp>

        pints
        |> should (equalWithin 0.1) 78.0631725437

    [<Fact>]
    let ``Convert known US tablespoons to gallons`` () =
        let gallons = ustbsp.toGallons 1234.<ustbsp>

        gallons
        |> should (equalWithin 0.1) 4.0137481216

    [<Fact>]
    let ``Convert known US tablespoons to fluid ounces`` () =
        let fluidOunces = ustbsp.toFluidOunces 12.5<ustbsp>

        fluidOunces
        |> should (equalWithin 0.1) 6.5052643786

    [<Fact>]
    let ``Convert known US tablespoons to US teaspoons`` () =
        let usTeaspoons = ustbsp.toUSTeaspoons 4.<ustbsp>

        usTeaspoons
        |> should (equalWithin 0.1) 12.

    [<Fact>]
    let ``Convert known US tablespoons to US quarts`` () =
        let usQuarts = ustbsp.toUSQuarts 3444.<ustbsp>

        usQuarts
        |> should (equalWithin 0.1) 53.8125

    [<Fact>]
    let ``Convert known US tablespoons to US pints`` () =
        let usPints = ustbsp.toUSPints 555.<ustbsp>

        usPints
        |> should (equalWithin 0.1) 17.34375

    [<Fact>]
    let ``Convert known US tablespoons to US gallons`` () =
        let usGallons = ustbsp.toUSGallons 1500.<ustbsp>

        usGallons
        |> should (equalWithin 0.1) 5.859375

    [<Fact>]
    let ``Convert known US tablespoons to US fluid ounces`` () =
        let usFluidOunces = ustbsp.toUSFluidOunces 44.<ustbsp>

        usFluidOunces
        |> should (equalWithin 0.1) 22.

    [<Fact>]
    let ``Convert known US tablespoons to US cups`` () =
        let usCups = ustbsp.toUSCups 800.<ustbsp>

        usCups
        |> should (equalWithin 0.1) 50.
