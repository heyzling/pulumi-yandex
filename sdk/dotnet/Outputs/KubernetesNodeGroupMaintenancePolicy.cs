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
    public sealed class KubernetesNodeGroupMaintenancePolicy
    {
        /// <summary>
        /// Boolean flag that specifies if node group can be repaired automatically. When omitted, default value is TRUE.
        /// </summary>
        public readonly bool AutoRepair;
        /// <summary>
        /// Boolean flag that specifies if node group can be upgraded automatically. When omitted, default value is TRUE.
        /// </summary>
        public readonly bool AutoUpgrade;
        /// <summary>
        /// (Computed) Set of day intervals, when maintenance is allowed for this node group. When omitted, it defaults to any time. 
        /// 
        /// To specify time of day interval, for all days, one element should be provided, with two fields set, `start_time` and `duration`.
        /// 
        /// To allow maintenance only on specific days of week, please provide list of elements, with all fields set. Only one
        /// time interval is allowed for each day of week. Please see `my_node_group` config example.
        /// </summary>
        public readonly ImmutableArray<Outputs.KubernetesNodeGroupMaintenancePolicyMaintenanceWindow> MaintenanceWindows;

        [OutputConstructor]
        private KubernetesNodeGroupMaintenancePolicy(
            bool autoRepair,

            bool autoUpgrade,

            ImmutableArray<Outputs.KubernetesNodeGroupMaintenancePolicyMaintenanceWindow> maintenanceWindows)
        {
            AutoRepair = autoRepair;
            AutoUpgrade = autoUpgrade;
            MaintenanceWindows = maintenanceWindows;
        }
    }
}
