namespace FSharp.Units.Tests

module JouleTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Energy
    open Helpers

     // Joules to X and back

    [<Property>]
    let ``Joules to kilojoules and back`` () =
        let property value = 
            let result = J.toKilojoules (J.create value)
            let back = kJ.toJoules result

            back
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.<J>, 0.123)>]
    let ``Convert known Joules to kilojoule`` (input, expectation) =
        J.toKilojoules input
        |> should (equalWithin 0.01) expectation

