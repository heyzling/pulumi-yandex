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
    public sealed class DatatransferEndpointSettingsClickhouseTarget
    {
        /// <summary>
        /// Table renaming rules. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.DatatransferEndpointSettingsClickhouseTargetAltName> AltNames;
        /// <summary>
        /// How to clean collections when activating the transfer. One of "CLICKHOUSE_CLEANUP_POLICY_DISABLED" or "CLICKHOUSE_CLEANUP_POLICY_DROP".
        /// </summary>
        public readonly string? CleanupPolicy;
        /// <summary>
        /// Name of the ClickHouse cluster. For managed ClickHouse clusters defaults to managed cluster ID.
        /// </summary>
        public readonly string? ClickhouseClusterName;
        /// <summary>
        /// Connection settings. The structure is documented below.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsClickhouseTargetConnection? Connection;
        /// <summary>
        /// List of security groups that the transfer associated with this endpoint should use.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroups;
        /// <summary>
        /// Shard selection rules for the data being transferred. The structure is documented below.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsClickhouseTargetSharding? Sharding;
        /// <summary>
        /// Identifier of the Yandex Cloud VPC subnetwork to user for accessing the database. If omitted, the server has to be accessible via Internet.
        /// </summary>
        public readonly string? SubnetId;

        [OutputConstructor]
        private DatatransferEndpointSettingsClickhouseTarget(
            ImmutableArray<Outputs.DatatransferEndpointSettingsClickhouseTargetAltName> altNames,

            string? cleanupPolicy,

            string? clickhouseClusterName,

            Outputs.DatatransferEndpointSettingsClickhouseTargetConnection? connection,

            ImmutableArray<string> securityGroups,

            Outputs.DatatransferEndpointSettingsClickhouseTargetSharding? sharding,

            string? subnetId)
        {
            AltNames = altNames;
            CleanupPolicy = cleanupPolicy;
            ClickhouseClusterName = clickhouseClusterName;
            Connection = connection;
            SecurityGroups = securityGroups;
            Sharding = sharding;
            SubnetId = subnetId;
        }
    }
}