namespace FSharp.Units.Tests

module BtuTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Energy
    open Helpers

     // Btu to X and back

    [<Property>]
    let ``Btu to kilojoules and back`` () =
        let property value = 
            let result = btu.toKilojoules (btu.create value)
            let back = kJ.toBtu result

            back
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.<btu>, 129.772)>]
    let ``Convert known Btu to kilojoule`` (input, expectation) =
        btu.toKilojoules input
        |> should (equalWithin 0.01) expectation

