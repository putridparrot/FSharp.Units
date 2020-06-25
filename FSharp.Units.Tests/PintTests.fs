namespace FSharp.Units.Tests

module PintTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // pint to X and back

    [<Property>]
    let ``pint to millilitres and back`` () =
        let property value = 
            let millilitres = pt.toMillilitres (pt.create value)
            let pints = ml.toPints millilitres

            pints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to litres and back`` () =
        let property value = 
            let litres = pt.toLitres (pt.create value)
            let pints = l.toPints litres

            pints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to kilolitres and back`` () =
        let property value = 
            let kilolitres = pt.toKilolitres (pt.create value)
            let pints = kl.toPints kilolitres

            pints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to teaspoons and back`` () =
        let property value = 
            let teaspoons = pt.toTeaspoons (pt.create value)
            let pints = tsp.toPints teaspoons

            pints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to tablespoons and back`` () =
        let property value = 
            let tablespoons = pt.toTablespoons (pt.create value)
            let pints = tbsp.toPints tablespoons

            pints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to quarts and back`` () =
        let property value = 
            let quarts = pt.toQuarts (pt.create value)
            let pints = qt.toPints quarts

            pints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to gallons and back`` () =
        let property value = 
            let gallons = pt.toGallons (pt.create value)
            let pints = gal.toPints gallons

            pints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = pt.toFluidOunces (pt.create value)
            let pints = floz.toPints fluidOunces

            pints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to US teaspoons and back`` () =
        let property value = 
            let usTeaspoons = pt.toUSTeaspoons (pt.create value)
            let pints = ustsp.toPints usTeaspoons

            pints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = pt.toUSTablespoons (pt.create value)
            let pints = ustbsp.toPints usTablespoons

            pints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to US quarts and back`` () =
        let property value = 
            let usQuarts = pt.toUSQuarts (pt.create value)
            let pints = usqt.toPints usQuarts

            pints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to US pints and back`` () =
        let property value = 
            let usPints = pt.toUSPints (pt.create value)
            let pints = uspt.toPints usPints

            pints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to US gallons and back`` () =
        let property value = 
            let usGallons = pt.toUSGallons (pt.create value)
            let pints = usgal.toPints usGallons

            pints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = pt.toUSFluidOunces (pt.create value)
            let pints = usfloz.toPints usFluidOunces

            pints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to US cups and back`` () =
        let property value = 
            let usCups = pt.toUSCups (pt.create value)
            let pints = uscup.toPints usCups

            pints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known pint to millilitres`` () =
        let millilitres = pt.toMillilitres 5.2<pt>

        millilitres
        |> should (equalWithin 0.1) 2954.95972135

    [<Test>]
    let ``Convert known pint to litres`` () =
        let litres = pt.toLitres 900.<pt>

        litres
        |> should (equalWithin 0.1) 511.4353363875

    [<Test>]
    let ``Convert known pint to kilolitres`` () =
        let kilolitres = pt.toKilolitres 20000.<pt>

        kilolitres
        |> should (equalWithin 0.1) 11.3652296975

    [<Test>]
    let ``Convert known pint to teaspoons`` () =
        let teaspoons = pt.toTeaspoons 3.2<pt>

        teaspoons
        |> should (equalWithin 0.1) 307.2

    [<Test>]
    let ``Convert known pint to tablespoons`` () =
        let tablespoons = pt.toTablespoons 1.2<pt>

        tablespoons
        |> should (equalWithin 0.1) 38.4

    [<Test>]
    let ``Convert known pint to quarts`` () =
        let quarts = pt.toQuarts 12.4<pt>

        quarts
        |> should (equalWithin 0.1) 6.2

    [<Test>]
    let ``Convert known pint to gallons`` () =
        let gallons = pt.toGallons 980.<pt>

        gallons
        |> should (equalWithin 0.1) 122.5

    [<Test>]
    let ``Convert known pint to fluid ounces`` () =
        let fluidOunces = pt.toFluidOunces 234.<pt>

        fluidOunces
        |> should (equalWithin 0.1) 4680.

    [<Test>]
    let ``Convert known pint to US teaspoons`` () =
        let usTeaspoons = pt.toUSTeaspoons 0.87<pt>

        usTeaspoons
        |> should (equalWithin 0.1) 100.3033792358

    [<Test>]
    let ``Convert known pint to US tablespoons`` () =
        let usTablespoons = pt.toUSTablespoons 4.3<pt>

        usTablespoons
        |> should (equalWithin 0.1) 165.2507780513

    [<Test>]
    let ``Convert known pint to US quarts`` () =
        let usQuarts = pt.toUSQuarts 19.3<pt>

        usQuarts
        |> should (equalWithin 0.1) 11.5891715712

    [<Test>]
    let ``Convert known pint to US pints`` () =
        let usPints = pt.toUSPints 9.5<pt>

        usPints
        |> should (equalWithin 0.1) 11.4090290079

    [<Test>]
    let ``Convert known pint to US gallons`` () =
        let usGallons = pt.toUSGallons 102.<pt>

        usGallons
        |> should (equalWithin 0.1) 15.312117879

    [<Test>]
    let ``Convert known pint to US fluid ounces`` () =
        let usFluidOunces = pt.toUSFluidOunces 89.4<pt>

        usFluidOunces
        |> should (equalWithin 0.1) 1717.8394834631

    [<Test>]
    let ``Convert known pint to US cups`` () =
        let usCups = pt.toUSCups 40.9<pt>

        usCups
        |> should (equalWithin 0.1) 98.2377445101
