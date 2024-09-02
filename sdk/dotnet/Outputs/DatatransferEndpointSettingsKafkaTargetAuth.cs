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
    public sealed class DatatransferEndpointSettingsKafkaTargetAuth
    {
        /// <summary>
        /// Connection without authentication data.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsKafkaTargetAuthNoAuth? NoAuth;
        /// <summary>
        /// Authentication using sasl.
        /// </summary>
        public readonly Outputs.DatatransferEndpointSettingsKafkaTargetAuthSasl? Sasl;

        [OutputConstructor]
        private DatatransferEndpointSettingsKafkaTargetAuth(
            Outputs.DatatransferEndpointSettingsKafkaTargetAuthNoAuth? noAuth,

            Outputs.DatatransferEndpointSettingsKafkaTargetAuthSasl? sasl)
        {
            NoAuth = noAuth;
            Sasl = sasl;
        }
    }
}
