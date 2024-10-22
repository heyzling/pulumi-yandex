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
    public sealed class SmartcaptchaCaptchaSecurityRule
    {
        public readonly Outputs.SmartcaptchaCaptchaSecurityRuleCondition? Condition;
        public readonly string? Description;
        public readonly string? Name;
        public readonly string? OverrideVariantUuid;
        public readonly int? Priority;

        [OutputConstructor]
        private SmartcaptchaCaptchaSecurityRule(
            Outputs.SmartcaptchaCaptchaSecurityRuleCondition? condition,

            string? description,

            string? name,

            string? overrideVariantUuid,

            int? priority)
        {
            Condition = condition;
            Description = description;
            Name = name;
            OverrideVariantUuid = overrideVariantUuid;
            Priority = priority;
        }
    }
}
