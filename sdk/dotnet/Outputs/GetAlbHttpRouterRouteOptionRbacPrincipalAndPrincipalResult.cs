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
    public sealed class GetAlbHttpRouterRouteOptionRbacPrincipalAndPrincipalResult
    {
        public readonly bool Any;
        public readonly ImmutableArray<Outputs.GetAlbHttpRouterRouteOptionRbacPrincipalAndPrincipalHeaderResult> Headers;
        public readonly string RemoteIp;

        [OutputConstructor]
        private GetAlbHttpRouterRouteOptionRbacPrincipalAndPrincipalResult(
            bool any,

            ImmutableArray<Outputs.GetAlbHttpRouterRouteOptionRbacPrincipalAndPrincipalHeaderResult> headers,

            string remoteIp)
        {
            Any = any;
            Headers = headers;
            RemoteIp = remoteIp;
        }
    }
}
