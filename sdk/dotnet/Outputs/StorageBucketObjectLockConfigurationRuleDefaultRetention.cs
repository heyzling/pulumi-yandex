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
    public sealed class StorageBucketObjectLockConfigurationRuleDefaultRetention
    {
        /// <summary>
        /// Specifies the number of days after object creation when the specific rule action takes effect.
        /// </summary>
        public readonly int? Days;
        /// <summary>
        /// Specifies a type of object lock. One of `["GOVERNANCE", "COMPLIANCE"]`.
        /// </summary>
        public readonly string Mode;
        /// <summary>
        /// Specifies a retention period in years after uploading an object version. It must be a positive integer. You can't set it simultaneously with `days`.
        /// </summary>
        public readonly int? Years;

        [OutputConstructor]
        private StorageBucketObjectLockConfigurationRuleDefaultRetention(
            int? days,

            string mode,

            int? years)
        {
            Days = days;
            Mode = mode;
            Years = years;
        }
    }
}
