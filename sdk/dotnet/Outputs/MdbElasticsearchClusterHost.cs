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
    public sealed class MdbElasticsearchClusterHost
    {
        /// <summary>
        /// Sets whether the host should get a public IP address on creation. Can be either `true` or `false`.
        /// </summary>
        public readonly bool? AssignPublicIp;
        /// <summary>
        /// The fully qualified domain name of the host.
        /// </summary>
        public readonly string? Fqdn;
        /// <summary>
        /// User defined host name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The ID of the subnet, to which the host belongs. The subnet must
        /// be a part of the network to which the cluster belongs.
        /// </summary>
        public readonly string? SubnetId;
        /// <summary>
        /// The type of the host to be deployed. Can be either `DATA_NODE` or `MASTER_NODE`.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The availability zone where the Elasticsearch host will be created.
        /// For more information see [the official documentation](https://cloud.yandex.com/docs/overview/concepts/geo-scope).
        /// </summary>
        public readonly string Zone;

        [OutputConstructor]
        private MdbElasticsearchClusterHost(
            bool? assignPublicIp,

            string? fqdn,

            string name,

            string? subnetId,

            string type,

            string zone)
        {
            AssignPublicIp = assignPublicIp;
            Fqdn = fqdn;
            Name = name;
            SubnetId = subnetId;
            Type = type;
            Zone = zone;
        }
    }
}