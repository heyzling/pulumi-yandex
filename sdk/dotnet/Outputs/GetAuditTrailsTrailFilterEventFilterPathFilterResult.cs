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
    public sealed class GetAuditTrailsTrailFilterEventFilterPathFilterResult
    {
        public readonly ImmutableArray<Outputs.GetAuditTrailsTrailFilterEventFilterPathFilterAnyFilterResult> AnyFilters;
        public readonly ImmutableArray<Outputs.GetAuditTrailsTrailFilterEventFilterPathFilterSomeFilterResult> SomeFilters;

        [OutputConstructor]
        private GetAuditTrailsTrailFilterEventFilterPathFilterResult(
            ImmutableArray<Outputs.GetAuditTrailsTrailFilterEventFilterPathFilterAnyFilterResult> anyFilters,

            ImmutableArray<Outputs.GetAuditTrailsTrailFilterEventFilterPathFilterSomeFilterResult> someFilters)
        {
            AnyFilters = anyFilters;
            SomeFilters = someFilters;
        }
    }
}