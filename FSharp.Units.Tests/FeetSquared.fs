namespace FSharp.Units.Tests

module FeetSquaredTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Area
    open Helpers

    // Feet Squared to X and back

    [<Property>]
    let ``From Feet squared to Acre and back`` () =
        let property value = 
            let result = feet2.toAcre (feet2.create value)
            let squareFeet = acre.toSquareFeet result

            squareFeet 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Feet squared to Miles Squared and back`` () =
        let property value = 
            let result = feet2.toSquareMile (feet2.create value)
            let squareFeet = mile2.toSquareFeet result
    
            squareFeet 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Feet squared to Square Yard and back`` () =
        let property value = 
            let result = feet2.toSquareYard (feet2.create value)
            let squareFeet = yard2.toSquareFeet result
    
            squareFeet 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Feet squared to Square Inch and back`` () =
        let property value = 
            let result = feet2.toSquareInch (feet2.create value)
            let squareFeet = inch2.toSquareFeet result
    
            squareFeet 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Feet squared to Square Metre and back`` () =
        let property value = 
            let result = feet2.toSquareMetre (feet2.create value)
            let squareFeet = m2.toSquareFeet result
    
            squareFeet 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Feet squared to Hectare and back`` () =
        let property value = 
            let result = feet2.toHectare (feet2.create value)
            let squareFeet = hectare.toSquareFeet result
    
            squareFeet 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Feet squared to Square Kilometre and back`` () =
        let property value = 
            let result = feet2.toSquareKilometre (feet2.create value)
            let squareFeet = km2.toSquareFeet result
    
            squareFeet 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)
