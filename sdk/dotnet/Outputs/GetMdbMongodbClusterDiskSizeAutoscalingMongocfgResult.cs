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
    public sealed class GetMdbMongodbClusterDiskSizeAutoscalingMongocfgResult
    {
        public readonly int? DiskSizeLimit;
        public readonly int? EmergencyUsageThreshold;
        public readonly int? PlannedUsageThreshold;

        [OutputConstructor]
        private GetMdbMongodbClusterDiskSizeAutoscalingMongocfgResult(
            int? diskSizeLimit,

            int? emergencyUsageThreshold,

            int? plannedUsageThreshold)
        {
            DiskSizeLimit = diskSizeLimit;
            EmergencyUsageThreshold = emergencyUsageThreshold;
            PlannedUsageThreshold = plannedUsageThreshold;
        }
    }
}
