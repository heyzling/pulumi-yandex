// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MonitoringDashboardWidgetChartVisualizationSettingGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Aggregation. Values:
        /// - SERIES_AGGREGATION_UNSPECIFIED: Not specified (avg by default).
        /// - SERIES_AGGREGATION_AVG: Average.
        /// - SERIES_AGGREGATION_MIN: Minimum.
        /// - SERIES_AGGREGATION_MAX: Maximum.
        /// - SERIES_AGGREGATION_LAST: Last non-NaN value.
        /// - SERIES_AGGREGATION_SUM: Sum.
        /// </summary>
        [Input("aggregation")]
        public Input<string>? Aggregation { get; set; }

        [Input("colorSchemeSettings")]
        private InputList<Inputs.MonitoringDashboardWidgetChartVisualizationSettingColorSchemeSettingGetArgs>? _colorSchemeSettings;

        /// <summary>
        /// Color settings.
        /// </summary>
        public InputList<Inputs.MonitoringDashboardWidgetChartVisualizationSettingColorSchemeSettingGetArgs> ColorSchemeSettings
        {
            get => _colorSchemeSettings ?? (_colorSchemeSettings = new InputList<Inputs.MonitoringDashboardWidgetChartVisualizationSettingColorSchemeSettingGetArgs>());
            set => _colorSchemeSettings = value;
        }

        [Input("heatmapSettings")]
        private InputList<Inputs.MonitoringDashboardWidgetChartVisualizationSettingHeatmapSettingGetArgs>? _heatmapSettings;

        /// <summary>
        /// Heatmap settings.
        /// </summary>
        public InputList<Inputs.MonitoringDashboardWidgetChartVisualizationSettingHeatmapSettingGetArgs> HeatmapSettings
        {
            get => _heatmapSettings ?? (_heatmapSettings = new InputList<Inputs.MonitoringDashboardWidgetChartVisualizationSettingHeatmapSettingGetArgs>());
            set => _heatmapSettings = value;
        }

        /// <summary>
        /// Interpolate values. Values:
        /// - INTERPOLATE_UNSPECIFIED: Not specified (linear by default).
        /// - INTERPOLATE_LINEAR: Linear.
        /// - INTERPOLATE_LEFT: Left.
        /// - INTERPOLATE_RIGHT: Right.
        /// </summary>
        [Input("interpolate")]
        public Input<string>? Interpolate { get; set; }

        /// <summary>
        /// Normalize values.
        /// </summary>
        [Input("normalize")]
        public Input<bool>? Normalize { get; set; }

        /// <summary>
        /// Show chart labels.
        /// </summary>
        [Input("showLabels")]
        public Input<bool>? ShowLabels { get; set; }

        /// <summary>
        /// Inside chart title.
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        /// <summary>
        /// Visualization type. Values:
        /// - VISUALIZATION_TYPE_UNSPECIFIED: Not specified (line by default).
        /// - VISUALIZATION_TYPE_LINE: Line chart.
        /// - VISUALIZATION_TYPE_STACK: Stack chart.
        /// - VISUALIZATION_TYPE_COLUMN: Points as columns chart.
        /// - VISUALIZATION_TYPE_POINTS: Points.
        /// - VISUALIZATION_TYPE_PIE: Pie aggregation chart.
        /// - VISUALIZATION_TYPE_BARS: Bars aggregation chart.
        /// - VISUALIZATION_TYPE_DISTRIBUTION: Distribution aggregation chart.
        /// - VISUALIZATION_TYPE_HEATMAP: Heatmap aggregation chart.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("yaxisSettings")]
        private InputList<Inputs.MonitoringDashboardWidgetChartVisualizationSettingYaxisSettingGetArgs>? _yaxisSettings;

        /// <summary>
        /// Y axis settings.
        /// </summary>
        public InputList<Inputs.MonitoringDashboardWidgetChartVisualizationSettingYaxisSettingGetArgs> YaxisSettings
        {
            get => _yaxisSettings ?? (_yaxisSettings = new InputList<Inputs.MonitoringDashboardWidgetChartVisualizationSettingYaxisSettingGetArgs>());
            set => _yaxisSettings = value;
        }

        public MonitoringDashboardWidgetChartVisualizationSettingGetArgs()
        {
        }
        public static new MonitoringDashboardWidgetChartVisualizationSettingGetArgs Empty => new MonitoringDashboardWidgetChartVisualizationSettingGetArgs();
    }
}
