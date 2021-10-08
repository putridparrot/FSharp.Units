namespace FSharp.Units.Tests

module LumenSecondTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.LuminousEnergy
    open Helpers

    // Lumen second to X and back

    [<Property>]
    let ``From Lumen second to Talbot and back`` () =
        let property value = 
            let result = lms.toTalbot (lms.create value)
            let original = T.toLumenSecond result

            original 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Lumen second to Lumen hour and back`` () =
        let property value = 
            let result = lms.toLumenHour (lms.create value)
            let original = lmh.toLumenSecond result
    
            original 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Lumen second to Lumen minute and back`` () =
        let property value = 
            let result = lms.toLumenMinute (lms.create value)
            let original = lmmin.toLumenSecond result
    
            original 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Lumen second to Talbot`` () =
        let result = lms.toTalbot 5678.<lms>
    
        result
        |> should (equalWithin 0.01) 5678.0

    [<Test>]
    let ``Convert known Lumen second to Lumen hour`` () =
        let result = lms.toLumenHour 6722.<lms>
    
        result
        |> should (equalWithin 0.01) 1.8672

    [<Test>]
    let ``Convert known Lumen second to Lumen minute`` () =
        let result = lms.toLumenMinute 4321.0<lms>
    
        result
        |> should (equalWithin 0.01) 72.0167
