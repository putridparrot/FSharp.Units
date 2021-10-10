namespace FSharp.Units.Tests

module PoundTests =

    //http://www.checkyourmath.com/convert/weight_mass/oz_metric_ton.php
    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Mass
    open Helpers

    // ounce to X and back

    [<Property>]
    let ``From pound to milligram and back`` () =
        let property value = 
            let milligrams = lb.toMilligrams (lb.create value)
            let pounds = mg.toPounds milligrams

            pounds
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From pound to grams and back`` () =
        let property value = 
            let grams = lb.toGrams (lb.create value)
            let pounds = g.toPounds grams

            pounds
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From pound to kilogram and back`` () =
        let property value = 
            let kilogram = lb.toKilograms (lb.create value)
            let pounds = kg.toPounds kilogram

            pounds
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From pound to tonne and back`` () =
        let property value = 
            let tonnes = lb.toTonnes (lb.create value)
            let pounds = tonne.toPounds tonnes

            pounds
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From pound to ounce and back`` () =
        let property value = 
            let ounces = lb.toOunces (lb.create value)
            let pounds = oz.toPounds ounces

            pounds
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From pound to stones and back`` () =
        let property value = 
            let stones = lb.toStones (lb.create value)
            let pounds = stone.toPounds stones

            pounds
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1560.0<lb>, 707604097.2)>]
    let ``Convert known pound to milligram`` (input, expectation) =
        lb.toMilligrams input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1560.0<lb>, 707604.0972)>]
    let ``Convert known pound to gram`` (input, expectation) =
        lb.toGrams input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1560.0<lb>, 707.6040972)>]
    let ``Convert known pound to kilogram`` (input, expectation) =
        lb.toKilograms input
        |> should (equalWithin 0.01) expectation

    [<TestCase(256.0<lb>, 0.11611965)>]
    let ``Convert known pound to tonne`` (input, expectation) =
        lb.toTonnes input
        |> should (equalWithin 0.01) expectation

    [<TestCase(16.<lb>, 256.)>]
    let ``Convert known pound to ounce`` (input, expectation) =
        lb.toOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1234.0<lb>, 88.14285714)>]
    let ``Convert known pound to stone`` (input, expectation) =
        lb.toStones input
        |> should (equalWithin 0.01) expectation
