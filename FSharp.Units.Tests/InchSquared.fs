namespace FSharp.Units.Tests

module InchSquaredTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Area
    open Helpers

    // Inch Squared to X and back

    [<Property>]
    let ``From Inch squared to Acre and back`` () =
        let property value = 
            let result = inch2.toAcre (inch2.create value)
            let original = acre.toSquareInch result

            original 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Inch squared to Miles Squared and back`` () =
        let property value = 
            let result = inch2.toSquareMile (inch2.create value)
            let original = mile2.toSquareInch result
    
            original 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Inch squared to Square Yard and back`` () =
        let property value = 
            let result = inch2.toSquareYard (inch2.create value)
            let original = yard2.toSquareInch result
    
            original 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Inch squared to Square Feet and back`` () =
        let property value = 
            let result = inch2.toSquareFeet (inch2.create value)
            let original = feet2.toSquareInch result
    
            original 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Inch squared to Square Metre and back`` () =
        let property value = 
            let result = inch2.toSquareMetre (inch2.create value)
            let original = m2.toSquareInch result
    
            original 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Inch squared to Hectare and back`` () =
        let property value = 
            let result = inch2.toHectare (inch2.create value)
            let original = hectare.toSquareInch result
    
            original 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Inch squared to Square Kilometre and back`` () =
        let property value = 
            let result = inch2.toSquareKilometre (inch2.create value)
            let original = km2.toSquareInch result
    
            original 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)
