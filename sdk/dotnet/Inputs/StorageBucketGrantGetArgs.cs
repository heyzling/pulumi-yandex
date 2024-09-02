// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class StorageBucketGrantGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Canonical user id to grant for. Used only when type is `CanonicalUser`.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("permissions", required: true)]
        private InputList<string>? _permissions;

        /// <summary>
        /// List of permissions to apply for grantee. Valid values are `READ`, `WRITE`, `FULL_CONTROL`.
        /// </summary>
        public InputList<string> Permissions
        {
            get => _permissions ?? (_permissions = new InputList<string>());
            set => _permissions = value;
        }

        /// <summary>
        /// Type of grantee to apply for. Valid values are `CanonicalUser` and `Group`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// Uri address to grant for. Used only when type is Group.
        /// 
        /// &gt; **Note:** To manage `grant` argument, service account with `storage.admin` role should be used.
        /// </summary>
        [Input("uri")]
        public Input<string>? Uri { get; set; }

        public StorageBucketGrantGetArgs()
        {
        }
        public static new StorageBucketGrantGetArgs Empty => new StorageBucketGrantGetArgs();
    }
}
