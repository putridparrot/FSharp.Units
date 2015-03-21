namespace FSharp.Units.Tests

module USTeaspoonTests =

    open System
    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit
    open FsUnit.Xunit
    open FSharp.Units
    open FSharp.Units.Volume
    open Helpers
       
    // US teaspoon to X and back    

    [<Property>]
    let ``From US teaspoon to millilitre and back`` () =
        let property value = 
            let millilitres = ustsp.toMillilitres (ustsp.create value)
            let usTeaspoons = ml.toUSTeaspoons millilitres

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to litre and back`` () =
        let property value = 
            let litres = ustsp.toLitres (ustsp.create value)
            let usTeaspoons = l.toUSTeaspoons litres

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to kilolitre and back`` () =
        let property value = 
            let kilolitres = ustsp.toKilolitres (ustsp.create value)
            let usTeaspoons = kl.toUSTeaspoons kilolitres

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to teaspoon and back`` () =
        let property value = 
            let teaspoons = ustsp.toTeaspoons (ustsp.create value)
            let usTeaspoons = tsp.toUSTeaspoons teaspoons

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to tablespoon and back`` () =
        let property value = 
            let tablespoons = ustsp.toTablespoons (ustsp.create value)
            let usTeaspoons = tbsp.toUSTeaspoons tablespoons

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to quarts and back`` () =
        let property value = 
            let quarts = ustsp.toQuarts (ustsp.create value)
            let usTeaspoons = qt.toUSTeaspoons quarts

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to pints and back`` () =
        let property value = 
            let pints = ustsp.toPints (ustsp.create value)
            let usTeaspoons = pt.toUSTeaspoons pints

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to gallons and back`` () =
        let property value = 
            let gallons = ustsp.toGallons (ustsp.create value)
            let usTeaspoons = gal.toUSTeaspoons gallons

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = ustsp.toFluidOunces (ustsp.create value)
            let usTeaspoons = floz.toUSTeaspoons fluidOunces

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to US tablespoons and back`` () =
        let property value = 
            let tableSpoons = ustsp.toUSTablespoons (ustsp.create value)
            let usTeaspoons = ustbsp.toUSTeaspoons tableSpoons

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to US quarts and back`` () =
        let property value = 
            let usQuarts = ustsp.toUSQuarts (ustsp.create value)
            let usTeaspoons = usqt.toUSTeaspoons usQuarts

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to US pints and back`` () =
        let property value = 
            let usPints = ustsp.toUSPints (ustsp.create value)
            let usTeaspoons = uspt.toUSTeaspoons usPints

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to US gallons and back`` () =
        let property value = 
            let usGallons = ustsp.toUSGallons (ustsp.create value)
            let usTeaspoons = usgal.toUSTeaspoons usGallons

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = ustsp.toUSFluidOunces (ustsp.create value)
            let usTeaspoons = usfloz.toUSTeaspoons usFluidOunces

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US teaspoon to US cups and back`` () =
        let property value = 
            let usCups = ustsp.toUSCups (ustsp.create value)
            let usTeaspoons = uscup.toUSTeaspoons usCups

            usTeaspoons
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known US teaspoons to millilitres`` () =
        let millilitres = ustsp.toMillilitres 6.9<ustsp>

        millilitres
        |> should (equalWithin 0.1) 34.0095589969

    [<Fact>]
    let ``Convert known US teaspoons to litres`` () =
        let litres = ustsp.toLitres 56090.<ustsp>

        litres
        |> should (equalWithin 0.1) 276.4632121934

    [<Fact>]
    let ``Convert known US teaspoons to kilolitres`` () =
        let kilolitres = ustsp.toKilolitres 9600.<ustsp>

        kilolitres
        |> should (equalWithin 0.1) 0.0473176473

    [<Fact>]
    let ``Convert known US teaspoons to teaspoons`` () =
        let teaspoons = ustsp.toTeaspoons 5.<ustsp>

        teaspoons
        |> should (equalWithin 0.1) 4.1633692023

    [<Fact>]
    let ``Convert known US teaspoons to tablespoons`` () =
        let tablespoons = ustsp.toTablespoons 80.<ustsp>

        tablespoons
        |> should (equalWithin 0.1) 22.2046357458

    [<Fact>]
    let ``Convert known US teaspoons to quarts`` () =
        let quarts = ustsp.toQuarts 19000.<ustsp>

        quarts
        |> should (equalWithin 0.1) 82.4000154628

    [<Fact>]
    let ``Convert known US teaspoons to pints`` () =
        let pints = ustsp.toPints 1000.<ustsp>

        pints
        |> should (equalWithin 0.1) 8.6736858382

    [<Fact>]
    let ``Convert known US teaspoons to gallons`` () =
        let gallons = ustsp.toGallons 4555.<ustsp>

        gallons
        |> should (equalWithin 0.1) 4.9385798741

    [<Fact>]
    let ``Convert known US teaspoons to fluid ounces`` () =
        let fluidOunces = ustsp.toFluidOunces 400.<ustsp>

        fluidOunces
        |> should (equalWithin 0.1) 69.3894867055

    [<Fact>]
    let ``Convert known US teaspoons to US tablespoons`` () =
        let usTablespoons = ustsp.toUSTablespoons 700.<ustsp>

        usTablespoons
        |> should (equalWithin 0.1) 233.3333333333

    [<Fact>]
    let ``Convert known US teaspoons to US quarts`` () =
        let usQuarts = ustsp.toUSQuarts 46009.<ustsp>

        usQuarts
        |> should (equalWithin 0.1) 239.6302083333

    [<Fact>]
    let ``Convert known US teaspoons to US pints`` () =
        let usPints = ustsp.toUSPints 900.<ustsp>

        usPints
        |> should (equalWithin 0.1) 9.375

    [<Fact>]
    let ``Convert known US teaspoons to US gallons`` () =
        let usGallons = ustsp.toUSGallons 50000.<ustsp>

        usGallons
        |> should (equalWithin 0.1) 65.1041666667

    [<Fact>]
    let ``Convert known US teaspoons to US fluid ounces`` () =
        let usFluidOunces = ustsp.toUSFluidOunces 3099.<ustsp>

        usFluidOunces
        |> should (equalWithin 0.1) 516.5

    [<Fact>]
    let ``Convert known US teaspoons to US cups`` () =
        let usCups = ustsp.toUSCups 6000.<ustsp>

        usCups
        |> should (equalWithin 0.1) 125.
