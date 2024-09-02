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
    public sealed class KubernetesNodeGroupInstanceTemplate
    {
        /// <summary>
        /// The specifications for boot disks that will be attached to the instance. The structure is documented below.
        /// </summary>
        public readonly Outputs.KubernetesNodeGroupInstanceTemplateBootDisk? BootDisk;
        /// <summary>
        /// Container network configuration. The structure is documented below.
        /// </summary>
        public readonly Outputs.KubernetesNodeGroupInstanceTemplateContainerNetwork? ContainerNetwork;
        /// <summary>
        /// Container runtime configuration. The structure is documented below.
        /// </summary>
        public readonly Outputs.KubernetesNodeGroupInstanceTemplateContainerRuntime? ContainerRuntime;
        /// <summary>
        /// GPU settings. The structure is documented below.
        /// </summary>
        public readonly Outputs.KubernetesNodeGroupInstanceTemplateGpuSettings? GpuSettings;
        /// <summary>
        /// Labels that will be assigned to compute nodes (instances), created by the Node Group.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Labels;
        /// <summary>
        /// The set of metadata `key:value` pairs assigned to this instance template. This includes custom metadata and predefined keys. **Note**: key "user-data" won't be provided into instances. It reserved for internal activity in `kubernetes_node_group` resource.
        /// 
        /// * `resources.0.memory` - The memory size allocated to the instance.
        /// * `resources.0.cores` - Number of CPU cores allocated to the instance.
        /// * `resources.0.core_fraction` - Baseline core performance as a percent.
        /// * `resources.0.gpus` - Number of GPU cores allocated to the instance.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Metadata;
        /// <summary>
        /// Name template of the instance.
        /// In order to be unique it must contain at least one of instance unique placeholders:
        /// {instance.short_id}
        /// {instance.index}
        /// combination of {instance.zone_id} and {instance.index_in_zone}
        /// Example: my-instance-{instance.index}
        /// If not set, default is used: {instance_group.id}-{instance.short_id}
        /// It may also contain another placeholders, see [Compute Instance group metadata doc](https://cloud.yandex.com/en-ru/docs/compute/api-ref/grpc/instance_group_service) for full list.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Boolean flag, enables NAT for node group compute instances.
        /// </summary>
        public readonly bool? Nat;
        /// <summary>
        /// Type of network acceleration. Values: `standard`, `software_accelerated`.
        /// </summary>
        public readonly string? NetworkAccelerationType;
        /// <summary>
        /// An array with the network interfaces that will be attached to the instance. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.KubernetesNodeGroupInstanceTemplateNetworkInterface> NetworkInterfaces;
        /// <summary>
        /// The placement policy configuration. The structure is documented below.
        /// </summary>
        public readonly Outputs.KubernetesNodeGroupInstanceTemplatePlacementPolicy? PlacementPolicy;
        /// <summary>
        /// The ID of the hardware platform configuration for the node group compute instances.
        /// </summary>
        public readonly string? PlatformId;
        public readonly Outputs.KubernetesNodeGroupInstanceTemplateResources? Resources;
        /// <summary>
        /// The scheduling policy for the instances in node group. The structure is documented below.
        /// </summary>
        public readonly Outputs.KubernetesNodeGroupInstanceTemplateSchedulingPolicy? SchedulingPolicy;

        [OutputConstructor]
        private KubernetesNodeGroupInstanceTemplate(
            Outputs.KubernetesNodeGroupInstanceTemplateBootDisk? bootDisk,

            Outputs.KubernetesNodeGroupInstanceTemplateContainerNetwork? containerNetwork,

            Outputs.KubernetesNodeGroupInstanceTemplateContainerRuntime? containerRuntime,

            Outputs.KubernetesNodeGroupInstanceTemplateGpuSettings? gpuSettings,

            ImmutableDictionary<string, string>? labels,

            ImmutableDictionary<string, string>? metadata,

            string? name,

            bool? nat,

            string? networkAccelerationType,

            ImmutableArray<Outputs.KubernetesNodeGroupInstanceTemplateNetworkInterface> networkInterfaces,

            Outputs.KubernetesNodeGroupInstanceTemplatePlacementPolicy? placementPolicy,

            string? platformId,

            Outputs.KubernetesNodeGroupInstanceTemplateResources? resources,

            Outputs.KubernetesNodeGroupInstanceTemplateSchedulingPolicy? schedulingPolicy)
        {
            BootDisk = bootDisk;
            ContainerNetwork = containerNetwork;
            ContainerRuntime = containerRuntime;
            GpuSettings = gpuSettings;
            Labels = labels;
            Metadata = metadata;
            Name = name;
            Nat = nat;
            NetworkAccelerationType = networkAccelerationType;
            NetworkInterfaces = networkInterfaces;
            PlacementPolicy = placementPolicy;
            PlatformId = platformId;
            Resources = resources;
            SchedulingPolicy = schedulingPolicy;
        }
    }
}