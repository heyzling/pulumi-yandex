// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetServerlessContainerStorageMountInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("bucket", required: true)]
        public Input<string> Bucket { get; set; } = null!;

        [Input("mountPointPath", required: true)]
        public Input<string> MountPointPath { get; set; } = null!;

        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        [Input("readOnly")]
        public Input<bool>? ReadOnly { get; set; }

        public GetServerlessContainerStorageMountInputArgs()
        {
        }
        public static new GetServerlessContainerStorageMountInputArgs Empty => new GetServerlessContainerStorageMountInputArgs();
    }
}