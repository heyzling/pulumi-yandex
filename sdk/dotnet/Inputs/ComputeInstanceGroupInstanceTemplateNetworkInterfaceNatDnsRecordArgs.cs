// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecordArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// DNS zone id (if not set, private zone used).
        /// </summary>
        [Input("dnsZoneId")]
        public Input<string>? DnsZoneId { get; set; }

        /// <summary>
        /// DNS record fqdn (must have dot at the end).
        /// </summary>
        [Input("fqdn", required: true)]
        public Input<string> Fqdn { get; set; } = null!;

        /// <summary>
        /// When set to true, also create PTR DNS record.
        /// </summary>
        [Input("ptr")]
        public Input<bool>? Ptr { get; set; }

        /// <summary>
        /// DNS record TTL.
        /// </summary>
        [Input("ttl")]
        public Input<int>? Ttl { get; set; }

        public ComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecordArgs()
        {
        }
        public static new ComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecordArgs Empty => new ComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecordArgs();
    }
}
