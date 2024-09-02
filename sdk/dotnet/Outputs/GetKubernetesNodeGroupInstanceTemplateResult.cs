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
    public sealed class GetKubernetesNodeGroupInstanceTemplateResult
    {
        public readonly ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplateBootDiskResult> BootDisks;
        public readonly ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplateContainerNetworkResult> ContainerNetworks;
        public readonly Outputs.GetKubernetesNodeGroupInstanceTemplateContainerRuntimeResult ContainerRuntime;
        public readonly ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplateGpuSettingResult> GpuSettings;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly ImmutableDictionary<string, string> Metadata;
        public readonly string Name;
        public readonly bool Nat;
        public readonly string NetworkAccelerationType;
        public readonly ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplateNetworkInterfaceResult> NetworkInterfaces;
        public readonly ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplatePlacementPolicyResult> PlacementPolicies;
        public readonly string PlatformId;
        public readonly ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplateResourceResult> Resources;
        public readonly ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplateSchedulingPolicyResult> SchedulingPolicies;

        [OutputConstructor]
        private GetKubernetesNodeGroupInstanceTemplateResult(
            ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplateBootDiskResult> bootDisks,

            ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplateContainerNetworkResult> containerNetworks,

            Outputs.GetKubernetesNodeGroupInstanceTemplateContainerRuntimeResult containerRuntime,

            ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplateGpuSettingResult> gpuSettings,

            ImmutableDictionary<string, string> labels,

            ImmutableDictionary<string, string> metadata,

            string name,

            bool nat,

            string networkAccelerationType,

            ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplateNetworkInterfaceResult> networkInterfaces,

            ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplatePlacementPolicyResult> placementPolicies,

            string platformId,

            ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplateResourceResult> resources,

            ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplateSchedulingPolicyResult> schedulingPolicies)
        {
            BootDisks = bootDisks;
            ContainerNetworks = containerNetworks;
            ContainerRuntime = containerRuntime;
            GpuSettings = gpuSettings;
            Labels = labels;
            Metadata = metadata;
            Name = name;
            Nat = nat;
            NetworkAccelerationType = networkAccelerationType;
            NetworkInterfaces = networkInterfaces;
            PlacementPolicies = placementPolicies;
            PlatformId = platformId;
            Resources = resources;
            SchedulingPolicies = schedulingPolicies;
        }
    }
}
