// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterClusterConfigMongodSecurityKmipArgs : global::Pulumi.InvokeArgs
    {
        [Input("clientCertificate")]
        public string? ClientCertificate { get; set; }

        [Input("keyIdentifier")]
        public string? KeyIdentifier { get; set; }

        [Input("port")]
        public int? Port { get; set; }

        [Input("serverCa")]
        public string? ServerCa { get; set; }

        [Input("serverName")]
        public string? ServerName { get; set; }

        public GetMdbMongodbClusterClusterConfigMongodSecurityKmipArgs()
        {
        }
        public static new GetMdbMongodbClusterClusterConfigMongodSecurityKmipArgs Empty => new GetMdbMongodbClusterClusterConfigMongodSecurityKmipArgs();
    }
}