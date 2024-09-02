// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class VpcRouteTableStaticRouteArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Route prefix in CIDR notation.
        /// </summary>
        [Input("destinationPrefix")]
        public Input<string>? DestinationPrefix { get; set; }

        /// <summary>
        /// ID of the gateway used ad next hop.
        /// 
        /// &gt; **NOTE:** Only one of `next_hop_address` or `gateway_id` should be specified.
        /// </summary>
        [Input("gatewayId")]
        public Input<string>? GatewayId { get; set; }

        /// <summary>
        /// Address of the next hop.
        /// </summary>
        [Input("nextHopAddress")]
        public Input<string>? NextHopAddress { get; set; }

        public VpcRouteTableStaticRouteArgs()
        {
        }
        public static new VpcRouteTableStaticRouteArgs Empty => new VpcRouteTableStaticRouteArgs();
    }
}
