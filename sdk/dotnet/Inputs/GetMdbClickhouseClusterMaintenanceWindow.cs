// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterMaintenanceWindowArgs : global::Pulumi.InvokeArgs
    {
        [Input("day")]
        public string? Day { get; set; }

        [Input("hour")]
        public int? Hour { get; set; }

        [Input("type")]
        public string? Type { get; set; }

        public GetMdbClickhouseClusterMaintenanceWindowArgs()
        {
        }
        public static new GetMdbClickhouseClusterMaintenanceWindowArgs Empty => new GetMdbClickhouseClusterMaintenanceWindowArgs();
    }
}
