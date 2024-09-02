// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class MdbClickhouseClusterClickhouseConfigQueryCache
    {
        /// <summary>
        /// The maximum number of SELECT query results stored in the cache. Default value: 1024.
        /// </summary>
        public readonly int? MaxEntries;
        /// <summary>
        /// The maximum size in bytes SELECT query results may have to be saved in the cache. Default value: 1048576 (1 MiB).
        /// </summary>
        public readonly int? MaxEntrySizeInBytes;
        /// <summary>
        /// The maximum number of rows SELECT query results may have to be saved in the cache. Default value: 30000000 (30 mil).
        /// </summary>
        public readonly int? MaxEntrySizeInRows;
        /// <summary>
        /// The maximum cache size in bytes. 0 means the query cache is disabled. Default value: 1073741824 (1 GiB).
        /// </summary>
        public readonly int? MaxSizeInBytes;

        [OutputConstructor]
        private MdbClickhouseClusterClickhouseConfigQueryCache(
            int? maxEntries,

            int? maxEntrySizeInBytes,

            int? maxEntrySizeInRows,

            int? maxSizeInBytes)
        {
            MaxEntries = maxEntries;
            MaxEntrySizeInBytes = maxEntrySizeInBytes;
            MaxEntrySizeInRows = maxEntrySizeInRows;
            MaxSizeInBytes = maxSizeInBytes;
        }
    }
}
