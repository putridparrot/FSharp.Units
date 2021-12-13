namespace FSharp.Units

open Microsoft.FSharp.Core

module Speed =

    /// Feet Per Second (fps) units
    [<Measure>]
    type fps =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<fps> value
        /// Converts the supplied Feet Per Second value to Miles Per Hour
        static member toMilesPerHour(value : float<fps>) = mph.create(float value * 0.681818)
        /// Converts the supplied Feet Per Second value to Kilometres Per Hour
        static member toKilometresPerHour(value : float<fps>) = kph.create(float value * 1.09728)
        /// Converts the supplied Feet Per Second value to Metres Per Second
        static member toMetresPerSecond(value : float<fps>) = mps.create(float value * 0.3048)
        /// Converts the supplied Feet Per Second value to Knots
        static member toKnots(value : float<fps>) = knot.create(float value * 0.592484)
    and /// Kilometres Per Hour (kph) units
        [<Measure>] kph =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kph> value
        /// Converts the supplied Kilometres Per Hour value to Miles Per Hour
        static member toMilesPerHour(value : float<kph>) = mph.create(float value * 0.621371)
        /// Converts the supplied Kilometres Per Hour value to Feet Per Second
        static member toFeetPerSecond(value : float<kph>) = fps.create(float value * 0.911344)
        /// Converts the supplied Kilometres Per Hour value to Metres Per Second
        static member toMetresPerSecond(value : float<kph>) = mps.create(float value * 0.277778)
        /// Converts the supplied Kilometres Per Hour value to Knots
        static member toKnots(value : float<kph>) = knot.create(float value * 0.539957)
    and /// Knots (knot) units
        [<Measure>] knot =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<knot> value
        /// Converts the supplied Knots value to Miles Per Hour
        static member toMilesPerHour(value : float<knot>) = mph.create(float value * 1.15078)
        /// Converts the supplied Knots value to Kilometres Per Hour
        static member toKilometresPerHour(value : float<knot>) = kph.create(float value * 1.852)
        /// Converts the supplied Knots value to Feet Per Second
        static member toFeetPerSecond(value : float<knot>) = fps.create(float value * 1.68781)
        /// Converts the supplied Knots value to Metres Per Second
        static member toMetresPerSecond(value : float<knot>) = mps.create(float value * 0.514444)
    and /// Metres Per Second (mps) units
        [<Measure>] mps =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<mps> value
        /// Converts the supplied Metres Per Second value to Miles Per Hour
        static member toMilesPerHour(value : float<mps>) = mph.create(float value * 2.23694)
        /// Converts the supplied Metres Per Second value to Kilometres Per Hour
        static member toKilometresPerHour(value : float<mps>) = kph.create(float value * 3.6)
        /// Converts the supplied Metres Per Second value to Feet Per Second
        static member toFeetPerSecond(value : float<mps>) = fps.create(float value * 3.28084)
        /// Converts the supplied Metres Per Second value to Knots
        static member toKnots(value : float<mps>) = knot.create(float value * 1.94384)
    and /// Miles Per Hour (mph) units
        [<Measure>] mph =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<mph> value
        /// Converts the supplied Miles Per Hour value to Kilometres Per Hour
        static member toKilometresPerHour(value : float<mph>) = kph.create(float value * 1.60934)
        /// Converts the supplied Miles Per Hour value to Feet Per Second
        static member toFeetPerSecond(value : float<mph>) = fps.create(float value * 1.46667)
        /// Converts the supplied Miles Per Hour value to Metres Per Second
        static member toMetresPerSecond(value : float<mph>) = mps.create(float value * 0.44704)
        /// Converts the supplied Miles Per Hour value to Knots
        static member toKnots(value : float<mph>) = knot.create(float value * 0.868976)
