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
    public sealed class MdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention
    {
        /// <summary>
        /// Minimum data age in seconds.
        /// </summary>
        public readonly int Age;
        /// <summary>
        /// Accuracy of determining the age of the data in seconds.
        /// </summary>
        public readonly int Precision;

        [OutputConstructor]
        private MdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention(
            int age,

            int precision)
        {
            Age = age;
            Precision = precision;
        }
    }
}