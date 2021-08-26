namespace FSharp.Units

open Microsoft.FSharp.Core

module Speed =

    // needs testing - is there a way to associate something like mps and m/s
    [<Measure>]
    type mph = // miles per hour
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<mph> value
        static member toKilometresPerHour(value : float<mph>) = kph.create(float value * 1.60934)
        static member toFeetPerSecond(value : float<mph>) = fps.create(float value * 1.46667)
        static member toMetresPerSecond(value : float<mph>) = mps.create(float value * 0.44704)
        static member toKnots(value : float<mph>) = knot.create(float value * 0.868976)
    and [<Measure>] kph = // kilometres per hour
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kph> value
        static member toMilesPerHour(value : float<kph>) = mph.create(float value * 0.621371)
        static member toFeetPerSecond(value : float<kph>) = fps.create(float value * 0.911344)
        static member toMetresPerSecond(value : float<kph>) = mps.create(float value * 0.277778)
        static member toKnots(value : float<kph>) = knot.create(float value * 0.539957)
    and [<Measure>] fps = // foot per second
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<fps> value
        static member toMilesPerHour(value : float<fps>) = mph.create(float value * 0.681818)
        static member toMetresPerSecond(value : float<fps>) = mps.create(float value * 0.3048)
        static member toKilometresPerHour(value : float<fps>) = kph.create(float value * 1.09728)
        static member toKnots(value : float<fps>) = knot.create(float value * 0.592484)
    and [<Measure>] mps = // metre per second
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<fps> value
        static member toMilesPerHour(value : float<mps>) = mph.create(float value * 2.23694)
        static member toFeetPerSecond(value : float<mps>) = fps.create(float value * 3.28084)
        static member toKilometresPerHour(value : float<mps>) = kph.create(float value * 3.6)
        static member toKnots(value : float<mps>) = knot.create(float value * 1.94384)
    and [<Measure>] knot = // knots
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<knot> value
        static member toMilesPerHour(value : float<knot>) = mph.create(float value * 1.15078)
        static member toFeetPerSecond(value : float<knot>) = fps.create(float value * 1.68781)
        static member toMetresPerSecond(value : float<knot>) = mps.create(float value * 0.514444)
        static member toKilometresPerHour(value : float<knot>) = kph.create(float value * 1.852)
    and [<Measure>] minmile = // min/mile
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<minmile> value
        static member toMilesPerHour(value : float<minmile>) = mph.create(float value * 60.)
    and [<Measure>] minkm = // min/km
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<minkm> value
        static member toKilometresPerHour(value : float<minkm>) = kph.create(float value * 60.)
