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
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From celsius to kelvin and back`` () =
        let property value = 
            let kelvin = C.toKelvin (C.create value)
            let celsius = K.toCelsius kelvin

            celsius
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Test>]
    let ``Convert known celsius to fahrenheit`` () =
        let fahrenheit = C.toFahrenheit 12.<C>

        fahrenheit
        |> should (equalWithin 0.1) 53.6

    [<Test>]
    let ``Convert known celsius to kelvin`` () =
        let kelvin = C.toKelvin 23.<C>

        kelvin
        |> should (equalWithin 0.1) 296.15