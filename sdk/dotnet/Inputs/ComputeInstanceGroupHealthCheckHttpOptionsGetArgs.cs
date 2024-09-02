// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupHealthCheckHttpOptionsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The URL path used for health check requests.
        /// </summary>
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        /// <summary>
        /// The port used for HTTP health checks.
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        public ComputeInstanceGroupHealthCheckHttpOptionsGetArgs()
        {
        }
        public static new ComputeInstanceGroupHealthCheckHttpOptionsGetArgs Empty => new ComputeInstanceGroupHealthCheckHttpOptionsGetArgs();
    }
}
