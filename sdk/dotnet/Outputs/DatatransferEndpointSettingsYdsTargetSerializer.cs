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
    public sealed class DatatransferEndpointSettingsYdsTargetSerializer
    {
        /// <summary>
        /// Empty block. Select data serialization format automatically.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsYdsTargetSerializerSerializerAuto? SerializerAuto;
        /// <summary>
        /// Serialize data in json format. The structure is documented below.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsYdsTargetSerializerSerializerDebezium? SerializerDebezium;
        /// <summary>
        /// Empty block. Serialize data in json format.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsYdsTargetSerializerSerializerJson? SerializerJson;

        [OutputConstructor]
        private DatatransferEndpointSettingsYdsTargetSerializer(
            Outputs.DatatransferEndpointSettingsYdsTargetSerializerSerializerAuto? serializerAuto,

            Outputs.DatatransferEndpointSettingsYdsTargetSerializerSerializerDebezium? serializerDebezium,

            Outputs.DatatransferEndpointSettingsYdsTargetSerializerSerializerJson? serializerJson)
        {
            SerializerAuto = serializerAuto;
            SerializerDebezium = serializerDebezium;
            SerializerJson = serializerJson;
        }
    }
}
