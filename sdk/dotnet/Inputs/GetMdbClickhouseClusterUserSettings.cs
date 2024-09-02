// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterUserSettingsArgs : global::Pulumi.InvokeArgs
    {
        [Input("addHttpCorsHeader", required: true)]
        public bool AddHttpCorsHeader { get; set; }

        [Input("allowDdl", required: true)]
        public bool AllowDdl { get; set; }

        [Input("allowIntrospectionFunctions", required: true)]
        public bool AllowIntrospectionFunctions { get; set; }

        [Input("allowSuspiciousLowCardinalityTypes", required: true)]
        public bool AllowSuspiciousLowCardinalityTypes { get; set; }

        [Input("asyncInsert", required: true)]
        public bool AsyncInsert { get; set; }

        [Input("asyncInsertBusyTimeout", required: true)]
        public int AsyncInsertBusyTimeout { get; set; }

        [Input("asyncInsertMaxDataSize", required: true)]
        public int AsyncInsertMaxDataSize { get; set; }

        [Input("asyncInsertStaleTimeout", required: true)]
        public int AsyncInsertStaleTimeout { get; set; }

        [Input("asyncInsertThreads", required: true)]
        public int AsyncInsertThreads { get; set; }

        [Input("cancelHttpReadonlyQueriesOnClientClose", required: true)]
        public bool CancelHttpReadonlyQueriesOnClientClose { get; set; }

        [Input("compile", required: true)]
        public bool Compile { get; set; }

        [Input("compileExpressions", required: true)]
        public bool CompileExpressions { get; set; }

        [Input("connectTimeout", required: true)]
        public int ConnectTimeout { get; set; }

        [Input("connectTimeoutWithFailover", required: true)]
        public int ConnectTimeoutWithFailover { get; set; }

        [Input("countDistinctImplementation", required: true)]
        public string CountDistinctImplementation { get; set; } = null!;

        [Input("distinctOverflowMode", required: true)]
        public string DistinctOverflowMode { get; set; } = null!;

        [Input("distributedAggregationMemoryEfficient", required: true)]
        public bool DistributedAggregationMemoryEfficient { get; set; }

        [Input("distributedDdlTaskTimeout", required: true)]
        public int DistributedDdlTaskTimeout { get; set; }

        [Input("distributedProductMode", required: true)]
        public string DistributedProductMode { get; set; } = null!;

        [Input("emptyResultForAggregationByEmptySet", required: true)]
        public bool EmptyResultForAggregationByEmptySet { get; set; }

        [Input("enableHttpCompression", required: true)]
        public bool EnableHttpCompression { get; set; }

        [Input("fallbackToStaleReplicasForDistributedQueries", required: true)]
        public bool FallbackToStaleReplicasForDistributedQueries { get; set; }

        [Input("flattenNested", required: true)]
        public bool FlattenNested { get; set; }

        [Input("forceIndexByDate", required: true)]
        public bool ForceIndexByDate { get; set; }

        [Input("forcePrimaryKey", required: true)]
        public bool ForcePrimaryKey { get; set; }

        [Input("groupByOverflowMode", required: true)]
        public string GroupByOverflowMode { get; set; } = null!;

        [Input("groupByTwoLevelThreshold", required: true)]
        public int GroupByTwoLevelThreshold { get; set; }

        [Input("groupByTwoLevelThresholdBytes", required: true)]
        public int GroupByTwoLevelThresholdBytes { get; set; }

        [Input("hedgedConnectionTimeoutMs", required: true)]
        public int HedgedConnectionTimeoutMs { get; set; }

        [Input("httpConnectionTimeout", required: true)]
        public int HttpConnectionTimeout { get; set; }

        [Input("httpHeadersProgressInterval", required: true)]
        public int HttpHeadersProgressInterval { get; set; }

        [Input("httpReceiveTimeout", required: true)]
        public int HttpReceiveTimeout { get; set; }

        [Input("httpSendTimeout", required: true)]
        public int HttpSendTimeout { get; set; }

        [Input("idleConnectionTimeout", required: true)]
        public int IdleConnectionTimeout { get; set; }

        [Input("inputFormatDefaultsForOmittedFields", required: true)]
        public bool InputFormatDefaultsForOmittedFields { get; set; }

        [Input("inputFormatImportNestedJson", required: true)]
        public bool InputFormatImportNestedJson { get; set; }

        [Input("inputFormatParallelParsing", required: true)]
        public bool InputFormatParallelParsing { get; set; }

        [Input("inputFormatValuesInterpretExpressions", required: true)]
        public bool InputFormatValuesInterpretExpressions { get; set; }

        [Input("insertKeeperMaxRetries", required: true)]
        public int InsertKeeperMaxRetries { get; set; }

        [Input("insertNullAsDefault", required: true)]
        public bool InsertNullAsDefault { get; set; }

        [Input("insertQuorum", required: true)]
        public int InsertQuorum { get; set; }

        [Input("insertQuorumTimeout", required: true)]
        public int InsertQuorumTimeout { get; set; }

        [Input("joinOverflowMode", required: true)]
        public string JoinOverflowMode { get; set; } = null!;

        [Input("joinUseNulls", required: true)]
        public bool JoinUseNulls { get; set; }

        [Input("joinedSubqueryRequiresAlias", required: true)]
        public bool JoinedSubqueryRequiresAlias { get; set; }

        [Input("loadBalancing", required: true)]
        public string LoadBalancing { get; set; } = null!;

        [Input("localFilesystemReadMethod", required: true)]
        public string LocalFilesystemReadMethod { get; set; } = null!;

        [Input("logQueryThreads", required: true)]
        public bool LogQueryThreads { get; set; }

        [Input("lowCardinalityAllowInNativeFormat", required: true)]
        public bool LowCardinalityAllowInNativeFormat { get; set; }

        [Input("maxAstDepth", required: true)]
        public int MaxAstDepth { get; set; }

        [Input("maxAstElements", required: true)]
        public int MaxAstElements { get; set; }

        [Input("maxBlockSize", required: true)]
        public int MaxBlockSize { get; set; }

        [Input("maxBytesBeforeExternalGroupBy", required: true)]
        public int MaxBytesBeforeExternalGroupBy { get; set; }

        [Input("maxBytesBeforeExternalSort", required: true)]
        public int MaxBytesBeforeExternalSort { get; set; }

        [Input("maxBytesInDistinct", required: true)]
        public int MaxBytesInDistinct { get; set; }

        [Input("maxBytesInJoin", required: true)]
        public int MaxBytesInJoin { get; set; }

        [Input("maxBytesInSet", required: true)]
        public int MaxBytesInSet { get; set; }

        [Input("maxBytesToRead", required: true)]
        public int MaxBytesToRead { get; set; }

        [Input("maxBytesToSort", required: true)]
        public int MaxBytesToSort { get; set; }

        [Input("maxBytesToTransfer", required: true)]
        public int MaxBytesToTransfer { get; set; }

        [Input("maxColumnsToRead", required: true)]
        public int MaxColumnsToRead { get; set; }

        [Input("maxConcurrentQueriesForUser", required: true)]
        public int MaxConcurrentQueriesForUser { get; set; }

        [Input("maxExecutionTime", required: true)]
        public int MaxExecutionTime { get; set; }

        [Input("maxExpandedAstElements", required: true)]
        public int MaxExpandedAstElements { get; set; }

        [Input("maxFinalThreads", required: true)]
        public int MaxFinalThreads { get; set; }

        [Input("maxHttpGetRedirects", required: true)]
        public int MaxHttpGetRedirects { get; set; }

        [Input("maxInsertBlockSize", required: true)]
        public int MaxInsertBlockSize { get; set; }

        [Input("maxInsertThreads", required: true)]
        public int MaxInsertThreads { get; set; }

        [Input("maxMemoryUsage", required: true)]
        public int MaxMemoryUsage { get; set; }

        [Input("maxMemoryUsageForUser", required: true)]
        public int MaxMemoryUsageForUser { get; set; }

        [Input("maxNetworkBandwidth", required: true)]
        public int MaxNetworkBandwidth { get; set; }

        [Input("maxNetworkBandwidthForUser", required: true)]
        public int MaxNetworkBandwidthForUser { get; set; }

        [Input("maxParserDepth", required: true)]
        public int MaxParserDepth { get; set; }

        [Input("maxQuerySize", required: true)]
        public int MaxQuerySize { get; set; }

        [Input("maxReadBufferSize", required: true)]
        public int MaxReadBufferSize { get; set; }

        [Input("maxReplicaDelayForDistributedQueries", required: true)]
        public int MaxReplicaDelayForDistributedQueries { get; set; }

        [Input("maxResultBytes", required: true)]
        public int MaxResultBytes { get; set; }

        [Input("maxResultRows", required: true)]
        public int MaxResultRows { get; set; }

        [Input("maxRowsInDistinct", required: true)]
        public int MaxRowsInDistinct { get; set; }

        [Input("maxRowsInJoin", required: true)]
        public int MaxRowsInJoin { get; set; }

        [Input("maxRowsInSet", required: true)]
        public int MaxRowsInSet { get; set; }

        [Input("maxRowsToGroupBy", required: true)]
        public int MaxRowsToGroupBy { get; set; }

        [Input("maxRowsToRead", required: true)]
        public int MaxRowsToRead { get; set; }

        [Input("maxRowsToSort", required: true)]
        public int MaxRowsToSort { get; set; }

        [Input("maxRowsToTransfer", required: true)]
        public int MaxRowsToTransfer { get; set; }

        [Input("maxTemporaryColumns", required: true)]
        public int MaxTemporaryColumns { get; set; }

        [Input("maxTemporaryDataOnDiskSizeForQuery", required: true)]
        public int MaxTemporaryDataOnDiskSizeForQuery { get; set; }

        [Input("maxTemporaryDataOnDiskSizeForUser", required: true)]
        public int MaxTemporaryDataOnDiskSizeForUser { get; set; }

        [Input("maxTemporaryNonConstColumns", required: true)]
        public int MaxTemporaryNonConstColumns { get; set; }

        [Input("maxThreads", required: true)]
        public int MaxThreads { get; set; }

        [Input("memoryOvercommitRatioDenominator", required: true)]
        public int MemoryOvercommitRatioDenominator { get; set; }

        [Input("memoryOvercommitRatioDenominatorForUser", required: true)]
        public int MemoryOvercommitRatioDenominatorForUser { get; set; }

        [Input("memoryProfilerSampleProbability", required: true)]
        public double MemoryProfilerSampleProbability { get; set; }

        [Input("memoryProfilerStep", required: true)]
        public int MemoryProfilerStep { get; set; }

        [Input("memoryUsageOvercommitMaxWaitMicroseconds", required: true)]
        public int MemoryUsageOvercommitMaxWaitMicroseconds { get; set; }

        [Input("mergeTreeMaxBytesToUseCache", required: true)]
        public int MergeTreeMaxBytesToUseCache { get; set; }

        [Input("mergeTreeMaxRowsToUseCache", required: true)]
        public int MergeTreeMaxRowsToUseCache { get; set; }

        [Input("mergeTreeMinBytesForConcurrentRead", required: true)]
        public int MergeTreeMinBytesForConcurrentRead { get; set; }

        [Input("mergeTreeMinRowsForConcurrentRead", required: true)]
        public int MergeTreeMinRowsForConcurrentRead { get; set; }

        [Input("minBytesToUseDirectIo", required: true)]
        public int MinBytesToUseDirectIo { get; set; }

        [Input("minCountToCompile", required: true)]
        public int MinCountToCompile { get; set; }

        [Input("minCountToCompileExpression", required: true)]
        public int MinCountToCompileExpression { get; set; }

        [Input("minExecutionSpeed", required: true)]
        public int MinExecutionSpeed { get; set; }

        [Input("minExecutionSpeedBytes", required: true)]
        public int MinExecutionSpeedBytes { get; set; }

        [Input("minInsertBlockSizeBytes", required: true)]
        public int MinInsertBlockSizeBytes { get; set; }

        [Input("minInsertBlockSizeRows", required: true)]
        public int MinInsertBlockSizeRows { get; set; }

        [Input("outputFormatJsonQuote64bitIntegers", required: true)]
        public bool OutputFormatJsonQuote64bitIntegers { get; set; }

        [Input("outputFormatJsonQuoteDenormals", required: true)]
        public bool OutputFormatJsonQuoteDenormals { get; set; }

        [Input("preferLocalhostReplica", required: true)]
        public bool PreferLocalhostReplica { get; set; }

        [Input("priority", required: true)]
        public int Priority { get; set; }

        [Input("quotaMode", required: true)]
        public string QuotaMode { get; set; } = null!;

        [Input("readOverflowMode", required: true)]
        public string ReadOverflowMode { get; set; } = null!;

        [Input("readonly", required: true)]
        public int Readonly { get; set; }

        [Input("receiveTimeout", required: true)]
        public int ReceiveTimeout { get; set; }

        [Input("remoteFilesystemReadMethod", required: true)]
        public string RemoteFilesystemReadMethod { get; set; } = null!;

        [Input("replicationAlterPartitionsSync", required: true)]
        public int ReplicationAlterPartitionsSync { get; set; }

        [Input("resultOverflowMode", required: true)]
        public string ResultOverflowMode { get; set; } = null!;

        [Input("selectSequentialConsistency", required: true)]
        public bool SelectSequentialConsistency { get; set; }

        [Input("sendProgressInHttpHeaders", required: true)]
        public bool SendProgressInHttpHeaders { get; set; }

        [Input("sendTimeout", required: true)]
        public int SendTimeout { get; set; }

        [Input("setOverflowMode", required: true)]
        public string SetOverflowMode { get; set; } = null!;

        [Input("skipUnavailableShards", required: true)]
        public bool SkipUnavailableShards { get; set; }

        [Input("sortOverflowMode", required: true)]
        public string SortOverflowMode { get; set; } = null!;

        [Input("timeoutBeforeCheckingExecutionSpeed", required: true)]
        public int TimeoutBeforeCheckingExecutionSpeed { get; set; }

        [Input("timeoutOverflowMode", required: true)]
        public string TimeoutOverflowMode { get; set; } = null!;

        [Input("transferOverflowMode", required: true)]
        public string TransferOverflowMode { get; set; } = null!;

        [Input("transformNullIn", required: true)]
        public bool TransformNullIn { get; set; }

        [Input("useHedgedRequests", required: true)]
        public bool UseHedgedRequests { get; set; }

        [Input("useUncompressedCache", required: true)]
        public bool UseUncompressedCache { get; set; }

        [Input("waitForAsyncInsert", required: true)]
        public bool WaitForAsyncInsert { get; set; }

        [Input("waitForAsyncInsertTimeout", required: true)]
        public int WaitForAsyncInsertTimeout { get; set; }

        public GetMdbClickhouseClusterUserSettingsArgs()
        {
        }
        public static new GetMdbClickhouseClusterUserSettingsArgs Empty => new GetMdbClickhouseClusterUserSettingsArgs();
    }
}
