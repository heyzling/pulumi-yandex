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
    public sealed class LoadtestingAgentComputeInstanceResources
    {
        /// <summary>
        /// If provided, specifies baseline core performance as a percent.
        /// </summary>
        public readonly int? CoreFraction;
        /// <summary>
        /// The number of CPU cores for the instance. Defaults to 2 cores.
        /// </summary>
        public readonly int? Cores;
        /// <summary>
        /// The memory size in GB. Defaults to 2 GB.
        /// </summary>
        public readonly double? Memory;

        [OutputConstructor]
        private LoadtestingAgentComputeInstanceResources(
            int? coreFraction,

            int? cores,

            double? memory)
        {
            CoreFraction = coreFraction;
            Cores = cores;
            Memory = memory;
        }
    }
}