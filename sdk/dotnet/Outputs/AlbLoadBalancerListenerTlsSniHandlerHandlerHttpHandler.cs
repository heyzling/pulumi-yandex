// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandler
    {
        /// <summary>
        /// If set, will enable only HTTP1 protocol with HTTP1.0 support.
        /// 
        /// &gt; **NOTE:** Only one type of protocol settings `http2_options` or `allow_http10` should be specified.
        /// </summary>
        public readonly bool? AllowHttp10;
        /// <summary>
        /// If set, will enable HTTP2 protocol for the handler. The structure is documented below.
        /// </summary>
        public readonly Outputs.AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandlerHttp2Options? Http2Options;
        /// <summary>
        /// HTTP router id.
        /// </summary>
        public readonly string? HttpRouterId;
        /// <summary>
        /// When unset, will preserve the incoming x-request-id header, otherwise would rewrite it with a new value.
        /// </summary>
        public readonly bool? RewriteRequestId;

        [OutputConstructor]
        private AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandler(
            bool? allowHttp10,

            Outputs.AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandlerHttp2Options? http2Options,

            string? httpRouterId,

            bool? rewriteRequestId)
        {
            AllowHttp10 = allowHttp10;
            Http2Options = http2Options;
            HttpRouterId = httpRouterId;
            RewriteRequestId = rewriteRequestId;
        }
    }
}
