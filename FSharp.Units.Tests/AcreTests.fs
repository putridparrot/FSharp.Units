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
