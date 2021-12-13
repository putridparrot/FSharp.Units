namespace FSharp.Units

open System
open Microsoft.FSharp.Core

module Angle =

    /// Degrees (deg) units
    [<Measure>]
    type deg =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<deg> value
        /// Converts the supplied Degrees value to Radians
        static member toRadians(value : float<deg>) = rad.create(float value * Math.PI/180.)
        /// Converts the supplied Degrees value to Gradians
        static member toGradians(value : float<deg>) = grad.create(float value * 200./180.)
        /// Converts the supplied Degrees value to Milliradians
        static member toMilliradians(value : float<deg>) = mrad.create(float value * 17.4533)
        /// Converts the supplied Degrees value to Minute Of Arc
        static member toMinuteOfArc(value : float<deg>) = arcmin.create(float value * 60.)
        /// Converts the supplied Degrees value to Seconds Of Arc
        static member toSecondsOfArc(value : float<deg>) = arcseconds.create(float value * 3600.)
    and /// Gradians (grad) units
        [<Measure>] grad =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<grad> value
        /// Converts the supplied Gradians value to Degrees
        static member toDegrees(value : float<grad>) = deg.create(float value * 180.0/200.0)
        /// Converts the supplied Gradians value to Radians
        static member toRadians(value : float<grad>) = rad.create(float value * Math.PI/200.0)
        /// Converts the supplied Gradians value to Milliradians
        static member toMilliradians(value : float<grad>) = mrad.create(float value * 15.708)
        /// Converts the supplied Gradians value to Minute Of Arc
        static member toMinuteOfArc(value : float<grad>) = arcmin.create(float value * 54.0)
        /// Converts the supplied Gradians value to Seconds Of Arc
        static member toSecondsOfArc(value : float<grad>) = arcseconds.create(float value * 3240.0)
    and /// Milliradians (mrad) units
        [<Measure>] mrad =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<mrad> value
        /// Converts the supplied Milliradians value to Degrees
        static member toDegrees(value : float<mrad>) = deg.create(float value * 180.0/(1000.0 * Math.PI))
        /// Converts the supplied Milliradians value to Radians
        static member toRadians(value : float<mrad>) = rad.create(float value / 1000.0)
        /// Converts the supplied Milliradians value to Gradians
        static member toGradians(value : float<mrad>) = grad.create(float value * 200.0/(1000.0 * Math.PI))
        /// Converts the supplied Milliradians value to Minute Of Arc
        static member toMinuteOfArc(value : float<mrad>) = arcmin.create(float value * (60.0 * 180.0)/(1000.0 * Math.PI))
        /// Converts the supplied Milliradians value to Seconds Of Arc
        static member toSecondsOfArc(value : float<mrad>) = arcseconds.create(float value * (3600.0 * 180.0)/(1000.0 * Math.PI))
    and /// Minute Of Arc (arcmin) units
        [<Measure>] arcmin =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<arcmin> value
        /// Converts the supplied Minute Of Arc value to Degrees
        static member toDegrees(value : float<arcmin>) = deg.create(float value / 60.)
        /// Converts the supplied Minute Of Arc value to Radians
        static member toRadians(value : float<arcmin>) = rad.create(float value * Math.PI/(60.0 * 180.0))
        /// Converts the supplied Minute Of Arc value to Gradians
        static member toGradians(value : float<arcmin>) = grad.create(float value / 54.)
        /// Converts the supplied Minute Of Arc value to Milliradians
        static member toMilliradians(value : float<arcmin>) = mrad.create(float value * (1000.0 * Math.PI) / (60.0 * 180.0))
        /// Converts the supplied Minute Of Arc value to Seconds Of Arc
        static member toSecondsOfArc(value : float<arcmin>) = arcseconds.create(float value * 60.)
    and /// Radians (rad) units
        [<Measure>] rad =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<rad> value
        /// Converts the supplied Radians value to Degrees
        static member toDegrees(value : float<rad>) = deg.create(float value * 180./Math.PI)
        /// Converts the supplied Radians value to Gradians
        static member toGradians(value : float<rad>) = grad.create(float value * 200./Math.PI)
        /// Converts the supplied Radians value to Milliradians
        static member toMilliradians(value : float<rad>) = mrad.create(float value * 1000.)
        /// Converts the supplied Radians value to Minute Of Arc
        static member toMinuteOfArc(value : float<rad>) = arcmin.create(float value * (60.0 * 180.0)/Math.PI)
        /// Converts the supplied Radians value to Seconds Of Arc
        static member toSecondsOfArc(value : float<rad>) = arcseconds.create(float value * (3600.0 * 180.0)/Math.PI)
    and /// Seconds Of Arc (arcseconds) units
        [<Measure>] arcseconds =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<arcseconds> value
        /// Converts the supplied Seconds Of Arc value to Degrees
        static member toDegrees(value : float<arcseconds>) = deg.create(float value / 3600.)
        /// Converts the supplied Seconds Of Arc value to Radians
        static member toRadians(value : float<arcseconds>) = rad.create(float value * Math.PI/(180.0 * 3600.0))
        /// Converts the supplied Seconds Of Arc value to Gradians
        static member toGradians(value : float<arcseconds>) = grad.create(float value / 3240.)
        /// Converts the supplied Seconds Of Arc value to Milliradians
        static member toMilliradians(value : float<arcseconds>) = mrad.create(float value * (1000.0 * Math.PI) / (180.0 * 3600.0))
        /// Converts the supplied Seconds Of Arc value to Minute Of Arc
        static member toMinuteOfArc(value : float<arcseconds>) = arcmin.create(float value / 60.)