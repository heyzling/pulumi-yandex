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
    public sealed class AlbLoadBalancerListenerEndpointAddressExternalIpv6Address
    {
        /// <summary>
        /// Provided by the client or computed automatically.
        /// </summary>
        public readonly string? Address;

        [OutputConstructor]
        private AlbLoadBalancerListenerEndpointAddressExternalIpv6Address(string? address)
        {
            Address = address;
        }
    }
}
