namespace FSharp.Units.Tests

module HertzTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Frequency
    open Helpers

    // Hertz to X and back

    [<Property>]
    let ``From Hertz to Kilohertz and back`` () =
        let property value = 
            let kiloHertz = Hz.toKilohertz (Hz.create value)
            let hertz = kHz.toHertz kiloHertz

            hertz 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Hertz to Megahertz and back`` () =
        let property value = 
            let megaHertz = Hz.toMegahertz (Hz.create value)
            let hertz = MHz.toHertz megaHertz 

            hertz 
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Hertz to Gigahertz and back`` () =
        let property value = 
            let gigaHertz = Hz.toGigahertz (Hz.create value)
            let hertz = GHz.toHertz gigaHertz
        
            hertz 
            |> should (equalWithin 0.1) value
        
        Check.QuickThrowOnFailure (testRange property)

