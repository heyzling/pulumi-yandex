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
    public sealed class GetAuditTrailsTrailDataStreamDestinationResult
    {
        public readonly string DatabaseId;
        public readonly string StreamName;

        [OutputConstructor]
        private GetAuditTrailsTrailDataStreamDestinationResult(
            string databaseId,

            string streamName)
        {
            DatabaseId = databaseId;
            StreamName = streamName;
        }
    }
}
