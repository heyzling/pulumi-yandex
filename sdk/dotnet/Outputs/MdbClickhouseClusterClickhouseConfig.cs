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
    public sealed class MdbClickhouseClusterClickhouseConfig
    {
        public readonly int? BackgroundFetchesPoolSize;
        public readonly int? BackgroundMergesMutationsConcurrencyRatio;
        public readonly int? BackgroundMessageBrokerSchedulePoolSize;
        public readonly int? BackgroundPoolSize;
        public readonly int? BackgroundSchedulePoolSize;
        /// <summary>
        /// Data compression configuration. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.MdbClickhouseClusterClickhouseConfigCompression> Compressions;
        public readonly string? DefaultDatabase;
        public readonly bool? DictionariesLazyLoad;
        public readonly bool? GeobaseEnabled;
        public readonly string? GeobaseUri;
        /// <summary>
        /// Graphite rollup configuration. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.MdbClickhouseClusterClickhouseConfigGraphiteRollup> GraphiteRollups;
        /// <summary>
        /// Kafka connection configuration. The structure is documented below.
        /// </summary>
        public readonly Outputs.MdbClickhouseClusterClickhouseConfigKafka? Kafka;
        /// <summary>
        /// Kafka topic connection configuration. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.MdbClickhouseClusterClickhouseConfigKafkaTopic> KafkaTopics;
        public readonly int? KeepAliveTimeout;
        /// <summary>
        /// , `max_connections`, `max_concurrent_queries`, `keep_alive_timeout`, `uncompressed_cache_size`, `mark_cache_size`,
        /// `max_table_size_to_drop`, `max_partition_size_to_drop`, `timezone`, `geobase_uri`, `query_log_retention_size`,
        /// `query_log_retention_time`, `query_thread_log_enabled`, `query_thread_log_retention_size`, `query_thread_log_retention_time`,
        /// `part_log_retention_size`, `part_log_retention_time`, `metric_log_enabled`, `metric_log_retention_size`, `metric_log_retention_time`,
        /// `trace_log_enabled`, `trace_log_retention_size`, `trace_log_retention_time`, `text_log_enabled`, `text_log_retention_size`,
        /// `text_log_retention_time`, `text_log_level`,
        /// `background_pool_size`, `background_schedule_pool_size`, `background_fetches_pool_size`, `background_message_broker_schedule_pool_size`,`background_merges_mutations_concurrency_ratio`,
        /// `default_database`,
        /// `total_memory_profiler_step`, `dictionaries_lazy_load` - (Optional) ClickHouse server parameters. For more information, see
        /// [the official documentation](https://cloud.yandex.com/docs/managed-clickhouse/concepts/settings-list).
        /// </summary>
        public readonly string? LogLevel;
        public readonly int? MarkCacheSize;
        public readonly int? MaxConcurrentQueries;
        public readonly int? MaxConnections;
        public readonly int? MaxPartitionSizeToDrop;
        public readonly int? MaxTableSizeToDrop;
        /// <summary>
        /// MergeTree engine configuration. The structure is documented below.
        /// </summary>
        public readonly Outputs.MdbClickhouseClusterClickhouseConfigMergeTree? MergeTree;
        public readonly bool? MetricLogEnabled;
        public readonly int? MetricLogRetentionSize;
        public readonly int? MetricLogRetentionTime;
        public readonly int? PartLogRetentionSize;
        public readonly int? PartLogRetentionTime;
        /// <summary>
        /// Query cache configuration. The structure is documented below.
        /// </summary>
        public readonly Outputs.MdbClickhouseClusterClickhouseConfigQueryCache? QueryCache;
        public readonly int? QueryLogRetentionSize;
        public readonly int? QueryLogRetentionTime;
        /// <summary>
        /// Query masking rules configuration. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.MdbClickhouseClusterClickhouseConfigQueryMaskingRule> QueryMaskingRules;
        public readonly bool? QueryThreadLogEnabled;
        public readonly int? QueryThreadLogRetentionSize;
        public readonly int? QueryThreadLogRetentionTime;
        /// <summary>
        /// RabbitMQ connection configuration. The structure is documented below.
        /// </summary>
        public readonly Outputs.MdbClickhouseClusterClickhouseConfigRabbitmq? Rabbitmq;
        public readonly bool? TextLogEnabled;
        public readonly string? TextLogLevel;
        public readonly int? TextLogRetentionSize;
        public readonly int? TextLogRetentionTime;
        public readonly string? Timezone;
        public readonly int? TotalMemoryProfilerStep;
        public readonly bool? TraceLogEnabled;
        public readonly int? TraceLogRetentionSize;
        public readonly int? TraceLogRetentionTime;
        public readonly int? UncompressedCacheSize;

        [OutputConstructor]
        private MdbClickhouseClusterClickhouseConfig(
            int? backgroundFetchesPoolSize,

            int? backgroundMergesMutationsConcurrencyRatio,

            int? backgroundMessageBrokerSchedulePoolSize,

            int? backgroundPoolSize,

            int? backgroundSchedulePoolSize,

            ImmutableArray<Outputs.MdbClickhouseClusterClickhouseConfigCompression> compressions,

            string? defaultDatabase,

            bool? dictionariesLazyLoad,

            bool? geobaseEnabled,

            string? geobaseUri,

            ImmutableArray<Outputs.MdbClickhouseClusterClickhouseConfigGraphiteRollup> graphiteRollups,

            Outputs.MdbClickhouseClusterClickhouseConfigKafka? kafka,

            ImmutableArray<Outputs.MdbClickhouseClusterClickhouseConfigKafkaTopic> kafkaTopics,

            int? keepAliveTimeout,

            string? logLevel,

            int? markCacheSize,

            int? maxConcurrentQueries,

            int? maxConnections,

            int? maxPartitionSizeToDrop,

            int? maxTableSizeToDrop,

            Outputs.MdbClickhouseClusterClickhouseConfigMergeTree? mergeTree,

            bool? metricLogEnabled,

            int? metricLogRetentionSize,

            int? metricLogRetentionTime,

            int? partLogRetentionSize,

            int? partLogRetentionTime,

            Outputs.MdbClickhouseClusterClickhouseConfigQueryCache? queryCache,

            int? queryLogRetentionSize,

            int? queryLogRetentionTime,

            ImmutableArray<Outputs.MdbClickhouseClusterClickhouseConfigQueryMaskingRule> queryMaskingRules,

            bool? queryThreadLogEnabled,

            int? queryThreadLogRetentionSize,

            int? queryThreadLogRetentionTime,

            Outputs.MdbClickhouseClusterClickhouseConfigRabbitmq? rabbitmq,

            bool? textLogEnabled,

            string? textLogLevel,

            int? textLogRetentionSize,

            int? textLogRetentionTime,

            string? timezone,

            int? totalMemoryProfilerStep,

            bool? traceLogEnabled,

            int? traceLogRetentionSize,

            int? traceLogRetentionTime,

            int? uncompressedCacheSize)
        {
            BackgroundFetchesPoolSize = backgroundFetchesPoolSize;
            BackgroundMergesMutationsConcurrencyRatio = backgroundMergesMutationsConcurrencyRatio;
            BackgroundMessageBrokerSchedulePoolSize = backgroundMessageBrokerSchedulePoolSize;
            BackgroundPoolSize = backgroundPoolSize;
            BackgroundSchedulePoolSize = backgroundSchedulePoolSize;
            Compressions = compressions;
            DefaultDatabase = defaultDatabase;
            DictionariesLazyLoad = dictionariesLazyLoad;
            GeobaseEnabled = geobaseEnabled;
            GeobaseUri = geobaseUri;
            GraphiteRollups = graphiteRollups;
            Kafka = kafka;
            KafkaTopics = kafkaTopics;
            KeepAliveTimeout = keepAliveTimeout;
            LogLevel = logLevel;
            MarkCacheSize = markCacheSize;
            MaxConcurrentQueries = maxConcurrentQueries;
            MaxConnections = maxConnections;
            MaxPartitionSizeToDrop = maxPartitionSizeToDrop;
            MaxTableSizeToDrop = maxTableSizeToDrop;
            MergeTree = mergeTree;
            MetricLogEnabled = metricLogEnabled;
            MetricLogRetentionSize = metricLogRetentionSize;
            MetricLogRetentionTime = metricLogRetentionTime;
            PartLogRetentionSize = partLogRetentionSize;
            PartLogRetentionTime = partLogRetentionTime;
            QueryCache = queryCache;
            QueryLogRetentionSize = queryLogRetentionSize;
            QueryLogRetentionTime = queryLogRetentionTime;
            QueryMaskingRules = queryMaskingRules;
            QueryThreadLogEnabled = queryThreadLogEnabled;
            QueryThreadLogRetentionSize = queryThreadLogRetentionSize;
            QueryThreadLogRetentionTime = queryThreadLogRetentionTime;
            Rabbitmq = rabbitmq;
            TextLogEnabled = textLogEnabled;
            TextLogLevel = textLogLevel;
            TextLogRetentionSize = textLogRetentionSize;
            TextLogRetentionTime = textLogRetentionTime;
            Timezone = timezone;
            TotalMemoryProfilerStep = totalMemoryProfilerStep;
            TraceLogEnabled = traceLogEnabled;
            TraceLogRetentionSize = traceLogRetentionSize;
            TraceLogRetentionTime = traceLogRetentionTime;
            UncompressedCacheSize = uncompressedCacheSize;
        }
    }
}