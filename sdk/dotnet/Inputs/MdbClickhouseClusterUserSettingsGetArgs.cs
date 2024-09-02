// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterUserSettingsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Include CORS headers in HTTP responces.
        /// </summary>
        [Input("addHttpCorsHeader")]
        public Input<bool>? AddHttpCorsHeader { get; set; }

        /// <summary>
        /// Allows or denies DDL queries.
        /// </summary>
        [Input("allowDdl")]
        public Input<bool>? AllowDdl { get; set; }

        /// <summary>
        /// Enables introspections functions for query profiling.
        /// </summary>
        [Input("allowIntrospectionFunctions")]
        public Input<bool>? AllowIntrospectionFunctions { get; set; }

        /// <summary>
        /// Allows specifying LowCardinality modifier for types of small fixed size (8 or less) in CREATE TABLE statements. Enabling this may increase merge times and memory consumption.
        /// </summary>
        [Input("allowSuspiciousLowCardinalityTypes")]
        public Input<bool>? AllowSuspiciousLowCardinalityTypes { get; set; }

        /// <summary>
        /// Enables asynchronous inserts. Disabled by default.
        /// </summary>
        [Input("asyncInsert")]
        public Input<bool>? AsyncInsert { get; set; }

        /// <summary>
        /// The maximum timeout in milliseconds since the first INSERT query before inserting collected data. If the parameter is set to 0, the timeout is disabled. Default value: 200.
        /// </summary>
        [Input("asyncInsertBusyTimeout")]
        public Input<int>? AsyncInsertBusyTimeout { get; set; }

        /// <summary>
        /// The maximum size of the unparsed data in bytes collected per query before being inserted. If the parameter is set to 0, asynchronous insertions are disabled. Default value: 100000.
        /// </summary>
        [Input("asyncInsertMaxDataSize")]
        public Input<int>? AsyncInsertMaxDataSize { get; set; }

        /// <summary>
        /// The maximum timeout in milliseconds since the last INSERT query before dumping collected data. If enabled, the settings prolongs the async_insert_busy_timeout with every INSERT query as long as async_insert_max_data_size is not exceeded.
        /// </summary>
        [Input("asyncInsertStaleTimeout")]
        public Input<int>? AsyncInsertStaleTimeout { get; set; }

        /// <summary>
        /// The maximum number of threads for background data parsing and insertion. If the parameter is set to 0, asynchronous insertions are disabled. Default value: 16.
        /// </summary>
        [Input("asyncInsertThreads")]
        public Input<int>? AsyncInsertThreads { get; set; }

        /// <summary>
        /// Cancels HTTP read-only queries (e.g. SELECT) when a client closes the connection without waiting for the response.
        /// Default value: false.
        /// </summary>
        [Input("cancelHttpReadonlyQueriesOnClientClose")]
        public Input<bool>? CancelHttpReadonlyQueriesOnClientClose { get; set; }

        /// <summary>
        /// Enable compilation of queries.
        /// </summary>
        [Input("compile")]
        public Input<bool>? Compile { get; set; }

        /// <summary>
        /// Turn on expression compilation.
        /// </summary>
        [Input("compileExpressions")]
        public Input<bool>? CompileExpressions { get; set; }

        /// <summary>
        /// Connect timeout in milliseconds on the socket used for communicating with the client.
        /// </summary>
        [Input("connectTimeout")]
        public Input<int>? ConnectTimeout { get; set; }

        /// <summary>
        /// The timeout in milliseconds for connecting to a remote server for a Distributed table engine, if the ‘shard’ and ‘replica’ sections are used in the cluster definition. If unsuccessful, several attempts are made to connect to various replicas. Default value: 50.
        /// </summary>
        [Input("connectTimeoutWithFailover")]
        public Input<int>? ConnectTimeoutWithFailover { get; set; }

        /// <summary>
        /// Specifies which of the uniq* functions should be used to perform the COUNT(DISTINCT …) construction.
        /// </summary>
        [Input("countDistinctImplementation")]
        public Input<string>? CountDistinctImplementation { get; set; }

        /// <summary>
        /// Sets behaviour on overflow when using DISTINCT. Possible values:
        /// </summary>
        [Input("distinctOverflowMode")]
        public Input<string>? DistinctOverflowMode { get; set; }

        /// <summary>
        /// Determine the behavior of distributed subqueries.
        /// </summary>
        [Input("distributedAggregationMemoryEfficient")]
        public Input<bool>? DistributedAggregationMemoryEfficient { get; set; }

        /// <summary>
        /// Timeout for DDL queries, in milliseconds.
        /// </summary>
        [Input("distributedDdlTaskTimeout")]
        public Input<int>? DistributedDdlTaskTimeout { get; set; }

        /// <summary>
        /// Changes the behaviour of distributed subqueries.
        /// </summary>
        [Input("distributedProductMode")]
        public Input<string>? DistributedProductMode { get; set; }

        /// <summary>
        /// Allows to retunr empty result.
        /// </summary>
        [Input("emptyResultForAggregationByEmptySet")]
        public Input<bool>? EmptyResultForAggregationByEmptySet { get; set; }

        /// <summary>
        /// Enables or disables data compression in the response to an HTTP request.
        /// </summary>
        [Input("enableHttpCompression")]
        public Input<bool>? EnableHttpCompression { get; set; }

        /// <summary>
        /// Forces a query to an out-of-date replica if updated data is not available.
        /// </summary>
        [Input("fallbackToStaleReplicasForDistributedQueries")]
        public Input<bool>? FallbackToStaleReplicasForDistributedQueries { get; set; }

        /// <summary>
        /// Sets the data format of a nested columns.
        /// </summary>
        [Input("flattenNested")]
        public Input<bool>? FlattenNested { get; set; }

        /// <summary>
        /// Disables query execution if the index can’t be used by date.
        /// </summary>
        [Input("forceIndexByDate")]
        public Input<bool>? ForceIndexByDate { get; set; }

        /// <summary>
        /// Disables query execution if indexing by the primary key is not possible.
        /// </summary>
        [Input("forcePrimaryKey")]
        public Input<bool>? ForcePrimaryKey { get; set; }

        /// <summary>
        /// Sets behaviour on overflow while GROUP BY operation. Possible values:
        /// </summary>
        [Input("groupByOverflowMode")]
        public Input<string>? GroupByOverflowMode { get; set; }

        /// <summary>
        /// Sets the threshold of the number of keys, after that the two-level aggregation should be used.
        /// </summary>
        [Input("groupByTwoLevelThreshold")]
        public Input<int>? GroupByTwoLevelThreshold { get; set; }

        /// <summary>
        /// Sets the threshold of the number of bytes, after that the two-level aggregation should be used.
        /// </summary>
        [Input("groupByTwoLevelThresholdBytes")]
        public Input<int>? GroupByTwoLevelThresholdBytes { get; set; }

        /// <summary>
        /// Connection timeout for establishing connection with replica for Hedged requests. Default value: 50 milliseconds.
        /// </summary>
        [Input("hedgedConnectionTimeoutMs")]
        public Input<int>? HedgedConnectionTimeoutMs { get; set; }

        /// <summary>
        /// Timeout for HTTP connection in milliseconds.
        /// </summary>
        [Input("httpConnectionTimeout")]
        public Input<int>? HttpConnectionTimeout { get; set; }

        /// <summary>
        /// Sets minimal interval between notifications about request process in HTTP header X-ClickHouse-Progress.
        /// </summary>
        [Input("httpHeadersProgressInterval")]
        public Input<int>? HttpHeadersProgressInterval { get; set; }

        /// <summary>
        /// Timeout for HTTP connection in milliseconds.
        /// </summary>
        [Input("httpReceiveTimeout")]
        public Input<int>? HttpReceiveTimeout { get; set; }

        /// <summary>
        /// Timeout for HTTP connection in milliseconds.
        /// </summary>
        [Input("httpSendTimeout")]
        public Input<int>? HttpSendTimeout { get; set; }

        /// <summary>
        /// Timeout to close idle TCP connections after specified number of seconds. Default value: 3600 seconds.
        /// </summary>
        [Input("idleConnectionTimeout")]
        public Input<int>? IdleConnectionTimeout { get; set; }

        /// <summary>
        /// When performing INSERT queries, replace omitted input column values with default values of the respective columns.
        /// </summary>
        [Input("inputFormatDefaultsForOmittedFields")]
        public Input<bool>? InputFormatDefaultsForOmittedFields { get; set; }

        /// <summary>
        /// Enables or disables the insertion of JSON data with nested objects.
        /// </summary>
        [Input("inputFormatImportNestedJson")]
        public Input<bool>? InputFormatImportNestedJson { get; set; }

        /// <summary>
        /// Enables or disables order-preserving parallel parsing of data formats. Supported only for TSV, TKSV, CSV and JSONEachRow formats.
        /// </summary>
        [Input("inputFormatParallelParsing")]
        public Input<bool>? InputFormatParallelParsing { get; set; }

        /// <summary>
        /// Enables or disables the full SQL parser if the fast stream parser can’t parse the data.
        /// </summary>
        [Input("inputFormatValuesInterpretExpressions")]
        public Input<bool>? InputFormatValuesInterpretExpressions { get; set; }

        /// <summary>
        /// The setting sets the maximum number of retries for ClickHouse Keeper (or ZooKeeper) requests during insert into replicated MergeTree. Only Keeper requests which failed due to network error, Keeper session timeout, or request timeout are considered for retries.
        /// </summary>
        [Input("insertKeeperMaxRetries")]
        public Input<int>? InsertKeeperMaxRetries { get; set; }

        /// <summary>
        /// Enables the insertion of default values instead of NULL into columns with not nullable data type. Default value: true.
        /// </summary>
        [Input("insertNullAsDefault")]
        public Input<bool>? InsertNullAsDefault { get; set; }

        /// <summary>
        /// Enables the quorum writes.
        /// </summary>
        [Input("insertQuorum")]
        public Input<int>? InsertQuorum { get; set; }

        /// <summary>
        /// Write to a quorum timeout in milliseconds.
        /// </summary>
        [Input("insertQuorumTimeout")]
        public Input<int>? InsertQuorumTimeout { get; set; }

        /// <summary>
        /// Sets behaviour on overflow in JOIN. Possible values:
        /// </summary>
        [Input("joinOverflowMode")]
        public Input<string>? JoinOverflowMode { get; set; }

        /// <summary>
        /// Sets the type of JOIN behaviour. When merging tables, empty cells may appear. ClickHouse fills them differently based on this setting.
        /// </summary>
        [Input("joinUseNulls")]
        public Input<bool>? JoinUseNulls { get; set; }

        /// <summary>
        /// Require aliases for subselects and table functions in FROM that more than one table is present.
        /// </summary>
        [Input("joinedSubqueryRequiresAlias")]
        public Input<bool>? JoinedSubqueryRequiresAlias { get; set; }

        /// <summary>
        /// Specifies the algorithm of replicas selection that is used for distributed query processing, one of: random, nearest_hostname, in_order, first_or_random, round_robin. Default value: random.
        /// </summary>
        [Input("loadBalancing")]
        public Input<string>? LoadBalancing { get; set; }

        /// <summary>
        /// Method of reading data from local filesystem. Possible values:
        /// </summary>
        [Input("localFilesystemReadMethod")]
        public Input<string>? LocalFilesystemReadMethod { get; set; }

        /// <summary>
        /// Setting up query threads logging. Query threads log into the system.query_thread_log table. This setting has effect only when log_queries is true. Queries’ threads run by ClickHouse with this setup are logged according to the rules in the query_thread_log server configuration parameter. Default value: true.
        /// </summary>
        [Input("logQueryThreads")]
        public Input<bool>? LogQueryThreads { get; set; }

        /// <summary>
        /// Allows or restricts using the LowCardinality data type with the Native format.
        /// </summary>
        [Input("lowCardinalityAllowInNativeFormat")]
        public Input<bool>? LowCardinalityAllowInNativeFormat { get; set; }

        /// <summary>
        /// Maximum abstract syntax tree depth.
        /// </summary>
        [Input("maxAstDepth")]
        public Input<int>? MaxAstDepth { get; set; }

        /// <summary>
        /// Maximum abstract syntax tree elements.
        /// </summary>
        [Input("maxAstElements")]
        public Input<int>? MaxAstElements { get; set; }

        /// <summary>
        /// A recommendation for what size of the block (in a count of rows) to load from tables.
        /// </summary>
        [Input("maxBlockSize")]
        public Input<int>? MaxBlockSize { get; set; }

        /// <summary>
        /// Limit in bytes for using memoru for GROUP BY before using swap on disk.
        /// </summary>
        [Input("maxBytesBeforeExternalGroupBy")]
        public Input<int>? MaxBytesBeforeExternalGroupBy { get; set; }

        /// <summary>
        /// This setting is equivalent of the max_bytes_before_external_group_by setting, except for it is for sort operation (ORDER BY), not aggregation.
        /// </summary>
        [Input("maxBytesBeforeExternalSort")]
        public Input<int>? MaxBytesBeforeExternalSort { get; set; }

        /// <summary>
        /// Limits the maximum size of a hash table in bytes (uncompressed data) when using DISTINCT.
        /// </summary>
        [Input("maxBytesInDistinct")]
        public Input<int>? MaxBytesInDistinct { get; set; }

        /// <summary>
        /// Limit on maximum size of the hash table for JOIN, in bytes.
        /// </summary>
        [Input("maxBytesInJoin")]
        public Input<int>? MaxBytesInJoin { get; set; }

        /// <summary>
        /// Limit on the number of bytes in the set resulting from the execution of the IN section.
        /// </summary>
        [Input("maxBytesInSet")]
        public Input<int>? MaxBytesInSet { get; set; }

        /// <summary>
        /// Limits the maximum number of bytes (uncompressed data) that can be read from a table when running a query.
        /// </summary>
        [Input("maxBytesToRead")]
        public Input<int>? MaxBytesToRead { get; set; }

        /// <summary>
        /// Limits the maximum number of bytes (uncompressed data) that can be read from a table for sorting.
        /// </summary>
        [Input("maxBytesToSort")]
        public Input<int>? MaxBytesToSort { get; set; }

        /// <summary>
        /// Limits the maximum number of bytes (uncompressed data) that can be passed to a remote server or saved in a temporary table when using GLOBAL IN.
        /// </summary>
        [Input("maxBytesToTransfer")]
        public Input<int>? MaxBytesToTransfer { get; set; }

        /// <summary>
        /// Limits the maximum number of columns that can be read from a table in a single query.
        /// </summary>
        [Input("maxColumnsToRead")]
        public Input<int>? MaxColumnsToRead { get; set; }

        /// <summary>
        /// The maximum number of concurrent requests per user. Default value: 0 (no limit).
        /// </summary>
        [Input("maxConcurrentQueriesForUser")]
        public Input<int>? MaxConcurrentQueriesForUser { get; set; }

        /// <summary>
        /// Limits the maximum query execution time in milliseconds.
        /// </summary>
        [Input("maxExecutionTime")]
        public Input<int>? MaxExecutionTime { get; set; }

        /// <summary>
        /// Maximum abstract syntax tree depth after after expansion of aliases.
        /// </summary>
        [Input("maxExpandedAstElements")]
        public Input<int>? MaxExpandedAstElements { get; set; }

        /// <summary>
        /// Sets the maximum number of parallel threads for the SELECT query data read phase with the FINAL modifier.
        /// </summary>
        [Input("maxFinalThreads")]
        public Input<int>? MaxFinalThreads { get; set; }

        /// <summary>
        /// Limits the maximum number of HTTP GET redirect hops for URL-engine tables.
        /// </summary>
        [Input("maxHttpGetRedirects")]
        public Input<int>? MaxHttpGetRedirects { get; set; }

        /// <summary>
        /// The size of blocks (in a count of rows) to form for insertion into a table.
        /// </summary>
        [Input("maxInsertBlockSize")]
        public Input<int>? MaxInsertBlockSize { get; set; }

        /// <summary>
        /// The maximum number of threads to execute the INSERT SELECT query. Default value: 0.
        /// </summary>
        [Input("maxInsertThreads")]
        public Input<int>? MaxInsertThreads { get; set; }

        /// <summary>
        /// Limits the maximum memory usage (in bytes) for processing queries on a single server.
        /// </summary>
        [Input("maxMemoryUsage")]
        public Input<int>? MaxMemoryUsage { get; set; }

        /// <summary>
        /// Limits the maximum memory usage (in bytes) for processing of user's queries on a single server.
        /// </summary>
        [Input("maxMemoryUsageForUser")]
        public Input<int>? MaxMemoryUsageForUser { get; set; }

        /// <summary>
        /// Limits the speed of the data exchange over the network in bytes per second.
        /// </summary>
        [Input("maxNetworkBandwidth")]
        public Input<int>? MaxNetworkBandwidth { get; set; }

        /// <summary>
        /// Limits the speed of the data exchange over the network in bytes per second.
        /// </summary>
        [Input("maxNetworkBandwidthForUser")]
        public Input<int>? MaxNetworkBandwidthForUser { get; set; }

        /// <summary>
        /// Limits maximum recursion depth in the recursive descent parser. Allows controlling the stack size. Zero means unlimited.
        /// </summary>
        [Input("maxParserDepth")]
        public Input<int>? MaxParserDepth { get; set; }

        /// <summary>
        /// The maximum part of a query that can be taken to RAM for parsing with the SQL parser.
        /// </summary>
        [Input("maxQuerySize")]
        public Input<int>? MaxQuerySize { get; set; }

        /// <summary>
        /// The maximum size of the buffer to read from the filesystem.
        /// </summary>
        [Input("maxReadBufferSize")]
        public Input<int>? MaxReadBufferSize { get; set; }

        /// <summary>
        /// Disables lagging replicas for distributed queries.
        /// </summary>
        [Input("maxReplicaDelayForDistributedQueries")]
        public Input<int>? MaxReplicaDelayForDistributedQueries { get; set; }

        /// <summary>
        /// Limits the number of bytes in the result.
        /// </summary>
        [Input("maxResultBytes")]
        public Input<int>? MaxResultBytes { get; set; }

        /// <summary>
        /// Limits the number of rows in the result.
        /// </summary>
        [Input("maxResultRows")]
        public Input<int>? MaxResultRows { get; set; }

        /// <summary>
        /// Limits the maximum number of different rows when using DISTINCT.
        /// </summary>
        [Input("maxRowsInDistinct")]
        public Input<int>? MaxRowsInDistinct { get; set; }

        /// <summary>
        /// Limit on maximum size of the hash table for JOIN, in rows.
        /// </summary>
        [Input("maxRowsInJoin")]
        public Input<int>? MaxRowsInJoin { get; set; }

        /// <summary>
        /// Limit on the number of rows in the set resulting from the execution of the IN section.
        /// </summary>
        [Input("maxRowsInSet")]
        public Input<int>? MaxRowsInSet { get; set; }

        /// <summary>
        /// Limits the maximum number of unique keys received from aggregation function.
        /// </summary>
        [Input("maxRowsToGroupBy")]
        public Input<int>? MaxRowsToGroupBy { get; set; }

        /// <summary>
        /// Limits the maximum number of rows that can be read from a table when running a query.
        /// </summary>
        [Input("maxRowsToRead")]
        public Input<int>? MaxRowsToRead { get; set; }

        /// <summary>
        /// Limits the maximum number of rows that can be read from a table for sorting.
        /// </summary>
        [Input("maxRowsToSort")]
        public Input<int>? MaxRowsToSort { get; set; }

        /// <summary>
        /// Limits the maximum number of rows that can be passed to a remote server or saved in a temporary table when using GLOBAL IN.
        /// </summary>
        [Input("maxRowsToTransfer")]
        public Input<int>? MaxRowsToTransfer { get; set; }

        /// <summary>
        /// Limits the maximum number of temporary columns that must be kept in RAM at the same time when running a query, including constant columns.
        /// </summary>
        [Input("maxTemporaryColumns")]
        public Input<int>? MaxTemporaryColumns { get; set; }

        /// <summary>
        /// The maximum amount of data consumed by temporary files on disk in bytes for all concurrently running queries. Zero means unlimited.
        /// </summary>
        [Input("maxTemporaryDataOnDiskSizeForQuery")]
        public Input<int>? MaxTemporaryDataOnDiskSizeForQuery { get; set; }

        /// <summary>
        /// The maximum amount of data consumed by temporary files on disk in bytes for all concurrently running user queries. Zero means unlimited.
        /// </summary>
        [Input("maxTemporaryDataOnDiskSizeForUser")]
        public Input<int>? MaxTemporaryDataOnDiskSizeForUser { get; set; }

        /// <summary>
        /// Limits the maximum number of temporary columns that must be kept in RAM at the same time when running a query, excluding constant columns.
        /// </summary>
        [Input("maxTemporaryNonConstColumns")]
        public Input<int>? MaxTemporaryNonConstColumns { get; set; }

        /// <summary>
        /// The maximum number of query processing threads, excluding threads for retrieving data from remote servers.
        /// </summary>
        [Input("maxThreads")]
        public Input<int>? MaxThreads { get; set; }

        /// <summary>
        /// It represents soft memory limit in case when hard limit is reached on user level. This value is used to compute overcommit ratio for the query. Zero means skip the query.
        /// </summary>
        [Input("memoryOvercommitRatioDenominator")]
        public Input<int>? MemoryOvercommitRatioDenominator { get; set; }

        /// <summary>
        /// It represents soft memory limit in case when hard limit is reached on global level. This value is used to compute overcommit ratio for the query. Zero means skip the query.
        /// </summary>
        [Input("memoryOvercommitRatioDenominatorForUser")]
        public Input<int>? MemoryOvercommitRatioDenominatorForUser { get; set; }

        /// <summary>
        /// Collect random allocations and deallocations and write them into system.trace_log with 'MemorySample' trace_type. The probability is for every alloc/free regardless to the size of the allocation. Possible values: from 0 to 1. Default: 0.
        /// </summary>
        [Input("memoryProfilerSampleProbability")]
        public Input<double>? MemoryProfilerSampleProbability { get; set; }

        /// <summary>
        /// Memory profiler step (in bytes).  If the next query step requires more memory than this parameter specifies, the memory profiler collects the allocating stack trace. Values lower than a few megabytes slow down query processing. Default value: 4194304 (4 MB). Zero means disabled memory profiler.
        /// </summary>
        [Input("memoryProfilerStep")]
        public Input<int>? MemoryProfilerStep { get; set; }

        /// <summary>
        /// Maximum time thread will wait for memory to be freed in the case of memory overcommit on a user level. If the timeout is reached and memory is not freed, an exception is thrown.
        /// </summary>
        [Input("memoryUsageOvercommitMaxWaitMicroseconds")]
        public Input<int>? MemoryUsageOvercommitMaxWaitMicroseconds { get; set; }

        /// <summary>
        /// If ClickHouse should read more than merge_tree_max_bytes_to_use_cache bytes in one query, it doesn’t use the cache of uncompressed blocks.
        /// </summary>
        [Input("mergeTreeMaxBytesToUseCache")]
        public Input<int>? MergeTreeMaxBytesToUseCache { get; set; }

        /// <summary>
        /// If ClickHouse should read more than merge_tree_max_rows_to_use_cache rows in one query, it doesn’t use the cache of uncompressed blocks.
        /// </summary>
        [Input("mergeTreeMaxRowsToUseCache")]
        public Input<int>? MergeTreeMaxRowsToUseCache { get; set; }

        /// <summary>
        /// If the number of bytes to read from one file of a MergeTree-engine table exceeds merge_tree_min_bytes_for_concurrent_read, then ClickHouse tries to concurrently read from this file in several threads.
        /// </summary>
        [Input("mergeTreeMinBytesForConcurrentRead")]
        public Input<int>? MergeTreeMinBytesForConcurrentRead { get; set; }

        /// <summary>
        /// If the number of rows to be read from a file of a MergeTree table exceeds merge_tree_min_rows_for_concurrent_read then ClickHouse tries to perform a concurrent reading from this file on several threads.
        /// </summary>
        [Input("mergeTreeMinRowsForConcurrentRead")]
        public Input<int>? MergeTreeMinRowsForConcurrentRead { get; set; }

        /// <summary>
        /// The minimum data volume required for using direct I/O access to the storage disk.
        /// </summary>
        [Input("minBytesToUseDirectIo")]
        public Input<int>? MinBytesToUseDirectIo { get; set; }

        /// <summary>
        /// How many times to potentially use a compiled chunk of code before running compilation.
        /// </summary>
        [Input("minCountToCompile")]
        public Input<int>? MinCountToCompile { get; set; }

        /// <summary>
        /// A query waits for expression compilation process to complete prior to continuing execution.
        /// </summary>
        [Input("minCountToCompileExpression")]
        public Input<int>? MinCountToCompileExpression { get; set; }

        /// <summary>
        /// Minimal execution speed in rows per second.
        /// </summary>
        [Input("minExecutionSpeed")]
        public Input<int>? MinExecutionSpeed { get; set; }

        /// <summary>
        /// Minimal execution speed in bytes per second.
        /// </summary>
        [Input("minExecutionSpeedBytes")]
        public Input<int>? MinExecutionSpeedBytes { get; set; }

        /// <summary>
        /// Sets the minimum number of bytes in the block which can be inserted into a table by an INSERT query.
        /// </summary>
        [Input("minInsertBlockSizeBytes")]
        public Input<int>? MinInsertBlockSizeBytes { get; set; }

        /// <summary>
        /// Sets the minimum number of rows in the block which can be inserted into a table by an INSERT query.
        /// </summary>
        [Input("minInsertBlockSizeRows")]
        public Input<int>? MinInsertBlockSizeRows { get; set; }

        /// <summary>
        /// If the value is true, integers appear in quotes when using JSON* Int64 and UInt64 formats (for compatibility with most JavaScript implementations); otherwise, integers are output without the quotes.
        /// </summary>
        [Input("outputFormatJsonQuote64bitIntegers")]
        public Input<bool>? OutputFormatJsonQuote64bitIntegers { get; set; }

        /// <summary>
        /// Enables +nan, -nan, +inf, -inf outputs in JSON output format.
        /// </summary>
        [Input("outputFormatJsonQuoteDenormals")]
        public Input<bool>? OutputFormatJsonQuoteDenormals { get; set; }

        /// <summary>
        /// Enables/disables preferable using the localhost replica when processing distributed queries. Default value: true.
        /// </summary>
        [Input("preferLocalhostReplica")]
        public Input<bool>? PreferLocalhostReplica { get; set; }

        /// <summary>
        /// Query priority.
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        /// <summary>
        /// Quota accounting mode.
        /// </summary>
        [Input("quotaMode")]
        public Input<string>? QuotaMode { get; set; }

        /// <summary>
        /// Sets behaviour on overflow while read. Possible values:
        /// </summary>
        [Input("readOverflowMode")]
        public Input<string>? ReadOverflowMode { get; set; }

        /// <summary>
        /// Restricts permissions for reading data, write data and change settings queries.
        /// </summary>
        [Input("readonly")]
        public Input<int>? Readonly { get; set; }

        /// <summary>
        /// Receive timeout in milliseconds on the socket used for communicating with the client.
        /// </summary>
        [Input("receiveTimeout")]
        public Input<int>? ReceiveTimeout { get; set; }

        /// <summary>
        /// Method of reading data from remote filesystem, one of: `read`, `threadpool`.
        /// </summary>
        [Input("remoteFilesystemReadMethod")]
        public Input<string>? RemoteFilesystemReadMethod { get; set; }

        /// <summary>
        /// For ALTER ... ATTACH|DETACH|DROP queries, you can use the replication_alter_partitions_sync setting to set up waiting.
        /// </summary>
        [Input("replicationAlterPartitionsSync")]
        public Input<int>? ReplicationAlterPartitionsSync { get; set; }

        /// <summary>
        /// Sets behaviour on overflow in result. Possible values:
        /// </summary>
        [Input("resultOverflowMode")]
        public Input<string>? ResultOverflowMode { get; set; }

        /// <summary>
        /// Enables or disables sequential consistency for SELECT queries.
        /// </summary>
        [Input("selectSequentialConsistency")]
        public Input<bool>? SelectSequentialConsistency { get; set; }

        /// <summary>
        /// Enables or disables X-ClickHouse-Progress HTTP response headers in clickhouse-server responses.
        /// </summary>
        [Input("sendProgressInHttpHeaders")]
        public Input<bool>? SendProgressInHttpHeaders { get; set; }

        /// <summary>
        /// Send timeout in milliseconds on the socket used for communicating with the client.
        /// </summary>
        [Input("sendTimeout")]
        public Input<int>? SendTimeout { get; set; }

        /// <summary>
        /// Sets behaviour on overflow in the set resulting. Possible values:
        /// </summary>
        [Input("setOverflowMode")]
        public Input<string>? SetOverflowMode { get; set; }

        /// <summary>
        /// Enables or disables silently skipping of unavailable shards.
        /// </summary>
        [Input("skipUnavailableShards")]
        public Input<bool>? SkipUnavailableShards { get; set; }

        /// <summary>
        /// Sets behaviour on overflow while sort. Possible values:
        /// </summary>
        [Input("sortOverflowMode")]
        public Input<string>? SortOverflowMode { get; set; }

        /// <summary>
        /// Timeout (in seconds) between checks of execution speed. It is checked that execution speed is not less that specified in min_execution_speed parameter.
        /// Must be at least 1000.
        /// </summary>
        [Input("timeoutBeforeCheckingExecutionSpeed")]
        public Input<int>? TimeoutBeforeCheckingExecutionSpeed { get; set; }

        /// <summary>
        /// Sets behaviour on overflow. Possible values:
        /// </summary>
        [Input("timeoutOverflowMode")]
        public Input<string>? TimeoutOverflowMode { get; set; }

        /// <summary>
        /// Sets behaviour on overflow. Possible values:
        /// </summary>
        [Input("transferOverflowMode")]
        public Input<string>? TransferOverflowMode { get; set; }

        /// <summary>
        /// Enables equality of NULL values for IN operator.
        /// </summary>
        [Input("transformNullIn")]
        public Input<bool>? TransformNullIn { get; set; }

        /// <summary>
        /// Enables hedged requests logic for remote queries. It allows to establish many connections with different replicas for query. New connection is enabled in case existent connection(s) with replica(s) were not established within hedged_connection_timeout or no data was received within receive_data_timeout. Query uses the first connection which send non empty progress packet (or data packet, if allow_changing_replica_until_first_data_packet); other connections are cancelled. Queries with max_parallel_replicas &gt; 1 are supported. Default value: true.
        /// </summary>
        [Input("useHedgedRequests")]
        public Input<bool>? UseHedgedRequests { get; set; }

        /// <summary>
        /// Whether to use a cache of uncompressed blocks.
        /// </summary>
        [Input("useUncompressedCache")]
        public Input<bool>? UseUncompressedCache { get; set; }

        /// <summary>
        /// Enables waiting for processing of asynchronous insertion. If enabled, server returns OK only after the data is inserted.
        /// </summary>
        [Input("waitForAsyncInsert")]
        public Input<bool>? WaitForAsyncInsert { get; set; }

        /// <summary>
        /// The timeout (in seconds) for waiting for processing of asynchronous insertion. Value must be at least 1000 (1 second).
        /// </summary>
        [Input("waitForAsyncInsertTimeout")]
        public Input<int>? WaitForAsyncInsertTimeout { get; set; }

        public MdbClickhouseClusterUserSettingsGetArgs()
        {
        }
        public static new MdbClickhouseClusterUserSettingsGetArgs Empty => new MdbClickhouseClusterUserSettingsGetArgs();
    }
}