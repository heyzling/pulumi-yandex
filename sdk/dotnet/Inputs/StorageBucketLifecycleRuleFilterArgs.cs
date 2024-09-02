// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class StorageBucketLifecycleRuleFilterArgs : global::Pulumi.ResourceArgs
    {
        [Input("and")]
        public Input<Inputs.StorageBucketLifecycleRuleFilterAndArgs>? And { get; set; }

        [Input("objectSizeGreaterThan")]
        public Input<int>? ObjectSizeGreaterThan { get; set; }

        [Input("objectSizeLessThan")]
        public Input<int>? ObjectSizeLessThan { get; set; }

        /// <summary>
        /// Object key prefix identifying one or more objects to which the rule applies.
        /// </summary>
        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        [Input("tag")]
        public Input<Inputs.StorageBucketLifecycleRuleFilterTagArgs>? Tag { get; set; }

        public StorageBucketLifecycleRuleFilterArgs()
        {
        }
        public static new StorageBucketLifecycleRuleFilterArgs Empty => new StorageBucketLifecycleRuleFilterArgs();
    }
}