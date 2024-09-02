// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbMongodbClusterClusterConfigMongodSecurityGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enables the encryption for the WiredTiger storage engine. Can be either true or false.
        /// For more information see [security.enableEncryption](https://www.mongodb.com/docs/manual/reference/configuration-options/#mongodb-setting-security.enableEncryption)
        /// description in the official documentation. Available only in enterprise edition.
        /// </summary>
        [Input("enableEncryption")]
        public Input<bool>? EnableEncryption { get; set; }

        /// <summary>
        /// Configuration of the third party key management appliance via the Key Management Interoperability Protocol (KMIP)
        /// (see [Encryption tutorial](https://www.mongodb.com/docs/rapid/tutorial/configure-encryption) ). Requires `enable_encryption` to be true.
        /// The structure is documented below. Available only in enterprise edition.
        /// </summary>
        [Input("kmip")]
        public Input<Inputs.MdbMongodbClusterClusterConfigMongodSecurityKmipGetArgs>? Kmip { get; set; }

        public MdbMongodbClusterClusterConfigMongodSecurityGetArgs()
        {
        }
        public static new MdbMongodbClusterClusterConfigMongodSecurityGetArgs Empty => new MdbMongodbClusterClusterConfigMongodSecurityGetArgs();
    }
}