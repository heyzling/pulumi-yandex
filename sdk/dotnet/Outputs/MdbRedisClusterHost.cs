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
    public sealed class MdbRedisClusterHost
    {
        /// <summary>
        /// Sets whether the host should get a public IP address or not.
        /// </summary>
        public readonly bool? AssignPublicIp;
        /// <summary>
        /// The fully qualified domain name of the host.
        /// </summary>
        public readonly string? Fqdn;
        /// <summary>
        /// Replica priority of a current replica (usable for non-sharded only).
        /// </summary>
        public readonly int? ReplicaPriority;
        /// <summary>
        /// The name of the shard to which the host belongs.
        /// </summary>
        public readonly string? ShardName;
        /// <summary>
        /// The ID of the subnet, to which the host belongs. The subnet must
        /// be a part of the network to which the cluster belongs.
        /// </summary>
        public readonly string? SubnetId;
        /// <summary>
        /// The availability zone where the Redis host will be created.
        /// For more information see [the official documentation](https://cloud.yandex.com/docs/overview/concepts/geo-scope).
        /// </summary>
        public readonly string Zone;

        [OutputConstructor]
        private MdbRedisClusterHost(
            bool? assignPublicIp,

            string? fqdn,

            int? replicaPriority,

            string? shardName,

            string? subnetId,

            string zone)
        {
            AssignPublicIp = assignPublicIp;
            Fqdn = fqdn;
            ReplicaPriority = replicaPriority;
            ShardName = shardName;
            SubnetId = subnetId;
            Zone = zone;
        }
    }
}