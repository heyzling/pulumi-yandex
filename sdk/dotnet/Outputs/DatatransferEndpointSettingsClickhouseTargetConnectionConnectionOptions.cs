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
    public sealed class DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptions
    {
        /// <summary>
        /// Database name.
        /// </summary>
        public readonly string? Database;
        /// <summary>
        /// Identifier of the Managed ClickHouse cluster.
        /// </summary>
        public readonly string? MdbClusterId;
        /// <summary>
        /// Connection settings of the on-premise ClickHouse server.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremise? OnPremise;
        /// <summary>
        /// Password for the database access. This is a block with a single field named `raw` which should contain the password.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsPassword? Password;
        /// <summary>
        /// User for database access.
        /// </summary>
        public readonly string? User;

        [OutputConstructor]
        private DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptions(
            string? database,

            string? mdbClusterId,

            Outputs.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremise? onPremise,

            Outputs.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsPassword? password,

            string? user)
        {
            Database = database;
            MdbClusterId = mdbClusterId;
            OnPremise = onPremise;
            Password = password;
            User = user;
        }
    }
}