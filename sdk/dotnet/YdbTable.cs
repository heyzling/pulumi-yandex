// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    /// <summary>
    /// Yandex Database table resource.
    /// </summary>
    [YandexResourceType("yandex:index/ydbTable:YdbTable")]
    public partial class YdbTable : global::Pulumi.CustomResource
    {
        /// <summary>
        /// A map of table attributes.
        /// </summary>
        [Output("attributes")]
        public Output<ImmutableDictionary<string, string>> Attributes { get; private set; } = null!;

        /// <summary>
        /// A list of column configuration options.
        /// The structure is documented below.
        /// </summary>
        [Output("columns")]
        public Output<ImmutableArray<Outputs.YdbTableColumn>> Columns { get; private set; } = null!;

        /// <summary>
        /// Connection string for database.
        /// </summary>
        [Output("connectionString")]
        public Output<string> ConnectionString { get; private set; } = null!;

        /// <summary>
        /// A list of column group configuration options.
        /// The structure is documented below.
        /// </summary>
        [Output("families")]
        public Output<ImmutableArray<Outputs.YdbTableFamily>> Families { get; private set; } = null!;

        /// <summary>
        /// Use the Bloom filter for the primary key
        /// </summary>
        [Output("keyBloomFilter")]
        public Output<bool> KeyBloomFilter { get; private set; } = null!;

        /// <summary>
        /// Table partiotioning settings
        /// The structure is documented below.
        /// </summary>
        [Output("partitioningSettings")]
        public Output<Outputs.YdbTablePartitioningSettings> PartitioningSettings { get; private set; } = null!;

        /// <summary>
        /// Table path.
        /// </summary>
        [Output("path")]
        public Output<string> Path { get; private set; } = null!;

        /// <summary>
        /// A list of table columns to be uased as primary key.
        /// </summary>
        [Output("primaryKeys")]
        public Output<ImmutableArray<string>> PrimaryKeys { get; private set; } = null!;

        /// <summary>
        /// Read replication settings
        /// </summary>
        [Output("readReplicasSettings")]
        public Output<string> ReadReplicasSettings { get; private set; } = null!;

        /// <summary>
        /// ttl		TTL settings
        /// The structure is documented below.
        /// </summary>
        [Output("ttl")]
        public Output<Outputs.YdbTableTtl?> Ttl { get; private set; } = null!;


        /// <summary>
        /// Create a YdbTable resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public YdbTable(string name, YdbTableArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/ydbTable:YdbTable", name, args ?? new YdbTableArgs(), MakeResourceOptions(options, ""))
        {
        }

        private YdbTable(string name, Input<string> id, YdbTableState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/ydbTable:YdbTable", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/heyzling/pulumi-yandex/releases/",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing YdbTable resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static YdbTable Get(string name, Input<string> id, YdbTableState? state = null, CustomResourceOptions? options = null)
        {
            return new YdbTable(name, id, state, options);
        }
    }

    public sealed class YdbTableArgs : global::Pulumi.ResourceArgs
    {
        [Input("attributes")]
        private InputMap<string>? _attributes;

        /// <summary>
        /// A map of table attributes.
        /// </summary>
        public InputMap<string> Attributes
        {
            get => _attributes ?? (_attributes = new InputMap<string>());
            set => _attributes = value;
        }

        [Input("columns", required: true)]
        private InputList<Inputs.YdbTableColumnArgs>? _columns;

        /// <summary>
        /// A list of column configuration options.
        /// The structure is documented below.
        /// </summary>
        public InputList<Inputs.YdbTableColumnArgs> Columns
        {
            get => _columns ?? (_columns = new InputList<Inputs.YdbTableColumnArgs>());
            set => _columns = value;
        }

        /// <summary>
        /// Connection string for database.
        /// </summary>
        [Input("connectionString", required: true)]
        public Input<string> ConnectionString { get; set; } = null!;

        [Input("families")]
        private InputList<Inputs.YdbTableFamilyArgs>? _families;

        /// <summary>
        /// A list of column group configuration options.
        /// The structure is documented below.
        /// </summary>
        public InputList<Inputs.YdbTableFamilyArgs> Families
        {
            get => _families ?? (_families = new InputList<Inputs.YdbTableFamilyArgs>());
            set => _families = value;
        }

        /// <summary>
        /// Use the Bloom filter for the primary key
        /// </summary>
        [Input("keyBloomFilter")]
        public Input<bool>? KeyBloomFilter { get; set; }

        /// <summary>
        /// Table partiotioning settings
        /// The structure is documented below.
        /// </summary>
        [Input("partitioningSettings")]
        public Input<Inputs.YdbTablePartitioningSettingsArgs>? PartitioningSettings { get; set; }

        /// <summary>
        /// Table path.
        /// </summary>
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        [Input("primaryKeys", required: true)]
        private InputList<string>? _primaryKeys;

        /// <summary>
        /// A list of table columns to be uased as primary key.
        /// </summary>
        public InputList<string> PrimaryKeys
        {
            get => _primaryKeys ?? (_primaryKeys = new InputList<string>());
            set => _primaryKeys = value;
        }

        /// <summary>
        /// Read replication settings
        /// </summary>
        [Input("readReplicasSettings")]
        public Input<string>? ReadReplicasSettings { get; set; }

        /// <summary>
        /// ttl		TTL settings
        /// The structure is documented below.
        /// </summary>
        [Input("ttl")]
        public Input<Inputs.YdbTableTtlArgs>? Ttl { get; set; }

        public YdbTableArgs()
        {
        }
        public static new YdbTableArgs Empty => new YdbTableArgs();
    }

    public sealed class YdbTableState : global::Pulumi.ResourceArgs
    {
        [Input("attributes")]
        private InputMap<string>? _attributes;

        /// <summary>
        /// A map of table attributes.
        /// </summary>
        public InputMap<string> Attributes
        {
            get => _attributes ?? (_attributes = new InputMap<string>());
            set => _attributes = value;
        }

        [Input("columns")]
        private InputList<Inputs.YdbTableColumnGetArgs>? _columns;

        /// <summary>
        /// A list of column configuration options.
        /// The structure is documented below.
        /// </summary>
        public InputList<Inputs.YdbTableColumnGetArgs> Columns
        {
            get => _columns ?? (_columns = new InputList<Inputs.YdbTableColumnGetArgs>());
            set => _columns = value;
        }

        /// <summary>
        /// Connection string for database.
        /// </summary>
        [Input("connectionString")]
        public Input<string>? ConnectionString { get; set; }

        [Input("families")]
        private InputList<Inputs.YdbTableFamilyGetArgs>? _families;

        /// <summary>
        /// A list of column group configuration options.
        /// The structure is documented below.
        /// </summary>
        public InputList<Inputs.YdbTableFamilyGetArgs> Families
        {
            get => _families ?? (_families = new InputList<Inputs.YdbTableFamilyGetArgs>());
            set => _families = value;
        }

        /// <summary>
        /// Use the Bloom filter for the primary key
        /// </summary>
        [Input("keyBloomFilter")]
        public Input<bool>? KeyBloomFilter { get; set; }

        /// <summary>
        /// Table partiotioning settings
        /// The structure is documented below.
        /// </summary>
        [Input("partitioningSettings")]
        public Input<Inputs.YdbTablePartitioningSettingsGetArgs>? PartitioningSettings { get; set; }

        /// <summary>
        /// Table path.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        [Input("primaryKeys")]
        private InputList<string>? _primaryKeys;

        /// <summary>
        /// A list of table columns to be uased as primary key.
        /// </summary>
        public InputList<string> PrimaryKeys
        {
            get => _primaryKeys ?? (_primaryKeys = new InputList<string>());
            set => _primaryKeys = value;
        }

        /// <summary>
        /// Read replication settings
        /// </summary>
        [Input("readReplicasSettings")]
        public Input<string>? ReadReplicasSettings { get; set; }

        /// <summary>
        /// ttl		TTL settings
        /// The structure is documented below.
        /// </summary>
        [Input("ttl")]
        public Input<Inputs.YdbTableTtlGetArgs>? Ttl { get; set; }

        public YdbTableState()
        {
        }
        public static new YdbTableState Empty => new YdbTableState();
    }
}