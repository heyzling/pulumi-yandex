// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesNodeGroupScalePolicyFixedScaleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of instances in the node group.
        /// </summary>
        [Input("size")]
        public Input<int>? Size { get; set; }

        public KubernetesNodeGroupScalePolicyFixedScaleArgs()
        {
        }
        public static new KubernetesNodeGroupScalePolicyFixedScaleArgs Empty => new KubernetesNodeGroupScalePolicyFixedScaleArgs();
    }
}