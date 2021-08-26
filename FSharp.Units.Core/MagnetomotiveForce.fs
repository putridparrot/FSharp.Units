namespace FSharp.Units

open Microsoft.FSharp.Core

module MagnetomotiveForce =

    [<Measure>]
    type AT = // Ampere-turn
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<AT> value
        static member toGilbert(value : float<AT>) = Gi.create(float value * 1.256637061436)
    and [<Measure>] Gi = // Gilbert
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Gi> value
        static member toAmpereTurn(value : float<Gi>) = AT.create(float value * 0.7957747154595)
