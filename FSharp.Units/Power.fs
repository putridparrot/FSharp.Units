// <auto-generated>
// This code was generated by the UnitCodeGenerator tool
//
// Changes to this file will be lost if the code is regenerated
// </auto-generated>

namespace FSharp.Units

open Microsoft.FSharp.Core

module Power =

    /// Mechanical Horse Power (hp) units
    [<Measure>]
    type hp =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<hp> value
        /// Converts the supplied Mechanical Horse Power value to Metric Horse Power
        static member toMetricHorsePower(value : float<hp>) = ps.create(float value * 1.013869665424)
    and /// Metric Horse Power (ps) units
        [<Measure>] ps =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<ps> value
        /// Converts the supplied Metric Horse Power value to Mechanical Horse Power
        static member toMechanicalHorsePower(value : float<ps>) = hp.create(float value / 1.013869665424)