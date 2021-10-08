namespace FSharp.Units.Tests

module MetreSquaredTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Area
    open Helpers

    // Metre Squared to X and back

    [<Property>]
    let ``From Metres Squared to Acre and back`` () =
        let property value = 
            let a = m2.toAcre (m2.create value)
            let metresSequared = acre.toSquareMetre a

            metresSequared 
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Metres Squared to Hectare and back`` () =
        let property value = 
            let a = m2.toHectare (m2.create value)
            let metresSequared = hectare.toSquareMetre a
    
            metresSequared 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Metres Squared to Square Feet and back`` () =
        let property value = 
            let a = m2.toSquareFeet (m2.create value)
            let metresSequared = feet2.toSquareMetre a
    
            metresSequared 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Metres Squared to Square Inch and back`` () =
        let property value = 
            let a = m2.toSquareInch (m2.create value)
            let metresSequared = inch2.toSquareMetre a
    
            metresSequared 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Metres Squared to Square Kilometre and back`` () =
        let property value = 
            let a = m2.toSquareKilometre (m2.create value)
            let metresSequared = km2.toSquareMetre a
    
            metresSequared 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Metres Squared to Square Mile and back`` () =
        let property value = 
            let a = m2.toSquareMile (m2.create value)
            let metresSequared = mile2.toSquareMetre a
    
            metresSequared 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Metres Squared to Square Yard and back`` () =
        let property value = 
            let a = m2.toSquareYard (m2.create value)
            let metresSequared = yard2.toSquareMetre a
    
            metresSequared 
            |> should (equalWithin 0.01) value
    
        Check.QuickThrowOnFailure (testRange property)
