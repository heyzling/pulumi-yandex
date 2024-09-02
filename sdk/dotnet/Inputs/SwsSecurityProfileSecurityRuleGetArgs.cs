// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class SwsSecurityProfileSecurityRuleGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("dryRun")]
        public Input<bool>? DryRun { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("priority")]
        public Input<int>? Priority { get; set; }

        [Input("ruleCondition")]
        public Input<Inputs.SwsSecurityProfileSecurityRuleRuleConditionGetArgs>? RuleCondition { get; set; }

        [Input("smartProtection")]
        public Input<Inputs.SwsSecurityProfileSecurityRuleSmartProtectionGetArgs>? SmartProtection { get; set; }

        public SwsSecurityProfileSecurityRuleGetArgs()
        {
        }
        public static new SwsSecurityProfileSecurityRuleGetArgs Empty => new SwsSecurityProfileSecurityRuleGetArgs();
    }
}
