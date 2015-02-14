namespace FSharp.Units.Tests

module TonneTests =

    open System
    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit
    open FsUnit.Xunit
    open FSharp.Units
    open FSharp.Units.Mass
    open Helpers

    // tonne to X and back

    [<Property>]
    let ``From tonne to milligram and back`` () =
        let property value = 
            let milligrams = tonne.toMilligrams (tonne.create value)
            let tonnes = mg.toTonnes milligrams

            tonnes 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From tonne to grams and back`` () =
        let property value = 
            let grams = tonne.toGrams (tonne.create value)
            let tonnes = g.toTonnes grams

            tonnes
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From tonne to kilogram and back`` () =
        let property value = 
            let kilogram = tonne.toKilograms (tonne.create value)
            let tonnes = kg.toTonnes kilogram

            tonnes
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From tonne to ounce and back`` () =
        let property value = 
            let ounces = tonne.toOunces (tonne.create value)
            let tonnes = oz.toTonnes ounces

            tonnes
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From tonne to pound and back`` () =
        let property value = 
            let pounds = tonne.toPounds (tonne.create value)
            let tonnes = lb.toTonnes pounds

            tonnes
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From tonne to stones and back`` () =
        let property value = 
            let stones = tonne.toStones (tonne.create value)
            let tonnes = stone.toTonnes stones

            tonnes
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known tonne to milligram`` () =
        let milligrams= tonne.toMilligrams 1560.0<tonne>

        milligrams
        |> should (equalWithin 0.1) 1.56e+12<mg>

    [<Fact>]
    let ``Convert known tonne to gram`` () =
        let grams = tonne.toGrams 1560.0<tonne>

        grams
        |> should (equalWithin 0.1) 1.56e+9<g>

    [<Fact>]
    let ``Convert known tonne to kilogram`` () =
        let kilograms = tonne.toKilograms 1560.0<tonne>

        kilograms
        |> should (equalWithin 0.1) 1560000<kg>

    [<Fact>]
    let ``Convert known tonne to ounce`` () =
        let ounces = tonne.toOunces 256.0<tonne>

        ounces
        |> should (equalWithin 0.1) 9030134.2670558<oz>

    [<Fact>]
    let ``Convert known tonne to pound`` () =
        let pounds = tonne.toPounds 256.0<tonne>

        pounds
        |> should (equalWithin 0.1) 564383.39119329<lb>

    [<Fact>]
    let ``Convert known tonne to stone`` () =
        let stones = tonne.toStones 1234.0<tonne>

        stones
        |> should (equalWithin 0.1) 194321.7<stone>
