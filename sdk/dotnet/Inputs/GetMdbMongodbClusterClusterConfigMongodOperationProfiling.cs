// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterClusterConfigMongodOperationProfilingArgs : global::Pulumi.InvokeArgs
    {
        [Input("mode")]
        public string? Mode { get; set; }

        [Input("slowOpSampleRate")]
        public double? SlowOpSampleRate { get; set; }

        [Input("slowOpThreshold")]
        public int? SlowOpThreshold { get; set; }

        public GetMdbMongodbClusterClusterConfigMongodOperationProfilingArgs()
        {
        }
        public static new GetMdbMongodbClusterClusterConfigMongodOperationProfilingArgs Empty => new GetMdbMongodbClusterClusterConfigMongodOperationProfilingArgs();
    }
}
