// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AuditTrailsTrailFilterArgs : global::Pulumi.ResourceArgs
    {
        [Input("eventFilters")]
        private InputList<Inputs.AuditTrailsTrailFilterEventFilterArgs>? _eventFilters;

        /// <summary>
        /// Structure describing filtering process for the service-specific data plane events
        /// </summary>
        public InputList<Inputs.AuditTrailsTrailFilterEventFilterArgs> EventFilters
        {
            get => _eventFilters ?? (_eventFilters = new InputList<Inputs.AuditTrailsTrailFilterEventFilterArgs>());
            set => _eventFilters = value;
        }

        /// <summary>
        /// Structure describing filtering process based on cloud resources for the described event set. Structurally equal to the `filter.path_filter`
        /// </summary>
        [Input("pathFilter")]
        public Input<Inputs.AuditTrailsTrailFilterPathFilterArgs>? PathFilter { get; set; }

        public AuditTrailsTrailFilterArgs()
        {
        }
        public static new AuditTrailsTrailFilterArgs Empty => new AuditTrailsTrailFilterArgs();
    }
}
