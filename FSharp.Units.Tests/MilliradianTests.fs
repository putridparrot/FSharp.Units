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

    [<Test>]
    let ``Convert known Gradians turn to Milliradian`` () =
        let mr = grad.toMilliradians 678.<grad>

        mr
        |> should (equalWithin 0.01) 10650.0

    [<Test>]
    let ``Convert known Milliradian turn to Gradian`` () =
        let gradians = mrad.toGradians 1234.<mrad>

        gradians
        |> should (equalWithin 0.01) 78.55888