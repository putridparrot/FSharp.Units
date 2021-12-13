namespace FSharp.Units

open Microsoft.FSharp.Core

module Pressure =

    /// Atmospheres (atm) units
    [<Measure>]
    type atm =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<atm> value
        /// Converts the supplied Atmospheres value to Bars
        static member toBars(value : float<atm>) = b.create(float value * 1.01325)
        /// Converts the supplied Atmospheres value to Pascals
        static member toPascals(value : float<atm>) = Pa.create(float value * 101325.)
        /// Converts the supplied Atmospheres value to Torrs
        static member toTorrs(value : float<atm>) = Torr.create(float value * 760.)
        /// Converts the supplied Atmospheres value to Psi
        static member toPsi(value : float<atm>) = psi.create(float value * 14.69596432068)
    and /// Bars (b) units
        [<Measure>] b =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<b> value
        /// Converts the supplied Bars value to Atmospheres
        static member toAtmospheres(value : float<b>) = atm.create(float value / 1.01325)
        /// Converts the supplied Bars value to Pascals
        static member toPascals(value : float<b>) = Pa.create(float value / 0.00001)
        /// Converts the supplied Bars value to Torrs
        static member toTorrs(value : float<b>) = Torr.create(float value * 750.0616827042)
        /// Converts the supplied Bars value to Psi
        static member toPsi(value : float<b>) = psi.create(float value * 14.50378911491)
    and /// Pascals (Pa) units
        [<Measure>] Pa =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Pa> value
        /// Converts the supplied Pascals value to Atmospheres
        static member toAtmospheres(value : float<Pa>) = atm.create(float value / 101325.)
        /// Converts the supplied Pascals value to Bars
        static member toBars(value : float<Pa>) = b.create(float value * 0.00001)
        /// Converts the supplied Pascals value to Torrs
        static member toTorrs(value : float<Pa>) = Torr.create(float value * 0.007500616827042)
        /// Converts the supplied Pascals value to Psi
        static member toPsi(value : float<Pa>) = psi.create(float value * 0.0001450378911491)
    and /// Psi (psi) units
        [<Measure>] psi =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<psi> value
        /// Converts the supplied Psi value to Bars
        static member toBars(value : float<psi>) = b.create(float value / 14.50378911491)
        /// Converts the supplied Psi value to Pascals
        static member toPascals(value : float<psi>) = Pa.create(float value / 0.0001450378911491)
        /// Converts the supplied Psi value to Atmospheres
        static member toAtmospheres(value : float<psi>) = atm.create(float value / 14.69596432068)
        /// Converts the supplied Psi value to Torrs
        static member toTorrs(value : float<psi>) = Torr.create(float value / 0.01933679515879)
    and /// Torrs (Torr) units
        [<Measure>] Torr =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Torr> value
        /// Converts the supplied Torrs value to Bars
        static member toBars(value : float<Torr>) = b.create(float value / 750.0616827042)
        /// Converts the supplied Torrs value to Pascals
        static member toPascals(value : float<Torr>) = Pa.create(float value / 0.007500616827042)
        /// Converts the supplied Torrs value to Atmospheres
        static member toAtmospheres(value : float<Torr>) = atm.create(float value / 760.)
        /// Converts the supplied Torrs value to Psi
        static member toPsi(value : float<Torr>) = psi.create(float value * 0.01933679515879)
