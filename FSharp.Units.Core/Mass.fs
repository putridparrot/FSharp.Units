namespace FSharp.Units

open Microsoft.FSharp.Core

module Mass = 

    [<Measure>]
    type mg = // milligrams
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<mg> value
        static member toGrams(value : float<mg>) = g.create(float value / 1000.0)
        static member toKilograms(value : float<mg>) = kg.create(float value / 1e+6)
        static member toTonnes(value : float<mg>) = tonne.create(float value / 1e+9)
        static member toOunces(value : float<mg>) = oz.create(float value / 28349.5231)
        static member toPounds(value : float<mg>) = lb.create(float value / 453592.37)
        static member toStones(value : float<mg>) = stone.create(float value / 6350293.18)
    and [<Measure>] g = // grams
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<g> value
        static member toMilligrams(value : float<g>) = mg.create(float value * 1000.0)
        static member toKilograms(value : float<g>) = kg.create(float value / 1000.0)
        static member toTonnes(value : float<g>) = tonne.create(float value * 1e-6)
        static member toOunces(value : float<g>) = oz.create(float value / 28.3495231)
        static member toPounds(value : float<g>) = lb.create(float value / 453.59237)
        static member toStones(value : float<g>) = stone.create(float value / 6350.29318)
    and [<Measure>] kg = // kilograms
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kg> value
        static member toMilligrams(value : float<kg>) = mg.create(float value * 1e+6)
        static member toGrams(value : float<kg>) = g.create(float value * 1000.0)
        static member toTonnes(value : float<kg>) = tonne.create(float value * 0.001)
        static member toOunces(value : float<kg>) = oz.create(float value * 35.274)
        static member toPounds(value : float<kg>) = lb.create(float value * 2.20462)
        static member toStones(value : float<kg>) = stone.create(float value * 0.157473)
    and [<Measure>] tonne = // metric tonne
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<tonne> value
        static member toMilligrams(value : float<tonne>) = mg.create(float value * 1e+9)
        static member toGrams(value : float<tonne>) = g.create(float value * 1e+6)
        static member toKilograms(value : float<tonne>) = kg.create(float value * 1000.0)
        static member toOunces(value : float<tonne>) = oz.create(float value / 0.0000283495231)
        static member toPounds(value : float<tonne>) = lb.create(float value * 2204.62)
        static member toStones(value : float<tonne>) = stone.create(float value * 157.473)
    and [<Measure>] oz = // ounces
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<oz> value
        static member toMilligrams(value : float<oz>) = mg.create(float value * 28349.5231)
        static member toGrams(value : float<oz>) = g.create(float value * 28.3495231)
        static member toKilograms(value : float<oz>) = kg.create(float value * 0.0283495)
        static member toTonnes(value : float<oz>) = tonne.create(float value * 0.0000283495231)
        static member toPounds(value : float<oz>) = lb.create(float value * 0.0625)
        static member toStones(value : float<oz>) = stone.create(float value * 0.00446429)
    and [<Measure>] lb = // pounds
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<lb> value
        static member toMilligrams(value : float<lb>) = mg.create(float value * 453592.37)
        static member toGrams(value : float<lb>) = g.create(float value * 453.59237)
        static member toKilograms(value : float<lb>) = kg.create(float value * 0.453592)
        static member toTonnes(value : float<lb>) = tonne.create(float value / 2204.62)
        static member toOunces(value : float<lb>) = oz.create(float value * 16.0)
        static member toStones(value : float<lb>) = stone.create(float value / 14.)
    and [<Measure>] stone = // stones
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<stone> value
        static member toMilligrams(value : float<stone>) = mg.create(float value * 6350293.18)
        static member toGrams(value : float<stone>) = g.create(float value * 6350.29318)
        static member toKilograms(value : float<stone>) = kg.create(float value * 6.35029)
        static member toTonnes(value : float<stone>) = tonne.create(float value * 0.00635029)
        static member toOunces(value : float<stone>) = oz.create(float value * 224.0)
        static member toPounds(value : float<stone>) = lb.create(float value * 14.0)