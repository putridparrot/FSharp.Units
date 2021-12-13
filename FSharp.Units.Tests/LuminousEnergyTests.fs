namespace FSharp.Units.Tests

module LuminousEnergyTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.LuminousEnergy
    open Helpers


    [<Property>]
    let ``From LumenHour to Talbot and back`` () =
        let property value =
            let convertTo = lmh.toTalbot (lmh.create value)
            let convertBack = T.toLumenHour convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9.0<lmh>, 32400.0)>]
    [<TestCase(1.2<lmh>, 4320.0)>]
    [<TestCase(4.0<lmh>, 14400.0)>]
    let ``Convert known LumenHour to Talbot`` (input, expectation) = 
        lmh.toTalbot input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From LumenHour to LumenMinute and back`` () =
        let property value =
            let convertTo = lmh.toLumenMinute (lmh.create value)
            let convertBack = lmmin.toLumenHour convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<lmh>, 72.0)>]
    [<TestCase(0.8<lmh>, 48.0)>]
    [<TestCase(109.00<lmh>, 6540)>]
    let ``Convert known LumenHour to LumenMinute`` (input, expectation) = 
        lmh.toLumenMinute input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From LumenHour to LumenSecond and back`` () =
        let property value =
            let convertTo = lmh.toLumenSecond (lmh.create value)
            let convertBack = lms.toLumenHour convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<lmh>, 392400.0)>]
    [<TestCase(6.1<lmh>, 21960.0)>]
    [<TestCase(0.7<lmh>, 2520.0)>]
    let ``Convert known LumenHour to LumenSecond`` (input, expectation) = 
        lmh.toLumenSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From LumenMinute to Talbot and back`` () =
        let property value =
            let convertTo = lmmin.toTalbot (lmmin.create value)
            let convertBack = T.toLumenMinute convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.7<lmmin>, 42.0)>]
    [<TestCase(678.0<lmmin>, 40680.0)>]
    [<TestCase(89.0<lmmin>, 5340.0)>]
    let ``Convert known LumenMinute to Talbot`` (input, expectation) = 
        lmmin.toTalbot input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From LumenMinute to LumenHour and back`` () =
        let property value =
            let convertTo = lmmin.toLumenHour (lmmin.create value)
            let convertBack = lmh.toLumenMinute convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(89.0<lmmin>, 1.4833)>]
    [<TestCase(9.0<lmmin>, 0.15)>]
    [<TestCase(0.123<lmmin>, 0.00205)>]
    let ``Convert known LumenMinute to LumenHour`` (input, expectation) = 
        lmmin.toLumenHour input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From LumenMinute to LumenSecond and back`` () =
        let property value =
            let convertTo = lmmin.toLumenSecond (lmmin.create value)
            let convertBack = lms.toLumenMinute convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.123<lmmin>, 7.38)>]
    [<TestCase(8000.0<lmmin>, 480000.0)>]
    [<TestCase(34.1<lmmin>, 2046.0)>]
    let ``Convert known LumenMinute to LumenSecond`` (input, expectation) = 
        lmmin.toLumenSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From LumenSecond to Talbot and back`` () =
        let property value =
            let convertTo = lms.toTalbot (lms.create value)
            let convertBack = T.toLumenSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190.0<lms>, 190.0)>]
    [<TestCase(0.6<lms>, 0.6)>]
    [<TestCase(5000.0<lms>, 5000.0)>]
    let ``Convert known LumenSecond to Talbot`` (input, expectation) = 
        lms.toTalbot input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From LumenSecond to LumenHour and back`` () =
        let property value =
            let convertTo = lms.toLumenHour (lms.create value)
            let convertBack = lmh.toLumenSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190.0<lms>, 0.052778)>]
    [<TestCase(200600.0<lms>, 55.7222)>]
    [<TestCase(1234.0<lms>, 0.342778)>]
    let ``Convert known LumenSecond to LumenHour`` (input, expectation) = 
        lms.toLumenHour input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From LumenSecond to LumenMinute and back`` () =
        let property value =
            let convertTo = lms.toLumenMinute (lms.create value)
            let convertBack = lmmin.toLumenSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(10900.0<lms>, 181.6667)>]
    [<TestCase(50.3<lms>, 0.83833)>]
    [<TestCase(276.0<lms>, 4.6)>]
    let ``Convert known LumenSecond to LumenMinute`` (input, expectation) = 
        lms.toLumenMinute input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Talbot to LumenSecond and back`` () =
        let property value =
            let convertTo = T.toLumenSecond (T.create value)
            let convertBack = lms.toTalbot convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100.0<T>, 100.0)>]
    [<TestCase(0.9<T>, 0.9)>]
    [<TestCase(23.1<T>, 23.1)>]
    let ``Convert known Talbot to LumenSecond`` (input, expectation) = 
        T.toLumenSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Talbot to LumenHour and back`` () =
        let property value =
            let convertTo = T.toLumenHour (T.create value)
            let convertBack = lmh.toTalbot convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(800.0<T>, 0.222)>]
    [<TestCase(6789.0<T>, 1.885833)>]
    [<TestCase(10900.0<T>, 3.027778)>]
    let ``Convert known Talbot to LumenHour`` (input, expectation) = 
        T.toLumenHour input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Talbot to LumenMinute and back`` () =
        let property value =
            let convertTo = T.toLumenMinute (T.create value)
            let convertBack = lmmin.toTalbot convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<T>, 15.0)>]
    [<TestCase(78.9<T>, 1.315)>]
    [<TestCase(1500.0<T>, 25.0)>]
    let ``Convert known Talbot to LumenMinute`` (input, expectation) = 
        T.toLumenMinute input
        |> should (equalWithin 0.01) expectation

