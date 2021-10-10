namespace FSharp.Units.Tests

module GramTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Mass
    open Helpers

    // gram to X and back

    [<Property>]
    let ``From gram to milligram and back`` () =
        let property value = 
            let milligrams = g.toMilligrams (g.create value)
            let grams = mg.toGrams milligrams

            grams 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From gram to kilogram and back`` () =
        let property value = 
            let kilograms = g.toKilograms (g.create value)
            let grams = kg.toGrams kilograms

            grams 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From gram to tonne and back`` () =
        let property value = 
            let tonnes = g.toTonnes (g.create value)
            let grams = tonne.toGrams tonnes

            grams 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From gram to ounce and back`` () =
        let property value = 
            let ounces = g.toOunces (g.create value)
            let grams = oz.toGrams ounces

            grams 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From gram to pound and back`` () =
        let property value = 
            let pounds = g.toPounds (g.create value)
            let grams = lb.toGrams pounds

            grams 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From gram to stones and back`` () =
        let property value = 
            let stones = g.toStones (g.create value)
            let grams = stone.toGrams stones

            grams 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)


    [<TestCase(167.0<g>, 0.167)>]
    let ``Convert known gram to kilogram`` (input, expectation) =
        g.toKilograms input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1560.0<g>, 0.00156)>]
    let ``Convert known gram to tonne`` (input, expectation) =
        g.toTonnes input
        |> should (equalWithin 0.01) expectation

    [<TestCase(256.0<g>, 9.03013)>]
    let ``Convert known gram to ounce`` (input, expectation) =
        g.toOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(256.0<g>, 0.564383)>]
    let ``Convert known gram to pound`` (input, expectation) =
        g.toPounds input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1234.0<g>, 0.1943217)>]
    let ``Convert known gram to stone`` (input, expectation) =
        g.toStones input
        |> should (equalWithin 0.01) expectation