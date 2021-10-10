namespace FSharp.Units.Tests

module MilliradiansTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Angle
    open Helpers

    // Milliradians to X and back

    [<Property>]
    let ``From Milliradians to Radian and back`` () =
        let property value = 
            let radians = mrad.toRadians (mrad.create value)
            let milliRadians = rad.toMilliradians radians

            milliRadians
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Milliradians to Gradians and back`` () =
        let property value = 
            let gradians = mrad.toGradians (mrad.create value)
            let milliRadians = grad.toMilliradians gradians

            milliRadians
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Milliradians to Minute of arc and back`` () =
        let property value = 
            let minArc = mrad.toMinuteOfArc (mrad.create value)
            let milliRadians = arcmin.toMilliradians minArc

            milliRadians
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Milliradians to Degrees and back`` () =
        let property value = 
            let degrees = mrad.toDegrees (mrad.create value)
            let milliRadians = deg.toMilliradians degrees

            milliRadians
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Milliradians to Second of arc and back`` () =
        let property value = 
            let sarc = mrad.toSecondsOfArc (mrad.create value)
            let milliRadians = arcseconds.toMilliradians sarc

            milliRadians
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(678.<grad>, 10650.024)>]
    let ``Convert known Gradians turn to Milliradian`` (input, expectation) =
        grad.toMilliradians input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1234.<mrad>, 78.55888)>]
    let ``Convert known Milliradian turn to Gradian`` (input, expectation) =
        mrad.toGradians input
        |> should (equalWithin 0.01) expectation