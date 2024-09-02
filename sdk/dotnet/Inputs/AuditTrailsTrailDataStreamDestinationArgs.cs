// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AuditTrailsTrailDataStreamDestinationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of the [YDB](https://cloud.yandex.ru/ru/docs/ydb/concepts/resources) hosting the destination data stream.
        /// </summary>
        [Input("databaseId", required: true)]
        public Input<string> DatabaseId { get; set; } = null!;

        /// <summary>
        /// Name of the [YDS stream](https://cloud.yandex.ru/ru/docs/data-streams/concepts/glossary#stream-concepts) belonging to the specified YDB.
        /// </summary>
        [Input("streamName", required: true)]
        public Input<string> StreamName { get; set; } = null!;

        public AuditTrailsTrailDataStreamDestinationArgs()
        {
        }
        public static new AuditTrailsTrailDataStreamDestinationArgs Empty => new AuditTrailsTrailDataStreamDestinationArgs();
    }
}
