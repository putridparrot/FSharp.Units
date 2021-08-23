namespace FSharp.Units.Tests

module DegreeTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Angle
    open Helpers

    // Degree to X and back

    [<Property>]
    let ``From Degree to Gradian and back`` () =
        let property value = 
            let gradian = deg.toGradians (deg.create value)
            let degree = grad.toDegrees gradian

            degree
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Degree to Milliradian and back`` () =
        let property value = 
            let milliRadian = deg.toMilliradians (deg.create value)
            let degree = mrad.toDegrees milliRadian

            degree
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Degree to Minute of arc and back`` () =
        let property value = 
            let minArc = deg.toMinuteOfArc (deg.create value)
            let degree = arcmin.toDegrees minArc

            degree
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Degree to Radian and back`` () =
        let property value = 
            let rads = deg.toRadians (deg.create value)
            let degree = rad.toDegrees rads

            degree
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Degree to Second of arc and back`` () =
        let property value = 
            let sarc = deg.toSecondsOfArc (deg.create value)
            let degree = arcseconds.toDegrees sarc

            degree
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Degree turn to Millradian`` () =
        let mr = deg.toMilliradians 999.<deg>

        mr
        |> should (equalWithin 0.1) 17435.8