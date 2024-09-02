// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// TCP port number for the HTTP interface of the ClickHouse server.
        /// </summary>
        [Input("httpPort")]
        public Input<int>? HttpPort { get; set; }

        /// <summary>
        /// TCP port number for the native interface of the ClickHouse server.
        /// </summary>
        [Input("nativePort")]
        public Input<int>? NativePort { get; set; }

        [Input("shards")]
        private InputList<Inputs.DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseShardGetArgs>? _shards;

        /// <summary>
        /// The list of ClickHouse shards. The structure is documented below.
        /// </summary>
        public InputList<Inputs.DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseShardGetArgs> Shards
        {
            get => _shards ?? (_shards = new InputList<Inputs.DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseShardGetArgs>());
            set => _shards = value;
        }

        /// <summary>
        /// TLS settings for the server connection. Empty implies plaintext connection. The structure is documented below.
        /// </summary>
        [Input("tlsMode")]
        public Input<Inputs.DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseTlsModeGetArgs>? TlsMode { get; set; }

        public DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseGetArgs Empty => new DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptionsOnPremiseGetArgs();
    }
}