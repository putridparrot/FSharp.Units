namespace FSharp.Units.Tests

module KelvinTests =

    open Xunit
    open FsCheck
    open FsCheck.Xunit
    open FsUnit.Xunit
    open FSharp.Units.Temperature
    open Helpers

   // kelvin to X and back

    [<Property>]
    let ``From kelvin to celsius and back`` () =
        let property value = 
            let celsius = K.toCelsius (K.create value)
            let kelvin = C.toKelvin celsius

            kelvin
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From kelvin to fahrenheit and back`` () =
        let property value = 
            let fahrenheit = K.toFahrenheit (K.create value)
            let kelvin = F.toKelvin fahrenheit

            kelvin
            |> should (equalWithin 0.1) value

        Check.QuickThrowOnFailure (testRange property)


    [<Fact>]
    let ``Convert known kelvin to celsius`` () =
        let celsius = K.toCelsius 123.<K>

        celsius
        |> should (equalWithin 0.1) -150.15

    [<Fact>]
    let ``Convert known kelvin to fahrenheit`` () =
        let fahrenheit = K.toFahrenheit 34.<K>

        fahrenheit
        |> should (equalWithin 0.1) -398.47
