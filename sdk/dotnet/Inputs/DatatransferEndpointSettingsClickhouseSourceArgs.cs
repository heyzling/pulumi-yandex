// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsClickhouseSourceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the ClickHouse cluster. For managed ClickHouse clusters defaults to managed cluster ID.
        /// </summary>
        [Input("clickhouseClusterName")]
        public Input<string>? ClickhouseClusterName { get; set; }

        /// <summary>
        /// Connection settings. The structure is documented below.
        /// </summary>
        [Input("connection")]
        public Input<Inputs.DatatransferEndpointSettingsClickhouseSourceConnectionArgs>? Connection { get; set; }

        [Input("excludeTables")]
        private InputList<string>? _excludeTables;

        /// <summary>
        /// The list of tables that should not be transferred.
        /// </summary>
        public InputList<string> ExcludeTables
        {
            get => _excludeTables ?? (_excludeTables = new InputList<string>());
            set => _excludeTables = value;
        }

        [Input("includeTables")]
        private InputList<string>? _includeTables;

        /// <summary>
        /// The list of tables that should be transferred. Leave empty if all tables should be transferred.
        /// </summary>
        public InputList<string> IncludeTables
        {
            get => _includeTables ?? (_includeTables = new InputList<string>());
            set => _includeTables = value;
        }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;

        /// <summary>
        /// List of security groups that the transfer associated with this endpoint should use.
        /// </summary>
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        /// <summary>
        /// Identifier of the Yandex Cloud VPC subnetwork to user for accessing the database. If omitted, the server has to be accessible via Internet.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        public DatatransferEndpointSettingsClickhouseSourceArgs()
        {
        }
        public static new DatatransferEndpointSettingsClickhouseSourceArgs Empty => new DatatransferEndpointSettingsClickhouseSourceArgs();
    }
}
