namespace FSharp.Units.Tests

module HectareTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Area
    open Helpers

    // Hectare to X and back

    [<Property>]
    let ``From Hectare to Acre and back`` () =
        let property value = 
            let h = hectare.toAcre (hectare.create value)
            let hectare = acre.toHectare h

            hectare 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Hectare to Metre Squared and back`` () =
        let property value = 
            let h = hectare.toSquareMetre (hectare.create value)
            let hectare = m2.toHectare h
    
            hectare 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Hectare to Square Feet and back`` () =
        let property value = 
            let h = hectare.toSquareFeet (hectare.create value)
            let hectare = feet2.toHectare h
    
            hectare 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Hectare to Square Inch and back`` () =
        let property value = 
            let h = hectare.toSquareInch (hectare.create value)
            let hectare = inch2.toHectare h
    
            hectare 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Hectare to Square Kilometre and back`` () =
        let property value = 
            let h = hectare.toSquareKilometre (hectare.create value)
            let hectare = km2.toHectare h
    
            hectare 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Hectare to Square Mile and back`` () =
        let property value = 
            let h = hectare.toSquareMile (hectare.create value)
            let hectare = mile2.toHectare h
    
            hectare 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Hectare to Square Yard and back`` () =
        let property value = 
            let h = hectare.toSquareYard (hectare.create value)
            let hectare = yard2.toHectare h
    
            hectare 
            |> should (equalWithin 0.1) value
    
        Check.QuickThrowOnFailure (testRange property)
