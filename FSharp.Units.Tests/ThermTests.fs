namespace FSharp.Units.Tests

module ThermTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Energy
    open Helpers

   // US therm to X and back

    [<Property>]
    let ``therm to btu and back`` () =
        let property value = 
            let converetd = therm.toBtu (therm.create value)
            let back = btu.toTherm converetd

            back
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.12<therm>, 11997.14)>]
    let ``Convert known therm to btu`` (input, expectation) =
        therm.toBtu input
        |> should (equalWithin 0.01) expectation
