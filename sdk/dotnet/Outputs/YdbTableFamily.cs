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
    public sealed class YdbTableFamily
    {
        /// <summary>
        /// Data codec (acceptable values: off, lz4).
        /// </summary>
        public readonly string Compression;
        /// <summary>
        /// Type of storage device for column data in this group (acceptable values: ssd, rot (from HDD spindle rotation)).
        /// </summary>
        public readonly string Data;
        /// <summary>
        /// Column family name
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private YdbTableFamily(
            string compression,

            string data,

            string name)
        {
            Compression = compression;
            Data = data;
            Name = name;
        }
    }
}
