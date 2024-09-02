// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbPostgresqlClusterConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Access policy to the PostgreSQL cluster. The structure is documented below.
        /// </summary>
        [Input("access")]
        public Input<Inputs.MdbPostgresqlClusterConfigAccessArgs>? Access { get; set; }

        /// <summary>
        /// Configuration setting which enables/disables autofailover in cluster.
        /// </summary>
        [Input("autofailover")]
        public Input<bool>? Autofailover { get; set; }

        /// <summary>
        /// The period in days during which backups are stored.
        /// </summary>
        [Input("backupRetainPeriodDays")]
        public Input<int>? BackupRetainPeriodDays { get; set; }

        /// <summary>
        /// Time to start the daily backup, in the UTC timezone. The structure is documented below.
        /// </summary>
        [Input("backupWindowStart")]
        public Input<Inputs.MdbPostgresqlClusterConfigBackupWindowStartArgs>? BackupWindowStart { get; set; }

        /// <summary>
        /// Cluster disk size autoscaling settings. The structure is documented below.
        /// </summary>
        [Input("diskSizeAutoscaling")]
        public Input<Inputs.MdbPostgresqlClusterConfigDiskSizeAutoscalingArgs>? DiskSizeAutoscaling { get; set; }

        /// <summary>
        /// Cluster performance diagnostics settings. The structure is documented below. [YC Documentation](https://cloud.yandex.com/en-ru/docs/managed-postgresql/api-ref/grpc/cluster_service#PerformanceDiagnostics)
        /// </summary>
        [Input("performanceDiagnostics")]
        public Input<Inputs.MdbPostgresqlClusterConfigPerformanceDiagnosticsArgs>? PerformanceDiagnostics { get; set; }

        /// <summary>
        /// Configuration of the connection pooler. The structure is documented below.
        /// </summary>
        [Input("poolerConfig")]
        public Input<Inputs.MdbPostgresqlClusterConfigPoolerConfigArgs>? PoolerConfig { get; set; }

        [Input("postgresqlConfig")]
        private InputMap<string>? _postgresqlConfig;

        /// <summary>
        /// PostgreSQL cluster config. Detail info in "postresql config" section (documented below).
        /// </summary>
        public InputMap<string> PostgresqlConfig
        {
            get => _postgresqlConfig ?? (_postgresqlConfig = new InputMap<string>());
            set => _postgresqlConfig = value;
        }

        /// <summary>
        /// Resources allocated to hosts of the PostgreSQL cluster. The structure is documented below.
        /// </summary>
        [Input("resources", required: true)]
        public Input<Inputs.MdbPostgresqlClusterConfigResourcesArgs> Resources { get; set; } = null!;

        /// <summary>
        /// Version of the PostgreSQL cluster. (allowed versions are: 10, 10-1c, 11, 11-1c, 12, 12-1c, 13, 13-1c, 14, 14-1c, 15, 15-1c, 16)
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public MdbPostgresqlClusterConfigArgs()
        {
        }
        public static new MdbPostgresqlClusterConfigArgs Empty => new MdbPostgresqlClusterConfigArgs();
    }
}
