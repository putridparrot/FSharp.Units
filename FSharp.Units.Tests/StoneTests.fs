namespace FSharp.Units.Tests

module StoneTests =

    //http://www.checkyourmath.com/convert/weight_mass/oz_metric_ton.php
    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit.Xunit
    open FSharp.Units.Mass
    open Helpers

    // ounce to X and back

    [<Property>]
    let ``From stone to milligram and back`` () =
        let property value = 
            let milligrams = stone.toMilligrams (stone.create value)
            let stones = mg.toStones milligrams

            stones
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From stone to grams and back`` () =
        let property value = 
            let grams = stone.toGrams (stone.create value)
            let stones = g.toStones grams

            stones
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From stone to kilogram and back`` () =
        let property value = 
            let kilogram = stone.toKilograms (stone.create value)
            let stones = kg.toStones kilogram

            stones
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From stone to tonne and back`` () =
        let property value = 
            let tonnes = stone.toTonnes (stone.create value)
            let stones = tonne.toStones tonnes

            stones
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From stone to ounce and back`` () =
        let property value = 
            let ounces = stone.toOunces (stone.create value)
            let stones = oz.toStones ounces

            stones
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From stone to pounds and back`` () =
        let property value = 
            let pounds = stone.toPounds (stone.create value)
            let stones = lb.toStones pounds

            stones
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known stone to milligram`` () =
        let milligrams= stone.toMilligrams 1560.0<stone>

        milligrams
        |> should (equalWithin 0.1) 9906457360.8

    [<Fact>]
    let ``Convert known stone to gram`` () =
        let grams = stone.toGrams 1560.0<stone>

        grams
        |> should (equalWithin 0.1) 9906457.3608

    [<Fact>]
    let ``Convert known stone to kilogram`` () =
        let kilograms = stone.toKilograms 1560.0<stone>

        kilograms
        |> should (equalWithin 0.1) 9906.4573608

    [<Fact>]
    let ``Convert known stone to tonne`` () =
        let tonnes = stone.toTonnes 256.0<stone>

        tonnes
        |> should (equalWithin 0.1) 1.62567505

    [<Fact>]
    let ``Convert known stone to ounce`` () =
        let ounces = stone.toOunces 256.0<stone>

        ounces
        |> should (equalWithin 0.1) 57344.

    [<Fact>]
    let ``Convert known stone to pound`` () =
        let pounds = stone.toPounds 1234.0<stone>

        pounds
        |> should (equalWithin 0.1) 17276.
