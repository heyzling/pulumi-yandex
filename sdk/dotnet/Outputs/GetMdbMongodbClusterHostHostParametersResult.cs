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
    public sealed class GetMdbMongodbClusterHostHostParametersResult
    {
        public readonly bool? Hidden;
        public readonly double? Priority;
        public readonly int? SecondaryDelaySecs;
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private GetMdbMongodbClusterHostHostParametersResult(
            bool? hidden,

            double? priority,

            int? secondaryDelaySecs,

            ImmutableDictionary<string, string>? tags)
        {
            Hidden = hidden;
            Priority = priority;
            SecondaryDelaySecs = secondaryDelaySecs;
            Tags = tags;
        }
    }
}
