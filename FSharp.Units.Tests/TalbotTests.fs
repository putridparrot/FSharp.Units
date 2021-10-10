namespace FSharp.Units.Tests

module TalbotTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.LuminousEnergy
    open Helpers

    // Talbot to X and back

    [<Property>]
    let ``From Talbot to Lumen second and back`` () =
        let property value = 
            let result = T.toLumenSecond (T.create value)
            let original = lms.toTalbot result

            original 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Talbot to Lumen hour and back`` () =
        let property value = 
            let result = T.toLumenHour (T.create value)
            let original = lmh.toTalbot result
    
            original 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Talbot to Lumen minute and back`` () =
        let property value = 
            let result = T.toLumenMinute (T.create value)
            let original = lmmin.toTalbot result
    
            original 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5678.<T>, 5678.0)>]
    let ``Convert known Talbot to Lumen second`` (input, expectation) =
        T.toLumenSecond input
        |> should (equalWithin 0.01) expectation

    [<TestCase(5678.<T>, 1.5772)>]
    let ``Convert known Talbot to Lumen hour`` (input, expectation) =
        T.toLumenHour input
        |> should (equalWithin 0.01) expectation

    [<TestCase(1456.0<T>, 24.2667)>]
    let ``Convert known Talbot to Lumen minute`` (input, expectation) =
        T.toLumenMinute input
        |> should (equalWithin 0.01) expectation
