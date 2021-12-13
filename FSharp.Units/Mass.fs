namespace FSharp.Units

open Microsoft.FSharp.Core

module Mass =

    /// Grams (g) units
    [<Measure>]
    type g =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<g> value
        /// Converts the supplied Grams value to Milligrams
        static member toMilligrams(value : float<g>) = mg.create(float value * 1000.)
        /// Converts the supplied Grams value to Kilograms
        static member toKilograms(value : float<g>) = kg.create(float value / 1000.)
        /// Converts the supplied Grams value to Tonnes
        static member toTonnes(value : float<g>) = tonne.create(float value * 1e-6)
        /// Converts the supplied Grams value to Ounces
        static member toOunces(value : float<g>) = oz.create(float value / 28.3495231)
        /// Converts the supplied Grams value to Pounds
        static member toPounds(value : float<g>) = lb.create(float value / 453.59237)
        /// Converts the supplied Grams value to Stones
        static member toStones(value : float<g>) = stone.create(float value / 6350.29318)
    and /// Kilograms (kg) units
        [<Measure>] kg =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kg> value
        /// Converts the supplied Kilograms value to Milligrams
        static member toMilligrams(value : float<kg>) = mg.create(float value * 1e+6)
        /// Converts the supplied Kilograms value to Grams
        static member toGrams(value : float<kg>) = g.create(float value * 1000.)
        /// Converts the supplied Kilograms value to Tonnes
        static member toTonnes(value : float<kg>) = tonne.create(float value * 0.001)
        /// Converts the supplied Kilograms value to Ounces
        static member toOunces(value : float<kg>) = oz.create(float value * 35.274)
        /// Converts the supplied Kilograms value to Pounds
        static member toPounds(value : float<kg>) = lb.create(float value * 2.20462)
        /// Converts the supplied Kilograms value to Stones
        static member toStones(value : float<kg>) = stone.create(float value * 0.157473)
    and /// Milligrams (mg) units
        [<Measure>] mg =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<mg> value
        /// Converts the supplied Milligrams value to Grams
        static member toGrams(value : float<mg>) = g.create(float value / 1000.)
        /// Converts the supplied Milligrams value to Kilograms
        static member toKilograms(value : float<mg>) = kg.create(float value / 1e+6)
        /// Converts the supplied Milligrams value to Tonnes
        static member toTonnes(value : float<mg>) = tonne.create(float value / 1e+9)
        /// Converts the supplied Milligrams value to Ounces
        static member toOunces(value : float<mg>) = oz.create(float value / 28349.5231)
        /// Converts the supplied Milligrams value to Pounds
        static member toPounds(value : float<mg>) = lb.create(float value / 453592.37)
        /// Converts the supplied Milligrams value to Stones
        static member toStones(value : float<mg>) = stone.create(float value / 6350293.18)
    and /// Ounces (oz) units
        [<Measure>] oz =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<oz> value
        /// Converts the supplied Ounces value to Milligrams
        static member toMilligrams(value : float<oz>) = mg.create(float value * 28349.5231)
        /// Converts the supplied Ounces value to Grams
        static member toGrams(value : float<oz>) = g.create(float value * 28.3495231)
        /// Converts the supplied Ounces value to Kilograms
        static member toKilograms(value : float<oz>) = kg.create(float value * 0.0283495)
        /// Converts the supplied Ounces value to Tonnes
        static member toTonnes(value : float<oz>) = tonne.create(float value * 0.0000283495231)
        /// Converts the supplied Ounces value to Pounds
        static member toPounds(value : float<oz>) = lb.create(float value * 0.0625)
        /// Converts the supplied Ounces value to Stones
        static member toStones(value : float<oz>) = stone.create(float value * 0.00446429)
    and /// Pounds (lb) units
        [<Measure>] lb =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<lb> value
        /// Converts the supplied Pounds value to Milligrams
        static member toMilligrams(value : float<lb>) = mg.create(float value * 453592.37)
        /// Converts the supplied Pounds value to Grams
        static member toGrams(value : float<lb>) = g.create(float value * 453.59237)
        /// Converts the supplied Pounds value to Kilograms
        static member toKilograms(value : float<lb>) = kg.create(float value * 0.453592)
        /// Converts the supplied Pounds value to Tonnes
        static member toTonnes(value : float<lb>) = tonne.create(float value / 2204.62)
        /// Converts the supplied Pounds value to Ounces
        static member toOunces(value : float<lb>) = oz.create(float value * 16.0)
        /// Converts the supplied Pounds value to Stones
        static member toStones(value : float<lb>) = stone.create(float value / 14.)
    and /// Stones (stone) units
        [<Measure>] stone =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<stone> value
        /// Converts the supplied Stones value to Milligrams
        static member toMilligrams(value : float<stone>) = mg.create(float value * 6350293.18)
        /// Converts the supplied Stones value to Grams
        static member toGrams(value : float<stone>) = g.create(float value * 6350.29318)
        /// Converts the supplied Stones value to Kilograms
        static member toKilograms(value : float<stone>) = kg.create(float value * 6.35029)
        /// Converts the supplied Stones value to Tonnes
        static member toTonnes(value : float<stone>) = tonne.create(float value * 0.00635029)
        /// Converts the supplied Stones value to Ounces
        static member toOunces(value : float<stone>) = oz.create(float value * 224.0)
        /// Converts the supplied Stones value to Pounds
        static member toPounds(value : float<stone>) = lb.create(float value * 14.0)
    and /// Tonnes (tonne) units
        [<Measure>] tonne =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<tonne> value
        /// Converts the supplied Tonnes value to Milligrams
        static member toMilligrams(value : float<tonne>) = mg.create(float value * 1e+9)
        /// Converts the supplied Tonnes value to Grams
        static member toGrams(value : float<tonne>) = g.create(float value * 1e+6)
        /// Converts the supplied Tonnes value to Kilograms
        static member toKilograms(value : float<tonne>) = kg.create(float value * 1000.0)
        /// Converts the supplied Tonnes value to Ounces
        static member toOunces(value : float<tonne>) = oz.create(float value / 0.0000283495231)
        /// Converts the supplied Tonnes value to Pounds
        static member toPounds(value : float<tonne>) = lb.create(float value * 2204.62)
        /// Converts the supplied Tonnes value to Stones
        static member toStones(value : float<tonne>) = stone.create(float value * 157.473)