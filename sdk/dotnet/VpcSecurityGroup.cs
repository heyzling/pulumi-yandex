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
    /// Manages a Security Group within the Yandex.Cloud. For more information, see
    /// [the official documentation](https://cloud.yandex.com/docs/vpc/concepts/security-groups).
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
    ///     var lab_net = new Yandex.VpcNetwork("lab-net");
    /// 
    ///     var group1 = new Yandex.VpcSecurityGroup("group1", new()
    ///     {
    ///         Description = "description for my security group",
    ///         Egresses = new[]
    ///         {
    ///             new Yandex.Inputs.VpcSecurityGroupEgressArgs
    ///             {
    ///                 Description = "rule2 description",
    ///                 FromPort = 8090,
    ///                 Protocol = "ANY",
    ///                 ToPort = 8099,
    ///                 V4CidrBlocks = new[]
    ///                 {
    ///                     "10.0.1.0/24",
    ///                     "10.0.2.0/24",
    ///                 },
    ///             },
    ///             new Yandex.Inputs.VpcSecurityGroupEgressArgs
    ///             {
    ///                 Description = "rule3 description",
    ///                 FromPort = 8090,
    ///                 Protocol = "UDP",
    ///                 ToPort = 8099,
    ///                 V4CidrBlocks = new[]
    ///                 {
    ///                     "10.0.1.0/24",
    ///                 },
    ///             },
    ///         },
    ///         Ingresses = new[]
    ///         {
    ///             new Yandex.Inputs.VpcSecurityGroupIngressArgs
    ///             {
    ///                 Description = "rule1 description",
    ///                 Port = 8080,
    ///                 Protocol = "TCP",
    ///                 V4CidrBlocks = new[]
    ///                 {
    ///                     "10.0.1.0/24",
    ///                     "10.0.2.0/24",
    ///                 },
    ///             },
    ///         },
    ///         Labels = 
    ///         {
    ///             { "my-label", "my-label-value" },
    ///         },
    ///         NetworkId = lab_net.Id,
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [YandexResourceType("yandex:index/vpcSecurityGroup:VpcSecurityGroup")]
    public partial class VpcSecurityGroup : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Creation timestamp of this security group.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// Description of the security group.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// A list of egress rules. The structure is documented below.
        /// </summary>
        [Output("egresses")]
        public Output<ImmutableArray<Outputs.VpcSecurityGroupEgress>> Egresses { get; private set; } = null!;

        /// <summary>
        /// ID of the folder this security group belongs to.
        /// </summary>
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// A list of ingress rules.
        /// </summary>
        [Output("ingresses")]
        public Output<ImmutableArray<Outputs.VpcSecurityGroupIngress>> Ingresses { get; private set; } = null!;

        /// <summary>
        /// Labels to assign to this security group.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>> Labels { get; private set; } = null!;

        /// <summary>
        /// Name of the security group.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// ID of the network this security group belongs to.
        /// </summary>
        [Output("networkId")]
        public Output<string> NetworkId { get; private set; } = null!;

        /// <summary>
        /// Status of this security group.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;


        /// <summary>
        /// Create a VpcSecurityGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VpcSecurityGroup(string name, VpcSecurityGroupArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/vpcSecurityGroup:VpcSecurityGroup", name, args ?? new VpcSecurityGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VpcSecurityGroup(string name, Input<string> id, VpcSecurityGroupState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/vpcSecurityGroup:VpcSecurityGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing VpcSecurityGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VpcSecurityGroup Get(string name, Input<string> id, VpcSecurityGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new VpcSecurityGroup(name, id, state, options);
        }
    }

    public sealed class VpcSecurityGroupArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the security group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("egresses")]
        private InputList<Inputs.VpcSecurityGroupEgressArgs>? _egresses;

        /// <summary>
        /// A list of egress rules. The structure is documented below.
        /// </summary>
        public InputList<Inputs.VpcSecurityGroupEgressArgs> Egresses
        {
            get => _egresses ?? (_egresses = new InputList<Inputs.VpcSecurityGroupEgressArgs>());
            set => _egresses = value;
        }

        /// <summary>
        /// ID of the folder this security group belongs to.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("ingresses")]
        private InputList<Inputs.VpcSecurityGroupIngressArgs>? _ingresses;

        /// <summary>
        /// A list of ingress rules.
        /// </summary>
        public InputList<Inputs.VpcSecurityGroupIngressArgs> Ingresses
        {
            get => _ingresses ?? (_ingresses = new InputList<Inputs.VpcSecurityGroupIngressArgs>());
            set => _ingresses = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Labels to assign to this security group.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the security group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the network this security group belongs to.
        /// </summary>
        [Input("networkId", required: true)]
        public Input<string> NetworkId { get; set; } = null!;

        public VpcSecurityGroupArgs()
        {
        }
        public static new VpcSecurityGroupArgs Empty => new VpcSecurityGroupArgs();
    }

    public sealed class VpcSecurityGroupState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Creation timestamp of this security group.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// Description of the security group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("egresses")]
        private InputList<Inputs.VpcSecurityGroupEgressGetArgs>? _egresses;

        /// <summary>
        /// A list of egress rules. The structure is documented below.
        /// </summary>
        public InputList<Inputs.VpcSecurityGroupEgressGetArgs> Egresses
        {
            get => _egresses ?? (_egresses = new InputList<Inputs.VpcSecurityGroupEgressGetArgs>());
            set => _egresses = value;
        }

        /// <summary>
        /// ID of the folder this security group belongs to.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("ingresses")]
        private InputList<Inputs.VpcSecurityGroupIngressGetArgs>? _ingresses;

        /// <summary>
        /// A list of ingress rules.
        /// </summary>
        public InputList<Inputs.VpcSecurityGroupIngressGetArgs> Ingresses
        {
            get => _ingresses ?? (_ingresses = new InputList<Inputs.VpcSecurityGroupIngressGetArgs>());
            set => _ingresses = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Labels to assign to this security group.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the security group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the network this security group belongs to.
        /// </summary>
        [Input("networkId")]
        public Input<string>? NetworkId { get; set; }

        /// <summary>
        /// Status of this security group.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public VpcSecurityGroupState()
        {
        }
        public static new VpcSecurityGroupState Empty => new VpcSecurityGroupState();
    }
}
