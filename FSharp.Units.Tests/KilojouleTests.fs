namespace FSharp.Units.Tests

module KilojouleTests =

    open System
    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit
    open FsUnit.Xunit
    open FSharp.Units
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

    [<Fact>]
    let ``Convert known kilojoule to kilocalorie`` () =
        let kilocalories = kJ.toKilocalories 1200.<kJ>

        kilocalories
        |> should equal 286.61507595299514
