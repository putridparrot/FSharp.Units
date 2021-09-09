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
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known therm to btu`` () =
        let converted = therm.toBtu 0.12<therm>

        converted
        |> should (equalWithin 0.1) 11997.14
