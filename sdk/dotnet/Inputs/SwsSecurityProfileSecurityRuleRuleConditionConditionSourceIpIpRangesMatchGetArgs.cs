// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class SwsSecurityProfileSecurityRuleRuleConditionConditionSourceIpIpRangesMatchGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("ipRanges")]
        private InputList<string>? _ipRanges;
        public InputList<string> IpRanges
        {
            get => _ipRanges ?? (_ipRanges = new InputList<string>());
            set => _ipRanges = value;
        }

        public SwsSecurityProfileSecurityRuleRuleConditionConditionSourceIpIpRangesMatchGetArgs()
        {
        }
        public static new SwsSecurityProfileSecurityRuleRuleConditionConditionSourceIpIpRangesMatchGetArgs Empty => new SwsSecurityProfileSecurityRuleRuleConditionConditionSourceIpIpRangesMatchGetArgs();
    }
}
