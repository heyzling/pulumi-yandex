// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class SwsSecurityProfileSecurityRuleRuleConditionConditionHttpMethodHttpMethodArgs : global::Pulumi.ResourceArgs
    {
        [Input("exactMatch")]
        public Input<string>? ExactMatch { get; set; }

        [Input("exactNotMatch")]
        public Input<string>? ExactNotMatch { get; set; }

        [Input("pireRegexMatch")]
        public Input<string>? PireRegexMatch { get; set; }

        [Input("pireRegexNotMatch")]
        public Input<string>? PireRegexNotMatch { get; set; }

        [Input("prefixMatch")]
        public Input<string>? PrefixMatch { get; set; }

        [Input("prefixNotMatch")]
        public Input<string>? PrefixNotMatch { get; set; }

        public SwsSecurityProfileSecurityRuleRuleConditionConditionHttpMethodHttpMethodArgs()
        {
        }
        public static new SwsSecurityProfileSecurityRuleRuleConditionConditionHttpMethodHttpMethodArgs Empty => new SwsSecurityProfileSecurityRuleRuleConditionConditionHttpMethodHttpMethodArgs();
    }
}
