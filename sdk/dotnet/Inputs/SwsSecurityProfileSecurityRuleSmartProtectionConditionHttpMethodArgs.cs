// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class SwsSecurityProfileSecurityRuleSmartProtectionConditionHttpMethodArgs : global::Pulumi.ResourceArgs
    {
        [Input("httpMethods")]
        private InputList<Inputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionHttpMethodHttpMethodArgs>? _httpMethods;
        public InputList<Inputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionHttpMethodHttpMethodArgs> HttpMethods
        {
            get => _httpMethods ?? (_httpMethods = new InputList<Inputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionHttpMethodHttpMethodArgs>());
            set => _httpMethods = value;
        }

        public SwsSecurityProfileSecurityRuleSmartProtectionConditionHttpMethodArgs()
        {
        }
        public static new SwsSecurityProfileSecurityRuleSmartProtectionConditionHttpMethodArgs Empty => new SwsSecurityProfileSecurityRuleSmartProtectionConditionHttpMethodArgs();
    }
}