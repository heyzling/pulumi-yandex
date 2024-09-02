// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesNodeGroupInstanceTemplateBootDiskGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The size of the disk in GB. Allowed minimal size: 64 GB.
        /// </summary>
        [Input("size")]
        public Input<int>? Size { get; set; }

        /// <summary>
        /// The disk type.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public KubernetesNodeGroupInstanceTemplateBootDiskGetArgs()
        {
        }
        public static new KubernetesNodeGroupInstanceTemplateBootDiskGetArgs Empty => new KubernetesNodeGroupInstanceTemplateBootDiskGetArgs();
    }
}
