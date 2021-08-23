namespace FSharp.Units.Tests

module RadiansTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Angle
    open Helpers

    // Radians to X and back

    [<Property>]
    let ``From Radians to Gradian and back`` () =
        let property value = 
            let gradian = rad.toGradians (rad.create value)
            let radians = grad.toRadians gradian

            radians
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Radians to Milliradian and back`` () =
        let property value = 
            let milliRadian = rad.toMilliradians (rad.create value)
            let radians = mrad.toRadians milliRadian

            radians
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Radians to Minute of arc and back`` () =
        let property value = 
            let minArc = rad.toMinuteOfArc (rad.create value)
            let radians = arcmin.toRadians minArc

            radians
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Radians to Degrees and back`` () =
        let property value = 
            let degrees = rad.toDegrees (rad.create value)
            let radians = deg.toRadians degrees

            radians
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Radians to Second of arc and back`` () =
        let property value = 
            let sarc = rad.toSecondsOfArc (rad.create value)
            let radians = arcseconds.toRadians sarc

            radians
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Radians turn to Millradian`` () =
        let mr = rad.toMilliradians 999.<rad>

        mr
        |> should (equalWithin 0.1) 999000.0