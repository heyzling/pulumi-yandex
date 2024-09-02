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
    public sealed class DatatransferTransferTransformationTransformer
    {
        /// <summary>
        /// Convert column values to strings.
        /// </summary>
        public readonly Outputs.DatatransferTransferTransformationTransformerConvertToString? ConvertToString;
        /// <summary>
        /// Set up a list of table columns to transfer.
        /// </summary>
        public readonly Outputs.DatatransferTransferTransformationTransformerFilterColumns? FilterColumns;
        /// <summary>
        /// This filter only applies to transfers with queues (Apache Kafka®) as a data source. When running a transfer, only the strings meeting the specified criteria remain in a changefeed.
        /// </summary>
        public readonly Outputs.DatatransferTransferTransformationTransformerFilterRows? FilterRows;
        /// <summary>
        /// Mask field transformer allows you to hash data.
        /// </summary>
        public readonly Outputs.DatatransferTransferTransformationTransformerMaskField? MaskField;
        /// <summary>
        /// Set rules for renaming tables by specifying the current names of the tables in the source and new names for these tables in the target.
        /// </summary>
        public readonly Outputs.DatatransferTransferTransformationTransformerRenameTables? RenameTables;
        /// <summary>
        /// Override primary keys.
        /// </summary>
        public readonly Outputs.DatatransferTransferTransformationTransformerReplacePrimaryKey? ReplacePrimaryKey;
        /// <summary>
        /// Set the number of shards for particular tables and a list of columns whose values will be used for calculating a hash to determine a shard.
        /// </summary>
        public readonly Outputs.DatatransferTransferTransformationTransformerSharderTransformer? SharderTransformer;
        /// <summary>
        /// Splits the X table into multiple tables (X_1, X_2, ..., X_n) based on data.
        /// </summary>
        public readonly Outputs.DatatransferTransferTransformationTransformerTableSplitterTransformer? TableSplitterTransformer;

        [OutputConstructor]
        private DatatransferTransferTransformationTransformer(
            Outputs.DatatransferTransferTransformationTransformerConvertToString? convertToString,

            Outputs.DatatransferTransferTransformationTransformerFilterColumns? filterColumns,

            Outputs.DatatransferTransferTransformationTransformerFilterRows? filterRows,

            Outputs.DatatransferTransferTransformationTransformerMaskField? maskField,

            Outputs.DatatransferTransferTransformationTransformerRenameTables? renameTables,

            Outputs.DatatransferTransferTransformationTransformerReplacePrimaryKey? replacePrimaryKey,

            Outputs.DatatransferTransferTransformationTransformerSharderTransformer? sharderTransformer,

            Outputs.DatatransferTransferTransformationTransformerTableSplitterTransformer? tableSplitterTransformer)
        {
            ConvertToString = convertToString;
            FilterColumns = filterColumns;
            FilterRows = filterRows;
            MaskField = maskField;
            RenameTables = renameTables;
            ReplacePrimaryKey = replacePrimaryKey;
            SharderTransformer = sharderTransformer;
            TableSplitterTransformer = tableSplitterTransformer;
        }
    }
}