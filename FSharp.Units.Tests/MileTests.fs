namespace FSharp.Units.Tests

module MileTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Length
    open Helpers

   // mile to X and back

    [<Property>]
    let ``From mile to millimetre and back`` () =
        let property value = 
            let millimetres = mile.toMillimetres (mile.create value)
            let miles = mm.toMiles millimetres

            miles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From mile to centimetre and back`` () =
        let property value = 
            let centimetres = mile.toCentimetres (mile.create value)
            let miles = cm.toMiles centimetres

            miles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From mile to kilometre and back`` () =
        let property value = 
            let kilometres = mile.toKilometres (mile.create value)
            let miles = km.toMiles kilometres

            miles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From mile to inches and back`` () =
        let property value = 
            let inches = mile.toInches (mile.create value)
            let miles = inch.toMiles inches

            miles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From mile to feet and back`` () =
        let property value = 
            let f = mile.toFeet (mile.create value)
            let miles = ft.toMiles f

            miles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From mile to yard and back`` () =
        let property value = 
            let yards = mile.toYards (mile.create value)
            let miles = yard.toMiles yards

            miles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From mile to nautical miles and back`` () =
        let property value = 
            let nauticalmiles = mile.toNauticalMiles (mile.create value)
            let miles = NM.toMiles nauticalmiles

            miles
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.03<mile>, 48280.32)>]
    let ``Convert known mile to millimetre`` (input, expectation) =
        mile.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(2.<mile>, 321868.8)>]
    let ``Convert known mile to centimetre`` (input, expectation) =
        mile.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.9<mile>, 1448.41)>]
    let ``Convert known mile to metre`` (input, expectation) =
        mile.toMetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3.<mile>, 4.82803)>]
    let ``Convert known mile to kilometre`` (input, expectation) =
        mile.toKilometres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1.2<mile>, 76032.)>]
    let ``Convert known mile to inch`` (input, expectation) =
        mile.toInches input
        |> should (equalWithin 0.01) expectation

    [<TestCase(2.1<mile>, 3696.)>]
    let ``Convert known mile to yard`` (input, expectation) =
        mile.toYards input
        |> should (equalWithin 0.01) expectation

    [<TestCase(2.2<mile>, 11616.)>]
    let ``Convert known mile to feet`` (input, expectation) =
        mile.toFeet input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5.<mile>, 4.34488)>]
    let ``Convert known mile to nautical mile`` (input, expectation) =
        mile.toNauticalMiles input
        |> should (equalWithin 0.01) expectation
