// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AuditTrailsTrailFilterEventFilterArgs : global::Pulumi.ResourceArgs
    {
        [Input("categories", required: true)]
        private InputList<Inputs.AuditTrailsTrailFilterEventFilterCategoryArgs>? _categories;

        /// <summary>
        /// List of structures describing categories of gathered data plane events
        /// </summary>
        public InputList<Inputs.AuditTrailsTrailFilterEventFilterCategoryArgs> Categories
        {
            get => _categories ?? (_categories = new InputList<Inputs.AuditTrailsTrailFilterEventFilterCategoryArgs>());
            set => _categories = value;
        }

        /// <summary>
        /// Structure describing filtering process based on cloud resources for the described event set. Structurally equal to the `filter.path_filter`
        /// </summary>
        [Input("pathFilter", required: true)]
        public Input<Inputs.AuditTrailsTrailFilterEventFilterPathFilterArgs> PathFilter { get; set; } = null!;

        /// <summary>
        /// ID of the service which events will be gathered
        /// </summary>
        [Input("service", required: true)]
        public Input<string> Service { get; set; } = null!;

        public AuditTrailsTrailFilterEventFilterArgs()
        {
        }
        public static new AuditTrailsTrailFilterEventFilterArgs Empty => new AuditTrailsTrailFilterEventFilterArgs();
    }
}