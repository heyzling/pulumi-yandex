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
    public sealed class LoadtestingAgentComputeInstance
    {
        /// <summary>
        /// Boot disk specifications for the instance. The structure is documented below.
        /// </summary>
        public readonly Outputs.LoadtestingAgentComputeInstanceBootDisk BootDisk;
        /// <summary>
        /// The set of metadata `key:value` pairs assigned to this instance. This includes user custom `metadata`, and predefined items created by Yandex Cloud Load Testing.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? ComputedMetadata;
        /// <summary>
        /// A set of key/value label pairs to assign to the instance.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Labels;
        /// <summary>
        /// A set of metadata key/value pairs to make available from within the instance.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Metadata;
        /// <summary>
        /// Network specifications for the instance. This can be used multiple times for adding multiple interfaces. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.LoadtestingAgentComputeInstanceNetworkInterface> NetworkInterfaces;
        /// <summary>
        /// The Compute platform of virtual machine. If it is not provided, the standard-v2 platform will be used.
        /// </summary>
        public readonly string? PlatformId;
        /// <summary>
        /// Compute resource specifications for the instance. The structure is documented below.
        /// </summary>
        public readonly Outputs.LoadtestingAgentComputeInstanceResources Resources;
        /// <summary>
        /// The ID of the service account authorized for this load testing agent. Service account should have `loadtesting.generatorClient` or `loadtesting.externalAgent` role in the folder.
        /// </summary>
        public readonly string ServiceAccountId;
        /// <summary>
        /// The availability zone where the virtual machine will be created. If it is not provided,
        /// the default provider folder is used.
        /// </summary>
        public readonly string? ZoneId;

        [OutputConstructor]
        private LoadtestingAgentComputeInstance(
            Outputs.LoadtestingAgentComputeInstanceBootDisk bootDisk,

            ImmutableDictionary<string, string>? computedMetadata,

            ImmutableDictionary<string, string>? labels,

            ImmutableDictionary<string, string>? metadata,

            ImmutableArray<Outputs.LoadtestingAgentComputeInstanceNetworkInterface> networkInterfaces,

            string? platformId,

            Outputs.LoadtestingAgentComputeInstanceResources resources,

            string serviceAccountId,

            string? zoneId)
        {
            BootDisk = bootDisk;
            ComputedMetadata = computedMetadata;
            Labels = labels;
            Metadata = metadata;
            NetworkInterfaces = networkInterfaces;
            PlatformId = platformId;
            Resources = resources;
            ServiceAccountId = serviceAccountId;
            ZoneId = zoneId;
        }
    }
}
