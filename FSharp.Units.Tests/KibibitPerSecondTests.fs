namespace FSharp.Units.Tests

module KibibitPerSecondTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.DataTransferRate
    open Helpers

     // Kibibit per second to X and back

    [<Property>]
    let ``Kibibit per second to bits per second and back`` () =
        let property value = 
            let result = Kibitps.toBitsPerSecond (Kibitps.create value)
            let back = bps.toKibibitPerSecond result

            back
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kibibit per second to Mega bits per second and back`` () =
        let property value = 
            let result = Kibitps.toMegaBitsPerSecond (Kibitps.create value)
            let back = Mbps.toKibibitPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kibibit per second to Tera bits per second and back`` () =
        let property value = 
            let result = Kibitps.toTeraBitsPerSecond (Kibitps.create value)
            let back = Tbps.toKibibitPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kibibit per second to kilo bytes per second and back`` () =
        let property value = 
            let result = Kibitps.toKiloBytesPerSecond (Kibitps.create value)
            let back = kBps.toKibibitPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kibibit per second to Mega bytes per second and back`` () =
        let property value = 
            let result = Kibitps.toMegaBytesPerSecond (Kibitps.create value)
            let back = MBps.toKibibitPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kibibit per second to Giga bytes per second and back`` () =
        let property value = 
            let result = Kibitps.toGigaBytesPerSecond (Kibitps.create value)
            let back = GBps.toKibibitPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kibibit per second to Tera bytes per second and back`` () =
        let property value = 
            let result = Kibitps.toTeraBytesPerSecond (Kibitps.create value)
            let back = TBps.toKibibitPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Kibibit per second to bits per second`` () =
        let result = Kibitps.toBitsPerSecond 1.2<Kibitps>
    
        result
        |> should (equalWithin 0.01) 1228.8
    
    [<Test>]
    let ``Convert known Kibibit per second to kilo bits per second`` () =
        let result = Kibitps.toKiloBitsPerSecond 1.23<Kibitps>
    
        result
        |> should (equalWithin 0.01) 1.25952

    [<Test>]
    let ``Convert known Kibibit per second to mega bits per second`` () =
        let result = Kibitps.toMegaBitsPerSecond 456.<Kibitps>
    
        result
        |> should (equalWithin 0.01) 0.466944


    [<Test>]
    let ``Convert known Kibibit per second to giga bits per second`` () =
        let result = Kibitps.toGigaBitsPerSecond 13456.<Kibitps>
    
        result
        |> should (equalWithin 0.01) 0.013778944

    [<Test>]
    let ``Convert known Kibibit per second to mega bytes per second`` () =
        let result = Kibitps.toMegaBytesPerSecond 13456.<Kibitps>
    
        result
        |> should (equalWithin 0.01) 1.722368

    [<Test>]
    let ``Convert known Kibibit per second to giga bytes per second`` () =
        let result = Kibitps.toGigaBytesPerSecond 10990.<Kibitps>
    
        result
        |> should (equalWithin 0.01) 0.01099
    
    [<Test>]
    let ``Convert known Kibibit per second to tera bytes per second`` () =
        let result = Kibitps.toTeraBytesPerSecond 8912345.<Kibitps>

        result
        |> should (equalWithin 0.01) 0.008912345

