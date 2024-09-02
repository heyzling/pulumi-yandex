// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AuditTrailsTrailFilterEventFilterGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("categories", required: true)]
        private InputList<Inputs.AuditTrailsTrailFilterEventFilterCategoryGetArgs>? _categories;

        /// <summary>
        /// List of structures describing categories of gathered data plane events
        /// </summary>
        public InputList<Inputs.AuditTrailsTrailFilterEventFilterCategoryGetArgs> Categories
        {
            get => _categories ?? (_categories = new InputList<Inputs.AuditTrailsTrailFilterEventFilterCategoryGetArgs>());
            set => _categories = value;
        }

        /// <summary>
        /// Structure describing filtering process based on cloud resources for the described event set. Structurally equal to the `filter.path_filter`
        /// </summary>
        [Input("pathFilter", required: true)]
        public Input<Inputs.AuditTrailsTrailFilterEventFilterPathFilterGetArgs> PathFilter { get; set; } = null!;

        /// <summary>
        /// ID of the service which events will be gathered
        /// </summary>
        [Input("service", required: true)]
        public Input<string> Service { get; set; } = null!;

        public AuditTrailsTrailFilterEventFilterGetArgs()
        {
        }
        public static new AuditTrailsTrailFilterEventFilterGetArgs Empty => new AuditTrailsTrailFilterEventFilterGetArgs();
    }
}
