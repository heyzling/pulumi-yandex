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
    public sealed class SmartcaptchaCaptchaSecurityRuleConditionUri
    {
        public readonly Outputs.SmartcaptchaCaptchaSecurityRuleConditionUriPath? Path;
        public readonly ImmutableArray<Outputs.SmartcaptchaCaptchaSecurityRuleConditionUriQuery> Queries;

        [OutputConstructor]
        private SmartcaptchaCaptchaSecurityRuleConditionUri(
            Outputs.SmartcaptchaCaptchaSecurityRuleConditionUriPath? path,

            ImmutableArray<Outputs.SmartcaptchaCaptchaSecurityRuleConditionUriQuery> queries)
        {
            Path = path;
            Queries = queries;
        }
    }
}