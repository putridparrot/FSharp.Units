namespace FSharp.Units.Tests

module MegaBitsPerSecondTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.DataTransferRate
    open Helpers

     // Mega Bits per second to X and back

    [<Property>]
    let ``Mega bits per second to bits per second and back`` () =
        let property value = 
            let result = Mbps.toBitsPerSecond (Mbps.create value)
            let back = bps.toMegaBitsPerSecond result

            back
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mega bits per second to kilo bits per second and back`` () =
        let property value = 
            let result = Mbps.toKiloBitsPerSecond (Mbps.create value)
            let back = kbps.toMegaBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mega bits per second to Giga bits per second and back`` () =
        let property value = 
            let result = Mbps.toGigaBitsPerSecond (Mbps.create value)
            let back = Gbps.toMegaBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mega bits per second to Tera bits per second and back`` () =
        let property value = 
            let result = Mbps.toTeraBitsPerSecond (Mbps.create value)
            let back = Tbps.toMegaBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mega bits per second to Mega bytes per second and back`` () =
        let property value = 
            let result = Mbps.toMegaBytesPerSecond (Mbps.create value)
            let back = MBps.toMegaBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mega bits per second to Giga bytes per second and back`` () =
        let property value = 
            let result = Mbps.toGigaBytesPerSecond (Mbps.create value)
            let back = GBps.toMegaBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mega bits per second to Tera bytes per second and back`` () =
        let property value = 
            let result = Mbps.toTeraBytesPerSecond (Mbps.create value)
            let back = TBps.toMegaBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.23<Mbps>, 1230000.)>]
    let ``Convert known Mega bits per second to bits per second`` (input, expectation) =
        Mbps.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation
    
    [<TestCase(1.23<Mbps>, 1230.)>]
    let ``Convert known Mega bits per second to kilo bits per second`` (input, expectation) =
        Mbps.toKiloBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1090.<Mbps>, 1.09)>]
    let ``Convert known Mega bits per second to giga bits per second`` (input, expectation) =
        Mbps.toGigaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(9.2<Mbps>, 1150.)>]
    let ``Convert known Mega bits per second to kilo bytes per second`` (input, expectation) =
        Mbps.toKiloBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(9.2<Mbps>, 1.15)>]
    let ``Convert known Mega bits per second to mega bytes per second`` (input, expectation) =
        Mbps.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(819.<Mbps>, 0.102375)>]
    let ``Convert known Mega bits per second to giga bytes per second`` (input, expectation) =
        Mbps.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation
    
    [<TestCase(123456.<Mbps>, 0.015432)>]
    let ``Convert known Mega bits per second to tera bytes per second`` (input, expectation) =
        Mbps.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

