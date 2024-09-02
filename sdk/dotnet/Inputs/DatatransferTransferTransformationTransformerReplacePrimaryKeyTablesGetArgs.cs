// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferTransferTransformationTransformerReplacePrimaryKeyTablesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("excludeTables")]
        private InputList<string>? _excludeTables;

        /// <summary>
        /// List of tables that will be excluded to transfer.
        /// </summary>
        public InputList<string> ExcludeTables
        {
            get => _excludeTables ?? (_excludeTables = new InputList<string>());
            set => _excludeTables = value;
        }

        [Input("includeTables")]
        private InputList<string>? _includeTables;

        /// <summary>
        /// List of tables that will be included to transfer.
        /// </summary>
        public InputList<string> IncludeTables
        {
            get => _includeTables ?? (_includeTables = new InputList<string>());
            set => _includeTables = value;
        }

        public DatatransferTransferTransformationTransformerReplacePrimaryKeyTablesGetArgs()
        {
        }
        public static new DatatransferTransferTransformationTransformerReplacePrimaryKeyTablesGetArgs Empty => new DatatransferTransferTransformationTransformerReplacePrimaryKeyTablesGetArgs();
    }
}
