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
    public sealed class GetMdbMongodbClusterClusterConfigMongodStorageWiredTigerResult
    {
        public readonly string? BlockCompressor;
        public readonly double? CacheSizeGb;
        public readonly bool? PrefixCompression;

        [OutputConstructor]
        private GetMdbMongodbClusterClusterConfigMongodStorageWiredTigerResult(
            string? blockCompressor,

            double? cacheSizeGb,

            bool? prefixCompression)
        {
            BlockCompressor = blockCompressor;
            CacheSizeGb = cacheSizeGb;
            PrefixCompression = prefixCompression;
        }
    }
}