namespace FSharp.Units.Tests

module TemperatureTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Temperature
    open Helpers


    [<Property>]
    let ``From Celsius to Fahrenheit and back`` () =
        let property value =
            let convertTo = C.toFahrenheit (C.create value)
            let convertBack = F.toCelsius convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(32.0<C>, 89.6)>]
    [<TestCase(0.9<C>, 33.62)>]
    [<TestCase(0.0<C>, 32.0)>]
    let ``Convert known Celsius to Fahrenheit`` (input, expectation) = 
        C.toFahrenheit input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Celsius to Kelvin and back`` () =
        let property value =
            let convertTo = C.toKelvin (C.create value)
            let convertBack = K.toCelsius convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.0<C>, 274.15)>]
    [<TestCase(9.9<C>, 283.05)>]
    [<TestCase(100.0<C>, 373.15)>]
    let ``Convert known Celsius to Kelvin`` (input, expectation) = 
        C.toKelvin input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Celsius to Rankine and back`` () =
        let property value =
            let convertTo = C.toRankine (C.create value)
            let convertBack = R.toCelsius convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<C>, 2111.67)>]
    [<TestCase(12<C>, 513.27)>]
    [<TestCase(-3<C>, 486.27)>]
    let ``Convert known Celsius to Rankine`` (input, expectation) = 
        C.toRankine input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fahrenheit to Celsius and back`` () =
        let property value =
            let convertTo = F.toCelsius (F.create value)
            let convertBack = C.toFahrenheit convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<F>, 42.7778)>]
    [<TestCase(56.9<F>, 13.83333)>]
    [<TestCase(102.0<F>, 38.8889)>]
    let ``Convert known Fahrenheit to Celsius`` (input, expectation) = 
        F.toCelsius input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fahrenheit to Kelvin and back`` () =
        let property value =
            let convertTo = F.toKelvin (F.create value)
            let convertBack = K.toFahrenheit convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(34.5<F>, 274.5389)>]
    [<TestCase(901.0<F>, 755.928)>]
    [<TestCase(23.9<F>, 268.65)>]
    let ``Convert known Fahrenheit to Kelvin`` (input, expectation) = 
        F.toKelvin input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Fahrenheit to Rankine and back`` () =
        let property value =
            let convertTo = F.toRankine (F.create value)
            let convertBack = R.toFahrenheit convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.0<F>, 582.67)>]
    [<TestCase(9.2<F>, 468.87)>]
    [<TestCase(0.2<F>, 459.87)>]
    let ``Convert known Fahrenheit to Rankine`` (input, expectation) = 
        F.toRankine input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kelvin to Celsius and back`` () =
        let property value =
            let convertTo = K.toCelsius (K.create value)
            let convertBack = C.toKelvin convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(80.0<K>, -193.15)>]
    [<TestCase(0.9<K>, -272.25)>]
    [<TestCase(305.15<K>, 32.0)>]
    let ``Convert known Kelvin to Celsius`` (input, expectation) = 
        K.toCelsius input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kelvin to Fahrenheit and back`` () =
        let property value =
            let convertTo = K.toFahrenheit (K.create value)
            let convertBack = F.toKelvin convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.4<K>, -237.55)>]
    [<TestCase(800.0<K>, 980.33)>]
    [<TestCase(99.999<K>, -279.6718)>]
    let ``Convert known Kelvin to Fahrenheit`` (input, expectation) = 
        K.toFahrenheit input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Kelvin to Rankine and back`` () =
        let property value =
            let convertTo = K.toRankine (K.create value)
            let convertBack = R.toKelvin convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(156.0<K>, 280.8)>]
    [<TestCase(8.2<K>, 14.76)>]
    [<TestCase(0.8<K>, 1.44)>]
    let ``Convert known Kelvin to Rankine`` (input, expectation) = 
        K.toRankine input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Rankine to Celsius and back`` () =
        let property value =
            let convertTo = R.toCelsius (R.create value)
            let convertBack = C.toRankine convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190.0<R>, -167.59444444)>]
    [<TestCase(0.7<R>, -272.76111111)>]
    [<TestCase(900.0<R>, 226.85)>]
    let ``Convert known Rankine to Celsius`` (input, expectation) = 
        R.toCelsius input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Rankine to Fahrenheit and back`` () =
        let property value =
            let convertTo = R.toFahrenheit (R.create value)
            let convertBack = F.toRankine convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(109.0<R>, -350.67)>]
    [<TestCase(3567.0<R>, 3107.33)>]
    [<TestCase(9.0<R>, -450.67)>]
    let ``Convert known Rankine to Fahrenheit`` (input, expectation) = 
        R.toFahrenheit input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Rankine to Kelvin and back`` () =
        let property value =
            let convertTo = R.toKelvin (R.create value)
            let convertBack = K.toRankine convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.0<R>, 68.333333333)>]
    [<TestCase(0.9<R>, 0.5)>]
    [<TestCase(23.0<R>, 12.777777778)>]
    let ``Convert known Rankine to Kelvin`` (input, expectation) = 
        R.toKelvin input
        |> should (equalWithin 0.01) expectation

