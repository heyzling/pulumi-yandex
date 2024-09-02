// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class LbNetworkLoadBalancerAttachedTargetGroupArgs : global::Pulumi.ResourceArgs
    {
        [Input("healthchecks", required: true)]
        private InputList<Inputs.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckArgs>? _healthchecks;

        /// <summary>
        /// A HealthCheck resource. The structure is documented below.
        /// </summary>
        public InputList<Inputs.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckArgs> Healthchecks
        {
            get => _healthchecks ?? (_healthchecks = new InputList<Inputs.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckArgs>());
            set => _healthchecks = value;
        }

        /// <summary>
        /// ID of the target group.
        /// </summary>
        [Input("targetGroupId", required: true)]
        public Input<string> TargetGroupId { get; set; } = null!;

        public LbNetworkLoadBalancerAttachedTargetGroupArgs()
        {
        }
        public static new LbNetworkLoadBalancerAttachedTargetGroupArgs Empty => new LbNetworkLoadBalancerAttachedTargetGroupArgs();
    }
}
