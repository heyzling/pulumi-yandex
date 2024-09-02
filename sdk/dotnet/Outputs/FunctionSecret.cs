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
    public sealed class FunctionSecret
    {
        /// <summary>
        /// (Required) Function's environment variable in which secret's value will be stored.
        /// </summary>
        public readonly string EnvironmentVariable;
        /// <summary>
        /// (Required) Secret's id.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// (Required) Secret's entries key which value will be stored in environment variable.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// (Required) Secret's version id.
        /// </summary>
        public readonly string VersionId;

        [OutputConstructor]
        private FunctionSecret(
            string environmentVariable,

            string id,

            string key,

            string versionId)
        {
            EnvironmentVariable = environmentVariable;
            Id = id;
            Key = key;
            VersionId = versionId;
        }
    }
}
