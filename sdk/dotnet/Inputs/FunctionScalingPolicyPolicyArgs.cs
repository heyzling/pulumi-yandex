// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class FunctionScalingPolicyPolicyArgs : global::Pulumi.ResourceArgs
    {
        [Input("tag", required: true)]
        public Input<string> Tag { get; set; } = null!;

        [Input("zoneInstancesLimit")]
        public Input<int>? ZoneInstancesLimit { get; set; }

        [Input("zoneRequestsLimit")]
        public Input<int>? ZoneRequestsLimit { get; set; }

        public FunctionScalingPolicyPolicyArgs()
        {
        }
        public static new FunctionScalingPolicyPolicyArgs Empty => new FunctionScalingPolicyPolicyArgs();
    }
}