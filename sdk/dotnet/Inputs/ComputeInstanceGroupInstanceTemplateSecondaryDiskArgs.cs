// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupInstanceTemplateSecondaryDiskArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This value can be used to reference the device under `/dev/disk/by-id/`.
        /// </summary>
        [Input("deviceName")]
        public Input<string>? DeviceName { get; set; }

        /// <summary>
        /// ID of the existing disk. To set use variables.
        /// </summary>
        [Input("diskId")]
        public Input<string>? DiskId { get; set; }

        /// <summary>
        /// Parameters used for creating a disk alongside the instance. The structure is documented below.
        /// </summary>
        [Input("initializeParams")]
        public Input<Inputs.ComputeInstanceGroupInstanceTemplateSecondaryDiskInitializeParamsArgs>? InitializeParams { get; set; }

        /// <summary>
        /// The access mode to the disk resource. By default a disk is attached in `READ_WRITE` mode.
        /// </summary>
        [Input("mode")]
        public Input<string>? Mode { get; set; }

        /// <summary>
        /// When set can be later used to change DiskSpec of actual disk.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ComputeInstanceGroupInstanceTemplateSecondaryDiskArgs()
        {
        }
        public static new ComputeInstanceGroupInstanceTemplateSecondaryDiskArgs Empty => new ComputeInstanceGroupInstanceTemplateSecondaryDiskArgs();
    }
}
