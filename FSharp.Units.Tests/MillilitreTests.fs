namespace FSharp.Units.Tests

module MillilitreTests =

    open System
    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit
    open FsUnit.Xunit
    open FSharp.Units
    open FSharp.Units.Volume
    open Helpers
       
    // millilitre to X and back

    [<Property>]
    let ``From millilitre to litre and back`` () =
        let property value = 
            let litres = ml.toLitres (ml.create value)
            let millilitres = l.toMillilitres litres

            millilitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to kilolitre and back`` () =
        let property value = 
            let kilolitres = ml.toKilolitres (ml.create value)
            let millilitres = kl.toMillilitres kilolitres

            millilitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to teaspoon and back`` () =
        let property value = 
            let teaspoons = ml.toTeaspoons (ml.create value)
            let millilitres = tsp.toMillilitres teaspoons

            millilitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to tablespoon and back`` () =
        let property value = 
            let tablespoons = ml.toTablespoons (ml.create value)
            let millilitres = tbsp.toMillilitres tablespoons

            millilitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to quart and back`` () =
        let property value = 
            let quarts = ml.toQuarts (ml.create value)
            let millilitres = qt.toMillilitres quarts

            millilitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to pint and back`` () =
        let property value = 
            let pints = ml.toPints (ml.create value)
            let millilitres = pt.toMillilitres pints

            millilitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to gallon and back`` () =
        let property value = 
            let gallons = ml.toGallons (ml.create value)
            let millilitres = gal.toMillilitres gallons

            millilitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = ml.toFluidOunces (ml.create value)
            let millilitres = floz.toMillilitres fluidOunces

            millilitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to US teaspoon and back`` () =
        let property value = 
            let usTeaspoons = ml.toUSTeaspoons (ml.create value)
            let millilitres = ustsp.toMillilitres usTeaspoons

            millilitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to US tablespoon and back`` () =
        let property value = 
            let usTablespoons = ml.toUSTablespoons (ml.create value)
            let millilitres = ustbsp.toMillilitres usTablespoons

            millilitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to US quarts and back`` () =
        let property value = 
            let usQuarts = ml.toUSQuarts (ml.create value)
            let millilitres = usqt.toMillilitres usQuarts

            millilitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to US pints and back`` () =
        let property value = 
            let usPints = ml.toUSPints (ml.create value)
            let millilitres = uspt.toMillilitres usPints

            millilitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to US gallons and back`` () =
        let property value = 
            let usGallons = ml.toUSGallons (ml.create value)
            let millilitres = usgal.toMillilitres usGallons

            millilitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = ml.toUSFluidOunces (ml.create value)
            let millilitres = usfloz.toMillilitres usFluidOunces

            millilitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millilitre to US cups and back`` () =
        let property value = 
            let usCups = ml.toUSCups (ml.create value)
            let millilitres = uscup.toMillilitres usCups

            millilitres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known millilitre to litre`` () =
        let litre = ml.toLitres 2567.0<ml>

        litre
        |> should (equalWithin 0.1) 2.567

    [<Fact>]
    let ``Convert known millilitre to kilolitre`` () =
        let kilolitre = ml.toKilolitres 145.0<ml>

        kilolitre
        |> should (equalWithin 0.1) 0.000145

    [<Fact>]
    let ``Convert known millilitre to teaspoon`` () =
        let teaspoons = ml.toTeaspoons 1230.0<ml>

        teaspoons
        |> should (equalWithin 0.1) 207.7916648283

    [<Fact>]
    let ``Convert known millilitre to tablespoon`` () =
        let tablespoons = ml.toTablespoons 4000.0<ml>

        tablespoons
        |> should (equalWithin 0.1) 225.2484171581

    [<Fact>]
    let ``Convert known millilitre to quarts`` () =
        let quarts = ml.toQuarts 3900.<ml>

        quarts
        |> should (equalWithin 0.1) 3.4315188551

    [<Fact>]
    let ``Convert known millilitre to pints`` () =
        let pints = ml.toPints 19099.<ml>

        pints
        |> should (equalWithin 0.1) 33.6095274945

    [<Fact>]
    let ``Convert known millilitre to gallons`` () =
        let gallons = ml.toGallons 129000.<ml>

        gallons
        |> should (equalWithin 0.1) 28.3760213021

    [<Fact>]
    let ``Convert known millilitre to fluid ounces`` () =
        let fluidOunces = ml.toFluidOunces 2900.<ml>

        fluidOunces
        |> should (equalWithin 0.1) 102.0656890248

    [<Fact>]
    let ``Convert known millilitre to US teaspoons`` () =
        let usTeaspoons = ml.toUSTeaspoons 1234.<ml>

        usTeaspoons
        |> should (equalWithin 0.1) 250.3590240844

    [<Fact>]
    let ``Convert known millilitre to US tablespoons`` () =
        let usTablespoons = ml.toUSTablespoons 5009.<ml>

        usTablespoons
        |> should (equalWithin 0.1) 338.7488794271

    [<Fact>]
    let ``Convert known millilitre to US quarts`` () =
        let usQuarts = ml.toUSQuarts 8888.<ml>

        usQuarts
        |> should (equalWithin 0.1) 9.3918448054

    [<Fact>]
    let ``Convert known millilitre to US pints`` () =
        let usPints = ml.toUSPints 48903.<ml>

        usPints
        |> should (equalWithin 0.1) 103.3504470118

    [<Fact>]
    let ``Convert known millilitre to US gallons`` () =
        let usGallons = ml.toUSGallons 50600.<ml>

        usGallons
        |> should (equalWithin 0.1) 13.3671058493

    [<Fact>]
    let ``Convert known millilitre to US fluid ounces`` () =
        let usFluidOunces = ml.toUSFluidOunces 5900.<ml>

        usFluidOunces
        |> should (equalWithin 0.1) 199.5027339409

    [<Fact>]
    let ``Convert known millilitre to US cups`` () =
        let usCups = ml.toUSCups 9000.0<ml>

        usCups
        |> should (equalWithin 0.1) 38.0407755396
