namespace FSharp.Units.Tests

module TonneTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Mass
    open Helpers

    // tonne to X and back

    [<Property>]
    let ``From tonne to milligram and back`` () =
        let property value = 
            let milligrams = tonne.toMilligrams (tonne.create value)
            let tonnes = mg.toTonnes milligrams

            tonnes 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From tonne to grams and back`` () =
        let property value = 
            let grams = tonne.toGrams (tonne.create value)
            let tonnes = g.toTonnes grams

            tonnes
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From tonne to kilogram and back`` () =
        let property value = 
            let kilogram = tonne.toKilograms (tonne.create value)
            let tonnes = kg.toTonnes kilogram

            tonnes
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From tonne to ounce and back`` () =
        let property value = 
            let ounces = tonne.toOunces (tonne.create value)
            let tonnes = oz.toTonnes ounces

            tonnes
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From tonne to pound and back`` () =
        let property value = 
            let pounds = tonne.toPounds (tonne.create value)
            let tonnes = lb.toTonnes pounds

            tonnes
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From tonne to stones and back`` () =
        let property value = 
            let stones = tonne.toStones (tonne.create value)
            let tonnes = stone.toTonnes stones

            tonnes
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.09<tonne>, 9e+7)>]
    [<TestCase(0.0005<tonne>, 500000.)>]
    [<TestCase(1560.0<tonne>, 1.56e+12)>]
    let ``Convert known tonne to milligram`` (input, expectation) =
        tonne.toMilligrams input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.09<tonne>, 90000.)>]
    [<TestCase(0.0005<tonne>, 500.)>]
    [<TestCase(1560.0<tonne>, 1.56e+9)>]
    let ``Convert known tonne to gram`` (input, expectation) =
        tonne.toGrams input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.90<tonne>, 900.)>]
    [<TestCase(89.<tonne>, 89000.)>]
    [<TestCase(1560.0<tonne>, 1560000.)>]
    let ``Convert known tonne to kilogram`` (input, expectation) =
        tonne.toKilograms input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.09<tonne>, 3174.657)>]
    [<TestCase(0.0011<tonne>, 38.8013581)>]
    [<TestCase(256.0<tonne>, 9030134.2670558)>]
    let ``Convert known tonne to ounce`` (input, expectation) =
        tonne.toOunces input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.09<tonne>, 198.416)>]
    [<TestCase(34.0<tonne>, 74957.08)>]
    [<TestCase(256.0<tonne>, 564382.72)>]
    let ``Convert known tonne to pound`` (input, expectation) =
        tonne.toPounds input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.0<tonne>, 1889.68)>]
    [<TestCase(9.7<tonne>, 1527.49)>]
    [<TestCase(1234.0<tonne>, 194321.682)>]
    let ``Convert known tonne to stone`` (input, expectation) =
        tonne.toStones input
        |> should (equalWithin 0.01) expectation
