# FSharp.Units

[![Build status](https://ci.appveyor.com/api/projects/status/goy007ku97j9iog6?svg=true)](https://ci.appveyor.com/project/putridparrot/fsharp-units)

Currently includes Mass, Length and Temperature units of measure.

The main aim for this project was to produce conversion functions for the various mass units, lengths units and temperature units and at the same time implement various units of measure.

### Example

let fahrenheit = C.toFahrenheit 12.<C>

let celsius = C.create someValue

Each unit of measure then includes functions to convert to each for example, converting each Temperature unit of measure to each other Temperature - it also includes a function to take a value and apply a unit of measure to it.

### Temperature

Includes units of measure, Celsius (C), Fahrenheit (F) and Kelvin (K). The create function simply turns a floating point value into one with a unit of measure applied. 

### Mass 

Includes unit of measure for milligrams (mg), grams (g), kilograms (kg), metric tonne (tonne), ounces (oz), pounds (lb), stones (stone).

### Length

Includes unit of measure millimetres (mm), centimetres (cm), metres (m), kilometre (km), inch (inch), feet (ft), yard (yard) mile(mile) and nautical miles (NM).

### Volume

Includes unit of measure millilitre (ml), litre (l), kilolitre (kl), imperial teaspoon (tsp), imperial tablespoon (tbsp), imperial quart (qt), imperial pint (pt), imperial gallon (gal), imperial fluid ounces (floz), Us teaspoon (ustsp), US tablespoon (ustbsp), US quart (usqt), US pint (uspt), US gallon (usgal), US fluid ounces (usfloz), US cup (uscup)

### Health

Includes unit of measure beats per minute (bpm), kilojoules (kJ) and kilocalories (kCal).

### Pressure 

Includes unit of measure atmosphere (atm), pascal (Pa), torr (Torr), pounds per square inch (psi), bar (b)

### Magnetomotive Force

Includes unit of measure Gilbert (Gi) and Ampere turn (AT)