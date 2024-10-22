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
    public sealed class GetMdbClickhouseClusterShardGroupResult
    {
        public readonly string? Description;
        public readonly string? Name;
        public readonly ImmutableArray<string> ShardNames;

        [OutputConstructor]
        private GetMdbClickhouseClusterShardGroupResult(
            string? description,

            string? name,

            ImmutableArray<string> shardNames)
        {
            Description = description;
            Name = name;
            ShardNames = shardNames;
        }
    }
}
