// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterClickhouseInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("config", required: true)]
        public Input<Inputs.GetMdbClickhouseClusterClickhouseConfigInputArgs> Config { get; set; } = null!;

        [Input("resources", required: true)]
        public Input<Inputs.GetMdbClickhouseClusterClickhouseResourcesInputArgs> Resources { get; set; } = null!;

        public GetMdbClickhouseClusterClickhouseInputArgs()
        {
        }
        public static new GetMdbClickhouseClusterClickhouseInputArgs Empty => new GetMdbClickhouseClusterClickhouseInputArgs();
    }
}