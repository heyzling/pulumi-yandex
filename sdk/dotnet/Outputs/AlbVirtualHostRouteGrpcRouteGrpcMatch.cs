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
    public sealed class AlbVirtualHostRouteGrpcRouteGrpcMatch
    {
        /// <summary>
        /// If not set, all services/methods are assumed. The structure is documented below.
        /// </summary>
        public readonly Outputs.AlbVirtualHostRouteGrpcRouteGrpcMatchFqmn? Fqmn;

        [OutputConstructor]
        private AlbVirtualHostRouteGrpcRouteGrpcMatch(Outputs.AlbVirtualHostRouteGrpcRouteGrpcMatchFqmn? fqmn)
        {
            Fqmn = fqmn;
        }
    }
}