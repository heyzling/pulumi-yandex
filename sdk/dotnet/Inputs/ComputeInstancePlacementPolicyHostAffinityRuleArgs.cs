// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstancePlacementPolicyHostAffinityRuleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Affinity label or one of reserved values - `yc.hostId`, `yc.hostGroupId`.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Affinity action. The only value supported is `IN`.
        /// </summary>
        [Input("op", required: true)]
        public Input<string> Op { get; set; } = null!;

        [Input("values", required: true)]
        private InputList<string>? _values;
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public ComputeInstancePlacementPolicyHostAffinityRuleArgs()
        {
        }
        public static new ComputeInstancePlacementPolicyHostAffinityRuleArgs Empty => new ComputeInstancePlacementPolicyHostAffinityRuleArgs();
    }
}