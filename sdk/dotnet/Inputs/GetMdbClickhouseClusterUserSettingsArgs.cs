// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterUserSettingsInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("addHttpCorsHeader", required: true)]
        public Input<bool> AddHttpCorsHeader { get; set; } = null!;

        [Input("allowDdl", required: true)]
        public Input<bool> AllowDdl { get; set; } = null!;

        [Input("allowIntrospectionFunctions", required: true)]
        public Input<bool> AllowIntrospectionFunctions { get; set; } = null!;

        [Input("allowSuspiciousLowCardinalityTypes", required: true)]
        public Input<bool> AllowSuspiciousLowCardinalityTypes { get; set; } = null!;

        [Input("asyncInsert", required: true)]
        public Input<bool> AsyncInsert { get; set; } = null!;

        [Input("asyncInsertBusyTimeout", required: true)]
        public Input<int> AsyncInsertBusyTimeout { get; set; } = null!;

        [Input("asyncInsertMaxDataSize", required: true)]
        public Input<int> AsyncInsertMaxDataSize { get; set; } = null!;

        [Input("asyncInsertStaleTimeout", required: true)]
        public Input<int> AsyncInsertStaleTimeout { get; set; } = null!;

        [Input("asyncInsertThreads", required: true)]
        public Input<int> AsyncInsertThreads { get; set; } = null!;

        [Input("cancelHttpReadonlyQueriesOnClientClose", required: true)]
        public Input<bool> CancelHttpReadonlyQueriesOnClientClose { get; set; } = null!;

        [Input("compile", required: true)]
        public Input<bool> Compile { get; set; } = null!;

        [Input("compileExpressions", required: true)]
        public Input<bool> CompileExpressions { get; set; } = null!;

        [Input("connectTimeout", required: true)]
        public Input<int> ConnectTimeout { get; set; } = null!;

        [Input("connectTimeoutWithFailover", required: true)]
        public Input<int> ConnectTimeoutWithFailover { get; set; } = null!;

        [Input("countDistinctImplementation", required: true)]
        public Input<string> CountDistinctImplementation { get; set; } = null!;

        [Input("distinctOverflowMode", required: true)]
        public Input<string> DistinctOverflowMode { get; set; } = null!;

        [Input("distributedAggregationMemoryEfficient", required: true)]
        public Input<bool> DistributedAggregationMemoryEfficient { get; set; } = null!;

        [Input("distributedDdlTaskTimeout", required: true)]
        public Input<int> DistributedDdlTaskTimeout { get; set; } = null!;

        [Input("distributedProductMode", required: true)]
        public Input<string> DistributedProductMode { get; set; } = null!;

        [Input("emptyResultForAggregationByEmptySet", required: true)]
        public Input<bool> EmptyResultForAggregationByEmptySet { get; set; } = null!;

        [Input("enableHttpCompression", required: true)]
        public Input<bool> EnableHttpCompression { get; set; } = null!;

        [Input("fallbackToStaleReplicasForDistributedQueries", required: true)]
        public Input<bool> FallbackToStaleReplicasForDistributedQueries { get; set; } = null!;

        [Input("flattenNested", required: true)]
        public Input<bool> FlattenNested { get; set; } = null!;

        [Input("forceIndexByDate", required: true)]
        public Input<bool> ForceIndexByDate { get; set; } = null!;

        [Input("forcePrimaryKey", required: true)]
        public Input<bool> ForcePrimaryKey { get; set; } = null!;

        [Input("groupByOverflowMode", required: true)]
        public Input<string> GroupByOverflowMode { get; set; } = null!;

        [Input("groupByTwoLevelThreshold", required: true)]
        public Input<int> GroupByTwoLevelThreshold { get; set; } = null!;

        [Input("groupByTwoLevelThresholdBytes", required: true)]
        public Input<int> GroupByTwoLevelThresholdBytes { get; set; } = null!;

        [Input("hedgedConnectionTimeoutMs", required: true)]
        public Input<int> HedgedConnectionTimeoutMs { get; set; } = null!;

        [Input("httpConnectionTimeout", required: true)]
        public Input<int> HttpConnectionTimeout { get; set; } = null!;

        [Input("httpHeadersProgressInterval", required: true)]
        public Input<int> HttpHeadersProgressInterval { get; set; } = null!;

        [Input("httpReceiveTimeout", required: true)]
        public Input<int> HttpReceiveTimeout { get; set; } = null!;

        [Input("httpSendTimeout", required: true)]
        public Input<int> HttpSendTimeout { get; set; } = null!;

        [Input("idleConnectionTimeout", required: true)]
        public Input<int> IdleConnectionTimeout { get; set; } = null!;

        [Input("inputFormatDefaultsForOmittedFields", required: true)]
        public Input<bool> InputFormatDefaultsForOmittedFields { get; set; } = null!;

        [Input("inputFormatImportNestedJson", required: true)]
        public Input<bool> InputFormatImportNestedJson { get; set; } = null!;

        [Input("inputFormatParallelParsing", required: true)]
        public Input<bool> InputFormatParallelParsing { get; set; } = null!;

        [Input("inputFormatValuesInterpretExpressions", required: true)]
        public Input<bool> InputFormatValuesInterpretExpressions { get; set; } = null!;

        [Input("insertKeeperMaxRetries", required: true)]
        public Input<int> InsertKeeperMaxRetries { get; set; } = null!;

        [Input("insertNullAsDefault", required: true)]
        public Input<bool> InsertNullAsDefault { get; set; } = null!;

        [Input("insertQuorum", required: true)]
        public Input<int> InsertQuorum { get; set; } = null!;

        [Input("insertQuorumTimeout", required: true)]
        public Input<int> InsertQuorumTimeout { get; set; } = null!;

        [Input("joinOverflowMode", required: true)]
        public Input<string> JoinOverflowMode { get; set; } = null!;

        [Input("joinUseNulls", required: true)]
        public Input<bool> JoinUseNulls { get; set; } = null!;

        [Input("joinedSubqueryRequiresAlias", required: true)]
        public Input<bool> JoinedSubqueryRequiresAlias { get; set; } = null!;

        [Input("loadBalancing", required: true)]
        public Input<string> LoadBalancing { get; set; } = null!;

        [Input("localFilesystemReadMethod", required: true)]
        public Input<string> LocalFilesystemReadMethod { get; set; } = null!;

        [Input("logQueryThreads", required: true)]
        public Input<bool> LogQueryThreads { get; set; } = null!;

        [Input("lowCardinalityAllowInNativeFormat", required: true)]
        public Input<bool> LowCardinalityAllowInNativeFormat { get; set; } = null!;

        [Input("maxAstDepth", required: true)]
        public Input<int> MaxAstDepth { get; set; } = null!;

        [Input("maxAstElements", required: true)]
        public Input<int> MaxAstElements { get; set; } = null!;

        [Input("maxBlockSize", required: true)]
        public Input<int> MaxBlockSize { get; set; } = null!;

        [Input("maxBytesBeforeExternalGroupBy", required: true)]
        public Input<int> MaxBytesBeforeExternalGroupBy { get; set; } = null!;

        [Input("maxBytesBeforeExternalSort", required: true)]
        public Input<int> MaxBytesBeforeExternalSort { get; set; } = null!;

        [Input("maxBytesInDistinct", required: true)]
        public Input<int> MaxBytesInDistinct { get; set; } = null!;

        [Input("maxBytesInJoin", required: true)]
        public Input<int> MaxBytesInJoin { get; set; } = null!;

        [Input("maxBytesInSet", required: true)]
        public Input<int> MaxBytesInSet { get; set; } = null!;

        [Input("maxBytesToRead", required: true)]
        public Input<int> MaxBytesToRead { get; set; } = null!;

        [Input("maxBytesToSort", required: true)]
        public Input<int> MaxBytesToSort { get; set; } = null!;

        [Input("maxBytesToTransfer", required: true)]
        public Input<int> MaxBytesToTransfer { get; set; } = null!;

        [Input("maxColumnsToRead", required: true)]
        public Input<int> MaxColumnsToRead { get; set; } = null!;

        [Input("maxConcurrentQueriesForUser", required: true)]
        public Input<int> MaxConcurrentQueriesForUser { get; set; } = null!;

        [Input("maxExecutionTime", required: true)]
        public Input<int> MaxExecutionTime { get; set; } = null!;

        [Input("maxExpandedAstElements", required: true)]
        public Input<int> MaxExpandedAstElements { get; set; } = null!;

        [Input("maxFinalThreads", required: true)]
        public Input<int> MaxFinalThreads { get; set; } = null!;

        [Input("maxHttpGetRedirects", required: true)]
        public Input<int> MaxHttpGetRedirects { get; set; } = null!;

        [Input("maxInsertBlockSize", required: true)]
        public Input<int> MaxInsertBlockSize { get; set; } = null!;

        [Input("maxInsertThreads", required: true)]
        public Input<int> MaxInsertThreads { get; set; } = null!;

        [Input("maxMemoryUsage", required: true)]
        public Input<int> MaxMemoryUsage { get; set; } = null!;

        [Input("maxMemoryUsageForUser", required: true)]
        public Input<int> MaxMemoryUsageForUser { get; set; } = null!;

        [Input("maxNetworkBandwidth", required: true)]
        public Input<int> MaxNetworkBandwidth { get; set; } = null!;

        [Input("maxNetworkBandwidthForUser", required: true)]
        public Input<int> MaxNetworkBandwidthForUser { get; set; } = null!;

        [Input("maxParserDepth", required: true)]
        public Input<int> MaxParserDepth { get; set; } = null!;

        [Input("maxQuerySize", required: true)]
        public Input<int> MaxQuerySize { get; set; } = null!;

        [Input("maxReadBufferSize", required: true)]
        public Input<int> MaxReadBufferSize { get; set; } = null!;

        [Input("maxReplicaDelayForDistributedQueries", required: true)]
        public Input<int> MaxReplicaDelayForDistributedQueries { get; set; } = null!;

        [Input("maxResultBytes", required: true)]
        public Input<int> MaxResultBytes { get; set; } = null!;

        [Input("maxResultRows", required: true)]
        public Input<int> MaxResultRows { get; set; } = null!;

        [Input("maxRowsInDistinct", required: true)]
        public Input<int> MaxRowsInDistinct { get; set; } = null!;

        [Input("maxRowsInJoin", required: true)]
        public Input<int> MaxRowsInJoin { get; set; } = null!;

        [Input("maxRowsInSet", required: true)]
        public Input<int> MaxRowsInSet { get; set; } = null!;

        [Input("maxRowsToGroupBy", required: true)]
        public Input<int> MaxRowsToGroupBy { get; set; } = null!;

        [Input("maxRowsToRead", required: true)]
        public Input<int> MaxRowsToRead { get; set; } = null!;

        [Input("maxRowsToSort", required: true)]
        public Input<int> MaxRowsToSort { get; set; } = null!;

        [Input("maxRowsToTransfer", required: true)]
        public Input<int> MaxRowsToTransfer { get; set; } = null!;

        [Input("maxTemporaryColumns", required: true)]
        public Input<int> MaxTemporaryColumns { get; set; } = null!;

        [Input("maxTemporaryDataOnDiskSizeForQuery", required: true)]
        public Input<int> MaxTemporaryDataOnDiskSizeForQuery { get; set; } = null!;

        [Input("maxTemporaryDataOnDiskSizeForUser", required: true)]
        public Input<int> MaxTemporaryDataOnDiskSizeForUser { get; set; } = null!;

        [Input("maxTemporaryNonConstColumns", required: true)]
        public Input<int> MaxTemporaryNonConstColumns { get; set; } = null!;

        [Input("maxThreads", required: true)]
        public Input<int> MaxThreads { get; set; } = null!;

        [Input("memoryOvercommitRatioDenominator", required: true)]
        public Input<int> MemoryOvercommitRatioDenominator { get; set; } = null!;

        [Input("memoryOvercommitRatioDenominatorForUser", required: true)]
        public Input<int> MemoryOvercommitRatioDenominatorForUser { get; set; } = null!;

        [Input("memoryProfilerSampleProbability", required: true)]
        public Input<double> MemoryProfilerSampleProbability { get; set; } = null!;

        [Input("memoryProfilerStep", required: true)]
        public Input<int> MemoryProfilerStep { get; set; } = null!;

        [Input("memoryUsageOvercommitMaxWaitMicroseconds", required: true)]
        public Input<int> MemoryUsageOvercommitMaxWaitMicroseconds { get; set; } = null!;

        [Input("mergeTreeMaxBytesToUseCache", required: true)]
        public Input<int> MergeTreeMaxBytesToUseCache { get; set; } = null!;

        [Input("mergeTreeMaxRowsToUseCache", required: true)]
        public Input<int> MergeTreeMaxRowsToUseCache { get; set; } = null!;

        [Input("mergeTreeMinBytesForConcurrentRead", required: true)]
        public Input<int> MergeTreeMinBytesForConcurrentRead { get; set; } = null!;

        [Input("mergeTreeMinRowsForConcurrentRead", required: true)]
        public Input<int> MergeTreeMinRowsForConcurrentRead { get; set; } = null!;

        [Input("minBytesToUseDirectIo", required: true)]
        public Input<int> MinBytesToUseDirectIo { get; set; } = null!;

        [Input("minCountToCompile", required: true)]
        public Input<int> MinCountToCompile { get; set; } = null!;

        [Input("minCountToCompileExpression", required: true)]
        public Input<int> MinCountToCompileExpression { get; set; } = null!;

        [Input("minExecutionSpeed", required: true)]
        public Input<int> MinExecutionSpeed { get; set; } = null!;

        [Input("minExecutionSpeedBytes", required: true)]
        public Input<int> MinExecutionSpeedBytes { get; set; } = null!;

        [Input("minInsertBlockSizeBytes", required: true)]
        public Input<int> MinInsertBlockSizeBytes { get; set; } = null!;

        [Input("minInsertBlockSizeRows", required: true)]
        public Input<int> MinInsertBlockSizeRows { get; set; } = null!;

        [Input("outputFormatJsonQuote64bitIntegers", required: true)]
        public Input<bool> OutputFormatJsonQuote64bitIntegers { get; set; } = null!;

        [Input("outputFormatJsonQuoteDenormals", required: true)]
        public Input<bool> OutputFormatJsonQuoteDenormals { get; set; } = null!;

        [Input("preferLocalhostReplica", required: true)]
        public Input<bool> PreferLocalhostReplica { get; set; } = null!;

        [Input("priority", required: true)]
        public Input<int> Priority { get; set; } = null!;

        [Input("quotaMode", required: true)]
        public Input<string> QuotaMode { get; set; } = null!;

        [Input("readOverflowMode", required: true)]
        public Input<string> ReadOverflowMode { get; set; } = null!;

        [Input("readonly", required: true)]
        public Input<int> Readonly { get; set; } = null!;

        [Input("receiveTimeout", required: true)]
        public Input<int> ReceiveTimeout { get; set; } = null!;

        [Input("remoteFilesystemReadMethod", required: true)]
        public Input<string> RemoteFilesystemReadMethod { get; set; } = null!;

        [Input("replicationAlterPartitionsSync", required: true)]
        public Input<int> ReplicationAlterPartitionsSync { get; set; } = null!;

        [Input("resultOverflowMode", required: true)]
        public Input<string> ResultOverflowMode { get; set; } = null!;

        [Input("selectSequentialConsistency", required: true)]
        public Input<bool> SelectSequentialConsistency { get; set; } = null!;

        [Input("sendProgressInHttpHeaders", required: true)]
        public Input<bool> SendProgressInHttpHeaders { get; set; } = null!;

        [Input("sendTimeout", required: true)]
        public Input<int> SendTimeout { get; set; } = null!;

        [Input("setOverflowMode", required: true)]
        public Input<string> SetOverflowMode { get; set; } = null!;

        [Input("skipUnavailableShards", required: true)]
        public Input<bool> SkipUnavailableShards { get; set; } = null!;

        [Input("sortOverflowMode", required: true)]
        public Input<string> SortOverflowMode { get; set; } = null!;

        [Input("timeoutBeforeCheckingExecutionSpeed", required: true)]
        public Input<int> TimeoutBeforeCheckingExecutionSpeed { get; set; } = null!;

        [Input("timeoutOverflowMode", required: true)]
        public Input<string> TimeoutOverflowMode { get; set; } = null!;

        [Input("transferOverflowMode", required: true)]
        public Input<string> TransferOverflowMode { get; set; } = null!;

        [Input("transformNullIn", required: true)]
        public Input<bool> TransformNullIn { get; set; } = null!;

        [Input("useHedgedRequests", required: true)]
        public Input<bool> UseHedgedRequests { get; set; } = null!;

        [Input("useUncompressedCache", required: true)]
        public Input<bool> UseUncompressedCache { get; set; } = null!;

        [Input("waitForAsyncInsert", required: true)]
        public Input<bool> WaitForAsyncInsert { get; set; } = null!;

        [Input("waitForAsyncInsertTimeout", required: true)]
        public Input<int> WaitForAsyncInsertTimeout { get; set; } = null!;

        public GetMdbClickhouseClusterUserSettingsInputArgs()
        {
        }
        public static new GetMdbClickhouseClusterUserSettingsInputArgs Empty => new GetMdbClickhouseClusterUserSettingsInputArgs();
    }
}