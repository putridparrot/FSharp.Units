namespace FSharp.Units.Tests

module KiloBytesPerSecondTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.DataTransferRate
    open Helpers

     // Kilo bytes per second to X and back

    [<Property>]
    let ``Kilo bytes per second to bits per second and back`` () =
        let property value = 
            let result = kBps.toBitsPerSecond (kBps.create value)
            let back = bps.toKiloBytesPerSecond result

            back
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bytes per second to Mega bits per second and back`` () =
        let property value = 
            let result = kBps.toMegaBitsPerSecond (kBps.create value)
            let back = Mbps.toKiloBytesPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bytes per second to Tera bits per second and back`` () =
        let property value = 
            let result = kBps.toTeraBitsPerSecond (kBps.create value)
            let back = Tbps.toKiloBytesPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bytes per second to Mega bytes per second and back`` () =
        let property value = 
            let result = kBps.toMegaBytesPerSecond (kBps.create value)
            let back = MBps.toKiloBytesPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bytes per second to Giga bytes per second and back`` () =
        let property value = 
            let result = kBps.toGigaBytesPerSecond (kBps.create value)
            let back = GBps.toKiloBytesPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bytes per second to Tera bytes per second and back`` () =
        let property value = 
            let result = kBps.toTeraBytesPerSecond (kBps.create value)
            let back = TBps.toKiloBytesPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<kBps>, 9600.)>]
    let ``Convert known Kilo bytes per second to bits per second`` (input, expectation) =
        kBps.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation
    
    [<TestCase(1.23<kBps>, 9.84)>]
    let ``Convert known Kilo bytes per second to kilo bits per second`` (input, expectation) =
        kBps.toKiloBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(456.<kBps>, 3.648)>]
    let ``Convert known Kilo bytes per second to mega bits per second`` (input, expectation) =
        kBps.toMegaBitsPerSecond input
        |> should (equalWithin 0.01) expectation


    [<TestCase(13456.<kBps>, 0.107648)>]
    let ``Convert known Kilo bytes per second to giga bits per second`` (input, expectation) =
        kBps.toGigaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(13456.<kBps>, 13.456)>]
    let ``Convert known Kilo bytes per second to mega bytes per second`` (input, expectation) =
        kBps.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(10990.<kBps>, 0.01099)>]
    let ``Convert known Kilo bytes per second to giga bytes per second`` (input, expectation) =
        kBps.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation
    
    [<TestCase(8912345.<kBps>, 0.008912345)>]
    let ``Convert known Kilo bytes per second to tera bytes per second`` (input, expectation) =
        kBps.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

