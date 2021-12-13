namespace FSharp.Units.Tests

module MagnetomotiveForceTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.MagnetomotiveForce
    open Helpers


    [<Property>]
    let ``From Ampere-turns to Gilberts and back`` () =
        let property value =
            let convertTo = AT.toGilberts (AT.create value)
            let convertBack = Gi.toAmpereturns convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(400.0<AT>, 502.6548248)>]
    [<TestCase(6.7<AT>, 8.4194683154)>]
    [<TestCase(0.8<AT>, 1.0053096496)>]
    let ``Convert known Ampere-turns to Gilberts`` (input, expectation) = 
        AT.toGilberts input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Gilberts to Ampere-turns and back`` () =
        let property value =
            let convertTo = Gi.toAmpereturns (Gi.create value)
            let convertBack = AT.toGilberts convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.8<Gi>, 0.6366197721)>]
    [<TestCase(67.0<Gi>, 53.316905912)>]
    [<TestCase(2.3<Gi>, 1.8302818447)>]
    let ``Convert known Gilberts to Ampere-turns`` (input, expectation) = 
        Gi.toAmpereturns input
        |> should (equalWithin 0.01) expectation
