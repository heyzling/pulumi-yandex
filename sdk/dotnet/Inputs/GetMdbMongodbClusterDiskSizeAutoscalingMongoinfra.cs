// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterDiskSizeAutoscalingMongoinfraArgs : global::Pulumi.InvokeArgs
    {
        [Input("diskSizeLimit")]
        public int? DiskSizeLimit { get; set; }

        [Input("emergencyUsageThreshold")]
        public int? EmergencyUsageThreshold { get; set; }

        [Input("plannedUsageThreshold")]
        public int? PlannedUsageThreshold { get; set; }

        public GetMdbMongodbClusterDiskSizeAutoscalingMongoinfraArgs()
        {
        }
        public static new GetMdbMongodbClusterDiskSizeAutoscalingMongoinfraArgs Empty => new GetMdbMongodbClusterDiskSizeAutoscalingMongoinfraArgs();
    }
}
