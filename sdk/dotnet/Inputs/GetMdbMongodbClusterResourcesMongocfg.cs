// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterResourcesMongocfgArgs : global::Pulumi.InvokeArgs
    {
        [Input("diskSize")]
        public int? DiskSize { get; set; }

        [Input("diskTypeId")]
        public string? DiskTypeId { get; set; }

        [Input("resourcePresetId")]
        public string? ResourcePresetId { get; set; }

        public GetMdbMongodbClusterResourcesMongocfgArgs()
        {
        }
        public static new GetMdbMongodbClusterResourcesMongocfgArgs Empty => new GetMdbMongodbClusterResourcesMongocfgArgs();
    }
}