namespace FSharp.Units.Tests

module BitsPerSecondTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.DataTransferRate
    open Helpers

     // Bits per second to X and back

    [<Property>]
    let ``Bits per second to Kilo bits per second and back`` () =
        let property value = 
            let result = bps.toKiloBitsPerSecond (bps.create value)
            let back = kbps.toBitsPerSecond result

            back
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Bits per second to Mega bits per second and back`` () =
        let property value = 
            let result = bps.toMegaBitsPerSecond (bps.create value)
            let back = Mbps.toBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Bits per second to Giga bits per second and back`` () =
        let property value = 
            let result = bps.toGigaBitsPerSecond (bps.create value)
            let back = Gbps.toBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Bits per second to Tera bits per second and back`` () =
        let property value = 
            let result = bps.toTeraBitsPerSecond (bps.create value)
            let back = Tbps.toBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Bits per second to Kilo bytes per second and back`` () =
        let property value = 
            let result = bps.toKiloBytesPerSecond (bps.create value)
            let back = kBps.toBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Bits per second to Mega bytes per second and back`` () =
        let property value = 
            let result = bps.toMegaBytesPerSecond (bps.create value)
            let back = MBps.toBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Bits per second to Giga bytes per second and back`` () =
        let property value = 
            let result = bps.toGigaBytesPerSecond (bps.create value)
            let back = GBps.toBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Bits per second to Tera bytes per second and back`` () =
        let property value = 
            let result = bps.toTeraBytesPerSecond (bps.create value)
            let back = TBps.toBitsPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Bits per second to Tera bytes per second`` () =
        let result = bps.toTeraBytesPerSecond 908.<bps>

        result
        |> should (equalWithin 0.01) 1.135e-10

