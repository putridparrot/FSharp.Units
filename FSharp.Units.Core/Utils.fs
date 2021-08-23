namespace FSharp.Units

module Utils =

    let internal removeUnit(value : float<_>) =
        float value