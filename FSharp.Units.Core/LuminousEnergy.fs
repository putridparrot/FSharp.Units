namespace FSharp.Units

open Microsoft.FSharp.Core

module LuminousEnergy =

    [<Measure>]
    type lmh = // Lumen hour (lm.h)
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<lmh> value
        static member toTalbot(value : float<lmh>) = T.create(float value * 3600.0)
        static member toLumenMinute(value : float<lmh>) = lmmin.create(float value * 60.0)
        static member toLumenSecond(value : float<lmh>) = lms.create(float value * 3600.0)
    and [<Measure>] lmmin = // Lumen minute (lm.min)
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<lmmin> value
        static member toLumenHour(value : float<lmmin>) = lmh.create(float value / 60.0)
        static member toTalbot(value : float<lmmin>) = T.create(float value * 60.0)
        static member toLumenSecond(value : float<lmmin>) = lms.create(float value * 60.0)
    and [<Measure>] lms = // Lumen second (lm.s)
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<lms> value
        static member toLumenHour(value : float<lms>) = lmh.create(float value / 3600.0)
        static member toLumenMinute(value : float<lms>) = lmmin.create(float value / 60.0)
        static member toTalbot(value : float<lms>) = T.create(float value)
    and [<Measure>] T = // Talbot
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<T> value
        static member toLumenHour(value : float<T>) = lmh.create(float value / 3600.0)
        static member toLumenMinute(value : float<T>) = lmmin.create(float value / 60.0)
        static member toLumenSecond(value : float<T>) = lms.create(float value)