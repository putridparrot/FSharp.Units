namespace FSharp.Units.Tests

module MilesSquaredTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Area
    open Helpers

    // Miles Squared to X and back

    [<Property>]
    let ``From Miles squared Acre and back`` () =
        let property value = 
            let result = mile2.toAcre (mile2.create value)
            let squareMile = acre.toSquareMile result

            squareMile 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Miles squared Metre Squared and back`` () =
        let property value = 
            let result = mile2.toSquareMetre (mile2.create value)
            let squareMile = m2.toSquareMile result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Miles squared Square Feet and back`` () =
        let property value = 
            let result = mile2.toSquareFeet (mile2.create value)
            let squareMile = feet2.toSquareMile result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Miles squared Square Inch and back`` () =
        let property value = 
            let result = mile2.toSquareInch (mile2.create value)
            let squareMile = inch2.toSquareMile result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Miles squared Square Kilometre and back`` () =
        let property value = 
            let result = mile2.toSquareKilometre (mile2.create value)
            let squareMile = km2.toSquareMile result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Miles squared Hectare and back`` () =
        let property value = 
            let result = mile2.toHectare (mile2.create value)
            let squareMile = hectare.toSquareMile result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Miles squared Square Yard and back`` () =
        let property value = 
            let result = mile2.toSquareYard (mile2.create value)
            let squareMile = yard2.toSquareMile result
    
            squareMile 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)
