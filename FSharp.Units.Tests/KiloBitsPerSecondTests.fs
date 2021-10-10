namespace FSharp.Units.Tests

module KiloBitsPerSecondTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.DataTransferRate
    open Helpers

     // Kilo Bits per second to X and back

    [<Property>]
    let ``Kilo bits per second to bits per second and back`` () =
        let property value = 
            let result = kbps.toBitsPerSecond (kbps.create value)
            let back = bps.toKiloBitsPerSecond result

            back
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bits per second to Mega bits per second and back`` () =
        let property value = 
            let result = kbps.toMegaBitsPerSecond (kbps.create value)
            let back = Mbps.toKiloBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bits per second to Giga bits per second and back`` () =
        let property value = 
            let result = kbps.toGigaBitsPerSecond (kbps.create value)
            let back = Gbps.toKiloBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bits per second to Tera bits per second and back`` () =
        let property value = 
            let result = kbps.toTeraBitsPerSecond (kbps.create value)
            let back = Tbps.toKiloBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bits per second to Mega bytes per second and back`` () =
        let property value = 
            let result = kbps.toMegaBytesPerSecond (kbps.create value)
            let back = MBps.toKiloBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bits per second to Giga bytes per second and back`` () =
        let property value = 
            let result = kbps.toGigaBytesPerSecond (kbps.create value)
            let back = GBps.toKiloBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bits per second to Tera bytes per second and back`` () =
        let property value = 
            let result = kbps.toTeraBytesPerSecond (kbps.create value)
            let back = TBps.toKiloBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.<kbps>, 12000.)>]
    let ``Convert known Kilo bits per second to bits per second`` (input, expectation) =
        kbps.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation
    
    [<TestCase(312.<kbps>, 0.312)>]
    let ``Convert known Kilo bits per second to mega bits per second`` (input, expectation) =
        kbps.toMegaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3125.<kbps>, 0.003125)>]
    let ``Convert known Kilo bits per second to giga bits per second`` (input, expectation) =
        kbps.toGigaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(3125.<kbps>, 390.625)>]
    let ``Convert known Kilo bits per second to kilo bytes per second`` (input, expectation) =
        kbps.toKiloBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(7890.<kbps>, 0.98625)>]
    let ``Convert known Kilo bits per second to mega bytes per second`` (input, expectation) =
        kbps.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1267801.<kbps>, 0.158475125)>]
    let ``Convert known Kilo bits per second to giga bytes per second`` (input, expectation) =
        kbps.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation
    
    [<TestCase(123456789.<kbps>, 0.015432098625)>]
    let ``Convert known Kilo bits per second to tera bytes per second`` (input, expectation) =
        kbps.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

