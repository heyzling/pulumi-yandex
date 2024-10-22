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
    public sealed class GetMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalClusterResult
    {
        public readonly string BootstrapServers;
        public readonly string SaslMechanism;
        public readonly string SaslPassword;
        public readonly string SaslUsername;
        public readonly string SecurityProtocol;

        [OutputConstructor]
        private GetMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalClusterResult(
            string bootstrapServers,

            string saslMechanism,

            string saslPassword,

            string saslUsername,

            string securityProtocol)
        {
            BootstrapServers = bootstrapServers;
            SaslMechanism = saslMechanism;
            SaslPassword = saslPassword;
            SaslUsername = saslUsername;
            SecurityProtocol = securityProtocol;
        }
    }
}
