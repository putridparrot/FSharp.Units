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

    [<Test>]
    let ``Convert known Mega bits per second to bits per second`` () =
        let result = Mbps.toBitsPerSecond 1.23<Mbps>
    
        result
        |> should (equalWithin 0.01) 1230000.
    
    [<Test>]
    let ``Convert known Mega bits per second to kilo bits per second`` () =
        let result = Mbps.toKiloBitsPerSecond 1.23<Mbps>
    
        result
        |> should (equalWithin 0.01) 1230.

    [<Test>]
    let ``Convert known Mega bits per second to giga bits per second`` () =
        let result = Mbps.toGigaBitsPerSecond 1090.<Mbps>
    
        result
        |> should (equalWithin 0.01) 1.09


    [<Test>]
    let ``Convert known Mega bits per second to kilo bytes per second`` () =
        let result = Mbps.toKiloBytesPerSecond 9.2<Mbps>
    
        result
        |> should (equalWithin 0.01) 1150.

    [<Test>]
    let ``Convert known Mega bits per second to mega bytes per second`` () =
        let result = Mbps.toMegaBytesPerSecond 9.2<Mbps>
    
        result
        |> should (equalWithin 0.01) 1.15

    [<Test>]
    let ``Convert known Mega bits per second to giga bytes per second`` () =
        let result = Mbps.toGigaBytesPerSecond 819.<Mbps>
    
        result
        |> should (equalWithin 0.01) 0.102375
    
    [<Test>]
    let ``Convert known Mega bits per second to tera bytes per second`` () =
        let result = Mbps.toTeraBytesPerSecond 123456.<Mbps>

        result
        |> should (equalWithin 0.01) 0.015432

