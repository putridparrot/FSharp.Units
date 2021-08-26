namespace FSharp.Units.Tests

module LumenHourTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.LuminousEnergy
    open Helpers

    // Lumen hour to X and back

    [<Property>]
    let ``From Lumen hour to Talbot and back`` () =
        let property value = 
            let result = lmh.toTalbot (lmh.create value)
            let original = T.toLumenHour result

            original 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Lumen hour to Lumen minute and back`` () =
        let property value = 
            let result = lmh.toLumenMinute (lmh.create value)
            let original = lmmin.toLumenHour result
    
            original 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Lumen hour to Lumen second and back`` () =
        let property value = 
            let result = lmh.toLumenSecond (lmh.create value)
            let original = lms.toLumenHour result
    
            original 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)


    [<Test>]
    let ``Convert known Lumen hour to Talbot`` () =
        let talbot = lmh.toTalbot 1.2<lmh>
    
        talbot
        |> should (equalWithin 0.1) 4320.0

    [<Test>]
    let ``Convert known Lumen hour to Lumen minute`` () =
        let lumenMinute = lmh.toLumenMinute 89.12<lmh>
    
        lumenMinute
        |> should (equalWithin 0.1) 5347.2

    [<Test>]
    let ``Convert known Lumen hour to Lumen second`` () =
        let lumenSeconds = lmh.toLumenSecond 67.9<lmh>
    
        lumenSeconds
        |> should (equalWithin 0.1) 244440.0

