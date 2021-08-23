namespace FSharp.Units

open Microsoft.FSharp.Core

module Pressure =

    // taken from http://www.unit-conversion.info/pressure.html
    [<Measure>]
    type Pa = // Pascals
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Pa> value
        static member toAtmosphere(value : float<Pa>) = value / 101325.<Pa/atm>
        static member toBar(value : float<Pa>) = value * 0.00001<b/Pa>
        static member toTorr(value : float<Pa>) = value * 0.007500616827042<Torr/Pa>
        static member toPsi(value : float<Pa>) = value * 0.0001450378911491<psi/Pa>
    and [<Measure>] b = // bar
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<b> value
        static member toAtmosphere(value : float<b>) = value / 1.01325<b/atm>
        static member toPascal(value : float<b>) = value / 0.00001<b/Pa>
        static member toTorr(value : float<b>) = value * 750.0616827042<Torr/b>
        static member toPsi(value : float<b>) = value * 14.50378911491<psi/b>
    and [<Measure>] atm = // Atmosphere
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<atm> value
        static member toBar(value : float<atm>) = value * 1.01325<b/atm>
        static member toPascal(value : float<atm>) = value * 101325.<Pa/atm>
        static member toTorr(value : float<atm>) = value * 760.<Torr/atm>
        static member toPsi(value : float<atm>) = value * 14.69596432068<psi/atm>
    and [<Measure>] Torr = 
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Torr> value
        static member toAtmosphere(value : float<Torr>) = value / 760.<Torr/atm>
        static member toPascal(value : float<Torr>) = value / 0.007500616827042<Torr/Pa>
        static member toBar(value : float<Torr>) = value / 750.0616827042<Torr/b>
        static member toPsi(value : float<Torr>) = value * 0.01933679515879<psi/Torr>
    and [<Measure>] psi = // pounds per square inch
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<psi> value
        static member toAtmosphere(value : float<psi>) = value / 14.69596432068<psi/atm>
        static member toPascal(value : float<psi>) = value / 0.0001450378911491<psi/Pa>
        static member toBar(value : float<psi>) = value / 14.50378911491<psi/b>
        static member toTorr(value : float<psi>) = value / 0.01933679515879<psi/Torr>
 