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
    public sealed class GetFunctionTriggerDataStreamResult
    {
        public readonly string BatchCutoff;
        public readonly string BatchSize;
        public readonly string Database;
        public readonly bool ServiceAccountId;
        public readonly string StreamName;
        public readonly string Suffix;

        [OutputConstructor]
        private GetFunctionTriggerDataStreamResult(
            string batchCutoff,

            string batchSize,

            string database,

            bool serviceAccountId,

            string streamName,

            string suffix)
        {
            BatchCutoff = batchCutoff;
            BatchSize = batchSize;
            Database = database;
            ServiceAccountId = serviceAccountId;
            StreamName = streamName;
            Suffix = suffix;
        }
    }
}
