// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalArgs : global::Pulumi.ResourceArgs
    {
        [Input("any")]
        public Input<bool>? Any { get; set; }

        [Input("header")]
        public Input<Inputs.AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalHeaderArgs>? Header { get; set; }

        [Input("remoteIp")]
        public Input<string>? RemoteIp { get; set; }

        public AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalArgs()
        {
        }
        public static new AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalArgs Empty => new AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalArgs();
    }
}
