// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbMongodbClusterClusterConfigMongocfgStorageWiredTigerGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Defines the maximum size of the internal cache that WiredTiger will use for all data.
        /// For more information, see the [storage.wiredTiger.engineConfig.cacheSizeGB](https://www.mongodb.com/docs/manual/reference/configuration-options/#mongodb-setting-storage.wiredTiger.engineConfig.cacheSizeGB)
        /// description in the official documentation.
        /// </summary>
        [Input("cacheSizeGb")]
        public Input<double>? CacheSizeGb { get; set; }

        public MdbMongodbClusterClusterConfigMongocfgStorageWiredTigerGetArgs()
        {
        }
        public static new MdbMongodbClusterClusterConfigMongocfgStorageWiredTigerGetArgs Empty => new MdbMongodbClusterClusterConfigMongocfgStorageWiredTigerGetArgs();
    }
}
