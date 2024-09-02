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
    public sealed class MdbClickhouseClusterClickhouseConfigMergeTree
    {
        /// <summary>
        /// Enables the check at table creation, that the data type of a column for sampling or sampling expression is correct. The data type must be one of unsigned integer types: UInt8, UInt16, UInt32, UInt64. Default value: true.
        /// </summary>
        public readonly bool? CheckSampleColumnIsCorrect;
        /// <summary>
        /// Minimum period to clean old queue logs, blocks hashes and parts.
        /// </summary>
        public readonly int? CleanupDelayPeriod;
        /// <summary>
        /// The `too many parts` check according to `parts_to_delay_insert` and `parts_to_throw_insert` will be active only if the average part size (in the relevant partition) is not larger than the specified threshold. If it is larger than the specified threshold, the INSERTs will be neither delayed or rejected. This allows to have hundreds of terabytes in a single table on a single server if the parts are successfully merged to larger parts. This does not affect the thresholds on inactive parts or total parts.
        /// </summary>
        public readonly int? MaxAvgPartSizeForTooManyParts;
        /// <summary>
        /// Max bytes to merge at min space in pool: Maximum total size of a data part to merge when the number of free threads in the background pool is minimum.
        /// </summary>
        public readonly int? MaxBytesToMergeAtMinSpaceInPool;
        /// <summary>
        /// Maximum period to clean old queue logs, blocks hashes and parts. Default value: 300 seconds.
        /// </summary>
        public readonly int? MaxCleanupDelayPeriod;
        /// <summary>
        /// Maximum sleep time for merge selecting, a lower setting will trigger selecting tasks in background_schedule_pool frequently which result in large amount of requests to zookeeper in large-scale clusters. Default value: 60000 milliseconds (60 seconds).
        /// </summary>
        public readonly int? MaxMergeSelectingSleepMs;
        /// <summary>
        /// When there is more than specified number of merges with TTL entries in pool, do not assign new merge with TTL.
        /// </summary>
        public readonly int? MaxNumberOfMergesWithTtlInPool;
        /// <summary>
        /// Maximum number of parts in all partitions.
        /// </summary>
        public readonly int? MaxPartsInTotal;
        /// <summary>
        /// Max replicated merges in queue: Maximum number of merge tasks that can be in the ReplicatedMergeTree queue at the same time.
        /// </summary>
        public readonly int? MaxReplicatedMergesInQueue;
        /// <summary>
        /// The number of rows that are read from the merged parts into memory. Default value: 8192.
        /// </summary>
        public readonly int? MergeMaxBlockSize;
        /// <summary>
        /// Sleep time for merge selecting when no part is selected. A lower setting triggers selecting tasks in background_schedule_pool frequently, which results in a large number of requests to ClickHouse Keeper in large-scale clusters.
        /// </summary>
        public readonly int? MergeSelectingSleepMs;
        /// <summary>
        /// Minimum delay in seconds before repeating a merge with recompression TTL. Default value: 14400 seconds (4 hours).
        /// </summary>
        public readonly int? MergeWithRecompressionTtlTimeout;
        /// <summary>
        /// Minimum delay in seconds before repeating a merge with delete TTL. Default value: 14400 seconds (4 hours).
        /// </summary>
        public readonly int? MergeWithTtlTimeout;
        /// <summary>
        /// Whether min_age_to_force_merge_seconds should be applied only on the entire partition and not on subset.
        /// </summary>
        public readonly bool? MinAgeToForceMergeOnPartitionOnly;
        /// <summary>
        /// Merge parts if every part in the range is older than the value of `min_age_to_force_merge_seconds`.
        /// </summary>
        public readonly int? MinAgeToForceMergeSeconds;
        /// <summary>
        /// Minimum number of bytes in a data part that can be stored in Wide format. You can set one, both or none of these settings.
        /// </summary>
        public readonly int? MinBytesForWidePart;
        /// <summary>
        /// Minimum number of rows in a data part that can be stored in Wide format. You can set one, both or none of these settings.
        /// </summary>
        public readonly int? MinRowsForWidePart;
        /// <summary>
        /// Number of free entries in pool to lower max size of merge: Threshold value of free entries in the pool. If the number of entries in the pool falls below this value, ClickHouse reduces the maximum size of a data part to merge. This helps handle small merges faster, rather than filling the pool with lengthy merges.
        /// </summary>
        public readonly int? NumberOfFreeEntriesInPoolToLowerMaxSizeOfMerge;
        /// <summary>
        /// Parts to delay insert: Number of active data parts in a table, on exceeding which ClickHouse starts artificially reduce the rate of inserting data into the table.
        /// </summary>
        public readonly int? PartsToDelayInsert;
        /// <summary>
        /// Parts to throw insert: Threshold value of active data parts in a table, on exceeding which ClickHouse throws the 'Too many parts ...' exception.
        /// </summary>
        public readonly int? PartsToThrowInsert;
        /// <summary>
        /// Replicated deduplication window: Number of recent hash blocks that ZooKeeper will store (the old ones will be deleted).
        /// </summary>
        public readonly int? ReplicatedDeduplicationWindow;
        /// <summary>
        /// Replicated deduplication window seconds: Time during which ZooKeeper stores the hash blocks (the old ones wil be deleted).
        /// </summary>
        public readonly int? ReplicatedDeduplicationWindowSeconds;
        /// <summary>
        /// Enables or disables complete dropping of data parts where all rows are expired in MergeTree tables.
        /// </summary>
        public readonly bool? TtlOnlyDropParts;

        [OutputConstructor]
        private MdbClickhouseClusterClickhouseConfigMergeTree(
            bool? checkSampleColumnIsCorrect,

            int? cleanupDelayPeriod,

            int? maxAvgPartSizeForTooManyParts,

            int? maxBytesToMergeAtMinSpaceInPool,

            int? maxCleanupDelayPeriod,

            int? maxMergeSelectingSleepMs,

            int? maxNumberOfMergesWithTtlInPool,

            int? maxPartsInTotal,

            int? maxReplicatedMergesInQueue,

            int? mergeMaxBlockSize,

            int? mergeSelectingSleepMs,

            int? mergeWithRecompressionTtlTimeout,

            int? mergeWithTtlTimeout,

            bool? minAgeToForceMergeOnPartitionOnly,

            int? minAgeToForceMergeSeconds,

            int? minBytesForWidePart,

            int? minRowsForWidePart,

            int? numberOfFreeEntriesInPoolToLowerMaxSizeOfMerge,

            int? partsToDelayInsert,

            int? partsToThrowInsert,

            int? replicatedDeduplicationWindow,

            int? replicatedDeduplicationWindowSeconds,

            bool? ttlOnlyDropParts)
        {
            CheckSampleColumnIsCorrect = checkSampleColumnIsCorrect;
            CleanupDelayPeriod = cleanupDelayPeriod;
            MaxAvgPartSizeForTooManyParts = maxAvgPartSizeForTooManyParts;
            MaxBytesToMergeAtMinSpaceInPool = maxBytesToMergeAtMinSpaceInPool;
            MaxCleanupDelayPeriod = maxCleanupDelayPeriod;
            MaxMergeSelectingSleepMs = maxMergeSelectingSleepMs;
            MaxNumberOfMergesWithTtlInPool = maxNumberOfMergesWithTtlInPool;
            MaxPartsInTotal = maxPartsInTotal;
            MaxReplicatedMergesInQueue = maxReplicatedMergesInQueue;
            MergeMaxBlockSize = mergeMaxBlockSize;
            MergeSelectingSleepMs = mergeSelectingSleepMs;
            MergeWithRecompressionTtlTimeout = mergeWithRecompressionTtlTimeout;
            MergeWithTtlTimeout = mergeWithTtlTimeout;
            MinAgeToForceMergeOnPartitionOnly = minAgeToForceMergeOnPartitionOnly;
            MinAgeToForceMergeSeconds = minAgeToForceMergeSeconds;
            MinBytesForWidePart = minBytesForWidePart;
            MinRowsForWidePart = minRowsForWidePart;
            NumberOfFreeEntriesInPoolToLowerMaxSizeOfMerge = numberOfFreeEntriesInPoolToLowerMaxSizeOfMerge;
            PartsToDelayInsert = partsToDelayInsert;
            PartsToThrowInsert = partsToThrowInsert;
            ReplicatedDeduplicationWindow = replicatedDeduplicationWindow;
            ReplicatedDeduplicationWindowSeconds = replicatedDeduplicationWindowSeconds;
            TtlOnlyDropParts = ttlOnlyDropParts;
        }
    }
}