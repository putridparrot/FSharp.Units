namespace FSharp.Units.Tests

module LitreTests =

    open System
    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit
    open FsUnit.Xunit
    open FSharp.Units
    open FSharp.Units.Volume
    open Helpers
       
    // litre to X and back

    [<Property>]
    let ``From litre to millilitre and back`` () =
        let property value = 
            let millilitres = l.toMillilitres (l.create value)
            let litres = ml.toLitres millilitres

            litres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to kilolitre and back`` () =
        let property value = 
            let kilometres = l.toKilolitres (l.create value)
            let litres = kl.toLitres kilometres

            litres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to teaspoons and back`` () =
        let property value = 
            let teaspoons = l.toTeaspoons (l.create value)
            let litres = tsp.toLitres teaspoons

            litres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to tablespoons and back`` () =
        let property value = 
            let tablespoons = l.toTablespoons (l.create value)
            let litres = tbsp.toLitres tablespoons

            litres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to quarts and back`` () =
        let property value = 
            let quarts = l.toQuarts (l.create value)
            let litres = qt.toLitres quarts

            litres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to pints and back`` () =
        let property value = 
            let pints = l.toPints (l.create value)
            let litres = pt.toLitres pints

            litres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to gallons and back`` () =
        let property value = 
            let gallons = l.toGallons (l.create value)
            let litres = gal.toLitres gallons

            litres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = l.toFluidOunces (l.create value)
            let litres = floz.toLitres fluidOunces

            litres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to US teaspoons and back`` () =
        let property value = 
            let teaspoons = l.toUSTeaspoons (l.create value)
            let litres = ustsp.toLitres teaspoons

            litres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to US tablespoons and back`` () =
        let property value = 
            let tablespoons = l.toUSTablespoons (l.create value)
            let litres = ustbsp.toLitres tablespoons

            litres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to US quarts and back`` () =
        let property value = 
            let quarts = l.toUSQuarts (l.create value)
            let litres = usqt.toLitres quarts

            litres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to US pints and back`` () =
        let property value = 
            let pints = l.toUSPints (l.create value)
            let litres = uspt.toLitres pints

            litres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to US gallons and back`` () =
        let property value = 
            let gallons = l.toUSGallons (l.create value)
            let litres = usgal.toLitres gallons

            litres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to US fluid ounces and back`` () =
        let property value = 
            let fluidOunces = l.toUSFluidOunces (l.create value)
            let litres = usfloz.toLitres fluidOunces

            litres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From litre to US cups and back`` () =
        let property value = 
            let cups = l.toUSCups (l.create value)
            let litres = uscup.toLitres cups

            litres
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)
    
    [<Fact>]
    let ``Convert known litre to millilitre`` () =
        let millilitre = l.toMillilitres 123.9<l>

        millilitre
        |> should (equalWithin 0.1) 123900.0

    [<Fact>]
    let ``Convert known litre to kilolitre`` () =
        let kilolitres = l.toKilolitres 1900000.<l>

        kilolitres
        |> should (equalWithin 0.1) 1900.

    [<Fact>]
    let ``Convert known litre to teaspoons`` () =
        let teaspoons = l.toTeaspoons 0.006<l>

        teaspoons
        |> should (equalWithin 0.1) 1.0136178772

    [<Fact>]
    let ``Convert known litre to tablespoons`` () =
        let tablespoons = l.toTablespoons 0.009<l>

        tablespoons
        |> should (equalWithin 0.1) 0.5068089386

    [<Fact>]
    let ``Convert known litre to quarts`` () =
        let quarts = l.toQuarts 0.34<l>

        quarts
        |> should (equalWithin 0.1) 0.299158054

    [<Fact>]
    let ``Convert known litre to pints`` () =
        let pints = l.toPints 0.8<l>

        pints
        |> should (equalWithin 0.1) 1.4078026072

    [<Fact>]
    let ``Convert known litre to gallons`` () =
        let gallons = l.toGallons 1234.<l>

        gallons
        |> should (equalWithin 0.1) 271.4419402081

    [<Fact>]
    let ``Convert known litre to fluid ounces`` () =
        let fluidOunces = l.toFluidOunces 12.45<l>

        fluidOunces
        |> should (equalWithin 0.1) 438.1785615028

    [<Fact>]
    let ``Convert known litre to US teaspoons`` () =
        let usTeaspoons = l.toUSTeaspoons 0.007<l>

        usTeaspoons
        |> should (equalWithin 0.1) 1.4201889535

    [<Fact>]
    let ``Convert known litre to US tablespoons`` () =
        let usTablespoons = l.toUSTablespoons 0.9<l>

        usTablespoons
        |> should (equalWithin 0.1) 60.8652408633

    [<Fact>]
    let ``Convert known litre to US quarts`` () =
        let usQuarts = l.toUSQuarts 80.7<l>

        usQuarts
        |> should (equalWithin 0.1) 85.2747385012

    [<Fact>]
    let ``Convert known litre to US pints`` () =
        let usPints = l.toUSPints 80.<l>

        usPints
        |> should (equalWithin 0.1) 169.0701135092

    [<Fact>]
    let ``Convert known litre to US gallons`` () =
        let usGallons = l.toUSGallons 123.5<l>

        usGallons
        |> should (equalWithin 0.1) 32.6252484662

    [<Fact>]
    let ``Convert known litre to US fluid ounces`` () =
        let usFluidOunces = l.toUSFluidOunces 12.1<l>

        usFluidOunces
        |> should (equalWithin 0.1) 409.1496746923

    [<Fact>]
    let ``Convert known litre to US cups`` () =
        let usCups = l.toUSCups 1.2<l>

        usCups
        |> should (equalWithin 0.1) 5.0721034053
