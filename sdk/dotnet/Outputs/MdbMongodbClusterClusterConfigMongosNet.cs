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
    public sealed class MdbMongodbClusterClusterConfigMongosNet
    {
        /// <summary>
        /// Specifies the default compressor(s) to use for communication between this mongod or mongos. 
        /// Accepts array of compressors. Order matters. Available compressors: snappy, zlib, zstd, disabled. To disable network compression, make "disabled" the only value.
        /// For more information, see the [net.Compression.Compressors](https://www.mongodb.com/docs/manual/reference/configuration-options/#mongodb-setting-net.compression.compressors)
        /// description in the official documentation.
        /// </summary>
        public readonly ImmutableArray<string> Compressors;
        /// <summary>
        /// The maximum number of simultaneous connections that host will accept.
        /// For more information, see the [net.maxIncomingConnections](https://www.mongodb.com/docs/manual/reference/configuration-options/#mongodb-setting-net.maxIncomingConnections)
        /// description in the official documentation.
        /// </summary>
        public readonly int? MaxIncomingConnections;

        [OutputConstructor]
        private MdbMongodbClusterClusterConfigMongosNet(
            ImmutableArray<string> compressors,

            int? maxIncomingConnections)
        {
            Compressors = compressors;
            MaxIncomingConnections = maxIncomingConnections;
        }
    }
}