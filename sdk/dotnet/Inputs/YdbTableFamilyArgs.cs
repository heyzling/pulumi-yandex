// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class YdbTableFamilyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Data codec (acceptable values: off, lz4).
        /// </summary>
        [Input("compression", required: true)]
        public Input<string> Compression { get; set; } = null!;

        /// <summary>
        /// Type of storage device for column data in this group (acceptable values: ssd, rot (from HDD spindle rotation)).
        /// </summary>
        [Input("data", required: true)]
        public Input<string> Data { get; set; } = null!;

        /// <summary>
        /// Column family name
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public YdbTableFamilyArgs()
        {
        }
        public static new YdbTableFamilyArgs Empty => new YdbTableFamilyArgs();
    }
}
