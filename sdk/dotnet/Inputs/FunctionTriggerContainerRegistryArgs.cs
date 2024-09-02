// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class FunctionTriggerContainerRegistryArgs : global::Pulumi.ResourceArgs
    {
        [Input("batchCutoff", required: true)]
        public Input<string> BatchCutoff { get; set; } = null!;

        [Input("batchSize")]
        public Input<string>? BatchSize { get; set; }

        [Input("createImage")]
        public Input<bool>? CreateImage { get; set; }

        [Input("createImageTag")]
        public Input<bool>? CreateImageTag { get; set; }

        [Input("deleteImage")]
        public Input<bool>? DeleteImage { get; set; }

        [Input("deleteImageTag")]
        public Input<bool>? DeleteImageTag { get; set; }

        [Input("imageName")]
        public Input<string>? ImageName { get; set; }

        [Input("registryId", required: true)]
        public Input<string> RegistryId { get; set; } = null!;

        [Input("tag")]
        public Input<string>? Tag { get; set; }

        public FunctionTriggerContainerRegistryArgs()
        {
        }
        public static new FunctionTriggerContainerRegistryArgs Empty => new FunctionTriggerContainerRegistryArgs();
    }
}
