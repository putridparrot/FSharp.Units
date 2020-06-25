namespace FSharp.Units.Tests

module QuartTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // quart to X and back

    [<Property>]
    let ``quart to millilitres and back`` () =
        let property value = 
            let millilitres = qt.toMillilitres (qt.create value)
            let tablepoon = ml.toQuarts millilitres

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to litres and back`` () =
        let property value = 
            let litres = qt.toLitres (qt.create value)
            let quarts = l.toQuarts litres

            quarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to kilolitres and back`` () =
        let property value = 
            let kilolitres = qt.toKilolitres (qt.create value)
            let quarts = kl.toQuarts kilolitres

            quarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to teaspoons and back`` () =
        let property value = 
            let teaspoons = qt.toTeaspoons (qt.create value)
            let quarts = tsp.toQuarts teaspoons

            quarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to tablespoons and back`` () =
        let property value = 
            let tablespoons = qt.toTablespoons (qt.create value)
            let quarts = tbsp.toQuarts tablespoons

            quarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to pints and back`` () =
        let property value = 
            let pints = qt.toPints (qt.create value)
            let quarts = pt.toQuarts pints

            quarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to gallons and back`` () =
        let property value = 
            let gallons = qt.toGallons (qt.create value)
            let quarts = gal.toQuarts gallons

            quarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = qt.toFluidOunces (qt.create value)
            let quarts = floz.toQuarts fluidOunces

            quarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to US teaspoons and back`` () =
        let property value = 
            let usTeaspoons = qt.toUSTeaspoons (qt.create value)
            let quarts = ustsp.toQuarts usTeaspoons

            quarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = qt.toUSTablespoons (qt.create value)
            let quarts = ustbsp.toQuarts usTablespoons

            quarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to US quarts and back`` () =
        let property value = 
            let usQuarts = qt.toUSQuarts (qt.create value)
            let quarts = usqt.toQuarts usQuarts

            quarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to US pints and back`` () =
        let property value = 
            let usPints = qt.toUSPints (qt.create value)
            let quarts = uspt.toQuarts usPints

            quarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to US gallons and back`` () =
        let property value = 
            let usGallons = qt.toUSGallons (qt.create value)
            let quarts = usgal.toQuarts usGallons

            quarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = qt.toUSFluidOunces (qt.create value)
            let quarts = usfloz.toQuarts usFluidOunces

            quarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``quart to US cups and back`` () =
        let property value = 
            let usCups = qt.toUSCups (qt.create value)
            let quarts = uscup.toQuarts usCups

            quarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known quart to millilitres`` () =
        let millilitres = qt.toMillilitres 0.567<qt>

        millilitres
        |> should (equalWithin 0.1) 644.4085238483

    [<Test>]
    let ``Convert known quart to litres`` () =
        let litres = qt.toLitres 8.9<qt>

        litres
        |> should (equalWithin 0.1) 10.1150544308

    [<Test>]
    let ``Convert known quart to kilolitres`` () =
        let kilolitres = qt.toKilolitres 1200.<qt>

        kilolitres
        |> should (equalWithin 0.1) 1.3638275637

    [<Test>]
    let ``Convert known quart to teaspoons`` () =
        let teaspoons = qt.toTeaspoons 0.008<qt>

        teaspoons
        |> should (equalWithin 0.1) 1.536

    [<Test>]
    let ``Convert known quart to tablespoons`` () =
        let tablespoons = qt.toTablespoons 0.09<qt>

        tablespoons
        |> should (equalWithin 0.1) 5.76

    [<Test>]
    let ``Convert known quart to pints`` () =
        let pints = qt.toPints 16.98<qt>

        pints
        |> should (equalWithin 0.1) 33.96

    [<Test>]
    let ``Convert known quart to gallons`` () =
        let gallons = qt.toGallons 109.2<qt>

        gallons
        |> should (equalWithin 0.1) 27.3

    [<Test>]
    let ``Convert known quart to fluid ounces`` () =
        let fluidOunces = qt.toFluidOunces 3.12<qt>

        fluidOunces
        |> should (equalWithin 0.1) 124.8

    [<Test>]
    let ``Convert known quart to US teaspoons`` () =
        let usTeaspoons = qt.toUSTeaspoons 0.001<qt>

        usTeaspoons
        |> should (equalWithin 0.1) 0.230582481

    [<Test>]
    let ``Convert known quart to US tablespoons`` () =
        let usTablespoons = qt.toUSTablespoons 0.006<qt>

        usTablespoons
        |> should (equalWithin 0.1) 0.461164962

    [<Test>]
    let ``Convert known quart to US quarts`` () =
        let usQuarts = qt.toUSQuarts 87.<qt>

        usQuarts
        |> should (equalWithin 0.1) 104.4826867039

    [<Test>]
    let ``Convert known quart to US pints`` () =
        let usPints = qt.toUSPints 908.2<qt>

        usPints
        |> should (equalWithin 0.1) 2181.4063463104

    [<Test>]
    let ``Convert known quart to US gallons`` () =
        let usGallons = qt.toUSGallons 108.3<qt>

        usGallons
        |> should (equalWithin 0.1) 32.5157326725

    [<Test>]
    let ``Convert known quart to US fluid ounces`` () =
        let usFluidOunces = qt.toUSFluidOunces 34.<qt>

        usFluidOunces
        |> should (equalWithin 0.1) 1306.6340590099

    [<Test>]
    let ``Convert known quart to US cups`` () =
        let usCups = qt.toUSCups 12.8<qt>

        usCups
        |> should (equalWithin 0.1) 61.4886616005
