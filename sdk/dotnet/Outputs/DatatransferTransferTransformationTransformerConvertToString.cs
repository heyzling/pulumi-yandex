// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class DatatransferTransferTransformationTransformerConvertToString
    {
        /// <summary>
        /// List of the columns to transfer to the target tables using lists of included and excluded columns (see block documentation below).
        /// </summary>
        public readonly Outputs.DatatransferTransferTransformationTransformerConvertToStringColumns? Columns;
        /// <summary>
        /// Table filter (see block documentation below).
        /// </summary>
        public readonly Outputs.DatatransferTransferTransformationTransformerConvertToStringTables? Tables;

        [OutputConstructor]
        private DatatransferTransferTransformationTransformerConvertToString(
            Outputs.DatatransferTransferTransformationTransformerConvertToStringColumns? columns,

            Outputs.DatatransferTransferTransformationTransformerConvertToStringTables? tables)
        {
            Columns = columns;
            Tables = tables;
        }
    }
}
