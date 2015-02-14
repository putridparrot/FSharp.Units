namespace FSharp.Units.Tests

module CelsiusTests =

    open System
    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit
    open FsUnit.Xunit
    open FSharp.Units
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

    [<Fact>]
    let ``Convert known celsius to fahrenheit`` () =
        let fahrenheit = C.toFahrenheit 12.<C>

        fahrenheit
        |> should (equalWithin 0.1) 53.6<C>

    [<Fact>]
    let ``Convert known celsius to kelvin`` () =
        let kelvin = C.toKelvin 23.<C>

        kelvin
        |> should (equalWithin 0.1) 296.15<K>