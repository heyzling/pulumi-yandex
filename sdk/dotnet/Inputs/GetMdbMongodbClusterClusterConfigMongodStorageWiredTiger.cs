// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterClusterConfigMongodStorageWiredTigerArgs : global::Pulumi.InvokeArgs
    {
        [Input("blockCompressor")]
        public string? BlockCompressor { get; set; }

        [Input("cacheSizeGb")]
        public double? CacheSizeGb { get; set; }

        [Input("prefixCompression")]
        public bool? PrefixCompression { get; set; }

        public GetMdbMongodbClusterClusterConfigMongodStorageWiredTigerArgs()
        {
        }
        public static new GetMdbMongodbClusterClusterConfigMongodStorageWiredTigerArgs Empty => new GetMdbMongodbClusterClusterConfigMongodStorageWiredTigerArgs();
    }
}
