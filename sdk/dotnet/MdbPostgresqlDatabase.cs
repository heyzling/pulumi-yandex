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
    /// Manages a PostgreSQL database within the Yandex.Cloud. For more information, see
    /// [the official documentation](https://cloud.yandex.com/docs/managed-postgresql/).
    /// 
    /// ## Example Usage
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
    ///         Zone = "ru-central1-a",
    ///         NetworkId = fooVpcNetwork.Id,
    ///         V4CidrBlocks = new[]
    ///         {
    ///             "10.5.0.0/24",
    ///         },
    ///     });
    /// 
    ///     var fooMdbPostgresqlCluster = new Yandex.MdbPostgresqlCluster("fooMdbPostgresqlCluster", new()
    ///     {
    ///         Environment = "PRESTABLE",
    ///         NetworkId = fooVpcNetwork.Id,
    ///         Config = new Yandex.Inputs.MdbPostgresqlClusterConfigArgs
    ///         {
    ///             Version = "15",
    ///             Resources = new Yandex.Inputs.MdbPostgresqlClusterConfigResourcesArgs
    ///             {
    ///                 ResourcePresetId = "s2.micro",
    ///                 DiskTypeId = "network-ssd",
    ///                 DiskSize = 16,
    ///             },
    ///         },
    ///         Hosts = new[]
    ///         {
    ///             new Yandex.Inputs.MdbPostgresqlClusterHostArgs
    ///             {
    ///                 Zone = "ru-central1-a",
    ///                 SubnetId = fooVpcSubnet.Id,
    ///             },
    ///         },
    ///     });
    /// 
    ///     var fooMdbPostgresqlDatabase = new Yandex.MdbPostgresqlDatabase("fooMdbPostgresqlDatabase", new()
    ///     {
    ///         ClusterId = fooMdbPostgresqlCluster.Id,
    ///         Owner = yandex_mdb_postgresql_user.Alice.Name,
    ///         LcCollate = "en_US.UTF-8",
    ///         LcType = "en_US.UTF-8",
    ///         Extensions = new[]
    ///         {
    ///             new Yandex.Inputs.MdbPostgresqlDatabaseExtensionArgs
    ///             {
    ///                 Name = "uuid-ossp",
    ///             },
    ///             new Yandex.Inputs.MdbPostgresqlDatabaseExtensionArgs
    ///             {
    ///                 Name = "xml2",
    ///             },
    ///         },
    ///     });
    /// 
    ///     var fooMdbPostgresqlUser = new Yandex.MdbPostgresqlUser("fooMdbPostgresqlUser", new()
    ///     {
    ///         ClusterId = fooMdbPostgresqlCluster.Id,
    ///         Password = "password",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// A PostgreSQL database can be imported using the following format:
    /// 
    /// ```sh
    /// $ pulumi import yandex:index/mdbPostgresqlDatabase:MdbPostgresqlDatabase foo {{cluster_id}}:{{database_name}}
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/mdbPostgresqlDatabase:MdbPostgresqlDatabase")]
    public partial class MdbPostgresqlDatabase : global::Pulumi.CustomResource
    {
        [Output("clusterId")]
        public Output<string> ClusterId { get; private set; } = null!;

        /// <summary>
        /// Inhibits deletion of the database. Can either be `true`, `false` or `unspecified`.
        /// </summary>
        [Output("deletionProtection")]
        public Output<string?> DeletionProtection { get; private set; } = null!;

        /// <summary>
        /// Set of database extensions. The structure is documented below
        /// </summary>
        [Output("extensions")]
        public Output<ImmutableArray<Outputs.MdbPostgresqlDatabaseExtension>> Extensions { get; private set; } = null!;

        /// <summary>
        /// POSIX locale for string sorting order. Forbidden to change in an existing database.
        /// </summary>
        [Output("lcCollate")]
        public Output<string?> LcCollate { get; private set; } = null!;

        /// <summary>
        /// POSIX locale for character classification. Forbidden to change in an existing database.
        /// </summary>
        [Output("lcType")]
        public Output<string?> LcType { get; private set; } = null!;

        /// <summary>
        /// The name of the database.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Name of the user assigned as the owner of the database. Forbidden to change in an existing database.
        /// </summary>
        [Output("owner")]
        public Output<string> Owner { get; private set; } = null!;

        /// <summary>
        /// Name of the template database.
        /// </summary>
        [Output("templateDb")]
        public Output<string?> TemplateDb { get; private set; } = null!;


        /// <summary>
        /// Create a MdbPostgresqlDatabase resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MdbPostgresqlDatabase(string name, MdbPostgresqlDatabaseArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/mdbPostgresqlDatabase:MdbPostgresqlDatabase", name, args ?? new MdbPostgresqlDatabaseArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MdbPostgresqlDatabase(string name, Input<string> id, MdbPostgresqlDatabaseState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/mdbPostgresqlDatabase:MdbPostgresqlDatabase", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing MdbPostgresqlDatabase resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MdbPostgresqlDatabase Get(string name, Input<string> id, MdbPostgresqlDatabaseState? state = null, CustomResourceOptions? options = null)
        {
            return new MdbPostgresqlDatabase(name, id, state, options);
        }
    }

    public sealed class MdbPostgresqlDatabaseArgs : global::Pulumi.ResourceArgs
    {
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        /// <summary>
        /// Inhibits deletion of the database. Can either be `true`, `false` or `unspecified`.
        /// </summary>
        [Input("deletionProtection")]
        public Input<string>? DeletionProtection { get; set; }

        [Input("extensions")]
        private InputList<Inputs.MdbPostgresqlDatabaseExtensionArgs>? _extensions;

        /// <summary>
        /// Set of database extensions. The structure is documented below
        /// </summary>
        public InputList<Inputs.MdbPostgresqlDatabaseExtensionArgs> Extensions
        {
            get => _extensions ?? (_extensions = new InputList<Inputs.MdbPostgresqlDatabaseExtensionArgs>());
            set => _extensions = value;
        }

        /// <summary>
        /// POSIX locale for string sorting order. Forbidden to change in an existing database.
        /// </summary>
        [Input("lcCollate")]
        public Input<string>? LcCollate { get; set; }

        /// <summary>
        /// POSIX locale for character classification. Forbidden to change in an existing database.
        /// </summary>
        [Input("lcType")]
        public Input<string>? LcType { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Name of the user assigned as the owner of the database. Forbidden to change in an existing database.
        /// </summary>
        [Input("owner", required: true)]
        public Input<string> Owner { get; set; } = null!;

        /// <summary>
        /// Name of the template database.
        /// </summary>
        [Input("templateDb")]
        public Input<string>? TemplateDb { get; set; }

        public MdbPostgresqlDatabaseArgs()
        {
        }
        public static new MdbPostgresqlDatabaseArgs Empty => new MdbPostgresqlDatabaseArgs();
    }

    public sealed class MdbPostgresqlDatabaseState : global::Pulumi.ResourceArgs
    {
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        /// <summary>
        /// Inhibits deletion of the database. Can either be `true`, `false` or `unspecified`.
        /// </summary>
        [Input("deletionProtection")]
        public Input<string>? DeletionProtection { get; set; }

        [Input("extensions")]
        private InputList<Inputs.MdbPostgresqlDatabaseExtensionGetArgs>? _extensions;

        /// <summary>
        /// Set of database extensions. The structure is documented below
        /// </summary>
        public InputList<Inputs.MdbPostgresqlDatabaseExtensionGetArgs> Extensions
        {
            get => _extensions ?? (_extensions = new InputList<Inputs.MdbPostgresqlDatabaseExtensionGetArgs>());
            set => _extensions = value;
        }

        /// <summary>
        /// POSIX locale for string sorting order. Forbidden to change in an existing database.
        /// </summary>
        [Input("lcCollate")]
        public Input<string>? LcCollate { get; set; }

        /// <summary>
        /// POSIX locale for character classification. Forbidden to change in an existing database.
        /// </summary>
        [Input("lcType")]
        public Input<string>? LcType { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Name of the user assigned as the owner of the database. Forbidden to change in an existing database.
        /// </summary>
        [Input("owner")]
        public Input<string>? Owner { get; set; }

        /// <summary>
        /// Name of the template database.
        /// </summary>
        [Input("templateDb")]
        public Input<string>? TemplateDb { get; set; }

        public MdbPostgresqlDatabaseState()
        {
        }
        public static new MdbPostgresqlDatabaseState Empty => new MdbPostgresqlDatabaseState();
    }
}
