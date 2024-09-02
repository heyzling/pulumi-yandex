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
    public sealed class GetComputeInstanceGroupScalePolicyTestAutoScaleResult
    {
        public readonly string AutoScaleType;
        public readonly double CpuUtilizationTarget;
        public readonly ImmutableArray<Outputs.GetComputeInstanceGroupScalePolicyTestAutoScaleCustomRuleResult> CustomRules;
        public readonly int InitialSize;
        public readonly int MaxSize;
        public readonly int MeasurementDuration;
        public readonly int MinZoneSize;
        public readonly int StabilizationDuration;
        public readonly int WarmupDuration;

        [OutputConstructor]
        private GetComputeInstanceGroupScalePolicyTestAutoScaleResult(
            string autoScaleType,

            double cpuUtilizationTarget,

            ImmutableArray<Outputs.GetComputeInstanceGroupScalePolicyTestAutoScaleCustomRuleResult> customRules,

            int initialSize,

            int maxSize,

            int measurementDuration,

            int minZoneSize,

            int stabilizationDuration,

            int warmupDuration)
        {
            AutoScaleType = autoScaleType;
            CpuUtilizationTarget = cpuUtilizationTarget;
            CustomRules = customRules;
            InitialSize = initialSize;
            MaxSize = maxSize;
            MeasurementDuration = measurementDuration;
            MinZoneSize = minZoneSize;
            StabilizationDuration = stabilizationDuration;
            WarmupDuration = warmupDuration;
        }
    }
}
