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
    public sealed class MdbPostgresqlClusterConfig
    {
        /// <summary>
        /// Access policy to the PostgreSQL cluster. The structure is documented below.
        /// </summary>
        public readonly Outputs.MdbPostgresqlClusterConfigAccess? Access;
        /// <summary>
        /// Configuration setting which enables/disables autofailover in cluster.
        /// </summary>
        public readonly bool? Autofailover;
        /// <summary>
        /// The period in days during which backups are stored.
        /// </summary>
        public readonly int? BackupRetainPeriodDays;
        /// <summary>
        /// Time to start the daily backup, in the UTC timezone. The structure is documented below.
        /// </summary>
        public readonly Outputs.MdbPostgresqlClusterConfigBackupWindowStart? BackupWindowStart;
        /// <summary>
        /// Cluster disk size autoscaling settings. The structure is documented below.
        /// </summary>
        public readonly Outputs.MdbPostgresqlClusterConfigDiskSizeAutoscaling? DiskSizeAutoscaling;
        /// <summary>
        /// Cluster performance diagnostics settings. The structure is documented below. [YC Documentation](https://cloud.yandex.com/en-ru/docs/managed-postgresql/api-ref/grpc/cluster_service#PerformanceDiagnostics)
        /// </summary>
        public readonly Outputs.MdbPostgresqlClusterConfigPerformanceDiagnostics? PerformanceDiagnostics;
        /// <summary>
        /// Configuration of the connection pooler. The structure is documented below.
        /// </summary>
        public readonly Outputs.MdbPostgresqlClusterConfigPoolerConfig? PoolerConfig;
        /// <summary>
        /// PostgreSQL cluster config. Detail info in "postresql config" section (documented below).
        /// </summary>
        public readonly ImmutableDictionary<string, string>? PostgresqlConfig;
        /// <summary>
        /// Resources allocated to hosts of the PostgreSQL cluster. The structure is documented below.
        /// </summary>
        public readonly Outputs.MdbPostgresqlClusterConfigResources Resources;
        /// <summary>
        /// Version of the PostgreSQL cluster. (allowed versions are: 10, 10-1c, 11, 11-1c, 12, 12-1c, 13, 13-1c, 14, 14-1c, 15, 15-1c, 16)
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private MdbPostgresqlClusterConfig(
            Outputs.MdbPostgresqlClusterConfigAccess? access,

            bool? autofailover,

            int? backupRetainPeriodDays,

            Outputs.MdbPostgresqlClusterConfigBackupWindowStart? backupWindowStart,

            Outputs.MdbPostgresqlClusterConfigDiskSizeAutoscaling? diskSizeAutoscaling,

            Outputs.MdbPostgresqlClusterConfigPerformanceDiagnostics? performanceDiagnostics,

            Outputs.MdbPostgresqlClusterConfigPoolerConfig? poolerConfig,

            ImmutableDictionary<string, string>? postgresqlConfig,

            Outputs.MdbPostgresqlClusterConfigResources resources,

            string version)
        {
            Access = access;
            Autofailover = autofailover;
            BackupRetainPeriodDays = backupRetainPeriodDays;
            BackupWindowStart = backupWindowStart;
            DiskSizeAutoscaling = diskSizeAutoscaling;
            PerformanceDiagnostics = performanceDiagnostics;
            PoolerConfig = poolerConfig;
            PostgresqlConfig = postgresqlConfig;
            Resources = resources;
            Version = version;
        }
    }
}
