namespace FSharp.Units

open Microsoft.FSharp.Core

module Energy =

    /// Btu (btu) units
    [<Measure>]
    type btu =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<btu> value
        /// Converts the supplied Btu value to Kilojoules
        static member toKilojoules(value : float<btu>) = kJ.create(float value * 1.0550559)
        /// Converts the supplied Btu value to Kilocalories
        static member toKilocalories(value : float<btu>) = kCal.create(float value / 3.966)
        /// Converts the supplied Btu value to Joules
        static member toJoules(value : float<btu>) = J.create(float value * 1055.06)
        /// Converts the supplied Btu value to Calories
        static member toCalories(value : float<btu>) = cal.create(float value * 252.164)
        /// Converts the supplied Btu value to US Therms
        static member toUSTherms(value : float<btu>) = ustherm.create(float value / 99976.12448781215)
        /// Converts the supplied Btu value to Watt Hours
        static member toWattHours(value : float<btu>) = Wh.create(float value * 0.293071)
        /// Converts the supplied Btu value to Kilowatt Hours
        static member toKilowattHours(value : float<btu>) = kWh.create(float value / 3412.14)
        /// Converts the supplied Btu value to Foot Pounds
        static member toFootPounds(value : float<btu>) = ftlb.create(float value * 778.169)
    and /// Calories (cal) units
        [<Measure>] cal =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<cal> value
        /// Converts the supplied Calories value to Kilojoules
        static member toKilojoules(value : float<cal>) = kJ.create(float value / 239.0057)
        /// Converts the supplied Calories value to Kilocalories
        static member toKilocalories(value : float<cal>) = kCal.create(float value / 1000.)
        /// Converts the supplied Calories value to Joules
        static member toJoules(value : float<cal>) = J.create(float value * 4.184)
        /// Converts the supplied Calories value to Btu
        static member toBtu(value : float<cal>) = btu.create(float value / 252.164)
        /// Converts the supplied Calories value to US Therms
        static member toUSTherms(value : float<cal>) = ustherm.create(float value / 25210420.0)
        /// Converts the supplied Calories value to Watt Hours
        static member toWattHours(value : float<cal>) = Wh.create(float value * 0.00116222)
        /// Converts the supplied Calories value to Kilowatt Hours
        static member toKilowattHours(value : float<cal>) = kWh.create(float value / 860421.0)
        /// Converts the supplied Calories value to Foot Pounds
        static member toFootPounds(value : float<cal>) = ftlb.create(float value * 3.08596)
    and /// ElectronVolts (eV) units
        [<Measure>] eV =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<eV> value
    and /// Foot Pounds (ftlb) units
        [<Measure>] ftlb =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<ftlb> value
        /// Converts the supplied Foot Pounds value to Kilojoules
        static member toKilojoules(value : float<ftlb>) = kJ.create(float value / 737.562)
        /// Converts the supplied Foot Pounds value to Kilocalories
        static member toKilocalories(value : float<ftlb>) = kCal.create(float value / 3085.96)
        /// Converts the supplied Foot Pounds value to Joules
        static member toJoules(value : float<ftlb>) = J.create(float value * 1.35582)
        /// Converts the supplied Foot Pounds value to Btu
        static member toBtu(value : float<ftlb>) = btu.create(float value / 778.169)
        /// Converts the supplied Foot Pounds value to Calories
        static member toCalories(value : float<ftlb>) = cal.create(float value / 3.08596)
        /// Converts the supplied Foot Pounds value to US Therms
        static member toUSTherms(value : float<ftlb>) = ustherm.create(float value / 77816937.099186)
        /// Converts the supplied Foot Pounds value to Watt Hours
        static member toWattHours(value : float<ftlb>) = Wh.create(float value / 2655.22)
        /// Converts the supplied Foot Pounds value to Kilowatt Hours
        static member toKilowattHours(value : float<ftlb>) = kWh.create(float value * 0.00000037662)
    and /// Joules (J) units
        [<Measure>] J =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<J> value
        /// Converts the supplied Joules value to Kilojoules
        static member toKilojoules(value : float<J>) = kJ.create(float value / 1000.)
        /// Converts the supplied Joules value to Kilocalories
        static member toKilocalories(value : float<J>) = kCal.create(float value / 4184.)
        /// Converts the supplied Joules value to Btu
        static member toBtu(value : float<J>) = btu.create(float value / 1055.)
        /// Converts the supplied Joules value to Calories
        static member toCalories(value : float<J>) = cal.create(float value / 4.184)
        /// Converts the supplied Joules value to US Therms
        static member toUSTherms(value : float<J>) = ustherm.create(float value / 105480400.0)
        /// Converts the supplied Joules value to Watt Hours
        static member toWattHours(value : float<J>) = Wh.create(float value / 3600.0)
        /// Converts the supplied Joules value to Kilowatt Hours
        static member toKilowattHours(value : float<J>) = kWh.create(float value / 3.6e+6)
        /// Converts the supplied Joules value to Foot Pounds
        static member toFootPounds(value : float<J>) = ftlb.create(float value / 1.35582)
    and /// Kilocalories (kCal) units
        [<Measure>] kCal =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kCal> value
        /// Converts the supplied Kilocalories value to Kilojoules
        static member toKilojoules(value : float<kCal>) = kJ.create(float value * 4.184)
        /// Converts the supplied Kilocalories value to Joules
        static member toJoules(value : float<kCal>) = J.create(float value * 4184.)
        /// Converts the supplied Kilocalories value to Btu
        static member toBtu(value : float<kCal>) = btu.create(float value * 3.966)
        /// Converts the supplied Kilocalories value to Calories
        static member toCalories(value : float<kCal>) = cal.create(float value * 1000.)
        /// Converts the supplied Kilocalories value to US Therms
        static member toUSTherms(value : float<kCal>) = ustherm.create(float value / 25210.4)
        /// Converts the supplied Kilocalories value to Watt Hours
        static member toWattHours(value : float<kCal>) = Wh.create(float value * 1.16222)
        /// Converts the supplied Kilocalories value to Kilowatt Hours
        static member toKilowattHours(value : float<kCal>) = kWh.create(float value / 860.421)
        /// Converts the supplied Kilocalories value to Foot Pounds
        static member toFootPounds(value : float<kCal>) = ftlb.create(float value * 3085.96)
    and /// Kilojoules (kJ) units
        [<Measure>] kJ =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kJ> value
        /// Converts the supplied Kilojoules value to Kilocalories
        static member toKilocalories(value : float<kJ>) = kCal.create(float value / 4.184)
        /// Converts the supplied Kilojoules value to Joules
        static member toJoules(value : float<kJ>) = J.create(float value * 1000.)
        /// Converts the supplied Kilojoules value to Btu
        static member toBtu(value : float<kJ>) = btu.create(float value / 1.0550559)
        /// Converts the supplied Kilojoules value to Calories
        static member toCalories(value : float<kJ>) = cal.create(float value * 239.0057)
        /// Converts the supplied Kilojoules value to US Therms
        static member toUSTherms(value : float<kJ>) = ustherm.create(float value / 105480.04)
        /// Converts the supplied Kilojoules value to Watt Hours
        static member toWattHours(value : float<kJ>) = Wh.create(float value / 3.6)
        /// Converts the supplied Kilojoules value to Kilowatt Hours
        static member toKilowattHours(value : float<kJ>) = kWh.create(float value / 3600.0)
        /// Converts the supplied Kilojoules value to Foot Pounds
        static member toFootPounds(value : float<kJ>) = ftlb.create(float value * 737.562)
    and /// Kilowatt Hours (kWh) units
        [<Measure>] kWh =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kWh> value
        /// Converts the supplied Kilowatt Hours value to Kilojoules
        static member toKilojoules(value : float<kWh>) = kJ.create(float value * 3600.0)
        /// Converts the supplied Kilowatt Hours value to Kilocalories
        static member toKilocalories(value : float<kWh>) = kCal.create(float value * 860.421)
        /// Converts the supplied Kilowatt Hours value to Joules
        static member toJoules(value : float<kWh>) = J.create(float value * 3.6e+6)
        /// Converts the supplied Kilowatt Hours value to Btu
        static member toBtu(value : float<kWh>) = btu.create(float value * 3412.14)
        /// Converts the supplied Kilowatt Hours value to Calories
        static member toCalories(value : float<kWh>) = cal.create(float value * 860421.0)
        /// Converts the supplied Kilowatt Hours value to US Therms
        static member toUSTherms(value : float<kWh>) = ustherm.create(float value / 29.3)
        /// Converts the supplied Kilowatt Hours value to Watt Hours
        static member toWattHours(value : float<kWh>) = Wh.create(float value * 1000.0)
        /// Converts the supplied Kilowatt Hours value to Foot Pounds
        static member toFootPounds(value : float<kWh>) = ftlb.create(float value / 0.00000037662)
    and /// US Therms (ustherm) units
        [<Measure>] ustherm =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<ustherm> value
        /// Converts the supplied US Therms value to Kilojoules
        static member toKilojoules(value : float<ustherm>) = kJ.create(float value * 105480.04)
        /// Converts the supplied US Therms value to Kilocalories
        static member toKilocalories(value : float<ustherm>) = kCal.create(float value * 25210.4)
        /// Converts the supplied US Therms value to Joules
        static member toJoules(value : float<ustherm>) = J.create(float value * 105480400.0)
        /// Converts the supplied US Therms value to Btu
        static member toBtu(value : float<ustherm>) = btu.create(float value * 99976.12448781215)
        /// Converts the supplied US Therms value to Calories
        static member toCalories(value : float<ustherm>) = cal.create(float value * 25210420.0)
        /// Converts the supplied US Therms value to Watt Hours
        static member toWattHours(value : float<ustherm>) = Wh.create(float value * 29300.1)
        /// Converts the supplied US Therms value to Kilowatt Hours
        static member toKilowattHours(value : float<ustherm>) = kWh.create(float value * 29.3)
        /// Converts the supplied US Therms value to Foot Pounds
        static member toFootPounds(value : float<ustherm>) = ftlb.create(float value * 77816937.099186)
    and /// Watt Hours (Wh) units
        [<Measure>] Wh =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Wh> value
        /// Converts the supplied Watt Hours value to Kilojoules
        static member toKilojoules(value : float<Wh>) = kJ.create(float value * 3.6)
        /// Converts the supplied Watt Hours value to Kilocalories
        static member toKilocalories(value : float<Wh>) = kCal.create(float value / 1.16222)
        /// Converts the supplied Watt Hours value to Joules
        static member toJoules(value : float<Wh>) = J.create(float value * 3600.0)
        /// Converts the supplied Watt Hours value to Btu
        static member toBtu(value : float<Wh>) = btu.create(float value / 0.293071)
        /// Converts the supplied Watt Hours value to Calories
        static member toCalories(value : float<Wh>) = cal.create(float value / 0.00116222)
        /// Converts the supplied Watt Hours value to US Therms
        static member toUSTherms(value : float<Wh>) = ustherm.create(float value / 29300.1)
        /// Converts the supplied Watt Hours value to Kilowatt Hours
        static member toKilowattHours(value : float<Wh>) = kWh.create(float value / 1000.0)
        /// Converts the supplied Watt Hours value to Foot Pounds
        static member toFootPounds(value : float<Wh>) = ftlb.create(float value * 2655.22)