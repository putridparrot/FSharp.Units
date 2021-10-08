namespace FSharp.Units.Tests

module YardSquaredTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Area
    open Helpers

    // Yard Squared to X and back

    [<Property>]
    let ``From Yard squared to Acre and back`` () =
        let property value = 
            let result = yard2.toAcre (yard2.create value)
            let squareMile = acre.toSquareYard result

            squareMile 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Yard squared to Miles Squared and back`` () =
        let property value = 
            let result = yard2.toSquareMile (yard2.create value)
            let squareMile = mile2.toSquareYard result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Yard squared to Square Feet and back`` () =
        let property value = 
            let result = yard2.toSquareFeet (yard2.create value)
            let squareMile = feet2.toSquareYard result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Yard squared to Square Inch and back`` () =
        let property value = 
            let result = yard2.toSquareInch (yard2.create value)
            let squareMile = inch2.toSquareYard result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Yard squared to Square Metre and back`` () =
        let property value = 
            let result = yard2.toSquareMetre (yard2.create value)
            let squareMile = m2.toSquareYard result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Yard squared to Hectare and back`` () =
        let property value = 
            let result = yard2.toHectare (yard2.create value)
            let squareMile = hectare.toSquareYard result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Yard squared to Square Kilometre and back`` () =
        let property value = 
            let result = yard2.toSquareKilometre (yard2.create value)
            let squareMile = km2.toSquareYard result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)
