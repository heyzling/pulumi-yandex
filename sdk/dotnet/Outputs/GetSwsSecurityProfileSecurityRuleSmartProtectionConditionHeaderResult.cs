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
    public sealed class GetSwsSecurityProfileSecurityRuleSmartProtectionConditionHeaderResult
    {
        public readonly string Name;
        public readonly ImmutableArray<Outputs.GetSwsSecurityProfileSecurityRuleSmartProtectionConditionHeaderValueResult> Values;

        [OutputConstructor]
        private GetSwsSecurityProfileSecurityRuleSmartProtectionConditionHeaderResult(
            string name,

            ImmutableArray<Outputs.GetSwsSecurityProfileSecurityRuleSmartProtectionConditionHeaderValueResult> values)
        {
            Name = name;
            Values = values;
        }
    }
}
