// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbGreenplumClusterCloudStorageArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to use cloud storage or not.
        /// </summary>
        [Input("enable")]
        public Input<bool>? Enable { get; set; }

        public MdbGreenplumClusterCloudStorageArgs()
        {
        }
        public static new MdbGreenplumClusterCloudStorageArgs Empty => new MdbGreenplumClusterCloudStorageArgs();
    }
}