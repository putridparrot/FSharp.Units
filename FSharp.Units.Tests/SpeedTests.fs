namespace FSharp.Units.Tests

module SpeedTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Speed
    open Helpers


    [<Property>]
    let ``From Feet Per Second to Miles Per Hour and back`` () =
        let property value =
            let convertTo = fps.toMilesPerHour (fps.create value)
            let convertBack = mph.toFeetPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(14.5<fps>, 9.886364)>]
    [<TestCase(100.0<fps>, 68.1818)>]
    [<TestCase(1.6<fps>, 1.09091)>]
    let ``Convert known Feet Per Second to Miles Per Hour`` (input, expectation) = 
        fps.toMilesPerHour input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Feet Per Second to Kilometres Per Hour and back`` () =
        let property value =
            let convertTo = fps.toKilometresPerHour (fps.create value)
            let convertBack = kph.toFeetPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.5<fps>, 1.64592)>]
    [<TestCase(67.9<fps>, 74.50531)>]
    [<TestCase(109.0<fps>, 119.604)>]
    let ``Convert known Feet Per Second to Kilometres Per Hour`` (input, expectation) = 
        fps.toKilometresPerHour input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Feet Per Second to Metres Per Second and back`` () =
        let property value =
            let convertTo = fps.toMetresPerSecond (fps.create value)
            let convertBack = mps.toFeetPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(10.8<fps>, 3.29184)>]
    [<TestCase(66.0<fps>, 20.1168)>]
    [<TestCase(2.3<fps>, 0.70104)>]
    let ``Convert known Feet Per Second to Metres Per Second`` (input, expectation) = 
        fps.toMetresPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Feet Per Second to Knots and back`` () =
        let property value =
            let convertTo = fps.toKnots (fps.create value)
            let convertBack = knot.toFeetPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.3<fps>, 1.36271)>]
    [<TestCase(666.0<fps>, 394.594)>]
    [<TestCase(17.1<fps>, 10.13147)>]
    let ``Convert known Feet Per Second to Knots`` (input, expectation) = 
        fps.toKnots input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilometres Per Hour to Miles Per Hour and back`` () =
        let property value =
            let convertTo = kph.toMilesPerHour (kph.create value)
            let convertBack = mph.toKilometresPerHour convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(67.0<kph>, 41.6319)>]
    [<TestCase(12.0<kph>, 7.45645)>]
    [<TestCase(6.3<kph>, 3.91464)>]
    let ``Convert known Kilometres Per Hour to Miles Per Hour`` (input, expectation) = 
        kph.toMilesPerHour input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilometres Per Hour to Feet Per Second and back`` () =
        let property value =
            let convertTo = kph.toFeetPerSecond (kph.create value)
            let convertBack = fps.toKilometresPerHour convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.0<kph>, 4.55672)>]
    [<TestCase(1.5<kph>, 1.36702)>]
    [<TestCase(89.8<kph>, 81.83873)>]
    let ``Convert known Kilometres Per Hour to Feet Per Second`` (input, expectation) = 
        kph.toFeetPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilometres Per Hour to Metres Per Second and back`` () =
        let property value =
            let convertTo = kph.toMetresPerSecond (kph.create value)
            let convertBack = mps.toKilometresPerHour convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(67.0<kph>, 18.6111)>]
    [<TestCase(5.9<kph>, 1.63889)>]
    [<TestCase(900.0<kph>, 250.0)>]
    let ``Convert known Kilometres Per Hour to Metres Per Second`` (input, expectation) = 
        kph.toMetresPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilometres Per Hour to Knots and back`` () =
        let property value =
            let convertTo = kph.toKnots (kph.create value)
            let convertBack = knot.toKilometresPerHour convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<kph>, 485.961)>]
    [<TestCase(3.9<kph>, 2.10583)>]
    [<TestCase(12.0<kph>, 6.47948)>]
    let ``Convert known Kilometres Per Hour to Knots`` (input, expectation) = 
        kph.toKnots input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Knots to Miles Per Hour and back`` () =
        let property value =
            let convertTo = knot.toMilesPerHour (knot.create value)
            let convertBack = mph.toKnots convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8.0<knot>, 9.20624)>]
    [<TestCase(1.2<knot>, 1.38094)>]
    [<TestCase(670.0<knot>, 771.022)>]
    let ``Convert known Knots to Miles Per Hour`` (input, expectation) = 
        knot.toMilesPerHour input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Knots to Kilometres Per Hour and back`` () =
        let property value =
            let convertTo = knot.toKilometresPerHour (knot.create value)
            let convertBack = kph.toKnots convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(678.0<knot>, 1255.66)>]
    [<TestCase(1.8<knot>, 3.3336)>]
    [<TestCase(56.0<knot>, 103.712)>]
    let ``Convert known Knots to Kilometres Per Hour`` (input, expectation) = 
        knot.toKilometresPerHour input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Knots to Feet Per Second and back`` () =
        let property value =
            let convertTo = knot.toFeetPerSecond (knot.create value)
            let convertBack = fps.toKnots convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(56.0<knot>, 94.5174)>]
    [<TestCase(4.7<knot>, 7.93271)>]
    [<TestCase(3.0<knot>, 5.06343)>]
    let ``Convert known Knots to Feet Per Second`` (input, expectation) = 
        knot.toFeetPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Knots to Metres Per Second and back`` () =
        let property value =
            let convertTo = knot.toMetresPerSecond (knot.create value)
            let convertBack = mps.toKnots convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.0<knot>, 2.57222)>]
    [<TestCase(9.1<knot>, 4.68144)>]
    [<TestCase(190.0<knot>, 97.7444)>]
    let ``Convert known Knots to Metres Per Second`` (input, expectation) = 
        knot.toMetresPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Metres Per Second to Miles Per Hour and back`` () =
        let property value =
            let convertTo = mps.toMilesPerHour (mps.create value)
            let convertBack = mph.toMetresPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(13.0<mps>, 29.0802)>]
    [<TestCase(6.7<mps>, 14.9875)>]
    [<TestCase(140.0<mps>, 313.171)>]
    let ``Convert known Metres Per Second to Miles Per Hour`` (input, expectation) = 
        mps.toMilesPerHour input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Metres Per Second to Kilometres Per Hour and back`` () =
        let property value =
            let convertTo = mps.toKilometresPerHour (mps.create value)
            let convertBack = kph.toMetresPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(800.0<mps>, 2880.0)>]
    [<TestCase(7.8<mps>, 28.08)>]
    [<TestCase(9000.0<mps>, 32400.0)>]
    let ``Convert known Metres Per Second to Kilometres Per Hour`` (input, expectation) = 
        mps.toKilometresPerHour input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Metres Per Second to Feet Per Second and back`` () =
        let property value =
            let convertTo = mps.toFeetPerSecond (mps.create value)
            let convertBack = fps.toMetresPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9000.0<mps>, 29527.56)>]
    [<TestCase(3.4<mps>, 11.1549)>]
    [<TestCase(12.0<mps>, 39.3701)>]
    let ``Convert known Metres Per Second to Feet Per Second`` (input, expectation) = 
        mps.toFeetPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Metres Per Second to Knots and back`` () =
        let property value =
            let convertTo = mps.toKnots (mps.create value)
            let convertBack = knot.toMetresPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<mps>, 23.3261)>]
    [<TestCase(6.3<mps>, 12.2462)>]
    [<TestCase(9.0<mps>, 17.4946)>]
    let ``Convert known Metres Per Second to Knots`` (input, expectation) = 
        mps.toKnots input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Miles Per Hour to Kilometres Per Hour and back`` () =
        let property value =
            let convertTo = mph.toKilometresPerHour (mph.create value)
            let convertBack = kph.toMilesPerHour convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(345.0<mph>, 555.224)>]
    [<TestCase(1.6<mph>, 2.57495)>]
    [<TestCase(0.5<mph>, 0.804672)>]
    let ``Convert known Miles Per Hour to Kilometres Per Hour`` (input, expectation) = 
        mph.toKilometresPerHour input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Miles Per Hour to Feet Per Second and back`` () =
        let property value =
            let convertTo = mph.toFeetPerSecond (mph.create value)
            let convertBack = fps.toMilesPerHour convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.5<mph>, 0.733333)>]
    [<TestCase(123.0<mph>, 180.4)>]
    [<TestCase(4.5<mph>, 6.6)>]
    let ``Convert known Miles Per Hour to Feet Per Second`` (input, expectation) = 
        mph.toFeetPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Miles Per Hour to Metres Per Second and back`` () =
        let property value =
            let convertTo = mph.toMetresPerSecond (mph.create value)
            let convertBack = mps.toMilesPerHour convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.5<mph>, 2.01168)>]
    [<TestCase(100.0<mph>, 44.704)>]
    [<TestCase(40.0<mph>, 17.8816)>]
    let ``Convert known Miles Per Hour to Metres Per Second`` (input, expectation) = 
        mph.toMetresPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Miles Per Hour to Knots and back`` () =
        let property value =
            let convertTo = mph.toKnots (mph.create value)
            let convertBack = knot.toMilesPerHour convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(30.0<mph>, 26.0693)>]
    [<TestCase(4.5<mph>, 3.91039)>]
    [<TestCase(55.0<mph>, 47.7937)>]
    let ``Convert known Miles Per Hour to Knots`` (input, expectation) = 
        mph.toKnots input
        |> should (equalWithin 0.01) expectation

