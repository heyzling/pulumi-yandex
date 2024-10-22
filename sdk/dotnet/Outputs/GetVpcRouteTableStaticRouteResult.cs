// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class GetVpcRouteTableStaticRouteResult
    {
        public readonly string DestinationPrefix;
        public readonly string GatewayId;
        public readonly string NextHopAddress;

        [OutputConstructor]
        private GetVpcRouteTableStaticRouteResult(
            string destinationPrefix,

            string gatewayId,

            string nextHopAddress)
        {
            DestinationPrefix = destinationPrefix;
            GatewayId = gatewayId;
            NextHopAddress = nextHopAddress;
        }
    }
}
