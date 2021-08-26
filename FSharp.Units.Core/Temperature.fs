namespace FSharp.Units

open Microsoft.FSharp.Core

module Temperature =

    [<Measure>]
    type C = // celsius
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<C> value
        static member toFahrenheit(value : float<C>) = F.create(float value * 1.8 + 32.0)
        static member toKelvin(value : float<C>) = K.create(float value + 273.15)
    and [<Measure>] F = // fahrenheit
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<F> value
        static member toCelsius(value : float<F>) = C.create(((float value - 32.0) * 5.0) / 9.0)
        static member toKelvin(value : float<F>) = K.create((((float value - 32.0) * 5.0) / 9.0) + 273.15)
    and [<Measure>] K = // Kelvin
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<K> value
        static member toCelsius(value : float<K>) = C.create(float value - 273.15)
        static member toFahrenheit(value : float<K>) = F.create(((float value - 273.15) * 1.8) + 32.0)

