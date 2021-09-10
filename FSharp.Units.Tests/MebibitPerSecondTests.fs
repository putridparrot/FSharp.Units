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
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mebibit per second to Mega bits per second and back`` () =
        let property value = 
            let result = Mibit.toMegaBitsPerSecond (Mibit.create value)
            let back = Mbps.toMebibitPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mebibit per second to Tera bits per second and back`` () =
        let property value = 
            let result = Mibit.toTeraBitsPerSecond (Mibit.create value)
            let back = Tbps.toMebibitPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mebibit per second to kilo bytes per second and back`` () =
        let property value = 
            let result = Mibit.toKiloBytesPerSecond (Mibit.create value)
            let back = kBps.toMebibitPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mebibit per second to Mega bytes per second and back`` () =
        let property value = 
            let result = Mibit.toMegaBytesPerSecond (Mibit.create value)
            let back = MBps.toMebibitPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mebibit per second to Giga bytes per second and back`` () =
        let property value = 
            let result = Mibit.toGigaBytesPerSecond (Mibit.create value)
            let back = GBps.toMebibitPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mebibit per second to Tera bytes per second and back`` () =
        let property value = 
            let result = Mibit.toTeraBytesPerSecond (Mibit.create value)
            let back = TBps.toMebibitPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``Mebibit per second to Kibibit per second and back`` () =
        let property value = 
            let result = Mibit.toKibibitPerSecond (Mibit.create value)
            let back = Kibitps.toMebibitPerSecond result
    
            back
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Mebibit per second to bits per second`` () =
        let result = Mibit.toBitsPerSecond 0.1<Mibit>
    
        result
        |> should (equalWithin 0.1) 104858.
    
    [<Test>]
    let ``Convert known Mebibit per second to kilo bits per second`` () =
        let result = Mibit.toKiloBitsPerSecond 1.23<Mibit>
    
        result
        |> should (equalWithin 0.01) 1289.748

    [<Test>]
    let ``Convert known Mebibit per second to mega bits per second`` () =
        let result = Mibit.toMegaBitsPerSecond 456.<Mibit>
    
        result
        |> should (equalWithin 0.1) 478.151


    [<Test>]
    let ``Convert known Mebibit per second to giga bits per second`` () =
        let result = Mibit.toGigaBitsPerSecond 13456.<Mibit>
    
        result
        |> should (equalWithin 0.01) 14.109639

    [<Test>]
    let ``Convert known Mebibit per second to mega bytes per second`` () =
        let result = Mibit.toMegaBytesPerSecond 13456.<Mibit>
    
        result
        |> should (equalWithin 0.1) 1763.7048

    [<Test>]
    let ``Convert known Mebibit per second to giga bytes per second`` () =
        let result = Mibit.toGigaBytesPerSecond 10990.<Mibit>
    
        result
        |> should (equalWithin 0.01) 1.4404813
    
    [<Test>]
    let ``Convert known Mebibit per second to tera bytes per second`` () =
        let result = Mibit.toTeraBytesPerSecond 8912345.<Mibit>

        result
        |> should (equalWithin 0.01) 1.168158884

    [<Test>]
    let ``Convert known Mebibit per second to kibibit bytes per second`` () =
        let result = Mibit.toKibibitPerSecond 123.<Mibit>
    
        result
        |> should (equalWithin 0.01) 125952.
    
