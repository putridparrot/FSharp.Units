namespace FSharp.Units.Tests

module MilligramTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Mass
    open Helpers
       
    // milligram to X and back

    [<Property>]
    let ``From milligram to gram and back`` () =
        let property value = 
            let grams = mg.toGrams (mg.create value)
            let milligrams = g.toMilligrams grams

            milligrams 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From milligram to kilogram and back`` () =
        let property value = 
            let kilograms = mg.toKilograms (mg.create value)
            let milligrams = kg.toMilligrams kilograms

            milligrams 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From milligram to tonne and back`` () =
        let property value = 
            let tonnes = mg.toTonnes (mg.create value)
            let milligrams = tonne.toMilligrams tonnes

            milligrams 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From milligram to ounce and back`` () =
        let property value = 
            let ounces = mg.toOunces (mg.create value)
            let milligrams = oz.toMilligrams ounces

            milligrams 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From milligram to pound and back`` () =
        let property value = 
            let lbs = mg.toPounds (mg.create value)
            let milligrams = lb.toMilligrams lbs

            milligrams 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From milligram to stone and back`` () =
        let property value = 
            let stones = mg.toStones (mg.create value)
            let milligrams = stone.toMilligrams stones

            milligrams 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.0<mg>, 0.123)>]
    let ``Convert known milligram to gram`` (input, expectation) =
        mg.toGrams input
        |> should equal expectation

    [<TestCase(1024.0<mg>, 0.001024)>]
    let ``Convert known milligram to kilogram`` (input, expectation) =
        mg.toKilograms input
        |> should equal expectation

    [<TestCase(1024.0<mg>, 1.024e-6)>]
    let ``Convert known milligram to tonne`` (input, expectation) =
        mg.toTonnes input
        |> should equal expectation

    [<TestCase(345.0<mg>, 0.0121695)>]
    let ``Convert known milligram to ounce`` (input, expectation) =
        mg.toOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(87.0<mg>, 0.000191802)>]
    let ``Convert known milligram to pound`` (input, expectation) =
        mg.toStones input
        |> should (equalWithin 0.01) expectation

    [<TestCase(678.0<mg>, 0.000106767)>]
    let ``Convert known milligram to stone`` (input, expectation) =
        mg.toStones input
        |> should (equalWithin 0.01) expectation
