// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbKafkaClusterTopicInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("partitions", required: true)]
        public Input<int> Partitions { get; set; } = null!;

        [Input("replicationFactor", required: true)]
        public Input<int> ReplicationFactor { get; set; } = null!;

        [Input("topicConfig")]
        public Input<Inputs.GetMdbKafkaClusterTopicTopicConfigInputArgs>? TopicConfig { get; set; }

        public GetMdbKafkaClusterTopicInputArgs()
        {
        }
        public static new GetMdbKafkaClusterTopicInputArgs Empty => new GetMdbKafkaClusterTopicInputArgs();
    }
}
