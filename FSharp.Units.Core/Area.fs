namespace FSharp.Units

open Microsoft.FSharp.Core

module Area =

    [<Measure>]
    type m2 = // metre square
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<m2> value
        static member toSquareKilometre(value : float<m2>) = km2.create(Utils.removeUnit(value / 1e+6))
        static member toSquareMile(value : float<m2>) = mile2.create(Utils.removeUnit(value / 2.59e+6))
        static member toSquareYard(value : float<m2>) = yard2.create(Utils.removeUnit(value * 1.196))
        static member toSquareFeet(value : float<m2>) = feet2.create(Utils.removeUnit(value * 10.764))
        static member toSquareInch(value : float<m2>) = inch2.create(Utils.removeUnit(value * 1550.0))
        static member toHectare(value : float<m2>) = hectare.create(Utils.removeUnit(value / 10000.0))
        static member toAcre(value : float<m2>) = acre.create(Utils.removeUnit(value / 4047.0))
    and [<Measure>] km2 =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<km2> value
        static member toSquareMetre(value : float<km2>) = m2.create(Utils.removeUnit(value * 1e+6))
        static member toSquareMile(value : float<km2>) = mile2.create(Utils.removeUnit(value / 2.59))
        static member toSquareYard(value : float<km2>) = yard2.create(Utils.removeUnit(value * 1.196e+6))
        static member toSquareFeet(value : float<km2>) = feet2.create(Utils.removeUnit(value * 1.076e+7))
        static member toSquareInch(value : float<km2>) = inch2.create(Utils.removeUnit(value * 1.55e+9))
        static member toHectare(value : float<km2>) = hectare.create(Utils.removeUnit(value * 100.0))
        static member toAcre(value : float<km2>) = acre.create(Utils.removeUnit(value * 247.0))
    and [<Measure>] mile2 =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<mile2> value
        static member toSquareMetre(value : float<mile2>) = m2.create(Utils.removeUnit(value * 2.59e+6))
        static member toSquareKilometre(value : float<mile2>) = km2.create(Utils.removeUnit(value * 2.59))
        static member toSquareYard(value : float<mile2>) = yard2.create(Utils.removeUnit(value * 3.098e+6))
        static member toSquareFeet(value : float<mile2>) = feet2.create(Utils.removeUnit(value * 2.788e+7))
        static member toSquareInch(value : float<mile2>) = inch2.create(Utils.removeUnit(value * 4.014e+9))
        static member toHectare(value : float<mile2>) = hectare.create(Utils.removeUnit(value * 259.0))
        static member toAcre(value : float<mile2>) = acre.create(Utils.removeUnit(value * 640.0))
    and [<Measure>] yard2 =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<yard2> value
        static member toSquareMetre(value : float<yard2>) = m2.create(Utils.removeUnit(value / 1.196))
        static member toSquareKilometre(value : float<yard2>) = km2.create(Utils.removeUnit(value / 1.196e+6))
        static member toSquareMile(value : float<yard2>) = mile2.create(Utils.removeUnit(value / 3.098e+6))
        static member toSquareFeet(value : float<yard2>) = feet2.create(Utils.removeUnit(value * 9.0))
        static member toSquareInch(value : float<yard2>) = inch2.create(Utils.removeUnit(value * 1296.0))
        static member toHectare(value : float<yard2>) = hectare.create(Utils.removeUnit(value / 11960.0))
        static member toAcre(value : float<yard2>) = acre.create(Utils.removeUnit(value / 4840.0))
    and [<Measure>] feet2 =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<feet2> value
        static member toSquareMetre(value : float<feet2>) = m2.create(Utils.removeUnit(value / 10.764))
        static member toSquareKilometre(value : float<feet2>) = km2.create(Utils.removeUnit(value / 1.076e+7))
        static member toSquareMile(value : float<feet2>) = mile2.create(Utils.removeUnit(value / 2.788e+7))
        static member toSquareYard(value : float<feet2>) = yard2.create(Utils.removeUnit(value / 9.0))
        static member toSquareInch(value : float<feet2>) = inch2.create(Utils.removeUnit(value * 144.0))
        static member toHectare(value : float<feet2>) = hectare.create(Utils.removeUnit(value / 107639.0))
        static member toAcre(value : float<feet2>) = acre.create(Utils.removeUnit(value / 43560.0))
    and [<Measure>] inch2 =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<inch2> value
        static member toSquareMetre(value : float<inch2>) = m2.create(Utils.removeUnit(value / 1550.0))
        static member toSquareKilometre(value : float<inch2>) = km2.create(Utils.removeUnit(value / 1.55e+9))
        static member toSquareMile(value : float<inch2>) = mile2.create(Utils.removeUnit(value / 4.014e+9))
        static member toSquareFeet(value : float<inch2>) = feet2.create(Utils.removeUnit(value / 144.0))
        static member toSquareYard(value : float<inch2>) = yard2.create(Utils.removeUnit(value / 1296.0))
        static member toHectare(value : float<inch2>) = hectare.create(Utils.removeUnit(value / 1.55e+7))
        static member toAcre(value : float<inch2>) = acre.create(Utils.removeUnit(value / 6.273e+6))
    and [<Measure>] hectare =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<hectare> value
        static member toSquareMetre(value : float<hectare>) = m2.create(Utils.removeUnit(value * 10000.0))
        static member toSquareKilometre(value : float<hectare>) = km2.create(Utils.removeUnit(value / 100.0))
        static member toSquareMile(value : float<hectare>) = mile2.create(Utils.removeUnit(value / 259.0))
        static member toSquareFeet(value : float<hectare>) = feet2.create(Utils.removeUnit(value * 107639.0))
        static member toSquareYard(value : float<hectare>) = yard2.create(Utils.removeUnit(value * 11960.0))
        static member toSquareInch(value : float<hectare>) = inch2.create(Utils.removeUnit(value * 1.55e+7))
        static member toAcre(value : float<hectare>) = acre.create(Utils.removeUnit(value * 2.471))
    and [<Measure>] acre =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<acre> value
        static member toSquareMetre(value : float<acre>) = m2.create(Utils.removeUnit(value * 4047.0))
        static member toSquareKilometre(value : float<acre>) = km2.create(Utils.removeUnit(value / 247.0))
        static member toSquareMile(value : float<acre>) = mile2.create(Utils.removeUnit(value / 640.0))
        static member toSquareFeet(value : float<acre>) = feet2.create(Utils.removeUnit(value * 43560.0))
        static member toSquareYard(value : float<acre>) = yard2.create(Utils.removeUnit(value * 4840.0))
        static member toSquareInch(value : float<acre>) = inch2.create(Utils.removeUnit(value * 6.273e+6))
        static member toHectare(value : float<acre>) = hectare.create(Utils.removeUnit(value / 2.471))


