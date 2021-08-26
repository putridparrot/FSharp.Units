namespace FSharp.Units.Tests

module LumenMinuteTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.LuminousEnergy
    open Helpers

    // Lumen minute to X and back

    [<Property>]
    let ``From Lumen minute to Talbot and back`` () =
        let property value = 
            let result = lmmin.toTalbot (lmmin.create value)
            let original = T.toLumenMinute result

            original 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Lumen minute to Lumen hour and back`` () =
        let property value = 
            let result = lmmin.toLumenHour (lmmin.create value)
            let original = lmh.toLumenMinute result
    
            original 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Lumen minute to Lumen second and back`` () =
        let property value = 
            let result = lmmin.toLumenSecond (lmmin.create value)
            let original = lms.toLumenMinute result
    
            original 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Lumen minute to Talbot`` () =
        let result = lmmin.toTalbot 123.<lmmin>
    
        result
        |> should (equalWithin 0.1) 7380.0

    [<Test>]
    let ``Convert known Lumen minute to Lumen hour`` () =
        let result = lmmin.toLumenHour 1900.<lmmin>
    
        result
        |> should (equalWithin 0.01) 31.667

    [<Test>]
    let ``Convert known Lumen minute to Lumen second`` () =
        let result = lmmin.toLumenSecond 12.1<lmmin>
    
        result
        |> should (equalWithin 0.01) 726.
