// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetServerlessContainer
    {
        public static Task<GetServerlessContainerResult> InvokeAsync(GetServerlessContainerArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetServerlessContainerResult>("yandex:index/getServerlessContainer:getServerlessContainer", args ?? new GetServerlessContainerArgs(), options.WithDefaults());

        public static Output<GetServerlessContainerResult> Invoke(GetServerlessContainerInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetServerlessContainerResult>("yandex:index/getServerlessContainer:getServerlessContainer", args ?? new GetServerlessContainerInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetServerlessContainerArgs : global::Pulumi.InvokeArgs
    {
        [Input("connectivity")]
        public Inputs.GetServerlessContainerConnectivityArgs? Connectivity { get; set; }

        [Input("containerId")]
        public string? ContainerId { get; set; }

        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("secrets")]
        private List<Inputs.GetServerlessContainerSecretArgs>? _secrets;
        public List<Inputs.GetServerlessContainerSecretArgs> Secrets
        {
            get => _secrets ?? (_secrets = new List<Inputs.GetServerlessContainerSecretArgs>());
            set => _secrets = value;
        }

        [Input("storageMounts")]
        private List<Inputs.GetServerlessContainerStorageMountArgs>? _storageMounts;
        public List<Inputs.GetServerlessContainerStorageMountArgs> StorageMounts
        {
            get => _storageMounts ?? (_storageMounts = new List<Inputs.GetServerlessContainerStorageMountArgs>());
            set => _storageMounts = value;
        }

        public GetServerlessContainerArgs()
        {
        }
        public static new GetServerlessContainerArgs Empty => new GetServerlessContainerArgs();
    }

    public sealed class GetServerlessContainerInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("connectivity")]
        public Input<Inputs.GetServerlessContainerConnectivityInputArgs>? Connectivity { get; set; }

        [Input("containerId")]
        public Input<string>? ContainerId { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("secrets")]
        private InputList<Inputs.GetServerlessContainerSecretInputArgs>? _secrets;
        public InputList<Inputs.GetServerlessContainerSecretInputArgs> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Inputs.GetServerlessContainerSecretInputArgs>());
            set => _secrets = value;
        }

        [Input("storageMounts")]
        private InputList<Inputs.GetServerlessContainerStorageMountInputArgs>? _storageMounts;
        public InputList<Inputs.GetServerlessContainerStorageMountInputArgs> StorageMounts
        {
            get => _storageMounts ?? (_storageMounts = new InputList<Inputs.GetServerlessContainerStorageMountInputArgs>());
            set => _storageMounts = value;
        }

        public GetServerlessContainerInvokeArgs()
        {
        }
        public static new GetServerlessContainerInvokeArgs Empty => new GetServerlessContainerInvokeArgs();
    }


    [OutputType]
    public sealed class GetServerlessContainerResult
    {
        public readonly int Concurrency;
        public readonly Outputs.GetServerlessContainerConnectivityResult? Connectivity;
        public readonly string? ContainerId;
        public readonly int CoreFraction;
        public readonly int Cores;
        public readonly string CreatedAt;
        public readonly string Description;
        public readonly string ExecutionTimeout;
        public readonly string? FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetServerlessContainerImageResult> Images;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly ImmutableArray<Outputs.GetServerlessContainerLogOptionResult> LogOptions;
        public readonly int Memory;
        public readonly string? Name;
        public readonly string RevisionId;
        public readonly ImmutableArray<Outputs.GetServerlessContainerSecretResult> Secrets;
        public readonly string ServiceAccountId;
        public readonly ImmutableArray<Outputs.GetServerlessContainerStorageMountResult> StorageMounts;
        public readonly string Url;

        [OutputConstructor]
        private GetServerlessContainerResult(
            int concurrency,

            Outputs.GetServerlessContainerConnectivityResult? connectivity,

            string? containerId,

            int coreFraction,

            int cores,

            string createdAt,

            string description,

            string executionTimeout,

            string? folderId,

            string id,

            ImmutableArray<Outputs.GetServerlessContainerImageResult> images,

            ImmutableDictionary<string, string> labels,

            ImmutableArray<Outputs.GetServerlessContainerLogOptionResult> logOptions,

            int memory,

            string? name,

            string revisionId,

            ImmutableArray<Outputs.GetServerlessContainerSecretResult> secrets,

            string serviceAccountId,

            ImmutableArray<Outputs.GetServerlessContainerStorageMountResult> storageMounts,

            string url)
        {
            Concurrency = concurrency;
            Connectivity = connectivity;
            ContainerId = containerId;
            CoreFraction = coreFraction;
            Cores = cores;
            CreatedAt = createdAt;
            Description = description;
            ExecutionTimeout = executionTimeout;
            FolderId = folderId;
            Id = id;
            Images = images;
            Labels = labels;
            LogOptions = logOptions;
            Memory = memory;
            Name = name;
            RevisionId = revisionId;
            Secrets = secrets;
            ServiceAccountId = serviceAccountId;
            StorageMounts = storageMounts;
            Url = url;
        }
    }
}
