// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class SmartcaptchaCaptchaSecurityRuleArgs : global::Pulumi.ResourceArgs
    {
        [Input("condition")]
        public Input<Inputs.SmartcaptchaCaptchaSecurityRuleConditionArgs>? Condition { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("overrideVariantUuid")]
        public Input<string>? OverrideVariantUuid { get; set; }

        [Input("priority")]
        public Input<int>? Priority { get; set; }

        public SmartcaptchaCaptchaSecurityRuleArgs()
        {
        }
        public static new SmartcaptchaCaptchaSecurityRuleArgs Empty => new SmartcaptchaCaptchaSecurityRuleArgs();
    }
}
