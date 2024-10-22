// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbGreenplumClusterPxfConfigInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("connectionTimeout")]
        public Input<int>? ConnectionTimeout { get; set; }

        [Input("maxThreads")]
        public Input<int>? MaxThreads { get; set; }

        [Input("poolAllowCoreThreadTimeout")]
        public Input<bool>? PoolAllowCoreThreadTimeout { get; set; }

        [Input("poolCoreSize")]
        public Input<int>? PoolCoreSize { get; set; }

        [Input("poolMaxSize")]
        public Input<int>? PoolMaxSize { get; set; }

        [Input("poolQueueCapacity")]
        public Input<int>? PoolQueueCapacity { get; set; }

        [Input("uploadTimeout")]
        public Input<int>? UploadTimeout { get; set; }

        [Input("xms")]
        public Input<int>? Xms { get; set; }

        [Input("xmx")]
        public Input<int>? Xmx { get; set; }

        public GetMdbGreenplumClusterPxfConfigInputArgs()
        {
        }
        public static new GetMdbGreenplumClusterPxfConfigInputArgs Empty => new GetMdbGreenplumClusterPxfConfigInputArgs();
    }
}
