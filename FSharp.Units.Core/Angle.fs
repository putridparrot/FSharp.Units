namespace FSharp.Units

open System
open Microsoft.FSharp.Core

module Angle =

    [<Measure>]
    type deg = // degrees
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<deg> value
        static member toRadians(value : float<deg>) = rad.create(float value * Math.PI/180.0)
        static member toGradians(value : float<deg>) = grad.create(float value * 200.0/180.0)
        static member toMilliradians(value : float<deg>) = mrad.create(float value * (1000.0 * Math.PI)/ 180.0)
        static member toMinuteOfArc(value : float<deg>) = arcmin.create(float value*60.0)
        static member toSecondsOfArc(value : float<deg>) = arcseconds.create(float value*3600.0)
    and [<Measure>] rad = // radians
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<rad> value
        static member toDegrees(value : float<rad>) = deg.create(float value * 180.0/Math.PI)
        static member toGradians(value : float<rad>) = grad.create(float value * 200.0/Math.PI)
        static member toMilliradians(value : float<rad>) = mrad.create(float value*1000.0)
        static member toMinuteOfArc(value : float<rad>) = arcmin.create(float value * (60.0 * 180.0)/Math.PI)
        static member toSecondsOfArc(value : float<rad>) = arcseconds.create(float value*(3600.0 * 180.0)/Math.PI)
    and [<Measure>] grad = // radians
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<grad> value
        static member toRadians(value : float<grad>) = rad.create(float value * Math.PI/200.0)
        static member toDegrees(value : float<grad>) = deg.create(float value * 180.0/200.0)
        static member toMilliradians(value : float<grad>) = mrad.create(float value * 1000.0 * (Math.PI/200.0))
        static member toMinuteOfArc(value : float<grad>) = arcmin.create(float value * 54.0)
        static member toSecondsOfArc(value : float<grad>) = arcseconds.create(float value * 3240.0)
    and [<Measure>] mrad = // Milliradians
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<mrad> value
        static member toDegrees(value : float<mrad>) = deg.create(float value * 180.0/(1000.0 * Math.PI))
        static member toRadians(value : float<mrad>) = rad.create(float value/1000.0)
        static member toGradians(value : float<mrad>) = grad.create(float value * 200.0/(1000.0 * Math.PI))
        static member toMinuteOfArc(value : float<mrad>) = arcmin.create(float value * (60.0 * 180.0)/(1000.0 * Math.PI))
        static member toSecondsOfArc(value : float<mrad>) = arcseconds.create(float value * (3600.0 * 180.0)/(1000.0 * Math.PI))
    and [<Measure>] arcmin = // Minute of arc
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<arcmin> value
        static member toDegrees(value : float<arcmin>) = deg.create(float value/60.0)
        static member toRadians(value : float<arcmin>) = rad.create(float value * Math.PI/(60.0 * 180.0))
        static member toGradians(value : float<arcmin>) = grad.create(float value/54.0)
        static member toMilliradians(value : float<arcmin>) = mrad.create(float value * (1000.0 * Math.PI) / (60.0 * 180.0))
        static member toSecondsOfArc(value : float<arcmin>) = arcseconds.create(float value * 60.0)
    and [<Measure>] arcseconds = // Seconds of arc
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<arcseconds> value
        static member toDegrees(value : float<arcseconds>) = deg.create(float value/3600.0)
        static member toRadians(value : float<arcseconds>) = rad.create(float value * Math.PI/(180.0 * 3600.0))
        static member toGradians(value : float<arcseconds>) = grad.create(float value/3240.0)
        static member toMilliradians(value : float<arcseconds>) = mrad.create(float value * (1000.0 * Math.PI) / (180.0 * 3600.0))
        static member toMinuteOfArc(value : float<arcseconds>) = arcmin.create(float value / 60.0)