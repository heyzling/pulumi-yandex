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
    public sealed class GetSwsSecurityProfileSecurityRuleSmartProtectionConditionSourceIpIpRangesMatchResult
    {
        public readonly ImmutableArray<string> IpRanges;

        [OutputConstructor]
        private GetSwsSecurityProfileSecurityRuleSmartProtectionConditionSourceIpIpRangesMatchResult(ImmutableArray<string> ipRanges)
        {
            IpRanges = ipRanges;
        }
    }
}
