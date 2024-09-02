// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class FunctionPackageArgs : global::Pulumi.ResourceArgs
    {
        [Input("bucketName", required: true)]
        public Input<string> BucketName { get; set; } = null!;

        [Input("objectName", required: true)]
        public Input<string> ObjectName { get; set; } = null!;

        [Input("sha256")]
        public Input<string>? Sha256 { get; set; }

        public FunctionPackageArgs()
        {
        }
        public static new FunctionPackageArgs Empty => new FunctionPackageArgs();
    }
}
