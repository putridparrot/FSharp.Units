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
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From milligram to kilogram and back`` () =
        let property value = 
            let kilograms = mg.toKilograms (mg.create value)
            let milligrams = kg.toMilligrams kilograms

            milligrams 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From milligram to tonne and back`` () =
        let property value = 
            let tonnes = mg.toTonnes (mg.create value)
            let milligrams = tonne.toMilligrams tonnes

            milligrams 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From milligram to ounce and back`` () =
        let property value = 
            let ounces = mg.toOunces (mg.create value)
            let milligrams = oz.toMilligrams ounces

            milligrams 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From milligram to pound and back`` () =
        let property value = 
            let lbs = mg.toPounds (mg.create value)
            let milligrams = lb.toMilligrams lbs

            milligrams 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From milligram to stone and back`` () =
        let property value = 
            let stones = mg.toStones (mg.create value)
            let milligrams = stone.toMilligrams stones

            milligrams 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known milligram to gram`` () =
        let grams = mg.toGrams 123.0<mg>

        grams
        |> should equal 0.123

    [<Test>]
    let ``Convert known milligram to kilogram`` () =
        let kilograms = mg.toKilograms 1024.0<mg>

        kilograms
        |> should equal 0.001024

    [<Test>]
    let ``Convert known milligram to tonne`` () =
        let tonnes = mg.toTonnes 1024.0<mg>

        tonnes
        |> should equal 1.024e-6

    [<Test>]
    let ``Convert known milligram to ounce`` () =
        let ounces = mg.toOunces 345.0<mg>

        ounces
        |> should (equalWithin 0.1) 0.0121695

    [<Test>]
    let ``Convert known milligram to pound`` () =
        let pounds = mg.toStones 87.0<mg>

        pounds
        |> should (equalWithin 0.1) 0.000191802

    [<Test>]
    let ``Convert known milligram to stone`` () =
        let stones = mg.toStones 678.0<mg>

        stones
        |> should (equalWithin 0.1) 0.000106767
