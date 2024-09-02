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
    public sealed class DatatransferEndpointSettingsYdbSource
    {
        /// <summary>
        /// - (Optional) Custom name for changefeed.
        /// </summary>
        public readonly string? ChangefeedCustomName;
        /// <summary>
        /// Database name.
        /// </summary>
        public readonly string? Database;
        /// <summary>
        /// - (Optional) Instance of YDB. Example: "my-cute-ydb.cloud.yandex.ru:2135".
        /// </summary>
        public readonly string? Instance;
        /// <summary>
        /// - (Optional) A list of paths which should be uploaded. When not specified, all available tables are uploaded.
        /// </summary>
        public readonly ImmutableArray<string> Paths;
        /// <summary>
        /// - (Optional, Sensitive) Authentication key.
        /// </summary>
        public readonly string? SaKeyContent;
        /// <summary>
        /// List of security groups that the transfer associated with this endpoint should use.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroups;
        /// <summary>
        /// - (Required) Service account ID for interaction with database.
        /// </summary>
        public readonly string? ServiceAccountId;
        /// <summary>
        /// Identifier of the Yandex Cloud VPC subnetwork to user for accessing the database. If omitted, the server has to be accessible via Internet.
        /// </summary>
        public readonly string? SubnetId;

        [OutputConstructor]
        private DatatransferEndpointSettingsYdbSource(
            string? changefeedCustomName,

            string? database,

            string? instance,

            ImmutableArray<string> paths,

            string? saKeyContent,

            ImmutableArray<string> securityGroups,

            string? serviceAccountId,

            string? subnetId)
        {
            ChangefeedCustomName = changefeedCustomName;
            Database = database;
            Instance = instance;
            Paths = paths;
            SaKeyContent = saKeyContent;
            SecurityGroups = securityGroups;
            ServiceAccountId = serviceAccountId;
            SubnetId = subnetId;
        }
    }
}