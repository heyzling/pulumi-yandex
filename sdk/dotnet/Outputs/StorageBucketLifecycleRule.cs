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
    public sealed class StorageBucketLifecycleRule
    {
        /// <summary>
        /// Specifies the number of days after initiating a multipart upload when the multipart upload must be completed.
        /// </summary>
        public readonly int? AbortIncompleteMultipartUploadDays;
        /// <summary>
        /// Specifies lifecycle rule status.
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Specifies a period in the object's expire (documented below).
        /// </summary>
        public readonly Outputs.StorageBucketLifecycleRuleExpiration? Expiration;
        /// <summary>
        /// Filter block identifies one or more objects to which the rule applies. A Filter must have exactly one of Prefix, Tag, or And specified. The filter supports the following options:
        /// 
        /// - object_size_greater_than - (Optional) Minimum object size to which the rule applies.
        /// - object_size_less_than - (Optional) Maximum object size to which the rule applies.
        /// - prefix - (Optional) Object key prefix identifying one or more objects to which the rule applies.
        /// - tag - (Optional) A key and value pair for filtering objects. E.g.: key=key1, value=value1.
        /// - and - (Optional) A logical `and` operator applied to one or more filter parameters. It should be used when two or more of the above parameters are used. It supports the following parameters:
        /// 
        /// - object_size_greater_than - (Optional) Minimum object size to which the rule applies.
        /// - object_size_less_than - (Optional) Maximum object size to which the rule applies.
        /// - prefix - (Optional) Object key prefix identifying one or more objects to which the rule applies.
        /// - tags - (Optional) Key-value pairs for filtering objects. All of these tags must exist in the object's tags to apply the rule. E.g.: key1=value1, key2=value2
        /// </summary>
        public readonly Outputs.StorageBucketLifecycleRuleFilter? Filter;
        /// <summary>
        /// Unique identifier for the rule. Must be less than or equal to 255 characters in length.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Specifies when noncurrent object versions expire (documented below).
        /// </summary>
        public readonly Outputs.StorageBucketLifecycleRuleNoncurrentVersionExpiration? NoncurrentVersionExpiration;
        /// <summary>
        /// Specifies when noncurrent object versions transitions (documented below).
        /// 
        /// At least one of `abort_incomplete_multipart_upload_days`, `expiration`, `transition`, `noncurrent_version_expiration`, `noncurrent_version_transition` must be specified.
        /// </summary>
        public readonly ImmutableArray<Outputs.StorageBucketLifecycleRuleNoncurrentVersionTransition> NoncurrentVersionTransitions;
        /// <summary>
        /// Object key prefix identifying one or more objects to which the rule applies.
        /// </summary>
        public readonly string? Prefix;
        /// <summary>
        /// Specifies a period in the object's transitions (documented below).
        /// </summary>
        public readonly ImmutableArray<Outputs.StorageBucketLifecycleRuleTransition> Transitions;

        [OutputConstructor]
        private StorageBucketLifecycleRule(
            int? abortIncompleteMultipartUploadDays,

            bool enabled,

            Outputs.StorageBucketLifecycleRuleExpiration? expiration,

            Outputs.StorageBucketLifecycleRuleFilter? filter,

            string? id,

            Outputs.StorageBucketLifecycleRuleNoncurrentVersionExpiration? noncurrentVersionExpiration,

            ImmutableArray<Outputs.StorageBucketLifecycleRuleNoncurrentVersionTransition> noncurrentVersionTransitions,

            string? prefix,

            ImmutableArray<Outputs.StorageBucketLifecycleRuleTransition> transitions)
        {
            AbortIncompleteMultipartUploadDays = abortIncompleteMultipartUploadDays;
            Enabled = enabled;
            Expiration = expiration;
            Filter = filter;
            Id = id;
            NoncurrentVersionExpiration = noncurrentVersionExpiration;
            NoncurrentVersionTransitions = noncurrentVersionTransitions;
            Prefix = prefix;
            Transitions = transitions;
        }
    }
}
