// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetMessageQueue
    {
        public static Task<GetMessageQueueResult> InvokeAsync(GetMessageQueueArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetMessageQueueResult>("yandex:index/getMessageQueue:getMessageQueue", args ?? new GetMessageQueueArgs(), options.WithDefaults());

        public static Output<GetMessageQueueResult> Invoke(GetMessageQueueInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetMessageQueueResult>("yandex:index/getMessageQueue:getMessageQueue", args ?? new GetMessageQueueInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetMessageQueueArgs : global::Pulumi.InvokeArgs
    {
        [Input("accessKey")]
        public string? AccessKey { get; set; }

        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("regionId")]
        public string? RegionId { get; set; }

        [Input("secretKey")]
        private string? _secretKey;
        public string? SecretKey
        {
            get => _secretKey;
            set => _secretKey = value;
        }

        public GetMessageQueueArgs()
        {
        }
        public static new GetMessageQueueArgs Empty => new GetMessageQueueArgs();
    }

    public sealed class GetMessageQueueInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("accessKey")]
        public Input<string>? AccessKey { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("regionId")]
        public Input<string>? RegionId { get; set; }

        [Input("secretKey")]
        private Input<string>? _secretKey;
        public Input<string>? SecretKey
        {
            get => _secretKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _secretKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public GetMessageQueueInvokeArgs()
        {
        }
        public static new GetMessageQueueInvokeArgs Empty => new GetMessageQueueInvokeArgs();
    }


    [OutputType]
    public sealed class GetMessageQueueResult
    {
        public readonly string? AccessKey;
        public readonly string Arn;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        public readonly string? RegionId;
        public readonly string? SecretKey;
        public readonly string Url;

        [OutputConstructor]
        private GetMessageQueueResult(
            string? accessKey,

            string arn,

            string id,

            string name,

            string? regionId,

            string? secretKey,

            string url)
        {
            AccessKey = accessKey;
            Arn = arn;
            Id = id;
            Name = name;
            RegionId = regionId;
            SecretKey = secretKey;
            Url = url;
        }
    }
}
