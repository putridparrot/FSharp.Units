namespace FSharp.Units

open Microsoft.FSharp.Core

module MagnetomotiveForce =

    /// Ampere-turns (AT) units
    [<Measure>]
    type AT =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<AT> value
        /// Converts the supplied Ampere-turns value to Gilberts
        static member toGilberts(value : float<AT>) = Gi.create(float value * 1.256637061436)
    and /// Gilberts (Gi) units
        [<Measure>] Gi =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Gi> value
        /// Converts the supplied Gilberts value to Ampere-turns
        static member toAmpereturns(value : float<Gi>) = AT.create(float value * 0.7957747154595)
