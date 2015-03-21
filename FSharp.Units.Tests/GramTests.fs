namespace FSharp.Units.Tests

module GramTests =

    open System
    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit
    open FsUnit.Xunit
    open FSharp.Units
    open FSharp.Units.Mass
    open Helpers

    // gram to X and back

    [<Property>]
    let ``From gram to milligram and back`` () =
        let property value = 
            let milligrams = g.toMilligrams (g.create value)
            let grams = mg.toGrams milligrams

            grams 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From gram to kilogram and back`` () =
        let property value = 
            let kilograms = g.toKilograms (g.create value)
            let grams = kg.toGrams kilograms

            grams 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From gram to tonne and back`` () =
        let property value = 
            let tonnes = g.toTonnes (g.create value)
            let grams = tonne.toGrams tonnes

            grams 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From gram to ounce and back`` () =
        let property value = 
            let ounces = g.toOunces (g.create value)
            let grams = oz.toGrams ounces

            grams 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From gram to pound and back`` () =
        let property value = 
            let pounds = g.toPounds (g.create value)
            let grams = lb.toGrams pounds

            grams 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From gram to stones and back`` () =
        let property value = 
            let stones = g.toStones (g.create value)
            let grams = stone.toGrams stones

            grams 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)


    [<Fact>]
    let ``Convert known gram to kilogram`` () =
        let kilograms = g.toKilograms 167.0<g>

        kilograms
        |> should (equalWithin 0.1) 0.167

    [<Fact>]
    let ``Convert known gram to tonne`` () =
        let tonnes = g.toTonnes 1560.0<g>

        tonnes
        |> should (equalWithin 0.1) 0.00156

    [<Fact>]
    let ``Convert known gram to ounce`` () =
        let ounces = g.toOunces 256.0<g>

        ounces
        |> should (equalWithin 0.1) 9.03013

    [<Fact>]
    let ``Convert known gram to pound`` () =
        let pounds = g.toPounds 256.0<g>

        pounds
        |> should (equalWithin 0.1) 0.564383

    [<Fact>]
    let ``Convert known gram to stone`` () =
        let stones = g.toStones 1234.0<g>

        stones
        |> should (equalWithin 0.1) 0.1943217