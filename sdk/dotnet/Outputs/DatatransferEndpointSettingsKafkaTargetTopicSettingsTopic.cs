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
    public sealed class DatatransferEndpointSettingsKafkaTargetTopicSettingsTopic
    {
        /// <summary>
        /// Not to split events queue into separate per-table queues.
        /// </summary>
        public readonly bool? SaveTxOrder;
        /// <summary>
        /// Full topic name
        /// </summary>
        public readonly string? TopicName;

        [OutputConstructor]
        private DatatransferEndpointSettingsKafkaTargetTopicSettingsTopic(
            bool? saveTxOrder,

            string? topicName)
        {
            SaveTxOrder = saveTxOrder;
            TopicName = topicName;
        }
    }
}