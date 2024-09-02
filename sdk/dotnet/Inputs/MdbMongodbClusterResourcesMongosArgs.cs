// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbMongodbClusterResourcesMongosArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Volume of the storage available to a MongoDB host, in gigabytes.
        /// </summary>
        [Input("diskSize", required: true)]
        public Input<int> DiskSize { get; set; } = null!;

        /// <summary>
        /// Type of the storage of MongoDB hosts.
        /// For more information see [the official documentation](https://cloud.yandex.com/docs/managed-clickhouse/concepts/storage).
        /// 
        /// The `disk_size_autoscaling_mongod`, `disk_size_autoscaling_mongos`, `disk_size_autoscaling_mongoinfra`, `disk_size_autoscaling_mongocfg` blocks support:
        /// </summary>
        [Input("diskTypeId", required: true)]
        public Input<string> DiskTypeId { get; set; } = null!;

        [Input("resourcePresetId", required: true)]
        public Input<string> ResourcePresetId { get; set; } = null!;

        public MdbMongodbClusterResourcesMongosArgs()
        {
        }
        public static new MdbMongodbClusterResourcesMongosArgs Empty => new MdbMongodbClusterResourcesMongosArgs();
    }
}
