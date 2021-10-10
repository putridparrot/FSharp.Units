namespace FSharp.Units.Tests

module KiloCalorieTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Energy
    open Helpers

     // kilocalories to X and back

    [<Property>]
    let ``kilocalories to kilojoules and back`` () =
        let property value = 
            let kilojoules = kCal.toKilojoules (kCal.create value)
            let kilocalories = kJ.toKilocalories kilojoules

            kilocalories
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2500.<kCal>, 10460.)>]
    let ``Convert known kilocalorie to kilojoule`` (input, expectation) =
        kCal.toKilojoules input
        |> should equal expectation

