// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetComputeInstanceGroup
    {
        public static Task<GetComputeInstanceGroupResult> InvokeAsync(GetComputeInstanceGroupArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetComputeInstanceGroupResult>("yandex:index/getComputeInstanceGroup:getComputeInstanceGroup", args ?? new GetComputeInstanceGroupArgs(), options.WithDefaults());

        public static Output<GetComputeInstanceGroupResult> Invoke(GetComputeInstanceGroupInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetComputeInstanceGroupResult>("yandex:index/getComputeInstanceGroup:getComputeInstanceGroup", args ?? new GetComputeInstanceGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetComputeInstanceGroupArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceGroupId", required: true)]
        public string InstanceGroupId { get; set; } = null!;

        public GetComputeInstanceGroupArgs()
        {
        }
        public static new GetComputeInstanceGroupArgs Empty => new GetComputeInstanceGroupArgs();
    }

    public sealed class GetComputeInstanceGroupInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceGroupId", required: true)]
        public Input<string> InstanceGroupId { get; set; } = null!;

        public GetComputeInstanceGroupInvokeArgs()
        {
        }
        public static new GetComputeInstanceGroupInvokeArgs Empty => new GetComputeInstanceGroupInvokeArgs();
    }


    [OutputType]
    public sealed class GetComputeInstanceGroupResult
    {
        public readonly ImmutableArray<Outputs.GetComputeInstanceGroupAllocationPolicyResult> AllocationPolicies;
        public readonly ImmutableArray<Outputs.GetComputeInstanceGroupApplicationBalancerStateResult> ApplicationBalancerStates;
        public readonly ImmutableArray<Outputs.GetComputeInstanceGroupApplicationLoadBalancerResult> ApplicationLoadBalancers;
        public readonly string CreatedAt;
        public readonly bool DeletionProtection;
        public readonly ImmutableArray<Outputs.GetComputeInstanceGroupDeployPolicyResult> DeployPolicies;
        public readonly string Description;
        public readonly string FolderId;
        public readonly ImmutableArray<Outputs.GetComputeInstanceGroupHealthCheckResult> HealthChecks;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceGroupId;
        public readonly ImmutableArray<Outputs.GetComputeInstanceGroupInstanceTemplateResult> InstanceTemplates;
        public readonly ImmutableArray<Outputs.GetComputeInstanceGroupInstanceResult> Instances;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly ImmutableArray<Outputs.GetComputeInstanceGroupLoadBalancerStateResult> LoadBalancerStates;
        public readonly ImmutableArray<Outputs.GetComputeInstanceGroupLoadBalancerResult> LoadBalancers;
        public readonly int MaxCheckingHealthDuration;
        public readonly string Name;
        public readonly ImmutableArray<Outputs.GetComputeInstanceGroupScalePolicyResult> ScalePolicies;
        public readonly string ServiceAccountId;
        public readonly string Status;
        public readonly ImmutableDictionary<string, string> Variables;

        [OutputConstructor]
        private GetComputeInstanceGroupResult(
            ImmutableArray<Outputs.GetComputeInstanceGroupAllocationPolicyResult> allocationPolicies,

            ImmutableArray<Outputs.GetComputeInstanceGroupApplicationBalancerStateResult> applicationBalancerStates,

            ImmutableArray<Outputs.GetComputeInstanceGroupApplicationLoadBalancerResult> applicationLoadBalancers,

            string createdAt,

            bool deletionProtection,

            ImmutableArray<Outputs.GetComputeInstanceGroupDeployPolicyResult> deployPolicies,

            string description,

            string folderId,

            ImmutableArray<Outputs.GetComputeInstanceGroupHealthCheckResult> healthChecks,

            string id,

            string instanceGroupId,

            ImmutableArray<Outputs.GetComputeInstanceGroupInstanceTemplateResult> instanceTemplates,

            ImmutableArray<Outputs.GetComputeInstanceGroupInstanceResult> instances,

            ImmutableDictionary<string, string> labels,

            ImmutableArray<Outputs.GetComputeInstanceGroupLoadBalancerStateResult> loadBalancerStates,

            ImmutableArray<Outputs.GetComputeInstanceGroupLoadBalancerResult> loadBalancers,

            int maxCheckingHealthDuration,

            string name,

            ImmutableArray<Outputs.GetComputeInstanceGroupScalePolicyResult> scalePolicies,

            string serviceAccountId,

            string status,

            ImmutableDictionary<string, string> variables)
        {
            AllocationPolicies = allocationPolicies;
            ApplicationBalancerStates = applicationBalancerStates;
            ApplicationLoadBalancers = applicationLoadBalancers;
            CreatedAt = createdAt;
            DeletionProtection = deletionProtection;
            DeployPolicies = deployPolicies;
            Description = description;
            FolderId = folderId;
            HealthChecks = healthChecks;
            Id = id;
            InstanceGroupId = instanceGroupId;
            InstanceTemplates = instanceTemplates;
            Instances = instances;
            Labels = labels;
            LoadBalancerStates = loadBalancerStates;
            LoadBalancers = loadBalancers;
            MaxCheckingHealthDuration = maxCheckingHealthDuration;
            Name = name;
            ScalePolicies = scalePolicies;
            ServiceAccountId = serviceAccountId;
            Status = status;
            Variables = variables;
        }
    }
}
