namespace FSharp.Units

open Microsoft.FSharp.Core

module Length =

    /// Centimetres (cm) units
    [<Measure>]
    type cm =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<cm> value
        /// Converts the supplied Centimetres value to Millimetres
        static member toMillimetres(value : float<cm>) = mm.create(float value * 10.)
        /// Converts the supplied Centimetres value to Metres
        static member toMetres(value : float<cm>) = m.create(float value / 100.)
        /// Converts the supplied Centimetres value to Kilometres
        static member toKilometres(value : float<cm>) = km.create(float value / 100000.)
        /// Converts the supplied Centimetres value to Inches
        static member toInches(value : float<cm>) = inch.create(float value / 2.54)
        /// Converts the supplied Centimetres value to Feet
        static member toFeet(value : float<cm>) = ft.create(float value / 30.48)
        /// Converts the supplied Centimetres value to Yards
        static member toYards(value : float<cm>) = yard.create(float value / 91.44)
        /// Converts the supplied Centimetres value to Miles
        static member toMiles(value : float<cm>) = mile.create(float value / 160934.4)
        /// Converts the supplied Centimetres value to Nautical Miles
        static member toNauticalMiles(value : float<cm>) = NM.create(float value / 185200.)
    and /// Feet (ft) units
        [<Measure>] ft =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<ft> value
        /// Converts the supplied Feet value to Millimetres
        static member toMillimetres(value : float<ft>) = mm.create(float value * 304.8)
        /// Converts the supplied Feet value to Centimetres
        static member toCentimetres(value : float<ft>) = cm.create(float value * 30.48)
        /// Converts the supplied Feet value to Metres
        static member toMetres(value : float<ft>) = m.create(float value * 0.3048)
        /// Converts the supplied Feet value to Kilometres
        static member toKilometres(value : float<ft>) = km.create(float value * 0.0003048)
        /// Converts the supplied Feet value to Inches
        static member toInches(value : float<ft>) = inch.create(float value * 12.)
        /// Converts the supplied Feet value to Yards
        static member toYards(value : float<ft>) = yard.create(float value / 3.)
        /// Converts the supplied Feet value to Miles
        static member toMiles(value : float<ft>) = mile.create(float value / 5280.)
        /// Converts the supplied Feet value to Nautical Miles
        static member toNauticalMiles(value : float<ft>) = NM.create(float value / 6076.12)
    and /// Inches (inch) units
        [<Measure>] inch =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<inch> value
        /// Converts the supplied Inches value to Millimetres
        static member toMillimetres(value : float<inch>) = mm.create(float value * 25.4)
        /// Converts the supplied Inches value to Centimetres
        static member toCentimetres(value : float<inch>) = cm.create(float value * 2.54)
        /// Converts the supplied Inches value to Metres
        static member toMetres(value : float<inch>) = m.create(float value * 0.0254)
        /// Converts the supplied Inches value to Kilometres
        static member toKilometres(value : float<inch>) = km.create(float value * 0.0000254)
        /// Converts the supplied Inches value to Feet
        static member toFeet(value : float<inch>) = ft.create(float value / 12.)
        /// Converts the supplied Inches value to Yards
        static member toYards(value : float<inch>) = yard.create(float value / 36.)
        /// Converts the supplied Inches value to Miles
        static member toMiles(value : float<inch>) = mile.create(float value / 63360.)
        /// Converts the supplied Inches value to Nautical Miles
        static member toNauticalMiles(value : float<inch>) = NM.create(float value / 72913.4)
    and /// Kilometres (km) units
        [<Measure>] km =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<km> value
        /// Converts the supplied Kilometres value to Millimetres
        static member toMillimetres(value : float<km>) = mm.create(float value * 1000000.)
        /// Converts the supplied Kilometres value to Centimetres
        static member toCentimetres(value : float<km>) = cm.create(float value * 100000.)
        /// Converts the supplied Kilometres value to Metres
        static member toMetres(value : float<km>) = m.create(float value * 1000.)
        /// Converts the supplied Kilometres value to Inches
        static member toInches(value : float<km>) = inch.create(float value / 0.0000254)
        /// Converts the supplied Kilometres value to Feet
        static member toFeet(value : float<km>) = ft.create(float value / 0.0003048)
        /// Converts the supplied Kilometres value to Yards
        static member toYards(value : float<km>) = yard.create(float value / 0.0009144)
        /// Converts the supplied Kilometres value to Miles
        static member toMiles(value : float<km>) = mile.create(float value / 1.609344)
        /// Converts the supplied Kilometres value to Nautical Miles
        static member toNauticalMiles(value : float<km>) = NM.create(float value / 1.85200)
    and /// Metres (m) units
        [<Measure>] m =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<m> value
        /// Converts the supplied Metres value to Millimetres
        static member toMillimetres(value : float<m>) = mm.create(float value * 1000.)
        /// Converts the supplied Metres value to Centimetres
        static member toCentimetres(value : float<m>) = cm.create(float value * 100.)
        /// Converts the supplied Metres value to Kilometres
        static member toKilometres(value : float<m>) = km.create(float value / 1000.)
        /// Converts the supplied Metres value to Inches
        static member toInches(value : float<m>) = inch.create(float value / 0.0254)
        /// Converts the supplied Metres value to Feet
        static member toFeet(value : float<m>) = ft.create(float value / 0.3048)
        /// Converts the supplied Metres value to Yards
        static member toYards(value : float<m>) = yard.create(float value / 0.9144)
        /// Converts the supplied Metres value to Miles
        static member toMiles(value : float<m>) = mile.create(float value / 1609.344)
        /// Converts the supplied Metres value to Nautical Miles
        static member toNauticalMiles(value : float<m>) = NM.create(float value / 1852.)
    and /// Miles (mile) units
        [<Measure>] mile =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<mile> value
        /// Converts the supplied Miles value to Millimetres
        static member toMillimetres(value : float<mile>) = mm.create(float value * 1609344.)
        /// Converts the supplied Miles value to Centimetres
        static member toCentimetres(value : float<mile>) = cm.create(float value * 160934.4)
        /// Converts the supplied Miles value to Metres
        static member toMetres(value : float<mile>) = m.create(float value * 1609.344)
        /// Converts the supplied Miles value to Kilometres
        static member toKilometres(value : float<mile>) = km.create(float value * 1.609344)
        /// Converts the supplied Miles value to Inches
        static member toInches(value : float<mile>) = inch.create(float value * 63360.)
        /// Converts the supplied Miles value to Feet
        static member toFeet(value : float<mile>) = ft.create(float value * 5280.)
        /// Converts the supplied Miles value to Yards
        static member toYards(value : float<mile>) = yard.create(float value * 1760.)
        /// Converts the supplied Miles value to Nautical Miles
        static member toNauticalMiles(value : float<mile>) = NM.create(float value / 1.15078)
    and /// Millimetres (mm) units
        [<Measure>] mm =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<mm> value
        /// Converts the supplied Millimetres value to Centimetres
        static member toCentimetres(value : float<mm>) = cm.create(float value / 10.)
        /// Converts the supplied Millimetres value to Metres
        static member toMetres(value : float<mm>) = m.create(float value / 1000.)
        /// Converts the supplied Millimetres value to Kilometres
        static member toKilometres(value : float<mm>) = km.create(float value / 1000000.)
        /// Converts the supplied Millimetres value to Inches
        static member toInches(value : float<mm>) = inch.create(float value / 25.4)
        /// Converts the supplied Millimetres value to Feet
        static member toFeet(value : float<mm>) = ft.create(float value / 304.8)
        /// Converts the supplied Millimetres value to Yards
        static member toYards(value : float<mm>) = yard.create(float value / 914.4)
        /// Converts the supplied Millimetres value to Miles
        static member toMiles(value : float<mm>) = mile.create(float value / 1609344.)
        /// Converts the supplied Millimetres value to Nautical Miles
        static member toNauticalMiles(value : float<mm>) = NM.create(float value / 1852000.)
    and /// Nautical Miles (NM) units
        [<Measure>] NM =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<NM> value
        /// Converts the supplied Nautical Miles value to Millimetres
        static member toMillimetres(value : float<NM>) = mm.create(float value * 1852000.)
        /// Converts the supplied Nautical Miles value to Centimetres
        static member toCentimetres(value : float<NM>) = cm.create(float value * 185200.)
        /// Converts the supplied Nautical Miles value to Metres
        static member toMetres(value : float<NM>) = m.create(float value * 1852.)
        /// Converts the supplied Nautical Miles value to Kilometres
        static member toKilometres(value : float<NM>) = km.create(float value * 1.85200)
        /// Converts the supplied Nautical Miles value to Inches
        static member toInches(value : float<NM>) = inch.create(float value * 72913.4)
        /// Converts the supplied Nautical Miles value to Feet
        static member toFeet(value : float<NM>) = ft.create(float value * 6076.12)
        /// Converts the supplied Nautical Miles value to Yards
        static member toYards(value : float<NM>) = yard.create(float value * 2025.37)
        /// Converts the supplied Nautical Miles value to Miles
        static member toMiles(value : float<NM>) = mile.create(float value * 1.15078)
    and /// Yards (yard) units
        [<Measure>] yard =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<yard> value
        /// Converts the supplied Yards value to Millimetres
        static member toMillimetres(value : float<yard>) = mm.create(float value * 914.4)
        /// Converts the supplied Yards value to Centimetres
        static member toCentimetres(value : float<yard>) = cm.create(float value * 91.44)
        /// Converts the supplied Yards value to Metres
        static member toMetres(value : float<yard>) = m.create(float value * 0.9144)
        /// Converts the supplied Yards value to Kilometres
        static member toKilometres(value : float<yard>) = km.create(float value * 0.0009144)
        /// Converts the supplied Yards value to Inches
        static member toInches(value : float<yard>) = inch.create(float value * 36.)
        /// Converts the supplied Yards value to Feet
        static member toFeet(value : float<yard>) = ft.create(float value * 3.)
        /// Converts the supplied Yards value to Miles
        static member toMiles(value : float<yard>) = mile.create(float value / 1760.)
        /// Converts the supplied Yards value to Nautical Miles
        static member toNauticalMiles(value : float<yard>) = NM.create(float value / 2025.37)
