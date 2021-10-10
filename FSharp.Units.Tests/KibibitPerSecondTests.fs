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
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kibibit per second to Mega bits per second and back`` () =
        let property value = 
            let result = Kibitps.toMegaBitsPerSecond (Kibitps.create value)
            let back = Mbps.toKibibitPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kibibit per second to Tera bits per second and back`` () =
        let property value = 
            let result = Kibitps.toTeraBitsPerSecond (Kibitps.create value)
            let back = Tbps.toKibibitPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kibibit per second to kilo bytes per second and back`` () =
        let property value = 
            let result = Kibitps.toKiloBytesPerSecond (Kibitps.create value)
            let back = kBps.toKibibitPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kibibit per second to Mega bytes per second and back`` () =
        let property value = 
            let result = Kibitps.toMegaBytesPerSecond (Kibitps.create value)
            let back = MBps.toKibibitPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kibibit per second to Giga bytes per second and back`` () =
        let property value = 
            let result = Kibitps.toGigaBytesPerSecond (Kibitps.create value)
            let back = GBps.toKibibitPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Kibibit per second to Tera bytes per second and back`` () =
        let property value = 
            let result = Kibitps.toTeraBytesPerSecond (Kibitps.create value)
            let back = TBps.toKibibitPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<Kibitps>, 1228.8)>]
    let ``Convert known Kibibit per second to bits per second`` (input, expectation) =
        Kibitps.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation
    
    [<TestCase(1.23<Kibitps>, 1.25952)>]
    let ``Convert known Kibibit per second to kilo bits per second`` (input, expectation) =
        Kibitps.toKiloBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(456.<Kibitps>, 0.466944)>]
    let ``Convert known Kibibit per second to mega bits per second`` (input, expectation) =
        Kibitps.toMegaBitsPerSecond input
        |> should (equalWithin 0.01) expectation


    [<TestCase(13456.<Kibitps>, 0.013778944)>]
    let ``Convert known Kibibit per second to giga bits per second`` (input, expectation) =
        Kibitps.toGigaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(13456.<Kibitps>, 1.722368)>]
    let ``Convert known Kibibit per second to mega bytes per second`` (input, expectation) =
        Kibitps.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(10990.<Kibitps>, 0.01099)>]
    let ``Convert known Kibibit per second to giga bytes per second`` (input, expectation) =
        Kibitps.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation
    
    [<TestCase(8912345.<Kibitps>, 0.008912345)>]
    let ``Convert known Kibibit per second to tera bytes per second`` (input, expectation) =
        Kibitps.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

