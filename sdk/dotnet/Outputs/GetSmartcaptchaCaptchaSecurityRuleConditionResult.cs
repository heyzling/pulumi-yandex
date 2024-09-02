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
    public sealed class GetSmartcaptchaCaptchaSecurityRuleConditionResult
    {
        public readonly ImmutableArray<Outputs.GetSmartcaptchaCaptchaSecurityRuleConditionHeaderResult> Headers;
        public readonly ImmutableArray<Outputs.GetSmartcaptchaCaptchaSecurityRuleConditionHostResult> Hosts;
        public readonly ImmutableArray<Outputs.GetSmartcaptchaCaptchaSecurityRuleConditionSourceIpResult> SourceIps;
        public readonly ImmutableArray<Outputs.GetSmartcaptchaCaptchaSecurityRuleConditionUriResult> Uris;

        [OutputConstructor]
        private GetSmartcaptchaCaptchaSecurityRuleConditionResult(
            ImmutableArray<Outputs.GetSmartcaptchaCaptchaSecurityRuleConditionHeaderResult> headers,

            ImmutableArray<Outputs.GetSmartcaptchaCaptchaSecurityRuleConditionHostResult> hosts,

            ImmutableArray<Outputs.GetSmartcaptchaCaptchaSecurityRuleConditionSourceIpResult> sourceIps,

            ImmutableArray<Outputs.GetSmartcaptchaCaptchaSecurityRuleConditionUriResult> uris)
        {
            Headers = headers;
            Hosts = hosts;
            SourceIps = sourceIps;
            Uris = uris;
        }
    }
}