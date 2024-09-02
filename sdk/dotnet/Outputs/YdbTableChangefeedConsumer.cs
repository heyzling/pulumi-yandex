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
    public sealed class YdbTableChangefeedConsumer
    {
        public readonly bool? Important;
        public readonly string Name;
        public readonly int? StartingMessageTimestampMs;
        public readonly ImmutableArray<string> SupportedCodecs;

        [OutputConstructor]
        private YdbTableChangefeedConsumer(
            bool? important,

            string name,

            int? startingMessageTimestampMs,

            ImmutableArray<string> supportedCodecs)
        {
            Important = important;
            Name = name;
            StartingMessageTimestampMs = startingMessageTimestampMs;
            SupportedCodecs = supportedCodecs;
        }
    }
}
