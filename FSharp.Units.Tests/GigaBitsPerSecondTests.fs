namespace FSharp.Units.Tests

module GigaBitsPerSecondTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.DataTransferRate
    open Helpers

     // Giga bits per second to X and back

    [<Property>]
    let ``Giga bits per second to bits per second and back`` () =
        let property value = 
            let result = Gbps.toBitsPerSecond (Gbps.create value)
            let back = bps.toGigaBitsPerSecond result

            back
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Giga bits per second to kilo bits per second and back`` () =
        let property value = 
            let result = Gbps.toKiloBitsPerSecond (Gbps.create value)
            let back = kbps.toGigaBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Giga bits per second to Mega bits per second and back`` () =
        let property value = 
            let result = Gbps.toMegaBitsPerSecond (Gbps.create value)
            let back = Mbps.toGigaBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Giga bits per second to Tera bits per second and back`` () =
        let property value = 
            let result = Gbps.toTeraBitsPerSecond (Gbps.create value)
            let back = Tbps.toGigaBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Giga bits per second to Mega bytes per second and back`` () =
        let property value = 
            let result = Gbps.toMegaBytesPerSecond (Gbps.create value)
            let back = MBps.toGigaBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Giga bits per second to Giga bytes per second and back`` () =
        let property value = 
            let result = Gbps.toGigaBytesPerSecond (Gbps.create value)
            let back = GBps.toGigaBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Giga bits per second to Tera bytes per second and back`` () =
        let property value = 
            let result = Gbps.toTeraBytesPerSecond (Gbps.create value)
            let back = TBps.toGigaBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.23<Gbps>, 1.23e+9)>]
    let ``Convert known Giga bits per second to bits per second`` (input, expectation) =
        Gbps.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation
    
    [<TestCase(1.23<Gbps>, 1230000.)>]
    let ``Convert known Giga bits per second to kilo bits per second`` (input, expectation) =
        Gbps.toKiloBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1090.<Gbps>, 1090000.)>]
    let ``Convert known Giga bits per second to mega bits per second`` (input, expectation) =
        Gbps.toMegaBitsPerSecond input
        |> should (equalWithin 0.01) expectation


    [<TestCase(9.2<Gbps>, 1.15e+6)>]
    let ``Convert known Giga bits per second to kilo bytes per second`` (input, expectation) =
        Gbps.toKiloBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(9.2<Gbps>, 1150.)>]
    let ``Convert known Giga bits per second to mega bytes per second`` (input, expectation) =
        Gbps.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(819.<Gbps>, 102.375)>]
    let ``Convert known Giga bits per second to giga bytes per second`` (input, expectation) =
        Gbps.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation
    
    [<TestCase(123456.<Gbps>, 15.432)>]
    let ``Convert known Giga bits per second to tera bytes per second`` (input, expectation) =
        Gbps.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

