// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterClusterConfigMongodOperationProfilingInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("mode")]
        public Input<string>? Mode { get; set; }

        [Input("slowOpSampleRate")]
        public Input<double>? SlowOpSampleRate { get; set; }

        [Input("slowOpThreshold")]
        public Input<int>? SlowOpThreshold { get; set; }

        public GetMdbMongodbClusterClusterConfigMongodOperationProfilingInputArgs()
        {
        }
        public static new GetMdbMongodbClusterClusterConfigMongodOperationProfilingInputArgs Empty => new GetMdbMongodbClusterClusterConfigMongodOperationProfilingInputArgs();
    }
}
