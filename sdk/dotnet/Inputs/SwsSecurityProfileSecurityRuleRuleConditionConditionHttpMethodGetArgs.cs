// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class SwsSecurityProfileSecurityRuleRuleConditionConditionHttpMethodGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("httpMethods")]
        private InputList<Inputs.SwsSecurityProfileSecurityRuleRuleConditionConditionHttpMethodHttpMethodGetArgs>? _httpMethods;
        public InputList<Inputs.SwsSecurityProfileSecurityRuleRuleConditionConditionHttpMethodHttpMethodGetArgs> HttpMethods
        {
            get => _httpMethods ?? (_httpMethods = new InputList<Inputs.SwsSecurityProfileSecurityRuleRuleConditionConditionHttpMethodHttpMethodGetArgs>());
            set => _httpMethods = value;
        }

        public SwsSecurityProfileSecurityRuleRuleConditionConditionHttpMethodGetArgs()
        {
        }
        public static new SwsSecurityProfileSecurityRuleRuleConditionConditionHttpMethodGetArgs Empty => new SwsSecurityProfileSecurityRuleRuleConditionConditionHttpMethodGetArgs();
    }
}