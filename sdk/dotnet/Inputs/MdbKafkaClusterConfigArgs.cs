// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbKafkaClusterConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Access policy to the Kafka cluster. The structure is documented below.
        /// 
        /// - - -
        /// </summary>
        [Input("access")]
        public Input<Inputs.MdbKafkaClusterConfigAccessArgs>? Access { get; set; }

        /// <summary>
        /// Determines whether each broker will be assigned a public IP address. The default is `false`.
        /// </summary>
        [Input("assignPublicIp")]
        public Input<bool>? AssignPublicIp { get; set; }

        /// <summary>
        /// Count of brokers per availability zone. The default is `1`.
        /// </summary>
        [Input("brokersCount")]
        public Input<int>? BrokersCount { get; set; }

        [Input("diskSizeAutoscaling")]
        public Input<Inputs.MdbKafkaClusterConfigDiskSizeAutoscalingArgs>? DiskSizeAutoscaling { get; set; }

        /// <summary>
        /// Configuration of the Kafka subcluster. The structure is documented below.
        /// </summary>
        [Input("kafka", required: true)]
        public Input<Inputs.MdbKafkaClusterConfigKafkaArgs> Kafka { get; set; } = null!;

        /// <summary>
        /// Enables managed schema registry on cluster. The default is `false`.
        /// </summary>
        [Input("schemaRegistry")]
        public Input<bool>? SchemaRegistry { get; set; }

        [Input("unmanagedTopics")]
        public Input<bool>? UnmanagedTopics { get; set; }

        /// <summary>
        /// Version of the Kafka server software.
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        [Input("zones", required: true)]
        private InputList<string>? _zones;

        /// <summary>
        /// List of availability zones.
        /// </summary>
        public InputList<string> Zones
        {
            get => _zones ?? (_zones = new InputList<string>());
            set => _zones = value;
        }

        /// <summary>
        /// Configuration of the ZooKeeper subcluster. The structure is documented below.
        /// </summary>
        [Input("zookeeper")]
        public Input<Inputs.MdbKafkaClusterConfigZookeeperArgs>? Zookeeper { get; set; }

        public MdbKafkaClusterConfigArgs()
        {
        }
        public static new MdbKafkaClusterConfigArgs Empty => new MdbKafkaClusterConfigArgs();
    }
}
