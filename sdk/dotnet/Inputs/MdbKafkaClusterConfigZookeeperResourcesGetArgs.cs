// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbKafkaClusterConfigZookeeperResourcesGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Volume of the storage available to a ZooKeeper host, in gigabytes.
        /// </summary>
        [Input("diskSize")]
        public Input<int>? DiskSize { get; set; }

        /// <summary>
        /// Type of the storage of ZooKeeper hosts.
        /// For more information see [the official documentation](https://cloud.yandex.com/docs/managed-kafka/concepts/storage).
        /// </summary>
        [Input("diskTypeId")]
        public Input<string>? DiskTypeId { get; set; }

        [Input("resourcePresetId")]
        public Input<string>? ResourcePresetId { get; set; }

        public MdbKafkaClusterConfigZookeeperResourcesGetArgs()
        {
        }
        public static new MdbKafkaClusterConfigZookeeperResourcesGetArgs Empty => new MdbKafkaClusterConfigZookeeperResourcesGetArgs();
    }
}
