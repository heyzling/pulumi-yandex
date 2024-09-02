// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class StorageBucketLifecycleRuleNoncurrentVersionExpirationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the number of days noncurrent object versions expire.
        /// </summary>
        [Input("days")]
        public Input<int>? Days { get; set; }

        public StorageBucketLifecycleRuleNoncurrentVersionExpirationArgs()
        {
        }
        public static new StorageBucketLifecycleRuleNoncurrentVersionExpirationArgs Empty => new StorageBucketLifecycleRuleNoncurrentVersionExpirationArgs();
    }
}
