// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class SwsSecurityProfileSecurityRuleRuleConditionConditionSourceIpArgs : global::Pulumi.ResourceArgs
    {
        [Input("geoIpMatch")]
        public Input<Inputs.SwsSecurityProfileSecurityRuleRuleConditionConditionSourceIpGeoIpMatchArgs>? GeoIpMatch { get; set; }

        [Input("geoIpNotMatch")]
        public Input<Inputs.SwsSecurityProfileSecurityRuleRuleConditionConditionSourceIpGeoIpNotMatchArgs>? GeoIpNotMatch { get; set; }

        [Input("ipRangesMatch")]
        public Input<Inputs.SwsSecurityProfileSecurityRuleRuleConditionConditionSourceIpIpRangesMatchArgs>? IpRangesMatch { get; set; }

        [Input("ipRangesNotMatch")]
        public Input<Inputs.SwsSecurityProfileSecurityRuleRuleConditionConditionSourceIpIpRangesNotMatchArgs>? IpRangesNotMatch { get; set; }

        public SwsSecurityProfileSecurityRuleRuleConditionConditionSourceIpArgs()
        {
        }
        public static new SwsSecurityProfileSecurityRuleRuleConditionConditionSourceIpArgs Empty => new SwsSecurityProfileSecurityRuleRuleConditionConditionSourceIpArgs();
    }
}