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
    public sealed class AlbLoadBalancerLogOptionsDiscardRule
    {
        public readonly int? DiscardPercent;
        /// <summary>
        /// list of grpc codes by name, e.g, _["NOT_FOUND", "RESOURCE_EXHAUSTED"]_
        /// </summary>
        public readonly ImmutableArray<string> GrpcCodes;
        /// <summary>
        /// list of http code intervals _1XX_-_5XX_ or _ALL_
        /// </summary>
        public readonly ImmutableArray<string> HttpCodeIntervals;
        /// <summary>
        /// list of http codes _100_-_599_
        /// </summary>
        public readonly ImmutableArray<int> HttpCodes;

        [OutputConstructor]
        private AlbLoadBalancerLogOptionsDiscardRule(
            int? discardPercent,

            ImmutableArray<string> grpcCodes,

            ImmutableArray<string> httpCodeIntervals,

            ImmutableArray<int> httpCodes)
        {
            DiscardPercent = discardPercent;
            GrpcCodes = grpcCodes;
            HttpCodeIntervals = httpCodeIntervals;
            HttpCodes = httpCodes;
        }
    }
}