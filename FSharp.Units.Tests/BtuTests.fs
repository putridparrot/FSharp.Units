namespace FSharp.Units.Tests

module BtuTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Health
    open Helpers

     // Btu to X and back

    [<Property>]
    let ``Btu to kilojoules and back`` () =
        let property value = 
            let result = btu.toKilojoules (btu.create value)
            let back = kJ.toBtu result

            back
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known Btu to kilojoule`` () =
        let result = btu.toKilojoules 123.<btu>

        result
        |> should (equalWithin 0.01) 129.772

