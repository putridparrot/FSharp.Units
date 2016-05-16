namespace FSharp.Units

open Microsoft.FSharp.Core

module Time = 

    [<Measure>]
    type sec = // seconds
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<sec> value
    and  [<Measure>] min = // minutes
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<min> value
    and  [<Measure>] hr = // minutes
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<hr> value
    and  [<Measure>] day = // minutes
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<day> value
    and  [<Measure>] month = // minutes
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<month> value
    and  [<Measure>] year = // minutes
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<year> value
