namespace FSharp.Units

open Microsoft.FSharp.Core

module Health =

    [<Measure>]
    type bpm =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<bpm> value