// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferTransferRuntimeGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// YC Runtime parameters for the transfer.
        /// </summary>
        [Input("ycRuntime")]
        public Input<Inputs.DatatransferTransferRuntimeYcRuntimeGetArgs>? YcRuntime { get; set; }

        public DatatransferTransferRuntimeGetArgs()
        {
        }
        public static new DatatransferTransferRuntimeGetArgs Empty => new DatatransferTransferRuntimeGetArgs();
    }
}