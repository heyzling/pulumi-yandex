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
    public sealed class ContainerRepositoryLifecyclePolicyRule
    {
        /// <summary>
        /// Description of the lifecycle policy.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The period of time that must pass after creating a image for it to suit the automatic deletion criteria. It must be a multiple of 24 hours.
        /// </summary>
        public readonly string? ExpirePeriod;
        /// <summary>
        /// The number of images to be retained even if the expire_period already expired.
        /// </summary>
        public readonly int? RetainedTop;
        /// <summary>
        /// Tag to specify a filter as a regular expression. For example `.*` - all images with tags.
        /// </summary>
        public readonly string? TagRegexp;
        /// <summary>
        /// If enabled, rules apply to untagged Docker images.
        /// </summary>
        public readonly bool? Untagged;

        [OutputConstructor]
        private ContainerRepositoryLifecyclePolicyRule(
            string? description,

            string? expirePeriod,

            int? retainedTop,

            string? tagRegexp,

            bool? untagged)
        {
            Description = description;
            ExpirePeriod = expirePeriod;
            RetainedTop = retainedTop;
            TagRegexp = tagRegexp;
            Untagged = untagged;
        }
    }
}
