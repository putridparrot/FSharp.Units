// <auto-generated>
// This code was generated by the UnitCodeGenerator tool
//
// Changes to this file will be lost if the code is regenerated
// </auto-generated>

namespace FSharp.Units

open Microsoft.FSharp.Core

module Time =

    /// Centuries (century) units
    [<Measure>]
    type century =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<century> value
        /// Converts the supplied Centuries value to Nanoseconds
        static member toNanoseconds(value : float<century>) = nanosecond.create(float value * 3.154e+18)
        /// Converts the supplied Centuries value to Microseconds
        static member toMicroseconds(value : float<century>) = microsecond.create(float value * 3.154e+15)
        /// Converts the supplied Centuries value to Milliseconds
        static member toMilliseconds(value : float<century>) = millisecond.create(float value * 3.154e+12)
        /// Converts the supplied Centuries value to Seconds
        static member toSeconds(value : float<century>) = second.create(float value * 3.154e+9)
        /// Converts the supplied Centuries value to Minutes
        static member toMinutes(value : float<century>) = minute.create(float value * 5.256e+7)
        /// Converts the supplied Centuries value to Hours
        static member toHours(value : float<century>) = hour.create(float value * 876000.0)
        /// Converts the supplied Centuries value to Days
        static member toDays(value : float<century>) = day.create(float value * 36500.0)
        /// Converts the supplied Centuries value to Weeks
        static member toWeeks(value : float<century>) = week.create(float value * 5214.29)
        /// Converts the supplied Centuries value to Months
        static member toMonths(value : float<century>) = month.create(float value * 1200.0)
        /// Converts the supplied Centuries value to Years
        static member toYears(value : float<century>) = year.create(float value * 100.0)
        /// Converts the supplied Centuries value to Decades
        static member toDecades(value : float<century>) = decade.create(float value * 10.0)
    and /// Days (day) units
        [<Measure>] day =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<day> value
        /// Converts the supplied Days value to Nanoseconds
        static member toNanoseconds(value : float<day>) = nanosecond.create(float value * 8.64e+13)
        /// Converts the supplied Days value to Microseconds
        static member toMicroseconds(value : float<day>) = microsecond.create(float value * 8.64e+10)
        /// Converts the supplied Days value to Milliseconds
        static member toMilliseconds(value : float<day>) = millisecond.create(float value * 8.64e+7)
        /// Converts the supplied Days value to Seconds
        static member toSeconds(value : float<day>) = second.create(float value * 86400.0)
        /// Converts the supplied Days value to Minutes
        static member toMinutes(value : float<day>) = minute.create(float value * 1440.0)
        /// Converts the supplied Days value to Hours
        static member toHours(value : float<day>) = hour.create(float value * 24.0)
        /// Converts the supplied Days value to Weeks
        static member toWeeks(value : float<day>) = week.create(float value / 7.0)
        /// Converts the supplied Days value to Months
        static member toMonths(value : float<day>) = month.create(float value / 30.4167)
        /// Converts the supplied Days value to Years
        static member toYears(value : float<day>) = year.create(float value / 365.0)
        /// Converts the supplied Days value to Decades
        static member toDecades(value : float<day>) = decade.create(float value / 3650.0)
        /// Converts the supplied Days value to Centuries
        static member toCenturies(value : float<day>) = century.create(float value / 36500.0)
    and /// Decades (decade) units
        [<Measure>] decade =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<decade> value
        /// Converts the supplied Decades value to Nanoseconds
        static member toNanoseconds(value : float<decade>) = nanosecond.create(float value * 3.154e+17)
        /// Converts the supplied Decades value to Microseconds
        static member toMicroseconds(value : float<decade>) = microsecond.create(float value * 3.154e+14)
        /// Converts the supplied Decades value to Milliseconds
        static member toMilliseconds(value : float<decade>) = millisecond.create(float value * 3.154e+11)
        /// Converts the supplied Decades value to Seconds
        static member toSeconds(value : float<decade>) = second.create(float value * 3.154e+8)
        /// Converts the supplied Decades value to Minutes
        static member toMinutes(value : float<decade>) = minute.create(float value * 5.256e+6)
        /// Converts the supplied Decades value to Hours
        static member toHours(value : float<decade>) = hour.create(float value * 87600.0)
        /// Converts the supplied Decades value to Days
        static member toDays(value : float<decade>) = day.create(float value * 3650.0)
        /// Converts the supplied Decades value to Weeks
        static member toWeeks(value : float<decade>) = week.create(float value * 521.429)
        /// Converts the supplied Decades value to Months
        static member toMonths(value : float<decade>) = month.create(float value * 120.0)
        /// Converts the supplied Decades value to Years
        static member toYears(value : float<decade>) = year.create(float value * 10.0)
        /// Converts the supplied Decades value to Centuries
        static member toCenturies(value : float<decade>) = century.create(float value / 10.0)
    and /// Hours (hour) units
        [<Measure>] hour =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<hour> value
        /// Converts the supplied Hours value to Nanoseconds
        static member toNanoseconds(value : float<hour>) = nanosecond.create(float value * 3.6e+12)
        /// Converts the supplied Hours value to Microseconds
        static member toMicroseconds(value : float<hour>) = microsecond.create(float value * 3.6e+9)
        /// Converts the supplied Hours value to Milliseconds
        static member toMilliseconds(value : float<hour>) = millisecond.create(float value * 3.6e+6)
        /// Converts the supplied Hours value to Seconds
        static member toSeconds(value : float<hour>) = second.create(float value * 3600.0)
        /// Converts the supplied Hours value to Minutes
        static member toMinutes(value : float<hour>) = minute.create(float value * 60.0)
        /// Converts the supplied Hours value to Days
        static member toDays(value : float<hour>) = day.create(float value / 24.0)
        /// Converts the supplied Hours value to Weeks
        static member toWeeks(value : float<hour>) = week.create(float value / 168.0)
        /// Converts the supplied Hours value to Months
        static member toMonths(value : float<hour>) = month.create(float value / 730.001)
        /// Converts the supplied Hours value to Years
        static member toYears(value : float<hour>) = year.create(float value / 8760.0)
        /// Converts the supplied Hours value to Decades
        static member toDecades(value : float<hour>) = decade.create(float value / 87600.0)
        /// Converts the supplied Hours value to Centuries
        static member toCenturies(value : float<hour>) = century.create(float value / 876000.0)
    and /// Microseconds (microsecond) units
        [<Measure>] microsecond =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<microsecond> value
        /// Converts the supplied Microseconds value to Nanoseconds
        static member toNanoseconds(value : float<microsecond>) = nanosecond.create(float value * 1000.0)
        /// Converts the supplied Microseconds value to Milliseconds
        static member toMilliseconds(value : float<microsecond>) = millisecond.create(float value / 1000.0)
        /// Converts the supplied Microseconds value to Seconds
        static member toSeconds(value : float<microsecond>) = second.create(float value / 1e+6)
        /// Converts the supplied Microseconds value to Minutes
        static member toMinutes(value : float<microsecond>) = minute.create(float value / 6e+7)
        /// Converts the supplied Microseconds value to Hours
        static member toHours(value : float<microsecond>) = hour.create(float value / 3.6e+9)
        /// Converts the supplied Microseconds value to Days
        static member toDays(value : float<microsecond>) = day.create(float value / 8.64e+10)
        /// Converts the supplied Microseconds value to Weeks
        static member toWeeks(value : float<microsecond>) = week.create(float value / 6.048e+11)
        /// Converts the supplied Microseconds value to Months
        static member toMonths(value : float<microsecond>) = month.create(float value / 2629746000000.0)
        /// Converts the supplied Microseconds value to Years
        static member toYears(value : float<microsecond>) = year.create(float value / 3.154e+13)
        /// Converts the supplied Microseconds value to Decades
        static member toDecades(value : float<microsecond>) = decade.create(float value / 3.154e+14)
        /// Converts the supplied Microseconds value to Centuries
        static member toCenturies(value : float<microsecond>) = century.create(float value / 3.154e+15)
    and /// Milliseconds (millisecond) units
        [<Measure>] millisecond =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<millisecond> value
        /// Converts the supplied Milliseconds value to Nanoseconds
        static member toNanoseconds(value : float<millisecond>) = nanosecond.create(float value * 1e+6)
        /// Converts the supplied Milliseconds value to Microseconds
        static member toMicroseconds(value : float<millisecond>) = microsecond.create(float value * 1000.0)
        /// Converts the supplied Milliseconds value to Seconds
        static member toSeconds(value : float<millisecond>) = second.create(float value / 1000.0)
        /// Converts the supplied Milliseconds value to Minutes
        static member toMinutes(value : float<millisecond>) = minute.create(float value / 60000.0)
        /// Converts the supplied Milliseconds value to Hours
        static member toHours(value : float<millisecond>) = hour.create(float value / 3.6e+6)
        /// Converts the supplied Milliseconds value to Days
        static member toDays(value : float<millisecond>) = day.create(float value / 8.64e+7)
        /// Converts the supplied Milliseconds value to Weeks
        static member toWeeks(value : float<millisecond>) = week.create(float value / 6.048e+8)
        /// Converts the supplied Milliseconds value to Months
        static member toMonths(value : float<millisecond>) = month.create(float value / 2629746000.0)
        /// Converts the supplied Milliseconds value to Years
        static member toYears(value : float<millisecond>) = year.create(float value / 31556952000.0)
        /// Converts the supplied Milliseconds value to Decades
        static member toDecades(value : float<millisecond>) = decade.create(float value / 3.154e+11)
        /// Converts the supplied Milliseconds value to Centuries
        static member toCenturies(value : float<millisecond>) = century.create(float value / 3.154e+12)
    and /// Minutes (minute) units
        [<Measure>] minute =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<minute> value
        /// Converts the supplied Minutes value to Nanoseconds
        static member toNanoseconds(value : float<minute>) = nanosecond.create(float value * 6e+10)
        /// Converts the supplied Minutes value to Microseconds
        static member toMicroseconds(value : float<minute>) = microsecond.create(float value * 6e+7)
        /// Converts the supplied Minutes value to Milliseconds
        static member toMilliseconds(value : float<minute>) = millisecond.create(float value * 60000.0)
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
        /// Converts the supplied Months value to Nanoseconds
        static member toNanoseconds(value : float<month>) = nanosecond.create(float value * 2629746000000000.0)
        /// Converts the supplied Months value to Microseconds
        static member toMicroseconds(value : float<month>) = microsecond.create(float value * 2629746000000.0)
        /// Converts the supplied Months value to Milliseconds
        static member toMilliseconds(value : float<month>) = millisecond.create(float value * 2629746000.0)
        /// Converts the supplied Months value to Seconds
        static member toSeconds(value : float<month>) = second.create(float value * 2.628e+6)
        /// Converts the supplied Months value to Minutes
        static member toMinutes(value : float<month>) = minute.create(float value * 43800.0)
        /// Converts the supplied Months value to Hours
        static member toHours(value : float<month>) = hour.create(float value * 730.001)
        /// Converts the supplied Months value to Days
        static member toDays(value : float<month>) = day.create(float value * 30.4167)
        /// Converts the supplied Months value to Weeks
        static member toWeeks(value : float<month>) = week.create(float value * 4.34524)
        /// Converts the supplied Months value to Years
        static member toYears(value : float<month>) = year.create(float value / 12.0)
        /// Converts the supplied Months value to Decades
        static member toDecades(value : float<month>) = decade.create(float value / 120.0)
        /// Converts the supplied Months value to Centuries
        static member toCenturies(value : float<month>) = century.create(float value / 1200.0)
    and /// Nanoseconds (nanosecond) units
        [<Measure>] nanosecond =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<nanosecond> value
        /// Converts the supplied Nanoseconds value to Microseconds
        static member toMicroseconds(value : float<nanosecond>) = microsecond.create(float value / 1000.0)
        /// Converts the supplied Nanoseconds value to Milliseconds
        static member toMilliseconds(value : float<nanosecond>) = millisecond.create(float value / 1e+6)
        /// Converts the supplied Nanoseconds value to Seconds
        static member toSeconds(value : float<nanosecond>) = second.create(float value / 1e+9)
        /// Converts the supplied Nanoseconds value to Minutes
        static member toMinutes(value : float<nanosecond>) = minute.create(float value / 6e+10)
        /// Converts the supplied Nanoseconds value to Hours
        static member toHours(value : float<nanosecond>) = hour.create(float value / 3.6e+12)
        /// Converts the supplied Nanoseconds value to Days
        static member toDays(value : float<nanosecond>) = day.create(float value / 8.64e+13)
        /// Converts the supplied Nanoseconds value to Weeks
        static member toWeeks(value : float<nanosecond>) = week.create(float value / 6.048e+14)
        /// Converts the supplied Nanoseconds value to Months
        static member toMonths(value : float<nanosecond>) = month.create(float value / 2629746000000000.0)
        /// Converts the supplied Nanoseconds value to Years
        static member toYears(value : float<nanosecond>) = year.create(float value / 3.154e+16)
        /// Converts the supplied Nanoseconds value to Decades
        static member toDecades(value : float<nanosecond>) = decade.create(float value / 3.154e+17)
        /// Converts the supplied Nanoseconds value to Centuries
        static member toCenturies(value : float<nanosecond>) = century.create(float value / 3.154e+18)
    and /// Seconds (second) units
        [<Measure>] second =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<second> value
        /// Converts the supplied Seconds value to Nanoseconds
        static member toNanoseconds(value : float<second>) = nanosecond.create(float value * 1e+9)
        /// Converts the supplied Seconds value to Microseconds
        static member toMicroseconds(value : float<second>) = microsecond.create(float value * 1e+6)
        /// Converts the supplied Seconds value to Milliseconds
        static member toMilliseconds(value : float<second>) = millisecond.create(float value * 1000.0)
        /// Converts the supplied Seconds value to Minutes
        static member toMinutes(value : float<second>) = minute.create(float value / 60.0)
        /// Converts the supplied Seconds value to Hours
        static member toHours(value : float<second>) = hour.create(float value / 3600.0)
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
        /// Converts the supplied Weeks value to Nanoseconds
        static member toNanoseconds(value : float<week>) = nanosecond.create(float value * 6.048e+14)
        /// Converts the supplied Weeks value to Microseconds
        static member toMicroseconds(value : float<week>) = microsecond.create(float value * 6.048e+11)
        /// Converts the supplied Weeks value to Milliseconds
        static member toMilliseconds(value : float<week>) = millisecond.create(float value * 6.048e+8)
        /// Converts the supplied Weeks value to Seconds
        static member toSeconds(value : float<week>) = second.create(float value * 604800.0)
        /// Converts the supplied Weeks value to Minutes
        static member toMinutes(value : float<week>) = minute.create(float value * 10080.0)
        /// Converts the supplied Weeks value to Hours
        static member toHours(value : float<week>) = hour.create(float value * 168.0)
        /// Converts the supplied Weeks value to Days
        static member toDays(value : float<week>) = day.create(float value * 7.0)
        /// Converts the supplied Weeks value to Months
        static member toMonths(value : float<week>) = month.create(float value / 4.34524)
        /// Converts the supplied Weeks value to Years
        static member toYears(value : float<week>) = year.create(float value / 52.143)
        /// Converts the supplied Weeks value to Decades
        static member toDecades(value : float<week>) = decade.create(float value / 521.429)
        /// Converts the supplied Weeks value to Centuries
        static member toCenturies(value : float<week>) = century.create(float value / 5214.29)
    and /// Years (year) units
        [<Measure>] year =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<year> value
        /// Converts the supplied Years value to Nanoseconds
        static member toNanoseconds(value : float<year>) = nanosecond.create(float value * 3.154e+16)
        /// Converts the supplied Years value to Microseconds
        static member toMicroseconds(value : float<year>) = microsecond.create(float value * 3.154e+13)
        /// Converts the supplied Years value to Milliseconds
        static member toMilliseconds(value : float<year>) = millisecond.create(float value * 31556952000.0)
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
