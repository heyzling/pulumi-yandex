// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MonitoringDashboardWidgetChartVisualizationSettingYaxisSettingLeftArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Max value in extended number format or empty.
        /// </summary>
        [Input("max")]
        public Input<string>? Max { get; set; }

        /// <summary>
        /// Min value in extended number format or empty.
        /// </summary>
        [Input("min")]
        public Input<string>? Min { get; set; }

        /// <summary>
        /// Tick value precision (null as default, 0-7 in other cases).
        /// </summary>
        [Input("precision")]
        public Input<int>? Precision { get; set; }

        /// <summary>
        /// Title or empty.
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        /// <summary>
        /// Type. Values:
        /// - YAXIS_TYPE_UNSPECIFIED: Not specified (linear by default).
        /// - YAXIS_TYPE_LINEAR: Linear.
        /// - YAXIS_TYPE_LOGARITHMIC: Logarithmic.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Unit format. Values:
        /// - UNIT_NONE: Misc. None (show tick values as-is).
        /// - UNIT_COUNT: Count.
        /// - UNIT_PERCENT: Percent (0-100).
        /// - UNIT_PERCENT_UNIT: Percent (0-1).
        /// - UNIT_NANOSECONDS: Time. Nanoseconds (ns).
        /// - UNIT_MICROSECONDS: Microseconds (µs).
        /// - UNIT_MILLISECONDS: Milliseconds (ms).
        /// - UNIT_SECONDS: Seconds (s).
        /// - UNIT_MINUTES: Minutes (m).
        /// - UNIT_HOURS: Hours (h).
        /// - UNIT_DAYS: Days (d).
        /// - UNIT_BITS_SI: Data (SI). Bits (SI).
        /// - UNIT_BYTES_SI: Bytes (SI).
        /// - UNIT_KILOBYTES: Kilobytes (KB).
        /// - UNIT_MEGABYTES: Megabytes (MB).
        /// - UNIT_GIGABYTES: Gigabytes (GB).
        /// - UNIT_TERABYTES: Terabytes (TB)
        /// - UNIT_PETABYTES: Petabytes (PB).
        /// - UNIT_EXABYTES: Exabytes (EB).
        /// - UNIT_BITS_IEC: Data (IEC). Bits (IEC).
        /// - UNIT_BYTES_IEC: Bytes (IEC).
        /// - UNIT_KIBIBYTES: Kibibytes (KiB).
        /// - UNIT_MEBIBYTES: Mebibytes (MiB).
        /// - UNIT_GIBIBYTES: Gigibytes (GiB).
        /// - UNIT_TEBIBYTES: Tebibytes (TiB).
        /// - UNIT_PEBIBYTES: Pebibytes (PiB).
        /// - UNIT_EXBIBYTES: Exbibytes (EiB).
        /// - UNIT_REQUESTS_PER_SECOND: Throughput. Requests per second (reqps).
        /// - UNIT_OPERATIONS_PER_SECOND: Operations per second (ops).
        /// - UNIT_WRITES_PER_SECOND: Writes per second (wps).
        /// - UNIT_READS_PER_SECOND: Reads per second (rps).
        /// - UNIT_PACKETS_PER_SECOND: Packets per second (pps).
        /// - UNIT_IO_OPERATIONS_PER_SECOND: IO operations per second (iops).
        /// - UNIT_COUNTS_PER_SECOND: Counts per second (counts/sec).
        /// - UNIT_BITS_SI_PER_SECOND: Data Rate (SI). Bits (SI) per second (bits/sec).
        /// - UNIT_BYTES_SI_PER_SECOND: Bytes (SI) per second (bytes/sec).
        /// - UNIT_KILOBITS_PER_SECOND: Kilobits per second (KBits/sec).
        /// - UNIT_KILOBYTES_PER_SECOND: Kilobytes per second (KB/sec).
        /// - UNIT_MEGABITS_PER_SECOND: Megabits per second (MBits/sec).
        /// - UNIT_MEGABYTES_PER_SECOND: Megabytes per second (MB/sec).
        /// - UNIT_GIGABITS_PER_SECOND: Gigabits per second (GBits/sec).
        /// - UNIT_GIGABYTES_PER_SECOND: Gigabytes per second (GB/sec).
        /// - UNIT_TERABITS_PER_SECOND: Terabits per second (TBits/sec).
        /// - UNIT_TERABYTES_PER_SECOND: Terabytes per second (TB/sec).
        /// - UNIT_PETABITS_PER_SECOND: Petabits per second (Pbits/sec).
        /// - UNIT_PETABYTES_PER_SECOND: Petabytes per second (PB/sec).
        /// - UNIT_BITS_IEC_PER_SECOND: Data Rate (IEC). Bits (IEC) per second (bits/sec).
        /// - UNIT_BYTES_IEC_PER_SECOND: Bytes (IEC) per second (bytes/sec).
        /// - UNIT_KIBIBITS_PER_SECOND: Kibibits per second (KiBits/sec).
        /// - UNIT_KIBIBYTES_PER_SECOND: Kibibytes per second (KiB/sec).
        /// - UNIT_MEBIBITS_PER_SECOND: Mebibits per second (MiBits/sec).
        /// - UNIT_MEBIBYTES_PER_SECOND: Mebibytes per second (MiB/sec).
        /// - UNIT_GIBIBITS_PER_SECOND: Gibibits per second (GiBits/sec).
        /// - UNIT_GIBIBYTES_PER_SECOND: Gibibytes per second (GiB/sec).
        /// - UNIT_TEBIBITS_PER_SECOND: Tebibits per second (TiBits/sec).
        /// - UNIT_TEBIBYTES_PER_SECOND: Tebibytes per second (TiB/sec).
        /// - UNIT_PEBIBITS_PER_SECOND: Pebibits per second (PiBits/sec).
        /// - UNIT_PEBIBYTES_PER_SECOND: Pebibytes per second (PiB/sec).
        /// - UNIT_DATETIME_UTC: Date &amp; time. Datetime (UTC).
        /// - UNIT_DATETIME_LOCAL: Datetime (local).
        /// - UNIT_HERTZ: Frequency. Hertz (Hz).
        /// - UNIT_KILOHERTZ: Kilohertz (KHz).
        /// - UNIT_MEGAHERTZ: Megahertz (MHz).
        /// - UNIT_GIGAHERTZ: Gigahertz (GHz).
        /// - UNIT_DOLLAR: Currency. Dollar.
        /// - UNIT_EURO: Euro.
        /// - UNIT_ROUBLE: Rouble.
        /// - UNIT_CELSIUS: Temperature. Celsius (°C).
        /// - UNIT_FAHRENHEIT: Fahrenheit (°F).
        /// - UNIT_KELVIN: Kelvin (K).
        /// - UNIT_FLOP_PER_SECOND: Computation. Flop per second (FLOP/sec).
        /// - UNIT_KILOFLOP_PER_SECOND: Kiloflop per second (KFLOP/sec).
        /// - UNIT_MEGAFLOP_PER_SECOND: Megaflop per second (MFLOP/sec).
        /// - UNIT_GIGAFLOP_PER_SECOND: Gigaflop per second (GFLOP/sec).
        /// - UNIT_PETAFLOP_PER_SECOND: Petaflop per second (PFLOP/sec).
        /// - UNIT_EXAFLOP_PER_SECOND: Exaflop per second (EFLOP/sec).
        /// - UNIT_METERS_PER_SECOND: Velocity. Meters per second (m/sec).
        /// - UNIT_KILOMETERS_PER_HOUR: Kilometers per hour (km/h).
        /// - UNIT_MILES_PER_HOUR: Miles per hour (mi/h).
        /// - UNIT_MILLIMETER: Length. Millimeter.
        /// - UNIT_CENTIMETER: Centimeter.
        /// - UNIT_METER: Meter.
        /// - UNIT_KILOMETER: Kilometer.
        /// - UNIT_MILE: Mile.
        /// - UNIT_PPM: Concentration. Parts per million (ppm).
        /// - UNIT_EVENTS_PER_SECOND: Events per second
        /// - UNIT_PACKETS: Packets
        /// - UNIT_DBM: dBm (dbm)
        /// - UNIT_VIRTUAL_CPU: Virtual CPU cores based on CPU time (vcpu)
        /// - UNIT_MESSAGES_PER_SECOND: Messages per second (mps)
        /// </summary>
        [Input("unitFormat")]
        public Input<string>? UnitFormat { get; set; }

        public MonitoringDashboardWidgetChartVisualizationSettingYaxisSettingLeftArgs()
        {
        }
        public static new MonitoringDashboardWidgetChartVisualizationSettingYaxisSettingLeftArgs Empty => new MonitoringDashboardWidgetChartVisualizationSettingYaxisSettingLeftArgs();
    }
}