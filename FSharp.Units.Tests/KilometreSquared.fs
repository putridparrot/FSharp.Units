namespace FSharp.Units.Tests

module KilometresSquaredTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Area
    open Helpers

    // Kilometres Squared to X and back

    [<Property>]
    let ``From Kilometres squared to Acre and back`` () =
        let property value = 
            let result = km2.toAcre (km2.create value)
            let squareMile = acre.toSquareKilometre result

            squareMile 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Kilometres squared to Miles Squared and back`` () =
        let property value = 
            let result = km2.toSquareMile (km2.create value)
            let squareMile = mile2.toSquareKilometre result
    
            squareMile 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Kilometres squared to Square Feet and back`` () =
        let property value = 
            let result = km2.toSquareFeet (km2.create value)
            let squareMile = feet2.toSquareKilometre result
    
            squareMile 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Kilometres squared to Square Inch and back`` () =
        let property value = 
            let result = km2.toSquareInch (km2.create value)
            let squareMile = inch2.toSquareKilometre result
    
            squareMile 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Kilometres squared to Square Metre and back`` () =
        let property value = 
            let result = km2.toSquareMetre (km2.create value)
            let squareMile = m2.toSquareKilometre result
    
            squareMile 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Kilometres squared to Hectare and back`` () =
        let property value = 
            let result = km2.toHectare (km2.create value)
            let squareMile = hectare.toSquareKilometre result
    
            squareMile 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Kilometres squared to Square Yard and back`` () =
        let property value = 
            let result = km2.toSquareYard (km2.create value)
            let squareMile = yard2.toSquareKilometre result
    
            squareMile 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)
