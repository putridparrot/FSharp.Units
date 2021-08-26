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
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Talbot to Lumen hour and back`` () =
        let property value = 
            let result = T.toLumenHour (T.create value)
            let original = lmh.toTalbot result
    
            original 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Talbot to Lumen minute and back`` () =
        let property value = 
            let result = T.toLumenMinute (T.create value)
            let original = lmmin.toTalbot result
    
            original 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Talbot to Lumen second`` () =
        let result = T.toLumenSecond 5678.<T>
    
        result
        |> should (equalWithin 0.1) 5678.0

    [<Test>]
    let ``Convert known Talbot to Lumen hour`` () =
        let result = T.toLumenHour 5678.<T>
    
        result
        |> should (equalWithin 0.01) 1.5772

    [<Test>]
    let ``Convert known Talbot to Lumen minute`` () =
        let result = T.toLumenMinute 1456.0<T>
    
        result
        |> should (equalWithin 0.01) 24.2667
