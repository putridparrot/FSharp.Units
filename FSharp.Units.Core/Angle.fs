namespace FSharp.Units

open System
open Microsoft.FSharp.Core

module Angle =

    [<Measure>]
    type deg = // degrees
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<deg> value
        static member toRadians(value : float<deg>) = rad.create(Utils.removeUnit(value * Math.PI/180.0))
        static member toGradians(value : float<deg>) = grad.create(Utils.removeUnit(value * 200.0/180.0))
        static member toMilliradians(value : float<deg>) = mrad.create(Utils.removeUnit(value * (1000.0 * Math.PI)/ 180.0))
        static member toMinuteOfArc(value : float<deg>) = arcmin.create(Utils.removeUnit(value*60.0))
        static member toSecondsOfArc(value : float<deg>) = arcseconds.create(Utils.removeUnit(value*3600.0))
    and [<Measure>] rad = // radians
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<rad> value
        static member toDegrees(value : float<rad>) = deg.create(Utils.removeUnit(value * 180.0/Math.PI))
        static member toGradians(value : float<rad>) = grad.create(Utils.removeUnit(value * 200.0/Math.PI))
        static member toMilliradians(value : float<rad>) = mrad.create(Utils.removeUnit(value*1000.0))
        static member toMinuteOfArc(value : float<rad>) = arcmin.create(Utils.removeUnit(value * (60.0 * 180.0)/Math.PI))
        static member toSecondsOfArc(value : float<rad>) = arcseconds.create(Utils.removeUnit(value*(3600.0 * 180.0)/Math.PI))
    and [<Measure>] grad = // radians
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<grad> value
        static member toRadians(value : float<grad>) = rad.create(Utils.removeUnit(value * Math.PI/200.0))
        static member toDegrees(value : float<grad>) = deg.create(Utils.removeUnit(value * 180.0/200.0))
        static member toMilliradians(value : float<grad>) = mrad.create(Utils.removeUnit(value * 1000.0 * (Math.PI/200.0)))
        static member toMinuteOfArc(value : float<grad>) = arcmin.create(Utils.removeUnit(value * 54.0))
        static member toSecondsOfArc(value : float<grad>) = arcseconds.create(Utils.removeUnit(value * 3240.0))
    and [<Measure>] mrad = // Milliradians
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<mrad> value
        static member toDegrees(value : float<mrad>) = deg.create(Utils.removeUnit(value * 180.0/(1000.0 * Math.PI)))
        static member toRadians(value : float<mrad>) = rad.create(Utils.removeUnit(value/1000.0))
        static member toGradians(value : float<mrad>) = grad.create(Utils.removeUnit(value * 200.0/(1000.0 * Math.PI)))
        static member toMinuteOfArc(value : float<mrad>) = arcmin.create(Utils.removeUnit(value * (60.0 * 180.0)/(1000.0 * Math.PI)))
        static member toSecondsOfArc(value : float<mrad>) = arcseconds.create(Utils.removeUnit(value * (3600.0 * 180.0)/(1000.0 * Math.PI)))
    and [<Measure>] arcmin = // Minute of arc
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<arcmin> value
        static member toDegrees(value : float<arcmin>) = deg.create(Utils.removeUnit(value/60.0))
        static member toRadians(value : float<arcmin>) = rad.create(Utils.removeUnit(value * Math.PI/(60.0 * 180.0)))
        static member toGradians(value : float<arcmin>) = grad.create(Utils.removeUnit(value/54.0))
        static member toMilliradians(value : float<arcmin>) = mrad.create(Utils.removeUnit(value * (1000.0 * Math.PI) / (60.0 * 180.0)))
        static member toSecondsOfArc(value : float<arcmin>) = arcseconds.create(Utils.removeUnit(value * 60.0))
    and [<Measure>] arcseconds = // Seconds of arc
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<arcseconds> value
        static member toDegrees(value : float<arcseconds>) = deg.create(Utils.removeUnit(value/3600.0))
        static member toRadians(value : float<arcseconds>) = rad.create(Utils.removeUnit(value * Math.PI/(180.0 * 3600.0)))
        static member toGradians(value : float<arcseconds>) = grad.create(Utils.removeUnit(value/3240.0))
        static member toMilliradians(value : float<arcseconds>) = mrad.create(Utils.removeUnit(value * (1000.0 * Math.PI) / (180.0 * 3600.0)))
        static member toMinuteOfArc(value : float<arcseconds>) = arcmin.create(Utils.removeUnit(value / 60.0))


