namespace FSharp.Units.Tests

module EnergyTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Energy
    open Helpers


    [<Property>]
    let ``From Btu to Kilojoules and back`` () =
        let property value =
            let convertTo = btu.toKilojoules (btu.create value)
            let convertBack = kJ.toBtu convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100.0<btu>, 105.506)>]
    [<TestCase(987.65<btu>, 1042.03)>]
    [<TestCase(555666.0<btu>, 586258.6917293)>]
    let ``Convert known Btu to Kilojoules`` (input, expectation) = 
        btu.toKilojoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Btu to Kilocalories and back`` () =
        let property value =
            let convertTo = btu.toKilocalories (btu.create value)
            let convertBack = kCal.toBtu convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(67.9<btu>, 17.12196)>]
    [<TestCase(109.9<btu>, 27.712868)>]
    [<TestCase(5000.0<btu>, 1260.716)>]
    let ``Convert known Btu to Kilocalories`` (input, expectation) = 
        btu.toKilocalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Btu to Joules and back`` () =
        let property value =
            let convertTo = btu.toJoules (btu.create value)
            let convertBack = J.toBtu convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.0<btu>, 5275.3)>]
    [<TestCase(912.9<btu>, 963164.274)>]
    [<TestCase(109.0<btu>, 115001.54)>]
    let ``Convert known Btu to Joules`` (input, expectation) = 
        btu.toJoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Btu to Calories and back`` () =
        let property value =
            let convertTo = btu.toCalories (btu.create value)
            let convertBack = cal.toBtu convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(56.0<btu>, 14121.184)>]
    [<TestCase(123.0<btu>, 31016.172)>]
    [<TestCase(0.9<btu>, 226.9476)>]
    let ``Convert known Btu to Calories`` (input, expectation) = 
        btu.toCalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Btu to US Therms and back`` () =
        let property value =
            let convertTo = btu.toUSTherms (btu.create value)
            let convertBack = ustherm.toBtu convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12000.0<btu>, 0.120028657)>]
    [<TestCase(9876.5<btu>, 0.098788586)>]
    [<TestCase(666.999<btu>, 0.006671583)>]
    let ``Convert known Btu to US Therms`` (input, expectation) = 
        btu.toUSTherms input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Btu to Watt Hours and back`` () =
        let property value =
            let convertTo = btu.toWattHours (btu.create value)
            let convertBack = Wh.toBtu convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<btu>, 263.764)>]
    [<TestCase(125.7<btu>, 36.839034)>]
    [<TestCase(0.99<btu>, 0.2901404)>]
    let ``Convert known Btu to Watt Hours`` (input, expectation) = 
        btu.toWattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Btu to Kilowatt Hours and back`` () =
        let property value =
            let convertTo = btu.toKilowattHours (btu.create value)
            let convertBack = kWh.toBtu convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9000.0<btu>, 2.63764)>]
    [<TestCase(12345.0<btu>, 3.6179624)>]
    [<TestCase(8090.8<btu>, 2.37117941)>]
    let ``Convert known Btu to Kilowatt Hours`` (input, expectation) = 
        btu.toKilowattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Btu to Foot Pounds and back`` () =
        let property value =
            let convertTo = btu.toFootPounds (btu.create value)
            let convertBack = ftlb.toBtu convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(189.0<btu>, 147073.9409)>]
    [<TestCase(0.3<btu>, 233.451)>]
    [<TestCase(2.6<btu>, 2023.24)>]
    let ``Convert known Btu to Foot Pounds`` (input, expectation) = 
        btu.toFootPounds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Calories to Kilojoules and back`` () =
        let property value =
            let convertTo = cal.toKilojoules (cal.create value)
            let convertBack = kJ.toCalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<cal>, 0.456056)>]
    [<TestCase(12.3<cal>, 0.0514632)>]
    [<TestCase(9876.0<cal>, 41.32118)>]
    let ``Convert known Calories to Kilojoules`` (input, expectation) = 
        cal.toKilojoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Calories to Kilocalories and back`` () =
        let property value =
            let convertTo = cal.toKilocalories (cal.create value)
            let convertBack = kCal.toCalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<cal>, 0.9)>]
    [<TestCase(1782.0<cal>, 1.782)>]
    [<TestCase(900800.0<cal>, 900.8)>]
    let ``Convert known Calories to Kilocalories`` (input, expectation) = 
        cal.toKilocalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Calories to Joules and back`` () =
        let property value =
            let convertTo = cal.toJoules (cal.create value)
            let convertBack = J.toCalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(98.0<cal>, 410.032)>]
    [<TestCase(1.67<cal>, 6.98728)>]
    [<TestCase(55.0<cal>, 230.12)>]
    let ``Convert known Calories to Joules`` (input, expectation) = 
        cal.toJoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Calories to Btu and back`` () =
        let property value =
            let convertTo = cal.toBtu (cal.create value)
            let convertBack = btu.toCalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(550.0<cal>, 2.18112)>]
    [<TestCase(1234.0<cal>, 4.893633)>]
    [<TestCase(900.9<cal>, 3.5726692)>]
    let ``Convert known Calories to Btu`` (input, expectation) = 
        cal.toBtu input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Calories to US Therms and back`` () =
        let property value =
            let convertTo = cal.toUSTherms (cal.create value)
            let convertBack = ustherm.toCalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9000000.0<cal>, 0.356995242)>]
    [<TestCase(12e6<cal>, 0.475993657)>]
    [<TestCase(100200300.0<cal>, 3.974558932)>]
    let ``Convert known Calories to US Therms`` (input, expectation) = 
        cal.toUSTherms input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Calories to Watt Hours and back`` () =
        let property value =
            let convertTo = cal.toWattHours (cal.create value)
            let convertBack = Wh.toCalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(600.0<cal>, 0.697333)>]
    [<TestCase(1234.5<cal>, 1.43476333)>]
    [<TestCase(88.7<cal>, 0.1030891)>]
    let ``Convert known Calories to Watt Hours`` (input, expectation) = 
        cal.toWattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Calories to Kilowatt Hours and back`` () =
        let property value =
            let convertTo = cal.toKilowattHours (cal.create value)
            let convertBack = kWh.toCalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100900.0<cal>, 0.117268222)>]
    [<TestCase(987654.0<cal>, 1.14787343)>]
    [<TestCase(506012.0<cal>, 0.588098391)>]
    let ``Convert known Calories to Kilowatt Hours`` (input, expectation) = 
        cal.toKilowattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Calories to Foot Pounds and back`` () =
        let property value =
            let convertTo = cal.toFootPounds (cal.create value)
            let convertBack = ftlb.toCalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.0<cal>, 379.573)>]
    [<TestCase(9.01<cal>, 27.8045)>]
    [<TestCase(2.8<cal>, 8.64069)>]
    let ``Convert known Calories to Foot Pounds`` (input, expectation) = 
        cal.toFootPounds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Foot Pounds to Kilojoules and back`` () =
        let property value =
            let convertTo = ftlb.toKilojoules (ftlb.create value)
            let convertBack = kJ.toFootPounds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190.0<ftlb>, 0.257605)>]
    [<TestCase(4.6<ftlb>, 0.00623676)>]
    [<TestCase(123.8<ftlb>, 0.16785026)>]
    let ``Convert known Foot Pounds to Kilojoules`` (input, expectation) = 
        ftlb.toKilojoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Foot Pounds to Kilocalories and back`` () =
        let property value =
            let convertTo = ftlb.toKilocalories (ftlb.create value)
            let convertBack = kCal.toFootPounds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1999.0<ftlb>, 0.6477725)>]
    [<TestCase(890.8<ftlb>, 0.2886622)>]
    [<TestCase(12000.0<ftlb>, 3.8885792)>]
    let ``Convert known Foot Pounds to Kilocalories`` (input, expectation) = 
        ftlb.toKilocalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Foot Pounds to Joules and back`` () =
        let property value =
            let convertTo = ftlb.toJoules (ftlb.create value)
            let convertBack = J.toFootPounds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190.0<ftlb>, 257.605)>]
    [<TestCase(23.4<ftlb>, 31.72614)>]
    [<TestCase(9.2<ftlb>, 12.4735)>]
    let ``Convert known Foot Pounds to Joules`` (input, expectation) = 
        ftlb.toJoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Foot Pounds to Btu and back`` () =
        let property value =
            let convertTo = ftlb.toBtu (ftlb.create value)
            let convertBack = btu.toFootPounds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9000.0<ftlb>, 11.56561)>]
    [<TestCase(45.6<ftlb>, 0.05859908)>]
    [<TestCase(1996.0<ftlb>, 2.564995)>]
    let ``Convert known Foot Pounds to Btu`` (input, expectation) = 
        ftlb.toBtu input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Foot Pounds to Calories and back`` () =
        let property value =
            let convertTo = ftlb.toCalories (ftlb.create value)
            let convertBack = cal.toFootPounds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.0<ftlb>, 39.8579)>]
    [<TestCase(54.7<ftlb>, 17.72544)>]
    [<TestCase(109.2<ftlb>, 35.386071)>]
    let ``Convert known Foot Pounds to Calories`` (input, expectation) = 
        ftlb.toCalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Foot Pounds to US Therms and back`` () =
        let property value =
            let convertTo = ftlb.toUSTherms (ftlb.create value)
            let convertBack = ustherm.toFootPounds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(19000000.0<ftlb>, 0.24422111613)>]
    [<TestCase(1234567.0<ftlb>, 0.01586880688)>]
    [<TestCase(100200300.0<ftlb>, 1.28794890016)>]
    let ``Convert known Foot Pounds to US Therms`` (input, expectation) = 
        ftlb.toUSTherms input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Foot Pounds to Watt Hours and back`` () =
        let property value =
            let convertTo = ftlb.toWattHours (ftlb.create value)
            let convertBack = Wh.toFootPounds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(44.0<ftlb>, 0.0165711)>]
    [<TestCase(9080.0<ftlb>, 3.419674)>]
    [<TestCase(1200.0<ftlb>, 0.4519393)>]
    let ``Convert known Foot Pounds to Watt Hours`` (input, expectation) = 
        ftlb.toWattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Foot Pounds to Kilowatt Hours and back`` () =
        let property value =
            let convertTo = ftlb.toKilowattHours (ftlb.create value)
            let convertBack = kWh.toFootPounds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900000.0<ftlb>, 0.338954487)>]
    [<TestCase(100200.0<ftlb>, 0.0377369329)>]
    [<TestCase(9876543.0<ftlb>, 3.719665074)>]
    let ``Convert known Foot Pounds to Kilowatt Hours`` (input, expectation) = 
        ftlb.toKilowattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Joules to Kilojoules and back`` () =
        let property value =
            let convertTo = J.toKilojoules (J.create value)
            let convertBack = kJ.toJoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(790.0<J>, 0.79)>]
    [<TestCase(800100.0<J>, 800.1)>]
    [<TestCase(509.2<J>, 0.5092)>]
    let ``Convert known Joules to Kilojoules`` (input, expectation) = 
        J.toKilojoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Joules to Kilocalories and back`` () =
        let property value =
            let convertTo = J.toKilocalories (J.create value)
            let convertBack = kCal.toJoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(790.0<J>, 0.188815)>]
    [<TestCase(125.9<J>, 0.030090822)>]
    [<TestCase(8000.0<J>, 1.912046)>]
    let ``Convert known Joules to Kilocalories`` (input, expectation) = 
        J.toKilocalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Joules to Btu and back`` () =
        let property value =
            let convertTo = J.toBtu (J.create value)
            let convertBack = btu.toJoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(500.0<J>, 0.473909)>]
    [<TestCase(1910.0<J>, 1.810331)>]
    [<TestCase(67000.1<J>, 63.50384184)>]
    let ``Convert known Joules to Btu`` (input, expectation) = 
        J.toBtu input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Joules to Calories and back`` () =
        let property value =
            let convertTo = J.toCalories (J.create value)
            let convertBack = cal.toJoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(67.0<J>, 16.0134)>]
    [<TestCase(909.0<J>, 217.256)>]
    [<TestCase(190.0<J>, 45.4111)>]
    let ``Convert known Joules to Calories`` (input, expectation) = 
        J.toCalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Joules to US Therms and back`` () =
        let property value =
            let convertTo = J.toUSTherms (J.create value)
            let convertBack = ustherm.toJoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100090000.0<J>, 0.948896667059)>]
    [<TestCase(55.7e6<J>, 0.52806018938)>]
    [<TestCase(1234567890.0<J>, 11.70423974501)>]
    let ``Convert known Joules to US Therms`` (input, expectation) = 
        J.toUSTherms input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Joules to Watt Hours and back`` () =
        let property value =
            let convertTo = J.toWattHours (J.create value)
            let convertBack = Wh.toJoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(56000.0<J>, 15.555556)>]
    [<TestCase(890.0<J>, 0.247222)>]
    [<TestCase(22001.0<J>, 6.1113889)>]
    let ``Convert known Joules to Watt Hours`` (input, expectation) = 
        J.toWattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Joules to Kilowatt Hours and back`` () =
        let property value =
            let convertTo = J.toKilowattHours (J.create value)
            let convertBack = kWh.toJoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(560000.8<J>, 0.1555557)>]
    [<TestCase(1234567.0<J>, 0.3429352778)>]
    [<TestCase(900100.0<J>, 0.250027778)>]
    let ``Convert known Joules to Kilowatt Hours`` (input, expectation) = 
        J.toKilowattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Joules to Foot Pounds and back`` () =
        let property value =
            let convertTo = J.toFootPounds (J.create value)
            let convertBack = ftlb.toJoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<J>, 663.806)>]
    [<TestCase(10.2<J>, 7.523134)>]
    [<TestCase(6.7<J>, 4.94167)>]
    let ``Convert known Joules to Foot Pounds`` (input, expectation) = 
        J.toFootPounds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilocalories to Kilojoules and back`` () =
        let property value =
            let convertTo = kCal.toKilojoules (kCal.create value)
            let convertBack = kJ.toKilocalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(67.0<kCal>, 280.328)>]
    [<TestCase(4.5<kCal>, 18.828)>]
    [<TestCase(100.3<kCal>, 419.6552)>]
    let ``Convert known Kilocalories to Kilojoules`` (input, expectation) = 
        kCal.toKilojoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilocalories to Joules and back`` () =
        let property value =
            let convertTo = kCal.toJoules (kCal.create value)
            let convertBack = J.toKilocalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100.3<kCal>, 419655.2)>]
    [<TestCase(0.9<kCal>, 3765.6)>]
    [<TestCase(3.4<kCal>, 14225.6)>]
    let ``Convert known Kilocalories to Joules`` (input, expectation) = 
        kCal.toJoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilocalories to Btu and back`` () =
        let property value =
            let convertTo = kCal.toBtu (kCal.create value)
            let convertBack = btu.toKilocalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.4<kCal>, 13.4833)>]
    [<TestCase(109.0<kCal>, 432.2940)>]
    [<TestCase(22.89<kCal>, 90.774114)>]
    let ``Convert known Kilocalories to Btu`` (input, expectation) = 
        kCal.toBtu input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilocalories to Calories and back`` () =
        let property value =
            let convertTo = kCal.toCalories (kCal.create value)
            let convertBack = cal.toKilocalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(22.8<kCal>, 22800.0)>]
    [<TestCase(76.23<kCal>, 76230.0)>]
    [<TestCase(0.07<kCal>, 70.0)>]
    let ``Convert known Kilocalories to Calories`` (input, expectation) = 
        kCal.toCalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilocalories to US Therms and back`` () =
        let property value =
            let convertTo = kCal.toUSTherms (kCal.create value)
            let convertBack = ustherm.toKilocalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12345.0<kCal>, 0.4896388)>]
    [<TestCase(90002.0<kCal>, 3.5700317)>]
    [<TestCase(180180.0<kCal>, 7.14704457)>]
    let ``Convert known Kilocalories to US Therms`` (input, expectation) = 
        kCal.toUSTherms input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilocalories to Watt Hours and back`` () =
        let property value =
            let convertTo = kCal.toWattHours (kCal.create value)
            let convertBack = Wh.toKilocalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(89.0<kCal>, 103.438)>]
    [<TestCase(23.6<kCal>, 27.42844)>]
    [<TestCase(0.9<kCal>, 1.046)>]
    let ``Convert known Kilocalories to Watt Hours`` (input, expectation) = 
        kCal.toWattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilocalories to Kilowatt Hours and back`` () =
        let property value =
            let convertTo = kCal.toKilowattHours (kCal.create value)
            let convertBack = kWh.toKilocalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(456.0<kCal>, 0.529973)>]
    [<TestCase(1090.8<kCal>, 1.267752)>]
    [<TestCase(567.1<kCal>, 0.65909622)>]
    let ``Convert known Kilocalories to Kilowatt Hours`` (input, expectation) = 
        kCal.toKilowattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilocalories to Foot Pounds and back`` () =
        let property value =
            let convertTo = kCal.toFootPounds (kCal.create value)
            let convertBack = ftlb.toKilocalories convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<kCal>, 336369.64)>]
    [<TestCase(0.5<kCal>, 1542.98)>]
    [<TestCase(2.4<kCal>, 7406.3)>]
    let ``Convert known Kilocalories to Foot Pounds`` (input, expectation) = 
        kCal.toFootPounds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilojoules to Kilocalories and back`` () =
        let property value =
            let convertTo = kJ.toKilocalories (kJ.create value)
            let convertBack = kCal.toKilojoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(199.0<kJ>, 47.5621)>]
    [<TestCase(0.67<kJ>, 0.1601338)>]
    [<TestCase(4.7<kJ>, 1.12333)>]
    let ``Convert known Kilojoules to Kilocalories`` (input, expectation) = 
        kJ.toKilocalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilojoules to Joules and back`` () =
        let property value =
            let convertTo = kJ.toJoules (kJ.create value)
            let convertBack = J.toKilojoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.7<kJ>, 4700.0)>]
    [<TestCase(7.8<kJ>, 7800.0)>]
    [<TestCase(1800.0<kJ>, 1800000.0)>]
    let ``Convert known Kilojoules to Joules`` (input, expectation) = 
        kJ.toJoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilojoules to Btu and back`` () =
        let property value =
            let convertTo = kJ.toBtu (kJ.create value)
            let convertBack = btu.toKilojoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1800.0<kJ>, 1706.070)>]
    [<TestCase(1.4<kJ>, 1.32694)>]
    [<TestCase(89.2<kJ>, 84.54529)>]
    let ``Convert known Kilojoules to Btu`` (input, expectation) = 
        kJ.toBtu input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilojoules to Calories and back`` () =
        let property value =
            let convertTo = kJ.toCalories (kJ.create value)
            let convertBack = cal.toKilojoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(67.0<kJ>, 16013.381899)>]
    [<TestCase(1.4<kJ>, 334.608)>]
    [<TestCase(87.0<kJ>, 20793.5)>]
    let ``Convert known Kilojoules to Calories`` (input, expectation) = 
        kJ.toCalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilojoules to US Therms and back`` () =
        let property value =
            let convertTo = kJ.toUSTherms (kJ.create value)
            let convertBack = ustherm.toKilojoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123456.0<kJ>, 1.17041649)>]
    [<TestCase(88000.0<kJ>, 0.83427822)>]
    [<TestCase(9000.0<kJ>, 0.08532391)>]
    let ``Convert known Kilojoules to US Therms`` (input, expectation) = 
        kJ.toUSTherms input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilojoules to Watt Hours and back`` () =
        let property value =
            let convertTo = kJ.toWattHours (kJ.create value)
            let convertBack = Wh.toKilojoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(98000.0<kJ>, 27222.222)>]
    [<TestCase(1.5<kJ>, 0.416667)>]
    [<TestCase(67.9<kJ>, 18.86111)>]
    let ``Convert known Kilojoules to Watt Hours`` (input, expectation) = 
        kJ.toWattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilojoules to Kilowatt Hours and back`` () =
        let property value =
            let convertTo = kJ.toKilowattHours (kJ.create value)
            let convertBack = kWh.toKilojoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8000.0<kJ>, 2.222222)>]
    [<TestCase(67.99<kJ>, 0.018886111)>]
    [<TestCase(406.8<kJ>, 0.113)>]
    let ``Convert known Kilojoules to Kilowatt Hours`` (input, expectation) = 
        kJ.toKilowattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilojoules to Foot Pounds and back`` () =
        let property value =
            let convertTo = kJ.toFootPounds (kJ.create value)
            let convertBack = ftlb.toKilojoules convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100.9<kJ>, 74420.00579)>]
    [<TestCase(2.4<kJ>, 1770.15)>]
    [<TestCase(0.9<kJ>, 663.806)>]
    let ``Convert known Kilojoules to Foot Pounds`` (input, expectation) = 
        kJ.toFootPounds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilowatt Hours to Kilojoules and back`` () =
        let property value =
            let convertTo = kWh.toKilojoules (kWh.create value)
            let convertBack = kJ.toKilowattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.6<kWh>, 2160.0)>]
    [<TestCase(134.0<kWh>, 482400.0)>]
    [<TestCase(45.6<kWh>, 164160.0)>]
    let ``Convert known Kilowatt Hours to Kilojoules`` (input, expectation) = 
        kWh.toKilojoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilowatt Hours to Kilocalories and back`` () =
        let property value =
            let convertTo = kWh.toKilocalories (kWh.create value)
            let convertBack = kCal.toKilowattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(45.6<kWh>, 39235.1976)>]
    [<TestCase(12.0<kWh>, 10325.052)>]
    [<TestCase(0.4<kWh>, 344.168)>]
    let ``Convert known Kilowatt Hours to Kilocalories`` (input, expectation) = 
        kWh.toKilocalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilowatt Hours to Joules and back`` () =
        let property value =
            let convertTo = kWh.toJoules (kWh.create value)
            let convertBack = J.toKilowattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.01<kWh>, 36000.0)>]
    [<TestCase(0.009<kWh>, 32400.0)>]
    [<TestCase(2.0<kWh>, 7.2e+6)>]
    let ``Convert known Kilowatt Hours to Joules`` (input, expectation) = 
        kWh.toJoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilowatt Hours to Btu and back`` () =
        let property value =
            let convertTo = kWh.toBtu (kWh.create value)
            let convertBack = btu.toKilowattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.0<kWh>, 6824.28)>]
    [<TestCase(0.7<kWh>, 2388.4979)>]
    [<TestCase(0.02<kWh>, 68.24283)>]
    let ``Convert known Kilowatt Hours to Btu`` (input, expectation) = 
        kWh.toBtu input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilowatt Hours to Calories and back`` () =
        let property value =
            let convertTo = kWh.toCalories (kWh.create value)
            let convertBack = cal.toKilowattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.1<kWh>, 86042.1)>]
    [<TestCase(0.07<kWh>, 60229.47)>]
    [<TestCase(0.0123<kWh>, 10583.174)>]
    let ``Convert known Kilowatt Hours to Calories`` (input, expectation) = 
        kWh.toCalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilowatt Hours to US Therms and back`` () =
        let property value =
            let convertTo = kWh.toUSTherms (kWh.create value)
            let convertBack = ustherm.toKilowattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.0<kWh>, 0.170648)>]
    [<TestCase(234.0<kWh>, 7.98632)>]
    [<TestCase(1001.0<kWh>, 34.16369)>]
    let ``Convert known Kilowatt Hours to US Therms`` (input, expectation) = 
        kWh.toUSTherms input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilowatt Hours to Watt Hours and back`` () =
        let property value =
            let convertTo = kWh.toWattHours (kWh.create value)
            let convertBack = Wh.toKilowattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.0<kWh>, 123000.0)>]
    [<TestCase(98.4<kWh>, 98400.0)>]
    [<TestCase(1.6<kWh>, 1600.0)>]
    let ``Convert known Kilowatt Hours to Watt Hours`` (input, expectation) = 
        kWh.toWattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kilowatt Hours to Foot Pounds and back`` () =
        let property value =
            let convertTo = kWh.toFootPounds (kWh.create value)
            let convertBack = ftlb.toKilowattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.001<kWh>, 2655.196219)>]
    [<TestCase(0.09<kWh>, 238967.6597)>]
    [<TestCase(0.0006<kWh>, 1593.1177314)>]
    let ``Convert known Kilowatt Hours to Foot Pounds`` (input, expectation) = 
        kWh.toFootPounds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Therms to Kilojoules and back`` () =
        let property value =
            let convertTo = ustherm.toKilojoules (ustherm.create value)
            let convertBack = kJ.toUSTherms convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.009<ustherm>, 949.3236)>]
    [<TestCase(3.0<ustherm>, 316440.12)>]
    [<TestCase(1.9<ustherm>, 200412.075)>]
    let ``Convert known US Therms to Kilojoules`` (input, expectation) = 
        ustherm.toKilojoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Therms to Kilocalories and back`` () =
        let property value =
            let convertTo = ustherm.toKilocalories (ustherm.create value)
            let convertBack = kCal.toUSTherms convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.1<ustherm>, 27731.44)>]
    [<TestCase(0.04<ustherm>, 1008.417)>]
    [<TestCase(0.0123<ustherm>, 310.088174)>]
    let ``Convert known US Therms to Kilocalories`` (input, expectation) = 
        ustherm.toKilocalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Therms to Joules and back`` () =
        let property value =
            let convertTo = ustherm.toJoules (ustherm.create value)
            let convertBack = J.toUSTherms convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.008<ustherm>, 843843.2)>]
    [<TestCase(3.4e-6<ustherm>, 358.633)>]
    [<TestCase(0.00678<ustherm>, 715157.112)>]
    let ``Convert known US Therms to Joules`` (input, expectation) = 
        ustherm.toJoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Therms to Btu and back`` () =
        let property value =
            let convertTo = ustherm.toBtu (ustherm.create value)
            let convertBack = btu.toUSTherms convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.00666<ustherm>, 665.8409891)>]
    [<TestCase(2.0<ustherm>, 199952.249)>]
    [<TestCase(0.9<ustherm>, 89978.51204)>]
    let ``Convert known US Therms to Btu`` (input, expectation) = 
        ustherm.toBtu input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Therms to Calories and back`` () =
        let property value =
            let convertTo = ustherm.toCalories (ustherm.create value)
            let convertBack = cal.toUSTherms convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.003<ustherm>, 75631.262)>]
    [<TestCase(6.8e-3<ustherm>, 171430.856)>]
    [<TestCase(0.0008<ustherm>, 20168.3365)>]
    let ``Convert known US Therms to Calories`` (input, expectation) = 
        ustherm.toCalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Therms to Watt Hours and back`` () =
        let property value =
            let convertTo = ustherm.toWattHours (ustherm.create value)
            let convertBack = Wh.toUSTherms convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.0<ustherm>, 175800.59)>]
    [<TestCase(1.9<ustherm>, 55670.189)>]
    [<TestCase(0.07<ustherm>, 2051.008)>]
    let ``Convert known US Therms to Watt Hours`` (input, expectation) = 
        ustherm.toWattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Therms to Kilowatt Hours and back`` () =
        let property value =
            let convertTo = ustherm.toKilowattHours (ustherm.create value)
            let convertBack = kWh.toUSTherms convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<ustherm>, 26.3701)>]
    [<TestCase(7.9<ustherm>, 231.471)>]
    [<TestCase(1.4<ustherm>, 41.0202)>]
    let ``Convert known US Therms to Kilowatt Hours`` (input, expectation) = 
        ustherm.toKilowattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From US Therms to Foot Pounds and back`` () =
        let property value =
            let convertTo = ustherm.toFootPounds (ustherm.create value)
            let convertBack = ftlb.toUSTherms convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.009<ustherm>, 700352.43389267)>]
    [<TestCase(0.02<ustherm>, 1556338.74198)>]
    [<TestCase(0.0003<ustherm>, 23345.081129)>]
    let ``Convert known US Therms to Foot Pounds`` (input, expectation) = 
        ustherm.toFootPounds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Watt Hours to Kilojoules and back`` () =
        let property value =
            let convertTo = Wh.toKilojoules (Wh.create value)
            let convertBack = kJ.toWattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.6<Wh>, 5.76)>]
    [<TestCase(67.0<Wh>, 241.2)>]
    [<TestCase(8.12<Wh>, 29.232)>]
    let ``Convert known Watt Hours to Kilojoules`` (input, expectation) = 
        Wh.toKilojoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Watt Hours to Kilocalories and back`` () =
        let property value =
            let convertTo = Wh.toKilocalories (Wh.create value)
            let convertBack = kCal.toWattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8.12<Wh>, 6.986616)>]
    [<TestCase(170.0<Wh>, 146.272)>]
    [<TestCase(19.2<Wh>, 16.52008)>]
    let ``Convert known Watt Hours to Kilocalories`` (input, expectation) = 
        Wh.toKilocalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Watt Hours to Joules and back`` () =
        let property value =
            let convertTo = Wh.toJoules (Wh.create value)
            let convertBack = J.toWattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.7<Wh>, 24120.0)>]
    [<TestCase(12.34<Wh>, 44424.0)>]
    [<TestCase(0.09<Wh>, 324.0)>]
    let ``Convert known Watt Hours to Joules`` (input, expectation) = 
        Wh.toJoules input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Watt Hours to Btu and back`` () =
        let property value =
            let convertTo = Wh.toBtu (Wh.create value)
            let convertBack = btu.toWattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(34.0<Wh>, 116.013)>]
    [<TestCase(179.2<Wh>, 611.45578)>]
    [<TestCase(0.9<Wh>, 3.07093)>]
    let ``Convert known Watt Hours to Btu`` (input, expectation) = 
        Wh.toBtu input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Watt Hours to Calories and back`` () =
        let property value =
            let convertTo = Wh.toCalories (Wh.create value)
            let convertBack = cal.toWattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.2<Wh>, 172.084)>]
    [<TestCase(0.09<Wh>, 77.43786)>]
    [<TestCase(12.0<Wh>, 10325.06754)>]
    let ``Convert known Watt Hours to Calories`` (input, expectation) = 
        Wh.toCalories input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Watt Hours to US Therms and back`` () =
        let property value =
            let convertTo = Wh.toUSTherms (Wh.create value)
            let convertBack = ustherm.toWattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1090.0<Wh>, 0.03720122)>]
    [<TestCase(49990.0<Wh>, 1.7061369)>]
    [<TestCase(900800.0<Wh>, 30.7439107)>]
    let ``Convert known Watt Hours to US Therms`` (input, expectation) = 
        Wh.toUSTherms input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Watt Hours to Kilowatt Hours and back`` () =
        let property value =
            let convertTo = Wh.toKilowattHours (Wh.create value)
            let convertBack = kWh.toWattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(98.0<Wh>, 0.098)>]
    [<TestCase(12.5<Wh>, 0.0125)>]
    [<TestCase(0.6<Wh>, 0.0006)>]
    let ``Convert known Watt Hours to Kilowatt Hours`` (input, expectation) = 
        Wh.toKilowattHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Watt Hours to Foot Pounds and back`` () =
        let property value =
            let convertTo = Wh.toFootPounds (Wh.create value)
            let convertBack = ftlb.toWattHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.5<Wh>, 3982.829)>]
    [<TestCase(0.3<Wh>, 796.567)>]
    [<TestCase(90.1<Wh>, 239235.3219)>]
    let ``Convert known Watt Hours to Foot Pounds`` (input, expectation) = 
        Wh.toFootPounds input
        |> should (equalWithin 0.01) expectation

