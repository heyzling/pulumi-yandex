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
    public sealed class ComputeInstanceResources
    {
        /// <summary>
        /// If provided, specifies baseline performance for a core as a percent.
        /// </summary>
        public readonly int? CoreFraction;
        /// <summary>
        /// CPU cores for the instance.
        /// </summary>
        public readonly int Cores;
        /// <summary>
        /// If provided, specifies the number of GPU devices for the instance
        /// </summary>
        public readonly int? Gpus;
        /// <summary>
        /// Memory size in GB.
        /// </summary>
        public readonly double Memory;

        [OutputConstructor]
        private ComputeInstanceResources(
            int? coreFraction,

            int cores,

            int? gpus,

            double memory)
        {
            CoreFraction = coreFraction;
            Cores = cores;
            Gpus = gpus;
            Memory = memory;
        }
    }
}
