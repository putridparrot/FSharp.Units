namespace FSharp.Units.Tests

module OunceTests =

    //http://www.checkyourmath.com/convert/weight_mass/oz_metric_ton.php
    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit.Xunit
    open FSharp.Units.Mass
    open Helpers

    // ounce to X and back

    [<Property>]
    let ``From ounce to milligram and back`` () =
        let property value = 
            let milligrams = oz.toMilligrams (oz.create value)
            let ounces = mg.toOunces milligrams

            ounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From ounce to grams and back`` () =
        let property value = 
            let grams = oz.toGrams (oz.create value)
            let ounces = g.toOunces grams

            ounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From ounce to kilogram and back`` () =
        let property value = 
            let kilogram = oz.toKilograms (oz.create value)
            let ounces = kg.toOunces kilogram

            ounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From ounce to tonne and back`` () =
        let property value = 
            let tonnes = oz.toTonnes (oz.create value)
            let ounces = tonne.toOunces tonnes

            ounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From ounce to pound and back`` () =
        let property value = 
            let pounds = oz.toPounds (oz.create value)
            let ounces = lb.toOunces pounds

            ounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From ounce to stones and back`` () =
        let property value = 
            let stones = oz.toStones (oz.create value)
            let ounces = stone.toOunces stones

            ounces
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Fact>]
    let ``Convert known ounce to milligram`` () =
        let milligrams= oz.toMilligrams 1560.0<oz>

        milligrams
        |> should (equalWithin 0.1) 44225256.036

    [<Fact>]
    let ``Convert known ounce to gram`` () =
        let grams = oz.toGrams 1560.0<oz>

        grams
        |> should (equalWithin 0.1) 44225.26

    [<Fact>]
    let ``Convert known ounce to kilogram`` () =
        let kilograms = oz.toKilograms 1560.0<oz>

        kilograms
        |> should (equalWithin 0.1) 44.22526

    [<Fact>]
    let ``Convert known ounce to tonne`` () =
        let tonnes = oz.toTonnes 256.0<oz>

        tonnes
        |> should (equalWithin 0.1) 0.00725748

    [<Fact>]
    let ``Convert known ounce to pound`` () =
        let pounds = oz.toPounds 256.0<oz>

        pounds
        |> should (equalWithin 0.1) 16

    [<Fact>]
    let ``Convert known ounce to stone`` () =
        let stones = oz.toStones 1234.0<oz>

        stones
        |> should (equalWithin 0.1) 5.508929
