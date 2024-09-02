// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MonitoringDashboardWidgetChartQueryTargetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Checks that target is visible or invisible.
        /// </summary>
        [Input("hidden")]
        public Input<bool>? Hidden { get; set; }

        /// <summary>
        /// Query.
        /// </summary>
        [Input("query")]
        public Input<string>? Query { get; set; }

        /// <summary>
        /// Text mode enabled.
        /// </summary>
        [Input("textMode")]
        public Input<bool>? TextMode { get; set; }

        public MonitoringDashboardWidgetChartQueryTargetArgs()
        {
        }
        public static new MonitoringDashboardWidgetChartQueryTargetArgs Empty => new MonitoringDashboardWidgetChartQueryTargetArgs();
    }
}