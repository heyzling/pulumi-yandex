// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterHostInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("assignPublicIp")]
        public Input<bool>? AssignPublicIp { get; set; }

        [Input("health", required: true)]
        public Input<string> Health { get; set; } = null!;

        [Input("hostParameters", required: true)]
        public Input<Inputs.GetMdbMongodbClusterHostHostParametersInputArgs> HostParameters { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        [Input("shardName", required: true)]
        public Input<string> ShardName { get; set; } = null!;

        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("zoneId")]
        public Input<string>? ZoneId { get; set; }

        public GetMdbMongodbClusterHostInputArgs()
        {
        }
        public static new GetMdbMongodbClusterHostInputArgs Empty => new GetMdbMongodbClusterHostInputArgs();
    }
}
