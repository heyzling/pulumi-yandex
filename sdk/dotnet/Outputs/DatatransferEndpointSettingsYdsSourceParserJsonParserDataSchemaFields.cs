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
    public sealed class DatatransferEndpointSettingsYdsSourceParserJsonParserDataSchemaFields
    {
        /// <summary>
        /// Description of the data schema in the array of `fields` structure (documented below).
        /// </summary>
        public readonly ImmutableArray<Outputs.DatatransferEndpointSettingsYdsSourceParserJsonParserDataSchemaFieldsField> Fields;

        [OutputConstructor]
        private DatatransferEndpointSettingsYdsSourceParserJsonParserDataSchemaFields(ImmutableArray<Outputs.DatatransferEndpointSettingsYdsSourceParserJsonParserDataSchemaFieldsField> fields)
        {
            Fields = fields;
        }
    }
}
