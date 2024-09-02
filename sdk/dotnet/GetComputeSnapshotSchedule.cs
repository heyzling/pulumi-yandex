// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetComputeSnapshotSchedule
    {
        public static Task<GetComputeSnapshotScheduleResult> InvokeAsync(GetComputeSnapshotScheduleArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetComputeSnapshotScheduleResult>("yandex:index/getComputeSnapshotSchedule:getComputeSnapshotSchedule", args ?? new GetComputeSnapshotScheduleArgs(), options.WithDefaults());

        public static Output<GetComputeSnapshotScheduleResult> Invoke(GetComputeSnapshotScheduleInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetComputeSnapshotScheduleResult>("yandex:index/getComputeSnapshotSchedule:getComputeSnapshotSchedule", args ?? new GetComputeSnapshotScheduleInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetComputeSnapshotScheduleArgs : global::Pulumi.InvokeArgs
    {
        [Input("description")]
        public string? Description { get; set; }

        [Input("diskIds")]
        private List<string>? _diskIds;
        public List<string> DiskIds
        {
            get => _diskIds ?? (_diskIds = new List<string>());
            set => _diskIds = value;
        }

        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("labels")]
        private Dictionary<string, string>? _labels;
        public Dictionary<string, string> Labels
        {
            get => _labels ?? (_labels = new Dictionary<string, string>());
            set => _labels = value;
        }

        [Input("name")]
        public string? Name { get; set; }

        [Input("retentionPeriod")]
        public string? RetentionPeriod { get; set; }

        [Input("schedulePolicies")]
        private List<Inputs.GetComputeSnapshotScheduleSchedulePolicyArgs>? _schedulePolicies;
        public List<Inputs.GetComputeSnapshotScheduleSchedulePolicyArgs> SchedulePolicies
        {
            get => _schedulePolicies ?? (_schedulePolicies = new List<Inputs.GetComputeSnapshotScheduleSchedulePolicyArgs>());
            set => _schedulePolicies = value;
        }

        [Input("snapshotCount")]
        public int? SnapshotCount { get; set; }

        [Input("snapshotScheduleId")]
        public string? SnapshotScheduleId { get; set; }

        [Input("snapshotSpecs")]
        private List<Inputs.GetComputeSnapshotScheduleSnapshotSpecArgs>? _snapshotSpecs;
        public List<Inputs.GetComputeSnapshotScheduleSnapshotSpecArgs> SnapshotSpecs
        {
            get => _snapshotSpecs ?? (_snapshotSpecs = new List<Inputs.GetComputeSnapshotScheduleSnapshotSpecArgs>());
            set => _snapshotSpecs = value;
        }

        public GetComputeSnapshotScheduleArgs()
        {
        }
        public static new GetComputeSnapshotScheduleArgs Empty => new GetComputeSnapshotScheduleArgs();
    }

    public sealed class GetComputeSnapshotScheduleInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("diskIds")]
        private InputList<string>? _diskIds;
        public InputList<string> DiskIds
        {
            get => _diskIds ?? (_diskIds = new InputList<string>());
            set => _diskIds = value;
        }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("retentionPeriod")]
        public Input<string>? RetentionPeriod { get; set; }

        [Input("schedulePolicies")]
        private InputList<Inputs.GetComputeSnapshotScheduleSchedulePolicyInputArgs>? _schedulePolicies;
        public InputList<Inputs.GetComputeSnapshotScheduleSchedulePolicyInputArgs> SchedulePolicies
        {
            get => _schedulePolicies ?? (_schedulePolicies = new InputList<Inputs.GetComputeSnapshotScheduleSchedulePolicyInputArgs>());
            set => _schedulePolicies = value;
        }

        [Input("snapshotCount")]
        public Input<int>? SnapshotCount { get; set; }

        [Input("snapshotScheduleId")]
        public Input<string>? SnapshotScheduleId { get; set; }

        [Input("snapshotSpecs")]
        private InputList<Inputs.GetComputeSnapshotScheduleSnapshotSpecInputArgs>? _snapshotSpecs;
        public InputList<Inputs.GetComputeSnapshotScheduleSnapshotSpecInputArgs> SnapshotSpecs
        {
            get => _snapshotSpecs ?? (_snapshotSpecs = new InputList<Inputs.GetComputeSnapshotScheduleSnapshotSpecInputArgs>());
            set => _snapshotSpecs = value;
        }

        public GetComputeSnapshotScheduleInvokeArgs()
        {
        }
        public static new GetComputeSnapshotScheduleInvokeArgs Empty => new GetComputeSnapshotScheduleInvokeArgs();
    }


    [OutputType]
    public sealed class GetComputeSnapshotScheduleResult
    {
        public readonly string CreatedAt;
        public readonly string Description;
        public readonly ImmutableArray<string> DiskIds;
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        public readonly string RetentionPeriod;
        public readonly ImmutableArray<Outputs.GetComputeSnapshotScheduleSchedulePolicyResult> SchedulePolicies;
        public readonly int SnapshotCount;
        public readonly string SnapshotScheduleId;
        public readonly ImmutableArray<Outputs.GetComputeSnapshotScheduleSnapshotSpecResult> SnapshotSpecs;
        public readonly string Status;

        [OutputConstructor]
        private GetComputeSnapshotScheduleResult(
            string createdAt,

            string description,

            ImmutableArray<string> diskIds,

            string folderId,

            string id,

            ImmutableDictionary<string, string> labels,

            string name,

            string retentionPeriod,

            ImmutableArray<Outputs.GetComputeSnapshotScheduleSchedulePolicyResult> schedulePolicies,

            int snapshotCount,

            string snapshotScheduleId,

            ImmutableArray<Outputs.GetComputeSnapshotScheduleSnapshotSpecResult> snapshotSpecs,

            string status)
        {
            CreatedAt = createdAt;
            Description = description;
            DiskIds = diskIds;
            FolderId = folderId;
            Id = id;
            Labels = labels;
            Name = name;
            RetentionPeriod = retentionPeriod;
            SchedulePolicies = schedulePolicies;
            SnapshotCount = snapshotCount;
            SnapshotScheduleId = snapshotScheduleId;
            SnapshotSpecs = snapshotSpecs;
            Status = status;
        }
    }
}
