// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetYdbDatabaseDedicated
    {
        public static Task<GetYdbDatabaseDedicatedResult> InvokeAsync(GetYdbDatabaseDedicatedArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetYdbDatabaseDedicatedResult>("yandex:index/getYdbDatabaseDedicated:getYdbDatabaseDedicated", args ?? new GetYdbDatabaseDedicatedArgs(), options.WithDefaults());

        public static Output<GetYdbDatabaseDedicatedResult> Invoke(GetYdbDatabaseDedicatedInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetYdbDatabaseDedicatedResult>("yandex:index/getYdbDatabaseDedicated:getYdbDatabaseDedicated", args ?? new GetYdbDatabaseDedicatedInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetYdbDatabaseDedicatedArgs : global::Pulumi.InvokeArgs
    {
        [Input("databaseId")]
        public string? DatabaseId { get; set; }

        [Input("deletionProtection")]
        public bool? DeletionProtection { get; set; }

        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        public GetYdbDatabaseDedicatedArgs()
        {
        }
        public static new GetYdbDatabaseDedicatedArgs Empty => new GetYdbDatabaseDedicatedArgs();
    }

    public sealed class GetYdbDatabaseDedicatedInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("databaseId")]
        public Input<string>? DatabaseId { get; set; }

        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        public GetYdbDatabaseDedicatedInvokeArgs()
        {
        }
        public static new GetYdbDatabaseDedicatedInvokeArgs Empty => new GetYdbDatabaseDedicatedInvokeArgs();
    }


    [OutputType]
    public sealed class GetYdbDatabaseDedicatedResult
    {
        public readonly bool AssignPublicIps;
        public readonly string CreatedAt;
        public readonly string? DatabaseId;
        public readonly string DatabasePath;
        public readonly bool DeletionProtection;
        public readonly string Description;
        public readonly string? FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string LocationId;
        public readonly ImmutableArray<Outputs.GetYdbDatabaseDedicatedLocationResult> Locations;
        public readonly string? Name;
        public readonly string NetworkId;
        public readonly string ResourcePresetId;
        public readonly ImmutableArray<Outputs.GetYdbDatabaseDedicatedScalePolicyResult> ScalePolicies;
        public readonly string Status;
        public readonly ImmutableArray<Outputs.GetYdbDatabaseDedicatedStorageConfigResult> StorageConfigs;
        public readonly ImmutableArray<string> SubnetIds;
        public readonly bool TlsEnabled;
        public readonly string YdbApiEndpoint;
        public readonly string YdbFullEndpoint;

        [OutputConstructor]
        private GetYdbDatabaseDedicatedResult(
            bool assignPublicIps,

            string createdAt,

            string? databaseId,

            string databasePath,

            bool deletionProtection,

            string description,

            string? folderId,

            string id,

            ImmutableDictionary<string, string> labels,

            string locationId,

            ImmutableArray<Outputs.GetYdbDatabaseDedicatedLocationResult> locations,

            string? name,

            string networkId,

            string resourcePresetId,

            ImmutableArray<Outputs.GetYdbDatabaseDedicatedScalePolicyResult> scalePolicies,

            string status,

            ImmutableArray<Outputs.GetYdbDatabaseDedicatedStorageConfigResult> storageConfigs,

            ImmutableArray<string> subnetIds,

            bool tlsEnabled,

            string ydbApiEndpoint,

            string ydbFullEndpoint)
        {
            AssignPublicIps = assignPublicIps;
            CreatedAt = createdAt;
            DatabaseId = databaseId;
            DatabasePath = databasePath;
            DeletionProtection = deletionProtection;
            Description = description;
            FolderId = folderId;
            Id = id;
            Labels = labels;
            LocationId = locationId;
            Locations = locations;
            Name = name;
            NetworkId = networkId;
            ResourcePresetId = resourcePresetId;
            ScalePolicies = scalePolicies;
            Status = status;
            StorageConfigs = storageConfigs;
            SubnetIds = subnetIds;
            TlsEnabled = tlsEnabled;
            YdbApiEndpoint = ydbApiEndpoint;
            YdbFullEndpoint = ydbFullEndpoint;
        }
    }
}
