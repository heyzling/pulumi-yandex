// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsYdsSourceParserTskvParserDataSchemaFieldsArgs : global::Pulumi.ResourceArgs
    {
        [Input("fields")]
        private InputList<Inputs.DatatransferEndpointSettingsYdsSourceParserTskvParserDataSchemaFieldsFieldArgs>? _fields;

        /// <summary>
        /// Description of the data schema in the array of `fields` structure (documented below).
        /// </summary>
        public InputList<Inputs.DatatransferEndpointSettingsYdsSourceParserTskvParserDataSchemaFieldsFieldArgs> Fields
        {
            get => _fields ?? (_fields = new InputList<Inputs.DatatransferEndpointSettingsYdsSourceParserTskvParserDataSchemaFieldsFieldArgs>());
            set => _fields = value;
        }

        public DatatransferEndpointSettingsYdsSourceParserTskvParserDataSchemaFieldsArgs()
        {
        }
        public static new DatatransferEndpointSettingsYdsSourceParserTskvParserDataSchemaFieldsArgs Empty => new DatatransferEndpointSettingsYdsSourceParserTskvParserDataSchemaFieldsArgs();
    }
}
