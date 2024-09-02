// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetVpcRouteTable
    {
        public static Task<GetVpcRouteTableResult> InvokeAsync(GetVpcRouteTableArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetVpcRouteTableResult>("yandex:index/getVpcRouteTable:getVpcRouteTable", args ?? new GetVpcRouteTableArgs(), options.WithDefaults());

        public static Output<GetVpcRouteTableResult> Invoke(GetVpcRouteTableInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetVpcRouteTableResult>("yandex:index/getVpcRouteTable:getVpcRouteTable", args ?? new GetVpcRouteTableInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVpcRouteTableArgs : global::Pulumi.InvokeArgs
    {
        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("routeTableId")]
        public string? RouteTableId { get; set; }

        public GetVpcRouteTableArgs()
        {
        }
        public static new GetVpcRouteTableArgs Empty => new GetVpcRouteTableArgs();
    }

    public sealed class GetVpcRouteTableInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("routeTableId")]
        public Input<string>? RouteTableId { get; set; }

        public GetVpcRouteTableInvokeArgs()
        {
        }
        public static new GetVpcRouteTableInvokeArgs Empty => new GetVpcRouteTableInvokeArgs();
    }


    [OutputType]
    public sealed class GetVpcRouteTableResult
    {
        public readonly string CreatedAt;
        public readonly string Description;
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        public readonly string NetworkId;
        public readonly string RouteTableId;
        public readonly ImmutableArray<Outputs.GetVpcRouteTableStaticRouteResult> StaticRoutes;

        [OutputConstructor]
        private GetVpcRouteTableResult(
            string createdAt,

            string description,

            string folderId,

            string id,

            ImmutableDictionary<string, string> labels,

            string name,

            string networkId,

            string routeTableId,

            ImmutableArray<Outputs.GetVpcRouteTableStaticRouteResult> staticRoutes)
        {
            CreatedAt = createdAt;
            Description = description;
            FolderId = folderId;
            Id = id;
            Labels = labels;
            Name = name;
            NetworkId = networkId;
            RouteTableId = routeTableId;
            StaticRoutes = staticRoutes;
        }
    }
}
