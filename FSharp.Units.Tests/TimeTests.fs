namespace FSharp.Units.Tests

module TimeTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Time
    open Helpers


    [<Property>]
    let ``From Centuries to Seconds and back`` () =
        let property value =
            let convertTo = century.toSeconds (century.create value)
            let convertBack = second.toCenturies convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Centuries to Minutes and back`` () =
        let property value =
            let convertTo = century.toMinutes (century.create value)
            let convertBack = minute.toCenturies convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Centuries to Hours and back`` () =
        let property value =
            let convertTo = century.toHours (century.create value)
            let convertBack = hour.toCenturies convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Centuries to Days and back`` () =
        let property value =
            let convertTo = century.toDays (century.create value)
            let convertBack = day.toCenturies convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Centuries to Weeks and back`` () =
        let property value =
            let convertTo = century.toWeeks (century.create value)
            let convertBack = week.toCenturies convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Centuries to Months and back`` () =
        let property value =
            let convertTo = century.toMonths (century.create value)
            let convertBack = month.toCenturies convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Centuries to Years and back`` () =
        let property value =
            let convertTo = century.toYears (century.create value)
            let convertBack = year.toCenturies convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Centuries to Decades and back`` () =
        let property value =
            let convertTo = century.toDecades (century.create value)
            let convertBack = decade.toCenturies convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Days to Seconds and back`` () =
        let property value =
            let convertTo = day.toSeconds (day.create value)
            let convertBack = second.toDays convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.4<day>, 120960.0)>]
    [<TestCase(0.06<day>, 5184.0)>]
    [<TestCase(0.2<day>, 17280.0)>]
    let ``Convert known Days to Seconds`` (input, expectation) = 
        day.toSeconds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Days to Minutes and back`` () =
        let property value =
            let convertTo = day.toMinutes (day.create value)
            let convertBack = minute.toDays convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(34.0<day>, 48960.0)>]
    [<TestCase(0.06<day>, 86.4)>]
    [<TestCase(8.1<day>, 11664.0)>]
    let ``Convert known Days to Minutes`` (input, expectation) = 
        day.toMinutes input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Days to Hours and back`` () =
        let property value =
            let convertTo = day.toHours (day.create value)
            let convertBack = hour.toDays convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8.1<day>, 194.4)>]
    [<TestCase(0.2<day>, 4.8)>]
    [<TestCase(121.0<day>, 2904.0)>]
    let ``Convert known Days to Hours`` (input, expectation) = 
        day.toHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Days to Weeks and back`` () =
        let property value =
            let convertTo = day.toWeeks (day.create value)
            let convertBack = week.toDays convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(121.0<day>, 17.2857)>]
    [<TestCase(7.2<day>, 1.02857)>]
    [<TestCase(0.9<day>, 0.128571)>]
    let ``Convert known Days to Weeks`` (input, expectation) = 
        day.toWeeks input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Days to Months and back`` () =
        let property value =
            let convertTo = day.toMonths (day.create value)
            let convertBack = month.toDays convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.9<day>, 0.029589)>]
    [<TestCase(108.0<day>, 3.55068)>]
    [<TestCase(55.0<day>, 1.80822)>]
    let ``Convert known Days to Months`` (input, expectation) = 
        day.toMonths input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Days to Years and back`` () =
        let property value =
            let convertTo = day.toYears (day.create value)
            let convertBack = year.toDays convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(55.0<day>, 0.150685)>]
    [<TestCase(123.0<day>, 0.336986)>]
    [<TestCase(900.0<day>, 2.46575)>]
    let ``Convert known Days to Years`` (input, expectation) = 
        day.toYears input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Days to Decades and back`` () =
        let property value =
            let convertTo = day.toDecades (day.create value)
            let convertBack = decade.toDays convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Days to Centuries and back`` () =
        let property value =
            let convertTo = day.toCenturies (day.create value)
            let convertBack = century.toDays convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Decades to Seconds and back`` () =
        let property value =
            let convertTo = decade.toSeconds (decade.create value)
            let convertBack = second.toDecades convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Decades to Minutes and back`` () =
        let property value =
            let convertTo = decade.toMinutes (decade.create value)
            let convertBack = minute.toDecades convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Decades to Hours and back`` () =
        let property value =
            let convertTo = decade.toHours (decade.create value)
            let convertBack = hour.toDecades convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Decades to Days and back`` () =
        let property value =
            let convertTo = decade.toDays (decade.create value)
            let convertBack = day.toDecades convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Decades to Weeks and back`` () =
        let property value =
            let convertTo = decade.toWeeks (decade.create value)
            let convertBack = week.toDecades convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Decades to Months and back`` () =
        let property value =
            let convertTo = decade.toMonths (decade.create value)
            let convertBack = month.toDecades convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Decades to Years and back`` () =
        let property value =
            let convertTo = decade.toYears (decade.create value)
            let convertBack = year.toDecades convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Decades to Centuries and back`` () =
        let property value =
            let convertTo = decade.toCenturies (decade.create value)
            let convertBack = century.toDecades convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Hours to Seconds and back`` () =
        let property value =
            let convertTo = hour.toSeconds (hour.create value)
            let convertBack = second.toHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<hour>, 43200.0)>]
    [<TestCase(3.2<hour>, 11520.0)>]
    [<TestCase(0.3<hour>, 1080.0)>]
    let ``Convert known Hours to Seconds`` (input, expectation) = 
        hour.toSeconds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hours to Minutes and back`` () =
        let property value =
            let convertTo = hour.toMinutes (hour.create value)
            let convertBack = minute.toHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.3<hour>, 18.0)>]
    [<TestCase(700.0<hour>, 42000.0)>]
    [<TestCase(4.8<hour>, 288.0)>]
    let ``Convert known Hours to Minutes`` (input, expectation) = 
        hour.toMinutes input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hours to Days and back`` () =
        let property value =
            let convertTo = hour.toDays (hour.create value)
            let convertBack = day.toHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.8<hour>, 0.2)>]
    [<TestCase(190.0<hour>, 7.91667)>]
    [<TestCase(8.5<hour>, 0.354167)>]
    let ``Convert known Hours to Days`` (input, expectation) = 
        hour.toDays input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hours to Weeks and back`` () =
        let property value =
            let convertTo = hour.toWeeks (hour.create value)
            let convertBack = week.toHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(800.0<hour>, 4.7619)>]
    [<TestCase(90.0<hour>, 0.535714)>]
    [<TestCase(102.0<hour>, 0.607143)>]
    let ``Convert known Hours to Weeks`` (input, expectation) = 
        hour.toWeeks input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hours to Months and back`` () =
        let property value =
            let convertTo = hour.toMonths (hour.create value)
            let convertBack = month.toHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(102.0<hour>, 0.139726)>]
    [<TestCase(9876.0<hour>, 13.52875)>]
    [<TestCase(100.8<hour>, 0.13808204)>]
    let ``Convert known Hours to Months`` (input, expectation) = 
        hour.toMonths input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hours to Years and back`` () =
        let property value =
            let convertTo = hour.toYears (hour.create value)
            let convertBack = year.toHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9000.0<hour>, 1.027397)>]
    [<TestCase(1003.0<hour>, 0.1144977)>]
    [<TestCase(809.0<hour>, 0.0923516)>]
    let ``Convert known Hours to Years`` (input, expectation) = 
        hour.toYears input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hours to Decades and back`` () =
        let property value =
            let convertTo = hour.toDecades (hour.create value)
            let convertBack = decade.toHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Hours to Centuries and back`` () =
        let property value =
            let convertTo = hour.toCenturies (hour.create value)
            let convertBack = century.toHours convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Minutes to Seconds and back`` () =
        let property value =
            let convertTo = minute.toSeconds (minute.create value)
            let convertBack = second.toMinutes convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(90.0<minute>, 5400)>]
    [<TestCase(0.9<minute>, 54.0)>]
    [<TestCase(123.0<minute>, 7380.0)>]
    let ``Convert known Minutes to Seconds`` (input, expectation) = 
        minute.toSeconds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Minutes to Hours and back`` () =
        let property value =
            let convertTo = minute.toHours (minute.create value)
            let convertBack = hour.toMinutes convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123.0<minute>, 2.05)>]
    [<TestCase(77.0<minute>, 1.28333)>]
    [<TestCase(0.8<minute>, 0.0133333)>]
    let ``Convert known Minutes to Hours`` (input, expectation) = 
        minute.toHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Minutes to Days and back`` () =
        let property value =
            let convertTo = minute.toDays (minute.create value)
            let convertBack = day.toMinutes convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(800.0<minute>, 0.555556)>]
    [<TestCase(190.0<minute>, 0.131944)>]
    [<TestCase(55.0<minute>, 0.0381944)>]
    let ``Convert known Minutes to Days`` (input, expectation) = 
        minute.toDays input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Minutes to Weeks and back`` () =
        let property value =
            let convertTo = minute.toWeeks (minute.create value)
            let convertBack = week.toMinutes convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1900.0<minute>, 0.1884921)>]
    [<TestCase(800.0<minute>, 0.0793651)>]
    [<TestCase(12345.0<minute>, 1.2247024)>]
    let ``Convert known Minutes to Weeks`` (input, expectation) = 
        minute.toWeeks input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Minutes to Months and back`` () =
        let property value =
            let convertTo = minute.toMonths (minute.create value)
            let convertBack = month.toMinutes convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1234.0<minute>, 0.02817349)>]
    [<TestCase(90000.0<minute>, 2.0547923)>]
    [<TestCase(7100.0<minute>, 0.1621003)>]
    let ``Convert known Minutes to Months`` (input, expectation) = 
        minute.toMonths input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Minutes to Years and back`` () =
        let property value =
            let convertTo = minute.toYears (minute.create value)
            let convertBack = year.toMinutes convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900800.0<minute>, 1.71385084)>]
    [<TestCase(12345.0<minute>, 0.023487443)>]
    [<TestCase(610910.0<minute>, 1.16230974)>]
    let ``Convert known Minutes to Years`` (input, expectation) = 
        minute.toYears input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Minutes to Decades and back`` () =
        let property value =
            let convertTo = minute.toDecades (minute.create value)
            let convertBack = decade.toMinutes convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Minutes to Centuries and back`` () =
        let property value =
            let convertTo = minute.toCenturies (minute.create value)
            let convertBack = century.toMinutes convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Months to Seconds and back`` () =
        let property value =
            let convertTo = month.toSeconds (month.create value)
            let convertBack = second.toMonths convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.03<month>, 78840.00)>]
    [<TestCase(0.1<month>, 262800.0)>]
    [<TestCase(0.008<month>, 21024.0)>]
    let ``Convert known Months to Seconds`` (input, expectation) = 
        month.toSeconds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Months to Minutes and back`` () =
        let property value =
            let convertTo = month.toMinutes (month.create value)
            let convertBack = minute.toMonths convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.7<month>, 30660.0)>]
    [<TestCase(1.4<month>, 61319.99)>]
    [<TestCase(5.0<month>, 219000.0)>]
    let ``Convert known Months to Minutes`` (input, expectation) = 
        month.toMinutes input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Months to Hours and back`` () =
        let property value =
            let convertTo = month.toHours (month.create value)
            let convertBack = hour.toMonths convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.0<month>, 2920.0)>]
    [<TestCase(0.3<month>, 219.0)>]
    [<TestCase(4.5<month>, 3285.0)>]
    let ``Convert known Months to Hours`` (input, expectation) = 
        month.toHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Months to Days and back`` () =
        let property value =
            let convertTo = month.toDays (month.create value)
            let convertBack = day.toMonths convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.5<month>, 136.875)>]
    [<TestCase(90.0<month>, 2737.53)>]
    [<TestCase(0.4<month>, 12.1667)>]
    let ``Convert known Months to Days`` (input, expectation) = 
        month.toDays input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Months to Weeks and back`` () =
        let property value =
            let convertTo = month.toWeeks (month.create value)
            let convertBack = week.toMonths convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.5<month>, 2.17262)>]
    [<TestCase(88.0<month>, 382.359)>]
    [<TestCase(12.6<month>, 54.75006)>]
    let ``Convert known Months to Weeks`` (input, expectation) = 
        month.toWeeks input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Months to Years and back`` () =
        let property value =
            let convertTo = month.toYears (month.create value)
            let convertBack = year.toMonths convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.6<month>, 1.050001)>]
    [<TestCase(109.0<month>, 9.08334)>]
    [<TestCase(23.0<month>, 1.91667)>]
    let ``Convert known Months to Years`` (input, expectation) = 
        month.toYears input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Months to Decades and back`` () =
        let property value =
            let convertTo = month.toDecades (month.create value)
            let convertBack = decade.toMonths convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Months to Centuries and back`` () =
        let property value =
            let convertTo = month.toCenturies (month.create value)
            let convertBack = century.toMonths convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Seconds to Minutes and back`` () =
        let property value =
            let convertTo = second.toMinutes (second.create value)
            let convertBack = minute.toSeconds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100.0<second>, 1.66667)>]
    [<TestCase(9000.0<second>, 150.0)>]
    [<TestCase(2300.0<second>, 38.33333)>]
    let ``Convert known Seconds to Minutes`` (input, expectation) = 
        second.toMinutes input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Seconds to Hours and back`` () =
        let property value =
            let convertTo = second.toHours (second.create value)
            let convertBack = hour.toSeconds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2300.0<second>, 0.6388889)>]
    [<TestCase(9999.0<second>, 2.7775)>]
    [<TestCase(36000.0<second>, 10.0)>]
    let ``Convert known Seconds to Hours`` (input, expectation) = 
        second.toHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Seconds to Days and back`` () =
        let property value =
            let convertTo = second.toDays (second.create value)
            let convertBack = day.toSeconds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(36000.0<second>, 0.41666667)>]
    [<TestCase(90000.0<second>, 1.0416667)>]
    [<TestCase(190000.0<second>, 2.19907407)>]
    let ``Convert known Seconds to Days`` (input, expectation) = 
        second.toDays input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Seconds to Weeks and back`` () =
        let property value =
            let convertTo = second.toWeeks (second.create value)
            let convertBack = week.toSeconds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190000.0<second>, 0.314153439)>]
    [<TestCase(1234567.0<second>, 2.041281415)>]
    [<TestCase(100200.0<second>, 0.165674603)>]
    let ``Convert known Seconds to Weeks`` (input, expectation) = 
        second.toWeeks input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Seconds to Months and back`` () =
        let property value =
            let convertTo = second.toMonths (second.create value)
            let convertBack = month.toSeconds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1000000.0<second>, 0.380517087)>]
    [<TestCase(9876543.0<second>, 3.75819337)>]
    [<TestCase(200900.0<second>, 0.0764458827)>]
    let ``Convert known Seconds to Months`` (input, expectation) = 
        second.toMonths input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Seconds to Years and back`` () =
        let property value =
            let convertTo = second.toYears (second.create value)
            let convertBack = year.toSeconds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(123456789.0<second>, 3.91478909817)>]
    [<TestCase(100900.0<second>, 0.00319951801)>]
    [<TestCase(987654.0<second>, 0.0313183029)>]
    let ``Convert known Seconds to Years`` (input, expectation) = 
        second.toYears input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Seconds to Decades and back`` () =
        let property value =
            let convertTo = second.toDecades (second.create value)
            let convertBack = decade.toSeconds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Seconds to Centuries and back`` () =
        let property value =
            let convertTo = second.toCenturies (second.create value)
            let convertBack = century.toSeconds convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Weeks to Seconds and back`` () =
        let property value =
            let convertTo = week.toSeconds (week.create value)
            let convertBack = second.toWeeks convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.1<week>, 60480.0)>]
    [<TestCase(0.08<week>, 48384.0)>]
    [<TestCase(3.0<week>, 1814400.0)>]
    let ``Convert known Weeks to Seconds`` (input, expectation) = 
        week.toSeconds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Weeks to Minutes and back`` () =
        let property value =
            let convertTo = week.toMinutes (week.create value)
            let convertBack = minute.toWeeks convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.0<week>, 20160.0)>]
    [<TestCase(0.4<week>, 4032.0)>]
    [<TestCase(0.02<week>, 201.6)>]
    let ``Convert known Weeks to Minutes`` (input, expectation) = 
        week.toMinutes input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Weeks to Hours and back`` () =
        let property value =
            let convertTo = week.toHours (week.create value)
            let convertBack = hour.toWeeks convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.02<week>, 3.36)>]
    [<TestCase(77.0<week>, 12936.0)>]
    [<TestCase(9.2<week>, 1545.6)>]
    let ``Convert known Weeks to Hours`` (input, expectation) = 
        week.toHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Weeks to Days and back`` () =
        let property value =
            let convertTo = week.toDays (week.create value)
            let convertBack = day.toWeeks convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9.2<week>, 64.4)>]
    [<TestCase(169.0<week>, 1183.0)>]
    [<TestCase(4.0<week>, 28.0)>]
    let ``Convert known Weeks to Days`` (input, expectation) = 
        week.toDays input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Weeks to Months and back`` () =
        let property value =
            let convertTo = week.toMonths (week.create value)
            let convertBack = month.toWeeks convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(4.0<week>, 0.920547)>]
    [<TestCase(900.0<week>, 207.134637)>]
    [<TestCase(3.8<week>, 0.87452)>]
    let ``Convert known Weeks to Months`` (input, expectation) = 
        week.toMonths input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Weeks to Years and back`` () =
        let property value =
            let convertTo = week.toYears (week.create value)
            let convertBack = year.toWeeks convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.0<week>, 0.0575342)>]
    [<TestCase(235.0<week>, 4.50685)>]
    [<TestCase(1090.0<week>, 20.90411)>]
    let ``Convert known Weeks to Years`` (input, expectation) = 
        week.toYears input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Weeks to Decades and back`` () =
        let property value =
            let convertTo = week.toDecades (week.create value)
            let convertBack = decade.toWeeks convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Weeks to Centuries and back`` () =
        let property value =
            let convertTo = week.toCenturies (week.create value)
            let convertBack = century.toWeeks convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Years to Seconds and back`` () =
        let property value =
            let convertTo = year.toSeconds (year.create value)
            let convertBack = second.toYears convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.06<year>, 1892160.0)>]
    [<TestCase(0.009<year>, 283824.0)>]
    [<TestCase(0.02<year>, 630720.0)>]
    let ``Convert known Years to Seconds`` (input, expectation) = 
        year.toSeconds input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Years to Minutes and back`` () =
        let property value =
            let convertTo = year.toMinutes (year.create value)
            let convertBack = minute.toYears convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.02<year>, 10512.0)>]
    [<TestCase(0.3<year>, 157680.0)>]
    [<TestCase(0.001<year>, 525.6)>]
    let ``Convert known Years to Minutes`` (input, expectation) = 
        year.toMinutes input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Years to Hours and back`` () =
        let property value =
            let convertTo = year.toHours (year.create value)
            let convertBack = hour.toYears convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.001<year>, 8.76)>]
    [<TestCase(0.3<year>, 2628.0)>]
    [<TestCase(2.0<year>, 17520.0)>]
    let ``Convert known Years to Hours`` (input, expectation) = 
        year.toHours input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Years to Days and back`` () =
        let property value =
            let convertTo = year.toDays (year.create value)
            let convertBack = day.toYears convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.0<year>, 730.0)>]
    [<TestCase(1009.0<year>, 368285.0)>]
    [<TestCase(7.0<year>, 2555.0)>]
    let ``Convert known Years to Days`` (input, expectation) = 
        year.toDays input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Years to Weeks and back`` () =
        let property value =
            let convertTo = year.toWeeks (year.create value)
            let convertBack = week.toYears convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(7.0<year>, 365.0)>]
    [<TestCase(1.3<year>, 67.7857)>]
    [<TestCase(88.0<year>, 4588.5839)>]
    let ``Convert known Years to Weeks`` (input, expectation) = 
        year.toWeeks input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Years to Months and back`` () =
        let property value =
            let convertTo = year.toMonths (year.create value)
            let convertBack = month.toYears convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.0<year>, 71.9999)>]
    [<TestCase(12.0<year>, 144.0)>]
    [<TestCase(0.3<year>, 3.6)>]
    let ``Convert known Years to Months`` (input, expectation) = 
        year.toMonths input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Years to Decades and back`` () =
        let property value =
            let convertTo = year.toDecades (year.create value)
            let convertBack = decade.toYears convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<Property>]
    let ``From Years to Centuries and back`` () =
        let property value =
            let convertTo = year.toCenturies (year.create value)
            let convertBack = century.toYears convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)
