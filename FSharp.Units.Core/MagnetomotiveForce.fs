namespace FSharp.Units

open Microsoft.FSharp.Core

module MagnetomotiveForce =

 [<Measure>]
    type AT = // Ampere-turn
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<AT> value
        static member toGilbert(value : float<AT>) = value * 1.256637061436<Gi/AT>
    and [<Measure>] Gi = // Gilbert
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Gi> value
        static member toAmpereTurn(value : float<Gi>) = value * 0.7957747154595<AT/Gi>
