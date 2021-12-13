# FSharp.Units

[![Build FSharp.Units](https://github.com/putridparrot/FSharp.Units/actions/workflows/dotnet-core.yml/badge.svg)](https://github.com/putridparrot/FSharp.Units/actions/workflows/dotnet-core.yml)

Currently includes Mass, Length and Temperature units of measure.

The main aim for this project was to produce conversion functions for the various mass units, lengths units and temperature units and at the same time implement various units of measure.

### Example

let fahrenheit = C.toFahrenheit 12.<C>

let celsius = C.create someValue

Each unit of measure then includes functions to convert to each for example, converting each Temperature unit of measure to each other Temperature - it also includes a function to take a value and apply a unit of measure to it.

### Angle

	* Degrees (deg)
	* Gradians (grad)
	* Milliradians (mrad)
	* Minute Of Arc (arcmin)
	* Radians (rad)
	* Seconds Of Arc (arcseconds)

### Area

	* Acres (acre)
	* Hectares (hectare)
	* Square Feet (feet2)
	* Square Inches (inch2)
	* Square Kilometres (km2)
	* Square Metres (m2)
	* Square Miles (mile2)
	* Square Yards (yard2)

### Data Transfer Rate

	* Bits Per Second (bps)
	* GigaBits Per Second (Gbps)
	* GigaBytes Per Second (GBps)
	* Kibibits Per Second (Kibitps)
	* KiloBits Per Second (kbps)
	* KiloBytes Per Second (kBps)
	* Mebibits Per Second (Mibit)
	* MegaBits Per Second (Mbps)
	* MegaBytes Per Second (MBps)
	* TeraBits Per Second (Tbps)
	* TeraBytes Per Second (TBps)

### Energy

	* Btu (btu)
	* Calories (cal)
	* ElectronVolts (eV)
	* Foot Pounds (ftlb)
	* Joules (J)
	* Kilocalories (kCal)
	* Kilojoules (kJ)
	* Kilowatt Hours (kWh)
	* US Therms (ustherm)
	* Watt Hours (Wh)

### Frequency

	* Gigahertz (GHz)
	* Hertz (Hz)
	* Kilohertz (kHz)
	* Megahertz (MHz)

### Length

	* Centimetres (cm)
	* Feet (ft)
	* Inches (inch)
	* Kilometres (km)
	* Metres (m)
	* Miles (mile)
	* Millimetres (mm)
	* Nautical Miles (NM)
	* Yards (yard)

### Luminous Energy

	* LumenHour (lmh)
	* LumenMinute (lmmin)
	* LumenSecond (lms)
	* Talbot (T)

### Luminous Intensity

	* Candela (cd)
	* Candlepower (Candlepower)
	* Hefnerkerse (HK)
	* Lumen Per Steradian (lmsr)

### Magnetomotive Force

	* Ampere-turns (AT)
	* Gilberts (Gi)

### Mass

	* Grams (g)
	* Kilograms (kg)
	* Milligrams (mg)
	* Ounces (oz)
	* Pounds (lb)
	* Stones (stone)
	* Tonnes (tonne)

### Pressure

	* Atmospheres (atm)
	* Bars (b)
	* Pascals (Pa)
	* Psi (psi)
	* Torrs (Torr)

### Angle

* Degrees (deg)
	* Gradians (grad)
	* Milliradians (mrad)
	* Minute Of Arc (arcmin)
	* Radians (rad)
	* Seconds Of Arc (arcseconds)


### Area

* Acres (acre)
	* Hectares (hectare)
	* Square Feet (feet2)
	* Square Inches (inch2)
	* Square Kilometres (km2)
	* Square Metres (m2)
	* Square Miles (mile2)
	* Square Yards (yard2)


### Data Transfer Rate

* Bits Per Second (bps)
	* GigaBits Per Second (Gbps)
	* GigaBytes Per Second (GBps)
	* Kibibits Per Second (Kibitps)
	* KiloBits Per Second (kbps)
	* KiloBytes Per Second (kBps)
	* Mebibits Per Second (Mibit)
	* MegaBits Per Second (Mbps)
	* MegaBytes Per Second (MBps)
	* TeraBits Per Second (Tbps)
	* TeraBytes Per Second (TBps)


### Energy

* Btu (btu)
	* Calories (cal)
	* ElectronVolts (eV)
	* Foot Pounds (ftlb)
	* Joules (J)
	* Kilocalories (kCal)
	* Kilojoules (kJ)
	* Kilowatt Hours (kWh)
	* US Therms (ustherm)
	* Watt Hours (Wh)


### Frequency

* Gigahertz (GHz)
	* Hertz (Hz)
	* Kilohertz (kHz)
	* Megahertz (MHz)


### Length

* Centimetres (cm)
	* Feet (ft)
	* Inches (inch)
	* Kilometres (km)
	* Metres (m)
	* Miles (mile)
	* Millimetres (mm)
	* Nautical Miles (NM)
	* Yards (yard)


### Luminous Energy

* LumenHour (lmh)
	* LumenMinute (lmmin)
	* LumenSecond (lms)
	* Talbot (T)


### Luminous Intensity

* Candela (cd)
	* Candlepower (Candlepower)
	* Hefnerkerse (HK)
	* Lumen Per Steradian (lmsr)


### Magnetomotive Force

* Ampere-turns (AT)
	* Gilberts (Gi)


### Mass

* Grams (g)
	* Kilograms (kg)
	* Milligrams (mg)
	* Ounces (oz)
	* Pounds (lb)
	* Stones (stone)
	* Tonnes (tonne)


### Pressure

* Atmospheres (atm)
	* Bars (b)
	* Pascals (Pa)
	* Psi (psi)
	* Torrs (Torr)


### Angle

* Degrees (deg)	* Gradians (grad)	* Milliradians (mrad)	* Minute Of Arc (arcmin)	* Radians (rad)	* Seconds Of Arc (arcseconds)

### Area

* Acres (acre)	* Hectares (hectare)	* Square Feet (feet2)	* Square Inches (inch2)	* Square Kilometres (km2)	* Square Metres (m2)	* Square Miles (mile2)	* Square Yards (yard2)

### Data Transfer Rate

* Bits Per Second (bps)	* GigaBits Per Second (Gbps)	* GigaBytes Per Second (GBps)	* Kibibits Per Second (Kibitps)	* KiloBits Per Second (kbps)	* KiloBytes Per Second (kBps)	* Mebibits Per Second (Mibit)	* MegaBits Per Second (Mbps)	* MegaBytes Per Second (MBps)	* TeraBits Per Second (Tbps)	* TeraBytes Per Second (TBps)

### Energy

* Btu (btu)	* Calories (cal)	* ElectronVolts (eV)	* Foot Pounds (ftlb)	* Joules (J)	* Kilocalories (kCal)	* Kilojoules (kJ)	* Kilowatt Hours (kWh)	* US Therms (ustherm)	* Watt Hours (Wh)

### Frequency

* Gigahertz (GHz)	* Hertz (Hz)	* Kilohertz (kHz)	* Megahertz (MHz)

### Length

* Centimetres (cm)	* Feet (ft)	* Inches (inch)	* Kilometres (km)	* Metres (m)	* Miles (mile)	* Millimetres (mm)	* Nautical Miles (NM)	* Yards (yard)

### Luminous Energy

* LumenHour (lmh)	* LumenMinute (lmmin)	* LumenSecond (lms)	* Talbot (T)

### Luminous Intensity

* Candela (cd)	* Candlepower (Candlepower)	* Hefnerkerse (HK)	* Lumen Per Steradian (lmsr)

### Magnetomotive Force

* Ampere-turns (AT)	* Gilberts (Gi)

### Mass

* Grams (g)	* Kilograms (kg)	* Milligrams (mg)	* Ounces (oz)	* Pounds (lb)	* Stones (stone)	* Tonnes (tonne)

### Pressure

* Atmospheres (atm)	* Bars (b)	* Pascals (Pa)	* Psi (psi)	* Torrs (Torr)

### Angle

Degrees (deg), Gradians (grad), Milliradians (mrad), Minute Of Arc (arcmin), Radians (rad), Seconds Of Arc (arcseconds)


### Area

Acres (acre), Hectares (hectare), Square Feet (feet2), Square Inches (inch2), Square Kilometres (km2), Square Metres (m2), Square Miles (mile2), Square Yards (yard2)


### Data Transfer Rate

Bits Per Second (bps), GigaBits Per Second (Gbps), GigaBytes Per Second (GBps), Kibibits Per Second (Kibitps), KiloBits Per Second (kbps), KiloBytes Per Second (kBps), Mebibits Per Second (Mibit), MegaBits Per Second (Mbps), MegaBytes Per Second (MBps), TeraBits Per Second (Tbps), TeraBytes Per Second (TBps)


### Energy

Btu (btu), Calories (cal), ElectronVolts (eV), Foot Pounds (ftlb), Joules (J), Kilocalories (kCal), Kilojoules (kJ), Kilowatt Hours (kWh), US Therms (ustherm), Watt Hours (Wh)


### Frequency

Gigahertz (GHz), Hertz (Hz), Kilohertz (kHz), Megahertz (MHz)


### Length

Centimetres (cm), Feet (ft), Inches (inch), Kilometres (km), Metres (m), Miles (mile), Millimetres (mm), Nautical Miles (NM), Yards (yard)


### Luminous Energy

LumenHour (lmh), LumenMinute (lmmin), LumenSecond (lms), Talbot (T)


### Luminous Intensity

Candela (cd), Candlepower (Candlepower), Hefnerkerse (HK), Lumen Per Steradian (lmsr)


### Magnetomotive Force

Ampere-turns (AT), Gilberts (Gi)


### Mass

Grams (g), Kilograms (kg), Milligrams (mg), Ounces (oz), Pounds (lb), Stones (stone), Tonnes (tonne)


### Pressure

Atmospheres (atm), Bars (b), Pascals (Pa), Psi (psi), Torrs (Torr)


### Speed

Feet Per Second (fps), Kilometres Per Hour (kph), Knots (knot), Metres Per Second (mps), Miles Per Hour (mph)


### Temperature

Celsius (C), Fahrenheit (F), Kelvin (K), Rankine (R)


### Time

Centuries (century), Days (day), Decades (decade), Hours (hour), Minutes (minute), Months (month), Seconds (second), Weeks (week), Years (year)


### Volume

Fluid Ounces (floz), Gallons (gal), Kilolitres (kl), Litres (l), Millilitres (ml), Pints (pt), Quarts (qt), Tablespoons (tbsp), Teaspoons (tsp), US Cups (uscup), US Fluid Ounces (usfloz), US Gallons (usgal), US Pints (uspt), US Quarts (usqt), US Tablespoons (ustbsp), US Teaspoons (ustsp)



### Speed

* Feet Per Second (fps)	* Kilometres Per Hour (kph)	* Knots (knot)	* Metres Per Second (mps)	* Miles Per Hour (mph)

### Temperature

* Celsius (C)	* Fahrenheit (F)	* Kelvin (K)	* Rankine (R)

### Time

* Centuries (century)	* Days (day)	* Decades (decade)	* Hours (hour)	* Minutes (minute)	* Months (month)	* Seconds (second)	* Weeks (week)	* Years (year)

### Volume

* Fluid Ounces (floz)	* Gallons (gal)	* Kilolitres (kl)	* Litres (l)	* Millilitres (ml)	* Pints (pt)	* Quarts (qt)	* Tablespoons (tbsp)	* Teaspoons (tsp)	* US Cups (uscup)	* US Fluid Ounces (usfloz)	* US Gallons (usgal)	* US Pints (uspt)	* US Quarts (usqt)	* US Tablespoons (ustbsp)	* US Teaspoons (ustsp)


### Speed

* Feet Per Second (fps)
	* Kilometres Per Hour (kph)
	* Knots (knot)
	* Metres Per Second (mps)
	* Miles Per Hour (mph)


### Temperature

* Celsius (C)
	* Fahrenheit (F)
	* Kelvin (K)
	* Rankine (R)


### Time

* Centuries (century)
	* Days (day)
	* Decades (decade)
	* Hours (hour)
	* Minutes (minute)
	* Months (month)
	* Seconds (second)
	* Weeks (week)
	* Years (year)


### Volume

* Fluid Ounces (floz)
	* Gallons (gal)
	* Kilolitres (kl)
	* Litres (l)
	* Millilitres (ml)
	* Pints (pt)
	* Quarts (qt)
	* Tablespoons (tbsp)
	* Teaspoons (tsp)
	* US Cups (uscup)
	* US Fluid Ounces (usfloz)
	* US Gallons (usgal)
	* US Pints (uspt)
	* US Quarts (usqt)
	* US Tablespoons (ustbsp)
	* US Teaspoons (ustsp)



### Speed

	* Feet Per Second (fps)
	* Kilometres Per Hour (kph)
	* Knots (knot)
	* Metres Per Second (mps)
	* Miles Per Hour (mph)

### Temperature

	* Celsius (C)
	* Fahrenheit (F)
	* Kelvin (K)
	* Rankine (R)

### Time

	* Centuries (century)
	* Days (day)
	* Decades (decade)
	* Hours (hour)
	* Minutes (minute)
	* Months (month)
	* Seconds (second)
	* Weeks (week)
	* Years (year)

### Volume

	* Fluid Ounces (floz)
	* Gallons (gal)
	* Kilolitres (kl)
	* Litres (l)
	* Millilitres (ml)
	* Pints (pt)
	* Quarts (qt)
	* Tablespoons (tbsp)
	* Teaspoons (tsp)
	* US Cups (uscup)
	* US Fluid Ounces (usfloz)
	* US Gallons (usgal)
	* US Pints (uspt)
	* US Quarts (usqt)
	* US Tablespoons (ustbsp)
	* US Teaspoons (ustsp)

