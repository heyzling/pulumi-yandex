// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class StorageBucketLifecycleRuleNoncurrentVersionTransitionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the number of days noncurrent object versions transition.
        /// </summary>
        [Input("days")]
        public Input<int>? Days { get; set; }

        /// <summary>
        /// Specifies the storage class to which you want the noncurrent object versions to transition. Supported values: [`STANDARD_IA`, `COLD`, `ICE`].
        /// </summary>
        [Input("storageClass", required: true)]
        public Input<string> StorageClass { get; set; } = null!;

        public StorageBucketLifecycleRuleNoncurrentVersionTransitionGetArgs()
        {
        }
        public static new StorageBucketLifecycleRuleNoncurrentVersionTransitionGetArgs Empty => new StorageBucketLifecycleRuleNoncurrentVersionTransitionGetArgs();
    }
}
