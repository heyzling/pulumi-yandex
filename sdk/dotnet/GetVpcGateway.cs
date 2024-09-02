// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetVpcGateway
    {
        public static Task<GetVpcGatewayResult> InvokeAsync(GetVpcGatewayArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetVpcGatewayResult>("yandex:index/getVpcGateway:getVpcGateway", args ?? new GetVpcGatewayArgs(), options.WithDefaults());

        public static Output<GetVpcGatewayResult> Invoke(GetVpcGatewayInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetVpcGatewayResult>("yandex:index/getVpcGateway:getVpcGateway", args ?? new GetVpcGatewayInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVpcGatewayArgs : global::Pulumi.InvokeArgs
    {
        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("gatewayId")]
        public string? GatewayId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("sharedEgressGateway")]
        public Inputs.GetVpcGatewaySharedEgressGatewayArgs? SharedEgressGateway { get; set; }

        public GetVpcGatewayArgs()
        {
        }
        public static new GetVpcGatewayArgs Empty => new GetVpcGatewayArgs();
    }

    public sealed class GetVpcGatewayInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("gatewayId")]
        public Input<string>? GatewayId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("sharedEgressGateway")]
        public Input<Inputs.GetVpcGatewaySharedEgressGatewayInputArgs>? SharedEgressGateway { get; set; }

        public GetVpcGatewayInvokeArgs()
        {
        }
        public static new GetVpcGatewayInvokeArgs Empty => new GetVpcGatewayInvokeArgs();
    }


    [OutputType]
    public sealed class GetVpcGatewayResult
    {
        public readonly string CreatedAt;
        public readonly string Description;
        public readonly string FolderId;
        public readonly string GatewayId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        public readonly Outputs.GetVpcGatewaySharedEgressGatewayResult? SharedEgressGateway;

        [OutputConstructor]
        private GetVpcGatewayResult(
            string createdAt,

            string description,

            string folderId,

            string gatewayId,

            string id,

            ImmutableDictionary<string, string> labels,

            string name,

            Outputs.GetVpcGatewaySharedEgressGatewayResult? sharedEgressGateway)
        {
            CreatedAt = createdAt;
            Description = description;
            FolderId = folderId;
            GatewayId = gatewayId;
            Id = id;
            Labels = labels;
            Name = name;
            SharedEgressGateway = sharedEgressGateway;
        }
    }
}