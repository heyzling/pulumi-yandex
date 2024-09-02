// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbKafkaClusterConfigDiskSizeAutoscalingInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("diskSizeLimit", required: true)]
        public Input<int> DiskSizeLimit { get; set; } = null!;

        [Input("emergencyUsageThreshold")]
        public Input<int>? EmergencyUsageThreshold { get; set; }

        [Input("plannedUsageThreshold")]
        public Input<int>? PlannedUsageThreshold { get; set; }

        public GetMdbKafkaClusterConfigDiskSizeAutoscalingInputArgs()
        {
        }
        public static new GetMdbKafkaClusterConfigDiskSizeAutoscalingInputArgs Empty => new GetMdbKafkaClusterConfigDiskSizeAutoscalingInputArgs();
    }
}