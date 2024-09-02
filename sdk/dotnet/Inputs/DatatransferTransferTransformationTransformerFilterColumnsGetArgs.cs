// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferTransferTransformationTransformerFilterColumnsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// List of the columns to transfer to the target tables using lists of included and excluded columns (see block documentation below).
        /// </summary>
        [Input("columns")]
        public Input<Inputs.DatatransferTransferTransformationTransformerFilterColumnsColumnsGetArgs>? Columns { get; set; }

        /// <summary>
        /// Table filter (see block documentation below).
        /// </summary>
        [Input("tables")]
        public Input<Inputs.DatatransferTransferTransformationTransformerFilterColumnsTablesGetArgs>? Tables { get; set; }

        public DatatransferTransferTransformationTransformerFilterColumnsGetArgs()
        {
        }
        public static new DatatransferTransferTransformationTransformerFilterColumnsGetArgs Empty => new DatatransferTransferTransformationTransformerFilterColumnsGetArgs();
    }
}