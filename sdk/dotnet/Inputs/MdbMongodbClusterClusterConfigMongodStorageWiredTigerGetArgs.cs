// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbMongodbClusterClusterConfigMongodStorageWiredTigerGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the default compression for collection data. You can override this on a per-collection basis when creating collections.
        /// Available compressors are: none, snappy, zlib, zstd. This setting available only on `mongod` hosts.
        /// For more information, see the [storage.wiredTiger.collectionConfig.blockCompressor](https://www.mongodb.com/docs/manual/reference/configuration-options/#mongodb-setting-storage.wiredTiger.collectionConfig.blockCompressor)
        /// description in the official documentation.
        /// </summary>
        [Input("blockCompressor")]
        public Input<string>? BlockCompressor { get; set; }

        /// <summary>
        /// Defines the maximum size of the internal cache that WiredTiger will use for all data.
        /// For more information, see the [storage.wiredTiger.engineConfig.cacheSizeGB](https://www.mongodb.com/docs/manual/reference/configuration-options/#mongodb-setting-storage.wiredTiger.engineConfig.cacheSizeGB)
        /// description in the official documentation.
        /// </summary>
        [Input("cacheSizeGb")]
        public Input<double>? CacheSizeGb { get; set; }

        /// <summary>
        /// Enables or disables prefix compression for index data. Сan be either true or false.
        /// For more information, see the [storage.wiredTiger.indexConfig.prefixCompression](https://www.mongodb.com/docs/manual/reference/configuration-options/#mongodb-setting-storage.wiredTiger.indexConfig.prefixCompression)
        /// description in the official documentation.
        /// </summary>
        [Input("prefixCompression")]
        public Input<bool>? PrefixCompression { get; set; }

        public MdbMongodbClusterClusterConfigMongodStorageWiredTigerGetArgs()
        {
        }
        public static new MdbMongodbClusterClusterConfigMongodStorageWiredTigerGetArgs Empty => new MdbMongodbClusterClusterConfigMongodStorageWiredTigerGetArgs();
    }
}