// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferTransferTransformationTransformerMaskFieldArgs : global::Pulumi.ResourceArgs
    {
        [Input("columns")]
        private InputList<string>? _columns;

        /// <summary>
        /// List of strings that specify the name of the column for data masking (a regular expression).
        /// </summary>
        public InputList<string> Columns
        {
            get => _columns ?? (_columns = new InputList<string>());
            set => _columns = value;
        }

        /// <summary>
        /// Mask function.
        /// </summary>
        [Input("function")]
        public Input<Inputs.DatatransferTransferTransformationTransformerMaskFieldFunctionArgs>? Function { get; set; }

        /// <summary>
        /// Table filter.
        /// </summary>
        [Input("tables")]
        public Input<Inputs.DatatransferTransferTransformationTransformerMaskFieldTablesArgs>? Tables { get; set; }

        public DatatransferTransferTransformationTransformerMaskFieldArgs()
        {
        }
        public static new DatatransferTransferTransformationTransformerMaskFieldArgs Empty => new DatatransferTransferTransformationTransformerMaskFieldArgs();
    }
}
