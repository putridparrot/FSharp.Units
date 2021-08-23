namespace FSharp.Units.Tests

module GradiansTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Angle
    open Helpers

    // Gradians to X and back

    [<Property>]
    let ``From Gradians to Radian and back`` () =
        let property value = 
            let radians = grad.toRadians (grad.create value)
            let gradians = rad.toGradians radians

            gradians
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Gradians to Milliradian and back`` () =
        let property value = 
            let milliRadian = grad.toMilliradians (grad.create value)
            let gradians = mrad.toGradians milliRadian

            gradians
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Gradians to Minute of arc and back`` () =
        let property value = 
            let minArc = grad.toMinuteOfArc (grad.create value)
            let gradians = arcmin.toGradians minArc

            gradians
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Gradians to Degrees and back`` () =
        let property value = 
            let degrees = grad.toDegrees (grad.create value)
            let gradians = deg.toGradians degrees

            gradians
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Gradians to Second of arc and back`` () =
        let property value = 
            let sarc = grad.toSecondsOfArc (grad.create value)
            let gradians = arcseconds.toGradians sarc

            gradians
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Gradians turn to Milliradian`` () =
        let mr = grad.toMilliradians 999.<grad>

        mr
        |> should (equalWithin 0.1) 15692.3

    [<Test>]
    let ``Convert known Milliradian turn to Gradian`` () =
        let mr = mrad.toGradians 999.<mrad>

        mr
        |> should (equalWithin 0.1) 63.5983