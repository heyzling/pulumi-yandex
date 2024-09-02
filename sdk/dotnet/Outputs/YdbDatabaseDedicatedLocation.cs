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
    public sealed class YdbDatabaseDedicatedLocation
    {
        /// <summary>
        /// Region for the Yandex Database cluster.
        /// The structure is documented below.
        /// </summary>
        public readonly Outputs.YdbDatabaseDedicatedLocationRegion? Region;

        [OutputConstructor]
        private YdbDatabaseDedicatedLocation(Outputs.YdbDatabaseDedicatedLocationRegion? region)
        {
            Region = region;
        }
    }
}