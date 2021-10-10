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

    [<TestCase(5678.<lms>, 5678.0)>]
    let ``Convert known Lumen second to Talbot`` (input, expectation) =
        lms.toTalbot input
        |> should (equalWithin 0.01) expectation

    [<TestCase(6722.<lms>, 1.8672)>]
    let ``Convert known Lumen second to Lumen hour`` (input, expectation) =
        lms.toLumenHour input
        |> should (equalWithin 0.01) expectation

    [<TestCase(4321.0<lms>, 72.0167)>]
    let ``Convert known Lumen second to Lumen minute`` (input, expectation) =
        lms.toLumenMinute input
        |> should (equalWithin 0.01) expectation
