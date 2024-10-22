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
    public sealed class GetLbNetworkLoadBalancerListenerResult
    {
        public readonly ImmutableArray<Outputs.GetLbNetworkLoadBalancerListenerExternalAddressSpecResult> ExternalAddressSpecs;
        public readonly ImmutableArray<Outputs.GetLbNetworkLoadBalancerListenerInternalAddressSpecResult> InternalAddressSpecs;
        public readonly string Name;
        public readonly int Port;
        public readonly string Protocol;
        public readonly int TargetPort;

        [OutputConstructor]
        private GetLbNetworkLoadBalancerListenerResult(
            ImmutableArray<Outputs.GetLbNetworkLoadBalancerListenerExternalAddressSpecResult> externalAddressSpecs,

            ImmutableArray<Outputs.GetLbNetworkLoadBalancerListenerInternalAddressSpecResult> internalAddressSpecs,

            string name,

            int port,

            string protocol,

            int targetPort)
        {
            ExternalAddressSpecs = externalAddressSpecs;
            InternalAddressSpecs = internalAddressSpecs;
            Name = name;
            Port = port;
            Protocol = protocol;
            TargetPort = targetPort;
        }
    }
}
