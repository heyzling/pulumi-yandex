// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AuditTrailsTrailFilterEventFilterPathFilterSomeFilterAnyFilterArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of the child resource.
        /// </summary>
        [Input("resourceId", required: true)]
        public Input<string> ResourceId { get; set; } = null!;

        /// <summary>
        /// Resource type of the child resource.
        /// </summary>
        [Input("resourceType", required: true)]
        public Input<string> ResourceType { get; set; } = null!;

        public AuditTrailsTrailFilterEventFilterPathFilterSomeFilterAnyFilterArgs()
        {
        }
        public static new AuditTrailsTrailFilterEventFilterPathFilterSomeFilterAnyFilterArgs Empty => new AuditTrailsTrailFilterEventFilterPathFilterSomeFilterAnyFilterArgs();
    }
}
