namespace FSharp.Units.Tests

module MillimetreTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Length
    open Helpers

   // millimetre to X and back

    [<Property>]
    let ``From millimetre to centimetres and back`` () =
        let property value = 
            let centimetres = mm.toCentimetres (mm.create value)
            let millimetres = cm.toMillimetres centimetres

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millimetre to metres and back`` () =
        let property value = 
            let metres = mm.toMetres (mm.create value)
            let millimetres = m.toMillimetres metres

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millimetre to kilometres and back`` () =
        let property value = 
            let kilometres = mm.toKilometres (mm.create value)
            let millimetres = km.toMillimetres kilometres

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millimetre to inches and back`` () =
        let property value = 
            let inches = mm.toInches (mm.create value)
            let millimetres = inch.toMillimetres inches

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millimetre to feet and back`` () =
        let property value = 
            let f = mm.toFeet (mm.create value)
            let millimetres = ft.toMillimetres f

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millimetre to yards and back`` () =
        let property value = 
            let yards = mm.toYards (mm.create value)
            let millimetres = yard.toMillimetres yards

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millimetre to miles and back`` () =
        let property value = 
            let miles = mm.toMiles (mm.create value)
            let millimetres = mile.toMillimetres miles

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From millimetre to nautical miles and back`` () =
        let property value = 
            let nauticalmiles = mm.toNauticalMiles (mm.create value)
            let millimetres = NM.toMillimetres nauticalmiles

            millimetres
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.<mm>, 12.3)>]
    let ``Convert known millimetre to centimetre`` (input, expectation) =
        mm.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(123.<mm>, 0.123)>]
    let ``Convert known millimetre to metre`` (input, expectation) =
        mm.toMetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(10981.<mm>, 0.010981)>]
    let ``Convert known millimetre to kilometre`` (input, expectation) =
        mm.toKilometres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1422.4<mm>, 56.)>]
    let ``Convert known millimetre to inch`` (input, expectation) =
        mm.toInches input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1234.<mm>, 4.04855643)>]
    let ``Convert known millimetre to feet`` (input, expectation) =
        mm.toFeet input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3940.<mm>, 4.3088364)>]
    let ``Convert known millimetre to yard`` (input, expectation) =
        mm.toYards input
        |> should (equalWithin 0.01) expectation

    [<TestCase(4023360.<mm>, 2.5)>]
    let ``Convert known millimetre to mile`` (input, expectation) =
        mm.toMiles input
        |> should (equalWithin 0.01) expectation

    [<TestCase(123456.<mm>, 0.0666609071)>]
    let ``Convert known millimetre to nauticalmile`` (input, expectation) =
        mm.toNauticalMiles input
        |> should (equalWithin 0.01) expectation
