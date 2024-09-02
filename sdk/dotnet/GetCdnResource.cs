// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetCdnResource
    {
        public static Task<GetCdnResourceResult> InvokeAsync(GetCdnResourceArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetCdnResourceResult>("yandex:index/getCdnResource:getCdnResource", args ?? new GetCdnResourceArgs(), options.WithDefaults());

        public static Output<GetCdnResourceResult> Invoke(GetCdnResourceInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetCdnResourceResult>("yandex:index/getCdnResource:getCdnResource", args ?? new GetCdnResourceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetCdnResourceArgs : global::Pulumi.InvokeArgs
    {
        [Input("active")]
        public bool? Active { get; set; }

        [Input("cname")]
        public string? Cname { get; set; }

        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("options")]
        public Inputs.GetCdnResourceOptionsArgs? Options { get; set; }

        [Input("originGroupId")]
        public int? OriginGroupId { get; set; }

        [Input("originGroupName")]
        public string? OriginGroupName { get; set; }

        [Input("originProtocol")]
        public string? OriginProtocol { get; set; }

        [Input("resourceId")]
        public string? ResourceId { get; set; }

        [Input("secondaryHostnames")]
        private List<string>? _secondaryHostnames;
        public List<string> SecondaryHostnames
        {
            get => _secondaryHostnames ?? (_secondaryHostnames = new List<string>());
            set => _secondaryHostnames = value;
        }

        [Input("sslCertificate")]
        public Inputs.GetCdnResourceSslCertificateArgs? SslCertificate { get; set; }

        [Input("updatedAt")]
        public string? UpdatedAt { get; set; }

        public GetCdnResourceArgs()
        {
        }
        public static new GetCdnResourceArgs Empty => new GetCdnResourceArgs();
    }

    public sealed class GetCdnResourceInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("active")]
        public Input<bool>? Active { get; set; }

        [Input("cname")]
        public Input<string>? Cname { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("options")]
        public Input<Inputs.GetCdnResourceOptionsInputArgs>? Options { get; set; }

        [Input("originGroupId")]
        public Input<int>? OriginGroupId { get; set; }

        [Input("originGroupName")]
        public Input<string>? OriginGroupName { get; set; }

        [Input("originProtocol")]
        public Input<string>? OriginProtocol { get; set; }

        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

        [Input("secondaryHostnames")]
        private InputList<string>? _secondaryHostnames;
        public InputList<string> SecondaryHostnames
        {
            get => _secondaryHostnames ?? (_secondaryHostnames = new InputList<string>());
            set => _secondaryHostnames = value;
        }

        [Input("sslCertificate")]
        public Input<Inputs.GetCdnResourceSslCertificateInputArgs>? SslCertificate { get; set; }

        [Input("updatedAt")]
        public Input<string>? UpdatedAt { get; set; }

        public GetCdnResourceInvokeArgs()
        {
        }
        public static new GetCdnResourceInvokeArgs Empty => new GetCdnResourceInvokeArgs();
    }


    [OutputType]
    public sealed class GetCdnResourceResult
    {
        public readonly bool? Active;
        public readonly string Cname;
        public readonly string CreatedAt;
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly Outputs.GetCdnResourceOptionsResult Options;
        public readonly int? OriginGroupId;
        public readonly string? OriginGroupName;
        public readonly string? OriginProtocol;
        public readonly string ProviderCname;
        public readonly string ResourceId;
        public readonly ImmutableArray<string> SecondaryHostnames;
        public readonly Outputs.GetCdnResourceSslCertificateResult SslCertificate;
        public readonly string UpdatedAt;

        [OutputConstructor]
        private GetCdnResourceResult(
            bool? active,

            string cname,

            string createdAt,

            string folderId,

            string id,

            Outputs.GetCdnResourceOptionsResult options,

            int? originGroupId,

            string? originGroupName,

            string? originProtocol,

            string providerCname,

            string resourceId,

            ImmutableArray<string> secondaryHostnames,

            Outputs.GetCdnResourceSslCertificateResult sslCertificate,

            string updatedAt)
        {
            Active = active;
            Cname = cname;
            CreatedAt = createdAt;
            FolderId = folderId;
            Id = id;
            Options = options;
            OriginGroupId = originGroupId;
            OriginGroupName = originGroupName;
            OriginProtocol = originProtocol;
            ProviderCname = providerCname;
            ResourceId = resourceId;
            SecondaryHostnames = secondaryHostnames;
            SslCertificate = sslCertificate;
            UpdatedAt = updatedAt;
        }
    }
}
