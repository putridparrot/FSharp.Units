// <auto-generated>
// This code was generated by the UnitCodeGenerator tool
//
// Changes to this file will be lost if the code is regenerated
// </auto-generated>

namespace FSharp.Units

open Microsoft.FSharp.Core

module Frequency =

    /// Gigahertz (GHz) units
    [<Measure>]
    type GHz =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<GHz> value
        /// Converts the supplied Gigahertz value to Hertz
        static member toHertz(value : float<GHz>) = Hz.create(float value * 1e+9)
        /// Converts the supplied Gigahertz value to Kilohertz
        static member toKilohertz(value : float<GHz>) = kHz.create(float value * 1e+6)
        /// Converts the supplied Gigahertz value to Megahertz
        static member toMegahertz(value : float<GHz>) = MHz.create(float value * 1000.0)
    and /// Hertz (Hz) units
        [<Measure>] Hz =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Hz> value
        /// Converts the supplied Hertz value to Kilohertz
        static member toKilohertz(value : float<Hz>) = kHz.create(float value / 1000.0)
        /// Converts the supplied Hertz value to Megahertz
        static member toMegahertz(value : float<Hz>) = MHz.create(float value / 1e+6)
        /// Converts the supplied Hertz value to Gigahertz
        static member toGigahertz(value : float<Hz>) = GHz.create(float value / 1e+9)
    and /// Kilohertz (kHz) units
        [<Measure>] kHz =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kHz> value
        /// Converts the supplied Kilohertz value to Hertz
        static member toHertz(value : float<kHz>) = Hz.create(float value * 1000.0)
        /// Converts the supplied Kilohertz value to Megahertz
        static member toMegahertz(value : float<kHz>) = MHz.create(float value / 1000.0)
        /// Converts the supplied Kilohertz value to Gigahertz
        static member toGigahertz(value : float<kHz>) = GHz.create(float value / 1e+6)
    and /// Megahertz (MHz) units
        [<Measure>] MHz =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<MHz> value
        /// Converts the supplied Megahertz value to Hertz
        static member toHertz(value : float<MHz>) = Hz.create(float value * 1e+6)
        /// Converts the supplied Megahertz value to Kilohertz
        static member toKilohertz(value : float<MHz>) = kHz.create(float value * 1000.0)
        /// Converts the supplied Megahertz value to Gigahertz
        static member toGigahertz(value : float<MHz>) = GHz.create(float value / 1000.0)
