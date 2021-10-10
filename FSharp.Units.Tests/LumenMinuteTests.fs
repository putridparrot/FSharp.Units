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
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Lumen minute to Lumen hour and back`` () =
        let property value = 
            let result = lmmin.toLumenHour (lmmin.create value)
            let original = lmh.toLumenMinute result
    
            original 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Lumen minute to Lumen second and back`` () =
        let property value = 
            let result = lmmin.toLumenSecond (lmmin.create value)
            let original = lms.toLumenMinute result
    
            original 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.<lmmin>, 7380.0)>]
    let ``Convert known Lumen minute to Talbot`` (input, expectation) =
        lmmin.toTalbot input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1900.<lmmin>, 31.667)>]
    let ``Convert known Lumen minute to Lumen hour`` (input, expectation) =
        lmmin.toLumenHour input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.1<lmmin>, 726.)>]
    let ``Convert known Lumen minute to Lumen second`` (input, expectation) =
        lmmin.toLumenSecond input
        |> should (equalWithin 0.01) expectation
