namespace FSharp.Units.Tests

module SecondsOfArcTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Angle
    open Helpers

    // Seconds of arc to X and back

    [<Property>]
    let ``From Seconds of arc to Radian and back`` () =
        let property value = 
            let radians = arcseconds.toRadians (arcseconds.create value)
            let sarc = rad.toSecondsOfArc radians

            sarc 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Seconds of arc to Milliradian and back`` () =
        let property value = 
            let milliRadian = arcseconds.toMilliradians (arcseconds.create value)
            let sarc = mrad.toSecondsOfArc milliRadian

            sarc 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Seconds of arc to Gradians and back`` () =
        let property value = 
            let gradians = arcseconds.toGradians (arcseconds.create value)
            let sarc = grad.toSecondsOfArc gradians

            sarc 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Seconds of arc to Degrees and back`` () =
        let property value = 
            let degrees = arcseconds.toDegrees (arcseconds.create value)
            let sarc = deg.toSecondsOfArc degrees

            sarc 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Seconds of arc to Minute of arc and back`` () =
        let property value = 
            let sarc = arcseconds.toMinuteOfArc (arcseconds.create value)
            let marc = arcmin.toSecondsOfArc sarc

            marc 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Seconds of arc turn to Milliradian`` () =
        let mr = arcseconds.toMilliradians 123.<arcseconds>

        mr
        |> should (equalWithin 0.01) 0.596321

    [<Test>]
    let ``Convert known Seconds of arc turn to Gradian`` () =
        let gradian = arcseconds.toGradians 34.<arcseconds>

        gradian
        |> should (equalWithin 0.001) 0.0104938