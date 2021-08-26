﻿namespace FSharp.Units

open Microsoft.FSharp.Core

module Volume = 

    [<Measure>]
    type ml = // millilitres
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<ml> value
        static member toLitres(value : float<ml>) = l.create(float value / 1000.0)
        static member toKilolitres(value : float<ml>) = kl.create(float value / 1000000.)
        static member toTeaspoons(value : float<ml>) = tsp.create(float value / 5.9193904674479161344)
        static member toTablespoons(value : float<ml>) = tbsp.create(float value / 17.758171402343747584)
        static member toQuarts(value : float<ml>) = qt.create(float value / 1136.52296975)
        static member toPints(value : float<ml>) = pt.create(float value / 568.26148487499988992)
        static member toGallons(value : float<ml>) = gal.create(float value / 4546.091879)
        static member toFluidOunces(value : float<ml>) = floz.create(float value / 28.413074243749994496)
        static member toUSTeaspoons(value : float<ml>) = ustsp.create(float value / 4.928921593749999616)
        static member toUSTablespoons(value : float<ml>) = ustbsp.create(float value / 14.786764781249998848)
        static member toUSQuarts(value : float<ml>) = usqt.create(float value / 946.35294599999995904)
        static member toUSPints(value : float<ml>) = uspt.create(float value / 473.17647299999997952)
        static member toUSGallons(value : float<ml>) = usgal.create(float value / 3785.411784)
        static member toUSFluidOunces(value : float<ml>) = usfloz.create(float value / 29.573529562499997696)
        static member toUSCups(value : float<ml>) = uscup.create(float value / 236.58823649999998976)
    and [<Measure>] l = // litres
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<l> value
        static member toMillilitres(value : float<l>) = ml.create(float value * 1000.0)
        static member toKilolitres(value : float<l>) = kl.create(float value / 1000.)
        static member toTeaspoons(value : float<l>) = tsp.create(float value / 0.005919390467447916134)
        static member toTablespoons(value : float<l>) = tbsp.create(float value / 0.017758171402343747584)
        static member toQuarts(value : float<l>) = qt.create(float value / 1.13652296975)
        static member toPints(value : float<l>) = pt.create(float value / 0.56826148487499988992)
        static member toGallons(value : float<l>) = gal.create(float value / 4.546091879)
        static member toFluidOunces(value : float<l>) = floz.create(float value / 0.028413074243749994496)
        static member toUSTeaspoons(value : float<l>) = ustsp.create(float value / 0.004928921593749999616)
        static member toUSTablespoons(value : float<l>) = ustbsp.create(float value / 0.014786764781249998848)
        static member toUSQuarts(value : float<l>) = usqt.create(float value / 0.94635294599999995904)
        static member toUSPints(value : float<l>) = uspt.create(float value / 0.47317647299999997952)
        static member toUSGallons(value : float<l>) = usgal.create(float value / 3.785411784)
        static member toUSFluidOunces(value : float<l>) = usfloz.create(float value / 0.029573529562499997696)
        static member toUSCups(value : float<l>) = value / 0.23658823649999998976<l/uscup>
    and [<Measure>] kl = // kilolitres
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kl> value
        static member toMillilitres(value : float<kl>) = ml.create(float value * 1000000.)
        static member toLitres(value : float<kl>) = l.create(float value * 1000.0)
        static member toTeaspoons(value : float<kl>) = tsp.create(float value / 0.000005919390467447916)
        static member toTablespoons(value : float<kl>) = tbsp.create(float value / 0.000017758171402343747)
        static member toQuarts(value : float<kl>) = qt.create(float value / 0.00113652296975)
        static member toPints(value : float<kl>) = pt.create(float value / 0.000568261484874999889)
        static member toGallons(value : float<kl>) = gal.create(float value / 0.0045460918799)
        static member toFluidOunces(value : float<kl>) = floz.create(float value / 0.0000284130742437499946)
        static member toUSTeaspoons(value : float<kl>) = ustsp.create(float value / 0.000004928921593749999)
        static member toUSTablespoons(value : float<kl>) = ustbsp.create(float value / 0.000014786764781249998)
        static member toUSQuarts(value : float<kl>) = usqt.create(float value / 0.000946352945999999959)
        static member toUSPints(value : float<kl>) = uspt.create(float value / 0.000473176472999999979)
        static member toUSGallons(value : float<kl>) = usgal.create(float value / 0.003785411784)
        static member toUSFluidOunces(value : float<kl>) = usfloz.create(float value / 0.0000295735296)
        static member toUSCups(value : float<kl>) = uscup.create(float value / 0.000236588236499999989)
    and [<Measure>] tsp = // imperial teaspoon
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<tsp> value
        static member toMillilitres(value : float<tsp>) = ml.create(float value * 5.9193904674479161344)
        static member toLitres(value : float<tsp>) = l.create(float value * 0.005919390467447916134)
        static member toKilolitres(value : float<tsp>) = kl.create(float value * 0.000005919390467447916)
        static member toTablespoons(value : float<tsp>) = tbsp.create(float value / 3.)
        static member toQuarts(value : float<tsp>) = qt.create(float value / 192.)
        static member toPints(value : float<tsp>) = pt.create(float value / 96.)
        static member toGallons(value : float<tsp>) = gal.create(float value / 768.)
        static member toFluidOunces(value : float<tsp>) = floz.create(float value / 4.8)
        static member toUSTeaspoons(value : float<tsp>) = ustsp.create(float value / 0.83267384046639071232)
        static member toUSTablespoons(value : float<tsp>) = ustbsp.create(float value / 2.4980215213991718912)
        static member toUSQuarts(value : float<tsp>) = usqt.create(float value / 159.87337736954701824)
        static member toUSPints(value : float<tsp>) = uspt.create(float value / 79.936688684773507072)
        static member toUSGallons(value : float<tsp>) = usgal.create(float value / 639.49350947818807296)
        static member toUSFluidOunces(value : float<tsp>) = usfloz.create(float value / 4.9960430427983437824)
        static member toUSCups(value : float<tsp>) = uscup.create(float value / 39.968344342386753536)
    and [<Measure>] tbsp = // imperial tablespoon
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<tbsp> value
        static member toMillilitres(value : float<tbsp>) = ml.create(float value * 17.758171402343747584)
        static member toLitres(value : float<tbsp>) = l.create(float value * 0.017758171402343747584)
        static member toKilolitres(value : float<tbsp>) = kl.create(float value * 0.000017758171402343747)
        static member toTeaspoons(value : float<tbsp>) = tsp.create(float value * 3.)
        static member toQuarts(value : float<tbsp>) = qt.create(float value / 64.)
        static member toPints(value : float<tbsp>) = pt.create(float value / 32.)
        static member toGallons(value : float<tbsp>) = gal.create(float value / 256.)
        static member toFluidOunces(value : float<tbsp>) = floz.create(float value / 1.6)
        static member toUSTeaspoons(value : float<tbsp>) = ustsp.create(float value / 0.27755794682213023744)
        static member toUSTablespoons(value : float<tbsp>) = ustbsp.create(float value / 0.83267384046639071232)
        static member toUSQuarts(value : float<tbsp>) = usqt.create(float value / 53.291125789849001984)
        static member toUSPints(value : float<tbsp>) = uspt.create(float value / 26.645562894924500992)
        static member toUSGallons(value : float<tbsp>) = usgal.create(float value / 213.16450315939602432)
        static member toUSFluidOunces(value : float<tbsp>) = usfloz.create(float value / 1.6653476809327814656)
        static member toUSCups(value : float<tbsp>) = uscup.create(float value / 13.322781447462250496)
    and [<Measure>] qt = // imperial quart
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<qt> value
        static member toMillilitres(value : float<qt>) = ml.create(float value * 1136.52296975)
        static member toLitres(value : float<qt>) = l.create(float value * 1.13652296975)
        static member toKilolitres(value : float<qt>) = kl.create(float value * 0.00113652296975)
        static member toTeaspoons(value : float<qt>) = tsp.create(float value * 192.)
        static member toTablespoons(value : float<qt>) = tbsp.create(float value * 64.)
        static member toPints(value : float<qt>) = pt.create(float value * 2.)
        static member toGallons(value : float<qt>) = gal.create(float value / 4.)
        static member toFluidOunces(value : float<qt>) = floz.create(float value * 40.)
        static member toUSTeaspoons(value : float<qt>) = ustsp.create(float value / 0.004336842919095784243)
        static member toUSTablespoons(value : float<qt>) = ustbsp.create(float value / 0.013010528757287354368)
        static member toUSQuarts(value : float<qt>) = usqt.create(float value / 0.83267384046639071232)
        static member toUSPints(value : float<qt>) = uspt.create(float value / 0.41633692023319535616)
        static member toUSGallons(value : float<qt>) = usgal.create(float value / 3.3306953618655629312)
        static member toUSFluidOunces(value : float<qt>) = usfloz.create(float value / 0.026021057514574708736)
        static member toUSCups(value : float<qt>) = uscup.create(float value / 0.20816846011659767808)
    and [<Measure>] pt = // imperial pint
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<pt> value
        static member toMillilitres(value : float<pt>) = ml.create(float value * 568.26148487499988992)
        static member toLitres(value : float<pt>) = l.create(float value * 0.56826148487499988992)
        static member toKilolitres(value : float<pt>) = kl.create(float value * 0.000568261484874999889)
        static member toTeaspoons(value : float<pt>) = tsp.create(float value * 96.)
        static member toTablespoons(value : float<pt>) = tbsp.create(float value * 32.)
        static member toQuarts(value : float<pt>) = qt.create(float value / 2.)
        static member toGallons(value : float<pt>) = gal.create(float value / 8.)
        static member toFluidOunces(value : float<pt>) = floz.create(float value * 20.)
        static member toUSTeaspoons(value : float<pt>) = ustsp.create(float value / 0.008673685838191568486)
        static member toUSTablespoons(value : float<pt>) = ustbsp.create(float value / 0.026021057514574708736)
        static member toUSQuarts(value : float<pt>) = usqt.create(float value / 1.6653476809327814656)
        static member toUSPints(value : float<pt>) = uspt.create(float value / 0.83267384046639071232)
        static member toUSGallons(value : float<pt>) = usgal.create(float value / 6.6613907237311258624)
        static member toUSFluidOunces(value : float<pt>) = usfloz.create(float value / 0.052042115029149417472)
        static member toUSCups(value : float<pt>) = uscup.create(float value / 0.41633692023319535616)
    and [<Measure>] gal = // imperial gallons
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<gal> value
        static member toMillilitres(value : float<gal>) = ml.create(float value * 4546.091879)
        static member toLitres(value : float<gal>) = l.create(float value * 4.546091879)
        static member toKilolitres(value : float<gal>) = kl.create(float value * 0.004546091879)
        static member toTeaspoons(value : float<gal>) = tsp.create(float value * 768.)
        static member toTablespoons(value : float<gal>) = tbsp.create(float value * 256.)
        static member toQuarts(value : float<gal>) = qt.create(float value * 4.)
        static member toPints(value : float<gal>) = pt.create(float value * 8.)
        static member toFluidOunces(value : float<gal>) = floz.create(float value * 160.)
        static member toUSTeaspoons(value : float<gal>) = ustsp.create(float value / 0.00108421072977394606)
        static member toUSTablespoons(value : float<gal>) = ustbsp.create(float value / 0.003252632189321838592)
        static member toUSQuarts(value : float<gal>) = usqt.create(float value / 0.20816846011659767808)
        static member toUSPints(value : float<gal>) = uspt.create(float value / 0.10408423005829883904)
        static member toUSGallons(value : float<gal>) = usgal.create(float value / 0.83267384046639071232)
        static member toUSFluidOunces(value : float<gal>) = usfloz.create(float value / 0.006505264378643677184)
        static member toUSCups(value : float<gal>) = uscup.create(float value / 0.052042115029149417472)
    and [<Measure>] floz = // imperial fluid ounces
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<floz> value
        static member toMillilitres(value : float<floz>) = ml.create(float value * 28.413074243749994496)
        static member toLitres(value : float<floz>) = l.create(float value * 0.028413074243749994496)
        static member toKilolitres(value : float<floz>) = kl.create(float value * 0.000028413074243749994)
        static member toTeaspoons(value : float<floz>) = tsp.create(float value * 4.8)
        static member toTablespoons(value : float<floz>) = tbsp.create(float value * 1.6)
        static member toQuarts(value : float<floz>) = qt.create(float value / 40.)
        static member toPints(value : float<floz>) = pt.create(float value / 20.)
        static member toGallons(value : float<floz>) = gal.create(float value / 160.)
        static member toUSTeaspoons(value : float<floz>) = ustsp.create(float value / 0.1734737167638313984)
        static member toUSTablespoons(value : float<floz>) = ustbsp.create(float value / 0.52042115029149417472)
        static member toUSQuarts(value : float<floz>) = usqt.create(float value / 33.306953618655629312)
        static member toUSPints(value : float<floz>) = uspt.create(float value / 16.653476809327814656)
        static member toUSGallons(value : float<floz>) = usgal.create(float value / 133.22781447462252544)
        static member toUSFluidOunces(value : float<floz>) = usfloz.create(float value / 1.0408423005829883904)
        static member toUSCups(value : float<floz>) = uscup.create(float value / 8.3267384046639071232)
    and [<Measure>] ustsp = // US teaspoon
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<ustsp> value
        static member toMillilitres(value : float<ustsp>) = ml.create(float value * 4.928921593749999616)
        static member toLitres(value : float<ustsp>) = l.create(float value * 0.004928921593749999616)
        static member toKilolitres(value : float<ustsp>) = kl.create(float value * 0.000004928921593749999)
        static member toTeaspoons(value : float<ustsp>) = tsp.create(float value * 0.83267384046639071232)
        static member toTablespoons(value : float<ustsp>) = tbsp.create(float value * 0.27755794682213023744)
        static member toQuarts(value : float<ustsp>) = qt.create(float value * 0.004336842919095784243)
        static member toPints(value : float<ustsp>) = pt.create(float value * 0.008673685838191568486)
        static member toGallons(value : float<ustsp>) = gal.create(float value * 0.00108421072977394606)
        static member toFluidOunces(value : float<ustsp>) = floz.create(float value * 0.1734737167638313984)
        static member toUSTablespoons(value : float<ustsp>) = ustbsp.create(float value / 3.)
        static member toUSQuarts(value : float<ustsp>) = usqt.create(float value / 192.)
        static member toUSPints(value : float<ustsp>) = uspt.create(float value / 96.)
        static member toUSGallons(value : float<ustsp>) = usgal.create(float value / 768.)
        static member toUSFluidOunces(value : float<ustsp>) = usfloz.create(float value / 6.)
        static member toUSCups(value : float<ustsp>) = uscup.create(float value / 48.)
    and [<Measure>] ustbsp = // US tablespoon
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<ustbsp> value
        static member toMillilitres(value : float<ustbsp>) = ml.create(float value * 14.786764781249998848)
        static member toLitres(value : float<ustbsp>) = l.create(float value * 0.014786764781249998848)
        static member toKilolitres(value : float<ustbsp>) = kl.create(float value * 0.000014786764781249998)
        static member toTeaspoons(value : float<ustbsp>) = tsp.create(float value * 2.4980215213991718912)
        static member toTablespoons(value : float<ustbsp>) = tbsp.create(float value * 0.83267384046639071232)
        static member toQuarts(value : float<ustbsp>) = qt.create(float value * 0.013010528757287354368)
        static member toPints(value : float<ustbsp>) = pt.create(float value * 0.026021057514574708736)
        static member toGallons(value : float<ustbsp>) = gal.create(float value * 0.003252632189321838592)
        static member toFluidOunces(value : float<ustbsp>) = floz.create(float value * 0.52042115029149417472)
        static member toUSTeaspoons(value : float<ustbsp>) = ustsp.create(float value * 3.)
        static member toUSQuarts(value : float<ustbsp>) = usqt.create(float value / 64.)
        static member toUSPints(value : float<ustbsp>) = uspt.create(float value / 32.)
        static member toUSGallons(value : float<ustbsp>) = usgal.create(float value / 256.)
        static member toUSFluidOunces(value : float<ustbsp>) = usfloz.create(float value / 2.)
        static member toUSCups(value : float<ustbsp>) = uscup.create(float value / 16.)
    and [<Measure>] usqt = // US quarts
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<usqt> value
        static member toMillilitres(value : float<usqt>) = ml.create(float value * 946.35294599999995904)
        static member toLitres(value : float<usqt>) = l.create(float value * 0.94635294599999995904)
        static member toKilolitres(value : float<usqt>) = kl.create(float value * 0.000946352945999999959)
        static member toTeaspoons(value : float<usqt>) = tsp.create(float value * 159.87337736954701824)
        static member toTablespoons(value : float<usqt>) = tbsp.create(float value * 53.291125789849001984)
        static member toQuarts(value : float<usqt>) = qt.create(float value * 0.83267384046639071232)
        static member toPints(value : float<usqt>) = pt.create(float value * 1.6653476809327814656)
        static member toGallons(value : float<usqt>) = gal.create(float value * 0.20816846011659767808)
        static member toFluidOunces(value : float<usqt>) = floz.create(float value * 33.306953618655629312)
        static member toUSTeaspoons(value : float<usqt>) = ustsp.create(float value * 192.)
        static member toUSTablespoons(value : float<usqt>) = ustbsp.create(float value * 64.)
        static member toUSPints(value : float<usqt>) = uspt.create(float value * 2.)
        static member toUSGallons(value : float<usqt>) = usgal.create(float value / 4.)
        static member toUSFluidOunces(value : float<usqt>) = usfloz.create(float value * 32.)
        static member toUSCups(value : float<usqt>) = uscup.create(float value * 4.)
    and [<Measure>] uspt = // US pints
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<uspt> value
        static member toMillilitres(value : float<uspt>) = ml.create(float value * 473.17647299999997952)
        static member toLitres(value : float<uspt>) = l.create(float value * 0.47317647299999997952)
        static member toKilolitres(value : float<uspt>) = kl.create(float value * 0.000473176472999999979)
        static member toTeaspoons(value : float<uspt>) = tsp.create(float value * 79.936688684773507072)
        static member toTablespoons(value : float<uspt>) = tbsp.create(float value * 26.645562894924500992)
        static member toQuarts(value : float<uspt>) = qt.create(float value * 0.41633692023319535616)
        static member toPints(value : float<uspt>) = pt.create(float value * 0.83267384046639071232)
        static member toGallons(value : float<uspt>) = gal.create(float value * 0.10408423005829883904)
        static member toFluidOunces(value : float<uspt>) = floz.create(float value * 16.653476809327814656)
        static member toUSTeaspoons(value : float<uspt>) = ustsp.create(float value * 96.)
        static member toUSTablespoons(value : float<uspt>) = ustbsp.create(float value * 32.)
        static member toUSQuarts(value : float<uspt>) = usqt.create(float value / 2.)
        static member toUSGallons(value : float<uspt>) = usgal.create(float value / 8.)
        static member toUSFluidOunces(value : float<uspt>) = usfloz.create(float value * 16.)
        static member toUSCups(value : float<uspt>) = uscup.create(float value * 2.)
    and [<Measure>] usgal = // US gallons
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<usgal> value
        static member toMillilitres(value : float<usgal>) = ml.create(float value * 3785.411784)
        static member toLitres(value : float<usgal>) = l.create(float value * 3.785411784)
        static member toKilolitres(value : float<usgal>) = kl.create(float value * 0.003785411784)
        static member toTeaspoons(value : float<usgal>) = tsp.create(float value * 639.49350947818807296)
        static member toTablespoons(value : float<usgal>) = tbsp.create(float value * 213.16450315939602432)
        static member toQuarts(value : float<usgal>) = qt.create(float value * 3.3306953618655629312)
        static member toPints(value : float<usgal>) = pt.create(float value * 6.6613907237311258624)
        static member toGallons(value : float<usgal>) = gal.create(float value * 0.83267384046639071232)
        static member toFluidOunces(value : float<usgal>) = floz.create(float value * 133.22781447462252544)
        static member toUSTeaspoons(value : float<usgal>) = ustsp.create(float value * 768.)
        static member toUSTablespoons(value : float<usgal>) = ustbsp.create(float value * 256.)
        static member toUSQuarts(value : float<usgal>) = usqt.create(float value * 4.)
        static member toUSPints(value : float<usgal>) = uspt.create(float value * 8.)
        static member toUSFluidOunces(value : float<usgal>) = usfloz.create(float value * 128.)
        static member toUSCups(value : float<usgal>) = uscup.create(float value * 16.)
    and [<Measure>] usfloz = // US fluid ounces
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<usfloz> value
        static member toMillilitres(value : float<usfloz>) = ml.create(float value * 29.573529562499997696)
        static member toLitres(value : float<usfloz>) = l.create(float value * 0.029573529562499997696)
        static member toKilolitres(value : float<usfloz>) = kl.create(float value * 0.0000295735296)
        static member toTeaspoons(value : float<usfloz>) = tsp.create(float value * 4.9960430427983437824)
        static member toTablespoons(value : float<usfloz>) = tbsp.create(float value * 1.6653476809327814656)
        static member toQuarts(value : float<usfloz>) = qt.create(float value * 0.026021057514574708736)
        static member toPints(value : float<usfloz>) = pt.create(float value * 0.052042115029149417472)
        static member toGallons(value : float<usfloz>) = gal.create(float value * 0.006505264378643677184)
        static member toFluidOunces(value : float<usfloz>) = floz.create(float value * 1.0408423005829883904)
        static member toUSTeaspoons(value : float<usfloz>) = ustsp.create(float value * 6.)
        static member toUSTablespoons(value : float<usfloz>) = ustbsp.create(float value * 2.)
        static member toUSQuarts(value : float<usfloz>) = usqt.create(float value / 32.)
        static member toUSPints(value : float<usfloz>) = uspt.create(float value / 16.)
        static member toUSGallons(value : float<usfloz>) = usgal.create(float value / 128.)
        static member toUSCups(value : float<usfloz>) = uscup.create(float value / 8.)
    and [<Measure>] uscup = // US cup
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<uscup> value
        static member toMillilitres(value : float<uscup>) = ml.create(float value * 236.58823649999998976)
        static member toLitres(value : float<uscup>) = l.create(float value * 0.23658823649999998976)
        static member toKilolitres(value : float<uscup>) = kl.create(float value * 0.000236588236499999989)
        static member toTeaspoons(value : float<uscup>) = tsp.create(float value * 39.968344342386753536)
        static member toTablespoons(value : float<uscup>) = tbsp.create(float value * 13.322781447462250496)
        static member toQuarts(value : float<uscup>) = qt.create(float value * 0.20816846011659767808)
        static member toPints(value : float<uscup>) = pt.create(float value * 0.41633692023319535616)
        static member toGallons(value : float<uscup>) = gal.create(float value * 0.052042115029149417472)
        static member toFluidOunces(value : float<uscup>) = floz.create(float value * 8.3267384046639071232)
        static member toUSTeaspoons(value : float<uscup>) = ustsp.create(float value * 48.)
        static member toUSTablespoons(value : float<uscup>) = ustbsp.create(float value * 16.)
        static member toUSQuarts(value : float<uscup>) = usqt.create(float value / 4.)
        static member toUSPints(value : float<uscup>) = uspt.create(float value / 2.)
        static member toUSGallons(value : float<uscup>) = usgal.create(float value / 16.)
        static member toUSFluidOunces(value : float<uscup>) = usfloz.create(float value * 8.)
