// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetCdnResourceOptionsIpAddressAclInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("exceptedValues", required: true)]
        private InputList<string>? _exceptedValues;
        public InputList<string> ExceptedValues
        {
            get => _exceptedValues ?? (_exceptedValues = new InputList<string>());
            set => _exceptedValues = value;
        }

        [Input("policyType", required: true)]
        public Input<string> PolicyType { get; set; } = null!;

        public GetCdnResourceOptionsIpAddressAclInputArgs()
        {
        }
        public static new GetCdnResourceOptionsIpAddressAclInputArgs Empty => new GetCdnResourceOptionsIpAddressAclInputArgs();
    }
}
