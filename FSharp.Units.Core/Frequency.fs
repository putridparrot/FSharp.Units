namespace FSharp.Units

open Microsoft.FSharp.Core

module Frequency =

    [<Measure>]
    type Hz =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Hz> value
        static member toKilohertz(value : float<Hz>) = kHz.create(Utils.removeUnit(value / 1000.0))
        static member toMegahertz(value : float<Hz>) = MHz.create(Utils.removeUnit(value / 1e+6))
        static member toGigahertz(value : float<Hz>) = GHz.create(Utils.removeUnit(value / 1e+9))
    and [<Measure>] kHz =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kHz> value
        static member toHertz(value : float<kHz>) = Hz.create(Utils.removeUnit(value * 1000.0))
        static member toMegahertz(value : float<kHz>) = MHz.create(Utils.removeUnit(value / 1000.0))
        static member toGigahertz(value : float<kHz>) = GHz.create(Utils.removeUnit(value / 1e+6))
    and [<Measure>] MHz =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<MHz> value
        static member toHertz(value : float<MHz>) = Hz.create(Utils.removeUnit(value * 1e+6))
        static member toKilohertz(value : float<MHz>) = kHz.create(Utils.removeUnit(value * 1000.0))
        static member toGigahertz(value : float<MHz>) = GHz.create(Utils.removeUnit(value / 1000.0))
    and [<Measure>] GHz =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<GHz> value
        static member toHertz(value : float<GHz>) = Hz.create(Utils.removeUnit(value * 1e+9))
        static member toKilohertz(value : float<GHz>) = kHz.create(Utils.removeUnit(value * 1e+6))
        static member toMegahertz(value : float<GHz>) = MHz.create(Utils.removeUnit(value * 1000.0))
