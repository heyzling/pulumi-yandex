// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbPostgresqlClusterConfigResourcesGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Volume of the storage available to a PostgreSQL host, in gigabytes.
        /// </summary>
        [Input("diskSize", required: true)]
        public Input<int> DiskSize { get; set; } = null!;

        /// <summary>
        /// Type of the storage of PostgreSQL hosts.
        /// </summary>
        [Input("diskTypeId")]
        public Input<string>? DiskTypeId { get; set; }

        [Input("resourcePresetId", required: true)]
        public Input<string> ResourcePresetId { get; set; } = null!;

        public MdbPostgresqlClusterConfigResourcesGetArgs()
        {
        }
        public static new MdbPostgresqlClusterConfigResourcesGetArgs Empty => new MdbPostgresqlClusterConfigResourcesGetArgs();
    }
}
