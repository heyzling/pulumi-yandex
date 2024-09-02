// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsKafkaSourceAuthSaslGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("mechanism")]
        public Input<string>? Mechanism { get; set; }

        /// <summary>
        /// Password for the database access. This is a block with a single field named `raw` which should contain the password.
        /// </summary>
        [Input("password")]
        public Input<Inputs.DatatransferEndpointSettingsKafkaSourceAuthSaslPasswordGetArgs>? Password { get; set; }

        /// <summary>
        /// User for database access.
        /// </summary>
        [Input("user")]
        public Input<string>? User { get; set; }

        public DatatransferEndpointSettingsKafkaSourceAuthSaslGetArgs()
        {
        }
        public static new DatatransferEndpointSettingsKafkaSourceAuthSaslGetArgs Empty => new DatatransferEndpointSettingsKafkaSourceAuthSaslGetArgs();
    }
}
