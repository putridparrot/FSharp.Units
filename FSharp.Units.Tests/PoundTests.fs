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

    [<Test>]
    let ``Convert known pound to milligram`` () =
        let milligrams= lb.toMilligrams 1560.0<lb>

        milligrams
        |> should (equalWithin 0.01) 707604097.2

    [<Test>]
    let ``Convert known pound to gram`` () =
        let grams = lb.toGrams 1560.0<lb>

        grams
        |> should (equalWithin 0.01) 707604.0972

    [<Test>]
    let ``Convert known pound to kilogram`` () =
        let kilograms = lb.toKilograms 1560.0<lb>

        kilograms
        |> should (equalWithin 0.01) 707.6040972

    [<Test>]
    let ``Convert known pound to tonne`` () =
        let tonnes = lb.toTonnes 256.0<lb>

        tonnes
        |> should (equalWithin 0.01) 0.11611965

    [<Test>]
    let ``Convert known pound to ounce`` () =
        let ounces = lb.toOunces 16.<lb>

        ounces
        |> should (equalWithin 0.01) 256

    [<Test>]
    let ``Convert known pound to stone`` () =
        let stones = lb.toStones 1234.0<lb>

        stones
        |> should (equalWithin 0.01) 88.14285714
