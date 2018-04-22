namespace FSharp.Units

open Microsoft.FSharp.Core

module LuminousIntensity =

    [<Measure>]
    type cd = // Candela
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<cd> value
    and [<Measure>] lmsr = // Lumen per steradian (lm/sr)
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<lmsr> value
    and [<Measure>] HK = // Hefnerkerse
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<HK> value
    and [<Measure>] Candlepower = // Candlepower
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Candlepower> value
