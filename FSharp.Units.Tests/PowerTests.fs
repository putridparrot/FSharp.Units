// <auto-generated>
// This code was generated by the UnitCodeGenerator tool
//
// Changes to this file will be lost if the code is regenerated
// </auto-generated>

namespace FSharp.Units.Tests

module PowerTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Power
    open Helpers


    [<Property>]
    let ``From Mechanical Horse Power to Metric Horse Power and back`` () =
        let property value =
            let convertTo = hp.toMetricHorsePower (hp.create value)
            let convertBack = ps.toMechanicalHorsePower convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(65.0971<hp>, 65.9999749)>]
    [<TestCase(121.317<hp>, 122.9996)>]
    [<TestCase(86.7962<hp>, 88.0)>]
    let ``Convert known Mechanical Horse Power to Metric Horse Power`` (input, expectation) = 
        hp.toMetricHorsePower input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Metric Horse Power to Mechanical Horse Power and back`` () =
        let property value =
            let convertTo = ps.toMechanicalHorsePower (ps.create value)
            let convertBack = hp.toMetricHorsePower convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(126.734<ps>, 125.0)>]
    [<TestCase(91.2483<ps>, 90.0)>]
    [<TestCase(425.825<ps>, 419.9997)>]
    let ``Convert known Metric Horse Power to Mechanical Horse Power`` (input, expectation) = 
        ps.toMechanicalHorsePower input
        |> should (equalWithin 0.01) expectation

