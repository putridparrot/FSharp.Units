namespace FSharp.Units.Tests

module USTablespoonTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Volume
    open Helpers
       
    // US tablespoon to X and back
    
    [<Property>]
    let ``From US tablespoon to millilitre and back`` () =
        let property value = 
            let millilitres = ustbsp.toMillilitres (ustbsp.create value)
            let usTeaspoons = ml.toUSTablespoons millilitres

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to litre and back`` () =
        let property value = 
            let litres = ustbsp.toLitres (ustbsp.create value)
            let usTeaspoons = l.toUSTablespoons litres

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to kilolitre and back`` () =
        let property value = 
            let kilolitres = ustbsp.toKilolitres (ustbsp.create value)
            let usTeaspoons = kl.toUSTablespoons kilolitres

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to teaspoon and back`` () =
        let property value = 
            let teaspoons = ustbsp.toTeaspoons (ustbsp.create value)
            let usTeaspoons = tsp.toUSTablespoons teaspoons

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to tablespoon and back`` () =
        let property value = 
            let tablespoons = ustbsp.toTablespoons (ustbsp.create value)
            let usTeaspoons = tbsp.toUSTablespoons tablespoons

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to quarts and back`` () =
        let property value = 
            let quarts = ustbsp.toQuarts (ustbsp.create value)
            let usTeaspoons = qt.toUSTablespoons quarts

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to pints and back`` () =
        let property value = 
            let pints = ustbsp.toPints (ustbsp.create value)
            let usTeaspoons = pt.toUSTablespoons pints

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to gallons and back`` () =
        let property value = 
            let gallons = ustbsp.toGallons (ustbsp.create value)
            let usTeaspoons = gal.toUSTablespoons gallons

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to fluid ounces and back`` () =
        let property value = 
            let fluidOunces = ustbsp.toFluidOunces (ustbsp.create value)
            let usTeaspoons = floz.toUSTablespoons fluidOunces

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to US teaspoons and back`` () =
        let property value = 
            let teaSpoons = ustbsp.toUSTeaspoons (ustbsp.create value)
            let usTeaspoons = ustsp.toUSTablespoons teaSpoons

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to US quarts and back`` () =
        let property value = 
            let usQuarts = ustbsp.toUSQuarts (ustbsp.create value)
            let usTeaspoons = usqt.toUSTablespoons usQuarts

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to US pints and back`` () =
        let property value = 
            let usPints = ustbsp.toUSPints (ustbsp.create value)
            let usTeaspoons = uspt.toUSTablespoons usPints

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to US gallons and back`` () =
        let property value = 
            let usGallons = ustbsp.toUSGallons (ustbsp.create value)
            let usTeaspoons = usgal.toUSTablespoons usGallons

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to US fluid ounces and back`` () =
        let property value = 
            let usFluidOunces = ustbsp.toUSFluidOunces (ustbsp.create value)
            let usTeaspoons = usfloz.toUSTablespoons usFluidOunces

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From US tablespoon to US cups and back`` () =
        let property value = 
            let usCups = ustbsp.toUSCups (ustbsp.create value)
            let usTeaspoons = uscup.toUSTablespoons usCups

            usTeaspoons
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6000.<ustbsp>, 88720.59)>]
    [<TestCase(12.<ustbsp>, 177.441)>]
    [<TestCase(5.<ustbsp>, 73.9338239062)>]
    let ``Convert known US tablespoons to millilites`` (input, expectation) =
        ustbsp.toMillilitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(8.<ustbsp>, 0.118294)>]
    [<TestCase(987.<ustbsp>, 14.5945)>]
    [<TestCase(1020.<ustbsp>, 15.0825000769)>]
    let ``Convert known US tablespoons to litres`` (input, expectation) =
        ustbsp.toLitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(900.<ustbsp>, 0.0133081)>]
    [<TestCase(15000.<ustbsp>, 0.22180147)>]
    [<TestCase(7009.<ustbsp>, 0.1036404344)>]
    let ``Convert known US tablespoons to kilolitres`` (input, expectation) =
        ustbsp.toKilolitres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(100.<ustbsp>, 249.802)>]
    [<TestCase(0.1<ustbsp>, 0.249802)>]
    [<TestCase(23.<ustbsp>, 57.4544949922)>]
    let ``Convert known US tablespoons to teaspoons`` (input, expectation) =
        ustbsp.toTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(123.<ustbsp>, 102.419)>]
    [<TestCase(8.<ustbsp>, 6.66139)>]
    [<TestCase(101.<ustbsp>, 84.1000578871)>]
    let ``Convert known US tablespoons to tablespoons`` (input, expectation) =
        ustbsp.toTablespoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(800.<ustbsp>, 10.4084)>]
    [<TestCase(12.<ustbsp>, 0.156126)>]
    [<TestCase(3400.<ustbsp>, 44.2357977748)>]
    let ``Convert known US tablespoons to quarts`` (input, expectation) =
        ustbsp.toQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.<ustbsp>, 0.312253)>]
    [<TestCase(890.<ustbsp>, 23.1588)>]
    [<TestCase(3000.<ustbsp>, 78.0631725437)>]
    let ``Convert known US tablespoons to pints`` (input, expectation) =
        ustbsp.toPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(890.<ustbsp>, 2.89484)>]
    [<TestCase(9000.<ustbsp>, 29.2737)>]
    [<TestCase(1234.<ustbsp>, 4.0137481216)>]
    let ``Convert known US tablespoons to gallons`` (input, expectation) =
        ustbsp.toGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(100.<ustbsp>, 52.0421)>]
    [<TestCase(901.<ustbsp>, 468.9)>]
    [<TestCase(12.5<ustbsp>, 6.5052643786)>]
    let ``Convert known US tablespoons to fluid ounces`` (input, expectation) =
        ustbsp.toFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1.5<ustbsp>, 4.5)>]
    [<TestCase(800.<ustbsp>, 2400.)>]
    [<TestCase(4.<ustbsp>, 12.)>]
    let ``Convert known US tablespoons to US teaspoons`` (input, expectation) =
        ustbsp.toUSTeaspoons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(23.<ustbsp>, 0.359375)>]
    [<TestCase(901.<ustbsp>, 14.0781)>]
    [<TestCase(3444.<ustbsp>, 53.8125)>]
    let ``Convert known US tablespoons to US quarts`` (input, expectation) =
        ustbsp.toUSQuarts input
        |> should (equalWithin 0.01) expectation

    [<TestCase(900.<ustbsp>, 28.125)>]
    [<TestCase(8.<ustbsp>, 0.25)>]
    [<TestCase(555.<ustbsp>, 17.34375)>]
    let ``Convert known US tablespoons to US pints`` (input, expectation) =
        ustbsp.toUSPints input
        |> should (equalWithin 0.01) expectation

    [<TestCase(34.<ustbsp>, 0.132813)>]
    [<TestCase(190.<ustbsp>, 0.742188)>]
    [<TestCase(1500.<ustbsp>, 5.859375)>]
    let ``Convert known US tablespoons to US gallons`` (input, expectation) =
        ustbsp.toUSGallons input
        |> should (equalWithin 0.01) expectation

    [<TestCase(190.<ustbsp>, 95.)>]
    [<TestCase(8.67<ustbsp>, 4.335)>]
    [<TestCase(44.<ustbsp>, 22.)>]
    let ``Convert known US tablespoons to US fluid ounces`` (input, expectation) =
        ustbsp.toUSFluidOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(9.12<ustbsp>, 0.5618971)>]
    [<TestCase(87.2<ustbsp>, 5.45)>]
    [<TestCase(800.<ustbsp>, 50.)>]
    let ``Convert known US tablespoons to US cups`` (input, expectation) =
        ustbsp.toUSCups input
        |> should (equalWithin 0.01) expectation
