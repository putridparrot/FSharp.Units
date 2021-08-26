namespace FSharp.Units.Tests

module KilojouleTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Health
    open Helpers

   // kilojoules to X and back

    [<Property>]
    let ``kilojoules to kilocalories and back`` () =
        let property value = 
            let kilojoules = kCal.toKilojoules (kCal.create value)
            let kilocalories = kJ.toKilocalories kilojoules

            kilocalories
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known kilojoule to kilocalorie`` () =
        let kilocalories = kJ.toKilocalories 1200.<kJ>

        kilocalories
        |> should (equalWithin 0.001) 286.8069
