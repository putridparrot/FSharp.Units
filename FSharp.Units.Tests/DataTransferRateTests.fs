namespace FSharp.Units.Tests

module DataTransferRateTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.DataTransferRate
    open Helpers


    [<Property>]
    let ``From Bits Per Second to KiloBits Per Second and back`` () =
        let property value =
            let convertTo = bps.toKiloBitsPerSecond (bps.create value)
            let convertBack = kbps.toBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100.0<bps>, 0.1)>]
    [<TestCase(6021.0<bps>, 6.021)>]
    [<TestCase(9100.0<bps>, 9.1)>]
    let ``Convert known Bits Per Second to KiloBits Per Second`` (input, expectation) = 
        bps.toKiloBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Bits Per Second to MegaBits Per Second and back`` () =
        let property value =
            let convertTo = bps.toMegaBitsPerSecond (bps.create value)
            let convertBack = Mbps.toBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9000000.0<bps>, 9.0)>]
    [<TestCase(123456.0<bps>, 0.123456)>]
    [<TestCase(1900000.0<bps>, 1.9)>]
    let ``Convert known Bits Per Second to MegaBits Per Second`` (input, expectation) = 
        bps.toMegaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Bits Per Second to GigaBits Per Second and back`` () =
        let property value =
            let convertTo = bps.toGigaBitsPerSecond (bps.create value)
            let convertBack = Gbps.toBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190000000.0<bps>, 0.19)>]
    [<TestCase(8009.0<bps>, 8.009e-6)>]
    [<TestCase(987654321.0<bps>, 0.987654321)>]
    let ``Convert known Bits Per Second to GigaBits Per Second`` (input, expectation) = 
        bps.toGigaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Bits Per Second to TeraBits Per Second and back`` () =
        let property value =
            let convertTo = bps.toTeraBitsPerSecond (bps.create value)
            let convertBack = Tbps.toBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(987654321234.0<bps>, 0.987654321234)>]
    [<TestCase(1234567890123456.0<bps>, 1234.567890123455982)>]
    [<TestCase(999888777666555.0<bps>, 999.888777666555029)>]
    let ``Convert known Bits Per Second to TeraBits Per Second`` (input, expectation) = 
        bps.toTeraBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Bits Per Second to KiloBytes Per Second and back`` () =
        let property value =
            let convertTo = bps.toKiloBytesPerSecond (bps.create value)
            let convertBack = kBps.toBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<bps>, 0.1125)>]
    [<TestCase(12345.0<bps>, 1.543125)>]
    [<TestCase(6000.9<bps>, 0.7501125)>]
    let ``Convert known Bits Per Second to KiloBytes Per Second`` (input, expectation) = 
        bps.toKiloBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Bits Per Second to MegaBytes Per Second and back`` () =
        let property value =
            let convertTo = bps.toMegaBytesPerSecond (bps.create value)
            let convertBack = MBps.toBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123456.<bps>, 0.015432)>]
    [<TestCase(900800.0<bps>, 0.1126)>]
    [<TestCase(999888777.0<bps>, 124.986097125)>]
    let ``Convert known Bits Per Second to MegaBytes Per Second`` (input, expectation) = 
        bps.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Bits Per Second to GigaBytes Per Second and back`` () =
        let property value =
            let convertTo = bps.toGigaBytesPerSecond (bps.create value)
            let convertBack = GBps.toBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(999888777.0<bps>, 0.124986097125)>]
    [<TestCase(1.9e+9<bps>, 0.2375)>]
    [<TestCase(80090077.0<bps>, 0.010011259625)>]
    let ``Convert known Bits Per Second to GigaBytes Per Second`` (input, expectation) = 
        bps.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Bits Per Second to TeraBytes Per Second and back`` () =
        let property value =
            let convertTo = bps.toTeraBytesPerSecond (bps.create value)
            let convertBack = TBps.toBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(999888777666.0<bps>, 0.12498609720825)>]
    [<TestCase(12345678912345.0<bps>, 1.5432098640431251)>]
    [<TestCase(111999222888333.0<bps>, 13.9999028610416243)>]
    let ``Convert known Bits Per Second to TeraBytes Per Second`` (input, expectation) = 
        bps.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Bits Per Second to Kibibits Per Second and back`` () =
        let property value =
            let convertTo = bps.toKibibitsPerSecond (bps.create value)
            let convertBack = Kibitps.toBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1800.0<bps>, 1.757813)>]
    [<TestCase(888.0<bps>, 0.867188)>]
    [<TestCase(7687.0<bps>, 7.506836)>]
    let ``Convert known Bits Per Second to Kibibits Per Second`` (input, expectation) = 
        bps.toKibibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Bits Per Second to Mebibits Per Second and back`` () =
        let property value =
            let convertTo = bps.toMebibitsPerSecond (bps.create value)
            let convertBack = Mibit.toBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(999888.0<bps>, 0.953567505)>]
    [<TestCase(1234567.0<bps>, 1.17737484)>]
    [<TestCase(900800.0<bps>, 0.859069824)>]
    let ``Convert known Bits Per Second to Mebibits Per Second`` (input, expectation) = 
        bps.toMebibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBits Per Second to Bits Per Second and back`` () =
        let property value =
            let convertTo = Gbps.toBitsPerSecond (Gbps.create value)
            let convertBack = bps.toGigaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.0009<Gbps>, 900000.0)>]
    [<TestCase(0.00007<Gbps>, 70000.0)>]
    [<TestCase(1.2e-5<Gbps>, 12000.0)>]
    let ``Convert known GigaBits Per Second to Bits Per Second`` (input, expectation) = 
        Gbps.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBits Per Second to KiloBits Per Second and back`` () =
        let property value =
            let convertTo = Gbps.toKiloBitsPerSecond (Gbps.create value)
            let convertBack = kbps.toGigaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.01<Gbps>, 10000.0)>]
    [<TestCase(0.91<Gbps>, 910000.0)>]
    [<TestCase(6.1<Gbps>, 6.1e+6)>]
    let ``Convert known GigaBits Per Second to KiloBits Per Second`` (input, expectation) = 
        Gbps.toKiloBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBits Per Second to MegaBits Per Second and back`` () =
        let property value =
            let convertTo = Gbps.toMegaBitsPerSecond (Gbps.create value)
            let convertBack = Mbps.toGigaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.1<Gbps>, 6100.0)>]
    [<TestCase(0.961<Gbps>, 961.0)>]
    [<TestCase(1.2e-3<Gbps>, 1.2)>]
    let ``Convert known GigaBits Per Second to MegaBits Per Second`` (input, expectation) = 
        Gbps.toMegaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBits Per Second to TeraBits Per Second and back`` () =
        let property value =
            let convertTo = Gbps.toTeraBitsPerSecond (Gbps.create value)
            let convertBack = Tbps.toGigaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1200.0<Gbps>, 1.2)>]
    [<TestCase(90012.0<Gbps>, 90.012)>]
    [<TestCase(8000.0<Gbps>, 8.0)>]
    let ``Convert known GigaBits Per Second to TeraBits Per Second`` (input, expectation) = 
        Gbps.toTeraBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBits Per Second to KiloBytes Per Second and back`` () =
        let property value =
            let convertTo = Gbps.toKiloBytesPerSecond (Gbps.create value)
            let convertBack = kBps.toGigaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<Gbps>, 150000.0)>]
    [<TestCase(0.9<Gbps>, 112500.0)>]
    [<TestCase(0.001<Gbps>, 125.0)>]
    let ``Convert known GigaBits Per Second to KiloBytes Per Second`` (input, expectation) = 
        Gbps.toKiloBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBits Per Second to MegaBytes Per Second and back`` () =
        let property value =
            let convertTo = Gbps.toMegaBytesPerSecond (Gbps.create value)
            let convertBack = MBps.toGigaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<Gbps>, 112.5)>]
    [<TestCase(1.2<Gbps>, 150.0)>]
    [<TestCase(80.1<Gbps>, 10012.5)>]
    let ``Convert known GigaBits Per Second to MegaBytes Per Second`` (input, expectation) = 
        Gbps.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBits Per Second to GigaBytes Per Second and back`` () =
        let property value =
            let convertTo = Gbps.toGigaBytesPerSecond (Gbps.create value)
            let convertBack = GBps.toGigaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(99.0<Gbps>, 12.375)>]
    [<TestCase(123.123<Gbps>, 15.390375)>]
    [<TestCase(8000.9<Gbps>, 1000.1125)>]
    let ``Convert known GigaBits Per Second to GigaBytes Per Second`` (input, expectation) = 
        Gbps.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBits Per Second to TeraBytes Per Second and back`` () =
        let property value =
            let convertTo = Gbps.toTeraBytesPerSecond (Gbps.create value)
            let convertBack = TBps.toGigaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9000.0<Gbps>, 1.125)>]
    [<TestCase(1234567.0<Gbps>, 154.320875)>]
    [<TestCase(613.0<Gbps>, 0.076625)>]
    let ``Convert known GigaBits Per Second to TeraBytes Per Second`` (input, expectation) = 
        Gbps.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBits Per Second to Kibibits Per Second and back`` () =
        let property value =
            let convertTo = Gbps.toKibibitsPerSecond (Gbps.create value)
            let convertBack = Kibitps.toGigaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.8<Gbps>, 781250.4)>]
    [<TestCase(0.012<Gbps>, 11718.75)>]
    [<TestCase(0.002<Gbps>, 1953.125)>]
    let ``Convert known GigaBits Per Second to Kibibits Per Second`` (input, expectation) = 
        Gbps.toKibibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBits Per Second to Mebibits Per Second and back`` () =
        let property value =
            let convertTo = Gbps.toMebibitsPerSecond (Gbps.create value)
            let convertBack = Mibit.toGigaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.002<Gbps>, 1.9073486)>]
    [<TestCase(0.9<Gbps>, 858.6)>]
    [<TestCase(6.1<Gbps>, 5819.4)>]
    let ``Convert known GigaBits Per Second to Mebibits Per Second`` (input, expectation) = 
        Gbps.toMebibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBytes Per Second to Bits Per Second and back`` () =
        let property value =
            let convertTo = GBps.toBitsPerSecond (GBps.create value)
            let convertBack = bps.toGigaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.004<GBps>, 32000000.0)>]
    [<TestCase(0.012<GBps>, 96000000)>]
    [<TestCase(3e-9<GBps>, 24.0)>]
    let ``Convert known GigaBytes Per Second to Bits Per Second`` (input, expectation) = 
        GBps.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBytes Per Second to KiloBits Per Second and back`` () =
        let property value =
            let convertTo = GBps.toKiloBitsPerSecond (GBps.create value)
            let convertBack = kbps.toGigaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.009<GBps>, 72000.0)>]
    [<TestCase(1.2e-4<GBps>, 960.0)>]
    [<TestCase(0.0078<GBps>, 62400.0)>]
    let ``Convert known GigaBytes Per Second to KiloBits Per Second`` (input, expectation) = 
        GBps.toKiloBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBytes Per Second to MegaBits Per Second and back`` () =
        let property value =
            let convertTo = GBps.toMegaBitsPerSecond (GBps.create value)
            let convertBack = Mbps.toGigaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.0078<GBps>, 62.4)>]
    [<TestCase(0.01<GBps>, 80.0)>]
    [<TestCase(0.001234<GBps>, 9.872)>]
    let ``Convert known GigaBytes Per Second to MegaBits Per Second`` (input, expectation) = 
        GBps.toMegaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBytes Per Second to GigaBits Per Second and back`` () =
        let property value =
            let convertTo = GBps.toGigaBitsPerSecond (GBps.create value)
            let convertBack = Gbps.toGigaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.0<GBps>, 40.0)>]
    [<TestCase(1.2<GBps>, 9.6)>]
    [<TestCase(0.01<GBps>, 0.08)>]
    let ``Convert known GigaBytes Per Second to GigaBits Per Second`` (input, expectation) = 
        GBps.toGigaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBytes Per Second to TeraBits Per Second and back`` () =
        let property value =
            let convertTo = GBps.toTeraBitsPerSecond (GBps.create value)
            let convertBack = Tbps.toGigaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(70.0<GBps>, 0.56)>]
    [<TestCase(9001.0<GBps>, 72.008)>]
    [<TestCase(768123.9<GBps>, 6144.9912)>]
    let ``Convert known GigaBytes Per Second to TeraBits Per Second`` (input, expectation) = 
        GBps.toTeraBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBytes Per Second to KiloBytes Per Second and back`` () =
        let property value =
            let convertTo = GBps.toKiloBytesPerSecond (GBps.create value)
            let convertBack = kBps.toGigaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.2<GBps>, 200000.0)>]
    [<TestCase(0.009<GBps>, 9000.0)>]
    [<TestCase(0.00123<GBps>, 1230.0)>]
    let ``Convert known GigaBytes Per Second to KiloBytes Per Second`` (input, expectation) = 
        GBps.toKiloBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBytes Per Second to MegaBytes Per Second and back`` () =
        let property value =
            let convertTo = GBps.toMegaBytesPerSecond (GBps.create value)
            let convertBack = MBps.toGigaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<GBps>, 900.0)>]
    [<TestCase(12.0<GBps>, 12000.0)>]
    [<TestCase(35.6<GBps>, 35600.0)>]
    let ``Convert known GigaBytes Per Second to MegaBytes Per Second`` (input, expectation) = 
        GBps.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBytes Per Second to TeraBytes Per Second and back`` () =
        let property value =
            let convertTo = GBps.toTeraBytesPerSecond (GBps.create value)
            let convertBack = TBps.toGigaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(35.6<GBps>, 0.0356)>]
    [<TestCase(100.23<GBps>, 0.10023)>]
    [<TestCase(900100.0<GBps>, 900.1)>]
    let ``Convert known GigaBytes Per Second to TeraBytes Per Second`` (input, expectation) = 
        GBps.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBytes Per Second to Kibibits Per Second and back`` () =
        let property value =
            let convertTo = GBps.toKibibitsPerSecond (GBps.create value)
            let convertBack = Kibitps.toGigaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.05<GBps>, 390625.0)>]
    [<TestCase(0.008<GBps>, 62500.0)>]
    [<TestCase(0.00123<GBps>, 9609.375)>]
    let ``Convert known GigaBytes Per Second to Kibibits Per Second`` (input, expectation) = 
        GBps.toKibibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From GigaBytes Per Second to Mebibits Per Second and back`` () =
        let property value =
            let convertTo = GBps.toMebibitsPerSecond (GBps.create value)
            let convertBack = Mibit.toGigaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.009<GBps>, 68.66451)>]
    [<TestCase(1.2<GBps>, 9155.268)>]
    [<TestCase(19.2<GBps>, 146484.288)>]
    let ``Convert known GigaBytes Per Second to Mebibits Per Second`` (input, expectation) = 
        GBps.toMebibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kibibits Per Second to Bits Per Second and back`` () =
        let property value =
            let convertTo = Kibitps.toBitsPerSecond (Kibitps.create value)
            let convertBack = bps.toKibibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.0<Kibitps>, 2048.0)>]
    [<TestCase(9.0<Kibitps>, 9216.0)>]
    [<TestCase(17.8<Kibitps>, 18227.2)>]
    let ``Convert known Kibibits Per Second to Bits Per Second`` (input, expectation) = 
        Kibitps.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kibibits Per Second to KiloBits Per Second and back`` () =
        let property value =
            let convertTo = Kibitps.toKiloBitsPerSecond (Kibitps.create value)
            let convertBack = kbps.toKibibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.2<Kibitps>, 6.3488)>]
    [<TestCase(0.9<Kibitps>, 0.9216)>]
    [<TestCase(87.0<Kibitps>, 89.088)>]
    let ``Convert known Kibibits Per Second to KiloBits Per Second`` (input, expectation) = 
        Kibitps.toKiloBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kibibits Per Second to MegaBits Per Second and back`` () =
        let property value =
            let convertTo = Kibitps.toMegaBitsPerSecond (Kibitps.create value)
            let convertBack = Mbps.toKibibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(87.0<Kibitps>, 0.089088)>]
    [<TestCase(12.34<Kibitps>, 0.01263616)>]
    [<TestCase(123456.0<Kibitps>, 126.418879)>]
    let ``Convert known Kibibits Per Second to MegaBits Per Second`` (input, expectation) = 
        Kibitps.toMegaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kibibits Per Second to GigaBits Per Second and back`` () =
        let property value =
            let convertTo = Kibitps.toGigaBitsPerSecond (Kibitps.create value)
            let convertBack = Gbps.toKibibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123456.0<Kibitps>, 0.126418944)>]
    [<TestCase(8000000.0<Kibitps>, 8.192)>]
    [<TestCase(1276876<Kibitps>, 1.307521024)>]
    let ``Convert known Kibibits Per Second to GigaBits Per Second`` (input, expectation) = 
        Kibitps.toGigaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kibibits Per Second to TeraBits Per Second and back`` () =
        let property value =
            let convertTo = Kibitps.toTeraBitsPerSecond (Kibitps.create value)
            let convertBack = Tbps.toKibibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(800000000.0<Kibitps>, 0.8192)>]
    [<TestCase(1.5e12<Kibitps>, 1536.0)>]
    [<TestCase(9999999.0<Kibitps>, 0.01023999898)>]
    let ``Convert known Kibibits Per Second to TeraBits Per Second`` (input, expectation) = 
        Kibitps.toTeraBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kibibits Per Second to KiloBytes Per Second and back`` () =
        let property value =
            let convertTo = Kibitps.toKiloBytesPerSecond (Kibitps.create value)
            let convertBack = kBps.toKibibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(919.0<Kibitps>, 117.632)>]
    [<TestCase(77.4<Kibitps>, 9.9072)>]
    [<TestCase(109.109<Kibitps>, 13.965952)>]
    let ``Convert known Kibibits Per Second to KiloBytes Per Second`` (input, expectation) = 
        Kibitps.toKiloBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kibibits Per Second to MegaBytes Per Second and back`` () =
        let property value =
            let convertTo = Kibitps.toMegaBytesPerSecond (Kibitps.create value)
            let convertBack = MBps.toKibibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1000.0<Kibitps>, 0.128)>]
    [<TestCase(800.123<Kibitps>, 0.102415744)>]
    [<TestCase(123456.0<Kibitps>, 15.802368)>]
    let ``Convert known Kibibits Per Second to MegaBytes Per Second`` (input, expectation) = 
        Kibitps.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kibibits Per Second to GigaBytes Per Second and back`` () =
        let property value =
            let convertTo = Kibitps.toGigaBytesPerSecond (Kibitps.create value)
            let convertBack = GBps.toKibibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12345678.0<Kibitps>, 1.580347926)>]
    [<TestCase(8e12<Kibitps>, 1024000.00)>]
    [<TestCase(1.2e5<Kibitps>, 0.01536)>]
    let ``Convert known Kibibits Per Second to GigaBytes Per Second`` (input, expectation) = 
        Kibitps.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kibibits Per Second to TeraBytes Per Second and back`` () =
        let property value =
            let convertTo = Kibitps.toTeraBytesPerSecond (Kibitps.create value)
            let convertBack = TBps.toKibibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(120000000.0<Kibitps>, 0.01536)>]
    [<TestCase(88e12<Kibitps>, 11264.0)>]
    [<TestCase(9000000.0<Kibitps>, 0.009216)>]
    let ``Convert known Kibibits Per Second to TeraBytes Per Second`` (input, expectation) = 
        Kibitps.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kibibits Per Second to Mebibits Per Second and back`` () =
        let property value =
            let convertTo = Kibitps.toMebibitsPerSecond (Kibitps.create value)
            let convertBack = Mibit.toKibibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(600.0<Kibitps>, 0.5859375)>]
    [<TestCase(12345.0<Kibitps>, 12.055664)>]
    [<TestCase(101.0<Kibitps>, 0.0986328)>]
    let ``Convert known Kibibits Per Second to Mebibits Per Second`` (input, expectation) = 
        Kibitps.toMebibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBits Per Second to Bits Per Second and back`` () =
        let property value =
            let convertTo = kbps.toBitsPerSecond (kbps.create value)
            let convertBack = bps.toKiloBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9.0<kbps>, 9000.0)>]
    [<TestCase(6.7<kbps>, 6700.0)>]
    [<TestCase(1.2345<kbps>, 1234.5)>]
    let ``Convert known KiloBits Per Second to Bits Per Second`` (input, expectation) = 
        kbps.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBits Per Second to MegaBits Per Second and back`` () =
        let property value =
            let convertTo = kbps.toMegaBitsPerSecond (kbps.create value)
            let convertBack = Mbps.toKiloBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<kbps>, 0.9)>]
    [<TestCase(12345.0<kbps>, 12.345)>]
    [<TestCase(9988.0<kbps>, 9.988)>]
    let ``Convert known KiloBits Per Second to MegaBits Per Second`` (input, expectation) = 
        kbps.toMegaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBits Per Second to GigaBits Per Second and back`` () =
        let property value =
            let convertTo = kbps.toGigaBitsPerSecond (kbps.create value)
            let convertBack = Gbps.toKiloBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123456.0<kbps>, 0.123456)>]
    [<TestCase(8000700.0<kbps>, 8.0007)>]
    [<TestCase(191987578.0<kbps>, 191.987578)>]
    let ``Convert known KiloBits Per Second to GigaBits Per Second`` (input, expectation) = 
        kbps.toGigaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBits Per Second to TeraBits Per Second and back`` () =
        let property value =
            let convertTo = kbps.toTeraBitsPerSecond (kbps.create value)
            let convertBack = Tbps.toKiloBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(191987578<kbps>, 0.191987578)>]
    [<TestCase(9010081903.0<kbps>, 9.010081903)>]
    [<TestCase(123456789.0<kbps>, 0.123456789)>]
    let ``Convert known KiloBits Per Second to TeraBits Per Second`` (input, expectation) = 
        kbps.toTeraBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBits Per Second to KiloBytes Per Second and back`` () =
        let property value =
            let convertTo = kbps.toKiloBytesPerSecond (kbps.create value)
            let convertBack = kBps.toKiloBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(80.0<kbps>, 10.0)>]
    [<TestCase(15.67<kbps>, 1.95875)>]
    [<TestCase(8007.09<kbps>, 1000.88625)>]
    let ``Convert known KiloBits Per Second to KiloBytes Per Second`` (input, expectation) = 
        kbps.toKiloBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBits Per Second to MegaBytes Per Second and back`` () =
        let property value =
            let convertTo = kbps.toMegaBytesPerSecond (kbps.create value)
            let convertBack = MBps.toKiloBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123456.0<kbps>, 15.432)>]
    [<TestCase(998877.0<kbps>, 124.859625)>]
    [<TestCase(10090.0<kbps>, 1.26125)>]
    let ``Convert known KiloBits Per Second to MegaBytes Per Second`` (input, expectation) = 
        kbps.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBits Per Second to GigaBytes Per Second and back`` () =
        let property value =
            let convertTo = kbps.toGigaBytesPerSecond (kbps.create value)
            let convertBack = GBps.toKiloBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1828972.0<kbps>, 0.2286215)>]
    [<TestCase(879860.8<kbps>, 0.1099826)>]
    [<TestCase(78178971.0<kbps>, 9.772371375)>]
    let ``Convert known KiloBits Per Second to GigaBytes Per Second`` (input, expectation) = 
        kbps.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBits Per Second to TeraBytes Per Second and back`` () =
        let property value =
            let convertTo = kbps.toTeraBytesPerSecond (kbps.create value)
            let convertBack = TBps.toKiloBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1234567891.0<kbps>, 0.154320986375)>]
    [<TestCase(999999098.0<kbps>, 0.12499988725)>]
    [<TestCase(84618364142.0<kbps>, 10.57729551775)>]
    let ``Convert known KiloBits Per Second to TeraBytes Per Second`` (input, expectation) = 
        kbps.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBits Per Second to Kibibits Per Second and back`` () =
        let property value =
            let convertTo = kbps.toKibibitsPerSecond (kbps.create value)
            let convertBack = Kibitps.toKiloBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(89.1<kbps>, 87.01172)>]
    [<TestCase(7.1<kbps>, 6.93359)>]
    [<TestCase(438.0<kbps>, 427.734)>]
    let ``Convert known KiloBits Per Second to Kibibits Per Second`` (input, expectation) = 
        kbps.toKibibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBits Per Second to Mebibits Per Second and back`` () =
        let property value =
            let convertTo = kbps.toMebibitsPerSecond (kbps.create value)
            let convertBack = Mibit.toKiloBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(77790.0<kbps>, 74.186325)>]
    [<TestCase(123456.0<kbps>, 117.736816)>]
    [<TestCase(23972.0<kbps>, 22.861481)>]
    let ``Convert known KiloBits Per Second to Mebibits Per Second`` (input, expectation) = 
        kbps.toMebibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBytes Per Second to Bits Per Second and back`` () =
        let property value =
            let convertTo = kBps.toBitsPerSecond (kBps.create value)
            let convertBack = bps.toKiloBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.456<kBps>, 987648.0)>]
    [<TestCase(900.0<kBps>, 7.2e+6)>]
    [<TestCase(100200.0<kBps>, 801600000)>]
    let ``Convert known KiloBytes Per Second to Bits Per Second`` (input, expectation) = 
        kBps.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBytes Per Second to KiloBits Per Second and back`` () =
        let property value =
            let convertTo = kBps.toKiloBitsPerSecond (kBps.create value)
            let convertBack = kbps.toKiloBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.0<kBps>, 32.0)>]
    [<TestCase(1.2<kBps>, 9.6)>]
    [<TestCase(88.1<kBps>, 704.8)>]
    let ``Convert known KiloBytes Per Second to KiloBits Per Second`` (input, expectation) = 
        kBps.toKiloBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBytes Per Second to MegaBits Per Second and back`` () =
        let property value =
            let convertTo = kBps.toMegaBitsPerSecond (kBps.create value)
            let convertBack = Mbps.toKiloBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(88.1<kBps>, 0.7048)>]
    [<TestCase(7.1<kBps>, 0.0568)>]
    [<TestCase(12.8<kBps>, 0.1024)>]
    let ``Convert known KiloBytes Per Second to MegaBits Per Second`` (input, expectation) = 
        kBps.toMegaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBytes Per Second to GigaBits Per Second and back`` () =
        let property value =
            let convertTo = kBps.toGigaBitsPerSecond (kBps.create value)
            let convertBack = Gbps.toKiloBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(10080.0<kBps>, 0.08064)>]
    [<TestCase(4.5e+9<kBps>, 36000.0)>]
    [<TestCase(271279.0<kBps>, 2.170232)>]
    let ``Convert known KiloBytes Per Second to GigaBits Per Second`` (input, expectation) = 
        kBps.toGigaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBytes Per Second to TeraBits Per Second and back`` () =
        let property value =
            let convertTo = kBps.toTeraBitsPerSecond (kBps.create value)
            let convertBack = Tbps.toKiloBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9009000.0<kBps>, 0.072072)>]
    [<TestCase(7.2e9<kBps>, 57.6)>]
    [<TestCase(100100100900.0<kBps>, 800.8008072)>]
    let ``Convert known KiloBytes Per Second to TeraBits Per Second`` (input, expectation) = 
        kBps.toTeraBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBytes Per Second to MegaBytes Per Second and back`` () =
        let property value =
            let convertTo = kBps.toMegaBytesPerSecond (kBps.create value)
            let convertBack = MBps.toKiloBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1009.0<kBps>, 1.009)>]
    [<TestCase(8899.0<kBps>, 8.899)>]
    [<TestCase(619.0<kBps>, 0.619)>]
    let ``Convert known KiloBytes Per Second to MegaBytes Per Second`` (input, expectation) = 
        kBps.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBytes Per Second to GigaBytes Per Second and back`` () =
        let property value =
            let convertTo = kBps.toGigaBytesPerSecond (kBps.create value)
            let convertBack = GBps.toKiloBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900800.0<kBps>, 0.9008)>]
    [<TestCase(1234567.0<kBps>, 1.234567)>]
    [<TestCase(7.9e9<kBps>, 7900.0)>]
    let ``Convert known KiloBytes Per Second to GigaBytes Per Second`` (input, expectation) = 
        kBps.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBytes Per Second to TeraBytes Per Second and back`` () =
        let property value =
            let convertTo = kBps.toTeraBytesPerSecond (kBps.create value)
            let convertBack = TBps.toKiloBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<kBps>, 9e-10)>]
    [<TestCase(140000000<kBps>, 0.14)>]
    [<TestCase(7.0<kBps>, 7e-9)>]
    let ``Convert known KiloBytes Per Second to TeraBytes Per Second`` (input, expectation) = 
        kBps.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBytes Per Second to Kibibits Per Second and back`` () =
        let property value =
            let convertTo = kBps.toKibibitsPerSecond (kBps.create value)
            let convertBack = Kibitps.toKiloBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.009<kBps>, 0.0703125)>]
    [<TestCase(6e+3<kBps>, 46872.0)>]
    [<TestCase(1.23<kBps>, 9.609375)>]
    let ``Convert known KiloBytes Per Second to Kibibits Per Second`` (input, expectation) = 
        kBps.toKibibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From KiloBytes Per Second to Mebibits Per Second and back`` () =
        let property value =
            let convertTo = kBps.toMebibitsPerSecond (kBps.create value)
            let convertBack = Mibit.toKiloBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(70.0<kBps>, 0.534058)>]
    [<TestCase(9.0<kBps>, 0.0686646)>]
    [<TestCase(10022.0<kBps>, 76.461792)>]
    let ``Convert known KiloBytes Per Second to Mebibits Per Second`` (input, expectation) = 
        kBps.toMebibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Mebibits Per Second to Bits Per Second and back`` () =
        let property value =
            let convertTo = Mibit.toBitsPerSecond (Mibit.create value)
            let convertBack = bps.toMebibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<Mibit>, 943718.4)>]
    [<TestCase(0.006<Mibit>, 6291.456)>]
    [<TestCase(2.0<Mibit>, 2097152.0)>]
    let ``Convert known Mebibits Per Second to Bits Per Second`` (input, expectation) = 
        Mibit.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Mebibits Per Second to KiloBits Per Second and back`` () =
        let property value =
            let convertTo = Mibit.toKiloBitsPerSecond (Mibit.create value)
            let convertBack = kbps.toMebibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.8<Mibit>, 838.861)>]
    [<TestCase(2.0<Mibit>, 2097.15)>]
    [<TestCase(0.23<Mibit>, 241.1725)>]
    let ``Convert known Mebibits Per Second to KiloBits Per Second`` (input, expectation) = 
        Mibit.toKiloBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Mebibits Per Second to MegaBits Per Second and back`` () =
        let property value =
            let convertTo = Mibit.toMegaBitsPerSecond (Mibit.create value)
            let convertBack = Mbps.toMebibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<Mibit>, 0.943718)>]
    [<TestCase(12.3<Mibit>, 12.89748)>]
    [<TestCase(8.1<Mibit>, 8.49347)>]
    let ``Convert known Mebibits Per Second to MegaBits Per Second`` (input, expectation) = 
        Mibit.toMegaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Mebibits Per Second to GigaBits Per Second and back`` () =
        let property value =
            let convertTo = Mibit.toGigaBitsPerSecond (Mibit.create value)
            let convertBack = Gbps.toMebibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12345.0<Mibit>, 12.944671)>]
    [<TestCase(100.0<Mibit>, 0.104858)>]
    [<TestCase(999.9<Mibit>, 1.0484711)>]
    let ``Convert known Mebibits Per Second to GigaBits Per Second`` (input, expectation) = 
        Mibit.toGigaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Mebibits Per Second to TeraBits Per Second and back`` () =
        let property value =
            let convertTo = Mibit.toTeraBitsPerSecond (Mibit.create value)
            let convertBack = Tbps.toMebibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100009.0<Mibit>, 0.104867037)>]
    [<TestCase(9876543.0<Mibit>, 10.35630595)>]
    [<TestCase(1000900.0<Mibit>, 1.049519718)>]
    let ``Convert known Mebibits Per Second to TeraBits Per Second`` (input, expectation) = 
        Mibit.toTeraBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Mebibits Per Second to KiloBytes Per Second and back`` () =
        let property value =
            let convertTo = Mibit.toKiloBytesPerSecond (Mibit.create value)
            let convertBack = kBps.toMebibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.0<Mibit>, 524.288)>]
    [<TestCase(1.45<Mibit>, 190.0544)>]
    [<TestCase(88.11<Mibit>, 11548.754)>]
    let ``Convert known Mebibits Per Second to KiloBytes Per Second`` (input, expectation) = 
        Mibit.toKiloBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Mebibits Per Second to MegaBytes Per Second and back`` () =
        let property value =
            let convertTo = Mibit.toMegaBytesPerSecond (Mibit.create value)
            let convertBack = MBps.toMebibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<Mibit>, 14.2868)>]
    [<TestCase(55.67<Mibit>, 7.2967782)>]
    [<TestCase(45678.0<Mibit>, 5987.1068)>]
    let ``Convert known Mebibits Per Second to MegaBytes Per Second`` (input, expectation) = 
        Mibit.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Mebibits Per Second to GigaBytes Per Second and back`` () =
        let property value =
            let convertTo = Mibit.toGigaBytesPerSecond (Mibit.create value)
            let convertBack = GBps.toMebibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4000.0<Mibit>, 0.524288311)>]
    [<TestCase(90100.0<Mibit>, 11.80959421)>]
    [<TestCase(1009.0<Mibit>, 0.132251727)>]
    let ``Convert known Mebibits Per Second to GigaBytes Per Second`` (input, expectation) = 
        Mibit.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Mebibits Per Second to TeraBytes Per Second and back`` () =
        let property value =
            let convertTo = Mibit.toTeraBytesPerSecond (Mibit.create value)
            let convertBack = TBps.toMebibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1000009.0<Mibit>, 0.1310731796)>]
    [<TestCase(90808080.0<Mibit>, 11.902396662)>]
    [<TestCase(5.2e12<Mibit>, 681574.4)>]
    let ``Convert known Mebibits Per Second to TeraBytes Per Second`` (input, expectation) = 
        Mibit.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Mebibits Per Second to Kibibits Per Second and back`` () =
        let property value =
            let convertTo = Mibit.toKibibitsPerSecond (Mibit.create value)
            let convertBack = Kibitps.toMebibitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.0<Mibit>, 5120.0)>]
    [<TestCase(1234.56<Mibit>, 1264189.44)>]
    [<TestCase(505.0<Mibit>, 517120.0)>]
    let ``Convert known Mebibits Per Second to Kibibits Per Second`` (input, expectation) = 
        Mibit.toKibibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBits Per Second to Bits Per Second and back`` () =
        let property value =
            let convertTo = Mbps.toBitsPerSecond (Mbps.create value)
            let convertBack = bps.toMegaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.34<Mbps>, 340000.0)>]
    [<TestCase(9.12<Mbps>, 9120000.0)>]
    [<TestCase(0.987<Mbps>, 987000.0)>]
    let ``Convert known MegaBits Per Second to Bits Per Second`` (input, expectation) = 
        Mbps.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBits Per Second to KiloBits Per Second and back`` () =
        let property value =
            let convertTo = Mbps.toKiloBitsPerSecond (Mbps.create value)
            let convertBack = kbps.toMegaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.77<Mbps>, 770.0)>]
    [<TestCase(5.0<Mbps>, 5000.0)>]
    [<TestCase(0.987<Mbps>, 987.0)>]
    let ``Convert known MegaBits Per Second to KiloBits Per Second`` (input, expectation) = 
        Mbps.toKiloBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBits Per Second to GigaBits Per Second and back`` () =
        let property value =
            let convertTo = Mbps.toGigaBitsPerSecond (Mbps.create value)
            let convertBack = Gbps.toMegaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<Mbps>, 0.9)>]
    [<TestCase(12345.0<Mbps>, 12.345)>]
    [<TestCase(189.1<Mbps>, 0.1891)>]
    let ``Convert known MegaBits Per Second to GigaBits Per Second`` (input, expectation) = 
        Mbps.toGigaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBits Per Second to TeraBits Per Second and back`` () =
        let property value =
            let convertTo = Mbps.toTeraBitsPerSecond (Mbps.create value)
            let convertBack = Tbps.toMegaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100200300.0<Mbps>, 100.2003)>]
    [<TestCase(99887777.0<Mbps>, 99.887777)>]
    [<TestCase(80009.0<Mbps>, 0.080009)>]
    let ``Convert known MegaBits Per Second to TeraBits Per Second`` (input, expectation) = 
        Mbps.toTeraBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBits Per Second to KiloBytes Per Second and back`` () =
        let property value =
            let convertTo = Mbps.toKiloBytesPerSecond (Mbps.create value)
            let convertBack = kBps.toMegaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9.0<Mbps>, 1125.0)>]
    [<TestCase(1.23<Mbps>, 153.75)>]
    [<TestCase(98.1<Mbps>, 12262.5)>]
    let ``Convert known MegaBits Per Second to KiloBytes Per Second`` (input, expectation) = 
        Mbps.toKiloBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBits Per Second to MegaBytes Per Second and back`` () =
        let property value =
            let convertTo = Mbps.toMegaBytesPerSecond (Mbps.create value)
            let convertBack = MBps.toMegaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(98.1<Mbps>, 12.2625)>]
    [<TestCase(10.9<Mbps>, 1.3625)>]
    [<TestCase(888.123<Mbps>, 111.015375)>]
    let ``Convert known MegaBits Per Second to MegaBytes Per Second`` (input, expectation) = 
        Mbps.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBits Per Second to GigaBytes Per Second and back`` () =
        let property value =
            let convertTo = Mbps.toGigaBytesPerSecond (Mbps.create value)
            let convertBack = GBps.toMegaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<Mbps>, 0.1125)>]
    [<TestCase(10123.0<Mbps>, 1.265375)>]
    [<TestCase(9988.0<Mbps>, 1.2485)>]
    let ``Convert known MegaBits Per Second to GigaBytes Per Second`` (input, expectation) = 
        Mbps.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBits Per Second to TeraBytes Per Second and back`` () =
        let property value =
            let convertTo = Mbps.toTeraBytesPerSecond (Mbps.create value)
            let convertBack = TBps.toMegaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(998877.0<Mbps>, 0.124859625)>]
    [<TestCase(100200400.0<Mbps>, 12.5250375)>]
    [<TestCase(9008877.0<Mbps>, 1.126109625)>]
    let ``Convert known MegaBits Per Second to TeraBytes Per Second`` (input, expectation) = 
        Mbps.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBits Per Second to Kibibits Per Second and back`` () =
        let property value =
            let convertTo = Mbps.toKibibitsPerSecond (Mbps.create value)
            let convertBack = Kibitps.toMegaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<Mbps>, 11718.756)>]
    [<TestCase(0.9<Mbps>, 878.906)>]
    [<TestCase(1.23<Mbps>, 1201.172)>]
    let ``Convert known MegaBits Per Second to Kibibits Per Second`` (input, expectation) = 
        Mbps.toKibibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBits Per Second to Mebibits Per Second and back`` () =
        let property value =
            let convertTo = Mbps.toMebibitsPerSecond (Mbps.create value)
            let convertBack = Mibit.toMegaBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.5<Mbps>, 4.29153)>]
    [<TestCase(0.8<Mbps>, 0.762939)>]
    [<TestCase(900.0<Mbps>, 858.307)>]
    let ``Convert known MegaBits Per Second to Mebibits Per Second`` (input, expectation) = 
        Mbps.toMebibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBytes Per Second to Bits Per Second and back`` () =
        let property value =
            let convertTo = MBps.toBitsPerSecond (MBps.create value)
            let convertBack = bps.toMegaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.04<MBps>, 320000.0)>]
    [<TestCase(0.0091<MBps>, 72800.0)>]
    [<TestCase(3e-5<MBps>, 240.0)>]
    let ``Convert known MegaBytes Per Second to Bits Per Second`` (input, expectation) = 
        MBps.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBytes Per Second to KiloBits Per Second and back`` () =
        let property value =
            let convertTo = MBps.toKiloBitsPerSecond (MBps.create value)
            let convertBack = kbps.toMegaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.0<MBps>, 48000.0)>]
    [<TestCase(0.3<MBps>, 2400.0)>]
    [<TestCase(0.009<MBps>, 72.0)>]
    let ``Convert known MegaBytes Per Second to KiloBits Per Second`` (input, expectation) = 
        MBps.toKiloBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBytes Per Second to MegaBits Per Second and back`` () =
        let property value =
            let convertTo = MBps.toMegaBitsPerSecond (MBps.create value)
            let convertBack = Mbps.toMegaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.0<MBps>, 24.0)>]
    [<TestCase(0.9<MBps>, 7.2)>]
    [<TestCase(13.0<MBps>, 104.0)>]
    let ``Convert known MegaBytes Per Second to MegaBits Per Second`` (input, expectation) = 
        MBps.toMegaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBytes Per Second to GigaBits Per Second and back`` () =
        let property value =
            let convertTo = MBps.toGigaBitsPerSecond (MBps.create value)
            let convertBack = Gbps.toMegaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(13.0<MBps>, 0.104)>]
    [<TestCase(900.0<MBps>, 7.2)>]
    [<TestCase(18000.0<MBps>, 144.0)>]
    let ``Convert known MegaBytes Per Second to GigaBits Per Second`` (input, expectation) = 
        MBps.toGigaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBytes Per Second to TeraBits Per Second and back`` () =
        let property value =
            let convertTo = MBps.toTeraBitsPerSecond (MBps.create value)
            let convertBack = Tbps.toMegaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(18000.0<MBps>, 0.144)>]
    [<TestCase(9718290.0<MBps>, 77.74632)>]
    [<TestCase(9e12<MBps>, 72000000.0)>]
    let ``Convert known MegaBytes Per Second to TeraBits Per Second`` (input, expectation) = 
        MBps.toTeraBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBytes Per Second to KiloBytes Per Second and back`` () =
        let property value =
            let convertTo = MBps.toKiloBytesPerSecond (MBps.create value)
            let convertBack = kBps.toMegaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.0<MBps>, 6000.0)>]
    [<TestCase(0.9<MBps>, 900.0)>]
    [<TestCase(123.4<MBps>, 123400.0)>]
    let ``Convert known MegaBytes Per Second to KiloBytes Per Second`` (input, expectation) = 
        MBps.toKiloBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBytes Per Second to GigaBytes Per Second and back`` () =
        let property value =
            let convertTo = MBps.toGigaBytesPerSecond (MBps.create value)
            let convertBack = GBps.toMegaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.4<MBps>, 0.1234)>]
    [<TestCase(900.0<MBps>, 0.9)>]
    [<TestCase(8e6<MBps>, 8000.0)>]
    let ``Convert known MegaBytes Per Second to GigaBytes Per Second`` (input, expectation) = 
        MBps.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBytes Per Second to TeraBytes Per Second and back`` () =
        let property value =
            let convertTo = MBps.toTeraBytesPerSecond (MBps.create value)
            let convertBack = TBps.toMegaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(80000.0<MBps>, 0.08)>]
    [<TestCase(12345678.0<MBps>, 12.345678)>]
    [<TestCase(900800.0<MBps>, 0.9008)>]
    let ``Convert known MegaBytes Per Second to TeraBytes Per Second`` (input, expectation) = 
        MBps.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBytes Per Second to Kibibits Per Second and back`` () =
        let property value =
            let convertTo = MBps.toKibibitsPerSecond (MBps.create value)
            let convertBack = Kibitps.toMegaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.0<MBps>, 46875.0)>]
    [<TestCase(0.9<MBps>, 7031.25)>]
    [<TestCase(0.03<MBps>, 234.375)>]
    let ``Convert known MegaBytes Per Second to Kibibits Per Second`` (input, expectation) = 
        MBps.toKibibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From MegaBytes Per Second to Mebibits Per Second and back`` () =
        let property value =
            let convertTo = MBps.toMebibitsPerSecond (MBps.create value)
            let convertBack = Mibit.toMegaBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.03<MBps>, 0.2288818)>]
    [<TestCase(4.5<MBps>, 34.3323)>]
    [<TestCase(80.1<MBps>, 611.1145)>]
    let ``Convert known MegaBytes Per Second to Mebibits Per Second`` (input, expectation) = 
        MBps.toMebibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBits Per Second to Bits Per Second and back`` () =
        let property value =
            let convertTo = Tbps.toBitsPerSecond (Tbps.create value)
            let convertBack = bps.toTeraBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.0007<Tbps>, 700000000.0)>]
    [<TestCase(1.23e-6<Tbps>, 1230000.0)>]
    [<TestCase(0.00098<Tbps>, 980000000.0)>]
    let ``Convert known TeraBits Per Second to Bits Per Second`` (input, expectation) = 
        Tbps.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBits Per Second to KiloBits Per Second and back`` () =
        let property value =
            let convertTo = Tbps.toKiloBitsPerSecond (Tbps.create value)
            let convertBack = kbps.toTeraBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.001<Tbps>, 1000000.0)>]
    [<TestCase(6.1e-6<Tbps>, 6100.0)>]
    [<TestCase(0.00009<Tbps>, 90000.0)>]
    let ``Convert known TeraBits Per Second to KiloBits Per Second`` (input, expectation) = 
        Tbps.toKiloBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBits Per Second to MegaBits Per Second and back`` () =
        let property value =
            let convertTo = Tbps.toMegaBitsPerSecond (Tbps.create value)
            let convertBack = Mbps.toTeraBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.09<Tbps>, 90000.0)>]
    [<TestCase(3.5e-4<Tbps>, 350.0)>]
    [<TestCase(0.0123<Tbps>, 12300.0)>]
    let ``Convert known TeraBits Per Second to MegaBits Per Second`` (input, expectation) = 
        Tbps.toMegaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBits Per Second to GigaBits Per Second and back`` () =
        let property value =
            let convertTo = Tbps.toGigaBitsPerSecond (Tbps.create value)
            let convertBack = Gbps.toTeraBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<Tbps>, 900.0)>]
    [<TestCase(1.45<Tbps>, 1450.0)>]
    [<TestCase(8.19<Tbps>, 8190.0)>]
    let ``Convert known TeraBits Per Second to GigaBits Per Second`` (input, expectation) = 
        Tbps.toGigaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBits Per Second to KiloBytes Per Second and back`` () =
        let property value =
            let convertTo = Tbps.toKiloBytesPerSecond (Tbps.create value)
            let convertBack = kBps.toTeraBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.0009<Tbps>, 112500.0)>]
    [<TestCase(3.14e-6<Tbps>, 392.5)>]
    [<TestCase(0.001<Tbps>, 125000.0)>]
    let ``Convert known TeraBits Per Second to KiloBytes Per Second`` (input, expectation) = 
        Tbps.toKiloBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBits Per Second to MegaBytes Per Second and back`` () =
        let property value =
            let convertTo = Tbps.toMegaBytesPerSecond (Tbps.create value)
            let convertBack = MBps.toTeraBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.4<Tbps>, 50000.0)>]
    [<TestCase(3.9e-3<Tbps>, 487.5)>]
    [<TestCase(0.007<Tbps>, 875.0)>]
    let ``Convert known TeraBits Per Second to MegaBytes Per Second`` (input, expectation) = 
        Tbps.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBits Per Second to GigaBytes Per Second and back`` () =
        let property value =
            let convertTo = Tbps.toGigaBytesPerSecond (Tbps.create value)
            let convertBack = GBps.toTeraBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.009<Tbps>, 1.125)>]
    [<TestCase(0.00123<Tbps>, 0.15375)>]
    [<TestCase(8.1e-3<Tbps>, 1.0125)>]
    let ``Convert known TeraBits Per Second to GigaBytes Per Second`` (input, expectation) = 
        Tbps.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBits Per Second to TeraBytes Per Second and back`` () =
        let property value =
            let convertTo = Tbps.toTeraBytesPerSecond (Tbps.create value)
            let convertBack = TBps.toTeraBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.3<Tbps>, 0.0375)>]
    [<TestCase(14.0<Tbps>, 1.75)>]
    [<TestCase(0.8<Tbps>, 0.1)>]
    let ``Convert known TeraBits Per Second to TeraBytes Per Second`` (input, expectation) = 
        Tbps.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBits Per Second to Kibibits Per Second and back`` () =
        let property value =
            let convertTo = Tbps.toKibibitsPerSecond (Tbps.create value)
            let convertBack = Kibitps.toTeraBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.0009<Tbps>, 878906.25)>]
    [<TestCase(6.1e-6<Tbps>, 5957.031)>]
    [<TestCase(12e-9<Tbps>, 11.71875)>]
    let ``Convert known TeraBits Per Second to Kibibits Per Second`` (input, expectation) = 
        Tbps.toKibibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBits Per Second to Mebibits Per Second and back`` () =
        let property value =
            let convertTo = Tbps.toMebibitsPerSecond (Tbps.create value)
            let convertBack = Mibit.toTeraBitsPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<Tbps>, 858306.59999)>]
    [<TestCase(4.6e-3<Tbps>, 4386.9)>]
    [<TestCase(0.00123<Tbps>, 1173.0194092)>]
    let ``Convert known TeraBits Per Second to Mebibits Per Second`` (input, expectation) = 
        Tbps.toMebibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBytes Per Second to Bits Per Second and back`` () =
        let property value =
            let convertTo = TBps.toBitsPerSecond (TBps.create value)
            let convertBack = bps.toTeraBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.00008<TBps>, 640000000.0)>]
    [<TestCase(1.2e-12<TBps>, 9.6)>]
    [<TestCase(9.0<TBps>, 7.2e+13)>]
    let ``Convert known TeraBytes Per Second to Bits Per Second`` (input, expectation) = 
        TBps.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBytes Per Second to KiloBits Per Second and back`` () =
        let property value =
            let convertTo = TBps.toKiloBitsPerSecond (TBps.create value)
            let convertBack = kbps.toTeraBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.009<TBps>, 72000000.0)>]
    [<TestCase(1.4e-6<TBps>, 11200.0)>]
    [<TestCase(6.1e-5<TBps>, 488000.0)>]
    let ``Convert known TeraBytes Per Second to KiloBits Per Second`` (input, expectation) = 
        TBps.toKiloBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBytes Per Second to MegaBits Per Second and back`` () =
        let property value =
            let convertTo = TBps.toMegaBitsPerSecond (TBps.create value)
            let convertBack = Mbps.toTeraBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.005<TBps>, 40000.0)>]
    [<TestCase(0.000123<TBps>, 984.0)>]
    [<TestCase(0.00006<TBps>, 480.0)>]
    let ``Convert known TeraBytes Per Second to MegaBits Per Second`` (input, expectation) = 
        TBps.toMegaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBytes Per Second to GigaBits Per Second and back`` () =
        let property value =
            let convertTo = TBps.toGigaBitsPerSecond (TBps.create value)
            let convertBack = Gbps.toTeraBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.008<TBps>, 64.0)>]
    [<TestCase(3e-7<TBps>, 0.0024)>]
    [<TestCase(0.00023<TBps>, 1.84)>]
    let ``Convert known TeraBytes Per Second to GigaBits Per Second`` (input, expectation) = 
        TBps.toGigaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBytes Per Second to TeraBits Per Second and back`` () =
        let property value =
            let convertTo = TBps.toTeraBitsPerSecond (TBps.create value)
            let convertBack = Tbps.toTeraBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.0<TBps>, 40.0)>]
    [<TestCase(1.23<TBps>, 9.84)>]
    [<TestCase(800.0<TBps>, 6400.0)>]
    let ``Convert known TeraBytes Per Second to TeraBits Per Second`` (input, expectation) = 
        TBps.toTeraBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBytes Per Second to KiloBytes Per Second and back`` () =
        let property value =
            let convertTo = TBps.toKiloBytesPerSecond (TBps.create value)
            let convertBack = kBps.toTeraBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.0009<TBps>, 900000.0)>]
    [<TestCase(3.14e-7<TBps>, 314.0)>]
    [<TestCase(0.00063<TBps>, 630000.0)>]
    let ``Convert known TeraBytes Per Second to KiloBytes Per Second`` (input, expectation) = 
        TBps.toKiloBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBytes Per Second to MegaBytes Per Second and back`` () =
        let property value =
            let convertTo = TBps.toMegaBytesPerSecond (TBps.create value)
            let convertBack = MBps.toTeraBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.009<TBps>, 9000.0)>]
    [<TestCase(0.234<TBps>, 234000.0)>]
    [<TestCase(2.0<TBps>, 2e+6)>]
    let ``Convert known TeraBytes Per Second to MegaBytes Per Second`` (input, expectation) = 
        TBps.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBytes Per Second to GigaBytes Per Second and back`` () =
        let property value =
            let convertTo = TBps.toGigaBytesPerSecond (TBps.create value)
            let convertBack = GBps.toTeraBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.7<TBps>, 2700.0)>]
    [<TestCase(0.9<TBps>, 900.0)>]
    [<TestCase(0.0123<TBps>, 12.3)>]
    let ``Convert known TeraBytes Per Second to GigaBytes Per Second`` (input, expectation) = 
        TBps.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBytes Per Second to Kibibits Per Second and back`` () =
        let property value =
            let convertTo = TBps.toKibibitsPerSecond (TBps.create value)
            let convertBack = Kibitps.toTeraBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.0009<TBps>, 7031250.0)>]
    [<TestCase(1.23e-5<TBps>, 96093.75)>]
    [<TestCase(0.0001<TBps>, 781250.0)>]
    let ``Convert known TeraBytes Per Second to Kibibits Per Second`` (input, expectation) = 
        TBps.toKibibitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From TeraBytes Per Second to Mebibits Per Second and back`` () =
        let property value =
            let convertTo = TBps.toMebibitsPerSecond (TBps.create value)
            let convertBack = Mibit.toTeraBytesPerSecond convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.01<TBps>, 76293.95)>]
    [<TestCase(0.008<TBps>, 61035.156)>]
    [<TestCase(2.0<TBps>, 15258789.0625)>]
    let ``Convert known TeraBytes Per Second to Mebibits Per Second`` (input, expectation) = 
        TBps.toMebibitsPerSecond input
        |> should (equalWithin 0.01) expectation
