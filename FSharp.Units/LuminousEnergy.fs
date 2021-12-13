namespace FSharp.Units

open Microsoft.FSharp.Core

module LuminousEnergy =

    /// LumenHour (lmh) units
    [<Measure>]
    type lmh =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<lmh> value
        /// Converts the supplied LumenHour value to Talbot
        static member toTalbot(value : float<lmh>) = T.create(float value * 3600.)
        /// Converts the supplied LumenHour value to LumenMinute
        static member toLumenMinute(value : float<lmh>) = lmmin.create(float value * 60.)
        /// Converts the supplied LumenHour value to LumenSecond
        static member toLumenSecond(value : float<lmh>) = lms.create(float value * 3600.)
    and /// LumenMinute (lmmin) units
        [<Measure>] lmmin =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<lmmin> value
        /// Converts the supplied LumenMinute value to Talbot
        static member toTalbot(value : float<lmmin>) = T.create(float value * 60.)
        /// Converts the supplied LumenMinute value to LumenHour
        static member toLumenHour(value : float<lmmin>) = lmh.create(float value / 60.)
        /// Converts the supplied LumenMinute value to LumenSecond
        static member toLumenSecond(value : float<lmmin>) = lms.create(float value * 60.)
    and /// LumenSecond (lms) units
        [<Measure>] lms =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<lms> value
        /// Converts the supplied LumenSecond value to Talbot
        static member toTalbot(value : float<lms>) = T.create(float value)
        /// Converts the supplied LumenSecond value to LumenHour
        static member toLumenHour(value : float<lms>) = lmh.create(float value / 3600.)
        /// Converts the supplied LumenSecond value to LumenMinute
        static member toLumenMinute(value : float<lms>) = lmmin.create(float value / 60.)
    and /// Talbot (T) units
        [<Measure>] T =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<T> value
        /// Converts the supplied Talbot value to LumenSecond
        static member toLumenSecond(value : float<T>) = lms.create(float value)
        /// Converts the supplied Talbot value to LumenHour
        static member toLumenHour(value : float<T>) = lmh.create(float value / 3600.)
        /// Converts the supplied Talbot value to LumenMinute
        static member toLumenMinute(value : float<T>) = lmmin.create(float value / 60.)
