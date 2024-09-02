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
    /// Manages a MongoDB cluster within the Yandex.Cloud. For more information, see
    /// [the official documentation](https://cloud.yandex.com/docs/managed-mongodb/concepts).
    /// 
    /// ## Example Usage
    /// 
    /// Example of creating a Single Node MongoDB.
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Yandex = Pulumi.Yandex;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var fooVpcNetwork = new Yandex.VpcNetwork("fooVpcNetwork");
    /// 
    ///     var fooVpcSubnet = new Yandex.VpcSubnet("fooVpcSubnet", new()
    ///     {
    ///         NetworkId = fooVpcNetwork.Id,
    ///         V4CidrBlocks = new[]
    ///         {
    ///             "10.1.0.0/24",
    ///         },
    ///         Zone = "ru-central1-a",
    ///     });
    /// 
    ///     var fooMdbMongodbCluster = new Yandex.MdbMongodbCluster("fooMdbMongodbCluster", new()
    ///     {
    ///         ClusterConfig = new Yandex.Inputs.MdbMongodbClusterClusterConfigArgs
    ///         {
    ///             Version = "4.2",
    ///         },
    ///         Databases = new[]
    ///         {
    ///             new Yandex.Inputs.MdbMongodbClusterDatabaseArgs
    ///             {
    ///                 Name = "testdb",
    ///             },
    ///         },
    ///         Environment = "PRESTABLE",
    ///         Hosts = new[]
    ///         {
    ///             new Yandex.Inputs.MdbMongodbClusterHostArgs
    ///             {
    ///                 SubnetId = fooVpcSubnet.Id,
    ///                 ZoneId = "ru-central1-a",
    ///             },
    ///         },
    ///         Labels = 
    ///         {
    ///             { "test_key", "test_value" },
    ///         },
    ///         MaintenanceWindow = new Yandex.Inputs.MdbMongodbClusterMaintenanceWindowArgs
    ///         {
    ///             Type = "ANYTIME",
    ///         },
    ///         NetworkId = fooVpcNetwork.Id,
    ///         ResourcesMongocfg = new Yandex.Inputs.MdbMongodbClusterResourcesMongocfgArgs
    ///         {
    ///             DiskSize = 14,
    ///             DiskTypeId = "network-hdd",
    ///             ResourcePresetId = "s2.small",
    ///         },
    ///         ResourcesMongod = new Yandex.Inputs.MdbMongodbClusterResourcesMongodArgs
    ///         {
    ///             DiskSize = 16,
    ///             DiskTypeId = "network-hdd",
    ///             ResourcePresetId = "s2.small",
    ///         },
    ///         ResourcesMongos = new Yandex.Inputs.MdbMongodbClusterResourcesMongosArgs
    ///         {
    ///             DiskSize = 14,
    ///             DiskTypeId = "network-hdd",
    ///             ResourcePresetId = "s2.small",
    ///         },
    ///         Users = new[]
    ///         {
    ///             new Yandex.Inputs.MdbMongodbClusterUserArgs
    ///             {
    ///                 Name = "john",
    ///                 Password = "password",
    ///                 Permissions = new[]
    ///                 {
    ///                     new Yandex.Inputs.MdbMongodbClusterUserPermissionArgs
    ///                     {
    ///                         DatabaseName = "testdb",
    ///                     },
    ///                 },
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// A cluster can be imported using the `id` of the resource, e.g.
    /// 
    /// ```sh
    /// $ pulumi import yandex:index/mdbMongodbCluster:MdbMongodbCluster foo cluster_id
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/mdbMongodbCluster:MdbMongodbCluster")]
    public partial class MdbMongodbCluster : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Configuration of the MongoDB subcluster. The structure is documented below.
        /// </summary>
        [Output("clusterConfig")]
        public Output<Outputs.MdbMongodbClusterClusterConfig> ClusterConfig { get; private set; } = null!;

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [Output("clusterId")]
        public Output<string> ClusterId { get; private set; } = null!;

        /// <summary>
        /// Creation timestamp of the key.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// A database of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Output("databases")]
        public Output<ImmutableArray<Outputs.MdbMongodbClusterDatabase>> Databases { get; private set; } = null!;

        /// <summary>
        /// Inhibits deletion of the cluster.  Can be either `true` or `false`.
        /// - - -
        /// </summary>
        [Output("deletionProtection")]
        public Output<bool> DeletionProtection { get; private set; } = null!;

        /// <summary>
        /// Description of the MongoDB cluster.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("diskSizeAutoscalingMongocfg")]
        public Output<Outputs.MdbMongodbClusterDiskSizeAutoscalingMongocfg> DiskSizeAutoscalingMongocfg { get; private set; } = null!;

        [Output("diskSizeAutoscalingMongod")]
        public Output<Outputs.MdbMongodbClusterDiskSizeAutoscalingMongod> DiskSizeAutoscalingMongod { get; private set; } = null!;

        [Output("diskSizeAutoscalingMongoinfra")]
        public Output<Outputs.MdbMongodbClusterDiskSizeAutoscalingMongoinfra> DiskSizeAutoscalingMongoinfra { get; private set; } = null!;

        [Output("diskSizeAutoscalingMongos")]
        public Output<Outputs.MdbMongodbClusterDiskSizeAutoscalingMongos> DiskSizeAutoscalingMongos { get; private set; } = null!;

        /// <summary>
        /// Deployment environment of the MongoDB cluster. Can be either `PRESTABLE` or `PRODUCTION`.
        /// </summary>
        [Output("environment")]
        public Output<string> Environment { get; private set; } = null!;

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// The health of the host.
        /// </summary>
        [Output("health")]
        public Output<string> Health { get; private set; } = null!;

        /// <summary>
        /// A host of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Output("hosts")]
        public Output<ImmutableArray<Outputs.MdbMongodbClusterHost>> Hosts { get; private set; } = null!;

        /// <summary>
        /// A set of key/value label pairs to assign to the MongoDB cluster.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>> Labels { get; private set; } = null!;

        /// <summary>
        /// Maintenance window settings of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Output("maintenanceWindow")]
        public Output<Outputs.MdbMongodbClusterMaintenanceWindow> MaintenanceWindow { get; private set; } = null!;

        /// <summary>
        /// Name of the MongoDB cluster. Provided by the client when the cluster is created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// ID of the network, to which the MongoDB cluster belongs.
        /// </summary>
        [Output("networkId")]
        public Output<string> NetworkId { get; private set; } = null!;

        /// <summary>
        /// Resources allocated to hosts of the MongoDB cluster. The structure is documented below.
        /// 
        /// - - -
        /// </summary>
        [Output("resources")]
        public Output<Outputs.MdbMongodbClusterResources?> Resources { get; private set; } = null!;

        /// <summary>
        /// Resources allocated to `mongocfg` hosts of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Output("resourcesMongocfg")]
        public Output<Outputs.MdbMongodbClusterResourcesMongocfg?> ResourcesMongocfg { get; private set; } = null!;

        /// <summary>
        /// Resources allocated to `mongod` hosts of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Output("resourcesMongod")]
        public Output<Outputs.MdbMongodbClusterResourcesMongod?> ResourcesMongod { get; private set; } = null!;

        /// <summary>
        /// Resources allocated to `mongoinfra` hosts of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Output("resourcesMongoinfra")]
        public Output<Outputs.MdbMongodbClusterResourcesMongoinfra?> ResourcesMongoinfra { get; private set; } = null!;

        /// <summary>
        /// Resources allocated to `mongos` hosts of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Output("resourcesMongos")]
        public Output<Outputs.MdbMongodbClusterResourcesMongos?> ResourcesMongos { get; private set; } = null!;

        /// <summary>
        /// The cluster will be created from the specified backup. The structure is documented below.
        /// 
        /// - - -
        /// </summary>
        [Output("restore")]
        public Output<Outputs.MdbMongodbClusterRestore?> Restore { get; private set; } = null!;

        /// <summary>
        /// A set of ids of security groups assigned to hosts of the cluster.
        /// </summary>
        [Output("securityGroupIds")]
        public Output<ImmutableArray<string>> SecurityGroupIds { get; private set; } = null!;

        /// <summary>
        /// MongoDB Cluster mode enabled/disabled.
        /// </summary>
        [Output("sharded")]
        public Output<bool> Sharded { get; private set; } = null!;

        /// <summary>
        /// Status of the cluster. Can be either `CREATING`, `STARTING`, `RUNNING`, `UPDATING`, `STOPPING`, `STOPPED`, `ERROR` or `STATUS_UNKNOWN`.
        /// For more information see `status` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-mongodb/api-ref/Cluster/).
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// A user of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Output("users")]
        public Output<ImmutableArray<Outputs.MdbMongodbClusterUser>> Users { get; private set; } = null!;


        /// <summary>
        /// Create a MdbMongodbCluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MdbMongodbCluster(string name, MdbMongodbClusterArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/mdbMongodbCluster:MdbMongodbCluster", name, args ?? new MdbMongodbClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MdbMongodbCluster(string name, Input<string> id, MdbMongodbClusterState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/mdbMongodbCluster:MdbMongodbCluster", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing MdbMongodbCluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MdbMongodbCluster Get(string name, Input<string> id, MdbMongodbClusterState? state = null, CustomResourceOptions? options = null)
        {
            return new MdbMongodbCluster(name, id, state, options);
        }
    }

    public sealed class MdbMongodbClusterArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration of the MongoDB subcluster. The structure is documented below.
        /// </summary>
        [Input("clusterConfig", required: true)]
        public Input<Inputs.MdbMongodbClusterClusterConfigArgs> ClusterConfig { get; set; } = null!;

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        [Input("databases")]
        private InputList<Inputs.MdbMongodbClusterDatabaseArgs>? _databases;

        /// <summary>
        /// A database of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Obsolete(@"to manage databases, please switch to using a separate resource type yandex_mdb_mongodb_database")]
        public InputList<Inputs.MdbMongodbClusterDatabaseArgs> Databases
        {
            get => _databases ?? (_databases = new InputList<Inputs.MdbMongodbClusterDatabaseArgs>());
            set => _databases = value;
        }

        /// <summary>
        /// Inhibits deletion of the cluster.  Can be either `true` or `false`.
        /// - - -
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// Description of the MongoDB cluster.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("diskSizeAutoscalingMongocfg")]
        public Input<Inputs.MdbMongodbClusterDiskSizeAutoscalingMongocfgArgs>? DiskSizeAutoscalingMongocfg { get; set; }

        [Input("diskSizeAutoscalingMongod")]
        public Input<Inputs.MdbMongodbClusterDiskSizeAutoscalingMongodArgs>? DiskSizeAutoscalingMongod { get; set; }

        [Input("diskSizeAutoscalingMongoinfra")]
        public Input<Inputs.MdbMongodbClusterDiskSizeAutoscalingMongoinfraArgs>? DiskSizeAutoscalingMongoinfra { get; set; }

        [Input("diskSizeAutoscalingMongos")]
        public Input<Inputs.MdbMongodbClusterDiskSizeAutoscalingMongosArgs>? DiskSizeAutoscalingMongos { get; set; }

        /// <summary>
        /// Deployment environment of the MongoDB cluster. Can be either `PRESTABLE` or `PRODUCTION`.
        /// </summary>
        [Input("environment", required: true)]
        public Input<string> Environment { get; set; } = null!;

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("hosts", required: true)]
        private InputList<Inputs.MdbMongodbClusterHostArgs>? _hosts;

        /// <summary>
        /// A host of the MongoDB cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbMongodbClusterHostArgs> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<Inputs.MdbMongodbClusterHostArgs>());
            set => _hosts = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the MongoDB cluster.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Maintenance window settings of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Input("maintenanceWindow")]
        public Input<Inputs.MdbMongodbClusterMaintenanceWindowArgs>? MaintenanceWindow { get; set; }

        /// <summary>
        /// Name of the MongoDB cluster. Provided by the client when the cluster is created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the network, to which the MongoDB cluster belongs.
        /// </summary>
        [Input("networkId", required: true)]
        public Input<string> NetworkId { get; set; } = null!;

        /// <summary>
        /// Resources allocated to hosts of the MongoDB cluster. The structure is documented below.
        /// 
        /// - - -
        /// </summary>
        [Input("resources")]
        public Input<Inputs.MdbMongodbClusterResourcesArgs>? Resources { get; set; }

        /// <summary>
        /// Resources allocated to `mongocfg` hosts of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Input("resourcesMongocfg")]
        public Input<Inputs.MdbMongodbClusterResourcesMongocfgArgs>? ResourcesMongocfg { get; set; }

        /// <summary>
        /// Resources allocated to `mongod` hosts of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Input("resourcesMongod")]
        public Input<Inputs.MdbMongodbClusterResourcesMongodArgs>? ResourcesMongod { get; set; }

        /// <summary>
        /// Resources allocated to `mongoinfra` hosts of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Input("resourcesMongoinfra")]
        public Input<Inputs.MdbMongodbClusterResourcesMongoinfraArgs>? ResourcesMongoinfra { get; set; }

        /// <summary>
        /// Resources allocated to `mongos` hosts of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Input("resourcesMongos")]
        public Input<Inputs.MdbMongodbClusterResourcesMongosArgs>? ResourcesMongos { get; set; }

        /// <summary>
        /// The cluster will be created from the specified backup. The structure is documented below.
        /// 
        /// - - -
        /// </summary>
        [Input("restore")]
        public Input<Inputs.MdbMongodbClusterRestoreArgs>? Restore { get; set; }

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;

        /// <summary>
        /// A set of ids of security groups assigned to hosts of the cluster.
        /// </summary>
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        [Input("users")]
        private InputList<Inputs.MdbMongodbClusterUserArgs>? _users;

        /// <summary>
        /// A user of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Obsolete(@"to manage users, please switch to using a separate resource type yandex_mdb_mongodb_user")]
        public InputList<Inputs.MdbMongodbClusterUserArgs> Users
        {
            get => _users ?? (_users = new InputList<Inputs.MdbMongodbClusterUserArgs>());
            set => _users = value;
        }

        public MdbMongodbClusterArgs()
        {
        }
        public static new MdbMongodbClusterArgs Empty => new MdbMongodbClusterArgs();
    }

    public sealed class MdbMongodbClusterState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration of the MongoDB subcluster. The structure is documented below.
        /// </summary>
        [Input("clusterConfig")]
        public Input<Inputs.MdbMongodbClusterClusterConfigGetArgs>? ClusterConfig { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        /// <summary>
        /// Creation timestamp of the key.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("databases")]
        private InputList<Inputs.MdbMongodbClusterDatabaseGetArgs>? _databases;

        /// <summary>
        /// A database of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Obsolete(@"to manage databases, please switch to using a separate resource type yandex_mdb_mongodb_database")]
        public InputList<Inputs.MdbMongodbClusterDatabaseGetArgs> Databases
        {
            get => _databases ?? (_databases = new InputList<Inputs.MdbMongodbClusterDatabaseGetArgs>());
            set => _databases = value;
        }

        /// <summary>
        /// Inhibits deletion of the cluster.  Can be either `true` or `false`.
        /// - - -
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// Description of the MongoDB cluster.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("diskSizeAutoscalingMongocfg")]
        public Input<Inputs.MdbMongodbClusterDiskSizeAutoscalingMongocfgGetArgs>? DiskSizeAutoscalingMongocfg { get; set; }

        [Input("diskSizeAutoscalingMongod")]
        public Input<Inputs.MdbMongodbClusterDiskSizeAutoscalingMongodGetArgs>? DiskSizeAutoscalingMongod { get; set; }

        [Input("diskSizeAutoscalingMongoinfra")]
        public Input<Inputs.MdbMongodbClusterDiskSizeAutoscalingMongoinfraGetArgs>? DiskSizeAutoscalingMongoinfra { get; set; }

        [Input("diskSizeAutoscalingMongos")]
        public Input<Inputs.MdbMongodbClusterDiskSizeAutoscalingMongosGetArgs>? DiskSizeAutoscalingMongos { get; set; }

        /// <summary>
        /// Deployment environment of the MongoDB cluster. Can be either `PRESTABLE` or `PRODUCTION`.
        /// </summary>
        [Input("environment")]
        public Input<string>? Environment { get; set; }

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// The health of the host.
        /// </summary>
        [Input("health")]
        public Input<string>? Health { get; set; }

        [Input("hosts")]
        private InputList<Inputs.MdbMongodbClusterHostGetArgs>? _hosts;

        /// <summary>
        /// A host of the MongoDB cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbMongodbClusterHostGetArgs> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<Inputs.MdbMongodbClusterHostGetArgs>());
            set => _hosts = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the MongoDB cluster.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Maintenance window settings of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Input("maintenanceWindow")]
        public Input<Inputs.MdbMongodbClusterMaintenanceWindowGetArgs>? MaintenanceWindow { get; set; }

        /// <summary>
        /// Name of the MongoDB cluster. Provided by the client when the cluster is created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the network, to which the MongoDB cluster belongs.
        /// </summary>
        [Input("networkId")]
        public Input<string>? NetworkId { get; set; }

        /// <summary>
        /// Resources allocated to hosts of the MongoDB cluster. The structure is documented below.
        /// 
        /// - - -
        /// </summary>
        [Input("resources")]
        public Input<Inputs.MdbMongodbClusterResourcesGetArgs>? Resources { get; set; }

        /// <summary>
        /// Resources allocated to `mongocfg` hosts of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Input("resourcesMongocfg")]
        public Input<Inputs.MdbMongodbClusterResourcesMongocfgGetArgs>? ResourcesMongocfg { get; set; }

        /// <summary>
        /// Resources allocated to `mongod` hosts of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Input("resourcesMongod")]
        public Input<Inputs.MdbMongodbClusterResourcesMongodGetArgs>? ResourcesMongod { get; set; }

        /// <summary>
        /// Resources allocated to `mongoinfra` hosts of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Input("resourcesMongoinfra")]
        public Input<Inputs.MdbMongodbClusterResourcesMongoinfraGetArgs>? ResourcesMongoinfra { get; set; }

        /// <summary>
        /// Resources allocated to `mongos` hosts of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Input("resourcesMongos")]
        public Input<Inputs.MdbMongodbClusterResourcesMongosGetArgs>? ResourcesMongos { get; set; }

        /// <summary>
        /// The cluster will be created from the specified backup. The structure is documented below.
        /// 
        /// - - -
        /// </summary>
        [Input("restore")]
        public Input<Inputs.MdbMongodbClusterRestoreGetArgs>? Restore { get; set; }

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;

        /// <summary>
        /// A set of ids of security groups assigned to hosts of the cluster.
        /// </summary>
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        /// <summary>
        /// MongoDB Cluster mode enabled/disabled.
        /// </summary>
        [Input("sharded")]
        public Input<bool>? Sharded { get; set; }

        /// <summary>
        /// Status of the cluster. Can be either `CREATING`, `STARTING`, `RUNNING`, `UPDATING`, `STOPPING`, `STOPPED`, `ERROR` or `STATUS_UNKNOWN`.
        /// For more information see `status` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-mongodb/api-ref/Cluster/).
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("users")]
        private InputList<Inputs.MdbMongodbClusterUserGetArgs>? _users;

        /// <summary>
        /// A user of the MongoDB cluster. The structure is documented below.
        /// </summary>
        [Obsolete(@"to manage users, please switch to using a separate resource type yandex_mdb_mongodb_user")]
        public InputList<Inputs.MdbMongodbClusterUserGetArgs> Users
        {
            get => _users ?? (_users = new InputList<Inputs.MdbMongodbClusterUserGetArgs>());
            set => _users = value;
        }

        public MdbMongodbClusterState()
        {
        }
        public static new MdbMongodbClusterState Empty => new MdbMongodbClusterState();
    }
}