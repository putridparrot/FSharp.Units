namespace FSharp.Units.Tests

module PressureTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Pressure
    open Helpers


    [<Property>]
    let ``From Atmospheres to Bars and back`` () =
        let property value =
            let convertTo = atm.toBars (atm.create value)
            let convertBack = b.toAtmospheres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.0<atm>, 6.0795)>]
    [<TestCase(1.2<atm>, 1.2159)>]
    [<TestCase(0.8<atm>, 0.8106)>]
    let ``Convert known Atmospheres to Bars`` (input, expectation) = 
        atm.toBars input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Atmospheres to Pascals and back`` () =
        let property value =
            let convertTo = atm.toPascals (atm.create value)
            let convertBack = Pa.toAtmospheres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.8<atm>, 81060.0)>]
    [<TestCase(1.2<atm>, 121590.0)>]
    [<TestCase(0.45<atm>, 45596.25)>]
    let ``Convert known Atmospheres to Pascals`` (input, expectation) = 
        atm.toPascals input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Atmospheres to Torrs and back`` () =
        let property value =
            let convertTo = atm.toTorrs (atm.create value)
            let convertBack = Torr.toAtmospheres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.45<atm>, 342.0)>]
    [<TestCase(1.2<atm>, 912.0)>]
    [<TestCase(6.0<atm>, 4560.0)>]
    let ``Convert known Atmospheres to Torrs`` (input, expectation) = 
        atm.toTorrs input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Atmospheres to Psi and back`` () =
        let property value =
            let convertTo = atm.toPsi (atm.create value)
            let convertBack = psi.toAtmospheres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.0<atm>, 88.1757)>]
    [<TestCase(0.4<atm>, 5.87838)>]
    [<TestCase(1.2<atm>, 17.6351)>]
    let ``Convert known Atmospheres to Psi`` (input, expectation) = 
        atm.toPsi input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Bars to Atmospheres and back`` () =
        let property value =
            let convertTo = b.toAtmospheres (b.create value)
            let convertBack = atm.toBars convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(800.0<b>, 789.539)>]
    [<TestCase(123.0<b>, 121.392)>]
    [<TestCase(89.0<b>, 87.8362)>]
    let ``Convert known Bars to Atmospheres`` (input, expectation) = 
        b.toAtmospheres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Bars to Pascals and back`` () =
        let property value =
            let convertTo = b.toPascals (b.create value)
            let convertBack = Pa.toBars convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.89<b>, 89000.0)>]
    [<TestCase(0.01<b>, 1000.0)>]
    [<TestCase(0.123<b>, 12300.0)>]
    let ``Convert known Bars to Pascals`` (input, expectation) = 
        b.toPascals input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Bars to Torrs and back`` () =
        let property value =
            let convertTo = b.toTorrs (b.create value)
            let convertBack = Torr.toBars convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.123<b>, 92.257587)>]
    [<TestCase(2.0<b>, 1500.12)>]
    [<TestCase(8.9<b>, 6675.55)>]
    let ``Convert known Bars to Torrs`` (input, expectation) = 
        b.toTorrs input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Bars to Psi and back`` () =
        let property value =
            let convertTo = b.toPsi (b.create value)
            let convertBack = psi.toBars convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8.1<b>, 117.481)>]
    [<TestCase(1001.0<b>, 14518.29290)>]
    [<TestCase(6.0<b>, 87.0226)>]
    let ``Convert known Bars to Psi`` (input, expectation) = 
        b.toPsi input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pascals to Atmospheres and back`` () =
        let property value =
            let convertTo = Pa.toAtmospheres (Pa.create value)
            let convertBack = atm.toPascals convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(90000.0<Pa>, 0.88823094)>]
    [<TestCase(1234567.0<Pa>, 12.18422897)>]
    [<TestCase(204060.0<Pa>, 2.01391562)>]
    let ``Convert known Pascals to Atmospheres`` (input, expectation) = 
        Pa.toAtmospheres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pascals to Bars and back`` () =
        let property value =
            let convertTo = Pa.toBars (Pa.create value)
            let convertBack = b.toPascals convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(10000.0<Pa>, 0.1)>]
    [<TestCase(12345.0<Pa>, 0.12345)>]
    [<TestCase(80000.0<Pa>, 0.8)>]
    let ``Convert known Pascals to Bars`` (input, expectation) = 
        Pa.toBars input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pascals to Torrs and back`` () =
        let property value =
            let convertTo = Pa.toTorrs (Pa.create value)
            let convertBack = Torr.toPascals convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(80000.0<Pa>, 600.04935)>]
    [<TestCase(1234.0<Pa>, 9.255761)>]
    [<TestCase(80.0<Pa>, 0.600049)>]
    let ``Convert known Pascals to Torrs`` (input, expectation) = 
        Pa.toTorrs input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Pascals to Psi and back`` () =
        let property value =
            let convertTo = Pa.toPsi (Pa.create value)
            let convertBack = psi.toPascals convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(800.0<Pa>, 0.11603)>]
    [<TestCase(8670.0<Pa>, 1.257477)>]
    [<TestCase(1000.0<Pa>, 0.145038)>]
    let ``Convert known Pascals to Psi`` (input, expectation) = 
        Pa.toPsi input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Psi to Bars and back`` () =
        let property value =
            let convertTo = psi.toBars (psi.create value)
            let convertBack = b.toPsi convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<psi>, 62.0528)>]
    [<TestCase(134.0<psi>, 9.23897)>]
    [<TestCase(111.2<psi>, 7.6669701)>]
    let ``Convert known Psi to Bars`` (input, expectation) = 
        psi.toBars input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Psi to Pascals and back`` () =
        let property value =
            let convertTo = psi.toPascals (psi.create value)
            let convertBack = Pa.toPsi convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<psi>, 6205.28)>]
    [<TestCase(0.03<psi>, 206.8427)>]
    [<TestCase(2.0<psi>, 13789.5)>]
    let ``Convert known Psi to Pascals`` (input, expectation) = 
        psi.toPascals input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Psi to Atmospheres and back`` () =
        let property value =
            let convertTo = psi.toAtmospheres (psi.create value)
            let convertBack = atm.toPsi convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.0<psi>, 0.136092)>]
    [<TestCase(109.0<psi>, 7.41701)>]
    [<TestCase(8.0<psi>, 0.544368)>]
    let ``Convert known Psi to Atmospheres`` (input, expectation) = 
        psi.toAtmospheres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Psi to Torrs and back`` () =
        let property value =
            let convertTo = psi.toTorrs (psi.create value)
            let convertBack = Torr.toPsi convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.0<psi>, 310.29)>]
    [<TestCase(3.4<psi>, 175.831)>]
    [<TestCase(0.5<psi>, 25.8575)>]
    let ``Convert known Psi to Torrs`` (input, expectation) = 
        psi.toTorrs input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Torrs to Bars and back`` () =
        let property value =
            let convertTo = Torr.toBars (Torr.create value)
            let convertBack = b.toTorrs convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100.0<Torr>, 0.133322)>]
    [<TestCase(9000.1<Torr>, 11.9991465)>]
    [<TestCase(1234.0<Torr>, 1.645198)>]
    let ``Convert known Torrs to Bars`` (input, expectation) = 
        Torr.toBars input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Torrs to Pascals and back`` () =
        let property value =
            let convertTo = Torr.toPascals (Torr.create value)
            let convertBack = Pa.toTorrs convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190.0<Torr>, 25331.2499)>]
    [<TestCase(6.5<Torr>, 866.595)>]
    [<TestCase(3.4<Torr>, 453.296)>]
    let ``Convert known Torrs to Pascals`` (input, expectation) = 
        Torr.toPascals input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Torrs to Atmospheres and back`` () =
        let property value =
            let convertTo = Torr.toAtmospheres (Torr.create value)
            let convertBack = atm.toTorrs convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5678.0<Torr>, 7.471053)>]
    [<TestCase(100.0<Torr>, 0.131579)>]
    [<TestCase(4509.0<Torr>, 5.932895)>]
    let ``Convert known Torrs to Atmospheres`` (input, expectation) = 
        Torr.toAtmospheres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Torrs to Psi and back`` () =
        let property value =
            let convertTo = Torr.toPsi (Torr.create value)
            let convertBack = psi.toTorrs convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4500.0<Torr>, 87.01549)>]
    [<TestCase(1234.0<Torr>, 23.86158)>]
    [<TestCase(900.0<Torr>, 17.4031)>]
    let ``Convert known Torrs to Psi`` (input, expectation) = 
        Torr.toPsi input
        |> should (equalWithin 0.01) expectation
