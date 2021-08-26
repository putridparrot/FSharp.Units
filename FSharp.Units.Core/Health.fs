namespace FSharp.Units

open Microsoft.FSharp.Core

module Health =

    [<Measure>]
    type bpm =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<bpm> value

    // http://www.convertunits.com/from/kilojoules/to/calorie+[nutritional]
    // https://www.unitconverters.net/energy/kcal-to-kj.htm

    [<Measure>]
    type kJ = // kilojoules
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kJ> value
        static member toKilocalories(value : float<kJ>) = kCal.create(float value / 4.184)
        static member toJoules(value : float<kJ>) = J.create(float value * 1000.)
        static member toBtu(value: float<kJ>) = btu.create(float value / 1.055)
        static member toCal(value: float<kJ>) = cal.create(float value * 239.)
    and [<Measure>] kCal = // thermochemical / food kilocalories
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kCal> value
        static member toKilojoules(value : float<kCal>) = kJ.create(float value * 4.184)
        static member toJoules(value : float<kCal>) = J.create(float value * 4184.)
        static member toBtu(value: float<kCal>) = btu.create(float value * 3.966)
        static member toCal(value: float<kCal>) = cal.create(float value * 1000.)
    and [<Measure>] J = // Joule
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<J> value
        static member toKilojoules(value : float<J>) = kJ.create(float value / 1000.)
        static member toKilocalories(value : float<J>) = kCal.create(float value / 4184.)
        static member toBtu(value: float<J>) = btu.create(float value / 1055.)
        static member toCal(value: float<J>) = cal.create(float value / 4.184)
    and [<Measure>] btu = // btu British Thermal Unit
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<btu> value
        static member toKilojoules(value : float<btu>) = kJ.create(float value * 1.055)
        static member toKilocalories(value : float<btu>) = kCal.create(float value / 3.966)
        static member toJoules(value : float<btu>) = J.create(float value * 1055.)
        static member toCal(value: float<btu>) = cal.create(float value * 252.)
    and [<Measure>] cal = // gram calorie
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<cal> value
        static member toKilojoules(value : float<cal>) = kJ.create(float value / 239.)
        static member toKilocalories(value : float<cal>) = kCal.create(float value / 1000.)
        static member toJoules(value : float<cal>) = J.create(float value * 4.184)
        static member toBtu(value: float<cal>) = btu.create(float value / 252.)
