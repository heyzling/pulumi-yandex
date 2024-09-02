// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbVirtualHostRouteGrpcRouteGrpcMatchFqmnArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Match exactly.
        /// </summary>
        [Input("exact")]
        public Input<string>? Exact { get; set; }

        /// <summary>
        /// Match prefix.
        /// </summary>
        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        /// <summary>
        /// Match regex.
        /// 
        /// &gt; **NOTE:** Exactly one type of string matches `exact`, `prefix` or `regex` should be
        /// specified.
        /// </summary>
        [Input("regex")]
        public Input<string>? Regex { get; set; }

        public AlbVirtualHostRouteGrpcRouteGrpcMatchFqmnArgs()
        {
        }
        public static new AlbVirtualHostRouteGrpcRouteGrpcMatchFqmnArgs Empty => new AlbVirtualHostRouteGrpcRouteGrpcMatchFqmnArgs();
    }
}
