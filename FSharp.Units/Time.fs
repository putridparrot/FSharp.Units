namespace FSharp.Units

open Microsoft.FSharp.Core

module Time =

    /// Centuries (century) units
    [<Measure>]
    type century =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<century> value
        /// Converts the supplied Centuries value to Seconds
        static member toSeconds(value : float<century>) = second.create(float value * 3.154e+9)
        /// Converts the supplied Centuries value to Minutes
        static member toMinutes(value : float<century>) = minute.create(float value * 5.256e+7)
        /// Converts the supplied Centuries value to Hours
        static member toHours(value : float<century>) = hour.create(float value * 876000.0)
        /// Converts the supplied Centuries value to Days
        static member toDays(value : float<century>) = day.create(float value * 36500.0)
        /// Converts the supplied Centuries value to Weeks
        static member toWeeks(value : float<century>) = week.create(float value * 5214.0)
        /// Converts the supplied Centuries value to Months
        static member toMonths(value : float<century>) = month.create(float value * 1200.0)
        /// Converts the supplied Centuries value to Years
        static member toYears(value : float<century>) = year.create(float value * 100.0)
        /// Converts the supplied Centuries value to Decades
        static member toDecades(value : float<century>) = decade.create(float value * 10.0)
    and /// Days (day) units
        [<Measure>] day =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<day> value
        /// Converts the supplied Days value to Seconds
        static member toSeconds(value : float<day>) = second.create(float value * 86400.0)
        /// Converts the supplied Days value to Minutes
        static member toMinutes(value : float<day>) = minute.create(float value * 1440.0)
        /// Converts the supplied Days value to Hours
        static member toHours(value : float<day>) = hour.create(float value * 24.0)
        /// Converts the supplied Days value to Weeks
        static member toWeeks(value : float<day>) = week.create(float value / 7.0)
        /// Converts the supplied Days value to Months
        static member toMonths(value : float<day>) = month.create(float value / 30.417)
        /// Converts the supplied Days value to Years
        static member toYears(value : float<day>) = year.create(float value / 365.0)
        /// Converts the supplied Days value to Decades
        static member toDecades(value : float<day>) = decade.create(float value / 3650.0)
        /// Converts the supplied Days value to Centuries
        static member toCenturies(value : float<day>) = century.create(float value / 36500.0)
    and /// Decades (decade) units
        [<Measure>] decade =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<decade> value
        /// Converts the supplied Decades value to Seconds
        static member toSeconds(value : float<decade>) = second.create(float value * 3.154e+8)
        /// Converts the supplied Decades value to Minutes
        static member toMinutes(value : float<decade>) = minute.create(float value * 5.256e+6)
        /// Converts the supplied Decades value to Hours
        static member toHours(value : float<decade>) = hour.create(float value * 87600.0)
        /// Converts the supplied Decades value to Days
        static member toDays(value : float<decade>) = day.create(float value * 3650.0)
        /// Converts the supplied Decades value to Weeks
        static member toWeeks(value : float<decade>) = week.create(float value * 521.0)
        /// Converts the supplied Decades value to Months
        static member toMonths(value : float<decade>) = month.create(float value * 120.0)
        /// Converts the supplied Decades value to Years
        static member toYears(value : float<decade>) = year.create(float value * 10.0)
        /// Converts the supplied Decades value to Centuries
        static member toCenturies(value : float<decade>) = century.create(float value / 10.0)
    and /// Hours (hour) units
        [<Measure>] hour =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<hour> value
        /// Converts the supplied Hours value to Seconds
        static member toSeconds(value : float<hour>) = second.create(float value * 3600.0)
        /// Converts the supplied Hours value to Minutes
        static member toMinutes(value : float<hour>) = minute.create(float value * 60.0)
        /// Converts the supplied Hours value to Days
        static member toDays(value : float<hour>) = day.create(float value / 24.0)
        /// Converts the supplied Hours value to Weeks
        static member toWeeks(value : float<hour>) = week.create(float value / 168.0)
        /// Converts the supplied Hours value to Months
        static member toMonths(value : float<hour>) = month.create(float value / 730.0)
        /// Converts the supplied Hours value to Years
        static member toYears(value : float<hour>) = year.create(float value / 8760.0)
        /// Converts the supplied Hours value to Decades
        static member toDecades(value : float<hour>) = decade.create(float value / 87600.0)
        /// Converts the supplied Hours value to Centuries
        static member toCenturies(value : float<hour>) = century.create(float value / 876000.0)
    and /// Minutes (minute) units
        [<Measure>] minute =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<minute> value
        /// Converts the supplied Minutes value to Seconds
        static member toSeconds(value : float<minute>) = second.create(float value * 60.0)
        /// Converts the supplied Minutes value to Hours
        static member toHours(value : float<minute>) = hour.create(float value / 60.0)
        /// Converts the supplied Minutes value to Days
        static member toDays(value : float<minute>) = day.create(float value / 1440.0)
        /// Converts the supplied Minutes value to Weeks
        static member toWeeks(value : float<minute>) = week.create(float value / 10080.0)
        /// Converts the supplied Minutes value to Months
        static member toMonths(value : float<minute>) = month.create(float value / 43800.0)
        /// Converts the supplied Minutes value to Years
        static member toYears(value : float<minute>) = year.create(float value / 525600.0)
        /// Converts the supplied Minutes value to Decades
        static member toDecades(value : float<minute>) = decade.create(float value / 5.256e+6)
        /// Converts the supplied Minutes value to Centuries
        static member toCenturies(value : float<minute>) = century.create(float value / 5.256e+7)
    and /// Months (month) units
        [<Measure>] month =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<month> value
        /// Converts the supplied Months value to Seconds
        static member toSeconds(value : float<month>) = second.create(float value * 2.628e+6)
        /// Converts the supplied Months value to Minutes
        static member toMinutes(value : float<month>) = minute.create(float value * 43800.0)
        /// Converts the supplied Months value to Hours
        static member toHours(value : float<month>) = hour.create(float value * 730.0)
        /// Converts the supplied Months value to Days
        static member toDays(value : float<month>) = day.create(float value * 30.417)
        /// Converts the supplied Months value to Weeks
        static member toWeeks(value : float<month>) = week.create(float value * 4.345)
        /// Converts the supplied Months value to Years
        static member toYears(value : float<month>) = year.create(float value / 12.0)
        /// Converts the supplied Months value to Decades
        static member toDecades(value : float<month>) = decade.create(float value / 120.0)
        /// Converts the supplied Months value to Centuries
        static member toCenturies(value : float<month>) = century.create(float value / 1200.0)
    and /// Seconds (second) units
        [<Measure>] second =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<second> value
        /// Converts the supplied Seconds value to Minutes
        static member toMinutes(value : float<second>) = minute.create(float value / 60.)
        /// Converts the supplied Seconds value to Hours
        static member toHours(value : float<second>) = hour.create(float value / 3600.)
        /// Converts the supplied Seconds value to Days
        static member toDays(value : float<second>) = day.create(float value / 86400.0)
        /// Converts the supplied Seconds value to Weeks
        static member toWeeks(value : float<second>) = week.create(float value / 604800.0)
        /// Converts the supplied Seconds value to Months
        static member toMonths(value : float<second>) = month.create(float value / 2.628e+6)
        /// Converts the supplied Seconds value to Years
        static member toYears(value : float<second>) = year.create(float value / 3.1536e+7)
        /// Converts the supplied Seconds value to Decades
        static member toDecades(value : float<second>) = decade.create(float value / 3.154e+8)
        /// Converts the supplied Seconds value to Centuries
        static member toCenturies(value : float<second>) = century.create(float value / 3.154e+9)
    and /// Weeks (week) units
        [<Measure>] week =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<week> value
        /// Converts the supplied Weeks value to Seconds
        static member toSeconds(value : float<week>) = second.create(float value * 604800.0)
        /// Converts the supplied Weeks value to Minutes
        static member toMinutes(value : float<week>) = minute.create(float value * 10080.0)
        /// Converts the supplied Weeks value to Hours
        static member toHours(value : float<week>) = hour.create(float value * 168.0)
        /// Converts the supplied Weeks value to Days
        static member toDays(value : float<week>) = day.create(float value * 7.0)
        /// Converts the supplied Weeks value to Months
        static member toMonths(value : float<week>) = month.create(float value / 4.345)
        /// Converts the supplied Weeks value to Years
        static member toYears(value : float<week>) = year.create(float value / 52.143)
        /// Converts the supplied Weeks value to Decades
        static member toDecades(value : float<week>) = decade.create(float value / 521.0)
        /// Converts the supplied Weeks value to Centuries
        static member toCenturies(value : float<week>) = century.create(float value / 5214.0)
    and /// Years (year) units
        [<Measure>] year =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<year> value
        /// Converts the supplied Years value to Seconds
        static member toSeconds(value : float<year>) = second.create(float value * 3.1536e+7)
        /// Converts the supplied Years value to Minutes
        static member toMinutes(value : float<year>) = minute.create(float value * 525600.0)
        /// Converts the supplied Years value to Hours
        static member toHours(value : float<year>) = hour.create(float value * 8760.0)
        /// Converts the supplied Years value to Days
        static member toDays(value : float<year>) = day.create(float value * 365.0)
        /// Converts the supplied Years value to Weeks
        static member toWeeks(value : float<year>) = week.create(float value * 52.143)
        /// Converts the supplied Years value to Months
        static member toMonths(value : float<year>) = month.create(float value * 12.0)
        /// Converts the supplied Years value to Decades
        static member toDecades(value : float<year>) = decade.create(float value / 10.0)
        /// Converts the supplied Years value to Centuries
        static member toCenturies(value : float<year>) = century.create(float value / 100.0)