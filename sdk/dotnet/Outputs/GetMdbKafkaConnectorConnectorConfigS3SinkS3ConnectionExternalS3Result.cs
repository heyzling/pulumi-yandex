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
    public sealed class GetMdbKafkaConnectorConnectorConfigS3SinkS3ConnectionExternalS3Result
    {
        public readonly string AccessKeyId;
        public readonly string Endpoint;
        public readonly string Region;
        public readonly string SecretAccessKey;

        [OutputConstructor]
        private GetMdbKafkaConnectorConnectorConfigS3SinkS3ConnectionExternalS3Result(
            string accessKeyId,

            string endpoint,

            string region,

            string secretAccessKey)
        {
            AccessKeyId = accessKeyId;
            Endpoint = endpoint;
            Region = region;
            SecretAccessKey = secretAccessKey;
        }
    }
}
