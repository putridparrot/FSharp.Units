namespace FSharp.Units.Tests

module MinuteOfArcTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Angle
    open Helpers

    // Minuteof arc to X and back

    [<Property>]
    let ``From Minute of arc to Radian and back`` () =
        let property value = 
            let radians = arcmin.toRadians (arcmin.create value)
            let marc = rad.toMinuteOfArc radians

            marc
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Minute of arc to Milliradian and back`` () =
        let property value = 
            let milliRadian = arcmin.toMilliradians (arcmin.create value)
            let marc = mrad.toMinuteOfArc milliRadian

            marc
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Minute of arc to Gradians and back`` () =
        let property value = 
            let gradians = arcmin.toGradians (arcmin.create value)
            let marc = grad.toMinuteOfArc gradians

            marc
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Minute of arc to Degrees and back`` () =
        let property value = 
            let degrees = arcmin.toDegrees (arcmin.create value)
            let marc = deg.toMinuteOfArc degrees

            marc
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Minute of arc to Second of arc and back`` () =
        let property value = 
            let sarc = arcmin.toSecondsOfArc (arcmin.create value)
            let marc = arcseconds.toMinuteOfArc sarc

            marc
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Minute of arc turn to Milliradian`` () =
        let mr = arcmin.toMilliradians 123.<arcmin>

        mr
        |> should (equalWithin 0.01) 35.7792

    [<Test>]
    let ``Convert known Minute of arc turn to Gradian`` () =
        let mr = arcmin.toGradians 34.<arcmin>

        mr
        |> should (equalWithin 0.001) 0.62963