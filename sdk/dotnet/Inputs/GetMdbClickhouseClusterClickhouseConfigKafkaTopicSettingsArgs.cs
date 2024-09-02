// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterClickhouseConfigKafkaTopicSettingsInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("autoOffsetReset", required: true)]
        public Input<string> AutoOffsetReset { get; set; } = null!;

        [Input("debug", required: true)]
        public Input<string> Debug { get; set; } = null!;

        [Input("enableSslCertificateVerification", required: true)]
        public Input<bool> EnableSslCertificateVerification { get; set; } = null!;

        [Input("maxPollIntervalMs", required: true)]
        public Input<int> MaxPollIntervalMs { get; set; } = null!;

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

        [Input("sessionTimeoutMs", required: true)]
        public Input<int> SessionTimeoutMs { get; set; } = null!;

        public GetMdbClickhouseClusterClickhouseConfigKafkaTopicSettingsInputArgs()
        {
        }
        public static new GetMdbClickhouseClusterClickhouseConfigKafkaTopicSettingsInputArgs Empty => new GetMdbClickhouseClusterClickhouseConfigKafkaTopicSettingsInputArgs();
    }
}