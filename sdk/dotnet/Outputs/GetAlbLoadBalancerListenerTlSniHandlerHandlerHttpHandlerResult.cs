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
    public sealed class GetAlbLoadBalancerListenerTlSniHandlerHandlerHttpHandlerResult
    {
        public readonly bool? AllowHttp10;
        public readonly ImmutableArray<Outputs.GetAlbLoadBalancerListenerTlSniHandlerHandlerHttpHandlerHttp2OptionResult> Http2Options;
        public readonly string HttpRouterId;
        public readonly bool RewriteRequestId;

        [OutputConstructor]
        private GetAlbLoadBalancerListenerTlSniHandlerHandlerHttpHandlerResult(
            bool? allowHttp10,

            ImmutableArray<Outputs.GetAlbLoadBalancerListenerTlSniHandlerHandlerHttpHandlerHttp2OptionResult> http2Options,

            string httpRouterId,

            bool rewriteRequestId)
        {
            AllowHttp10 = allowHttp10;
            Http2Options = http2Options;
            HttpRouterId = httpRouterId;
            RewriteRequestId = rewriteRequestId;
        }
    }
}
