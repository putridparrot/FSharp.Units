namespace FSharp.Units.Tests

module FrequencyTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Frequency
    open Helpers


    [<Property>]
    let ``From Gigahertz to Hertz and back`` () =
        let property value =
            let convertTo = GHz.toHertz (GHz.create value)
            let convertBack = Hz.toGigahertz convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.009<GHz>, 9000000.)>]
    [<TestCase(0.000123<GHz>, 123000.)>]
    [<TestCase(0.0000456<GHz>, 45600.)>]
    let ``Convert known Gigahertz to Hertz`` (input, expectation) = 
        GHz.toHertz input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gigahertz to Kilohertz and back`` () =
        let property value =
            let convertTo = GHz.toKilohertz (GHz.create value)
            let convertBack = kHz.toGigahertz convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.009<GHz>, 9000.)>]
    [<TestCase(1e-5<GHz>, 10.)>]
    [<TestCase(0.000065<GHz>, 65.)>]
    let ``Convert known Gigahertz to Kilohertz`` (input, expectation) = 
        GHz.toKilohertz input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gigahertz to Megahertz and back`` () =
        let property value =
            let convertTo = GHz.toMegahertz (GHz.create value)
            let convertBack = MHz.toGigahertz convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<GHz>, 900.)>]
    [<TestCase(0.0123<GHz>, 12.3)>]
    [<TestCase(5.<GHz>, 5000.)>]
    let ``Convert known Gigahertz to Megahertz`` (input, expectation) = 
        GHz.toMegahertz input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hertz to Kilohertz and back`` () =
        let property value =
            let convertTo = Hz.toKilohertz (Hz.create value)
            let convertBack = kHz.toHertz convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(800<Hz>, 0.8)>]
    [<TestCase(1506.9<Hz>, 1.5069)>]
    [<TestCase(5000.<Hz>, 5.)>]
    let ``Convert known Hertz to Kilohertz`` (input, expectation) = 
        Hz.toKilohertz input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hertz to Megahertz and back`` () =
        let property value =
            let convertTo = Hz.toMegahertz (Hz.create value)
            let convertBack = MHz.toHertz convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900009<Hz>, 0.900009)>]
    [<TestCase(160000.<Hz>, 0.16)>]
    [<TestCase(888888.<Hz>, 0.888888)>]
    let ``Convert known Hertz to Megahertz`` (input, expectation) = 
        Hz.toMegahertz input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hertz to Gigahertz and back`` () =
        let property value =
            let convertTo = Hz.toGigahertz (Hz.create value)
            let convertBack = GHz.toHertz convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100900900<Hz>, 0.1009009)>]
    [<TestCase(9.<Hz>, 9e-9)>]
    [<TestCase(90909090.<Hz>, 0.09090909)>]
    let ``Convert known Hertz to Gigahertz`` (input, expectation) = 
        Hz.toGigahertz input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilohertz to Hertz and back`` () =
        let property value =
            let convertTo = kHz.toHertz (kHz.create value)
            let convertBack = Hz.toKilohertz convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(90.90909<kHz>, 90909.09)>]
    [<TestCase(0.12345<kHz>, 123.45)>]
    [<TestCase(500.<kHz>, 500000.)>]
    let ``Convert known Kilohertz to Hertz`` (input, expectation) = 
        kHz.toHertz input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilohertz to Megahertz and back`` () =
        let property value =
            let convertTo = kHz.toMegahertz (kHz.create value)
            let convertBack = MHz.toKilohertz convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(909.<kHz>, 0.909)>]
    [<TestCase(123456.<kHz>, 123.456)>]
    [<TestCase(900.<kHz>, 0.9)>]
    let ``Convert known Kilohertz to Megahertz`` (input, expectation) = 
        kHz.toMegahertz input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilohertz to Gigahertz and back`` () =
        let property value =
            let convertTo = kHz.toGigahertz (kHz.create value)
            let convertBack = GHz.toKilohertz convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(987654.<kHz>, 0.987654)>]
    [<TestCase(10000.<kHz>, 0.01)>]
    [<TestCase(90090.<kHz>, 0.09009)>]
    let ``Convert known Kilohertz to Gigahertz`` (input, expectation) = 
        kHz.toGigahertz input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Megahertz to Hertz and back`` () =
        let property value =
            let convertTo = MHz.toHertz (MHz.create value)
            let convertBack = Hz.toMegahertz convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<MHz>, 900000.)>]
    [<TestCase(0.001<MHz>, 1000.)>]
    [<TestCase(0.091<MHz>, 91000.)>]
    let ``Convert known Megahertz to Hertz`` (input, expectation) = 
        MHz.toHertz input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Megahertz to Kilohertz and back`` () =
        let property value =
            let convertTo = MHz.toKilohertz (MHz.create value)
            let convertBack = kHz.toMegahertz convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.87<MHz>, 870.)>]
    [<TestCase(12.<MHz>, 12000.)>]
    [<TestCase(88.1<MHz>, 88100.)>]
    let ``Convert known Megahertz to Kilohertz`` (input, expectation) = 
        MHz.toKilohertz input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Megahertz to Gigahertz and back`` () =
        let property value =
            let convertTo = MHz.toGigahertz (MHz.create value)
            let convertBack = GHz.toMegahertz convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(798.<MHz>, 0.798)>]
    [<TestCase(900.<MHz>, 0.9)>]
    [<TestCase(579.1<MHz>, 0.5791)>]
    let ``Convert known Megahertz to Gigahertz`` (input, expectation) = 
        MHz.toGigahertz input
        |> should (equalWithin 0.01) expectation
