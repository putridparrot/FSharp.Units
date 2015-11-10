namespace FSharp.Units

open Microsoft.FSharp.Core

module LuminousEnery =

    [<Measure>]
    type lmh = // Lumen hour (lm.h)
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<lmh> value
    and [<Measure>] lmmin = // Lumen minute (lm.min)
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<lmmin> value
    and [<Measure>] lms = // Lumen second (lm.s)
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<lms> value
    and [<Measure>] T = // Talbot
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<T> value
