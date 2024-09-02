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
    public sealed class GetComputeInstanceGroupInstanceTemplateSecondaryDiskInitializeParamResult
    {
        public readonly string Description;
        public readonly string ImageId;
        public readonly int Size;
        public readonly string SnapshotId;
        public readonly string Type;

        [OutputConstructor]
        private GetComputeInstanceGroupInstanceTemplateSecondaryDiskInitializeParamResult(
            string description,

            string imageId,

            int size,

            string snapshotId,

            string type)
        {
            Description = description;
            ImageId = imageId;
            Size = size;
            SnapshotId = snapshotId;
            Type = type;
        }
    }
}
