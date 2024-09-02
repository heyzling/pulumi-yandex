// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceBootDiskArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Defines whether the disk will be auto-deleted when the instance
        /// is deleted. The default value is `True`.
        /// </summary>
        [Input("autoDelete")]
        public Input<bool>? AutoDelete { get; set; }

        /// <summary>
        /// Name that can be used to access an attached disk.
        /// </summary>
        [Input("deviceName")]
        public Input<string>? DeviceName { get; set; }

        /// <summary>
        /// The ID of the existing disk (such as those managed by
        /// `yandex.ComputeDisk`) to attach as a boot disk.
        /// </summary>
        [Input("diskId")]
        public Input<string>? DiskId { get; set; }

        /// <summary>
        /// Parameters for a new disk that will be created
        /// alongside the new instance. Either `initialize_params` or `disk_id` must be set. The structure is documented below.
        /// 
        /// &gt; **NOTE:** Either `initialize_params` or `disk_id` must be specified.
        /// </summary>
        [Input("initializeParams")]
        public Input<Inputs.ComputeInstanceBootDiskInitializeParamsArgs>? InitializeParams { get; set; }

        /// <summary>
        /// Type of access to the disk resource. By default, a disk is attached in `READ_WRITE` mode.
        /// </summary>
        [Input("mode")]
        public Input<string>? Mode { get; set; }

        public ComputeInstanceBootDiskArgs()
        {
        }
        public static new ComputeInstanceBootDiskArgs Empty => new ComputeInstanceBootDiskArgs();
    }
}