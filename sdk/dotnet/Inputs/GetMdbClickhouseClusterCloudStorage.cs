// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterCloudStorageArgs : global::Pulumi.InvokeArgs
    {
        [Input("dataCacheEnabled", required: true)]
        public bool DataCacheEnabled { get; set; }

        [Input("dataCacheMaxSize", required: true)]
        public int DataCacheMaxSize { get; set; }

        [Input("enabled")]
        public bool? Enabled { get; set; }

        [Input("moveFactor", required: true)]
        public double MoveFactor { get; set; }

        [Input("preferNotToMerge", required: true)]
        public bool PreferNotToMerge { get; set; }

        public GetMdbClickhouseClusterCloudStorageArgs()
        {
        }
        public static new GetMdbClickhouseClusterCloudStorageArgs Empty => new GetMdbClickhouseClusterCloudStorageArgs();
    }
}
