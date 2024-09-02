// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbVirtualHostRouteGrpcRouteGrpcRouteActionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If set, will automatically rewrite host.
        /// 
        /// &gt; **NOTE:** Only one type of host rewrite specifiers `host_rewrite` or `auto_host_rewrite` should be
        /// specified.
        /// </summary>
        [Input("autoHostRewrite")]
        public Input<bool>? AutoHostRewrite { get; set; }

        /// <summary>
        /// Backend group to route requests.
        /// </summary>
        [Input("backendGroupId", required: true)]
        public Input<string> BackendGroupId { get; set; } = null!;

        /// <summary>
        /// Host rewrite specifier.
        /// </summary>
        [Input("hostRewrite")]
        public Input<string>? HostRewrite { get; set; }

        /// <summary>
        /// Specifies the idle timeout (time without any data transfer for the active request) for the
        /// route. It is useful for streaming scenarios - one should set idle_timeout to something meaningful and max_timeout
        /// to the maximum time the stream is allowed to be alive. If not specified, there is no
        /// per-route idle timeout.
        /// </summary>
        [Input("idleTimeout")]
        public Input<string>? IdleTimeout { get; set; }

        /// <summary>
        /// Lower timeout may be specified by the client (using grpc-timeout header). If not set, default is 
        /// 60 seconds.
        /// </summary>
        [Input("maxTimeout")]
        public Input<string>? MaxTimeout { get; set; }

        public AlbVirtualHostRouteGrpcRouteGrpcRouteActionGetArgs()
        {
        }
        public static new AlbVirtualHostRouteGrpcRouteGrpcRouteActionGetArgs Empty => new AlbVirtualHostRouteGrpcRouteGrpcRouteActionGetArgs();
    }
}
