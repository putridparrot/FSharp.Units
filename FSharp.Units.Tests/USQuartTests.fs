namespace FSharp.Units.Tests

module USQuartTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // US quart to X and back

    [<Property>]
    let ``From US quart to millilitre and back`` () =
        let property value = 
            let millilitres = usqt.toMillilitres (usqt.create value)
            let usQuarts = ml.toUSQuarts millilitres

            usQuarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to litre and back`` () =
        let property value = 
            let litres = usqt.toLitres (usqt.create value)
            let usQuarts = l.toUSQuarts litres

            usQuarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to kilolitre and back`` () =
        let property value = 
            let kilolitres = usqt.toKilolitres (usqt.create value)
            let usQuarts = kl.toUSQuarts kilolitres

            usQuarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to teaspoon and back`` () =
        let property value = 
            let teaspoons = usqt.toTeaspoons (usqt.create value)
            let usQuarts = tsp.toUSQuarts teaspoons

            usQuarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to tablespoon and back`` () =
        let property value = 
            let tablespoons = usqt.toTablespoons (usqt.create value)
            let usQuarts = tbsp.toUSQuarts tablespoons

            usQuarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to quarts and back`` () =
        let property value = 
            let quarts = usqt.toQuarts (usqt.create value)
            let usQuarts = qt.toUSQuarts quarts

            usQuarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to pints and back`` () =
        let property value = 
            let pints = usqt.toPints (usqt.create value)
            let usQuarts = pt.toUSQuarts pints

            usQuarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to gallons and back`` () =
        let property value = 
            let gallons = usqt.toGallons (usqt.create value)
            let usQuarts = gal.toUSQuarts gallons

            usQuarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = usqt.toFluidOunces (usqt.create value)
            let usQuarts = floz.toUSQuarts fluidOunces

            usQuarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to US teaspoons and back`` () =
        let property value = 
            let teaSpoons = usqt.toUSTeaspoons (usqt.create value)
            let usQuarts = ustsp.toUSQuarts teaSpoons

            usQuarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = usqt.toUSTablespoons (usqt.create value)
            let usQuarts = ustbsp.toUSQuarts usTablespoons

            usQuarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to US pints and back`` () =
        let property value = 
            let usPints = usqt.toUSPints (usqt.create value)
            let usQuarts = uspt.toUSQuarts usPints

            usQuarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to US gallons and back`` () =
        let property value = 
            let usGallons = usqt.toUSGallons (usqt.create value)
            let usQuarts = usgal.toUSQuarts usGallons

            usQuarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = usqt.toUSFluidOunces (usqt.create value)
            let usQuarts = usfloz.toUSQuarts usFluidOunces

            usQuarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US quart to US cups and back`` () =
        let property value = 
            let usCups = usqt.toUSCups (usqt.create value)
            let usQuarts = uscup.toUSQuarts usCups

            usQuarts
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known US quarts to millilitres`` () =
        let millilitres = usqt.toMillilitres 0.01<usqt>

        millilitres
        |> should (equalWithin 0.1) 9.46352946

    [<Test>]
    let ``Convert known US quarts to litres`` () =
        let litres = usqt.toLitres 23.<usqt>

        litres
        |> should (equalWithin 0.1) 21.766117758

    [<Test>]
    let ``Convert known US quarts to kilolitres`` () =
        let kilolitres = usqt.toKilolitres 304.<usqt>

        kilolitres
        |> should (equalWithin 0.1) 0.2876912956

    [<Test>]
    let ``Convert known US quarts to teaspoons`` () =
        let teaspoons = usqt.toTeaspoons 0.09<usqt>

        teaspoons
        |> should (equalWithin 0.1) 14.3886039633

    [<Test>]
    let ``Convert known US quarts to tablespoons`` () =
        let tablespoons = usqt.toTablespoons 0.6<usqt>

        tablespoons
        |> should (equalWithin 0.1) 31.9746754739

    [<Test>]
    let ``Convert known US quarts to quarts`` () =
        let quarts = usqt.toQuarts 12.<usqt>

        quarts
        |> should (equalWithin 0.1) 9.9920860856

    [<Test>]
    let ``Convert known US quarts to pints`` () =
        let pints = usqt.toPints 45.8<usqt>

        pints
        |> should (equalWithin 0.1) 76.2729237867

    [<Test>]
    let ``Convert known US quarts to gallons`` () =
        let gallons = usqt.toGallons 56.<usqt>

        gallons
        |> should (equalWithin 0.1) 11.6574337665

    [<Test>]
    let ``Convert known US quarts to fluid ounces`` () =
        let fluidOunces = usqt.toFluidOunces 56.<usqt>

        fluidOunces
        |> should (equalWithin 0.1) 1865.1894026447

    [<Test>]
    let ``Convert known US quarts to US teaspoons`` () =
        let usTeaspoons = usqt.toUSTeaspoons 0.5<usqt>

        usTeaspoons
        |> should (equalWithin 0.1) 96.

    [<Test>]
    let ``Convert known US quarts to US tablespoons`` () =
        let usTablespoons = usqt.toUSTablespoons 0.4<usqt>

        usTablespoons
        |> should (equalWithin 0.1) 25.6

    [<Test>]
    let ``Convert known US quarts to US pints`` () =
        let usPints = usqt.toUSPints 7.<usqt>

        usPints
        |> should (equalWithin 0.1) 14.

    [<Test>]
    let ``Convert known US quarts to US gallons`` () =
        let usGallons = usqt.toUSGallons 44.<usqt>

        usGallons
        |> should (equalWithin 0.1) 11.

    [<Test>]
    let ``Convert known US quarts to US fluid ounces`` () =
        let usFluidOunces = usqt.toUSFluidOunces 1.2<usqt>

        usFluidOunces
        |> should (equalWithin 0.1) 38.4

    [<Test>]
    let ``Convert known US quarts to US cups`` () =
        let usCups = usqt.toUSCups 123.<usqt>

        usCups
        |> should (equalWithin 0.1) 492.
