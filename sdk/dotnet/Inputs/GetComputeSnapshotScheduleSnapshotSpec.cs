// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetComputeSnapshotScheduleSnapshotSpecArgs : global::Pulumi.InvokeArgs
    {
        [Input("description", required: true)]
        public string Description { get; set; } = null!;

        [Input("labels", required: true)]
        private Dictionary<string, string>? _labels;
        public Dictionary<string, string> Labels
        {
            get => _labels ?? (_labels = new Dictionary<string, string>());
            set => _labels = value;
        }

        public GetComputeSnapshotScheduleSnapshotSpecArgs()
        {
        }
        public static new GetComputeSnapshotScheduleSnapshotSpecArgs Empty => new GetComputeSnapshotScheduleSnapshotSpecArgs();
    }
}
