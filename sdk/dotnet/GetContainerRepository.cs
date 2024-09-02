// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetContainerRepository
    {
        public static Task<GetContainerRepositoryResult> InvokeAsync(GetContainerRepositoryArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetContainerRepositoryResult>("yandex:index/getContainerRepository:getContainerRepository", args ?? new GetContainerRepositoryArgs(), options.WithDefaults());

        public static Output<GetContainerRepositoryResult> Invoke(GetContainerRepositoryInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetContainerRepositoryResult>("yandex:index/getContainerRepository:getContainerRepository", args ?? new GetContainerRepositoryInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetContainerRepositoryArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public string? Name { get; set; }

        [Input("repositoryId")]
        public string? RepositoryId { get; set; }

        public GetContainerRepositoryArgs()
        {
        }
        public static new GetContainerRepositoryArgs Empty => new GetContainerRepositoryArgs();
    }

    public sealed class GetContainerRepositoryInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("repositoryId")]
        public Input<string>? RepositoryId { get; set; }

        public GetContainerRepositoryInvokeArgs()
        {
        }
        public static new GetContainerRepositoryInvokeArgs Empty => new GetContainerRepositoryInvokeArgs();
    }


    [OutputType]
    public sealed class GetContainerRepositoryResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        public readonly string RepositoryId;

        [OutputConstructor]
        private GetContainerRepositoryResult(
            string id,

            string name,

            string repositoryId)
        {
            Id = id;
            Name = name;
            RepositoryId = repositoryId;
        }
    }
}
