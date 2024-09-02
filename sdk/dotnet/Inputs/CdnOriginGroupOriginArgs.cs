// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class CdnOriginGroupOriginArgs : global::Pulumi.ResourceArgs
    {
        [Input("backup")]
        public Input<bool>? Backup { get; set; }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("originGroupId")]
        public Input<int>? OriginGroupId { get; set; }

        [Input("source", required: true)]
        public Input<string> Source { get; set; } = null!;

        public CdnOriginGroupOriginArgs()
        {
        }
        public static new CdnOriginGroupOriginArgs Empty => new CdnOriginGroupOriginArgs();
    }
}