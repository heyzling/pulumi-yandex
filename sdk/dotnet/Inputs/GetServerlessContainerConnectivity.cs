// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetServerlessContainerConnectivityArgs : global::Pulumi.InvokeArgs
    {
        [Input("networkId", required: true)]
        public string NetworkId { get; set; } = null!;

        public GetServerlessContainerConnectivityArgs()
        {
        }
        public static new GetServerlessContainerConnectivityArgs Empty => new GetServerlessContainerConnectivityArgs();
    }
}
