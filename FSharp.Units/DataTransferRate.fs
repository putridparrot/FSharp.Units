namespace FSharp.Units

open Microsoft.FSharp.Core

module DataTransferRate =

    /// Bits Per Second (bps) units
    [<Measure>]
    type bps =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<bps> value
        /// Converts the supplied Bits Per Second value to KiloBits Per Second
        static member toKiloBitsPerSecond(value : float<bps>) = kbps.create(float value / 1000.)
        /// Converts the supplied Bits Per Second value to MegaBits Per Second
        static member toMegaBitsPerSecond(value : float<bps>) = Mbps.create(float value / 1e+6)
        /// Converts the supplied Bits Per Second value to GigaBits Per Second
        static member toGigaBitsPerSecond(value : float<bps>) = Gbps.create(float value / 1e+9)
        /// Converts the supplied Bits Per Second value to TeraBits Per Second
        static member toTeraBitsPerSecond(value : float<bps>) = Tbps.create(float value / 1e+12)
        /// Converts the supplied Bits Per Second value to KiloBytes Per Second
        static member toKiloBytesPerSecond(value : float<bps>) = kBps.create(float value / 8000.)
        /// Converts the supplied Bits Per Second value to MegaBytes Per Second
        static member toMegaBytesPerSecond(value : float<bps>) = MBps.create(float value / 8e+6)
        /// Converts the supplied Bits Per Second value to GigaBytes Per Second
        static member toGigaBytesPerSecond(value : float<bps>) = GBps.create(float value / 8e+9)
        /// Converts the supplied Bits Per Second value to TeraBytes Per Second
        static member toTeraBytesPerSecond(value : float<bps>) = TBps.create(float value / 8e+12)
        /// Converts the supplied Bits Per Second value to Kibibits Per Second
        static member toKibibitsPerSecond(value : float<bps>) = Kibitps.create(float value / 1024.)
        /// Converts the supplied Bits Per Second value to Mebibits Per Second
        static member toMebibitsPerSecond(value : float<bps>) = Mibit.create(float value / 1048576.)
    and /// GigaBits Per Second (Gbps) units
        [<Measure>] Gbps =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Gbps> value
        /// Converts the supplied GigaBits Per Second value to Bits Per Second
        static member toBitsPerSecond(value : float<Gbps>) = bps.create(float value * 1e+9)
        /// Converts the supplied GigaBits Per Second value to KiloBits Per Second
        static member toKiloBitsPerSecond(value : float<Gbps>) = kbps.create(float value * 1e+6)
        /// Converts the supplied GigaBits Per Second value to MegaBits Per Second
        static member toMegaBitsPerSecond(value : float<Gbps>) = Mbps.create(float value * 1000.)
        /// Converts the supplied GigaBits Per Second value to TeraBits Per Second
        static member toTeraBitsPerSecond(value : float<Gbps>) = Tbps.create(float value / 1000.)
        /// Converts the supplied GigaBits Per Second value to KiloBytes Per Second
        static member toKiloBytesPerSecond(value : float<Gbps>) = kBps.create(float value * 125000.)
        /// Converts the supplied GigaBits Per Second value to MegaBytes Per Second
        static member toMegaBytesPerSecond(value : float<Gbps>) = MBps.create(float value * 125.)
        /// Converts the supplied GigaBits Per Second value to GigaBytes Per Second
        static member toGigaBytesPerSecond(value : float<Gbps>) = GBps.create(float value / 8.)
        /// Converts the supplied GigaBits Per Second value to TeraBytes Per Second
        static member toTeraBytesPerSecond(value : float<Gbps>) = TBps.create(float value / 8000.)
        /// Converts the supplied GigaBits Per Second value to Kibibits Per Second
        static member toKibibitsPerSecond(value : float<Gbps>) = Kibitps.create(float value * 976563.)
        /// Converts the supplied GigaBits Per Second value to Mebibits Per Second
        static member toMebibitsPerSecond(value : float<Gbps>) = Mibit.create(float value * 954.)
    and /// GigaBytes Per Second (GBps) units
        [<Measure>] GBps =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<GBps> value
        /// Converts the supplied GigaBytes Per Second value to Bits Per Second
        static member toBitsPerSecond(value : float<GBps>) = bps.create(float value * 8e+9)
        /// Converts the supplied GigaBytes Per Second value to KiloBits Per Second
        static member toKiloBitsPerSecond(value : float<GBps>) = kbps.create(float value * 8e+6)
        /// Converts the supplied GigaBytes Per Second value to MegaBits Per Second
        static member toMegaBitsPerSecond(value : float<GBps>) = Mbps.create(float value * 8000.)
        /// Converts the supplied GigaBytes Per Second value to GigaBits Per Second
        static member toGigaBitsPerSecond(value : float<GBps>) = Gbps.create(float value * 8.)
        /// Converts the supplied GigaBytes Per Second value to TeraBits Per Second
        static member toTeraBitsPerSecond(value : float<GBps>) = Tbps.create(float value / 125.)
        /// Converts the supplied GigaBytes Per Second value to KiloBytes Per Second
        static member toKiloBytesPerSecond(value : float<GBps>) = kBps.create(float value * 1e+6)
        /// Converts the supplied GigaBytes Per Second value to MegaBytes Per Second
        static member toMegaBytesPerSecond(value : float<GBps>) = MBps.create(float value * 1000.)
        /// Converts the supplied GigaBytes Per Second value to TeraBytes Per Second
        static member toTeraBytesPerSecond(value : float<GBps>) = TBps.create(float value / 1000.)
        /// Converts the supplied GigaBytes Per Second value to Kibibits Per Second
        static member toKibibitsPerSecond(value : float<GBps>) = Kibitps.create(float value * 7812500.0)
        /// Converts the supplied GigaBytes Per Second value to Mebibits Per Second
        static member toMebibitsPerSecond(value : float<GBps>) = Mibit.create(float value * 7629.39)
    and /// Kibibits Per Second (Kibitps) units
        [<Measure>] Kibitps =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Kibitps> value
        /// Converts the supplied Kibibits Per Second value to Bits Per Second
        static member toBitsPerSecond(value : float<Kibitps>) = bps.create(float value * 1024.)
        /// Converts the supplied Kibibits Per Second value to KiloBits Per Second
        static member toKiloBitsPerSecond(value : float<Kibitps>) = kbps.create(float value * 1.024)
        /// Converts the supplied Kibibits Per Second value to MegaBits Per Second
        static member toMegaBitsPerSecond(value : float<Kibitps>) = Mbps.create(float value / 976.563)
        /// Converts the supplied Kibibits Per Second value to GigaBits Per Second
        static member toGigaBitsPerSecond(value : float<Kibitps>) = Gbps.create(float value / 976562.)
        /// Converts the supplied Kibibits Per Second value to TeraBits Per Second
        static member toTeraBitsPerSecond(value : float<Kibitps>) = Tbps.create(float value / 976562500.0)
        /// Converts the supplied Kibibits Per Second value to KiloBytes Per Second
        static member toKiloBytesPerSecond(value : float<Kibitps>) = kBps.create(float value / 7.812)
        /// Converts the supplied Kibibits Per Second value to MegaBytes Per Second
        static member toMegaBytesPerSecond(value : float<Kibitps>) = MBps.create(float value / 7812.5)
        /// Converts the supplied Kibibits Per Second value to GigaBytes Per Second
        static member toGigaBytesPerSecond(value : float<Kibitps>) = GBps.create(float value / 7812500.0)
        /// Converts the supplied Kibibits Per Second value to TeraBytes Per Second
        static member toTeraBytesPerSecond(value : float<Kibitps>) = TBps.create(float value / 7812500000.0)
        /// Converts the supplied Kibibits Per Second value to Mebibits Per Second
        static member toMebibitsPerSecond(value : float<Kibitps>) = Mibit.create(float value / 1024.)
    and /// KiloBits Per Second (kbps) units
        [<Measure>] kbps =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kbps> value
        /// Converts the supplied KiloBits Per Second value to Bits Per Second
        static member toBitsPerSecond(value : float<kbps>) = bps.create(float value * 1000.)
        /// Converts the supplied KiloBits Per Second value to MegaBits Per Second
        static member toMegaBitsPerSecond(value : float<kbps>) = Mbps.create(float value / 1000.)
        /// Converts the supplied KiloBits Per Second value to GigaBits Per Second
        static member toGigaBitsPerSecond(value : float<kbps>) = Gbps.create(float value / 1e+6)
        /// Converts the supplied KiloBits Per Second value to TeraBits Per Second
        static member toTeraBitsPerSecond(value : float<kbps>) = Tbps.create(float value / 1e+9)
        /// Converts the supplied KiloBits Per Second value to KiloBytes Per Second
        static member toKiloBytesPerSecond(value : float<kbps>) = kBps.create(float value / 8.)
        /// Converts the supplied KiloBits Per Second value to MegaBytes Per Second
        static member toMegaBytesPerSecond(value : float<kbps>) = MBps.create(float value / 8000.)
        /// Converts the supplied KiloBits Per Second value to GigaBytes Per Second
        static member toGigaBytesPerSecond(value : float<kbps>) = GBps.create(float value / 8e+6)
        /// Converts the supplied KiloBits Per Second value to TeraBytes Per Second
        static member toTeraBytesPerSecond(value : float<kbps>) = TBps.create(float value / 8e+9)
        /// Converts the supplied KiloBits Per Second value to Kibibits Per Second
        static member toKibibitsPerSecond(value : float<kbps>) = Kibitps.create(float value / 1.024)
        /// Converts the supplied KiloBits Per Second value to Mebibits Per Second
        static member toMebibitsPerSecond(value : float<kbps>) = Mibit.create(float value / 1048.58)
    and /// KiloBytes Per Second (kBps) units
        [<Measure>] kBps =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<kBps> value
        /// Converts the supplied KiloBytes Per Second value to Bits Per Second
        static member toBitsPerSecond(value : float<kBps>) = bps.create(float value * 8000.)
        /// Converts the supplied KiloBytes Per Second value to KiloBits Per Second
        static member toKiloBitsPerSecond(value : float<kBps>) = kbps.create(float value * 8.)
        /// Converts the supplied KiloBytes Per Second value to MegaBits Per Second
        static member toMegaBitsPerSecond(value : float<kBps>) = Mbps.create(float value / 125.)
        /// Converts the supplied KiloBytes Per Second value to GigaBits Per Second
        static member toGigaBitsPerSecond(value : float<kBps>) = Gbps.create(float value / 125000.)
        /// Converts the supplied KiloBytes Per Second value to TeraBits Per Second
        static member toTeraBitsPerSecond(value : float<kBps>) = Tbps.create(float value / 1.25e+8)
        /// Converts the supplied KiloBytes Per Second value to MegaBytes Per Second
        static member toMegaBytesPerSecond(value : float<kBps>) = MBps.create(float value / 1000.)
        /// Converts the supplied KiloBytes Per Second value to GigaBytes Per Second
        static member toGigaBytesPerSecond(value : float<kBps>) = GBps.create(float value / 1e+6)
        /// Converts the supplied KiloBytes Per Second value to TeraBytes Per Second
        static member toTeraBytesPerSecond(value : float<kBps>) = TBps.create(float value / 1e+9)
        /// Converts the supplied KiloBytes Per Second value to Kibibits Per Second
        static member toKibibitsPerSecond(value : float<kBps>) = Kibitps.create(float value * 7.812)
        /// Converts the supplied KiloBytes Per Second value to Mebibits Per Second
        static member toMebibitsPerSecond(value : float<kBps>) = Mibit.create(float value * 0.00762939)
    and /// Mebibits Per Second (Mibit) units
        [<Measure>] Mibit =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Mibit> value
        /// Converts the supplied Mebibits Per Second value to Bits Per Second
        static member toBitsPerSecond(value : float<Mibit>) = bps.create(float value * 1048576.)
        /// Converts the supplied Mebibits Per Second value to KiloBits Per Second
        static member toKiloBitsPerSecond(value : float<Mibit>) = kbps.create(float value * 1048.58)
        /// Converts the supplied Mebibits Per Second value to MegaBits Per Second
        static member toMegaBitsPerSecond(value : float<Mibit>) = Mbps.create(float value * 1.04858)
        /// Converts the supplied Mebibits Per Second value to GigaBits Per Second
        static member toGigaBitsPerSecond(value : float<Mibit>) = Gbps.create(float value / 954.)
        /// Converts the supplied Mebibits Per Second value to TeraBits Per Second
        static member toTeraBitsPerSecond(value : float<Mibit>) = Tbps.create(float value / 953674.)
        /// Converts the supplied Mebibits Per Second value to KiloBytes Per Second
        static member toKiloBytesPerSecond(value : float<Mibit>) = kBps.create(float value / 0.00762939)
        /// Converts the supplied Mebibits Per Second value to MegaBytes Per Second
        static member toMegaBytesPerSecond(value : float<Mibit>) = MBps.create(float value / 7.62939)
        /// Converts the supplied Mebibits Per Second value to GigaBytes Per Second
        static member toGigaBytesPerSecond(value : float<Mibit>) = GBps.create(float value / 7629.39)
        /// Converts the supplied Mebibits Per Second value to TeraBytes Per Second
        static member toTeraBytesPerSecond(value : float<Mibit>) = TBps.create(float value * 0.000000131072)
        /// Converts the supplied Mebibits Per Second value to Kibibits Per Second
        static member toKibibitsPerSecond(value : float<Mibit>) = Kibitps.create(float value * 1024.)
    and /// MegaBits Per Second (Mbps) units
        [<Measure>] Mbps =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Mbps> value
        /// Converts the supplied MegaBits Per Second value to Bits Per Second
        static member toBitsPerSecond(value : float<Mbps>) = bps.create(float value * 1e+6)
        /// Converts the supplied MegaBits Per Second value to KiloBits Per Second
        static member toKiloBitsPerSecond(value : float<Mbps>) = kbps.create(float value * 1000.)
        /// Converts the supplied MegaBits Per Second value to GigaBits Per Second
        static member toGigaBitsPerSecond(value : float<Mbps>) = Gbps.create(float value / 1000.)
        /// Converts the supplied MegaBits Per Second value to TeraBits Per Second
        static member toTeraBitsPerSecond(value : float<Mbps>) = Tbps.create(float value / 1e+6)
        /// Converts the supplied MegaBits Per Second value to KiloBytes Per Second
        static member toKiloBytesPerSecond(value : float<Mbps>) = kBps.create(float value * 125.)
        /// Converts the supplied MegaBits Per Second value to MegaBytes Per Second
        static member toMegaBytesPerSecond(value : float<Mbps>) = MBps.create(float value / 8.)
        /// Converts the supplied MegaBits Per Second value to GigaBytes Per Second
        static member toGigaBytesPerSecond(value : float<Mbps>) = GBps.create(float value / 8000.)
        /// Converts the supplied MegaBits Per Second value to TeraBytes Per Second
        static member toTeraBytesPerSecond(value : float<Mbps>) = TBps.create(float value / 8e+6)
        /// Converts the supplied MegaBits Per Second value to Kibibits Per Second
        static member toKibibitsPerSecond(value : float<Mbps>) = Kibitps.create(float value * 976.563)
        /// Converts the supplied MegaBits Per Second value to Mebibits Per Second
        static member toMebibitsPerSecond(value : float<Mbps>) = Mibit.create(float value * 0.953674)
    and /// MegaBytes Per Second (MBps) units
        [<Measure>] MBps =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<MBps> value
        /// Converts the supplied MegaBytes Per Second value to Bits Per Second
        static member toBitsPerSecond(value : float<MBps>) = bps.create(float value * 8e+6)
        /// Converts the supplied MegaBytes Per Second value to KiloBits Per Second
        static member toKiloBitsPerSecond(value : float<MBps>) = kbps.create(float value * 8000.)
        /// Converts the supplied MegaBytes Per Second value to MegaBits Per Second
        static member toMegaBitsPerSecond(value : float<MBps>) = Mbps.create(float value * 8.)
        /// Converts the supplied MegaBytes Per Second value to GigaBits Per Second
        static member toGigaBitsPerSecond(value : float<MBps>) = Gbps.create(float value / 125.)
        /// Converts the supplied MegaBytes Per Second value to TeraBits Per Second
        static member toTeraBitsPerSecond(value : float<MBps>) = Tbps.create(float value / 125000.)
        /// Converts the supplied MegaBytes Per Second value to KiloBytes Per Second
        static member toKiloBytesPerSecond(value : float<MBps>) = kBps.create(float value * 1000.)
        /// Converts the supplied MegaBytes Per Second value to GigaBytes Per Second
        static member toGigaBytesPerSecond(value : float<MBps>) = GBps.create(float value / 1000.)
        /// Converts the supplied MegaBytes Per Second value to TeraBytes Per Second
        static member toTeraBytesPerSecond(value : float<MBps>) = TBps.create(float value / 1e+6)
        /// Converts the supplied MegaBytes Per Second value to Kibibits Per Second
        static member toKibibitsPerSecond(value : float<MBps>) = Kibitps.create(float value * 7812.5)
        /// Converts the supplied MegaBytes Per Second value to Mebibits Per Second
        static member toMebibitsPerSecond(value : float<MBps>) = Mibit.create(float value * 7.62939)
    and /// TeraBits Per Second (Tbps) units
        [<Measure>] Tbps =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<Tbps> value
        /// Converts the supplied TeraBits Per Second value to Bits Per Second
        static member toBitsPerSecond(value : float<Tbps>) = bps.create(float value * 1e+12)
        /// Converts the supplied TeraBits Per Second value to KiloBits Per Second
        static member toKiloBitsPerSecond(value : float<Tbps>) = kbps.create(float value * 1e+9)
        /// Converts the supplied TeraBits Per Second value to MegaBits Per Second
        static member toMegaBitsPerSecond(value : float<Tbps>) = Mbps.create(float value * 1e+6)
        /// Converts the supplied TeraBits Per Second value to GigaBits Per Second
        static member toGigaBitsPerSecond(value : float<Tbps>) = Gbps.create(float value * 1000.)
        /// Converts the supplied TeraBits Per Second value to KiloBytes Per Second
        static member toKiloBytesPerSecond(value : float<Tbps>) = kBps.create(float value * 1.25e+8)
        /// Converts the supplied TeraBits Per Second value to MegaBytes Per Second
        static member toMegaBytesPerSecond(value : float<Tbps>) = MBps.create(float value * 125000.)
        /// Converts the supplied TeraBits Per Second value to GigaBytes Per Second
        static member toGigaBytesPerSecond(value : float<Tbps>) = GBps.create(float value * 125.)
        /// Converts the supplied TeraBits Per Second value to TeraBytes Per Second
        static member toTeraBytesPerSecond(value : float<Tbps>) = TBps.create(float value / 8.)
        /// Converts the supplied TeraBits Per Second value to Kibibits Per Second
        static member toKibibitsPerSecond(value : float<Tbps>) = Kibitps.create(float value * 976562500.0)
        /// Converts the supplied TeraBits Per Second value to Mebibits Per Second
        static member toMebibitsPerSecond(value : float<Tbps>) = Mibit.create(float value * 953674.)
    and /// TeraBytes Per Second (TBps) units
        [<Measure>] TBps =
        static member create(value : float) = LanguagePrimitives.FloatWithMeasure<TBps> value
        /// Converts the supplied TeraBytes Per Second value to Bits Per Second
        static member toBitsPerSecond(value : float<TBps>) = bps.create(float value * 8e+12)
        /// Converts the supplied TeraBytes Per Second value to KiloBits Per Second
        static member toKiloBitsPerSecond(value : float<TBps>) = kbps.create(float value * 8e+9)
        /// Converts the supplied TeraBytes Per Second value to MegaBits Per Second
        static member toMegaBitsPerSecond(value : float<TBps>) = Mbps.create(float value * 8e+6)
        /// Converts the supplied TeraBytes Per Second value to GigaBits Per Second
        static member toGigaBitsPerSecond(value : float<TBps>) = Gbps.create(float value * 8000.)
        /// Converts the supplied TeraBytes Per Second value to TeraBits Per Second
        static member toTeraBitsPerSecond(value : float<TBps>) = Tbps.create(float value * 8.)
        /// Converts the supplied TeraBytes Per Second value to KiloBytes Per Second
        static member toKiloBytesPerSecond(value : float<TBps>) = kBps.create(float value * 1e+9)
        /// Converts the supplied TeraBytes Per Second value to MegaBytes Per Second
        static member toMegaBytesPerSecond(value : float<TBps>) = MBps.create(float value * 1e+6)
        /// Converts the supplied TeraBytes Per Second value to GigaBytes Per Second
        static member toGigaBytesPerSecond(value : float<TBps>) = GBps.create(float value * 1000.)
        /// Converts the supplied TeraBytes Per Second value to Kibibits Per Second
        static member toKibibitsPerSecond(value : float<TBps>) = Kibitps.create(float value * 7812500000.0)
        /// Converts the supplied TeraBytes Per Second value to Mebibits Per Second
        static member toMebibitsPerSecond(value : float<TBps>) = Mibit.create(float value / 0.000000131072)
