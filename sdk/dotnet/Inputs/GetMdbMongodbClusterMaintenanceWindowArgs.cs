// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterMaintenanceWindowInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("day")]
        public Input<string>? Day { get; set; }

        [Input("hour")]
        public Input<int>? Hour { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public GetMdbMongodbClusterMaintenanceWindowInputArgs()
        {
        }
        public static new GetMdbMongodbClusterMaintenanceWindowInputArgs Empty => new GetMdbMongodbClusterMaintenanceWindowInputArgs();
    }
}
