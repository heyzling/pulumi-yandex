// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetComputeInstancePlacementPolicyArgs : global::Pulumi.InvokeArgs
    {
        [Input("hostAffinityRules", required: true)]
        private List<Inputs.GetComputeInstancePlacementPolicyHostAffinityRuleArgs>? _hostAffinityRules;
        public List<Inputs.GetComputeInstancePlacementPolicyHostAffinityRuleArgs> HostAffinityRules
        {
            get => _hostAffinityRules ?? (_hostAffinityRules = new List<Inputs.GetComputeInstancePlacementPolicyHostAffinityRuleArgs>());
            set => _hostAffinityRules = value;
        }

        [Input("placementGroupId")]
        public string? PlacementGroupId { get; set; }

        [Input("placementGroupPartition")]
        public int? PlacementGroupPartition { get; set; }

        public GetComputeInstancePlacementPolicyArgs()
        {
        }
        public static new GetComputeInstancePlacementPolicyArgs Empty => new GetComputeInstancePlacementPolicyArgs();
    }
}
