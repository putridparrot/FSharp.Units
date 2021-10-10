namespace FSharp.Units.Tests

module MebibitPerSecondTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.DataTransferRate
    open Helpers

     // Mebibit per second to X and back

    [<Property>]
    let ``Mebibit per second to bits per second and back`` () =
        let property value = 
            let result = Mibit.toBitsPerSecond (Mibit.create value)
            let back = bps.toMebibitPerSecond result

            back
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mebibit per second to Mega bits per second and back`` () =
        let property value = 
            let result = Mibit.toMegaBitsPerSecond (Mibit.create value)
            let back = Mbps.toMebibitPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mebibit per second to Tera bits per second and back`` () =
        let property value = 
            let result = Mibit.toTeraBitsPerSecond (Mibit.create value)
            let back = Tbps.toMebibitPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mebibit per second to kilo bytes per second and back`` () =
        let property value = 
            let result = Mibit.toKiloBytesPerSecond (Mibit.create value)
            let back = kBps.toMebibitPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mebibit per second to Mega bytes per second and back`` () =
        let property value = 
            let result = Mibit.toMegaBytesPerSecond (Mibit.create value)
            let back = MBps.toMebibitPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mebibit per second to Giga bytes per second and back`` () =
        let property value = 
            let result = Mibit.toGigaBytesPerSecond (Mibit.create value)
            let back = GBps.toMebibitPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mebibit per second to Tera bytes per second and back`` () =
        let property value = 
            let result = Mibit.toTeraBytesPerSecond (Mibit.create value)
            let back = TBps.toMebibitPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mebibit per second to Kibibit per second and back`` () =
        let property value = 
            let result = Mibit.toKibibitPerSecond (Mibit.create value)
            let back = Kibitps.toMebibitPerSecond result
    
            back
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.1<Mibit>, 104857.6)>]
    [<TestCase(78.<Mibit>, 8.179e+7)>]
    [<TestCase(0.0067<Mibit>, 7025.4592)>]
    let ``Convert known Mebibit per second to bits per second`` (input, expectation) =
        Mibit.toBitsPerSecond input
        |> should (equalWithin 0.01) expectation
    
    [<TestCase(1.23<Mibit>, 1289.748)>]
    [<TestCase(78.<Mibit>, 81788.9)>]
    [<TestCase(0.9<Mibit>, 943.718)>]
    let ``Convert known Mebibit per second to kilo bits per second`` (input, expectation) =
        Mibit.toKiloBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(456.<Mibit>, 478.151)>]
    [<TestCase(78.12<Mibit>, 81.914757)>]
    [<TestCase(0.98<Mibit>, 1.027604)>]
    let ``Convert known Mebibit per second to mega bits per second`` (input, expectation) =
        Mibit.toMegaBitsPerSecond input
        |> should (equalWithin 0.01) expectation


    [<TestCase(13456.<Mibit>, 14.109639)>]
    [<TestCase(99.15<Mibit>, 0.10396631)>]
    [<TestCase(0.9<Mibit>, 0.000943718)>]
    let ``Convert known Mebibit per second to giga bits per second`` (input, expectation) =
        Mibit.toGigaBitsPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(13456.<Mibit>, 1763.7048)>]
    [<TestCase(99.15<Mibit>, 12.995789)>]
    [<TestCase(0.9<Mibit>, 0.117965)>]
    let ``Convert known Mebibit per second to mega bytes per second`` (input, expectation) =
        Mibit.toMegaBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(10990.<Mibit>, 1.4404813)>]
    [<TestCase(99.15<Mibit>, 0.012995789)>]
    [<TestCase(1.9<Mibit>, 0.000249037)>]
    let ``Convert known Mebibit per second to giga bytes per second`` (input, expectation) =
        Mibit.toGigaBytesPerSecond input
        |> should (equalWithin 0.01) expectation
    
    [<TestCase(8912345.<Mibit>, 1.168158884)>]
    [<TestCase(99999<Mibit>, 0.013107069)>]
    [<TestCase(1.9<Mibit>, 2.4904e-7)>]
    let ``Convert known Mebibit per second to tera bytes per second`` (input, expectation) =
        Mibit.toTeraBytesPerSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(123.<Mibit>, 125952.)>]
    [<TestCase(99<Mibit>, 101376)>]
    [<TestCase(1.9<Mibit>, 1945.6)>]
    let ``Convert known Mebibit per second to kibibit bytes per second`` (input, expectation) =
        Mibit.toKibibitPerSecond input
        |> should (equalWithin 0.01) expectation
    
