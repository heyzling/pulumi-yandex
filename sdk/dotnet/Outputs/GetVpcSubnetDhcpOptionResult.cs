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
    public sealed class GetVpcSubnetDhcpOptionResult
    {
        public readonly string DomainName;
        public readonly ImmutableArray<string> DomainNameServers;
        public readonly ImmutableArray<string> NtpServers;

        [OutputConstructor]
        private GetVpcSubnetDhcpOptionResult(
            string domainName,

            ImmutableArray<string> domainNameServers,

            ImmutableArray<string> ntpServers)
        {
            DomainName = domainName;
            DomainNameServers = domainNameServers;
            NtpServers = ntpServers;
        }
    }
}
