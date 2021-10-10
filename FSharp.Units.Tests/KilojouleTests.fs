namespace FSharp.Units.Tests

module KilojouleTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Energy
    open Helpers

   // kilojoules to X and back

    [<Property>]
    let ``kilojoules to kilocalories and back`` () =
        let property value = 
            let kilojoules = kCal.toKilojoules (kCal.create value)
            let kilocalories = kJ.toKilocalories kilojoules

            kilocalories
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1200.<kJ>, 286.8069)>]
    let ``Convert known kilojoule to kilocalorie`` (input, expectation) =
        kJ.toKilocalories input
        |> should (equalWithin 0.001) expectation
