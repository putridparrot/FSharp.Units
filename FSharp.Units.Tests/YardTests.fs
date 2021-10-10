namespace FSharp.Units.Tests

module YardTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Length
    open Helpers

   // yard to X and back

    [<Property>]
    let ``From yard to millimetre and back`` () =
        let property value = 
            let millimetres = yard.toMillimetres (yard.create value)
            let yard = mm.toYards millimetres

            yard
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From yard to centimetre and back`` () =
        let property value = 
            let centimetres = yard.toCentimetres (yard.create value)
            let yard = cm.toYards centimetres

            yard
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From yard to metre and back`` () =
        let property value = 
            let metres = yard.toMetres (yard.create value)
            let yard = m.toYards metres

            yard
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From yard to kilometre and back`` () =
        let property value = 
            let kilometres = yard.toKilometres (yard.create value)
            let yard = km.toYards kilometres

            yard
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From yard to inch and back`` () =
        let property value = 
            let inches = yard.toInches (yard.create value)
            let yard = inch.toYards inches

            yard
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From yard to feet and back`` () =
        let property value = 
            let feet = yard.toFeet (yard.create value)
            let yard = ft.toYards feet

            yard
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From yard to miles and back`` () =
        let property value = 
            let miles = yard.toMiles (yard.create value)
            let yard = mile.toYards miles

            yard
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From yard to nautical miles and back`` () =
        let property value = 
            let nauticalmiles = yard.toNauticalMiles (yard.create value)
            let yard = NM.toYards nauticalmiles

            yard
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.<yard>, 914.4)>]
    [<TestCase(97.<yard>, 88696.8)>]
    [<TestCase(0.456<yard>, 416.9664)>]
    let ``Convert known yard to millimetre`` (input, expectation) =
        yard.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(23.<yard>, 2103.12)>]
    [<TestCase(97.<yard>, 8869.68)>]
    [<TestCase(0.456<yard>, 41.69664)>]
    let ``Convert known yard to centimetre`` (input, expectation) =
        yard.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(23.<yard>, 21.0312)>]
    [<TestCase(97.<yard>, 88.6968)>]
    [<TestCase(0.981<yard>, 0.8970264)>]
    let ``Convert known yard to metre`` (input, expectation) =
        yard.toMetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1200.<yard>, 1.09728)>]
    [<TestCase(97.<yard>, 0.0886968)>]
    [<TestCase(0.981<yard>, 0.0008970264)>]
    let ``Convert known yard to kilometre`` (input, expectation) =
        yard.toKilometres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.<yard>, 432.)>]
    [<TestCase(97.<yard>, 3492)>]
    [<TestCase(0.981<yard>, 35.316)>]
    let ``Convert known yard to inch`` (input, expectation) =
        yard.toInches input
        |> should (equalWithin 0.01) expectation

    [<TestCase(23.<yard>, 69.)>]
    [<TestCase(97.<yard>, 291)>]
    [<TestCase(0.981<yard>, 2.943)>]
    let ``Convert known yard to feet`` (input, expectation) =
        yard.toFeet input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1245.<yard>, 0.70738636)>]
    [<TestCase(97.<yard>, 0.0551136)>]
    [<TestCase(7111.<yard>, 4.040341)>]
    let ``Convert known yard to mile`` (input, expectation) =
        yard.toMiles input
        |> should (equalWithin 0.01) expectation

    [<TestCase(7000.<yard>, 3.456156)>]
    [<TestCase(97.<yard>, 0.0478924)>]
    [<TestCase(8910<yard>, 4.399192)>]
    let ``Convert known yard to nautical mile`` (input, expectation) =
        yard.toNauticalMiles input
        |> should (equalWithin 0.01) expectation
