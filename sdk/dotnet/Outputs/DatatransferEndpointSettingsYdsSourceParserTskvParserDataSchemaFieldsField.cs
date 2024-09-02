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
    public sealed class DatatransferEndpointSettingsYdsSourceParserTskvParserDataSchemaFieldsField
    {
        /// <summary>
        /// Mark field as Primary Key.
        /// </summary>
        public readonly bool? Key;
        /// <summary>
        /// Field name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Path to the field.
        /// </summary>
        public readonly string? Path;
        /// <summary>
        /// Mark field as required.
        /// </summary>
        public readonly bool? Required;
        /// <summary>
        /// Field type, one of: `INT64`, `INT32`, `INT16`, `INT8`, `UINT64`, `UINT32`, `UINT16`, `UINT8`, `DOUBLE`, `BOOLEAN`, `STRING`, `UTF8`, `ANY`, `DATETIME`.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private DatatransferEndpointSettingsYdsSourceParserTskvParserDataSchemaFieldsField(
            bool? key,

            string? name,

            string? path,

            bool? required,

            string? type)
        {
            Key = key;
            Name = name;
            Path = path;
            Required = required;
            Type = type;
        }
    }
}
