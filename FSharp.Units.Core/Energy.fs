namespace FSharp.Units

open Microsoft.FSharp.Core

module Energy =

    // http://www.convertunits.com/from/kilojoules/to/calorie+[nutritional]
    // https://www.unitconverters.net/energy/kcal-to-kj.htm

    [<Measure>]
    type kJ = // kilojoules
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kJ> value
        static member toKilocalories(value : float<kJ>) = kCal.create(float value / 4.184)
        static member toJoules(value : float<kJ>) = J.create(float value * 1000.)
        static member toBtu(value: float<kJ>) = btu.create(float value / 1.055)
        static member toCal(value: float<kJ>) = cal.create(float value * 239.)
        static member toTherm(value: float<kJ>) = therm.create(float value / 105480.)
    and [<Measure>] kCal = // thermochemical / food kilocalories
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kCal> value
        static member toKilojoules(value : float<kCal>) = kJ.create(float value * 4.184)
        static member toJoules(value : float<kCal>) = J.create(float value * 4184.)
        static member toBtu(value: float<kCal>) = btu.create(float value * 3.966)
        static member toCal(value: float<kCal>) = cal.create(float value * 1000.)
        static member toTherm(value: float<kCal>) = therm.create(float value / 25210.)
    and [<Measure>] J = // Joule
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<J> value
        static member toKilojoules(value : float<J>) = kJ.create(float value / 1000.)
        static member toKilocalories(value : float<J>) = kCal.create(float value / 4184.)
        static member toBtu(value: float<J>) = btu.create(float value / 1055.)
        static member toCal(value: float<J>) = cal.create(float value / 4.184)
        static member toTherm(value: float<J>) = therm.create(float value / 1.055e+8)
    and [<Measure>] btu = // btu British Thermal Unit
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<btu> value
        static member toKilojoules(value : float<btu>) = kJ.create(float value * 1.055)
        static member toKilocalories(value : float<btu>) = kCal.create(float value / 3.966)
        static member toJoules(value : float<btu>) = J.create(float value * 1055.)
        static member toCal(value: float<btu>) = cal.create(float value * 252.)
        static member toTherm(value: float<btu>) = therm.create(float value / 99976.)
    and [<Measure>] cal = // gram calorie
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<cal> value
        static member toKilojoules(value : float<cal>) = kJ.create(float value / 239.)
        static member toKilocalories(value : float<cal>) = kCal.create(float value / 1000.)
        static member toJoules(value : float<cal>) = J.create(float value * 4.184)
        static member toBtu(value: float<cal>) = btu.create(float value / 252.)
        static member toTherm(value: float<J>) = therm.create(float value / 2.521e+7)
    and [<Measure>] therm = // us therm
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<therm> value
        static member toKilojoules(value: float<therm>) = kJ.create(float value * 2.521e+7)
        static member toKilocalories(value : float<therm>) = kCal.create(float value * 25210.)
        static member toJoules(value : float<therm>) = J.create(float value * 1.055e+8)
        static member toBtu(value: float<therm>) = btu.create(float value * 99976.)
        static member toCal(value : float<therm>) = cal.create(float value * 2.521e+7)

        // TODO: Add watt hour, kWh, electron volt, foot pound

