// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetComputeInstanceLocalDiskInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("deviceName", required: true)]
        public Input<string> DeviceName { get; set; } = null!;

        [Input("sizeBytes", required: true)]
        public Input<int> SizeBytes { get; set; } = null!;

        public GetComputeInstanceLocalDiskInputArgs()
        {
        }
        public static new GetComputeInstanceLocalDiskInputArgs Empty => new GetComputeInstanceLocalDiskInputArgs();
    }
}
