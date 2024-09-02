// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class LoadtestingAgentComputeInstanceResourcesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If provided, specifies baseline core performance as a percent.
        /// </summary>
        [Input("coreFraction")]
        public Input<int>? CoreFraction { get; set; }

        /// <summary>
        /// The number of CPU cores for the instance. Defaults to 2 cores.
        /// </summary>
        [Input("cores")]
        public Input<int>? Cores { get; set; }

        /// <summary>
        /// The memory size in GB. Defaults to 2 GB.
        /// </summary>
        [Input("memory")]
        public Input<double>? Memory { get; set; }

        public LoadtestingAgentComputeInstanceResourcesArgs()
        {
        }
        public static new LoadtestingAgentComputeInstanceResourcesArgs Empty => new LoadtestingAgentComputeInstanceResourcesArgs();
    }
}
