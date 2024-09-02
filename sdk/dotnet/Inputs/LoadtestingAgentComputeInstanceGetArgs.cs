// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class LoadtestingAgentComputeInstanceGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Boot disk specifications for the instance. The structure is documented below.
        /// </summary>
        [Input("bootDisk", required: true)]
        public Input<Inputs.LoadtestingAgentComputeInstanceBootDiskGetArgs> BootDisk { get; set; } = null!;

        [Input("computedMetadata")]
        private InputMap<string>? _computedMetadata;

        /// <summary>
        /// The set of metadata `key:value` pairs assigned to this instance. This includes user custom `metadata`, and predefined items created by Yandex Cloud Load Testing.
        /// </summary>
        public InputMap<string> ComputedMetadata
        {
            get => _computedMetadata ?? (_computedMetadata = new InputMap<string>());
            set => _computedMetadata = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the instance.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("metadata")]
        private InputMap<string>? _metadata;

        /// <summary>
        /// A set of metadata key/value pairs to make available from within the instance.
        /// </summary>
        public InputMap<string> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

        [Input("networkInterfaces", required: true)]
        private InputList<Inputs.LoadtestingAgentComputeInstanceNetworkInterfaceGetArgs>? _networkInterfaces;

        /// <summary>
        /// Network specifications for the instance. This can be used multiple times for adding multiple interfaces. The structure is documented below.
        /// </summary>
        public InputList<Inputs.LoadtestingAgentComputeInstanceNetworkInterfaceGetArgs> NetworkInterfaces
        {
            get => _networkInterfaces ?? (_networkInterfaces = new InputList<Inputs.LoadtestingAgentComputeInstanceNetworkInterfaceGetArgs>());
            set => _networkInterfaces = value;
        }

        /// <summary>
        /// The Compute platform of virtual machine. If it is not provided, the standard-v2 platform will be used.
        /// </summary>
        [Input("platformId")]
        public Input<string>? PlatformId { get; set; }

        /// <summary>
        /// Compute resource specifications for the instance. The structure is documented below.
        /// </summary>
        [Input("resources", required: true)]
        public Input<Inputs.LoadtestingAgentComputeInstanceResourcesGetArgs> Resources { get; set; } = null!;

        /// <summary>
        /// The ID of the service account authorized for this load testing agent. Service account should have `loadtesting.generatorClient` or `loadtesting.externalAgent` role in the folder.
        /// </summary>
        [Input("serviceAccountId", required: true)]
        public Input<string> ServiceAccountId { get; set; } = null!;

        /// <summary>
        /// The availability zone where the virtual machine will be created. If it is not provided,
        /// the default provider folder is used.
        /// </summary>
        [Input("zoneId")]
        public Input<string>? ZoneId { get; set; }

        public LoadtestingAgentComputeInstanceGetArgs()
        {
        }
        public static new LoadtestingAgentComputeInstanceGetArgs Empty => new LoadtestingAgentComputeInstanceGetArgs();
    }
}
