// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetContainerRepositoryLifecyclePolicy
    {
        public static Task<GetContainerRepositoryLifecyclePolicyResult> InvokeAsync(GetContainerRepositoryLifecyclePolicyArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetContainerRepositoryLifecyclePolicyResult>("yandex:index/getContainerRepositoryLifecyclePolicy:getContainerRepositoryLifecyclePolicy", args ?? new GetContainerRepositoryLifecyclePolicyArgs(), options.WithDefaults());

        public static Output<GetContainerRepositoryLifecyclePolicyResult> Invoke(GetContainerRepositoryLifecyclePolicyInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetContainerRepositoryLifecyclePolicyResult>("yandex:index/getContainerRepositoryLifecyclePolicy:getContainerRepositoryLifecyclePolicy", args ?? new GetContainerRepositoryLifecyclePolicyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetContainerRepositoryLifecyclePolicyArgs : global::Pulumi.InvokeArgs
    {
        [Input("lifecyclePolicyId")]
        public string? LifecyclePolicyId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("repositoryId")]
        public string? RepositoryId { get; set; }

        public GetContainerRepositoryLifecyclePolicyArgs()
        {
        }
        public static new GetContainerRepositoryLifecyclePolicyArgs Empty => new GetContainerRepositoryLifecyclePolicyArgs();
    }

    public sealed class GetContainerRepositoryLifecyclePolicyInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("lifecyclePolicyId")]
        public Input<string>? LifecyclePolicyId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("repositoryId")]
        public Input<string>? RepositoryId { get; set; }

        public GetContainerRepositoryLifecyclePolicyInvokeArgs()
        {
        }
        public static new GetContainerRepositoryLifecyclePolicyInvokeArgs Empty => new GetContainerRepositoryLifecyclePolicyInvokeArgs();
    }


    [OutputType]
    public sealed class GetContainerRepositoryLifecyclePolicyResult
    {
        public readonly string CreatedAt;
        public readonly string Description;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string LifecyclePolicyId;
        public readonly string Name;
        public readonly string RepositoryId;
        public readonly ImmutableArray<Outputs.GetContainerRepositoryLifecyclePolicyRuleResult> Rules;
        public readonly string Status;

        [OutputConstructor]
        private GetContainerRepositoryLifecyclePolicyResult(
            string createdAt,

            string description,

            string id,

            string lifecyclePolicyId,

            string name,

            string repositoryId,

            ImmutableArray<Outputs.GetContainerRepositoryLifecyclePolicyRuleResult> rules,

            string status)
        {
            CreatedAt = createdAt;
            Description = description;
            Id = id;
            LifecyclePolicyId = lifecyclePolicyId;
            Name = name;
            RepositoryId = repositoryId;
            Rules = rules;
            Status = status;
        }
    }
}
