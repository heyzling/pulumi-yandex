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
    public sealed class DatatransferEndpointSettingsClickhouseTargetSharding
    {
        /// <summary>
        /// Shard data by the hash value of the specified column. The structure is documented below.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsClickhouseTargetShardingColumnValueHash? ColumnValueHash;
        /// <summary>
        /// A custom shard mapping by the value of the specified column. The structure is documented below.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsClickhouseTargetShardingCustomMapping? CustomMapping;
        /// <summary>
        /// Distribute incoming rows between ClickHouse shards in a round-robin manner. Specify as an empty block to enable.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsClickhouseTargetShardingRoundRobin? RoundRobin;
        /// <summary>
        /// Shard data by ID of the transfer.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsClickhouseTargetShardingTransferId? TransferId;

        [OutputConstructor]
        private DatatransferEndpointSettingsClickhouseTargetSharding(
            Outputs.DatatransferEndpointSettingsClickhouseTargetShardingColumnValueHash? columnValueHash,

            Outputs.DatatransferEndpointSettingsClickhouseTargetShardingCustomMapping? customMapping,

            Outputs.DatatransferEndpointSettingsClickhouseTargetShardingRoundRobin? roundRobin,

            Outputs.DatatransferEndpointSettingsClickhouseTargetShardingTransferId? transferId)
        {
            ColumnValueHash = columnValueHash;
            CustomMapping = customMapping;
            RoundRobin = roundRobin;
            TransferId = transferId;
        }
    }
}
