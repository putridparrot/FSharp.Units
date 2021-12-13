namespace FSharp.Units

open Microsoft.FSharp.Core

module Temperature =

    /// Celsius (C) units
    [<Measure>]
    type C =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<C> value
        /// Converts the supplied Celsius value to Fahrenheit
        static member toFahrenheit(value : float<C>) = F.create(float value * 1.8 + 32.0)
        /// Converts the supplied Celsius value to Kelvin
        static member toKelvin(value : float<C>) = K.create(float value + 273.15)
        /// Converts the supplied Celsius value to Rankine
        static member toRankine(value : float<C>) = R.create(float value * 9.0/5.0 + 491.67)
    and /// Fahrenheit (F) units
        [<Measure>] F =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<F> value
        /// Converts the supplied Fahrenheit value to Celsius
        static member toCelsius(value : float<F>) = C.create(((float value - 32.0) * 5.0) / 9.0)
        /// Converts the supplied Fahrenheit value to Kelvin
        static member toKelvin(value : float<F>) = K.create((((float value - 32.0) * 5.0) / 9.0) + 273.15)
        /// Converts the supplied Fahrenheit value to Rankine
        static member toRankine(value : float<F>) = R.create(float value + 459.67)
    and /// Kelvin (K) units
        [<Measure>] K =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<K> value
        /// Converts the supplied Kelvin value to Celsius
        static member toCelsius(value : float<K>) = C.create(float value - 273.15)
        /// Converts the supplied Kelvin value to Fahrenheit
        static member toFahrenheit(value : float<K>) = F.create(((float value - 273.15) * 1.8) + 32.0)
        /// Converts the supplied Kelvin value to Rankine
        static member toRankine(value : float<K>) = R.create(float value * 1.8)
    and /// Rankine (R) units
        [<Measure>] R =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<R> value
        /// Converts the supplied Rankine value to Celsius
        static member toCelsius(value : float<R>) = C.create((float value - 491.67) * 5.0/9.0)
        /// Converts the supplied Rankine value to Fahrenheit
        static member toFahrenheit(value : float<R>) = F.create(float value - 459.67)
        /// Converts the supplied Rankine value to Kelvin
        static member toKelvin(value : float<R>) = K.create(float value / 1.8)