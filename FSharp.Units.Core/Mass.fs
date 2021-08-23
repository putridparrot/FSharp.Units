namespace FSharp.Units

open Microsoft.FSharp.Core

module Mass = 

    [<Measure>]
    type mg = // milligrams
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<mg> value
        static member toGrams(value : float<mg>) = value / 1000.0<mg/g>
        static member toKilograms(value : float<mg>) = value / 1e+6<mg/kg>
        static member toTonnes(value : float<mg>) = value / 1e+9<mg/tonne>
        static member toOunces(value : float<mg>) = value / 28349.5231<mg/oz>
        static member toPounds(value : float<mg>) = value / 453592.37<mg/lb>
        static member toStones(value : float<mg>) = value / 6350293.18<mg/stone>
    and [<Measure>] g = // grams
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<g> value
        static member toMilligrams(value : float<g>) = value * 1000.0<mg/g>
        static member toKilograms(value : float<g>) = value / 1000.0<g/kg>
        static member toTonnes(value : float<g>) = value * 1e-6<tonne/g>
        static member toOunces(value : float<g>) = value / 28.3495231<g/oz>
        static member toPounds(value : float<g>) = value / 453.59237<g/lb>
        static member toStones(value : float<g>) = value / 6350.29318<g/stone>
    and [<Measure>] kg = // kilograms
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kg> value
        static member toMilligrams(value : float<kg>) = value * 1e+6<mg/kg>
        static member toGrams(value : float<kg>) = value * 1000.0<g/kg>
        static member toTonnes(value : float<kg>) = value * 0.001<tonne/kg>
        static member toOunces(value : float<kg>) = value * 35.274<oz/kg>
        static member toPounds(value : float<kg>) = value * 2.20462<lb/kg>
        static member toStones(value : float<kg>) = value * 0.157473<stone/kg>
    and [<Measure>] tonne = // metric tonne
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<tonne> value
        static member toMilligrams(value : float<tonne>) = value * 1e+9<mg/tonne>
        static member toGrams(value : float<tonne>) = value * 1e+6<g/tonne>
        static member toKilograms(value : float<tonne>) = value * 1000.0<kg/tonne>
        static member toOunces(value : float<tonne>) = value / 0.0000283495231<tonne/oz>
        static member toPounds(value : float<tonne>) = value / 0.00045359237<tonne/lb>
        static member toStones(value : float<tonne>) = value * 157.473<stone/tonne>
    and [<Measure>] oz = // ounces
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<oz> value
        static member toMilligrams(value : float<oz>) = value * 28349.5231<mg/oz>
        static member toGrams(value : float<oz>) = value * 28.3495231<g/oz>
        static member toKilograms(value : float<oz>) = value * 0.0283495<kg/oz>
        static member toTonnes(value : float<oz>) = value * 0.0000283495231<tonne/oz>
        static member toPounds(value : float<oz>) = value * 0.0625<lb/oz>
        static member toStones(value : float<oz>) = value * 0.00446429<stone/oz>
    and [<Measure>] lb = // pounds
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<lb> value
        static member toMilligrams(value : float<lb>) = value * 453592.37<mg/lb>
        static member toGrams(value : float<lb>) = value * 453.59237<g/lb>
        static member toKilograms(value : float<lb>) = value * 0.453592<kg/lb>
        static member toTonnes(value : float<lb>) = value * 0.00045359237<tonne/lb>
        static member toOunces(value : float<lb>) = value * 16.0<oz/lb>
        static member toStones(value : float<lb>) = value / 14.<lb/stone>
    and [<Measure>] stone = // stones
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<stone> value
        static member toMilligrams(value : float<stone>) = value * 6350293.18<mg/stone>
        static member toGrams(value : float<stone>) = value * 6350.29318<g/stone>
        static member toKilograms(value : float<stone>) = value * 6.35029<kg/stone>
        static member toTonnes(value : float<stone>) = value * 0.00635029<tonne/stone>
        static member toOunces(value : float<stone>) = value * 224.0<oz/stone>
        static member toPounds(value : float<stone>) = value * 14.0<lb/stone>