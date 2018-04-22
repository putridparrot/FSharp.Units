namespace FSharp.Units.Tests

module FluidOunceTests =

    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit.Xunit
    open FSharp.Units.Volume
    open Helpers
       
    // fluid ounces to X and back

    [<Property>]
    let ``From fluid ounces to millilitre and back`` () =
        let property value = 
            let millilitres = floz.toMillilitres (floz.create value)
            let fluidounces = ml.toFluidOunces millilitres

            fluidounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to litre and back`` () =
        let property value = 
            let litres = floz.toLitres (floz.create value)
            let fluidounces = l.toFluidOunces litres

            fluidounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to kilolitre and back`` () =
        let property value = 
            let kilolitres = floz.toKilolitres(floz.create value)
            let fluidounces = kl.toFluidOunces kilolitres

            fluidounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to teaspoons and back`` () =
        let property value = 
            let teaspoons = floz.toTeaspoons (floz.create value)
            let fluidounces = tsp.toFluidOunces teaspoons

            fluidounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to tablespoons and back`` () =
        let property value = 
            let tablespoons = floz.toLitres (floz.create value)
            let fluidounces = l.toFluidOunces tablespoons

            fluidounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to quarts and back`` () =
        let property value = 
            let quarts = floz.toQuarts (floz.create value)
            let fluidounces = qt.toFluidOunces quarts

            fluidounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to pints and back`` () =
        let property value = 
            let pints = floz.toPints (floz.create value)
            let fluidounces = pt.toFluidOunces pints

            fluidounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to gallons and back`` () =
        let property value = 
            let gallons = floz.toGallons (floz.create value)
            let fluidounces = gal.toFluidOunces gallons

            fluidounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to US teaspoons and back`` () =
        let property value = 
            let usTeaspoons = floz.toUSTeaspoons (floz.create value)
            let fluidounces = ustsp.toFluidOunces usTeaspoons

            fluidounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = floz.toUSTablespoons (floz.create value)
            let fluidounces = ustbsp.toFluidOunces usTablespoons

            fluidounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to US quarts and back`` () =
        let property value = 
            let usQuarts = floz.toUSQuarts (floz.create value)
            let fluidounces = usqt.toFluidOunces usQuarts

            fluidounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to US pints and back`` () =
        let property value = 
            let usPints = floz.toUSPints (floz.create value)
            let fluidounces = uspt.toFluidOunces usPints

            fluidounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to US gallons and back`` () =
        let property value = 
            let usGallons = floz.toUSGallons (floz.create value)
            let fluidounces = usgal.toFluidOunces usGallons

            fluidounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = floz.toUSFluidOunces (floz.create value)
            let fluidounces = usfloz.toFluidOunces usFluidOunces

            fluidounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to US cups and back`` () =
        let property value = 
            let usCups = floz.toUSCups (floz.create value)
            let fluidounces = uscup.toFluidOunces usCups

            fluidounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known fluid ounces to millilitres`` () =
        let millilitres = floz.toMillilitres 9.8<floz>

        millilitres
        |> should (equalWithin 0.1) 278.4481275887

    [<Fact>]
    let ``Convert known fluid ounces to litres`` () =
        let litres = floz.toLitres 4567.<floz>

        litres
        |> should (equalWithin 0.1) 129.7625100712

    [<Fact>]
    let ``Convert known fluid ounces to kilolitres`` () =
        let kilolitres = floz.toKilolitres 130034.<floz>

        kilolitres
        |> should (equalWithin 0.1) 3.6946656962

    [<Fact>]
    let ``Convert known fluid ounces to teaspoons`` () =
        let teaspoons = floz.toTeaspoons 0.123<floz>

        teaspoons
        |> should (equalWithin 0.1) 0.5904

    [<Fact>]
    let ``Convert known fluid ounces to tablespoons`` () =
        let tablespoons = floz.toTablespoons 0.78<floz>

        tablespoons
        |> should (equalWithin 0.1) 1.248

    [<Fact>]
    let ``Convert known fluid ounces to quarts`` () =
        let quarts = floz.toQuarts 6.5<floz>

        quarts
        |> should (equalWithin 0.1) 0.16

    [<Fact>]
    let ``Convert known fluid ounces to pints`` () =
        let pints = floz.toPints 12.<floz>

        pints
        |> should (equalWithin 0.1) 0.6

    [<Fact>]
    let ``Convert known fluid ounces to gallons`` () =
        let gallons = floz.toGallons 1234.<floz>

        gallons
        |> should (equalWithin 0.1) 7.7125

    [<Fact>]
    let ``Convert known fluid ounces to US teapoons`` () =
        let usTeaspoons = floz.toUSTeaspoons 0.6<floz>

        usTeaspoons
        |> should (equalWithin 0.1) 3.458737215

    [<Fact>]
    let ``Convert known fluid ounces to US tablepoons`` () =
        let usTablespoons = floz.toUSTablespoons 8.1<floz>

        usTablespoons
        |> should (equalWithin 0.1) 15.5643174676

    [<Fact>]
    let ``Convert known fluid ounces to US quarts`` () =
        let usQuarts = floz.toUSQuarts 3.45<floz>

        usQuarts
        |> should (equalWithin 0.1) 0.1035819739

    [<Fact>]
    let ``Convert known fluid ounces to US pints`` () =
        let usPints = floz.toUSPints 6.5<floz>

        usPints
        |> should (equalWithin 0.1) 0.3903088871

    [<Fact>]
    let ``Convert known fluid ounces to US gallons`` () =
        let usGallons = floz.toUSGallons 123.<floz>

        usGallons
        |> should (equalWithin 0.1) 0.9232306368

    [<Fact>]
    let ``Convert known fluid ounces to US fluid ounces`` () =
        let usFluidOunces = floz.toUSFluidOunces 8.12<floz>

        usFluidOunces
        |> should (equalWithin 0.1) 7.8013739406

    [<Fact>]
    let ``Convert known fluid ounces to US cups`` () =
        let usCups = floz.toUSCups 3.4<floz>

        usCups
        |> should (equalWithin 0.1) 0.4083231434
