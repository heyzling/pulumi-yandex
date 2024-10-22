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
    public sealed class GetMdbKafkaClusterHostResult
    {
        public readonly bool AssignPublicIp;
        public readonly string Health;
        public readonly string Name;
        public readonly string Role;
        public readonly string SubnetId;
        public readonly string ZoneId;

        [OutputConstructor]
        private GetMdbKafkaClusterHostResult(
            bool assignPublicIp,

            string health,

            string name,

            string role,

            string subnetId,

            string zoneId)
        {
            AssignPublicIp = assignPublicIp;
            Health = health;
            Name = name;
            Role = role;
            SubnetId = subnetId;
            ZoneId = zoneId;
        }
    }
}
