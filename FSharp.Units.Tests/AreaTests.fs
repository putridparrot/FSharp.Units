namespace FSharp.Units.Tests

module AreaTests =

    open NUnit.Framework
    open FsCheck
    open FsCheck.NUnit
    open FsUnit
    open FSharp.Units.Area
    open Helpers


    [<Property>]
    let ``From Acres to Square Kilometres and back`` () =
        let property value =
            let convertTo = acre.toSquareKilometres (acre.create value)
            let convertBack = km2.toAcres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100.0<acre>, 0.404686)>]
    [<TestCase(90.0<acre>, 0.364217)>]
    [<TestCase(1800.0<acre>, 7.284342)>]
    let ``Convert known Acres to Square Kilometres`` (input, expectation) = 
        acre.toSquareKilometres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Acres to Square Metres and back`` () =
        let property value =
            let convertTo = acre.toSquareMetres (acre.create value)
            let convertBack = m2.toAcres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<acre>, 4856.23)>]
    [<TestCase(0.8<acre>, 3237.49)>]
    [<TestCase(5.6<acre>, 22662.416)>]
    let ``Convert known Acres to Square Metres`` (input, expectation) = 
        acre.toSquareMetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Acres to Square Miles and back`` () =
        let property value =
            let convertTo = acre.toSquareMiles (acre.create value)
            let convertBack = mile2.toAcres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1009.0<acre>, 1.576562)>]
    [<TestCase(90.0<acre>, 0.140625)>]
    [<TestCase(765.0<acre>, 1.19531)>]
    let ``Convert known Acres to Square Miles`` (input, expectation) = 
        acre.toSquareMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Acres to Square Yards and back`` () =
        let property value =
            let convertTo = acre.toSquareYards (acre.create value)
            let convertBack = yard2.toAcres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.4<acre>, 16456.0)>]
    [<TestCase(0.7<acre>, 3388.0)>]
    [<TestCase(0.01<acre>, 48.4)>]
    let ``Convert known Acres to Square Yards`` (input, expectation) = 
        acre.toSquareYards input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Acres to Square Feet and back`` () =
        let property value =
            let convertTo = acre.toSquareFeet (acre.create value)
            let convertBack = feet2.toAcres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.01<acre>, 435.6)>]
    [<TestCase(12.0<acre>, 522720.0)>]
    [<TestCase(0.67<acre>, 29185.2)>]
    let ``Convert known Acres to Square Feet`` (input, expectation) = 
        acre.toSquareFeet input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Acres to Square Inches and back`` () =
        let property value =
            let convertTo = acre.toSquareInches (acre.create value)
            let convertBack = inch2.toAcres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.09<acre>, 564537.6)>]
    [<TestCase(0.005<acre>, 31363.2)>]
    [<TestCase(0.012<acre>, 75271.68)>]
    let ``Convert known Acres to Square Inches`` (input, expectation) = 
        acre.toSquareInches input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Acres to Hectares and back`` () =
        let property value =
            let convertTo = acre.toHectares (acre.create value)
            let convertBack = hectare.toAcres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1109.0<acre>, 448.7964)>]
    [<TestCase(5.6<acre>, 2.26624)>]
    [<TestCase(1.23<acre>, 0.4977633)>]
    let ``Convert known Acres to Hectares`` (input, expectation) = 
        acre.toHectares input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hectares to Square Kilometres and back`` () =
        let property value =
            let convertTo = hectare.toSquareKilometres (hectare.create value)
            let convertBack = km2.toHectares convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(15000.0<hectare>, 150.0)>]
    [<TestCase(300.0<hectare>, 3.0)>]
    [<TestCase(45.6<hectare>, 0.456)>]
    let ``Convert known Hectares to Square Kilometres`` (input, expectation) = 
        hectare.toSquareKilometres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hectares to Square Metres and back`` () =
        let property value =
            let convertTo = hectare.toSquareMetres (hectare.create value)
            let convertBack = m2.toHectares convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.4<hectare>, 14000.0)>]
    [<TestCase(0.9<hectare>, 9000.0)>]
    [<TestCase(0.012<hectare>, 120.0)>]
    let ``Convert known Hectares to Square Metres`` (input, expectation) = 
        hectare.toSquareMetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hectares to Square Miles and back`` () =
        let property value =
            let convertTo = hectare.toSquareMiles (hectare.create value)
            let convertBack = mile2.toHectares convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1102.0<hectare>, 4.254846)>]
    [<TestCase(4500.0<hectare>, 17.3746)>]
    [<TestCase(90.0<hectare>, 0.347492)>]
    let ``Convert known Hectares to Square Miles`` (input, expectation) = 
        hectare.toSquareMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hectares to Square Yards and back`` () =
        let property value =
            let convertTo = hectare.toSquareYards (hectare.create value)
            let convertBack = yard2.toHectares convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<hectare>, 14351.8805556)>]
    [<TestCase(0.8<hectare>, 9567.92)>]
    [<TestCase(34.0<hectare>, 406636.615)>]
    let ``Convert known Hectares to Square Yards`` (input, expectation) = 
        hectare.toSquareYards input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hectares to Square Feet and back`` () =
        let property value =
            let convertTo = hectare.toSquareFeet (hectare.create value)
            let convertBack = feet2.toHectares convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.4<hectare>, 365972.599)>]
    [<TestCase(0.09<hectare>, 9687.519)>]
    [<TestCase(1.2<hectare>, 129166.7999)>]
    let ``Convert known Hectares to Square Feet`` (input, expectation) = 
        hectare.toSquareFeet input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hectares to Square Inches and back`` () =
        let property value =
            let convertTo = hectare.toSquareInches (hectare.create value)
            let convertBack = inch2.toHectares convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.009<hectare>, 139500.28)>]
    [<TestCase(0.01<hectare>, 155000.31)>]
    [<TestCase(0.0061<hectare>, 94550.1891)>]
    let ``Convert known Hectares to Square Inches`` (input, expectation) = 
        hectare.toSquareInches input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Hectares to Acres and back`` () =
        let property value =
            let convertTo = hectare.toAcres (hectare.create value)
            let convertBack = acre.toHectares convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1.2<hectare>, 2.96526)>]
    [<TestCase(0.8<hectare>, 1.97684)>]
    [<TestCase(4.2<hectare>, 10.3784)>]
    let ``Convert known Hectares to Acres`` (input, expectation) = 
        hectare.toAcres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Feet to Square Kilometres and back`` () =
        let property value =
            let convertTo = feet2.toSquareKilometres (feet2.create value)
            let convertBack = km2.toSquareFeet convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(88997766.0<feet2>, 8.2681630146)>]
    [<TestCase(10009002.0<feet2>, 0.92986671317)>]
    [<TestCase(987654321.0<feet2>, 91.75608889)>]
    let ``Convert known Square Feet to Square Kilometres`` (input, expectation) = 
        feet2.toSquareKilometres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Feet to Square Metres and back`` () =
        let property value =
            let convertTo = feet2.toSquareMetres (feet2.create value)
            let convertBack = m2.toSquareFeet convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<feet2>, 83.6127)>]
    [<TestCase(799.123<feet2>, 74.24095603)>]
    [<TestCase(500.0<feet2>, 46.4515)>]
    let ``Convert known Square Feet to Square Metres`` (input, expectation) = 
        feet2.toSquareMetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Feet to Square Miles and back`` () =
        let property value =
            let convertTo = feet2.toSquareMiles (feet2.create value)
            let convertBack = mile2.toSquareFeet convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12000000.0<feet2>, 0.43044077135)>]
    [<TestCase(987654321.0<feet2>, 35.4272239799)>]
    [<TestCase(900800700.0<feet2>, 32.3117790117)>]
    let ``Convert known Square Feet to Square Miles`` (input, expectation) = 
        feet2.toSquareMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Feet to Square Yards and back`` () =
        let property value =
            let convertTo = feet2.toSquareYards (feet2.create value)
            let convertBack = yard2.toSquareFeet convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(909.0<feet2>, 101.0)>]
    [<TestCase(123.456<feet2>, 13.71733333)>]
    [<TestCase(8009.0<feet2>, 889.8889)>]
    let ``Convert known Square Feet to Square Yards`` (input, expectation) = 
        feet2.toSquareYards input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Feet to Square Inches and back`` () =
        let property value =
            let convertTo = feet2.toSquareInches (feet2.create value)
            let convertBack = inch2.toSquareFeet convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(6.7<feet2>, 964.8)>]
    [<TestCase(1.5<feet2>, 216.0)>]
    [<TestCase(0.9<feet2>, 129.6)>]
    let ``Convert known Square Feet to Square Inches`` (input, expectation) = 
        feet2.toSquareInches input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Feet to Hectares and back`` () =
        let property value =
            let convertTo = feet2.toHectares (feet2.create value)
            let convertBack = hectare.toSquareFeet convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(90000.0<feet2>, 0.83612736)>]
    [<TestCase(120120.0<feet2>, 1.11595132)>]
    [<TestCase(90071.0<feet2>, 0.83678697)>]
    let ``Convert known Square Feet to Hectares`` (input, expectation) = 
        feet2.toHectares input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Feet to Acres and back`` () =
        let property value =
            let convertTo = feet2.toAcres (feet2.create value)
            let convertBack = acre.toSquareFeet convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(90000.0<feet2>, 2.0661157)>]
    [<TestCase(123456.0<feet2>, 2.83415978)>]
    [<TestCase(8809.0<feet2>, 0.2022268)>]
    let ``Convert known Square Feet to Acres`` (input, expectation) = 
        feet2.toAcres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Inches to Square Kilometres and back`` () =
        let property value =
            let convertTo = inch2.toSquareKilometres (inch2.create value)
            let convertBack = km2.toSquareInches convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(678900000.0<inch2>, 0.437999124)>]
    [<TestCase(10000000000.0<inch2>, 6.4516)>]
    [<TestCase(9e12<inch2>, 5806.44)>]
    let ``Convert known Square Inches to Square Kilometres`` (input, expectation) = 
        inch2.toSquareKilometres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Inches to Square Metres and back`` () =
        let property value =
            let convertTo = inch2.toSquareMetres (inch2.create value)
            let convertBack = m2.toSquareInches convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1090.0<inch2>, 0.7032244)>]
    [<TestCase(1.3e6<inch2>, 838.708)>]
    [<TestCase(9988.0<inch2>, 6.443858)>]
    let ``Convert known Square Inches to Square Metres`` (input, expectation) = 
        inch2.toSquareMetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Inches to Square Miles and back`` () =
        let property value =
            let convertTo = inch2.toSquareMiles (inch2.create value)
            let convertBack = mile2.toSquareInches convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1007008000.0<inch2>, 0.2508433450668)>]
    [<TestCase(1.2e12<inch2>, 298.9172023262932)>]
    [<TestCase(250e7<inch2>, 0.6227441715131)>]
    let ``Convert known Square Inches to Square Miles`` (input, expectation) = 
        inch2.toSquareMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Inches to Square Yards and back`` () =
        let property value =
            let convertTo = inch2.toSquareYards (inch2.create value)
            let convertBack = yard2.toSquareInches convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900.0<inch2>, 0.694444)>]
    [<TestCase(15000.0<inch2>, 11.574074)>]
    [<TestCase(3e6<inch2>, 2314.814815)>]
    let ``Convert known Square Inches to Square Yards`` (input, expectation) = 
        inch2.toSquareYards input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Inches to Square Feet and back`` () =
        let property value =
            let convertTo = inch2.toSquareFeet (inch2.create value)
            let convertBack = feet2.toSquareInches convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(34.0<inch2>, 0.236111)>]
    [<TestCase(1002.0<inch2>, 6.958333)>]
    [<TestCase(890.0<inch2>, 6.18056)>]
    let ``Convert known Square Inches to Square Feet`` (input, expectation) = 
        inch2.toSquareFeet input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Inches to Hectares and back`` () =
        let property value =
            let convertTo = inch2.toHectares (inch2.create value)
            let convertBack = hectare.toSquareInches convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(9000000.0<inch2>, 0.580644)>]
    [<TestCase(12345678.0<inch2>, 0.79649376185)>]
    [<TestCase(99887766.0<inch2>, 6.4443591113)>]
    let ``Convert known Square Inches to Hectares`` (input, expectation) = 
        inch2.toHectares input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Inches to Acres and back`` () =
        let property value =
            let convertTo = inch2.toAcres (inch2.create value)
            let convertBack = acre.toSquareInches convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900100.0<inch2>, 0.143496199)>]
    [<TestCase(5e6<inch2>, 0.7971125395)>]
    [<TestCase(12345678.0<inch2>, 1.9681789486)>]
    let ``Convert known Square Inches to Acres`` (input, expectation) = 
        inch2.toAcres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Kilometres to Square Metres and back`` () =
        let property value =
            let convertTo = km2.toSquareMetres (km2.create value)
            let convertBack = m2.toSquareKilometres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.12<km2>, 120000.)>]
    [<TestCase(0.9<km2>, 900000.)>]
    [<TestCase(8.123456<km2>, 8123456.)>]
    let ``Convert known Square Kilometres to Square Metres`` (input, expectation) = 
        km2.toSquareMetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Kilometres to Square Miles and back`` () =
        let property value =
            let convertTo = km2.toSquareMiles (km2.create value)
            let convertBack = mile2.toSquareKilometres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(492.098<km2>, 190.)>]
    [<TestCase(23.3099<km2>, 9.)>]
    [<TestCase(4661.979<km2>, 1800.)>]
    let ``Convert known Square Kilometres to Square Miles`` (input, expectation) = 
        km2.toSquareMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Kilometres to Square Yards and back`` () =
        let property value =
            let convertTo = km2.toSquareYards (km2.create value)
            let convertBack = yard2.toSquareKilometres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.158028071<km2>, 189000.0005)>]
    [<TestCase(8.361272764<km2>, 9999999.0310)>]
    [<TestCase(0.6<km2>, 717594.030)>]
    let ``Convert known Square Kilometres to Square Yards`` (input, expectation) = 
        km2.toSquareYards input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Kilometres to Square Feet and back`` () =
        let property value =
            let convertTo = km2.toSquareFeet (km2.create value)
            let convertBack = feet2.toSquareKilometres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.009<km2>, 96875.194)>]
    [<TestCase(0.08<km2>, 861112.833)>]
    [<TestCase(0.123<km2>, 1323960.9812553)>]
    let ``Convert known Square Kilometres to Square Feet`` (input, expectation) = 
        km2.toSquareFeet input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Kilometres to Square Inches and back`` () =
        let property value =
            let convertTo = km2.toSquareInches (km2.create value)
            let convertBack = inch2.toSquareKilometres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.0008<km2>, 1240002.48)>]
    [<TestCase(0.00123<km2>, 1906503.813)>]
    [<TestCase(0.000045<km2>, 69750.1395)>]
    let ``Convert known Square Kilometres to Square Inches`` (input, expectation) = 
        km2.toSquareInches input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Kilometres to Hectares and back`` () =
        let property value =
            let convertTo = km2.toHectares (km2.create value)
            let convertBack = hectare.toSquareKilometres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190.0<km2>, 19000.0)>]
    [<TestCase(55.67<km2>, 5567.0)>]
    [<TestCase(0.9<km2>, 90.0)>]
    let ``Convert known Square Kilometres to Hectares`` (input, expectation) = 
        km2.toHectares input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Kilometres to Acres and back`` () =
        let property value =
            let convertTo = km2.toAcres (km2.create value)
            let convertBack = acre.toSquareKilometres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(30.393962<km2>, 7510.4999900100)>]
    [<TestCase(54.1<km2>, 13368.3805)>]
    [<TestCase(90.67<km2>, 22405.0103)>]
    let ``Convert known Square Kilometres to Acres`` (input, expectation) = 
        km2.toAcres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Metres to Square Kilometres and back`` () =
        let property value =
            let convertTo = m2.toSquareKilometres (m2.create value)
            let convertBack = km2.toSquareMetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(19000.0<m2>, 0.019)>]
    [<TestCase(123456.0<m2>, 0.123456)>]
    [<TestCase(900100.0<m2>, 0.9001)>]
    let ``Convert known Square Metres to Square Kilometres`` (input, expectation) = 
        m2.toSquareKilometres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Metres to Square Miles and back`` () =
        let property value =
            let convertTo = m2.toSquareMiles (m2.create value)
            let convertBack = mile2.toSquareMetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(190009.0<m2>, 0.073362885)>]
    [<TestCase(12345678.0<m2>, 4.7666929245)>]
    [<TestCase(777666.0<m2>, 0.300258521)>]
    let ``Convert known Square Metres to Square Miles`` (input, expectation) = 
        m2.toSquareMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Metres to Square Yards and back`` () =
        let property value =
            let convertTo = m2.toSquareYards (m2.create value)
            let convertBack = yard2.toSquareMetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(5.0<m2>, 5.97995)>]
    [<TestCase(1.23<m2>, 1.471068)>]
    [<TestCase(700.0<m2>, 837.193)>]
    let ``Convert known Square Metres to Square Yards`` (input, expectation) = 
        m2.toSquareYards input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Metres to Square Feet and back`` () =
        let property value =
            let convertTo = m2.toSquareFeet (m2.create value)
            let convertBack = feet2.toSquareMetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(90.0<m2>, 968.752)>]
    [<TestCase(180.0<m2>, 1937.52)>]
    [<TestCase(123.4<m2>, 1328.2775)>]
    let ``Convert known Square Metres to Square Feet`` (input, expectation) = 
        m2.toSquareFeet input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Metres to Square Inches and back`` () =
        let property value =
            let convertTo = m2.toSquareInches (m2.create value)
            let convertBack = inch2.toSquareMetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(8.0<m2>, 12400.0)>]
    [<TestCase(1.23<m2>, 1906.504)>]
    [<TestCase(0.9<m2>, 1395.0)>]
    let ``Convert known Square Metres to Square Inches`` (input, expectation) = 
        m2.toSquareInches input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Metres to Hectares and back`` () =
        let property value =
            let convertTo = m2.toHectares (m2.create value)
            let convertBack = hectare.toSquareMetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1234.0<m2>, 0.1234)>]
    [<TestCase(560.9<m2>, 0.05609)>]
    [<TestCase(100900.0<m2>, 10.09)>]
    let ``Convert known Square Metres to Hectares`` (input, expectation) = 
        m2.toHectares input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Metres to Acres and back`` () =
        let property value =
            let convertTo = m2.toAcres (m2.create value)
            let convertBack = acre.toSquareMetres convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(986.0<m2>, 0.243646)>]
    [<TestCase(1020.0<m2>, 0.2520475)>]
    [<TestCase(666111.0<m2>, 164.599613)>]
    let ``Convert known Square Metres to Acres`` (input, expectation) = 
        m2.toAcres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Miles to Square Kilometres and back`` () =
        let property value =
            let convertTo = mile2.toSquareKilometres (mile2.create value)
            let convertBack = km2.toSquareMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(3.0<mile2>, 7.76996)>]
    [<TestCase(0.9<mile2>, 2.33099)>]
    [<TestCase(100.0<mile2>, 258.999)>]
    let ``Convert known Square Miles to Square Kilometres`` (input, expectation) = 
        mile2.toSquareKilometres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Miles to Square Metres and back`` () =
        let property value =
            let convertTo = mile2.toSquareMetres (mile2.create value)
            let convertBack = m2.toSquareMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.009<mile2>, 23309.893)>]
    [<TestCase(0.010<mile2>, 25899.88)>]
    [<TestCase(0.0006<mile2>, 1553.99287)>]
    let ``Convert known Square Miles to Square Metres`` (input, expectation) = 
        mile2.toSquareMetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Miles to Square Yards and back`` () =
        let property value =
            let convertTo = mile2.toSquareYards (mile2.create value)
            let convertBack = yard2.toSquareMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.01<mile2>, 30976.0)>]
    [<TestCase(0.00123<mile2>, 3810.048)>]
    [<TestCase(0.09<mile2>, 278784.0)>]
    let ``Convert known Square Miles to Square Yards`` (input, expectation) = 
        mile2.toSquareYards input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Miles to Square Feet and back`` () =
        let property value =
            let convertTo = mile2.toSquareFeet (mile2.create value)
            let convertBack = feet2.toSquareMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.01<mile2>, 278784.0)>]
    [<TestCase(0.005<mile2>, 139392.0)>]
    [<TestCase(0.08<mile2>, 2230272.0)>]
    let ``Convert known Square Miles to Square Feet`` (input, expectation) = 
        mile2.toSquareFeet input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Miles to Square Inches and back`` () =
        let property value =
            let convertTo = mile2.toSquareInches (mile2.create value)
            let convertBack = inch2.toSquareMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(0.0001<mile2>, 401448.96)>]
    [<TestCase(0.00098<mile2>, 3934199.808)>]
    [<TestCase(0.000007<mile2>, 28101.4272)>]
    let ``Convert known Square Miles to Square Inches`` (input, expectation) = 
        mile2.toSquareInches input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Miles to Hectares and back`` () =
        let property value =
            let convertTo = mile2.toHectares (mile2.create value)
            let convertBack = hectare.toSquareMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(100.0<mile2>, 25900.0)>]
    [<TestCase(2.3<mile2>, 595.697)>]
    [<TestCase(0.9<mile2>, 233.099)>]
    let ``Convert known Square Miles to Hectares`` (input, expectation) = 
        mile2.toHectares input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Miles to Acres and back`` () =
        let property value =
            let convertTo = mile2.toAcres (mile2.create value)
            let convertBack = acre.toSquareMiles convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(2.0<mile2>, 1280.0)>]
    [<TestCase(0.1<mile2>, 64.0)>]
    [<TestCase(4.6<mile2>, 2944.0)>]
    let ``Convert known Square Miles to Acres`` (input, expectation) = 
        mile2.toAcres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Yards to Square Kilometres and back`` () =
        let property value =
            let convertTo = yard2.toSquareKilometres (yard2.create value)
            let convertBack = km2.toSquareYards convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(900000.0<yard2>, 0.752514624)>]
    [<TestCase(190190.0<yard2>, 0.159023063)>]
    [<TestCase(7000000.0<yard2>, 5.85289152)>]
    let ``Convert known Square Yards to Square Kilometres`` (input, expectation) = 
        yard2.toSquareKilometres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Yards to Square Metres and back`` () =
        let property value =
            let convertTo = yard2.toSquareMetres (yard2.create value)
            let convertBack = m2.toSquareYards convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(700.0<yard2>, 585.289)>]
    [<TestCase(12.0<yard2>, 10.0335)>]
    [<TestCase(9.1<yard2>, 7.60876)>]
    let ``Convert known Square Yards to Square Metres`` (input, expectation) = 
        yard2.toSquareMetres input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Yards to Square Miles and back`` () =
        let property value =
            let convertTo = yard2.toSquareMiles (yard2.create value)
            let convertBack = mile2.toSquareYards convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(98700.0<yard2>, 0.031863378)>]
    [<TestCase(8888888.0<yard2>, 2.869604855)>]
    [<TestCase(100200300.0<yard2>, 32.3477208161)>]
    let ``Convert known Square Yards to Square Miles`` (input, expectation) = 
        yard2.toSquareMiles input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Yards to Square Feet and back`` () =
        let property value =
            let convertTo = yard2.toSquareFeet (yard2.create value)
            let convertBack = feet2.toSquareYards convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(12.0<yard2>, 108.0)>]
    [<TestCase(5.6<yard2>, 50.4)>]
    [<TestCase(102.5<yard2>, 922.5)>]
    let ``Convert known Square Yards to Square Feet`` (input, expectation) = 
        yard2.toSquareFeet input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Yards to Square Inches and back`` () =
        let property value =
            let convertTo = yard2.toSquareInches (yard2.create value)
            let convertBack = inch2.toSquareYards convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(56.7<yard2>, 73483.2)>]
    [<TestCase(1.8<yard2>, 2332.8)>]
    [<TestCase(0.2<yard2>, 259.2)>]
    let ``Convert known Square Yards to Square Inches`` (input, expectation) = 
        yard2.toSquareInches input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Yards to Hectares and back`` () =
        let property value =
            let convertTo = yard2.toHectares (yard2.create value)
            let convertBack = hectare.toSquareYards convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(10090.0<yard2>, 0.84365251)>]
    [<TestCase(98765.0<yard2>, 8.2580119)>]
    [<TestCase(3090.09<yard2>, 0.2583634)>]
    let ``Convert known Square Yards to Hectares`` (input, expectation) = 
        yard2.toHectares input
        |> should (equalWithin 0.01) expectation

    [<Property>]
    let ``From Square Yards to Acres and back`` () =
        let property value =
            let convertTo = yard2.toAcres (yard2.create value)
            let convertBack = acre.toSquareYards convertTo

            convertBack
            |> should (equalWithin 0.01) value

        Check.QuickThrowOnFailure (testRange property)

    [<TestCase(1000.0<yard2>, 0.206612)>]
    [<TestCase(899.0<yard2>, 0.185744)>]
    [<TestCase(5678.0<yard2>, 1.17314)>]
    let ``Convert known Square Yards to Acres`` (input, expectation) = 
        yard2.toAcres input
        |> should (equalWithin 0.01) expectation
