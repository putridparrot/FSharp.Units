namespace FSharp.Units

open Microsoft.FSharp.Core

module Speed =

    // needs testing - is there a way to associate something like mps and m/s
    [<Measure>]
    type mph = // miles per hour
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<mph> value
        static member toKilometresPerHour(value : float<mph>) = value * 1.60934<kph/mph>
        static member toFeetPerSecond(value : float<mph>) = value * 1.46667<fps/mph>
        static member toMetresPerSecond(value : float<mph>) = value * 0.44704<mps/mph>
        static member toKnots(value : float<mph>) = value * 0.868976<knot/mph>
    and [<Measure>] kph = // kilometres per hour
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kph> value
        static member toMilesPerHour(value : float<kph>) = value * 0.621371<mph/kph>
        static member toFeetPerSecond(value : float<kph>) = value * 0.911344<fps/kph>
        static member toMetresPerSecond(value : float<kph>) = value * 0.277778<mps/kph>
        static member toKnots(value : float<kph>) = value * 0.539957<knot/kph>
    and [<Measure>] fps = // foot per second
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<fps> value
        static member toMilesPerHour(value : float<fps>) = value * 0.681818<mph/fps>
        static member toMetresPerSecond(value : float<fps>) = value * 0.3048<mps/fps>
        static member toKilometresPerHour(value : float<fps>) = value * 1.09728<kph/fps>
        static member toKnots(value : float<fps>) = value * 0.592484<knot/fps>
    and [<Measure>] mps = // metre per second
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<fps> value
        static member toMilesPerHour(value : float<mps>) = value * 2.23694<mph/mps>
        static member toFeetPerSecond(value : float<mps>) = value * 3.28084<fps/mps>
        static member toKilometresPerHour(value : float<mps>) = value * 3.6<kph/mps>
        static member toKnots(value : float<mps>) = value * 1.94384<knot/mps>
    and [<Measure>] knot = // knots
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<knot> value
        static member toMilesPerHour(value : float<knot>) = value * 1.15078<mph/knot>
        static member toFeetPerSecond(value : float<knot>) = value * 1.68781<fps/knot>
        static member toMetresPerSecond(value : float<knot>) = value * 0.514444<mps/knot>
        static member toKilometresPerHour(value : float<knot>) = value * 1.852<kph/knot>
    and [<Measure>] minmile = // min/mile
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<minmile> value
        static member toMilesPerHour(value : float<minmile>) = value * 60.<mph/minmile>
    and [<Measure>] minkm = // min/km
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<minkm> value
        static member toKilometresPerHour(value : float<minkm>) = value * 60.<kph/minkm>
