// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsYdsSourceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - (Optional) Should continue working, if consumer read lag exceed TTL of topic.
        /// </summary>
        [Input("allowTtlRewind")]
        public Input<bool>? AllowTtlRewind { get; set; }

        /// <summary>
        /// - (Optional) Consumer.
        /// </summary>
        [Input("consumer")]
        public Input<string>? Consumer { get; set; }

        /// <summary>
        /// Database name.
        /// </summary>
        [Input("database")]
        public Input<string>? Database { get; set; }

        /// <summary>
        /// - (Optional) YDS Endpoint.
        /// </summary>
        [Input("endpoint")]
        public Input<string>? Endpoint { get; set; }

        /// <summary>
        /// Data parsing parameters. If not set, the source messages are read in raw.
        /// </summary>
        [Input("parser")]
        public Input<Inputs.DatatransferEndpointSettingsYdsSourceParserArgs>? Parser { get; set; }

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
        /// - (Required) Service account ID for interaction with database.
        /// </summary>
        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        /// <summary>
        /// - (Optional) Stream.
        /// </summary>
        [Input("stream")]
        public Input<string>? Stream { get; set; }

        /// <summary>
        /// Identifier of the Yandex Cloud VPC subnetwork to user for accessing the database. If omitted, the server has to be accessible via Internet.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        [Input("supportedCodecs")]
        private InputList<string>? _supportedCodecs;

        /// <summary>
        /// - (Optional) List of supported compression codec.
        /// </summary>
        public InputList<string> SupportedCodecs
        {
            get => _supportedCodecs ?? (_supportedCodecs = new InputList<string>());
            set => _supportedCodecs = value;
        }

        public DatatransferEndpointSettingsYdsSourceArgs()
        {
        }
        public static new DatatransferEndpointSettingsYdsSourceArgs Empty => new DatatransferEndpointSettingsYdsSourceArgs();
    }
}
