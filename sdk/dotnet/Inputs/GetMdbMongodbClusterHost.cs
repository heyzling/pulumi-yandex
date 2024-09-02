// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterHostArgs : global::Pulumi.InvokeArgs
    {
        [Input("assignPublicIp")]
        public bool? AssignPublicIp { get; set; }

        [Input("health", required: true)]
        public string Health { get; set; } = null!;

        [Input("hostParameters", required: true)]
        public Inputs.GetMdbMongodbClusterHostHostParametersArgs HostParameters { get; set; } = null!;

        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("role", required: true)]
        public string Role { get; set; } = null!;

        [Input("shardName", required: true)]
        public string ShardName { get; set; } = null!;

        [Input("subnetId")]
        public string? SubnetId { get; set; }

        [Input("type")]
        public string? Type { get; set; }

        [Input("zoneId")]
        public string? ZoneId { get; set; }

        public GetMdbMongodbClusterHostArgs()
        {
        }
        public static new GetMdbMongodbClusterHostArgs Empty => new GetMdbMongodbClusterHostArgs();
    }
}