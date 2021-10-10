namespace FSharp.Units.Tests

module FluidOunceTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // fluid ounces to X and back

    [<Property>]
    let ``From fluid ounces to millilitre and back`` () =
        let property value = 
            let millilitres = floz.toMillilitres (floz.create value)
            let fluidounces = ml.toFluidOunces millilitres

            fluidounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to litre and back`` () =
        let property value = 
            let litres = floz.toLitres (floz.create value)
            let fluidounces = l.toFluidOunces litres

            fluidounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to kilolitre and back`` () =
        let property value = 
            let kilolitres = floz.toKilolitres(floz.create value)
            let fluidounces = kl.toFluidOunces kilolitres

            fluidounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to teaspoons and back`` () =
        let property value = 
            let teaspoons = floz.toTeaspoons (floz.create value)
            let fluidounces = tsp.toFluidOunces teaspoons

            fluidounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to tablespoons and back`` () =
        let property value = 
            let tablespoons = floz.toLitres (floz.create value)
            let fluidounces = l.toFluidOunces tablespoons

            fluidounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to quarts and back`` () =
        let property value = 
            let quarts = floz.toQuarts (floz.create value)
            let fluidounces = qt.toFluidOunces quarts

            fluidounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to pints and back`` () =
        let property value = 
            let pints = floz.toPints (floz.create value)
            let fluidounces = pt.toFluidOunces pints

            fluidounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to gallons and back`` () =
        let property value = 
            let gallons = floz.toGallons (floz.create value)
            let fluidounces = gal.toFluidOunces gallons

            fluidounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to US teaspoons and back`` () =
        let property value = 
            let usTeaspoons = floz.toUSTeaspoons (floz.create value)
            let fluidounces = ustsp.toFluidOunces usTeaspoons

            fluidounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = floz.toUSTablespoons (floz.create value)
            let fluidounces = ustbsp.toFluidOunces usTablespoons

            fluidounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to US quarts and back`` () =
        let property value = 
            let usQuarts = floz.toUSQuarts (floz.create value)
            let fluidounces = usqt.toFluidOunces usQuarts

            fluidounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to US pints and back`` () =
        let property value = 
            let usPints = floz.toUSPints (floz.create value)
            let fluidounces = uspt.toFluidOunces usPints

            fluidounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to US gallons and back`` () =
        let property value = 
            let usGallons = floz.toUSGallons (floz.create value)
            let fluidounces = usgal.toFluidOunces usGallons

            fluidounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = floz.toUSFluidOunces (floz.create value)
            let fluidounces = usfloz.toFluidOunces usFluidOunces

            fluidounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From fluid ounces to US cups and back`` () =
        let property value = 
            let usCups = floz.toUSCups (floz.create value)
            let fluidounces = uscup.toFluidOunces usCups

            fluidounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9.8<floz>, 278.4481275887)>]
    let ``Convert known fluid ounces to millilitres`` (input, expectation) =
        floz.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(4567.<floz>, 129.7625100712)>]
    let ``Convert known fluid ounces to litres`` (input, expectation) =
        floz.toLitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(130034.<floz>, 3.6946656962)>]
    let ``Convert known fluid ounces to kilolitres`` (input, expectation) =
        floz.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.123<floz>, 0.5904)>]
    let ``Convert known fluid ounces to teaspoons`` (input, expectation) =
        floz.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.78<floz>, 1.248)>]
    let ``Convert known fluid ounces to tablespoons`` (input, expectation) =
        floz.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(6.5<floz>, 0.16)>]
    let ``Convert known fluid ounces to quarts`` (input, expectation) =
        floz.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.<floz>, 0.6)>]
    let ``Convert known fluid ounces to pints`` (input, expectation) =
        floz.toPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1234.<floz>, 7.7125)>]
    let ``Convert known fluid ounces to gallons`` (input, expectation) =
        floz.toGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.6<floz>, 3.458737215)>]
    let ``Convert known fluid ounces to US teapoons`` (input, expectation) =
        floz.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(8.1<floz>, 15.5643174676)>]
    let ``Convert known fluid ounces to US tablepoons`` (input, expectation) =
        floz.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3.45<floz>, 0.1035819739)>]
    let ``Convert known fluid ounces to US quarts`` (input, expectation) =
        floz.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(6.5<floz>, 0.3903088871)>]
    let ``Convert known fluid ounces to US pints`` (input, expectation) =
        floz.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(123.<floz>, 0.9232306368)>]
    let ``Convert known fluid ounces to US gallons`` (input, expectation) =
        floz.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(8.12<floz>, 7.8013739406)>]
    let ``Convert known fluid ounces to US fluid ounces`` (input, expectation) =
        floz.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3.4<floz>, 0.4083231434)>]
    let ``Convert known fluid ounces to US cups`` (input, expectation) =
        floz.toUSCups input
        |> should (equalWithin 0.01) expectation
