namespace FSharp.Units.Tests

module OunceTests =

    //http://www.checkyourmath.com/convert/weight_mass/oz_metric_ton.php
    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Mass
    open Helpers

    // ounce to X and back

    [<Property>]
    let ``From ounce to milligram and back`` () =
        let property value = 
            let milligrams = oz.toMilligrams (oz.create value)
            let ounces = mg.toOunces milligrams

            ounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From ounce to grams and back`` () =
        let property value = 
            let grams = oz.toGrams (oz.create value)
            let ounces = g.toOunces grams

            ounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From ounce to kilogram and back`` () =
        let property value = 
            let kilogram = oz.toKilograms (oz.create value)
            let ounces = kg.toOunces kilogram

            ounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From ounce to tonne and back`` () =
        let property value = 
            let tonnes = oz.toTonnes (oz.create value)
            let ounces = tonne.toOunces tonnes

            ounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From ounce to pound and back`` () =
        let property value = 
            let pounds = oz.toPounds (oz.create value)
            let ounces = lb.toOunces pounds

            ounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From ounce to stones and back`` () =
        let property value = 
            let stones = oz.toStones (oz.create value)
            let ounces = stone.toOunces stones

            ounces
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1560.0<oz>, 44225256.036)>]
    let ``Convert known ounce to milligram`` (input, expectation) =
        oz.toMilligrams input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1560.0<oz>, 44225.26)>]
    let ``Convert known ounce to gram`` (input, expectation) =
        oz.toGrams input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1560.0<oz>, 44.22526)>]
    let ``Convert known ounce to kilogram`` (input, expectation) =
        oz.toKilograms input
        |> should (equalWithin 0.01) expectation

    [<TestCase(256.0<oz>, 0.00725748)>]
    let ``Convert known ounce to tonne`` (input, expectation) =
        oz.toTonnes input
        |> should (equalWithin 0.01) expectation

    [<TestCase(256.0<oz>, 16.)>]
    let ``Convert known ounce to pound`` (input, expectation) =
        oz.toPounds input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1234.0<oz>, 5.508929)>]
    let ``Convert known ounce to stone`` (input, expectation) =
        oz.toStones input
        |> should (equalWithin 0.01) expectation
