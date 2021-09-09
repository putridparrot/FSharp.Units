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
            let back = bps.toKiloBitsPerSecond result

            back
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Giga bits per second to kilo bits per second and back`` () =
        let property value = 
            let result = Gbps.toKiloBitsPerSecond (Gbps.create value)
            let back = kbps.toMegaBytesPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Giga bits per second to Mega bits per second and back`` () =
        let property value = 
            let result = Gbps.toMegaBitsPerSecond (Gbps.create value)
            let back = Mbps.toBitsPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Giga bits per second to Tera bits per second and back`` () =
        let property value = 
            let result = Gbps.toTeraBitsPerSecond (Gbps.create value)
            let back = Tbps.toBitsPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Giga bits per second to Mega bytes per second and back`` () =
        let property value = 
            let result = Gbps.toMegaBytesPerSecond (Gbps.create value)
            let back = MBps.toBitsPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Giga bits per second to Giga bytes per second and back`` () =
        let property value = 
            let result = Gbps.toGigaBytesPerSecond (Gbps.create value)
            let back = GBps.toBitsPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Giga bits per second to Tera bytes per second and back`` () =
        let property value = 
            let result = Gbps.toTeraBytesPerSecond (Gbps.create value)
            let back = TBps.toBitsPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Giga bits per second to bits per second`` () =
        let result = Gbps.toBitsPerSecond 1.23<Gbps>
    
        result
        |> should (equalWithin 0.01) 1230000.
    
    [<Test>]
    let ``Convert known Giga bits per second to kilo bits per second`` () =
        let result = Gbps.toKiloBitsPerSecond 1.23<Gbps>
    
        result
        |> should (equalWithin 0.01) 1230.

    [<Test>]
    let ``Convert known Giga bits per second to mega bits per second`` () =
        let result = Gbps.toMegaBitsPerSecond 1090.<Gbps>
    
        result
        |> should (equalWithin 0.01) 1.09


    [<Test>]
    let ``Convert known Giga bits per second to kilo bytes per second`` () =
        let result = Gbps.toKiloBytesPerSecond 9.2<Gbps>
    
        result
        |> should (equalWithin 0.01) 1150.

    [<Test>]
    let ``Convert known Giga bits per second to mega bytes per second`` () =
        let result = Gbps.toMegaBytesPerSecond 9.2<Gbps>
    
        result
        |> should (equalWithin 0.01) 1.15

    [<Test>]
    let ``Convert known Giga bits per second to giga bytes per second`` () =
        let result = Gbps.toGigaBytesPerSecond 819.<Gbps>
    
        result
        |> should (equalWithin 0.01) 0.102375
    
    [<Test>]
    let ``Convert known Giga bits per second to tera bytes per second`` () =
        let result = Gbps.toTeraBytesPerSecond 123456.<Gbps>

        result
        |> should (equalWithin 0.01) 0.015432

