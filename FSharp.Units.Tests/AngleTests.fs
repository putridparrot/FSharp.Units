namespace FSharp.Units.Tests

module AngleTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Angle
    open Helpers


    [<Property>]
    let ``From Degrees to Radians and back`` () =
        let property value =
            let convertTo = deg.toRadians (deg.create value)
            let convertBack = rad.toDegrees convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(98.8<deg>, 1.724385)>]
    [<TestCase(8000.<deg>, 139.6263)>]
    [<TestCase(8.<deg>, 0.139626)>]
    let ``Convert known Degrees to Radians`` (input, expectation) = 
        deg.toRadians input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Degrees to Gradians and back`` () =
        let property value =
            let convertTo = deg.toGradians (deg.create value)
            let convertBack = grad.toDegrees convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.<deg>, 136.667)>]
    [<TestCase(65.<deg>, 72.2222)>]
    [<TestCase(900.<deg>, 1000.)>]
    let ``Convert known Degrees to Gradians`` (input, expectation) = 
        deg.toGradians input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Degrees to Milliradians and back`` () =
        let property value =
            let convertTo = deg.toMilliradians (deg.create value)
            let convertBack = mrad.toDegrees convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.<deg>, 15707.969)>]
    [<TestCase(76.<deg>, 1326.45)>]
    [<TestCase(4.5<deg>, 78.5398)>]
    let ``Convert known Degrees to Milliradians`` (input, expectation) = 
        deg.toMilliradians input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Degrees to Minute Of Arc and back`` () =
        let property value =
            let convertTo = deg.toMinuteOfArc (deg.create value)
            let convertBack = arcmin.toDegrees convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(97.<deg>, 5820.)>]
    [<TestCase(8.65<deg>, 519.)>]
    [<TestCase(12.<deg>, 720.)>]
    let ``Convert known Degrees to Minute Of Arc`` (input, expectation) = 
        deg.toMinuteOfArc input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Degrees to Seconds Of Arc and back`` () =
        let property value =
            let convertTo = deg.toSecondsOfArc (deg.create value)
            let convertBack = arcseconds.toDegrees convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.<deg>, 43200.)>]
    [<TestCase(910.4<deg>, 3277440)>]
    [<TestCase(5.6<deg>, 20160.)>]
    let ``Convert known Degrees to Seconds Of Arc`` (input, expectation) = 
        deg.toSecondsOfArc input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gradians to Degrees and back`` () =
        let property value =
            let convertTo = grad.toDegrees (grad.create value)
            let convertBack = deg.toGradians convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.6<grad>, 5.04)>]
    [<TestCase(167.<grad>, 150.3)>]
    [<TestCase(0.1<grad>, 0.09)>]
    let ``Convert known Gradians to Degrees`` (input, expectation) = 
        grad.toDegrees input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gradians to Radians and back`` () =
        let property value =
            let convertTo = grad.toRadians (grad.create value)
            let convertBack = rad.toGradians convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(67.9<grad>, 1.066571)>]
    [<TestCase(8000<grad>, 125.6637)>]
    [<TestCase(6.5<grad>, 0.102102)>]
    let ``Convert known Gradians to Radians`` (input, expectation) = 
        grad.toRadians input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gradians to Milliradians and back`` () =
        let property value =
            let convertTo = grad.toMilliradians (grad.create value)
            let convertBack = mrad.toGradians convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8.1<grad>, 127.2348)>]
    [<TestCase(900.<grad>, 14137.2)>]
    [<TestCase(1902.5<grad>, 29884.47)>]
    let ``Convert known Gradians to Milliradians`` (input, expectation) = 
        grad.toMilliradians input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gradians to Minute Of Arc and back`` () =
        let property value =
            let convertTo = grad.toMinuteOfArc (grad.create value)
            let convertBack = arcmin.toGradians convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(80.9<grad>, 4368.6)>]
    [<TestCase(1678.<grad>, 90612.)>]
    [<TestCase(900.<grad>, 48600.)>]
    let ``Convert known Gradians to Minute Of Arc`` (input, expectation) = 
        grad.toMinuteOfArc input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gradians to Seconds Of Arc and back`` () =
        let property value =
            let convertTo = grad.toSecondsOfArc (grad.create value)
            let convertBack = arcseconds.toGradians convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<grad>, 2916.)>]
    [<TestCase(12.3<grad>, 39852.)>]
    [<TestCase(5.1<grad>, 16524.)>]
    let ``Convert known Gradians to Seconds Of Arc`` (input, expectation) = 
        grad.toSecondsOfArc input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Milliradians to Degrees and back`` () =
        let property value =
            let convertTo = mrad.toDegrees (mrad.create value)
            let convertBack = deg.toMilliradians convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.9<mrad>, 0.338045)>]
    [<TestCase(109.<mrad>, 6.24524)>]
    [<TestCase(7009.<mrad>, 401.5861)>]
    let ``Convert known Milliradians to Degrees`` (input, expectation) = 
        mrad.toDegrees input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Milliradians to Radians and back`` () =
        let property value =
            let convertTo = mrad.toRadians (mrad.create value)
            let convertBack = rad.toMilliradians convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8011.<mrad>, 8.011)>]
    [<TestCase(7689.<mrad>, 7.689)>]
    [<TestCase(129.<mrad>, 0.129)>]
    let ``Convert known Milliradians to Radians`` (input, expectation) = 
        mrad.toRadians input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Milliradians to Gradians and back`` () =
        let property value =
            let convertTo = mrad.toGradians (mrad.create value)
            let convertBack = grad.toMilliradians convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(129.<mrad>, 8.2124)>]
    [<TestCase(800.<mrad>, 50.9296)>]
    [<TestCase(12.89<mrad>, 0.8206029)>]
    let ``Convert known Milliradians to Gradians`` (input, expectation) = 
        mrad.toGradians input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Milliradians to Minute Of Arc and back`` () =
        let property value =
            let convertTo = mrad.toMinuteOfArc (mrad.create value)
            let convertBack = arcmin.toMilliradians convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.<mrad>, 41.253)>]
    [<TestCase(0.9<mrad>, 3.09397)>]
    [<TestCase(800.<mrad>, 2750.2)>]
    let ``Convert known Milliradians to Minute Of Arc`` (input, expectation) = 
        mrad.toMinuteOfArc input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Milliradians to Seconds Of Arc and back`` () =
        let property value =
            let convertTo = mrad.toSecondsOfArc (mrad.create value)
            let convertBack = arcseconds.toMilliradians convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(67.<mrad>, 13819.742)>]
    [<TestCase(900.<mrad>, 185638.32562238674)>]
    [<TestCase(812.5<mrad>, 167590.16)>]
    let ``Convert known Milliradians to Seconds Of Arc`` (input, expectation) = 
        mrad.toSecondsOfArc input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Minute Of Arc to Degrees and back`` () =
        let property value =
            let convertTo = arcmin.toDegrees (arcmin.create value)
            let convertBack = deg.toMinuteOfArc convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(89.<arcmin>, 1.48333)>]
    [<TestCase(160.5<arcmin>, 2.675)>]
    [<TestCase(0.9<arcmin>, 0.015)>]
    let ``Convert known Minute Of Arc to Degrees`` (input, expectation) = 
        arcmin.toDegrees input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Minute Of Arc to Radians and back`` () =
        let property value =
            let convertTo = arcmin.toRadians (arcmin.create value)
            let convertBack = rad.toMinuteOfArc convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1790.<arcmin>, 0.5206899)>]
    [<TestCase(9999.<arcmin>, 2.908591)>]
    [<TestCase(12345.<arcmin>, 3.5910149)>]
    let ``Convert known Minute Of Arc to Radians`` (input, expectation) = 
        arcmin.toRadians input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Minute Of Arc to Gradians and back`` () =
        let property value =
            let convertTo = arcmin.toGradians (arcmin.create value)
            let convertBack = grad.toMinuteOfArc convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(300.<arcmin>, 5.55556)>]
    [<TestCase(1009.<arcmin>, 18.68519)>]
    [<TestCase(6700.5<arcmin>, 124.083335)>]
    let ``Convert known Minute Of Arc to Gradians`` (input, expectation) = 
        arcmin.toGradians input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Minute Of Arc to Milliradians and back`` () =
        let property value =
            let convertTo = arcmin.toMilliradians (arcmin.create value)
            let convertBack = mrad.toMinuteOfArc convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(600.<arcmin>, 174.533)>]
    [<TestCase(90.7<arcmin>, 26.38356)>]
    [<TestCase(1700.<arcmin>, 494.51)>]
    let ``Convert known Minute Of Arc to Milliradians`` (input, expectation) = 
        arcmin.toMilliradians input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Minute Of Arc to Seconds Of Arc and back`` () =
        let property value =
            let convertTo = arcmin.toSecondsOfArc (arcmin.create value)
            let convertBack = arcseconds.toMinuteOfArc convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<arcmin>, 54.)>]
    [<TestCase(70.<arcmin>, 4200.)>]
    [<TestCase(901.6<arcmin>, 54096.)>]
    let ``Convert known Minute Of Arc to Seconds Of Arc`` (input, expectation) = 
        arcmin.toSecondsOfArc input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Radians to Degrees and back`` () =
        let property value =
            let convertTo = rad.toDegrees (rad.create value)
            let convertBack = deg.toRadians convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.5<rad>, 257.831)>]
    [<TestCase(0.9<rad>, 51.5662)>]
    [<TestCase(78.9<rad>, 4520.637)>]
    let ``Convert known Radians to Degrees`` (input, expectation) = 
        rad.toDegrees input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Radians to Gradians and back`` () =
        let property value =
            let convertTo = rad.toGradians (rad.create value)
            let convertBack = grad.toRadians convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.<rad>, 318.31)>]
    [<TestCase(0.9<rad>, 57.2958)>]
    [<TestCase(89.<rad>, 5665.92)>]
    let ``Convert known Radians to Gradians`` (input, expectation) = 
        rad.toGradians input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Radians to Milliradians and back`` () =
        let property value =
            let convertTo = rad.toMilliradians (rad.create value)
            let convertBack = mrad.toRadians convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.<rad>, 5000.)>]
    [<TestCase(0.13<rad>, 130.)>]
    [<TestCase(0.13<rad>, 130.)>]
    [<TestCase(89.1<rad>, 89100.)>]
    let ``Convert known Radians to Milliradians`` (input, expectation) = 
        rad.toMilliradians input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Radians to Minute Of Arc and back`` () =
        let property value =
            let convertTo = rad.toMinuteOfArc (rad.create value)
            let convertBack = arcmin.toRadians convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.<rad>, 20626.480624709635)>]
    [<TestCase(0.8<rad>, 2750.2)>]
    [<TestCase(2.3<rad>, 7906.82)>]
    let ``Convert known Radians to Minute Of Arc`` (input, expectation) = 
        rad.toMinuteOfArc input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Radians to Seconds Of Arc and back`` () =
        let property value =
            let convertTo = rad.toSecondsOfArc (rad.create value)
            let convertBack = arcseconds.toRadians convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.8<rad>, 165011.84499767708)>]
    [<TestCase(0.001<rad>, 206.26481)>]
    [<TestCase(0.9<rad>, 185638.32562238674)>]
    let ``Convert known Radians to Seconds Of Arc`` (input, expectation) = 
        rad.toSecondsOfArc input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Seconds Of Arc to Degrees and back`` () =
        let property value =
            let convertTo = arcseconds.toDegrees (arcseconds.create value)
            let convertBack = deg.toSecondsOfArc convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.<arcseconds>, 0.25)>]
    [<TestCase(123.4<arcseconds>, 0.034277778)>]
    [<TestCase(8000.<arcseconds>, 2.222222)>]
    let ``Convert known Seconds Of Arc to Degrees`` (input, expectation) = 
        arcseconds.toDegrees input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Seconds Of Arc to Radians and back`` () =
        let property value =
            let convertTo = arcseconds.toRadians (arcseconds.create value)
            let convertBack = rad.toSecondsOfArc convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190000.<arcseconds>, 0.921145994)>]
    [<TestCase(88990.<arcseconds>, 0.43143569)>]
    [<TestCase(100000.<arcseconds>, 0.48481368)>]
    let ``Convert known Seconds Of Arc to Radians`` (input, expectation) = 
        arcseconds.toRadians input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Seconds Of Arc to Gradians and back`` () =
        let property value =
            let convertTo = arcseconds.toGradians (arcseconds.create value)
            let convertBack = grad.toSecondsOfArc convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1000.<arcseconds>, 0.308642)>]
    [<TestCase(809.<arcseconds>, 0.249691)>]
    [<TestCase(1567.9<arcseconds>, 0.483919761)>]
    let ``Convert known Seconds Of Arc to Gradians`` (input, expectation) = 
        arcseconds.toGradians input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Seconds Of Arc to Milliradians and back`` () =
        let property value =
            let convertTo = arcseconds.toMilliradians (arcseconds.create value)
            let convertBack = mrad.toSecondsOfArc convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1234.<arcseconds>, 5.982601)>]
    [<TestCase(909.<arcseconds>, 4.40696)>]
    [<TestCase(190009.<arcseconds>, 921.189627)>]
    let ``Convert known Seconds Of Arc to Milliradians`` (input, expectation) = 
        arcseconds.toMilliradians input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Seconds Of Arc to Minute Of Arc and back`` () =
        let property value =
            let convertTo = arcseconds.toMinuteOfArc (arcseconds.create value)
            let convertBack = arcmin.toSecondsOfArc convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100.<arcseconds>, 1.66667)>]
    [<TestCase(908.<arcseconds>, 15.1333)>]
    [<TestCase(8091.<arcseconds>, 134.85)>]
    let ``Convert known Seconds Of Arc to Minute Of Arc`` (input, expectation) = 
        arcseconds.toMinuteOfArc input
        |> should (equalWithin 0.01) expectation

