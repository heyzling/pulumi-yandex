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
    public sealed class SwsSecurityProfileSecurityRuleSmartProtectionCondition
    {
        public readonly Outputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionAuthority? Authority;
        public readonly ImmutableArray<Outputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionHeader> Headers;
        public readonly Outputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionHttpMethod? HttpMethod;
        public readonly Outputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionRequestUri? RequestUri;
        public readonly Outputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionSourceIp? SourceIp;

        [OutputConstructor]
        private SwsSecurityProfileSecurityRuleSmartProtectionCondition(
            Outputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionAuthority? authority,

            ImmutableArray<Outputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionHeader> headers,

            Outputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionHttpMethod? httpMethod,

            Outputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionRequestUri? requestUri,

            Outputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionSourceIp? sourceIp)
        {
            Authority = authority;
            Headers = headers;
            HttpMethod = httpMethod;
            RequestUri = requestUri;
            SourceIp = sourceIp;
        }
    }
}
