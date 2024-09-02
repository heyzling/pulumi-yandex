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
    /// Manages a user of a Kafka cluster within the Yandex.Cloud. For more information, see
    /// [the official documentation](https://cloud.yandex.com/docs/managed-kafka/concepts).
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
    ///     var foo = new Yandex.MdbKafkaCluster("foo", new()
    ///     {
    ///         NetworkId = "c64vs98keiqc7f24pvkd",
    ///         Config = new Yandex.Inputs.MdbKafkaClusterConfigArgs
    ///         {
    ///             Version = "2.8",
    ///             Zones = new[]
    ///             {
    ///                 "ru-central1-a",
    ///             },
    ///             Kafka = new Yandex.Inputs.MdbKafkaClusterConfigKafkaArgs
    ///             {
    ///                 Resources = new Yandex.Inputs.MdbKafkaClusterConfigKafkaResourcesArgs
    ///                 {
    ///                     ResourcePresetId = "s2.micro",
    ///                     DiskTypeId = "network-hdd",
    ///                     DiskSize = 16,
    ///                 },
    ///             },
    ///         },
    ///     });
    /// 
    ///     var events = new Yandex.MdbKafkaTopic("events", new()
    ///     {
    ///         ClusterId = foo.Id,
    ///         Partitions = 4,
    ///         ReplicationFactor = 1,
    ///     });
    /// 
    ///     var userEvents = new Yandex.MdbKafkaUser("userEvents", new()
    ///     {
    ///         ClusterId = foo.Id,
    ///         Password = "pass1231232332",
    ///         Permissions = new[]
    ///         {
    ///             new Yandex.Inputs.MdbKafkaUserPermissionArgs
    ///             {
    ///                 TopicName = "events",
    ///                 Role = "ACCESS_ROLE_CONSUMER",
    ///                 AllowHosts = new[]
    ///                 {
    ///                     "host1.db.yandex.net",
    ///                     "host2.db.yandex.net",
    ///                 },
    ///             },
    ///             new Yandex.Inputs.MdbKafkaUserPermissionArgs
    ///             {
    ///                 TopicName = "events",
    ///                 Role = "ACCESS_ROLE_PRODUCER",
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
    /// Kafka user can be imported using following format:
    /// 
    /// ```sh
    /// $ pulumi import yandex:index/mdbKafkaUser:MdbKafkaUser foo {{cluster_id}}:{{user_name}}
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/mdbKafkaUser:MdbKafkaUser")]
    public partial class MdbKafkaUser : global::Pulumi.CustomResource
    {
        [Output("clusterId")]
        public Output<string> ClusterId { get; private set; } = null!;

        /// <summary>
        /// The name of the user.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The password of the user.
        /// </summary>
        [Output("password")]
        public Output<string> Password { get; private set; } = null!;

        /// <summary>
        /// Set of permissions granted to the user. The structure is documented below.
        /// </summary>
        [Output("permissions")]
        public Output<ImmutableArray<Outputs.MdbKafkaUserPermission>> Permissions { get; private set; } = null!;


        /// <summary>
        /// Create a MdbKafkaUser resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MdbKafkaUser(string name, MdbKafkaUserArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/mdbKafkaUser:MdbKafkaUser", name, args ?? new MdbKafkaUserArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MdbKafkaUser(string name, Input<string> id, MdbKafkaUserState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/mdbKafkaUser:MdbKafkaUser", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/heyzling/pulumi-yandex/releases/",
                AdditionalSecretOutputs =
                {
                    "password",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing MdbKafkaUser resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MdbKafkaUser Get(string name, Input<string> id, MdbKafkaUserState? state = null, CustomResourceOptions? options = null)
        {
            return new MdbKafkaUser(name, id, state, options);
        }
    }

    public sealed class MdbKafkaUserArgs : global::Pulumi.ResourceArgs
    {
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        /// <summary>
        /// The name of the user.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("password", required: true)]
        private Input<string>? _password;

        /// <summary>
        /// The password of the user.
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("permissions")]
        private InputList<Inputs.MdbKafkaUserPermissionArgs>? _permissions;

        /// <summary>
        /// Set of permissions granted to the user. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbKafkaUserPermissionArgs> Permissions
        {
            get => _permissions ?? (_permissions = new InputList<Inputs.MdbKafkaUserPermissionArgs>());
            set => _permissions = value;
        }

        public MdbKafkaUserArgs()
        {
        }
        public static new MdbKafkaUserArgs Empty => new MdbKafkaUserArgs();
    }

    public sealed class MdbKafkaUserState : global::Pulumi.ResourceArgs
    {
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        /// <summary>
        /// The name of the user.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("password")]
        private Input<string>? _password;

        /// <summary>
        /// The password of the user.
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("permissions")]
        private InputList<Inputs.MdbKafkaUserPermissionGetArgs>? _permissions;

        /// <summary>
        /// Set of permissions granted to the user. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbKafkaUserPermissionGetArgs> Permissions
        {
            get => _permissions ?? (_permissions = new InputList<Inputs.MdbKafkaUserPermissionGetArgs>());
            set => _permissions = value;
        }

        public MdbKafkaUserState()
        {
        }
        public static new MdbKafkaUserState Empty => new MdbKafkaUserState();
    }
}