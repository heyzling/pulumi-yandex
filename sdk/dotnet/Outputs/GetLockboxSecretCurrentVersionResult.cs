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
    public sealed class GetLockboxSecretCurrentVersionResult
    {
        public readonly string CreatedAt;
        public readonly string Description;
        public readonly string DestroyAt;
        public readonly string Id;
        public readonly ImmutableArray<string> PayloadEntryKeys;
        public readonly string SecretId;
        public readonly string Status;

        [OutputConstructor]
        private GetLockboxSecretCurrentVersionResult(
            string createdAt,

            string description,

            string destroyAt,

            string id,

            ImmutableArray<string> payloadEntryKeys,

            string secretId,

            string status)
        {
            CreatedAt = createdAt;
            Description = description;
            DestroyAt = destroyAt;
            Id = id;
            PayloadEntryKeys = payloadEntryKeys;
            SecretId = secretId;
            Status = status;
        }
    }
}
