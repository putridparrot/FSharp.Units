namespace FSharp.Units.Tests

module KilogramTests =

    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit.Xunit
    open FSharp.Units.Mass
    open Helpers

    // kilogram to X and back

    [<Property>]
    let ``From kilogram to milligram and back`` () =
        let property value = 
            let milligrams = kg.toMilligrams (kg.create value)
            let kilograms = mg.toKilograms milligrams

            kilograms 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilogram to grams and back`` () =
        let property value = 
            let grams = kg.toGrams (kg.create value)
            let kilograms = g.toKilograms grams

            kilograms
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilogram to tonne and back`` () =
        let property value = 
            let tonnes = kg.toTonnes (kg.create value)
            let kilograms = tonne.toKilograms tonnes

            kilograms
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilogram to ounce and back`` () =
        let property value = 
            let ounces = kg.toOunces (kg.create value)
            let kilograms = oz.toKilograms ounces

            kilograms
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilogram to pound and back`` () =
        let property value = 
            let pounds = kg.toPounds (kg.create value)
            let kilograms = lb.toKilograms pounds

            kilograms
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kilogram to stones and back`` () =
        let property value = 
            let stones = kg.toStones (kg.create value)
            let kilograms = stone.toKilograms stones

            kilograms
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known kilogram to milligram`` () =
        let milligrams= kg.toMilligrams 1560.0<kg>

        milligrams
        |> should (equalWithin 0.1) 1.56e+9

    [<Fact>]
    let ``Convert known kilogram to gram`` () =
        let grams = kg.toGrams 1560.0<kg>

        grams
        |> should (equalWithin 0.1) 1560000

    [<Fact>]
    let ``Convert known kilogram to tonne`` () =
        let tonnes = kg.toTonnes 1560.0<kg>

        tonnes
        |> should (equalWithin 0.1) 1.56

    [<Fact>]
    let ``Convert known kilogram to ounce`` () =
        let ounces = kg.toOunces 256.0<kg>

        ounces
        |> should (equalWithin 0.1) 9030.13

    [<Fact>]
    let ``Convert known kilogram to pound`` () =
        let pounds = kg.toPounds 256.0<kg>

        pounds
        |> should (equalWithin 0.1) 564.383

    [<Fact>]
    let ``Convert known kilogram to stone`` () =
        let stones = kg.toStones 1234.0<kg>

        stones
        |> should (equalWithin 0.1) 194.3217