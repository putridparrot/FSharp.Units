namespace FSharp.Units.Tests

module GigahertzTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Frequency
    open Helpers

    // Gigahertz to X and back

    [<Property>]
    let ``From Gigahertz to Kilohertz and back`` () =
        let property value = 
            let kiloHertz = GHz.toKilohertz (GHz.create value)
            let gigaaHertz = kHz.toGigahertz kiloHertz

            gigaaHertz 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Gigahertz to Hertz and back`` () =
        let property value = 
            let hertz = GHz.toHertz (GHz.create value)
            let gigaaHertz = Hz.toGigahertz hertz 

            gigaaHertz 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Gigahertz to Megahertz and back`` () =
        let property value = 
            let megaHertz = GHz.toMegahertz (GHz.create value)
            let gigaaHertz = MHz.toGigahertz megaHertz
        
            gigaaHertz 
            |> should (equalWithin 0.1) value
        
        Check.QuickThrowOnFailure (testRange property)

