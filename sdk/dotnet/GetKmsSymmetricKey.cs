// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetKmsSymmetricKey
    {
        public static Task<GetKmsSymmetricKeyResult> InvokeAsync(GetKmsSymmetricKeyArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetKmsSymmetricKeyResult>("yandex:index/getKmsSymmetricKey:getKmsSymmetricKey", args ?? new GetKmsSymmetricKeyArgs(), options.WithDefaults());

        public static Output<GetKmsSymmetricKeyResult> Invoke(GetKmsSymmetricKeyInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetKmsSymmetricKeyResult>("yandex:index/getKmsSymmetricKey:getKmsSymmetricKey", args ?? new GetKmsSymmetricKeyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetKmsSymmetricKeyArgs : global::Pulumi.InvokeArgs
    {
        [Input("defaultAlgorithm")]
        public string? DefaultAlgorithm { get; set; }

        [Input("deletionProtection")]
        public bool? DeletionProtection { get; set; }

        [Input("description")]
        public string? Description { get; set; }

        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("labels")]
        private Dictionary<string, string>? _labels;
        public Dictionary<string, string> Labels
        {
            get => _labels ?? (_labels = new Dictionary<string, string>());
            set => _labels = value;
        }

        [Input("name")]
        public string? Name { get; set; }

        [Input("rotationPeriod")]
        public string? RotationPeriod { get; set; }

        [Input("symmetricKeyId")]
        public string? SymmetricKeyId { get; set; }

        public GetKmsSymmetricKeyArgs()
        {
        }
        public static new GetKmsSymmetricKeyArgs Empty => new GetKmsSymmetricKeyArgs();
    }

    public sealed class GetKmsSymmetricKeyInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("defaultAlgorithm")]
        public Input<string>? DefaultAlgorithm { get; set; }

        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("rotationPeriod")]
        public Input<string>? RotationPeriod { get; set; }

        [Input("symmetricKeyId")]
        public Input<string>? SymmetricKeyId { get; set; }

        public GetKmsSymmetricKeyInvokeArgs()
        {
        }
        public static new GetKmsSymmetricKeyInvokeArgs Empty => new GetKmsSymmetricKeyInvokeArgs();
    }


    [OutputType]
    public sealed class GetKmsSymmetricKeyResult
    {
        public readonly string CreatedAt;
        public readonly string? DefaultAlgorithm;
        public readonly bool? DeletionProtection;
        public readonly string? Description;
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string>? Labels;
        public readonly string? Name;
        public readonly string RotatedAt;
        public readonly string? RotationPeriod;
        public readonly string Status;
        public readonly string? SymmetricKeyId;

        [OutputConstructor]
        private GetKmsSymmetricKeyResult(
            string createdAt,

            string? defaultAlgorithm,

            bool? deletionProtection,

            string? description,

            string folderId,

            string id,

            ImmutableDictionary<string, string>? labels,

            string? name,

            string rotatedAt,

            string? rotationPeriod,

            string status,

            string? symmetricKeyId)
        {
            CreatedAt = createdAt;
            DefaultAlgorithm = defaultAlgorithm;
            DeletionProtection = deletionProtection;
            Description = description;
            FolderId = folderId;
            Id = id;
            Labels = labels;
            Name = name;
            RotatedAt = rotatedAt;
            RotationPeriod = rotationPeriod;
            Status = status;
            SymmetricKeyId = symmetricKeyId;
        }
    }
}
