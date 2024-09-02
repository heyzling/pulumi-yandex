// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterClickhouseConfigArgs : global::Pulumi.ResourceArgs
    {
        [Input("backgroundFetchesPoolSize")]
        public Input<int>? BackgroundFetchesPoolSize { get; set; }

        [Input("backgroundMergesMutationsConcurrencyRatio")]
        public Input<int>? BackgroundMergesMutationsConcurrencyRatio { get; set; }

        [Input("backgroundMessageBrokerSchedulePoolSize")]
        public Input<int>? BackgroundMessageBrokerSchedulePoolSize { get; set; }

        [Input("backgroundPoolSize")]
        public Input<int>? BackgroundPoolSize { get; set; }

        [Input("backgroundSchedulePoolSize")]
        public Input<int>? BackgroundSchedulePoolSize { get; set; }

        [Input("compressions")]
        private InputList<Inputs.MdbClickhouseClusterClickhouseConfigCompressionArgs>? _compressions;

        /// <summary>
        /// Data compression configuration. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterClickhouseConfigCompressionArgs> Compressions
        {
            get => _compressions ?? (_compressions = new InputList<Inputs.MdbClickhouseClusterClickhouseConfigCompressionArgs>());
            set => _compressions = value;
        }

        [Input("defaultDatabase")]
        public Input<string>? DefaultDatabase { get; set; }

        [Input("dictionariesLazyLoad")]
        public Input<bool>? DictionariesLazyLoad { get; set; }

        [Input("geobaseEnabled")]
        public Input<bool>? GeobaseEnabled { get; set; }

        [Input("geobaseUri")]
        public Input<string>? GeobaseUri { get; set; }

        [Input("graphiteRollups")]
        private InputList<Inputs.MdbClickhouseClusterClickhouseConfigGraphiteRollupArgs>? _graphiteRollups;

        /// <summary>
        /// Graphite rollup configuration. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterClickhouseConfigGraphiteRollupArgs> GraphiteRollups
        {
            get => _graphiteRollups ?? (_graphiteRollups = new InputList<Inputs.MdbClickhouseClusterClickhouseConfigGraphiteRollupArgs>());
            set => _graphiteRollups = value;
        }

        /// <summary>
        /// Kafka connection configuration. The structure is documented below.
        /// </summary>
        [Input("kafka")]
        public Input<Inputs.MdbClickhouseClusterClickhouseConfigKafkaArgs>? Kafka { get; set; }

        [Input("kafkaTopics")]
        private InputList<Inputs.MdbClickhouseClusterClickhouseConfigKafkaTopicArgs>? _kafkaTopics;

        /// <summary>
        /// Kafka topic connection configuration. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterClickhouseConfigKafkaTopicArgs> KafkaTopics
        {
            get => _kafkaTopics ?? (_kafkaTopics = new InputList<Inputs.MdbClickhouseClusterClickhouseConfigKafkaTopicArgs>());
            set => _kafkaTopics = value;
        }

        [Input("keepAliveTimeout")]
        public Input<int>? KeepAliveTimeout { get; set; }

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
        [Input("logLevel")]
        public Input<string>? LogLevel { get; set; }

        [Input("markCacheSize")]
        public Input<int>? MarkCacheSize { get; set; }

        [Input("maxConcurrentQueries")]
        public Input<int>? MaxConcurrentQueries { get; set; }

        [Input("maxConnections")]
        public Input<int>? MaxConnections { get; set; }

        [Input("maxPartitionSizeToDrop")]
        public Input<int>? MaxPartitionSizeToDrop { get; set; }

        [Input("maxTableSizeToDrop")]
        public Input<int>? MaxTableSizeToDrop { get; set; }

        /// <summary>
        /// MergeTree engine configuration. The structure is documented below.
        /// </summary>
        [Input("mergeTree")]
        public Input<Inputs.MdbClickhouseClusterClickhouseConfigMergeTreeArgs>? MergeTree { get; set; }

        [Input("metricLogEnabled")]
        public Input<bool>? MetricLogEnabled { get; set; }

        [Input("metricLogRetentionSize")]
        public Input<int>? MetricLogRetentionSize { get; set; }

        [Input("metricLogRetentionTime")]
        public Input<int>? MetricLogRetentionTime { get; set; }

        [Input("partLogRetentionSize")]
        public Input<int>? PartLogRetentionSize { get; set; }

        [Input("partLogRetentionTime")]
        public Input<int>? PartLogRetentionTime { get; set; }

        /// <summary>
        /// Query cache configuration. The structure is documented below.
        /// </summary>
        [Input("queryCache")]
        public Input<Inputs.MdbClickhouseClusterClickhouseConfigQueryCacheArgs>? QueryCache { get; set; }

        [Input("queryLogRetentionSize")]
        public Input<int>? QueryLogRetentionSize { get; set; }

        [Input("queryLogRetentionTime")]
        public Input<int>? QueryLogRetentionTime { get; set; }

        [Input("queryMaskingRules")]
        private InputList<Inputs.MdbClickhouseClusterClickhouseConfigQueryMaskingRuleArgs>? _queryMaskingRules;

        /// <summary>
        /// Query masking rules configuration. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterClickhouseConfigQueryMaskingRuleArgs> QueryMaskingRules
        {
            get => _queryMaskingRules ?? (_queryMaskingRules = new InputList<Inputs.MdbClickhouseClusterClickhouseConfigQueryMaskingRuleArgs>());
            set => _queryMaskingRules = value;
        }

        [Input("queryThreadLogEnabled")]
        public Input<bool>? QueryThreadLogEnabled { get; set; }

        [Input("queryThreadLogRetentionSize")]
        public Input<int>? QueryThreadLogRetentionSize { get; set; }

        [Input("queryThreadLogRetentionTime")]
        public Input<int>? QueryThreadLogRetentionTime { get; set; }

        /// <summary>
        /// RabbitMQ connection configuration. The structure is documented below.
        /// </summary>
        [Input("rabbitmq")]
        public Input<Inputs.MdbClickhouseClusterClickhouseConfigRabbitmqArgs>? Rabbitmq { get; set; }

        [Input("textLogEnabled")]
        public Input<bool>? TextLogEnabled { get; set; }

        [Input("textLogLevel")]
        public Input<string>? TextLogLevel { get; set; }

        [Input("textLogRetentionSize")]
        public Input<int>? TextLogRetentionSize { get; set; }

        [Input("textLogRetentionTime")]
        public Input<int>? TextLogRetentionTime { get; set; }

        [Input("timezone")]
        public Input<string>? Timezone { get; set; }

        [Input("totalMemoryProfilerStep")]
        public Input<int>? TotalMemoryProfilerStep { get; set; }

        [Input("traceLogEnabled")]
        public Input<bool>? TraceLogEnabled { get; set; }

        [Input("traceLogRetentionSize")]
        public Input<int>? TraceLogRetentionSize { get; set; }

        [Input("traceLogRetentionTime")]
        public Input<int>? TraceLogRetentionTime { get; set; }

        [Input("uncompressedCacheSize")]
        public Input<int>? UncompressedCacheSize { get; set; }

        public MdbClickhouseClusterClickhouseConfigArgs()
        {
        }
        public static new MdbClickhouseClusterClickhouseConfigArgs Empty => new MdbClickhouseClusterClickhouseConfigArgs();
    }
}