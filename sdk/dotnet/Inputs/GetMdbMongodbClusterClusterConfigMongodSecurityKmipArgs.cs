// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterClusterConfigMongodSecurityKmipInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("clientCertificate")]
        public Input<string>? ClientCertificate { get; set; }

        [Input("keyIdentifier")]
        public Input<string>? KeyIdentifier { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("serverCa")]
        public Input<string>? ServerCa { get; set; }

        [Input("serverName")]
        public Input<string>? ServerName { get; set; }

        public GetMdbMongodbClusterClusterConfigMongodSecurityKmipInputArgs()
        {
        }
        public static new GetMdbMongodbClusterClusterConfigMongodSecurityKmipInputArgs Empty => new GetMdbMongodbClusterClusterConfigMongodSecurityKmipInputArgs();
    }
}
