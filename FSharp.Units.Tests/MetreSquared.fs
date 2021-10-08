namespace FSharp.Units.Tests

module MetresSquaredTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Area
    open Helpers

    // Metres Squared to X and back

    [<Property>]
    let ``From Metres squared to Acre and back`` () =
        let property value = 
            let result = m2.toAcre (m2.create value)
            let squareMile = acre.toSquareMetre result

            squareMile 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Metres squared to Miles Squared and back`` () =
        let property value = 
            let result = m2.toSquareMile (m2.create value)
            let squareMile = mile2.toSquareMetre result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Metres squared to Square Feet and back`` () =
        let property value = 
            let result = m2.toSquareFeet (m2.create value)
            let squareMile = feet2.toSquareMetre result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Metres squared to Square Inch and back`` () =
        let property value = 
            let result = m2.toSquareInch (m2.create value)
            let squareMile = inch2.toSquareMetre result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Metres squared to Square Kilometre and back`` () =
        let property value = 
            let result = m2.toSquareKilometre (m2.create value)
            let squareMile = km2.toSquareMetre result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Metres squared to Hectare and back`` () =
        let property value = 
            let result = m2.toHectare (m2.create value)
            let squareMile = hectare.toSquareMetre result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Metres squared to Square Yard and back`` () =
        let property value = 
            let result = m2.toSquareYard (m2.create value)
            let squareMile = yard2.toSquareMetre result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)
