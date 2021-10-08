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

    [<Test>]
    let ``Convert known Kilo bytes per second to bits per second`` () =
        let result = kBps.toBitsPerSecond 1.2<kBps>
    
        result
        |> should (equalWithin 0.01) 9600.
    
    [<Test>]
    let ``Convert known Kilo bytes per second to kilo bits per second`` () =
        let result = kBps.toKiloBitsPerSecond 1.23<kBps>
    
        result
        |> should (equalWithin 0.01) 9.84

    [<Test>]
    let ``Convert known Kilo bytes per second to mega bits per second`` () =
        let result = kBps.toMegaBitsPerSecond 456.<kBps>
    
        result
        |> should (equalWithin 0.01) 3.648


    [<Test>]
    let ``Convert known Kilo bytes per second to giga bits per second`` () =
        let result = kBps.toGigaBitsPerSecond 13456.<kBps>
    
        result
        |> should (equalWithin 0.01) 0.107648

    [<Test>]
    let ``Convert known Kilo bytes per second to mega bytes per second`` () =
        let result = kBps.toMegaBytesPerSecond 13456.<kBps>
    
        result
        |> should (equalWithin 0.01) 13.456

    [<Test>]
    let ``Convert known Kilo bytes per second to giga bytes per second`` () =
        let result = kBps.toGigaBytesPerSecond 10990.<kBps>
    
        result
        |> should (equalWithin 0.01) 0.01099
    
    [<Test>]
    let ``Convert known Kilo bytes per second to tera bytes per second`` () =
        let result = kBps.toTeraBytesPerSecond 8912345.<kBps>

        result
        |> should (equalWithin 0.01) 0.008912345

