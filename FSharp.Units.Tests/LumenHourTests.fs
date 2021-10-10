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
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Lumen hour to Lumen minute and back`` () =
        let property value = 
            let result = lmh.toLumenMinute (lmh.create value)
            let original = lmmin.toLumenHour result
    
            original 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Lumen hour to Lumen second and back`` () =
        let property value = 
            let result = lmh.toLumenSecond (lmh.create value)
            let original = lms.toLumenHour result
    
            original 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)


    [<TestCase(1.2<lmh>, 4320.0)>]
    let ``Convert known Lumen hour to Talbot`` (input, expectation) =
        lmh.toTalbot input
        |> should (equalWithin 0.01) expectation

    [<TestCase(89.12<lmh>, 5347.2)>]
    let ``Convert known Lumen hour to Lumen minute`` (input, expectation) =
        lmh.toLumenMinute input
        |> should (equalWithin 0.01) expectation

    [<TestCase(67.9<lmh>, 244440.)>]
    let ``Convert known Lumen hour to Lumen second`` (input, expectation) =
        lmh.toLumenSecond input
        |> should (equalWithin 0.01) expectation

