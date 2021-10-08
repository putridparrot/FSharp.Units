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

    [<Test>]
    let ``Convert known kilocalorie to kilojoule`` () =
        let kilojoules = kCal.toKilojoules 2500.<kCal>

        kilojoules
        |> should equal 10460.

