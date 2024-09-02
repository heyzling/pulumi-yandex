// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalClusterArgs : global::Pulumi.ResourceArgs
    {
        [Input("bootstrapServers", required: true)]
        public Input<string> BootstrapServers { get; set; } = null!;

        [Input("saslMechanism")]
        public Input<string>? SaslMechanism { get; set; }

        [Input("saslPassword")]
        private Input<string>? _saslPassword;
        public Input<string>? SaslPassword
        {
            get => _saslPassword;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _saslPassword = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("saslUsername")]
        public Input<string>? SaslUsername { get; set; }

        [Input("securityProtocol")]
        public Input<string>? SecurityProtocol { get; set; }

        public MdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalClusterArgs()
        {
        }
        public static new MdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalClusterArgs Empty => new MdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalClusterArgs();
    }
}
