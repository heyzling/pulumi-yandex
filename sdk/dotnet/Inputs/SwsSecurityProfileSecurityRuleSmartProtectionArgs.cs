// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class SwsSecurityProfileSecurityRuleSmartProtectionArgs : global::Pulumi.ResourceArgs
    {
        [Input("condition")]
        public Input<Inputs.SwsSecurityProfileSecurityRuleSmartProtectionConditionArgs>? Condition { get; set; }

        [Input("mode")]
        public Input<string>? Mode { get; set; }

        public SwsSecurityProfileSecurityRuleSmartProtectionArgs()
        {
        }
        public static new SwsSecurityProfileSecurityRuleSmartProtectionArgs Empty => new SwsSecurityProfileSecurityRuleSmartProtectionArgs();
    }
}