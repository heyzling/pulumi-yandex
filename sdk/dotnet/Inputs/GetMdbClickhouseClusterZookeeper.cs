// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterZookeeperArgs : global::Pulumi.InvokeArgs
    {
        [Input("resources", required: true)]
        public Inputs.GetMdbClickhouseClusterZookeeperResourcesArgs Resources { get; set; } = null!;

        public GetMdbClickhouseClusterZookeeperArgs()
        {
        }
        public static new GetMdbClickhouseClusterZookeeperArgs Empty => new GetMdbClickhouseClusterZookeeperArgs();
    }
}
