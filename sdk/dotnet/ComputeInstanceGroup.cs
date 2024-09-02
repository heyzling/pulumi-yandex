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
    /// An Instance group resource. For more information, see
    /// [the official documentation](https://cloud.yandex.com/docs/compute/concepts/instance-groups/).
    /// 
    /// ## Example Usage
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.IO;
    /// using System.Linq;
    /// using Pulumi;
    /// using Yandex = Pulumi.Yandex;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var group1 = new Yandex.ComputeInstanceGroup("group1", new()
    ///     {
    ///         AllocationPolicy = new Yandex.Inputs.ComputeInstanceGroupAllocationPolicyArgs
    ///         {
    ///             Zones = new[]
    ///             {
    ///                 "ru-central1-a",
    ///             },
    ///         },
    ///         DeletionProtection = true,
    ///         DeployPolicy = new Yandex.Inputs.ComputeInstanceGroupDeployPolicyArgs
    ///         {
    ///             MaxCreating = 2,
    ///             MaxDeleting = 2,
    ///             MaxExpansion = 2,
    ///             MaxUnavailable = 2,
    ///         },
    ///         FolderId = data.Yandex_resourcemanager_folder.Test_folder.Id,
    ///         InstanceTemplate = new Yandex.Inputs.ComputeInstanceGroupInstanceTemplateArgs
    ///         {
    ///             BootDisk = new Yandex.Inputs.ComputeInstanceGroupInstanceTemplateBootDiskArgs
    ///             {
    ///                 InitializeParams = new Yandex.Inputs.ComputeInstanceGroupInstanceTemplateBootDiskInitializeParamsArgs
    ///                 {
    ///                     ImageId = data.Yandex_compute_image.Ubuntu.Id,
    ///                     Size = 4,
    ///                 },
    ///                 Mode = "READ_WRITE",
    ///             },
    ///             Labels = 
    ///             {
    ///                 { "label1", "label1-value" },
    ///                 { "label2", "label2-value" },
    ///             },
    ///             Metadata = 
    ///             {
    ///                 { "foo", "bar" },
    ///                 { "ssh-keys", $"ubuntu:{File.ReadAllText("~/.ssh/id_rsa.pub")}" },
    ///             },
    ///             NetworkInterfaces = new[]
    ///             {
    ///                 new Yandex.Inputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceArgs
    ///                 {
    ///                     NetworkId = yandex_vpc_network.My_inst_group_network.Id,
    ///                     SubnetIds = new[]
    ///                     {
    ///                         yandex_vpc_subnet.My_inst_group_subnet.Id,
    ///                     },
    ///                 },
    ///             },
    ///             NetworkSettings = new[]
    ///             {
    ///                 new Yandex.Inputs.ComputeInstanceGroupInstanceTemplateNetworkSettingArgs
    ///                 {
    ///                     Type = "STANDARD",
    ///                 },
    ///             },
    ///             PlatformId = "standard-v1",
    ///             Resources = new Yandex.Inputs.ComputeInstanceGroupInstanceTemplateResourcesArgs
    ///             {
    ///                 Cores = 2,
    ///                 Memory = 2,
    ///             },
    ///         },
    ///         ScalePolicy = new Yandex.Inputs.ComputeInstanceGroupScalePolicyArgs
    ///         {
    ///             FixedScale = new Yandex.Inputs.ComputeInstanceGroupScalePolicyFixedScaleArgs
    ///             {
    ///                 Size = 3,
    ///             },
    ///         },
    ///         ServiceAccountId = yandex_iam_service_account.Test_account.Id,
    ///         Variables = 
    ///         {
    ///             { "test_key1", "test_value1" },
    ///             { "test_key2", "test_value2" },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [YandexResourceType("yandex:index/computeInstanceGroup:ComputeInstanceGroup")]
    public partial class ComputeInstanceGroup : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The allocation policy of the instance group by zone and region. The structure is documented below.
        /// </summary>
        [Output("allocationPolicy")]
        public Output<Outputs.ComputeInstanceGroupAllocationPolicy> AllocationPolicy { get; private set; } = null!;

        /// <summary>
        /// Application Load balancing (L7) specifications. The structure is documented below.
        /// </summary>
        [Output("applicationLoadBalancer")]
        public Output<Outputs.ComputeInstanceGroupApplicationLoadBalancer?> ApplicationLoadBalancer { get; private set; } = null!;

        /// <summary>
        /// The instance group creation timestamp.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// Flag that protects the instance group from accidental deletion.
        /// </summary>
        [Output("deletionProtection")]
        public Output<bool?> DeletionProtection { get; private set; } = null!;

        /// <summary>
        /// The deployment policy of the instance group. The structure is documented below.
        /// </summary>
        [Output("deployPolicy")]
        public Output<Outputs.ComputeInstanceGroupDeployPolicy> DeployPolicy { get; private set; } = null!;

        /// <summary>
        /// A description of the instance group.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The ID of the folder that the resources belong to.
        /// </summary>
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// Health check specifications. The structure is documented below.
        /// </summary>
        [Output("healthChecks")]
        public Output<ImmutableArray<Outputs.ComputeInstanceGroupHealthCheck>> HealthChecks { get; private set; } = null!;

        /// <summary>
        /// The template for creating new instances. The structure is documented below.
        /// </summary>
        [Output("instanceTemplate")]
        public Output<Outputs.ComputeInstanceGroupInstanceTemplate> InstanceTemplate { get; private set; } = null!;

        [Output("instances")]
        public Output<ImmutableArray<Outputs.ComputeInstanceGroupInstance>> Instances { get; private set; } = null!;

        /// <summary>
        /// A set of key/value label pairs to assign to the instance group.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// Load balancing specifications. The structure is documented below.
        /// </summary>
        [Output("loadBalancer")]
        public Output<Outputs.ComputeInstanceGroupLoadBalancer?> LoadBalancer { get; private set; } = null!;

        /// <summary>
        /// Timeout for waiting for the VM to become healthy. If the timeout is exceeded, the VM will be turned off based on the deployment policy. Specified in seconds.
        /// </summary>
        [Output("maxCheckingHealthDuration")]
        public Output<int?> MaxCheckingHealthDuration { get; private set; } = null!;

        /// <summary>
        /// The name of the instance group.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The scaling policy of the instance group. The structure is documented below.
        /// </summary>
        [Output("scalePolicy")]
        public Output<Outputs.ComputeInstanceGroupScalePolicy> ScalePolicy { get; private set; } = null!;

        /// <summary>
        /// The ID of the service account authorized for this instance group.
        /// </summary>
        [Output("serviceAccountId")]
        public Output<string> ServiceAccountId { get; private set; } = null!;

        /// <summary>
        /// The status of the instance.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// A set of key/value  variables pairs to assign to the instance group.
        /// </summary>
        [Output("variables")]
        public Output<ImmutableDictionary<string, string>?> Variables { get; private set; } = null!;


        /// <summary>
        /// Create a ComputeInstanceGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ComputeInstanceGroup(string name, ComputeInstanceGroupArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/computeInstanceGroup:ComputeInstanceGroup", name, args ?? new ComputeInstanceGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ComputeInstanceGroup(string name, Input<string> id, ComputeInstanceGroupState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/computeInstanceGroup:ComputeInstanceGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ComputeInstanceGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ComputeInstanceGroup Get(string name, Input<string> id, ComputeInstanceGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new ComputeInstanceGroup(name, id, state, options);
        }
    }

    public sealed class ComputeInstanceGroupArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The allocation policy of the instance group by zone and region. The structure is documented below.
        /// </summary>
        [Input("allocationPolicy", required: true)]
        public Input<Inputs.ComputeInstanceGroupAllocationPolicyArgs> AllocationPolicy { get; set; } = null!;

        /// <summary>
        /// Application Load balancing (L7) specifications. The structure is documented below.
        /// </summary>
        [Input("applicationLoadBalancer")]
        public Input<Inputs.ComputeInstanceGroupApplicationLoadBalancerArgs>? ApplicationLoadBalancer { get; set; }

        /// <summary>
        /// Flag that protects the instance group from accidental deletion.
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// The deployment policy of the instance group. The structure is documented below.
        /// </summary>
        [Input("deployPolicy", required: true)]
        public Input<Inputs.ComputeInstanceGroupDeployPolicyArgs> DeployPolicy { get; set; } = null!;

        /// <summary>
        /// A description of the instance group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The ID of the folder that the resources belong to.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("healthChecks")]
        private InputList<Inputs.ComputeInstanceGroupHealthCheckArgs>? _healthChecks;

        /// <summary>
        /// Health check specifications. The structure is documented below.
        /// </summary>
        public InputList<Inputs.ComputeInstanceGroupHealthCheckArgs> HealthChecks
        {
            get => _healthChecks ?? (_healthChecks = new InputList<Inputs.ComputeInstanceGroupHealthCheckArgs>());
            set => _healthChecks = value;
        }

        /// <summary>
        /// The template for creating new instances. The structure is documented below.
        /// </summary>
        [Input("instanceTemplate", required: true)]
        public Input<Inputs.ComputeInstanceGroupInstanceTemplateArgs> InstanceTemplate { get; set; } = null!;

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the instance group.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Load balancing specifications. The structure is documented below.
        /// </summary>
        [Input("loadBalancer")]
        public Input<Inputs.ComputeInstanceGroupLoadBalancerArgs>? LoadBalancer { get; set; }

        /// <summary>
        /// Timeout for waiting for the VM to become healthy. If the timeout is exceeded, the VM will be turned off based on the deployment policy. Specified in seconds.
        /// </summary>
        [Input("maxCheckingHealthDuration")]
        public Input<int>? MaxCheckingHealthDuration { get; set; }

        /// <summary>
        /// The name of the instance group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The scaling policy of the instance group. The structure is documented below.
        /// </summary>
        [Input("scalePolicy", required: true)]
        public Input<Inputs.ComputeInstanceGroupScalePolicyArgs> ScalePolicy { get; set; } = null!;

        /// <summary>
        /// The ID of the service account authorized for this instance group.
        /// </summary>
        [Input("serviceAccountId", required: true)]
        public Input<string> ServiceAccountId { get; set; } = null!;

        [Input("variables")]
        private InputMap<string>? _variables;

        /// <summary>
        /// A set of key/value  variables pairs to assign to the instance group.
        /// </summary>
        public InputMap<string> Variables
        {
            get => _variables ?? (_variables = new InputMap<string>());
            set => _variables = value;
        }

        public ComputeInstanceGroupArgs()
        {
        }
        public static new ComputeInstanceGroupArgs Empty => new ComputeInstanceGroupArgs();
    }

    public sealed class ComputeInstanceGroupState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The allocation policy of the instance group by zone and region. The structure is documented below.
        /// </summary>
        [Input("allocationPolicy")]
        public Input<Inputs.ComputeInstanceGroupAllocationPolicyGetArgs>? AllocationPolicy { get; set; }

        /// <summary>
        /// Application Load balancing (L7) specifications. The structure is documented below.
        /// </summary>
        [Input("applicationLoadBalancer")]
        public Input<Inputs.ComputeInstanceGroupApplicationLoadBalancerGetArgs>? ApplicationLoadBalancer { get; set; }

        /// <summary>
        /// The instance group creation timestamp.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// Flag that protects the instance group from accidental deletion.
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// The deployment policy of the instance group. The structure is documented below.
        /// </summary>
        [Input("deployPolicy")]
        public Input<Inputs.ComputeInstanceGroupDeployPolicyGetArgs>? DeployPolicy { get; set; }

        /// <summary>
        /// A description of the instance group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The ID of the folder that the resources belong to.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("healthChecks")]
        private InputList<Inputs.ComputeInstanceGroupHealthCheckGetArgs>? _healthChecks;

        /// <summary>
        /// Health check specifications. The structure is documented below.
        /// </summary>
        public InputList<Inputs.ComputeInstanceGroupHealthCheckGetArgs> HealthChecks
        {
            get => _healthChecks ?? (_healthChecks = new InputList<Inputs.ComputeInstanceGroupHealthCheckGetArgs>());
            set => _healthChecks = value;
        }

        /// <summary>
        /// The template for creating new instances. The structure is documented below.
        /// </summary>
        [Input("instanceTemplate")]
        public Input<Inputs.ComputeInstanceGroupInstanceTemplateGetArgs>? InstanceTemplate { get; set; }

        [Input("instances")]
        private InputList<Inputs.ComputeInstanceGroupInstanceGetArgs>? _instances;
        public InputList<Inputs.ComputeInstanceGroupInstanceGetArgs> Instances
        {
            get => _instances ?? (_instances = new InputList<Inputs.ComputeInstanceGroupInstanceGetArgs>());
            set => _instances = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the instance group.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Load balancing specifications. The structure is documented below.
        /// </summary>
        [Input("loadBalancer")]
        public Input<Inputs.ComputeInstanceGroupLoadBalancerGetArgs>? LoadBalancer { get; set; }

        /// <summary>
        /// Timeout for waiting for the VM to become healthy. If the timeout is exceeded, the VM will be turned off based on the deployment policy. Specified in seconds.
        /// </summary>
        [Input("maxCheckingHealthDuration")]
        public Input<int>? MaxCheckingHealthDuration { get; set; }

        /// <summary>
        /// The name of the instance group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The scaling policy of the instance group. The structure is documented below.
        /// </summary>
        [Input("scalePolicy")]
        public Input<Inputs.ComputeInstanceGroupScalePolicyGetArgs>? ScalePolicy { get; set; }

        /// <summary>
        /// The ID of the service account authorized for this instance group.
        /// </summary>
        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        /// <summary>
        /// The status of the instance.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("variables")]
        private InputMap<string>? _variables;

        /// <summary>
        /// A set of key/value  variables pairs to assign to the instance group.
        /// </summary>
        public InputMap<string> Variables
        {
            get => _variables ?? (_variables = new InputMap<string>());
            set => _variables = value;
        }

        public ComputeInstanceGroupState()
        {
        }
        public static new ComputeInstanceGroupState Empty => new ComputeInstanceGroupState();
    }
}