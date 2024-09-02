// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsKafkaTargetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Authentication data.
        /// </summary>
        [Input("auth")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaTargetAuthArgs>? Auth { get; set; }

        /// <summary>
        /// Connection settings.
        /// </summary>
        [Input("connection")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaTargetConnectionArgs>? Connection { get; set; }

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
        /// Data serialization settings.
        /// </summary>
        [Input("serializer")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaTargetSerializerArgs>? Serializer { get; set; }

        /// <summary>
        /// Target topic settings.
        /// </summary>
        [Input("topicSettings")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaTargetTopicSettingsArgs>? TopicSettings { get; set; }

        public DatatransferEndpointSettingsKafkaTargetArgs()
        {
        }
        public static new DatatransferEndpointSettingsKafkaTargetArgs Empty => new DatatransferEndpointSettingsKafkaTargetArgs();
    }
}
