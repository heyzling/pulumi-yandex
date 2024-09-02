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
    public sealed class DatatransferEndpointSettings
    {
        /// <summary>
        /// Settings specific to the ClickHouse source endpoint.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsClickhouseSource? ClickhouseSource;
        /// <summary>
        /// Settings specific to the ClickHouse target endpoint.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsClickhouseTarget? ClickhouseTarget;
        /// <summary>
        /// Settings specific to the Kafka source endpoint.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsKafkaSource? KafkaSource;
        /// <summary>
        /// Settings specific to the Kafka target endpoint.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsKafkaTarget? KafkaTarget;
        public readonly Outputs.DatatransferEndpointSettingsMetrikaSource? MetrikaSource;
        /// <summary>
        /// Settings specific to the MongoDB source endpoint.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsMongoSource? MongoSource;
        /// <summary>
        /// Settings specific to the MongoDB target endpoint.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsMongoTarget? MongoTarget;
        /// <summary>
        /// Settings specific to the MySQL source endpoint.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsMysqlSource? MysqlSource;
        /// <summary>
        /// Settings specific to the MySQL target endpoint.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsMysqlTarget? MysqlTarget;
        /// <summary>
        /// Settings specific to the PostgreSQL source endpoint.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsPostgresSource? PostgresSource;
        /// <summary>
        /// Settings specific to the PostgreSQL target endpoint.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsPostgresTarget? PostgresTarget;
        /// <summary>
        /// Settings specific to the YDB source endpoint.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsYdbSource? YdbSource;
        /// <summary>
        /// Settings specific to the YDB target endpoint.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsYdbTarget? YdbTarget;
        /// <summary>
        /// Settings specific to the YDS source endpoint.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsYdsSource? YdsSource;
        /// <summary>
        /// Settings specific to the YDS target endpoint.
        /// 
        /// For the documentation of the specific endpoint settings see below.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsYdsTarget? YdsTarget;

        [OutputConstructor]
        private DatatransferEndpointSettings(
            Outputs.DatatransferEndpointSettingsClickhouseSource? clickhouseSource,

            Outputs.DatatransferEndpointSettingsClickhouseTarget? clickhouseTarget,

            Outputs.DatatransferEndpointSettingsKafkaSource? kafkaSource,

            Outputs.DatatransferEndpointSettingsKafkaTarget? kafkaTarget,

            Outputs.DatatransferEndpointSettingsMetrikaSource? metrikaSource,

            Outputs.DatatransferEndpointSettingsMongoSource? mongoSource,

            Outputs.DatatransferEndpointSettingsMongoTarget? mongoTarget,

            Outputs.DatatransferEndpointSettingsMysqlSource? mysqlSource,

            Outputs.DatatransferEndpointSettingsMysqlTarget? mysqlTarget,

            Outputs.DatatransferEndpointSettingsPostgresSource? postgresSource,

            Outputs.DatatransferEndpointSettingsPostgresTarget? postgresTarget,

            Outputs.DatatransferEndpointSettingsYdbSource? ydbSource,

            Outputs.DatatransferEndpointSettingsYdbTarget? ydbTarget,

            Outputs.DatatransferEndpointSettingsYdsSource? ydsSource,

            Outputs.DatatransferEndpointSettingsYdsTarget? ydsTarget)
        {
            ClickhouseSource = clickhouseSource;
            ClickhouseTarget = clickhouseTarget;
            KafkaSource = kafkaSource;
            KafkaTarget = kafkaTarget;
            MetrikaSource = metrikaSource;
            MongoSource = mongoSource;
            MongoTarget = mongoTarget;
            MysqlSource = mysqlSource;
            MysqlTarget = mysqlTarget;
            PostgresSource = postgresSource;
            PostgresTarget = postgresTarget;
            YdbSource = ydbSource;
            YdbTarget = ydbTarget;
            YdsSource = ydsSource;
            YdsTarget = ydsTarget;
        }
    }
}
