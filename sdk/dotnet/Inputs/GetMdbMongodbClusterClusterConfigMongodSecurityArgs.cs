// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterClusterConfigMongodSecurityInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("enableEncryption")]
        public Input<bool>? EnableEncryption { get; set; }

        [Input("kmip", required: true)]
        public Input<Inputs.GetMdbMongodbClusterClusterConfigMongodSecurityKmipInputArgs> Kmip { get; set; } = null!;

        public GetMdbMongodbClusterClusterConfigMongodSecurityInputArgs()
        {
        }
        public static new GetMdbMongodbClusterClusterConfigMongodSecurityInputArgs Empty => new GetMdbMongodbClusterClusterConfigMongodSecurityInputArgs();
    }
}
