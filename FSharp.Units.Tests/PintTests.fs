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
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to litres and back`` () =
        let property value = 
            let litres = pt.toLitres (pt.create value)
            let pints = l.toPints litres

            pints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to kilolitres and back`` () =
        let property value = 
            let kilolitres = pt.toKilolitres (pt.create value)
            let pints = kl.toPints kilolitres

            pints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to teaspoons and back`` () =
        let property value = 
            let teaspoons = pt.toTeaspoons (pt.create value)
            let pints = tsp.toPints teaspoons

            pints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to tablespoons and back`` () =
        let property value = 
            let tablespoons = pt.toTablespoons (pt.create value)
            let pints = tbsp.toPints tablespoons

            pints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to quarts and back`` () =
        let property value = 
            let quarts = pt.toQuarts (pt.create value)
            let pints = qt.toPints quarts

            pints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to gallons and back`` () =
        let property value = 
            let gallons = pt.toGallons (pt.create value)
            let pints = gal.toPints gallons

            pints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = pt.toFluidOunces (pt.create value)
            let pints = floz.toPints fluidOunces

            pints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to US teaspoons and back`` () =
        let property value = 
            let usTeaspoons = pt.toUSTeaspoons (pt.create value)
            let pints = ustsp.toPints usTeaspoons

            pints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to US tablespoons and back`` () =
        let property value = 
            let usTablespoons = pt.toUSTablespoons (pt.create value)
            let pints = ustbsp.toPints usTablespoons

            pints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to US quarts and back`` () =
        let property value = 
            let usQuarts = pt.toUSQuarts (pt.create value)
            let pints = usqt.toPints usQuarts

            pints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to US pints and back`` () =
        let property value = 
            let usPints = pt.toUSPints (pt.create value)
            let pints = uspt.toPints usPints

            pints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to US gallons and back`` () =
        let property value = 
            let usGallons = pt.toUSGallons (pt.create value)
            let pints = usgal.toPints usGallons

            pints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = pt.toUSFluidOunces (pt.create value)
            let pints = usfloz.toPints usFluidOunces

            pints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``pint to US cups and back`` () =
        let property value = 
            let usCups = pt.toUSCups (pt.create value)
            let pints = uscup.toPints usCups

            pints
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.2<pt>, 2954.95972135)>]
    let ``Convert known pint to millilitres`` (input, expectation) =
        pt.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(900.<pt>, 511.4353363875)>]
    let ``Convert known pint to litres`` (input, expectation) =
        pt.toLitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(20000.<pt>, 11.3652296975)>]
    let ``Convert known pint to kilolitres`` (input, expectation) =
        pt.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3.2<pt>, 307.2)>]
    let ``Convert known pint to teaspoons`` (input, expectation) =
        pt.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1.2<pt>, 38.4)>]
    let ``Convert known pint to tablespoons`` (input, expectation) =
        pt.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.4<pt>, 6.2)>]
    let ``Convert known pint to quarts`` (input, expectation) =
        pt.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(980.<pt>, 122.5)>]
    let ``Convert known pint to gallons`` (input, expectation) =
        pt.toGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(234.<pt>, 4680.)>]
    let ``Convert known pint to fluid ounces`` (input, expectation) =
        pt.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.87<pt>, 100.3033792358)>]
    let ``Convert known pint to US teaspoons`` (input, expectation) =
        pt.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(4.3<pt>, 165.2507780513)>]
    let ``Convert known pint to US tablespoons`` (input, expectation) =
        pt.toUSTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(19.3<pt>, 11.5891715712)>]
    let ``Convert known pint to US quarts`` (input, expectation) =
        pt.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(9.5<pt>, 11.4090290079)>]
    let ``Convert known pint to US pints`` (input, expectation) =
        pt.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(102.<pt>, 15.312117879)>]
    let ``Convert known pint to US gallons`` (input, expectation) =
        pt.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(89.4<pt>, 1717.8394834631)>]
    let ``Convert known pint to US fluid ounces`` (input, expectation) =
        pt.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(40.9<pt>, 98.2377445101)>]
    let ``Convert known pint to US cups`` (input, expectation) =
        pt.toUSCups input
        |> should (equalWithin 0.01) expectation
