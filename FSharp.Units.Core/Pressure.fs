namespace FSharp.Units

open Microsoft.FSharp.Core

module Pressure =

    // taken from http://www.unit-conversion.info/pressure.html
    [<Measure>]
    type Pa = // Pascals
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Pa> value
        static member toAtmosphere(value : float<Pa>) = atm.create(float value / 101325.)
        static member toBar(value : float<Pa>) = b.create(float value * 0.00001)
        static member toTorr(value : float<Pa>) = Torr.create(float value * 0.007500616827042)
        static member toPsi(value : float<Pa>) = psi.create(float value * 0.0001450378911491)
    and [<Measure>] b = // bar
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<b> value
        static member toAtmosphere(value : float<b>) = atm.create(float value / 1.01325)
        static member toPascal(value : float<b>) = Pa.create(float value / 0.00001)
        static member toTorr(value : float<b>) = Torr.create(float value * 750.0616827042)
        static member toPsi(value : float<b>) = psi.create(float value * 14.50378911491)
    and [<Measure>] atm = // Atmosphere
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<atm> value
        static member toBar(value : float<atm>) = b.create(float value * 1.01325)
        static member toPascal(value : float<atm>) = Pa.create(float value * 101325.)
        static member toTorr(value : float<atm>) = Torr.create(float value * 760.)
        static member toPsi(value : float<atm>) = psi.create(float value * 14.69596432068)
    and [<Measure>] Torr = 
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Torr> value
        static member toAtmosphere(value : float<Torr>) = atm.create(float value / 760.)
        static member toPascal(value : float<Torr>) = Pa.create(float value / 0.007500616827042)
        static member toBar(value : float<Torr>) = b.create(float value / 750.0616827042)
        static member toPsi(value : float<Torr>) = psi.create(float value * 0.01933679515879)
    and [<Measure>] psi = // pounds per square inch
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<psi> value
        static member toAtmosphere(value : float<psi>) = atm.create(float value / 14.69596432068)
        static member toPascal(value : float<psi>) = Pa.create(float value / 0.0001450378911491)
        static member toBar(value : float<psi>) = b.create(float value / 14.50378911491)
        static member toTorr(value : float<psi>) = Torr.create(float value / 0.01933679515879)
 