// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsPostgresSourceConnectionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Identifier of the Managed MySQL cluster.
        /// </summary>
        [Input("mdbClusterId")]
        public Input<string>? MdbClusterId { get; set; }

        /// <summary>
        /// Connection settings of the on-premise Kafka server.
        /// </summary>
        [Input("onPremise")]
        public Input<Inputs.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseGetArgs>? OnPremise { get; set; }

        public DatatransferEndpointSettingsPostgresSourceConnectionGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsPostgresSourceConnectionGetArgs Empty => new DatatransferEndpointSettingsPostgresSourceConnectionGetArgs();
    }
}
