// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterClickhouseConfigCompressionInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("level")]
        public Input<int>? Level { get; set; }

        [Input("method")]
        public Input<string>? Method { get; set; }

        [Input("minPartSize")]
        public Input<int>? MinPartSize { get; set; }

        [Input("minPartSizeRatio")]
        public Input<double>? MinPartSizeRatio { get; set; }

        public GetMdbClickhouseClusterClickhouseConfigCompressionInputArgs()
        {
        }
        public static new GetMdbClickhouseClusterClickhouseConfigCompressionInputArgs Empty => new GetMdbClickhouseClusterClickhouseConfigCompressionInputArgs();
    }
}