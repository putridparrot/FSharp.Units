namespace FSharp.Units.Tests

module StoneTests =

    //http://www.checkyourmath.com/convert/weight_mass/oz_metric_ton.php
    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Mass
    open Helpers

    // ounce to X and back

    [<Property>]
    let ``From stone to milligram and back`` () =
        let property value = 
            let milligrams = stone.toMilligrams (stone.create value)
            let stones = mg.toStones milligrams

            stones
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From stone to grams and back`` () =
        let property value = 
            let grams = stone.toGrams (stone.create value)
            let stones = g.toStones grams

            stones
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From stone to kilogram and back`` () =
        let property value = 
            let kilogram = stone.toKilograms (stone.create value)
            let stones = kg.toStones kilogram

            stones
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From stone to tonne and back`` () =
        let property value = 
            let tonnes = stone.toTonnes (stone.create value)
            let stones = tonne.toStones tonnes

            stones
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From stone to ounce and back`` () =
        let property value = 
            let ounces = stone.toOunces (stone.create value)
            let stones = oz.toStones ounces

            stones
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From stone to pounds and back`` () =
        let property value = 
            let pounds = stone.toPounds (stone.create value)
            let stones = lb.toStones pounds

            stones
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1560.0<stone>, 9906457360.8)>]
    let ``Convert known stone to milligram`` (input, expectation) =
        stone.toMilligrams input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1560.0<stone>, 9906457.3608)>]
    let ``Convert known stone to gram`` (input, expectation) =
        stone.toGrams input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1560.0<stone>, 9906.4573608)>]
    let ``Convert known stone to kilogram`` (input, expectation) =
        stone.toKilograms input
        |> should (equalWithin 0.01) expectation

    [<TestCase(256.0<stone>, 1.62567505)>]
    let ``Convert known stone to tonne`` (input, expectation) =
        stone.toTonnes input
        |> should (equalWithin 0.01) expectation

    [<TestCase(256.0<stone>, 57344.)>]
    let ``Convert known stone to ounce`` (input, expectation) =
        stone.toOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1234.0<stone>, 17276.)>]
    let ``Convert known stone to pound`` (input, expectation) =
        stone.toPounds input
        |> should (equalWithin 0.01) expectation
