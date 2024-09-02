// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ServerlessContainerSecretGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Required) Container's environment variable in which secret's value will be stored.
        /// </summary>
        [Input("environmentVariable", required: true)]
        public Input<string> EnvironmentVariable { get; set; } = null!;

        /// <summary>
        /// (Required) Secret's id.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// (Required) Secret's entries key which value will be stored in environment variable.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// (Required) Secret's version id.
        /// </summary>
        [Input("versionId", required: true)]
        public Input<string> VersionId { get; set; } = null!;

        public ServerlessContainerSecretGetArgs()
        {
        }
        public static new ServerlessContainerSecretGetArgs Empty => new ServerlessContainerSecretGetArgs();
    }
}
