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
    public sealed class GetFunctionStorageMountResult
    {
        public readonly string Bucket;
        public readonly string MountPointName;
        public readonly string? Prefix;
        public readonly bool? ReadOnly;

        [OutputConstructor]
        private GetFunctionStorageMountResult(
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