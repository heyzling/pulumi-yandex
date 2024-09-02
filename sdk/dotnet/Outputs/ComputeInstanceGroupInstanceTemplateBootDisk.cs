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
    public sealed class ComputeInstanceGroupInstanceTemplateBootDisk
    {
        /// <summary>
        /// This value can be used to reference the device under `/dev/disk/by-id/`.
        /// </summary>
        public readonly string? DeviceName;
        /// <summary>
        /// ID of the existing disk. To set use variables.
        /// </summary>
        public readonly string? DiskId;
        /// <summary>
        /// Parameters for creating a disk alongside the instance. The structure is documented below.
        /// </summary>
        public readonly Outputs.ComputeInstanceGroupInstanceTemplateBootDiskInitializeParams? InitializeParams;
        /// <summary>
        /// The access mode to the disk resource. By default a disk is attached in `READ_WRITE` mode.
        /// </summary>
        public readonly string? Mode;
        /// <summary>
        /// When set can be later used to change DiskSpec of actual disk.
        /// </summary>
        public readonly string? Name;

        [OutputConstructor]
        private ComputeInstanceGroupInstanceTemplateBootDisk(
            string? deviceName,

            string? diskId,

            Outputs.ComputeInstanceGroupInstanceTemplateBootDiskInitializeParams? initializeParams,

            string? mode,

            string? name)
        {
            DeviceName = deviceName;
            DiskId = diskId;
            InitializeParams = initializeParams;
            Mode = mode;
            Name = name;
        }
    }
}
