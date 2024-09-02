// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class YdbTablePartitioningSettingsArgs : global::Pulumi.ResourceArgs
    {
        [Input("autoPartitioningByLoad")]
        public Input<bool>? AutoPartitioningByLoad { get; set; }

        [Input("autoPartitioningBySizeEnabled")]
        public Input<bool>? AutoPartitioningBySizeEnabled { get; set; }

        [Input("autoPartitioningMaxPartitionsCount")]
        public Input<int>? AutoPartitioningMaxPartitionsCount { get; set; }

        [Input("autoPartitioningMinPartitionsCount")]
        public Input<int>? AutoPartitioningMinPartitionsCount { get; set; }

        [Input("autoPartitioningPartitionSizeMb")]
        public Input<int>? AutoPartitioningPartitionSizeMb { get; set; }

        [Input("partitionAtKeys")]
        private InputList<Inputs.YdbTablePartitioningSettingsPartitionAtKeyArgs>? _partitionAtKeys;
        public InputList<Inputs.YdbTablePartitioningSettingsPartitionAtKeyArgs> PartitionAtKeys
        {
            get => _partitionAtKeys ?? (_partitionAtKeys = new InputList<Inputs.YdbTablePartitioningSettingsPartitionAtKeyArgs>());
            set => _partitionAtKeys = value;
        }

        [Input("uniformPartitions")]
        public Input<int>? UniformPartitions { get; set; }

        public YdbTablePartitioningSettingsArgs()
        {
        }
        public static new YdbTablePartitioningSettingsArgs Empty => new YdbTablePartitioningSettingsArgs();
    }
}
