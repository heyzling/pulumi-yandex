// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterClickhouseConfigQueryCacheArgs : global::Pulumi.InvokeArgs
    {
        [Input("maxEntries", required: true)]
        public int MaxEntries { get; set; }

        [Input("maxEntrySizeInBytes", required: true)]
        public int MaxEntrySizeInBytes { get; set; }

        [Input("maxEntrySizeInRows", required: true)]
        public int MaxEntrySizeInRows { get; set; }

        [Input("maxSizeInBytes", required: true)]
        public int MaxSizeInBytes { get; set; }

        public GetMdbClickhouseClusterClickhouseConfigQueryCacheArgs()
        {
        }
        public static new GetMdbClickhouseClusterClickhouseConfigQueryCacheArgs Empty => new GetMdbClickhouseClusterClickhouseConfigQueryCacheArgs();
    }
}
