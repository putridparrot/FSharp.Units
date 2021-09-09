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
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bits per second to Mega bits per second and back`` () =
        let property value = 
            let result = kbps.toMegaBitsPerSecond (kbps.create value)
            let back = Mbps.toKiloBitsPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bits per second to Giga bits per second and back`` () =
        let property value = 
            let result = kbps.toGigaBitsPerSecond (kbps.create value)
            let back = Gbps.toKiloBitsPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bits per second to Tera bits per second and back`` () =
        let property value = 
            let result = kbps.toTeraBitsPerSecond (kbps.create value)
            let back = Tbps.toKiloBitsPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bits per second to Mega bytes per second and back`` () =
        let property value = 
            let result = kbps.toMegaBytesPerSecond (kbps.create value)
            let back = MBps.toKiloBitsPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bits per second to Giga bytes per second and back`` () =
        let property value = 
            let result = kbps.toGigaBytesPerSecond (kbps.create value)
            let back = GBps.toKiloBitsPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kilo bits per second to Tera bytes per second and back`` () =
        let property value = 
            let result = kbps.toTeraBytesPerSecond (kbps.create value)
            let back = TBps.toKiloBitsPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Kilo bits per second to bits per second`` () =
        let result = kbps.toBitsPerSecond 12.<kbps>
    
        result
        |> should (equalWithin 0.01) 12000.
    
    [<Test>]
    let ``Convert known Kilo bits per second to mega bits per second`` () =
        let result = kbps.toMegaBitsPerSecond 312.<kbps>
    
        result
        |> should (equalWithin 0.01) 0.312

    [<Test>]
    let ``Convert known Kilo bits per second to giga bits per second`` () =
        let result = kbps.toGigaBitsPerSecond 3125.<kbps>
    
        result
        |> should (equalWithin 0.01) 0.003125


    [<Test>]
    let ``Convert known Kilo bits per second to kilo bytes per second`` () =
        let result = kbps.toKiloBytesPerSecond 3125.<kbps>
    
        result
        |> should (equalWithin 0.01) 390.625

    [<Test>]
    let ``Convert known Kilo bits per second to mega bytes per second`` () =
        let result = kbps.toMegaBytesPerSecond 7890.<kbps>
    
        result
        |> should (equalWithin 0.01) 0.98625

    [<Test>]
    let ``Convert known Kilo bits per second to giga bytes per second`` () =
        let result = kbps.toGigaBytesPerSecond 1267801.<kbps>
    
        result
        |> should (equalWithin 0.01) 0.158475125
    
    [<Test>]
    let ``Convert known Kilo bits per second to tera bytes per second`` () =
        let result = kbps.toTeraBytesPerSecond 123456789.<kbps>

        result
        |> should (equalWithin 0.01) 0.015432098625

