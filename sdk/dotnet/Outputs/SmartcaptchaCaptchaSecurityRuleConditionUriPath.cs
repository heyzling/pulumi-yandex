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
    public sealed class SmartcaptchaCaptchaSecurityRuleConditionUriPath
    {
        public readonly string? ExactMatch;
        public readonly string? ExactNotMatch;
        public readonly string? PireRegexMatch;
        public readonly string? PireRegexNotMatch;
        public readonly string? PrefixMatch;
        public readonly string? PrefixNotMatch;

        [OutputConstructor]
        private SmartcaptchaCaptchaSecurityRuleConditionUriPath(
            string? exactMatch,

            string? exactNotMatch,

            string? pireRegexMatch,

            string? pireRegexNotMatch,

            string? prefixMatch,

            string? prefixNotMatch)
        {
            ExactMatch = exactMatch;
            ExactNotMatch = exactNotMatch;
            PireRegexMatch = pireRegexMatch;
            PireRegexNotMatch = pireRegexNotMatch;
            PrefixMatch = prefixMatch;
            PrefixNotMatch = prefixNotMatch;
        }
    }
}
