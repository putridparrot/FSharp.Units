namespace FSharp.Units.Tests

module InchTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Length
    open Helpers

   // inch to X and back

    [<Property>]
    let ``From inch to millimetre and back`` () =
        let property value = 
            let millimetres = inch.toMillimetres (inch.create value)
            let inches = mm.toInches millimetres

            inches
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From inch to centimetre and back`` () =
        let property value = 
            let centimetres = inch.toCentimetres (inch.create value)
            let inches = cm.toInches centimetres

            inches
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From inch to metre and back`` () =
        let property value = 
            let metres = inch.toMetres (inch.create value)
            let inches = m.toInches metres

            inches
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From inch to kilometre and back`` () =
        let property value = 
            let kilometres = inch.toKilometres (inch.create value)
            let inches = km.toInches kilometres

            inches
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From inch to feet and back`` () =
        let property value = 
            let feet = inch.toFeet (inch.create value)
            let inches = ft.toInches feet

            inches
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From inch to yards and back`` () =
        let property value = 
            let yards = inch.toYards (inch.create value)
            let inches = yard.toInches yards

            inches
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From inch to miles and back`` () =
        let property value = 
            let miles = inch.toMiles (inch.create value)
            let inches = mile.toInches miles

            inches
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From inch to nautical miles and back`` () =
        let property value = 
            let nauticalmiles = inch.toNauticalMiles (inch.create value)
            let inches = NM.toInches nauticalmiles

            inches
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.<inch>, 3124.2)>]
    let ``Convert known inch to millimetre`` (input, expectation) =
        inch.toMillimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(56.<inch>, 142.24)>]
    let ``Convert known inch to centimetre`` (input, expectation) =
        inch.toCentimetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(123.<inch>, 3.1242)>]
    let ``Convert known inch to metre`` (input, expectation) =
        inch.toMetres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1891.<inch>, 0.0480314)>]
    let ``Convert known inch to kilometre`` (input, expectation) =
        inch.toKilometres input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1891.<inch>, 157.58333333)>]
    let ``Convert known inch to feet`` (input, expectation) =
        inch.toFeet input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1891.<inch>, 52.52777778)>]
    let ``Convert known inch to yards`` (input, expectation) =
        inch.toYards input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1891.<inch>, 0.02984533)>]
    let ``Convert known inch to miles`` (input, expectation) =
        inch.toMiles input
        |> should (equalWithin 0.01) expectation

    [<TestCase(8900.<inch>, 0.1220626)>]
    let ``Convert known inch to nauticalmiles`` (input, expectation) =
        inch.toNauticalMiles input
        |> should (equalWithin 0.01) expectation
