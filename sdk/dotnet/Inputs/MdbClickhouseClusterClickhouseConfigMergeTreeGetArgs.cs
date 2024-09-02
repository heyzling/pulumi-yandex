// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterClickhouseConfigMergeTreeGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enables the check at table creation, that the data type of a column for sampling or sampling expression is correct. The data type must be one of unsigned integer types: UInt8, UInt16, UInt32, UInt64. Default value: true.
        /// </summary>
        [Input("checkSampleColumnIsCorrect")]
        public Input<bool>? CheckSampleColumnIsCorrect { get; set; }

        /// <summary>
        /// Minimum period to clean old queue logs, blocks hashes and parts.
        /// </summary>
        [Input("cleanupDelayPeriod")]
        public Input<int>? CleanupDelayPeriod { get; set; }

        /// <summary>
        /// The `too many parts` check according to `parts_to_delay_insert` and `parts_to_throw_insert` will be active only if the average part size (in the relevant partition) is not larger than the specified threshold. If it is larger than the specified threshold, the INSERTs will be neither delayed or rejected. This allows to have hundreds of terabytes in a single table on a single server if the parts are successfully merged to larger parts. This does not affect the thresholds on inactive parts or total parts.
        /// </summary>
        [Input("maxAvgPartSizeForTooManyParts")]
        public Input<int>? MaxAvgPartSizeForTooManyParts { get; set; }

        /// <summary>
        /// Max bytes to merge at min space in pool: Maximum total size of a data part to merge when the number of free threads in the background pool is minimum.
        /// </summary>
        [Input("maxBytesToMergeAtMinSpaceInPool")]
        public Input<int>? MaxBytesToMergeAtMinSpaceInPool { get; set; }

        /// <summary>
        /// Maximum period to clean old queue logs, blocks hashes and parts. Default value: 300 seconds.
        /// </summary>
        [Input("maxCleanupDelayPeriod")]
        public Input<int>? MaxCleanupDelayPeriod { get; set; }

        /// <summary>
        /// Maximum sleep time for merge selecting, a lower setting will trigger selecting tasks in background_schedule_pool frequently which result in large amount of requests to zookeeper in large-scale clusters. Default value: 60000 milliseconds (60 seconds).
        /// </summary>
        [Input("maxMergeSelectingSleepMs")]
        public Input<int>? MaxMergeSelectingSleepMs { get; set; }

        /// <summary>
        /// When there is more than specified number of merges with TTL entries in pool, do not assign new merge with TTL.
        /// </summary>
        [Input("maxNumberOfMergesWithTtlInPool")]
        public Input<int>? MaxNumberOfMergesWithTtlInPool { get; set; }

        /// <summary>
        /// Maximum number of parts in all partitions.
        /// </summary>
        [Input("maxPartsInTotal")]
        public Input<int>? MaxPartsInTotal { get; set; }

        /// <summary>
        /// Max replicated merges in queue: Maximum number of merge tasks that can be in the ReplicatedMergeTree queue at the same time.
        /// </summary>
        [Input("maxReplicatedMergesInQueue")]
        public Input<int>? MaxReplicatedMergesInQueue { get; set; }

        /// <summary>
        /// The number of rows that are read from the merged parts into memory. Default value: 8192.
        /// </summary>
        [Input("mergeMaxBlockSize")]
        public Input<int>? MergeMaxBlockSize { get; set; }

        /// <summary>
        /// Sleep time for merge selecting when no part is selected. A lower setting triggers selecting tasks in background_schedule_pool frequently, which results in a large number of requests to ClickHouse Keeper in large-scale clusters.
        /// </summary>
        [Input("mergeSelectingSleepMs")]
        public Input<int>? MergeSelectingSleepMs { get; set; }

        /// <summary>
        /// Minimum delay in seconds before repeating a merge with recompression TTL. Default value: 14400 seconds (4 hours).
        /// </summary>
        [Input("mergeWithRecompressionTtlTimeout")]
        public Input<int>? MergeWithRecompressionTtlTimeout { get; set; }

        /// <summary>
        /// Minimum delay in seconds before repeating a merge with delete TTL. Default value: 14400 seconds (4 hours).
        /// </summary>
        [Input("mergeWithTtlTimeout")]
        public Input<int>? MergeWithTtlTimeout { get; set; }

        /// <summary>
        /// Whether min_age_to_force_merge_seconds should be applied only on the entire partition and not on subset.
        /// </summary>
        [Input("minAgeToForceMergeOnPartitionOnly")]
        public Input<bool>? MinAgeToForceMergeOnPartitionOnly { get; set; }

        /// <summary>
        /// Merge parts if every part in the range is older than the value of `min_age_to_force_merge_seconds`.
        /// </summary>
        [Input("minAgeToForceMergeSeconds")]
        public Input<int>? MinAgeToForceMergeSeconds { get; set; }

        /// <summary>
        /// Minimum number of bytes in a data part that can be stored in Wide format. You can set one, both or none of these settings.
        /// </summary>
        [Input("minBytesForWidePart")]
        public Input<int>? MinBytesForWidePart { get; set; }

        /// <summary>
        /// Minimum number of rows in a data part that can be stored in Wide format. You can set one, both or none of these settings.
        /// </summary>
        [Input("minRowsForWidePart")]
        public Input<int>? MinRowsForWidePart { get; set; }

        /// <summary>
        /// Number of free entries in pool to lower max size of merge: Threshold value of free entries in the pool. If the number of entries in the pool falls below this value, ClickHouse reduces the maximum size of a data part to merge. This helps handle small merges faster, rather than filling the pool with lengthy merges.
        /// </summary>
        [Input("numberOfFreeEntriesInPoolToLowerMaxSizeOfMerge")]
        public Input<int>? NumberOfFreeEntriesInPoolToLowerMaxSizeOfMerge { get; set; }

        /// <summary>
        /// Parts to delay insert: Number of active data parts in a table, on exceeding which ClickHouse starts artificially reduce the rate of inserting data into the table.
        /// </summary>
        [Input("partsToDelayInsert")]
        public Input<int>? PartsToDelayInsert { get; set; }

        /// <summary>
        /// Parts to throw insert: Threshold value of active data parts in a table, on exceeding which ClickHouse throws the 'Too many parts ...' exception.
        /// </summary>
        [Input("partsToThrowInsert")]
        public Input<int>? PartsToThrowInsert { get; set; }

        /// <summary>
        /// Replicated deduplication window: Number of recent hash blocks that ZooKeeper will store (the old ones will be deleted).
        /// </summary>
        [Input("replicatedDeduplicationWindow")]
        public Input<int>? ReplicatedDeduplicationWindow { get; set; }

        /// <summary>
        /// Replicated deduplication window seconds: Time during which ZooKeeper stores the hash blocks (the old ones wil be deleted).
        /// </summary>
        [Input("replicatedDeduplicationWindowSeconds")]
        public Input<int>? ReplicatedDeduplicationWindowSeconds { get; set; }

        /// <summary>
        /// Enables or disables complete dropping of data parts where all rows are expired in MergeTree tables.
        /// </summary>
        [Input("ttlOnlyDropParts")]
        public Input<bool>? TtlOnlyDropParts { get; set; }

        public MdbClickhouseClusterClickhouseConfigMergeTreeGetArgs()
        {
        }
        public static new MdbClickhouseClusterClickhouseConfigMergeTreeGetArgs Empty => new MdbClickhouseClusterClickhouseConfigMergeTreeGetArgs();
    }
}
