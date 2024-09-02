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
    public sealed class FunctionStorageMount
    {
        /// <summary>
        /// (Required) Name of the mounting bucket.
        /// </summary>
        public readonly string Bucket;
        /// <summary>
        /// (Required) Name of the mount point. The directory where the bucket is mounted will be accessible at the `/function/storage/&lt;mount_point&gt;` path.
        /// </summary>
        public readonly string MountPointName;
        /// <summary>
        /// Prefix within the bucket. If you leave this field empty, the entire bucket will be mounted.
        /// </summary>
        public readonly string? Prefix;
        /// <summary>
        /// Mount the bucket in read-only mode.
        /// </summary>
        public readonly bool? ReadOnly;

        [OutputConstructor]
        private FunctionStorageMount(
            string bucket,

            string mountPointName,

            string? prefix,

            bool? readOnly)
        {
            Bucket = bucket;
            MountPointName = mountPointName;
            Prefix = prefix;
            ReadOnly = readOnly;
        }
    }
}
