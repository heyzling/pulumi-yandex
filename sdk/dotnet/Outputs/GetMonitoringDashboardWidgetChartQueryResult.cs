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
    public sealed class GetMonitoringDashboardWidgetChartQueryResult
    {
        /// <summary>
        /// Downsampling settings
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMonitoringDashboardWidgetChartQueryDownsamplingResult> Downsamplings;
        /// <summary>
        /// Downsampling settings
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMonitoringDashboardWidgetChartQueryTargetResult> Targets;

        [OutputConstructor]
        private GetMonitoringDashboardWidgetChartQueryResult(
            ImmutableArray<Outputs.GetMonitoringDashboardWidgetChartQueryDownsamplingResult> downsamplings,

            ImmutableArray<Outputs.GetMonitoringDashboardWidgetChartQueryTargetResult> targets)
        {
            Downsamplings = downsamplings;
            Targets = targets;
        }
    }
}