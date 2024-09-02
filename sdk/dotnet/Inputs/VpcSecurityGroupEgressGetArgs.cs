// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class VpcSecurityGroupEgressGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the security group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// (Optional) - Minimum port number.
        /// </summary>
        [Input("fromPort")]
        public Input<int>? FromPort { get; set; }

        /// <summary>
        /// Id of the rule.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Labels to assign to this security group.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// (Optional) - Port number (if applied to a single port).
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// (Optional) - Special-purpose targets. `self_security_group` refers to this particular security group. `loadbalancer_healthchecks` represents [loadbalancer health check nodes](https://cloud.yandex.com/docs/network-load-balancer/concepts/health-check).
        /// </summary>
        [Input("predefinedTarget")]
        public Input<string>? PredefinedTarget { get; set; }

        /// <summary>
        /// (Required) - One of `ANY`, `TCP`, `UDP`, `ICMP`, `IPV6_ICMP`.
        /// </summary>
        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        /// <summary>
        /// (Optional) - Target security group ID for this rule.
        /// </summary>
        [Input("securityGroupId")]
        public Input<string>? SecurityGroupId { get; set; }

        /// <summary>
        /// (Optional) - Maximum port number.
        /// </summary>
        [Input("toPort")]
        public Input<int>? ToPort { get; set; }

        [Input("v4CidrBlocks")]
        private InputList<string>? _v4CidrBlocks;

        /// <summary>
        /// (Optional) - The blocks of IPv4 addresses for this rule.
        /// </summary>
        public InputList<string> V4CidrBlocks
        {
            get => _v4CidrBlocks ?? (_v4CidrBlocks = new InputList<string>());
            set => _v4CidrBlocks = value;
        }

        [Input("v6CidrBlocks")]
        private InputList<string>? _v6CidrBlocks;

        /// <summary>
        /// (Optional) - The blocks of IPv6 addresses for this rule. `v6_cidr_blocks` argument is currently not supported. It will be available in the future.
        /// </summary>
        public InputList<string> V6CidrBlocks
        {
            get => _v6CidrBlocks ?? (_v6CidrBlocks = new InputList<string>());
            set => _v6CidrBlocks = value;
        }

        public VpcSecurityGroupEgressGetArgs()
        {
        }
        public static new VpcSecurityGroupEgressGetArgs Empty => new VpcSecurityGroupEgressGetArgs();
    }
}
