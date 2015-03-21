namespace FSharp.Units

open Microsoft.FSharp.Core

module Health =

    [<Measure>]
    type bpm

    // http://www.convertunits.com/from/kilojoules/to/calorie+[nutritional]

    [<Measure>]
    type kJ = // kilojoules
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kJ> value
        static member toKilocalories(value : float<kJ>) = value / 4.1868<kJ/kCal>
    and [<Measure>] kCal = // thermochemical / food kilocalories
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kCal> value
        static member toKilojoules(value : float<kCal>) = value * 4.1868<kJ/kCal>
