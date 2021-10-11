namespace FSharp.Units.Tests

module AcreTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Area
    open Helpers

    // Acre to X and back

    [<Property>]
    let ``From Acre to Hectare and back`` () =
        let property value = 
            let result = acre.toHectare (acre.create value)
            let a = hectare.toAcre result

            a 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Acre to Metre Squared and back`` () =
        let property value = 
            let result = acre.toSquareMetre (acre.create value)
            let a = m2.toAcre result
    
            a 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Acre to Square Feet and back`` () =
        let property value = 
            let result = acre.toSquareFeet (acre.create value)
            let a = feet2.toAcre result
    
            a 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Acre to Square Inch and back`` () =
        let property value = 
            let result = acre.toSquareInch (acre.create value)
            let a = inch2.toAcre result
    
            a 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Acre to Square Kilometre and back`` () =
        let property value = 
            let result = acre.toSquareKilometre (acre.create value)
            let a = km2.toAcre result
    
            a 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Acre to Square Mile and back`` () =
        let property value = 
            let result = acre.toSquareMile (acre.create value)
            let a = mile2.toAcre result
    
            a 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Acre to Square Yard and back`` () =
        let property value = 
            let result = acre.toSquareYard (acre.create value)
            let a = yard2.toAcre result
    
            a 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123<acre>, 49.7763)>]
    [<TestCase(78.<acre>, 31.5655)>]
    [<TestCase(0.9<acre>, 0.364217)>]
    let ``Convert known Acre to Hectare`` (input, expectation) =
        acre.toHectare input
        |> should (equalWithin 0.01) expectation

    [<TestCase(123<acre>, 497763.78)>]
    [<TestCase(78.<acre>, 315655.08)>]
    [<TestCase(0.9<acre>, 3642.174)>]
    let ``Convert known Acre to Square Metre`` (input, expectation) =
        acre.toSquareMetre input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12<acre>, 522720)>]
    [<TestCase(1.4<acre>, 60984.)>]
    [<TestCase(0.9<acre>, 39204)>]
    let ``Convert known Acre to Square Feet`` (input, expectation) =
        acre.toSquareFeet input
        |> should (equalWithin 0.01) expectation

    [<TestCase(0.1<acre>, 627300.)>]
    [<TestCase(6.<acre>, 37638000.)>]
    [<TestCase(0.089<acre>, 558297.)>]
    let ``Convert known Acre to Square Inch`` (input, expectation) =
        acre.toSquareInch input
        |> should (equalWithin 0.01) expectation

    [<TestCase(123.<acre>, 0.497763)>]
    [<TestCase(6.<acre>, 0.0242811)>]
    [<TestCase(4660.<acre>, 18.85835)>]
    let ``Convert known Acre to Square Kilometre`` (input, expectation) =
        acre.toSquareKilometre input
        |> should (equalWithin 0.01) expectation

    [<TestCase(123.<acre>, 0.192188)>]
    [<TestCase(6.<acre>, 0.009375)>]
    [<TestCase(4660.<acre>, 7.28125)>]
    let ``Convert known Acre to Square Mile`` (input, expectation) =
        acre.toSquareMile input
        |> should (equalWithin 0.01) expectation

    [<TestCase(12.<acre>, 58080)>]
    [<TestCase(0.9<acre>, 4356)>]
    [<TestCase(45.<acre>, 217800)>]
    let ``Convert known Acre to Square Yard`` (input, expectation) =
        acre.toSquareYard input
        |> should (equalWithin 0.01) expectation
