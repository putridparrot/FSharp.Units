namespace FSharp.Units.Tests

module CelsiusTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Temperature
    open Helpers

   // celsius to X and back

    [<Property>]
    let ``From celsius to fahrenheit and back`` () =
        let property value = 
            let fahrenheit = C.toFahrenheit (C.create value)
            let celsius = F.toCelsius fahrenheit

            celsius
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From celsius to kelvin and back`` () =
        let property value = 
            let kelvin = C.toKelvin (C.create value)
            let celsius = K.toCelsius kelvin

            celsius
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.<C>, 53.6)>]
    let ``Convert known celsius to fahrenheit`` (input, expectation) =
        C.toFahrenheit input
        |> should (equalWithin 0.01) expectation

    [<TestCase(23.<C>, 296.15)>]
    let ``Convert known celsius to kelvin`` (input, expectation) =
        C.toKelvin input
        |> should (equalWithin 0.01) expectation