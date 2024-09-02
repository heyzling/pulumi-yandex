// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class SwsSecurityProfileSecurityRuleSmartProtectionConditionArgs : global::Pulumi.ResourceArgs
    {
        [Input("authority")]
        public Input<Inputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionAuthorityArgs>? Authority { get; set; }

        [Input("headers")]
        private InputList<Inputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionHeaderArgs>? _headers;
        public InputList<Inputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionHeaderArgs> Headers
        {
            get => _headers ?? (_headers = new InputList<Inputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionHeaderArgs>());
            set => _headers = value;
        }

        [Input("httpMethod")]
        public Input<Inputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionHttpMethodArgs>? HttpMethod { get; set; }

        [Input("requestUri")]
        public Input<Inputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionRequestUriArgs>? RequestUri { get; set; }

        [Input("sourceIp")]
        public Input<Inputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionSourceIpArgs>? SourceIp { get; set; }

        public SwsSecurityProfileSecurityRuleSmartProtectionConditionArgs()
        {
        }
        public static new SwsSecurityProfileSecurityRuleSmartProtectionConditionArgs Empty => new SwsSecurityProfileSecurityRuleSmartProtectionConditionArgs();
    }
}
