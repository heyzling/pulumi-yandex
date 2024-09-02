// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferTransferTransformationTransformerTableSplitterTransformerArgs : global::Pulumi.ResourceArgs
    {
        [Input("columns")]
        private InputList<string>? _columns;

        /// <summary>
        /// List of strings that specify the columns in the tables to be partitioned.
        /// </summary>
        public InputList<string> Columns
        {
            get => _columns ?? (_columns = new InputList<string>());
            set => _columns = value;
        }

        /// <summary>
        /// Specify the split string to be used for merging components in a new table name.
        /// </summary>
        [Input("splitter")]
        public Input<string>? Splitter { get; set; }

        /// <summary>
        /// Table filter (see block documentation below).
        /// </summary>
        [Input("tables")]
        public Input<Inputs.DatatransferTransferTransformationTransformerTableSplitterTransformerTablesArgs>? Tables { get; set; }

        public DatatransferTransferTransformationTransformerTableSplitterTransformerArgs()
        {
        }
        public static new DatatransferTransferTransformationTransformerTableSplitterTransformerArgs Empty => new DatatransferTransferTransformationTransformerTableSplitterTransformerArgs();
    }
}