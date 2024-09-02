// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterClickhouseConfigQueryCacheArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The maximum number of SELECT query results stored in the cache. Default value: 1024.
        /// </summary>
        [Input("maxEntries")]
        public Input<int>? MaxEntries { get; set; }

        /// <summary>
        /// The maximum size in bytes SELECT query results may have to be saved in the cache. Default value: 1048576 (1 MiB).
        /// </summary>
        [Input("maxEntrySizeInBytes")]
        public Input<int>? MaxEntrySizeInBytes { get; set; }

        /// <summary>
        /// The maximum number of rows SELECT query results may have to be saved in the cache. Default value: 30000000 (30 mil).
        /// </summary>
        [Input("maxEntrySizeInRows")]
        public Input<int>? MaxEntrySizeInRows { get; set; }

        /// <summary>
        /// The maximum cache size in bytes. 0 means the query cache is disabled. Default value: 1073741824 (1 GiB).
        /// </summary>
        [Input("maxSizeInBytes")]
        public Input<int>? MaxSizeInBytes { get; set; }

        public MdbClickhouseClusterClickhouseConfigQueryCacheArgs()
        {
        }
        public static new MdbClickhouseClusterClickhouseConfigQueryCacheArgs Empty => new MdbClickhouseClusterClickhouseConfigQueryCacheArgs();
    }
}
