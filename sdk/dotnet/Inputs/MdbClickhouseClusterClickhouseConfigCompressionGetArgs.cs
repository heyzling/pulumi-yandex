// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterClickhouseConfigCompressionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Compression level for `ZSTD` method.
        /// </summary>
        [Input("level")]
        public Input<int>? Level { get; set; }

        /// <summary>
        /// Method: Compression method. Two methods are available: LZ4 and zstd.
        /// </summary>
        [Input("method", required: true)]
        public Input<string> Method { get; set; } = null!;

        /// <summary>
        /// Min part size: Minimum size (in bytes) of a data part in a table. ClickHouse only applies the rule to tables with data parts greater than or equal to the Min part size value.
        /// </summary>
        [Input("minPartSize", required: true)]
        public Input<int> MinPartSize { get; set; } = null!;

        /// <summary>
        /// Min part size ratio: Minimum table part size to total table size ratio. ClickHouse only applies the rule to tables in which this ratio is greater than or equal to the Min part size ratio value.
        /// </summary>
        [Input("minPartSizeRatio", required: true)]
        public Input<double> MinPartSizeRatio { get; set; } = null!;

        public MdbClickhouseClusterClickhouseConfigCompressionGetArgs()
        {
        }
        public static new MdbClickhouseClusterClickhouseConfigCompressionGetArgs Empty => new MdbClickhouseClusterClickhouseConfigCompressionGetArgs();
    }
}