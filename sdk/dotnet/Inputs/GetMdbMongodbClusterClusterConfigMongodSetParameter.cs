// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterClusterConfigMongodSetParameterArgs : global::Pulumi.InvokeArgs
    {
        [Input("auditAuthorizationSuccess")]
        public bool? AuditAuthorizationSuccess { get; set; }

        [Input("enableFlowControl")]
        public bool? EnableFlowControl { get; set; }

        [Input("minSnapshotHistoryWindowInSeconds")]
        public int? MinSnapshotHistoryWindowInSeconds { get; set; }

        public GetMdbMongodbClusterClusterConfigMongodSetParameterArgs()
        {
        }
        public static new GetMdbMongodbClusterClusterConfigMongodSetParameterArgs Empty => new GetMdbMongodbClusterClusterConfigMongodSetParameterArgs();
    }
}
