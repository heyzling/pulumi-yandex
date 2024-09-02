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
    public sealed class DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremise
    {
        /// <summary>
        /// TCP port number for the HTTP interface of the ClickHouse server.
        /// </summary>
        public readonly int? HttpPort;
        /// <summary>
        /// TCP port number for the native interface of the ClickHouse server.
        /// </summary>
        public readonly int? NativePort;
        /// <summary>
        /// The list of ClickHouse shards. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremiseShard> Shards;
        /// <summary>
        /// TLS settings for the server connection. Empty implies plaintext connection. The structure is documented below.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremiseTlsMode? TlsMode;

        [OutputConstructor]
        private DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremise(
            int? httpPort,

            int? nativePort,

            ImmutableArray<Outputs.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremiseShard> shards,

            Outputs.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremiseTlsMode? tlsMode)
        {
            HttpPort = httpPort;
            NativePort = nativePort;
            Shards = shards;
            TlsMode = tlsMode;
        }
    }
}
