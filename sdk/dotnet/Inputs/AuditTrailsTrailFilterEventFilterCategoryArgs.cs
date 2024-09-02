// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AuditTrailsTrailFilterEventFilterCategoryArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Type of the event by its relation to the cloud resource model. Possible values: `CONTROL_PLANE`/`DATA_PLANE`
        /// </summary>
        [Input("plane", required: true)]
        public Input<string> Plane { get; set; } = null!;

        /// <summary>
        /// Type of the event by its operation effect on the resource. Possible values: `READ`/`WRITE`
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public AuditTrailsTrailFilterEventFilterCategoryArgs()
        {
        }
        public static new AuditTrailsTrailFilterEventFilterCategoryArgs Empty => new AuditTrailsTrailFilterEventFilterCategoryArgs();
    }
}