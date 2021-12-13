namespace FSharp.Units

open Microsoft.FSharp.Core

module Area =

    /// Acres (acre) units
    [<Measure>]
    type acre =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<acre> value
        /// Converts the supplied Acres value to Square Kilometres
        static member toSquareKilometres(value : float<acre>) = km2.create(float value / 247.105)
        /// Converts the supplied Acres value to Square Metres
        static member toSquareMetres(value : float<acre>) = m2.create(float value * 4046.86)
        /// Converts the supplied Acres value to Square Miles
        static member toSquareMiles(value : float<acre>) = mile2.create(float value / 640.)
        /// Converts the supplied Acres value to Square Yards
        static member toSquareYards(value : float<acre>) = yard2.create(float value * 4840.)
        /// Converts the supplied Acres value to Square Feet
        static member toSquareFeet(value : float<acre>) = feet2.create(float value * 43560.)
        /// Converts the supplied Acres value to Square Inches
        static member toSquareInches(value : float<acre>) = inch2.create(float value * 6272640.0)
        /// Converts the supplied Acres value to Hectares
        static member toHectares(value : float<acre>) = hectare.create(float value / 2.471)
    and /// Hectares (hectare) units
        [<Measure>] hectare =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<hectare> value
        /// Converts the supplied Hectares value to Square Kilometres
        static member toSquareKilometres(value : float<hectare>) = km2.create(float value / 100.)
        /// Converts the supplied Hectares value to Square Metres
        static member toSquareMetres(value : float<hectare>) = m2.create(float value * 10000.)
        /// Converts the supplied Hectares value to Square Miles
        static member toSquareMiles(value : float<hectare>) = mile2.create(float value / 259.)
        /// Converts the supplied Hectares value to Square Yards
        static member toSquareYards(value : float<hectare>) = yard2.create(float value * 11959.900463011)
        /// Converts the supplied Hectares value to Square Feet
        static member toSquareFeet(value : float<hectare>) = feet2.create(float value * 107639.)
        /// Converts the supplied Hectares value to Square Inches
        static member toSquareInches(value : float<hectare>) = inch2.create(float value * 15500031.0)
        /// Converts the supplied Hectares value to Acres
        static member toAcres(value : float<hectare>) = acre.create(float value * 2.471)
    and /// Square Feet (feet2) units
        [<Measure>] feet2 =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<feet2> value
        /// Converts the supplied Square Feet value to Square Kilometres
        static member toSquareKilometres(value : float<feet2>) = km2.create(float value / 10763910.41671)
        /// Converts the supplied Square Feet value to Square Metres
        static member toSquareMetres(value : float<feet2>) = m2.create(float value / 10.764)
        /// Converts the supplied Square Feet value to Square Miles
        static member toSquareMiles(value : float<feet2>) = mile2.create(float value / 27878400.0)
        /// Converts the supplied Square Feet value to Square Yards
        static member toSquareYards(value : float<feet2>) = yard2.create(float value / 9.)
        /// Converts the supplied Square Feet value to Square Inches
        static member toSquareInches(value : float<feet2>) = inch2.create(float value * 144.)
        /// Converts the supplied Square Feet value to Hectares
        static member toHectares(value : float<feet2>) = hectare.create(float value / 107639.)
        /// Converts the supplied Square Feet value to Acres
        static member toAcres(value : float<feet2>) = acre.create(float value / 43560.)
    and /// Square Inches (inch2) units
        [<Measure>] inch2 =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<inch2> value
        /// Converts the supplied Square Inches value to Square Kilometres
        static member toSquareKilometres(value : float<inch2>) = km2.create(float value / 1550003100.00)
        /// Converts the supplied Square Inches value to Square Metres
        static member toSquareMetres(value : float<inch2>) = m2.create(float value / 1550.)
        /// Converts the supplied Square Inches value to Square Miles
        static member toSquareMiles(value : float<inch2>) = mile2.create(float value / 4014489600.0)
        /// Converts the supplied Square Inches value to Square Yards
        static member toSquareYards(value : float<inch2>) = yard2.create(float value / 1296.)
        /// Converts the supplied Square Inches value to Square Feet
        static member toSquareFeet(value : float<inch2>) = feet2.create(float value / 144.)
        /// Converts the supplied Square Inches value to Hectares
        static member toHectares(value : float<inch2>) = hectare.create(float value / 15500031.0)
        /// Converts the supplied Square Inches value to Acres
        static member toAcres(value : float<inch2>) = acre.create(float value / 6272640.0)
    and /// Square Kilometres (km2) units
        [<Measure>] km2 =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<km2> value
        /// Converts the supplied Square Kilometres value to Square Metres
        static member toSquareMetres(value : float<km2>) = m2.create(float value * 1e+6)
        /// Converts the supplied Square Kilometres value to Square Miles
        static member toSquareMiles(value : float<km2>) = mile2.create(float value / 2.58999)
        /// Converts the supplied Square Kilometres value to Square Yards
        static member toSquareYards(value : float<km2>) = yard2.create(float value * 1195990.05)
        /// Converts the supplied Square Kilometres value to Square Feet
        static member toSquareFeet(value : float<km2>) = feet2.create(float value * 10763910.41671)
        /// Converts the supplied Square Kilometres value to Square Inches
        static member toSquareInches(value : float<km2>) = inch2.create(float value * 1550003100.00)
        /// Converts the supplied Square Kilometres value to Hectares
        static member toHectares(value : float<km2>) = hectare.create(float value * 100.)
        /// Converts the supplied Square Kilometres value to Acres
        static member toAcres(value : float<km2>) = acre.create(float value * 247.105)
    and /// Square Metres (m2) units
        [<Measure>] m2 =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<m2> value
        /// Converts the supplied Square Metres value to Square Kilometres
        static member toSquareKilometres(value : float<m2>) = km2.create(float value / 1e+6)
        /// Converts the supplied Square Metres value to Square Miles
        static member toSquareMiles(value : float<m2>) = mile2.create(float value / 2589988.10)
        /// Converts the supplied Square Metres value to Square Yards
        static member toSquareYards(value : float<m2>) = yard2.create(float value * 1.196)
        /// Converts the supplied Square Metres value to Square Feet
        static member toSquareFeet(value : float<m2>) = feet2.create(float value * 10.764)
        /// Converts the supplied Square Metres value to Square Inches
        static member toSquareInches(value : float<m2>) = inch2.create(float value * 1550.)
        /// Converts the supplied Square Metres value to Hectares
        static member toHectares(value : float<m2>) = hectare.create(float value / 10000.)
        /// Converts the supplied Square Metres value to Acres
        static member toAcres(value : float<m2>) = acre.create(float value / 4046.86)
    and /// Square Miles (mile2) units
        [<Measure>] mile2 =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<mile2> value
        /// Converts the supplied Square Miles value to Square Kilometres
        static member toSquareKilometres(value : float<mile2>) = km2.create(float value * 2.58999)
        /// Converts the supplied Square Miles value to Square Metres
        static member toSquareMetres(value : float<mile2>) = m2.create(float value * 2589988.10)
        /// Converts the supplied Square Miles value to Square Yards
        static member toSquareYards(value : float<mile2>) = yard2.create(float value * 3097600.0)
        /// Converts the supplied Square Miles value to Square Feet
        static member toSquareFeet(value : float<mile2>) = feet2.create(float value * 27878400.0)
        /// Converts the supplied Square Miles value to Square Inches
        static member toSquareInches(value : float<mile2>) = inch2.create(float value * 4014489600.0)
        /// Converts the supplied Square Miles value to Hectares
        static member toHectares(value : float<mile2>) = hectare.create(float value * 259.)
        /// Converts the supplied Square Miles value to Acres
        static member toAcres(value : float<mile2>) = acre.create(float value * 640.)
    and /// Square Yards (yard2) units
        [<Measure>] yard2 =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<yard2> value
        /// Converts the supplied Square Yards value to Square Kilometres
        static member toSquareKilometres(value : float<yard2>) = km2.create(float value / 1195990.05)
        /// Converts the supplied Square Yards value to Square Metres
        static member toSquareMetres(value : float<yard2>) = m2.create(float value / 1.196)
        /// Converts the supplied Square Yards value to Square Miles
        static member toSquareMiles(value : float<yard2>) = mile2.create(float value / 3097600.0)
        /// Converts the supplied Square Yards value to Square Feet
        static member toSquareFeet(value : float<yard2>) = feet2.create(float value * 9.)
        /// Converts the supplied Square Yards value to Square Inches
        static member toSquareInches(value : float<yard2>) = inch2.create(float value * 1296.)
        /// Converts the supplied Square Yards value to Hectares
        static member toHectares(value : float<yard2>) = hectare.create(float value / 11959.900463011)
        /// Converts the supplied Square Yards value to Acres
        static member toAcres(value : float<yard2>) = acre.create(float value / 4840.)
