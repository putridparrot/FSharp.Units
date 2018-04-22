namespace FSharp.Units.Tests

module USPintTests =

    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit.Xunit
    open FSharp.Units.Volume
    open Helpers
       
    // US pint to X and back

    [<Property>]
    let ``From US pint to millilitre and back`` () =
        let property value = 
            let millilitres = uspt.toMillilitres (uspt.create value)
            let usPints = ml.toUSPints millilitres

            usPints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to litre and back`` () =
        let property value = 
            let litres = uspt.toLitres (uspt.create value)
            let usPints = l.toUSPints litres

            usPints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to kilolitre and back`` () =
        let property value = 
            let kilolitres = uspt.toKilolitres (uspt.create value)
            let usPints = kl.toUSPints kilolitres

            usPints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to teaspoon and back`` () =
        let property value = 
            let teaspoons = uspt.toTeaspoons (uspt.create value)
            let usPints = tsp.toUSPints teaspoons

            usPints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to tablespoon and back`` () =
        let property value = 
            let tablespoons = uspt.toTablespoons (uspt.create value)
            let usPints = tbsp.toUSPints tablespoons

            usPints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to quarts and back`` () =
        let property value = 
            let quarts = uspt.toQuarts (uspt.create value)
            let usPints = qt.toUSPints quarts

            usPints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to pints and back`` () =
        let property value = 
            let pints = uspt.toPints (uspt.create value)
            let usPints = pt.toUSPints pints

            usPints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to gallons and back`` () =
        let property value = 
            let gallons = uspt.toGallons (uspt.create value)
            let usPints = gal.toUSPints gallons

            usPints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = uspt.toFluidOunces (uspt.create value)
            let usPints = floz.toUSPints fluidOunces

            usPints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to US teaspoons and back`` () =
        let property value = 
            let teaSpoons = uspt.toUSTeaspoons (uspt.create value)
            let usPints = ustsp.toUSPints teaSpoons

            usPints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = uspt.toUSTablespoons (uspt.create value)
            let usPints = ustbsp.toUSPints usTablespoons

            usPints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to US quarts and back`` () =
        let property value = 
            let usQuarts = uspt.toUSQuarts (uspt.create value)
            let usPints = usqt.toUSPints usQuarts

            usPints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to US gallons and back`` () =
        let property value = 
            let usGallons = uspt.toUSGallons (uspt.create value)
            let usPints = usgal.toUSPints usGallons

            usPints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = uspt.toUSFluidOunces (uspt.create value)
            let usPints = usfloz.toUSPints usFluidOunces

            usPints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US pint to US cups and back`` () =
        let property value = 
            let usCups = uspt.toUSCups (uspt.create value)
            let usPints = uscup.toUSPints usCups

            usPints
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known US pints to millilitres`` () =
        let millilitres = uspt.toMillilitres 5.6<uspt>

        millilitres
        |> should (equalWithin 0.1) 2649.7882488

    [<Fact>]
    let ``Convert known US pints to litres`` () =
        let litres = uspt.toLitres 239.<uspt>

        litres
        |> should (equalWithin 0.1) 113.089177047

    [<Fact>]
    let ``Convert known US pints to kilolitres`` () =
        let kilolitres = uspt.toKilolitres 1020.<uspt>

        kilolitres
        |> should (equalWithin 0.1) 0.4826400025

    [<Fact>]
    let ``Convert known US pints to teaspoons`` () =
        let teaspoons = uspt.toTeaspoons 0.87<uspt>

        teaspoons
        |> should (equalWithin 0.1) 69.5449191558

    [<Fact>]
    let ``Convert known US pints to tablespoons`` () =
        let tablespoons = uspt.toTablespoons 4.<uspt>

        tablespoons
        |> should (equalWithin 0.1) 106.5822515797

    [<Fact>]
    let ``Convert known US pints to quarts`` () =
        let quarts = uspt.toQuarts 45.<uspt>

        quarts
        |> should (equalWithin 0.1) 18.7351614105

    [<Fact>]
    let ``Convert known US pints to pints`` () =
        let pints = uspt.toPints 23.<uspt>

        pints
        |> should (equalWithin 0.1) 19.1514983307

    [<Fact>]
    let ``Convert known US pints to gallons`` () =
        let gallons = uspt.toGallons 45.2<uspt>

        gallons
        |> should (equalWithin 0.1) 4.7046071986

    [<Fact>]
    let ``Convert known US pints to fluid ounces`` () =
        let fluidOunces = uspt.toFluidOunces 44.<uspt>

        fluidOunces
        |> should (equalWithin 0.1) 732.7529796104

    [<Fact>]
    let ``Convert known US pints to US teaspoons`` () =
        let usTeaspoons = uspt.toUSTeaspoons 0.04<uspt>

        usTeaspoons
        |> should (equalWithin 0.1) 3.84

    [<Fact>]
    let ``Convert known US pints to US tablespoons`` () =
        let usTablespoons = uspt.toUSTablespoons 0.45<uspt>

        usTablespoons
        |> should (equalWithin 0.1) 14.4

    [<Fact>]
    let ``Convert known US pints to US quarts`` () =
        let usQuarts = uspt.toUSQuarts 12.<uspt>

        usQuarts
        |> should (equalWithin 0.1) 6.

    [<Fact>]
    let ``Convert known US pints to US gallons`` () =
        let usGallons = uspt.toUSGallons 600.<uspt>

        usGallons
        |> should (equalWithin 0.1) 75.

    [<Fact>]
    let ``Convert known US pints to US fluid ounces`` () =
        let usFluidOunces = uspt.toUSFluidOunces 0.123<uspt>

        usFluidOunces
        |> should (equalWithin 0.1) 1.968

    [<Fact>]
    let ``Convert known US pints to US cups`` () =
        let usCups = uspt.toUSCups 546.<uspt>

        usCups
        |> should (equalWithin 0.1) 1092.
