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
    public sealed class AuditTrailsTrailDataStreamDestination
    {
        /// <summary>
        /// ID of the [YDB](https://cloud.yandex.ru/ru/docs/ydb/concepts/resources) hosting the destination data stream.
        /// </summary>
        public readonly string DatabaseId;
        /// <summary>
        /// Name of the [YDS stream](https://cloud.yandex.ru/ru/docs/data-streams/concepts/glossary#stream-concepts) belonging to the specified YDB.
        /// </summary>
        public readonly string StreamName;

        [OutputConstructor]
        private AuditTrailsTrailDataStreamDestination(
            string databaseId,

            string streamName)
        {
            DatabaseId = databaseId;
            StreamName = streamName;
        }
    }
}