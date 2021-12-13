namespace FSharp.Units

open Microsoft.FSharp.Core

module Volume =

    /// Fluid Ounces (floz) units
    [<Measure>]
    type floz =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<floz> value
        /// Converts the supplied Fluid Ounces value to Millilitres
        static member toMillilitres(value : float<floz>) = ml.create(float value * 28.413074243749994496)
        /// Converts the supplied Fluid Ounces value to Litres
        static member toLitres(value : float<floz>) = l.create(float value * 0.028413074243749994496)
        /// Converts the supplied Fluid Ounces value to Kilolitres
        static member toKilolitres(value : float<floz>) = kl.create(float value * 0.000028413074243749994)
        /// Converts the supplied Fluid Ounces value to Teaspoons
        static member toTeaspoons(value : float<floz>) = tsp.create(float value * 4.8)
        /// Converts the supplied Fluid Ounces value to Tablespoons
        static member toTablespoons(value : float<floz>) = tbsp.create(float value * 1.6)
        /// Converts the supplied Fluid Ounces value to Quarts
        static member toQuarts(value : float<floz>) = qt.create(float value / 40.)
        /// Converts the supplied Fluid Ounces value to Pints
        static member toPints(value : float<floz>) = pt.create(float value / 20.)
        /// Converts the supplied Fluid Ounces value to Gallons
        static member toGallons(value : float<floz>) = gal.create(float value / 160.)
        /// Converts the supplied Fluid Ounces value to US Teaspoons
        static member toUSTeaspoons(value : float<floz>) = ustsp.create(float value / 0.1734737167638313984)
        /// Converts the supplied Fluid Ounces value to US Tablespoons
        static member toUSTablespoons(value : float<floz>) = ustbsp.create(float value / 0.52042115029149417472)
        /// Converts the supplied Fluid Ounces value to US Quarts
        static member toUSQuarts(value : float<floz>) = usqt.create(float value / 33.306953618655629312)
        /// Converts the supplied Fluid Ounces value to US Pints
        static member toUSPints(value : float<floz>) = uspt.create(float value / 16.653476809327814656)
        /// Converts the supplied Fluid Ounces value to US Gallons
        static member toUSGallons(value : float<floz>) = usgal.create(float value / 133.22781447462252544)
        /// Converts the supplied Fluid Ounces value to US Fluid Ounces
        static member toUSFluidOunces(value : float<floz>) = usfloz.create(float value / 1.0408423005829883904)
        /// Converts the supplied Fluid Ounces value to US Cups
        static member toUSCups(value : float<floz>) = uscup.create(float value / 8.3267384046639071232)
    and /// Gallons (gal) units
        [<Measure>] gal =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<gal> value
        /// Converts the supplied Gallons value to Millilitres
        static member toMillilitres(value : float<gal>) = ml.create(float value * 4546.091879)
        /// Converts the supplied Gallons value to Litres
        static member toLitres(value : float<gal>) = l.create(float value * 4.546091879)
        /// Converts the supplied Gallons value to Kilolitres
        static member toKilolitres(value : float<gal>) = kl.create(float value * 0.004546091879)
        /// Converts the supplied Gallons value to Teaspoons
        static member toTeaspoons(value : float<gal>) = tsp.create(float value * 768.)
        /// Converts the supplied Gallons value to Tablespoons
        static member toTablespoons(value : float<gal>) = tbsp.create(float value * 256.)
        /// Converts the supplied Gallons value to Quarts
        static member toQuarts(value : float<gal>) = qt.create(float value * 4.)
        /// Converts the supplied Gallons value to Pints
        static member toPints(value : float<gal>) = pt.create(float value * 8.)
        /// Converts the supplied Gallons value to Fluid Ounces
        static member toFluidOunces(value : float<gal>) = floz.create(float value * 160.)
        /// Converts the supplied Gallons value to US Teaspoons
        static member toUSTeaspoons(value : float<gal>) = ustsp.create(float value / 0.00108421072977394606)
        /// Converts the supplied Gallons value to US Tablespoons
        static member toUSTablespoons(value : float<gal>) = ustbsp.create(float value / 0.003252632189321838592)
        /// Converts the supplied Gallons value to US Quarts
        static member toUSQuarts(value : float<gal>) = usqt.create(float value / 0.20816846011659767808)
        /// Converts the supplied Gallons value to US Pints
        static member toUSPints(value : float<gal>) = uspt.create(float value / 0.10408423005829883904)
        /// Converts the supplied Gallons value to US Gallons
        static member toUSGallons(value : float<gal>) = usgal.create(float value / 0.83267384046639071232)
        /// Converts the supplied Gallons value to US Fluid Ounces
        static member toUSFluidOunces(value : float<gal>) = usfloz.create(float value / 0.006505264378643677184)
        /// Converts the supplied Gallons value to US Cups
        static member toUSCups(value : float<gal>) = uscup.create(float value / 0.052042115029149417472)
    and /// Kilolitres (kl) units
        [<Measure>] kl =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kl> value
        /// Converts the supplied Kilolitres value to Millilitres
        static member toMillilitres(value : float<kl>) = ml.create(float value * 1000000.)
        /// Converts the supplied Kilolitres value to Litres
        static member toLitres(value : float<kl>) = l.create(float value * 1000.0)
        /// Converts the supplied Kilolitres value to Teaspoons
        static member toTeaspoons(value : float<kl>) = tsp.create(float value / 0.000005919390467447916)
        /// Converts the supplied Kilolitres value to Tablespoons
        static member toTablespoons(value : float<kl>) = tbsp.create(float value / 0.000017758171402343747)
        /// Converts the supplied Kilolitres value to Quarts
        static member toQuarts(value : float<kl>) = qt.create(float value / 0.00113652296975)
        /// Converts the supplied Kilolitres value to Pints
        static member toPints(value : float<kl>) = pt.create(float value / 0.000568261484874999889)
        /// Converts the supplied Kilolitres value to Gallons
        static member toGallons(value : float<kl>) = gal.create(float value / 0.0045460918799)
        /// Converts the supplied Kilolitres value to Fluid Ounces
        static member toFluidOunces(value : float<kl>) = floz.create(float value / 0.0000284130742437499946)
        /// Converts the supplied Kilolitres value to US Teaspoons
        static member toUSTeaspoons(value : float<kl>) = ustsp.create(float value / 0.000004928921593749999)
        /// Converts the supplied Kilolitres value to US Tablespoons
        static member toUSTablespoons(value : float<kl>) = ustbsp.create(float value / 0.000014786764781249998)
        /// Converts the supplied Kilolitres value to US Quarts
        static member toUSQuarts(value : float<kl>) = usqt.create(float value / 0.000946352945999999959)
        /// Converts the supplied Kilolitres value to US Pints
        static member toUSPints(value : float<kl>) = uspt.create(float value / 0.000473176472999999979)
        /// Converts the supplied Kilolitres value to US Gallons
        static member toUSGallons(value : float<kl>) = usgal.create(float value / 0.003785411784)
        /// Converts the supplied Kilolitres value to US Fluid Ounces
        static member toUSFluidOunces(value : float<kl>) = usfloz.create(float value / 0.0000295735296)
        /// Converts the supplied Kilolitres value to US Cups
        static member toUSCups(value : float<kl>) = uscup.create(float value / 0.000236588236499999989)
    and /// Litres (l) units
        [<Measure>] l =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<l> value
        /// Converts the supplied Litres value to Millilitres
        static member toMillilitres(value : float<l>) = ml.create(float value * 1000.0)
        /// Converts the supplied Litres value to Kilolitres
        static member toKilolitres(value : float<l>) = kl.create(float value / 1000.)
        /// Converts the supplied Litres value to Teaspoons
        static member toTeaspoons(value : float<l>) = tsp.create(float value / 0.005919390467447916134)
        /// Converts the supplied Litres value to Tablespoons
        static member toTablespoons(value : float<l>) = tbsp.create(float value / 0.017758171402343747584)
        /// Converts the supplied Litres value to Quarts
        static member toQuarts(value : float<l>) = qt.create(float value / 1.13652296975)
        /// Converts the supplied Litres value to Pints
        static member toPints(value : float<l>) = pt.create(float value / 0.56826148487499988992)
        /// Converts the supplied Litres value to Gallons
        static member toGallons(value : float<l>) = gal.create(float value / 4.546091879)
        /// Converts the supplied Litres value to Fluid Ounces
        static member toFluidOunces(value : float<l>) = floz.create(float value / 0.028413074243749994496)
        /// Converts the supplied Litres value to US Teaspoons
        static member toUSTeaspoons(value : float<l>) = ustsp.create(float value / 0.004928921593749999616)
        /// Converts the supplied Litres value to US Tablespoons
        static member toUSTablespoons(value : float<l>) = ustbsp.create(float value / 0.014786764781249998848)
        /// Converts the supplied Litres value to US Quarts
        static member toUSQuarts(value : float<l>) = usqt.create(float value / 0.94635294599999995904)
        /// Converts the supplied Litres value to US Pints
        static member toUSPints(value : float<l>) = uspt.create(float value / 0.47317647299999997952)
        /// Converts the supplied Litres value to US Gallons
        static member toUSGallons(value : float<l>) = usgal.create(float value / 3.785411784)
        /// Converts the supplied Litres value to US Fluid Ounces
        static member toUSFluidOunces(value : float<l>) = usfloz.create(float value / 0.029573529562499997696)
        /// Converts the supplied Litres value to US Cups
        static member toUSCups(value : float<l>) = uscup.create(float value / 0.23658823649999998976)
    and /// Millilitres (ml) units
        [<Measure>] ml =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<ml> value
        /// Converts the supplied Millilitres value to Litres
        static member toLitres(value : float<ml>) = l.create(float value / 1000.0)
        /// Converts the supplied Millilitres value to Kilolitres
        static member toKilolitres(value : float<ml>) = kl.create(float value / 1000000.)
        /// Converts the supplied Millilitres value to Teaspoons
        static member toTeaspoons(value : float<ml>) = tsp.create(float value / 5.9193904674479161344)
        /// Converts the supplied Millilitres value to Tablespoons
        static member toTablespoons(value : float<ml>) = tbsp.create(float value / 17.758171402343747584)
        /// Converts the supplied Millilitres value to Quarts
        static member toQuarts(value : float<ml>) = qt.create(float value / 1136.52296975)
        /// Converts the supplied Millilitres value to Pints
        static member toPints(value : float<ml>) = pt.create(float value / 568.26148487499988992)
        /// Converts the supplied Millilitres value to Gallons
        static member toGallons(value : float<ml>) = gal.create(float value / 4546.091879)
        /// Converts the supplied Millilitres value to Fluid Ounces
        static member toFluidOunces(value : float<ml>) = floz.create(float value / 28.413074243749994496)
        /// Converts the supplied Millilitres value to US Teaspoons
        static member toUSTeaspoons(value : float<ml>) = ustsp.create(float value / 4.928921593749999616)
        /// Converts the supplied Millilitres value to US Tablespoons
        static member toUSTablespoons(value : float<ml>) = ustbsp.create(float value / 14.786764781249998848)
        /// Converts the supplied Millilitres value to US Quarts
        static member toUSQuarts(value : float<ml>) = usqt.create(float value / 946.35294599999995904)
        /// Converts the supplied Millilitres value to US Pints
        static member toUSPints(value : float<ml>) = uspt.create(float value / 473.17647299999997952)
        /// Converts the supplied Millilitres value to US Gallons
        static member toUSGallons(value : float<ml>) = usgal.create(float value / 3785.411784)
        /// Converts the supplied Millilitres value to US Fluid Ounces
        static member toUSFluidOunces(value : float<ml>) = usfloz.create(float value / 29.573529562499997696)
        /// Converts the supplied Millilitres value to US Cups
        static member toUSCups(value : float<ml>) = uscup.create(float value / 236.58823649999998976)
    and /// Pints (pt) units
        [<Measure>] pt =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<pt> value
        /// Converts the supplied Pints value to Millilitres
        static member toMillilitres(value : float<pt>) = ml.create(float value * 568.26148487499988992)
        /// Converts the supplied Pints value to Litres
        static member toLitres(value : float<pt>) = l.create(float value * 0.56826148487499988992)
        /// Converts the supplied Pints value to Kilolitres
        static member toKilolitres(value : float<pt>) = kl.create(float value * 0.000568261484874999889)
        /// Converts the supplied Pints value to Teaspoons
        static member toTeaspoons(value : float<pt>) = tsp.create(float value * 96.)
        /// Converts the supplied Pints value to Tablespoons
        static member toTablespoons(value : float<pt>) = tbsp.create(float value * 32.)
        /// Converts the supplied Pints value to Quarts
        static member toQuarts(value : float<pt>) = qt.create(float value  / 2.)
        /// Converts the supplied Pints value to Gallons
        static member toGallons(value : float<pt>) = gal.create(float value / 8.)
        /// Converts the supplied Pints value to Fluid Ounces
        static member toFluidOunces(value : float<pt>) = floz.create(float value * 20.)
        /// Converts the supplied Pints value to US Teaspoons
        static member toUSTeaspoons(value : float<pt>) = ustsp.create(float value / 0.008673685838191568486)
        /// Converts the supplied Pints value to US Tablespoons
        static member toUSTablespoons(value : float<pt>) = ustbsp.create(float value / 0.026021057514574708736)
        /// Converts the supplied Pints value to US Quarts
        static member toUSQuarts(value : float<pt>) = usqt.create(float value / 1.6653476809327814656)
        /// Converts the supplied Pints value to US Pints
        static member toUSPints(value : float<pt>) = uspt.create(float value / 0.83267384046639071232)
        /// Converts the supplied Pints value to US Gallons
        static member toUSGallons(value : float<pt>) = usgal.create(float value / 6.6613907237311258624)
        /// Converts the supplied Pints value to US Fluid Ounces
        static member toUSFluidOunces(value : float<pt>) = usfloz.create(float value / 0.052042115029149417472)
        /// Converts the supplied Pints value to US Cups
        static member toUSCups(value : float<pt>) = uscup.create(float value / 0.41633692023319535616)
    and /// Quarts (qt) units
        [<Measure>] qt =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<qt> value
        /// Converts the supplied Quarts value to Millilitres
        static member toMillilitres(value : float<qt>) = ml.create(float value * 1136.52296975)
        /// Converts the supplied Quarts value to Litres
        static member toLitres(value : float<qt>) = l.create(float value * 1.13652296975)
        /// Converts the supplied Quarts value to Kilolitres
        static member toKilolitres(value : float<qt>) = kl.create(float value * 0.00113652296975)
        /// Converts the supplied Quarts value to Teaspoons
        static member toTeaspoons(value : float<qt>) = tsp.create(float value * 192.)
        /// Converts the supplied Quarts value to Tablespoons
        static member toTablespoons(value : float<qt>) = tbsp.create(float value * 64.)
        /// Converts the supplied Quarts value to Pints
        static member toPints(value : float<qt>) = pt.create(float value * 2.)
        /// Converts the supplied Quarts value to Gallons
        static member toGallons(value : float<qt>) = gal.create(float value / 4.)
        /// Converts the supplied Quarts value to Fluid Ounces
        static member toFluidOunces(value : float<qt>) = floz.create(float value * 40.)
        /// Converts the supplied Quarts value to US Teaspoons
        static member toUSTeaspoons(value : float<qt>) = ustsp.create(float value / 0.004336842919095784243)
        /// Converts the supplied Quarts value to US Tablespoons
        static member toUSTablespoons(value : float<qt>) = ustbsp.create(float value / 0.013010528757287354368)
        /// Converts the supplied Quarts value to US Quarts
        static member toUSQuarts(value : float<qt>) = usqt.create(float value / 0.83267384046639071232)
        /// Converts the supplied Quarts value to US Pints
        static member toUSPints(value : float<qt>) = uspt.create(float value / 0.41633692023319535616)
        /// Converts the supplied Quarts value to US Gallons
        static member toUSGallons(value : float<qt>) = usgal.create(float value / 3.3306953618655629312)
        /// Converts the supplied Quarts value to US Fluid Ounces
        static member toUSFluidOunces(value : float<qt>) = usfloz.create(float value / 0.026021057514574708736)
        /// Converts the supplied Quarts value to US Cups
        static member toUSCups(value : float<qt>) = uscup.create(float value / 0.20816846011659767808)
    and /// Tablespoons (tbsp) units
        [<Measure>] tbsp =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<tbsp> value
        /// Converts the supplied Tablespoons value to Millilitres
        static member toMillilitres(value : float<tbsp>) = ml.create(float value * 17.758171402343747584)
        /// Converts the supplied Tablespoons value to Litres
        static member toLitres(value : float<tbsp>) = l.create(float value * 0.017758171402343747584)
        /// Converts the supplied Tablespoons value to Kilolitres
        static member toKilolitres(value : float<tbsp>) = kl.create(float value * 0.000017758171402343747)
        /// Converts the supplied Tablespoons value to Teaspoons
        static member toTeaspoons(value : float<tbsp>) = tsp.create(float value * 3.)
        /// Converts the supplied Tablespoons value to Quarts
        static member toQuarts(value : float<tbsp>) = qt.create(float value / 64.)
        /// Converts the supplied Tablespoons value to Pints
        static member toPints(value : float<tbsp>) = pt.create(float value / 32.)
        /// Converts the supplied Tablespoons value to Gallons
        static member toGallons(value : float<tbsp>) = gal.create(float value / 256.)
        /// Converts the supplied Tablespoons value to Fluid Ounces
        static member toFluidOunces(value : float<tbsp>) = floz.create(float value / 1.6)
        /// Converts the supplied Tablespoons value to US Teaspoons
        static member toUSTeaspoons(value : float<tbsp>) = ustsp.create(float value / 0.27755794682213023744)
        /// Converts the supplied Tablespoons value to US Tablespoons
        static member toUSTablespoons(value : float<tbsp>) = ustbsp.create(float value / 0.83267384046639071232)
        /// Converts the supplied Tablespoons value to US Quarts
        static member toUSQuarts(value : float<tbsp>) = usqt.create(float value / 53.291125789849001984)
        /// Converts the supplied Tablespoons value to US Pints
        static member toUSPints(value : float<tbsp>) = uspt.create(float value / 26.645562894924500992)
        /// Converts the supplied Tablespoons value to US Gallons
        static member toUSGallons(value : float<tbsp>) = usgal.create(float value / 213.16450315939602432)
        /// Converts the supplied Tablespoons value to US Fluid Ounces
        static member toUSFluidOunces(value : float<tbsp>) = usfloz.create(float value / 1.6653476809327814656)
        /// Converts the supplied Tablespoons value to US Cups
        static member toUSCups(value : float<tbsp>) = uscup.create(float value / 13.322781447462250496)
    and /// Teaspoons (tsp) units
        [<Measure>] tsp =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<tsp> value
        /// Converts the supplied Teaspoons value to Millilitres
        static member toMillilitres(value : float<tsp>) = ml.create(float value * 5.9193904674479161344)
        /// Converts the supplied Teaspoons value to Litres
        static member toLitres(value : float<tsp>) = l.create(float value * 0.005919390467447916134)
        /// Converts the supplied Teaspoons value to Kilolitres
        static member toKilolitres(value : float<tsp>) = kl.create(float value * 0.000005919390467447916)
        /// Converts the supplied Teaspoons value to Tablespoons
        static member toTablespoons(value : float<tsp>) = tbsp.create(float value / 3.)
        /// Converts the supplied Teaspoons value to Quarts
        static member toQuarts(value : float<tsp>) = qt.create(float value / 192.)
        /// Converts the supplied Teaspoons value to Pints
        static member toPints(value : float<tsp>) = pt.create(float value / 96.)
        /// Converts the supplied Teaspoons value to Gallons
        static member toGallons(value : float<tsp>) = gal.create(float value / 768.)
        /// Converts the supplied Teaspoons value to Fluid Ounces
        static member toFluidOunces(value : float<tsp>) = floz.create(float value / 4.8)
        /// Converts the supplied Teaspoons value to US Teaspoons
        static member toUSTeaspoons(value : float<tsp>) = ustsp.create(float value / 0.83267384046639071232)
        /// Converts the supplied Teaspoons value to US Tablespoons
        static member toUSTablespoons(value : float<tsp>) = ustbsp.create(float value / 2.4980215213991718912)
        /// Converts the supplied Teaspoons value to US Quarts
        static member toUSQuarts(value : float<tsp>) = usqt.create(float value / 159.87337736954701824)
        /// Converts the supplied Teaspoons value to US Pints
        static member toUSPints(value : float<tsp>) = uspt.create(float value / 79.936688684773507072)
        /// Converts the supplied Teaspoons value to US Gallons
        static member toUSGallons(value : float<tsp>) = usgal.create(float value / 639.49350947818807296)
        /// Converts the supplied Teaspoons value to US Fluid Ounces
        static member toUSFluidOunces(value : float<tsp>) = usfloz.create(float value / 4.9960430427983437824)
        /// Converts the supplied Teaspoons value to US Cups
        static member toUSCups(value : float<tsp>) = uscup.create(float value / 39.968344342386753536)
    and /// US Cups (uscup) units
        [<Measure>] uscup =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<uscup> value
        /// Converts the supplied US Cups value to Millilitres
        static member toMillilitres(value : float<uscup>) = ml.create(float value * 236.58823649999998976)
        /// Converts the supplied US Cups value to Litres
        static member toLitres(value : float<uscup>) = l.create(float value * 0.23658823649999998976)
        /// Converts the supplied US Cups value to Kilolitres
        static member toKilolitres(value : float<uscup>) = kl.create(float value * 0.000236588236499999989)
        /// Converts the supplied US Cups value to Teaspoons
        static member toTeaspoons(value : float<uscup>) = tsp.create(float value * 39.968344342386753536)
        /// Converts the supplied US Cups value to Tablespoons
        static member toTablespoons(value : float<uscup>) = tbsp.create(float value * 13.322781447462250496)
        /// Converts the supplied US Cups value to Quarts
        static member toQuarts(value : float<uscup>) = qt.create(float value * 0.20816846011659767808)
        /// Converts the supplied US Cups value to Pints
        static member toPints(value : float<uscup>) = pt.create(float value * 0.41633692023319535616)
        /// Converts the supplied US Cups value to Gallons
        static member toGallons(value : float<uscup>) = gal.create(float value * 0.052042115029149417472)
        /// Converts the supplied US Cups value to Fluid Ounces
        static member toFluidOunces(value : float<uscup>) = floz.create(float value * 8.3267384046639071232)
        /// Converts the supplied US Cups value to US Teaspoons
        static member toUSTeaspoons(value : float<uscup>) = ustsp.create(float value * 48.)
        /// Converts the supplied US Cups value to US Tablespoons
        static member toUSTablespoons(value : float<uscup>) = ustbsp.create(float value * 16.)
        /// Converts the supplied US Cups value to US Quarts
        static member toUSQuarts(value : float<uscup>) = usqt.create(float value / 4.)
        /// Converts the supplied US Cups value to US Pints
        static member toUSPints(value : float<uscup>) = uspt.create(float value / 2.)
        /// Converts the supplied US Cups value to US Gallons
        static member toUSGallons(value : float<uscup>) = usgal.create(float value / 16.)
        /// Converts the supplied US Cups value to US Fluid Ounces
        static member toUSFluidOunces(value : float<uscup>) = usfloz.create(float value * 8.)
    and /// US Fluid Ounces (usfloz) units
        [<Measure>] usfloz =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<usfloz> value
        /// Converts the supplied US Fluid Ounces value to Millilitres
        static member toMillilitres(value : float<usfloz>) = ml.create(float value * 29.573529562499997696)
        /// Converts the supplied US Fluid Ounces value to Litres
        static member toLitres(value : float<usfloz>) = l.create(float value * 0.029573529562499997696)
        /// Converts the supplied US Fluid Ounces value to Kilolitres
        static member toKilolitres(value : float<usfloz>) = kl.create(float value * 0.0000295735296)
        /// Converts the supplied US Fluid Ounces value to Teaspoons
        static member toTeaspoons(value : float<usfloz>) = tsp.create(float value * 4.9960430427983437824)
        /// Converts the supplied US Fluid Ounces value to Tablespoons
        static member toTablespoons(value : float<usfloz>) = tbsp.create(float value * 1.6653476809327814656)
        /// Converts the supplied US Fluid Ounces value to Quarts
        static member toQuarts(value : float<usfloz>) = qt.create(float value * 0.026021057514574708736)
        /// Converts the supplied US Fluid Ounces value to Pints
        static member toPints(value : float<usfloz>) = pt.create(float value * 0.052042115029149417472)
        /// Converts the supplied US Fluid Ounces value to Gallons
        static member toGallons(value : float<usfloz>) = gal.create(float value * 0.006505264378643677184)
        /// Converts the supplied US Fluid Ounces value to Fluid Ounces
        static member toFluidOunces(value : float<usfloz>) = floz.create(float value * 1.0408423005829883904)
        /// Converts the supplied US Fluid Ounces value to US Teaspoons
        static member toUSTeaspoons(value : float<usfloz>) = ustsp.create(float value * 6.)
        /// Converts the supplied US Fluid Ounces value to US Tablespoons
        static member toUSTablespoons(value : float<usfloz>) = ustbsp.create(float value * 2.)
        /// Converts the supplied US Fluid Ounces value to US Quarts
        static member toUSQuarts(value : float<usfloz>) = usqt.create(float value / 32.)
        /// Converts the supplied US Fluid Ounces value to US Pints
        static member toUSPints(value : float<usfloz>) = uspt.create(float value / 16.)
        /// Converts the supplied US Fluid Ounces value to US Gallons
        static member toUSGallons(value : float<usfloz>) = usgal.create(float value / 128.)
        /// Converts the supplied US Fluid Ounces value to US Cups
        static member toUSCups(value : float<usfloz>) = uscup.create(float value / 8.)
    and /// US Gallons (usgal) units
        [<Measure>] usgal =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<usgal> value
        /// Converts the supplied US Gallons value to Millilitres
        static member toMillilitres(value : float<usgal>) = ml.create(float value * 3785.411784)
        /// Converts the supplied US Gallons value to Litres
        static member toLitres(value : float<usgal>) = l.create(float value * 3.785411784)
        /// Converts the supplied US Gallons value to Kilolitres
        static member toKilolitres(value : float<usgal>) = kl.create(float value * 0.003785411784)
        /// Converts the supplied US Gallons value to Teaspoons
        static member toTeaspoons(value : float<usgal>) = tsp.create(float value * 639.49350947818807296)
        /// Converts the supplied US Gallons value to Tablespoons
        static member toTablespoons(value : float<usgal>) = tbsp.create(float value * 213.16450315939602432)
        /// Converts the supplied US Gallons value to Quarts
        static member toQuarts(value : float<usgal>) = qt.create(float value * 3.3306953618655629312)
        /// Converts the supplied US Gallons value to Pints
        static member toPints(value : float<usgal>) = pt.create(float value * 6.6613907237311258624)
        /// Converts the supplied US Gallons value to Gallons
        static member toGallons(value : float<usgal>) = gal.create(float value * 0.83267384046639071232)
        /// Converts the supplied US Gallons value to Fluid Ounces
        static member toFluidOunces(value : float<usgal>) = floz.create(float value * 133.22781447462252544)
        /// Converts the supplied US Gallons value to US Teaspoons
        static member toUSTeaspoons(value : float<usgal>) = ustsp.create(float value * 768.)
        /// Converts the supplied US Gallons value to US Tablespoons
        static member toUSTablespoons(value : float<usgal>) = ustbsp.create(float value * 256.)
        /// Converts the supplied US Gallons value to US Quarts
        static member toUSQuarts(value : float<usgal>) = usqt.create(float value * 4.)
        /// Converts the supplied US Gallons value to US Pints
        static member toUSPints(value : float<usgal>) = uspt.create(float value * 8.)
        /// Converts the supplied US Gallons value to US Fluid Ounces
        static member toUSFluidOunces(value : float<usgal>) = usfloz.create(float value * 128.)
        /// Converts the supplied US Gallons value to US Cups
        static member toUSCups(value : float<usgal>) = uscup.create(float value * 16.0)
    and /// US Pints (uspt) units
        [<Measure>] uspt =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<uspt> value
        /// Converts the supplied US Pints value to Millilitres
        static member toMillilitres(value : float<uspt>) = ml.create(float value * 473.17647299999997952)
        /// Converts the supplied US Pints value to Litres
        static member toLitres(value : float<uspt>) = l.create(float value * 0.47317647299999997952)
        /// Converts the supplied US Pints value to Kilolitres
        static member toKilolitres(value : float<uspt>) = kl.create(float value * 0.000473176472999999979)
        /// Converts the supplied US Pints value to Teaspoons
        static member toTeaspoons(value : float<uspt>) = tsp.create(float value * 79.936688684773507072)
        /// Converts the supplied US Pints value to Tablespoons
        static member toTablespoons(value : float<uspt>) = tbsp.create(float value * 26.645562894924500992)
        /// Converts the supplied US Pints value to Quarts
        static member toQuarts(value : float<uspt>) = qt.create(float value * 0.41633692023319535616)
        /// Converts the supplied US Pints value to Pints
        static member toPints(value : float<uspt>) = pt.create(float value * 0.83267384046639071232)
        /// Converts the supplied US Pints value to Gallons
        static member toGallons(value : float<uspt>) = gal.create(float value * 0.10408423005829883904)
        /// Converts the supplied US Pints value to Fluid Ounces
        static member toFluidOunces(value : float<uspt>) = floz.create(float value * 16.653476809327814656)
        /// Converts the supplied US Pints value to US Teaspoons
        static member toUSTeaspoons(value : float<uspt>) = ustsp.create(float value * 96.)
        /// Converts the supplied US Pints value to US Tablespoons
        static member toUSTablespoons(value : float<uspt>) = ustbsp.create(float value * 32.)
        /// Converts the supplied US Pints value to US Quarts
        static member toUSQuarts(value : float<uspt>) = usqt.create(float value / 2.)
        /// Converts the supplied US Pints value to US Gallons
        static member toUSGallons(value : float<uspt>) = usgal.create(float value / 8.)
        /// Converts the supplied US Pints value to US Fluid Ounces
        static member toUSFluidOunces(value : float<uspt>) = usfloz.create(float value * 16.)
        /// Converts the supplied US Pints value to US Cups
        static member toUSCups(value : float<uspt>) = uscup.create(float value * 2.)
    and /// US Quarts (usqt) units
        [<Measure>] usqt =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<usqt> value
        /// Converts the supplied US Quarts value to Millilitres
        static member toMillilitres(value : float<usqt>) = ml.create(float value * 946.35294599999995904)
        /// Converts the supplied US Quarts value to Litres
        static member toLitres(value : float<usqt>) = l.create(float value * 0.94635294599999995904)
        /// Converts the supplied US Quarts value to Kilolitres
        static member toKilolitres(value : float<usqt>) = kl.create(float value * 0.000946352945999999959)
        /// Converts the supplied US Quarts value to Teaspoons
        static member toTeaspoons(value : float<usqt>) = tsp.create(float value * 159.87337736954701824)
        /// Converts the supplied US Quarts value to Tablespoons
        static member toTablespoons(value : float<usqt>) = tbsp.create(float value * 53.291125789849001984)
        /// Converts the supplied US Quarts value to Quarts
        static member toQuarts(value : float<usqt>) = qt.create(float value * 0.83267384046639071232)
        /// Converts the supplied US Quarts value to Pints
        static member toPints(value : float<usqt>) = pt.create(float value * 1.6653476809327814656)
        /// Converts the supplied US Quarts value to Gallons
        static member toGallons(value : float<usqt>) = gal.create(float value * 0.20816846011659767808)
        /// Converts the supplied US Quarts value to Fluid Ounces
        static member toFluidOunces(value : float<usqt>) = floz.create(float value * 33.306953618655629312)
        /// Converts the supplied US Quarts value to US Teaspoons
        static member toUSTeaspoons(value : float<usqt>) = ustsp.create(float value * 192.)
        /// Converts the supplied US Quarts value to US Tablespoons
        static member toUSTablespoons(value : float<usqt>) = ustbsp.create(float value * 64.)
        /// Converts the supplied US Quarts value to US Pints
        static member toUSPints(value : float<usqt>) = uspt.create(float value * 2.)
        /// Converts the supplied US Quarts value to US Gallons
        static member toUSGallons(value : float<usqt>) = usgal.create(float value / 4.)
        /// Converts the supplied US Quarts value to US Fluid Ounces
        static member toUSFluidOunces(value : float<usqt>) = usfloz.create(float value * 32.)
        /// Converts the supplied US Quarts value to US Cups
        static member toUSCups(value : float<usqt>) = uscup.create(float value * 4.)
    and /// US Tablespoons (ustbsp) units
        [<Measure>] ustbsp =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<ustbsp> value
        /// Converts the supplied US Tablespoons value to Millilitres
        static member toMillilitres(value : float<ustbsp>) = ml.create(float value * 14.786764781249998848)
        /// Converts the supplied US Tablespoons value to Litres
        static member toLitres(value : float<ustbsp>) = l.create(float value * 0.014786764781249998848)
        /// Converts the supplied US Tablespoons value to Kilolitres
        static member toKilolitres(value : float<ustbsp>) = kl.create(float value * 0.000014786764781249998)
        /// Converts the supplied US Tablespoons value to Teaspoons
        static member toTeaspoons(value : float<ustbsp>) = tsp.create(float value * 2.4980215213991718912)
        /// Converts the supplied US Tablespoons value to Tablespoons
        static member toTablespoons(value : float<ustbsp>) = tbsp.create(float value * 0.83267384046639071232)
        /// Converts the supplied US Tablespoons value to Quarts
        static member toQuarts(value : float<ustbsp>) = qt.create(float value * 0.013010528757287354368)
        /// Converts the supplied US Tablespoons value to Pints
        static member toPints(value : float<ustbsp>) = pt.create(float value * 0.026021057514574708736)
        /// Converts the supplied US Tablespoons value to Gallons
        static member toGallons(value : float<ustbsp>) = gal.create(float value * 0.003252632189321838592)
        /// Converts the supplied US Tablespoons value to Fluid Ounces
        static member toFluidOunces(value : float<ustbsp>) = floz.create(float value * 0.52042115029149417472)
        /// Converts the supplied US Tablespoons value to US Teaspoons
        static member toUSTeaspoons(value : float<ustbsp>) = ustsp.create(float value * 3.)
        /// Converts the supplied US Tablespoons value to US Quarts
        static member toUSQuarts(value : float<ustbsp>) = usqt.create(float value / 64.)
        /// Converts the supplied US Tablespoons value to US Pints
        static member toUSPints(value : float<ustbsp>) = uspt.create(float value / 32.)
        /// Converts the supplied US Tablespoons value to US Gallons
        static member toUSGallons(value : float<ustbsp>) = usgal.create(float value / 256.)
        /// Converts the supplied US Tablespoons value to US Fluid Ounces
        static member toUSFluidOunces(value : float<ustbsp>) = usfloz.create(float value / 2.)
        /// Converts the supplied US Tablespoons value to US Cups
        static member toUSCups(value : float<ustbsp>) = uscup.create(float value / 16.)
    and /// US Teaspoons (ustsp) units
        [<Measure>] ustsp =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<ustsp> value
        /// Converts the supplied US Teaspoons value to Millilitres
        static member toMillilitres(value : float<ustsp>) = ml.create(float value * 4.928921593749999616)
        /// Converts the supplied US Teaspoons value to Litres
        static member toLitres(value : float<ustsp>) = l.create(float value * 0.004928921593749999616)
        /// Converts the supplied US Teaspoons value to Kilolitres
        static member toKilolitres(value : float<ustsp>) = kl.create(float value * 0.000004928921593749999)
        /// Converts the supplied US Teaspoons value to Teaspoons
        static member toTeaspoons(value : float<ustsp>) = tsp.create(float value * 0.83267384046639071232)
        /// Converts the supplied US Teaspoons value to Tablespoons
        static member toTablespoons(value : float<ustsp>) = tbsp.create(float value * 0.27755794682213023744)
        /// Converts the supplied US Teaspoons value to Quarts
        static member toQuarts(value : float<ustsp>) = qt.create(float value * 0.004336842919095784243)
        /// Converts the supplied US Teaspoons value to Pints
        static member toPints(value : float<ustsp>) = pt.create(float value * 0.008673685838191568486)
        /// Converts the supplied US Teaspoons value to Gallons
        static member toGallons(value : float<ustsp>) = gal.create(float value * 0.00108421072977394606)
        /// Converts the supplied US Teaspoons value to Fluid Ounces
        static member toFluidOunces(value : float<ustsp>) = floz.create(float value * 0.1734737167638313984)
        /// Converts the supplied US Teaspoons value to US Tablespoons
        static member toUSTablespoons(value : float<ustsp>) = ustbsp.create(float value / 3.)
        /// Converts the supplied US Teaspoons value to US Quarts
        static member toUSQuarts(value : float<ustsp>) = usqt.create(float value / 192.)
        /// Converts the supplied US Teaspoons value to US Pints
        static member toUSPints(value : float<ustsp>) = uspt.create(float value / 96.)
        /// Converts the supplied US Teaspoons value to US Gallons
        static member toUSGallons(value : float<ustsp>) = usgal.create(float value / 768.)
        /// Converts the supplied US Teaspoons value to US Fluid Ounces
        static member toUSFluidOunces(value : float<ustsp>) = usfloz.create(float value / 6.)
        /// Converts the supplied US Teaspoons value to US Cups
        static member toUSCups(value : float<ustsp>) = uscup.create(float value / 48.)