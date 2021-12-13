namespace FSharp.Units

open Microsoft.FSharp.Core

module LuminousIntensity =

    /// Candela (cd) units
    [<Measure>]
    type cd =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<cd> value
    and /// Candlepower (Candlepower) units
        [<Measure>] Candlepower =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Candlepower> value
    and /// Hefnerkerse (HK) units
        [<Measure>] HK =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<HK> value
    and /// Lumen Per Steradian (lmsr) units
        [<Measure>] lmsr =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<lmsr> value
