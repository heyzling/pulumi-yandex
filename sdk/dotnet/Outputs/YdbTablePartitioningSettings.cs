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
    public sealed class YdbTablePartitioningSettings
    {
        public readonly bool? AutoPartitioningByLoad;
        public readonly bool? AutoPartitioningBySizeEnabled;
        public readonly int? AutoPartitioningMaxPartitionsCount;
        public readonly int? AutoPartitioningMinPartitionsCount;
        public readonly int? AutoPartitioningPartitionSizeMb;
        public readonly ImmutableArray<Outputs.YdbTablePartitioningSettingsPartitionAtKey> PartitionAtKeys;
        public readonly int? UniformPartitions;

        [OutputConstructor]
        private YdbTablePartitioningSettings(
            bool? autoPartitioningByLoad,

            bool? autoPartitioningBySizeEnabled,

            int? autoPartitioningMaxPartitionsCount,

            int? autoPartitioningMinPartitionsCount,

            int? autoPartitioningPartitionSizeMb,

            ImmutableArray<Outputs.YdbTablePartitioningSettingsPartitionAtKey> partitionAtKeys,

            int? uniformPartitions)
        {
            AutoPartitioningByLoad = autoPartitioningByLoad;
            AutoPartitioningBySizeEnabled = autoPartitioningBySizeEnabled;
            AutoPartitioningMaxPartitionsCount = autoPartitioningMaxPartitionsCount;
            AutoPartitioningMinPartitionsCount = autoPartitioningMinPartitionsCount;
            AutoPartitioningPartitionSizeMb = autoPartitioningPartitionSizeMb;
            PartitionAtKeys = partitionAtKeys;
            UniformPartitions = uniformPartitions;
        }
    }
}
