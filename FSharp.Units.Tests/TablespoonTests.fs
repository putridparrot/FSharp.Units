namespace FSharp.Units.Tests

module TablespoonTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // tablespoon to X and back

    [<Property>]
    let ``tablespoon to millilitres and back`` () =
        let property value = 
            let millilitres = tbsp.toMillilitres (tbsp.create value)
            let tablepoon = ml.toTablespoons millilitres

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to litres and back`` () =
        let property value = 
            let litres = tbsp.toLitres (tbsp.create value)
            let tablepoon = l.toTablespoons litres

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to kilolitres and back`` () =
        let property value = 
            let kilolitres = tbsp.toKilolitres (tbsp.create value)
            let tablepoon = kl.toTablespoons kilolitres

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to teaspoons and back`` () =
        let property value = 
            let teaspoons = tbsp.toTeaspoons (tbsp.create value)
            let tablepoon = tsp.toTablespoons teaspoons

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to quarts and back`` () =
        let property value = 
            let quarts = tbsp.toQuarts (tbsp.create value)
            let tablepoon = qt.toTablespoons quarts

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to pints and back`` () =
        let property value = 
            let pints = tbsp.toPints (tbsp.create value)
            let tablepoon = pt.toTablespoons pints

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to gallons and back`` () =
        let property value = 
            let gallons = tbsp.toGallons (tbsp.create value)
            let tablepoon = gal.toTablespoons gallons

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = tbsp.toFluidOunces (tbsp.create value)
            let tablepoon = floz.toTablespoons fluidOunces

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to US teaspoons and back`` () =
        let property value = 
            let usTeaspoons = tbsp.toUSTeaspoons (tbsp.create value)
            let tablepoon = ustsp.toTablespoons usTeaspoons

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = tbsp.toUSTablespoons (tbsp.create value)
            let tablepoon = ustbsp.toTablespoons usTablespoons

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to US quarts and back`` () =
        let property value = 
            let usQuarts = tbsp.toUSQuarts (tbsp.create value)
            let tablepoon = usqt.toTablespoons usQuarts

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to US pints and back`` () =
        let property value = 
            let usPints = tbsp.toUSPints (tbsp.create value)
            let tablepoon = uspt.toTablespoons usPints

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to US gallons and back`` () =
        let property value = 
            let usGallons = tbsp.toUSGallons (tbsp.create value)
            let tablepoon = usgal.toTablespoons usGallons

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = tbsp.toUSFluidOunces (tbsp.create value)
            let tablepoon = usfloz.toTablespoons usFluidOunces

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``tablespoon to US cups and back`` () =
        let property value = 
            let usCups = tbsp.toUSCups (tbsp.create value)
            let tablepoon = uscup.toTablespoons usCups

            tablepoon
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known tablepoon to millilitre`` () =
        let millilitre = tbsp.toMillilitres 2.5<tbsp>

        millilitre
        |> should (equalWithin 0.1) 44.3954285059

    [<Test>]
    let ``Convert known tablepoon to litre`` () =
        let litre = tbsp.toLitres 998.9<tbsp>

        litre
        |> should (equalWithin 0.1) 17.7386374138

    [<Test>]
    let ``Convert known tablepoon to kilolitre`` () =
        let kilolitre = tbsp.toKilolitres 180007.<tbsp>

        kilolitre
        |> should (equalWithin 0.1) 3.1965951596

    [<Test>]
    let ``Convert known tablepoon to teaspoons`` () =
        let teaspoons = tbsp.toTeaspoons 20.04<tbsp>

        teaspoons
        |> should (equalWithin 0.1) 60.12

    [<Test>]
    let ``Convert known tablepoon to quarts`` () =
        let quarts = tbsp.toQuarts 1690.<tbsp>

        quarts
        |> should (equalWithin 0.1) 26.40625

    [<Test>]
    let ``Convert known tablepoon to pints`` () =
        let pints = tbsp.toPints 109.98<tbsp>

        pints
        |> should (equalWithin 0.1) 3.436875

    [<Test>]
    let ``Convert known tablepoon to gallons`` () =
        let gallons = tbsp.toGallons 999.1<tbsp>

        gallons
        |> should (equalWithin 0.1) 3.902734375

    [<Test>]
    let ``Convert known tablepoon to fluid ounces`` () =
        let fluidOunces = tbsp.toFluidOunces 1098.<tbsp>

        fluidOunces
        |> should (equalWithin 0.1) 686.25

    [<Test>]
    let ``Convert known tablepoon to US teaspoons`` () =
        let usTeaspoons = tbsp.toUSTeaspoons 3.<tbsp>

        usTeaspoons
        |> should (equalWithin 0.1) 10.808553797

    [<Test>]
    let ``Convert known tablepoon to US tablespoons`` () =
        let usTablespoons = tbsp.toUSTablespoons 12.7<tbsp>

        usTablespoons
        |> should (equalWithin 0.1) 15.2520703579

    [<Test>]
    let ``Convert known tablepoon to US quarts`` () =
        let usQuarts = tbsp.toUSQuarts 777.34<tbsp>

        usQuarts
        |> should (equalWithin 0.1) 14.5866687648

    [<Test>]
    let ``Convert known tablepoon to US pints`` () =
        let usPints = tbsp.toUSPints 5930.123<tbsp>

        usPints
        |> should (equalWithin 0.1) 222.5557412086

    [<Test>]
    let ``Convert known tablepoon to US gallons`` () =
        let usGallons = tbsp.toUSGallons 8000.9<tbsp>

        usGallons
        |> should (equalWithin 0.1) 37.5339227752

    [<Test>]
    let ``Convert known tablepoon to US fluid ounces`` () =
        let usFluidOunces = tbsp.toUSFluidOunces 304.<tbsp>

        usFluidOunces
        |> should (equalWithin 0.1) 182.5444641264

    [<Test>]
    let ``Convert known tablepoon to US cups`` () =
        let usCups = tbsp.toUSCups 600.<tbsp>

        usCups
        |> should (equalWithin 0.1) 45.0356408207
