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
    public sealed class GetMonitoringDashboardWidgetChartResult
    {
        /// <summary>
        /// Chart ID
        /// </summary>
        public readonly string ChartId;
        /// <summary>
        /// Chart description in dashboard (not enabled in UI)
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Enable legend under chart
        /// </summary>
        public readonly bool DisplayLegend;
        /// <summary>
        /// Fixed time interval for chart
        /// </summary>
        public readonly string Freeze;
        /// <summary>
        /// Name hiding settings
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMonitoringDashboardWidgetChartNameHidingSettingResult> NameHidingSettings;
        /// <summary>
        /// Queries
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMonitoringDashboardWidgetChartQueryResult> Queries;
        public readonly ImmutableArray<Outputs.GetMonitoringDashboardWidgetChartSeriesOverrideResult> SeriesOverrides;
        /// <summary>
        /// Chart widget title
        /// </summary>
        public readonly string Title;
        /// <summary>
        /// Visualization settings
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMonitoringDashboardWidgetChartVisualizationSettingResult> VisualizationSettings;

        [OutputConstructor]
        private GetMonitoringDashboardWidgetChartResult(
            string chartId,

            string description,

            bool displayLegend,

            string freeze,

            ImmutableArray<Outputs.GetMonitoringDashboardWidgetChartNameHidingSettingResult> nameHidingSettings,

            ImmutableArray<Outputs.GetMonitoringDashboardWidgetChartQueryResult> queries,

            ImmutableArray<Outputs.GetMonitoringDashboardWidgetChartSeriesOverrideResult> seriesOverrides,

            string title,

            ImmutableArray<Outputs.GetMonitoringDashboardWidgetChartVisualizationSettingResult> visualizationSettings)
        {
            ChartId = chartId;
            Description = description;
            DisplayLegend = displayLegend;
            Freeze = freeze;
            NameHidingSettings = nameHidingSettings;
            Queries = queries;
            SeriesOverrides = seriesOverrides;
            Title = title;
            VisualizationSettings = visualizationSettings;
        }
    }
}
