namespace FSharp.Units.Tests

module KelvinTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Temperature
    open Helpers

   // kelvin to X and back

    [<Property>]
    let ``From kelvin to celsius and back`` () =
        let property value = 
            let celsius = K.toCelsius (K.create value)
            let kelvin = C.toKelvin celsius

            kelvin
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kelvin to fahrenheit and back`` () =
        let property value = 
            let fahrenheit = K.toFahrenheit (K.create value)
            let kelvin = F.toKelvin fahrenheit

            kelvin
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)


    [<TestCase(123.<K>, -150.15)>]
    let ``Convert known kelvin to celsius`` (input, expectation) =
        K.toCelsius input
        |> should (equalWithin 0.01) expectation

    [<TestCase(34.<K>, -398.47)>]
    let ``Convert known kelvin to fahrenheit`` (input, expectation) =
        K.toFahrenheit input
        |> should (equalWithin 0.01) expectation
