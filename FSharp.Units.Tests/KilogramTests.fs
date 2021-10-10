namespace FSharp.Units.Tests

module KilogramTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Mass
    open Helpers

    // kilogram to X and back

    [<Property>]
    let ``From kilogram to milligram and back`` () =
        let property value = 
            let milligrams = kg.toMilligrams (kg.create value)
            let kilograms = mg.toKilograms milligrams

            kilograms 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilogram to grams and back`` () =
        let property value = 
            let grams = kg.toGrams (kg.create value)
            let kilograms = g.toKilograms grams

            kilograms
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilogram to tonne and back`` () =
        let property value = 
            let tonnes = kg.toTonnes (kg.create value)
            let kilograms = tonne.toKilograms tonnes

            kilograms
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilogram to ounce and back`` () =
        let property value = 
            let ounces = kg.toOunces (kg.create value)
            let kilograms = oz.toKilograms ounces

            kilograms
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilogram to pound and back`` () =
        let property value = 
            let pounds = kg.toPounds (kg.create value)
            let kilograms = lb.toKilograms pounds

            kilograms
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilogram to stones and back`` () =
        let property value = 
            let stones = kg.toStones (kg.create value)
            let kilograms = stone.toKilograms stones

            kilograms
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1560.0<kg>, 1.56e+9)>]
    let ``Convert known kilogram to milligram`` (input, expectation) =
        kg.toMilligrams input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1560.0<kg>, 1560000)>]
    let ``Convert known kilogram to gram`` (input, expectation) =
        kg.toGrams input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1560.0<kg>, 1.56)>]
    let ``Convert known kilogram to tonne`` (input, expectation) =
        kg.toTonnes input
        |> should (equalWithin 0.01) expectation

    [<TestCase(256.0<kg>, 9030.144)>]
    let ``Convert known kilogram to ounce`` (input, expectation) =
        kg.toOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(256.0<kg>, 564.383)>]
    let ``Convert known kilogram to pound`` (input, expectation) =
        kg.toPounds input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1234.0<kg>, 194.3217)>]
    let ``Convert known kilogram to stone`` (input, expectation) =
        kg.toStones input
        |> should (equalWithin 0.01) expectation