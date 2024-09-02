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
    public sealed class GetFunctionTriggerIotResult
    {
        public readonly string BatchCutoff;
        public readonly string BatchSize;
        public readonly string DeviceId;
        public readonly string RegistryId;
        public readonly string Topic;

        [OutputConstructor]
        private GetFunctionTriggerIotResult(
            string batchCutoff,

            string batchSize,

            string deviceId,

            string registryId,

            string topic)
        {
            BatchCutoff = batchCutoff;
            BatchSize = batchSize;
            DeviceId = deviceId;
            RegistryId = registryId;
            Topic = topic;
        }
    }
}
