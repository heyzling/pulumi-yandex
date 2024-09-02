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
    public sealed class GetAlbLoadBalancerLogOptionResult
    {
        public readonly bool Disable;
        public readonly ImmutableArray<Outputs.GetAlbLoadBalancerLogOptionDiscardRuleResult> DiscardRules;
        public readonly string LogGroupId;

        [OutputConstructor]
        private GetAlbLoadBalancerLogOptionResult(
            bool disable,

            ImmutableArray<Outputs.GetAlbLoadBalancerLogOptionDiscardRuleResult> discardRules,

            string logGroupId)
        {
            Disable = disable;
            DiscardRules = discardRules;
            LogGroupId = logGroupId;
        }
    }
}
