// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupDeployPolicyGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The maximum number of instances that can be created at the same time.
        /// </summary>
        [Input("maxCreating")]
        public Input<int>? MaxCreating { get; set; }

        /// <summary>
        /// The maximum number of instances that can be deleted at the same time.
        /// </summary>
        [Input("maxDeleting")]
        public Input<int>? MaxDeleting { get; set; }

        /// <summary>
        /// The maximum number of instances that can be temporarily allocated above the group's target size
        /// during the update process.
        /// 
        /// - - -
        /// </summary>
        [Input("maxExpansion", required: true)]
        public Input<int> MaxExpansion { get; set; } = null!;

        /// <summary>
        /// The maximum number of running instances that can be taken offline (stopped or deleted) at the same time
        /// during the update process.
        /// </summary>
        [Input("maxUnavailable", required: true)]
        public Input<int> MaxUnavailable { get; set; } = null!;

        /// <summary>
        /// The amount of time in seconds to allow for an instance to start.
        /// Instance will be considered up and running (and start receiving traffic) only after the startup_duration
        /// has elapsed and all health checks are passed.
        /// </summary>
        [Input("startupDuration")]
        public Input<int>? StartupDuration { get; set; }

        /// <summary>
        /// Affects the lifecycle of the instance during deployment. If set to `proactive` (default), Instance Groups
        /// can forcefully stop a running instance. If `opportunistic`, Instance Groups does not stop a running instance. Instead,
        /// it will wait until the instance stops itself or becomes unhealthy.
        /// </summary>
        [Input("strategy")]
        public Input<string>? Strategy { get; set; }

        public ComputeInstanceGroupDeployPolicyGetArgs()
        {
        }
        public static new ComputeInstanceGroupDeployPolicyGetArgs Empty => new ComputeInstanceGroupDeployPolicyGetArgs();
    }
}