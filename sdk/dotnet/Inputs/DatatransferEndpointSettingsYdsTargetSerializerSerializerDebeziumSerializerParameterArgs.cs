// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsYdsTargetSerializerSerializerDebeziumSerializerParameterArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Mark field as Primary Key.
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        public DatatransferEndpointSettingsYdsTargetSerializerSerializerDebeziumSerializerParameterArgs()
        {
        }
        public static new DatatransferEndpointSettingsYdsTargetSerializerSerializerDebeziumSerializerParameterArgs Empty => new DatatransferEndpointSettingsYdsTargetSerializerSerializerDebeziumSerializerParameterArgs();
    }
}
