namespace FSharp.Units.Tests

module Helpers =

    open FsCheck

    let testRange f value =
        let inRange v = (v > -1E+10) && (v < 1E+10)
        inRange value ==> lazy (f value)

    let removeUnits<[<Measure>]'u> value = float value