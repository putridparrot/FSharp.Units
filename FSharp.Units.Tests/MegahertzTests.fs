namespace FSharp.Units.Tests

module MegahertzTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Frequency
    open Helpers

    // Megahertz to X and back

    [<Property>]
    let ``From Megahertz to Kilohertz and back`` () =
        let property value = 
            let kiloHertz = MHz.toKilohertz (MHz.create value)
            let megaHertz = kHz.toMegahertz kiloHertz

            megaHertz 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Megahertz to Hertz and back`` () =
        let property value = 
            let hertz = MHz.toHertz (MHz.create value)
            let megaHertz = Hz.toMegahertz hertz 

            megaHertz 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Megahertz to Gigahertz and back`` () =
        let property value = 
            let gigaHertz = MHz.toGigahertz (MHz.create value)
            let megaHertz = GHz.toMegahertz gigaHertz
        
            megaHertz 
            |> should (equalWithin 0.1) value
        
        Check.QuickThrowOnFailure (testRange property)

