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
    public sealed class SwsSecurityProfileSecurityRuleSmartProtectionConditionRequestUri
    {
        public readonly Outputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionRequestUriPath? Path;
        public readonly ImmutableArray<Outputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionRequestUriQuery> Queries;

        [OutputConstructor]
        private SwsSecurityProfileSecurityRuleSmartProtectionConditionRequestUri(
            Outputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionRequestUriPath? path,

            ImmutableArray<Outputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionRequestUriQuery> queries)
        {
            Path = path;
            Queries = queries;
        }
    }
}
