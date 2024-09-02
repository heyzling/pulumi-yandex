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
    /// A Load Testing Agent resource. For more information, see
    /// [the official documentation](https://cloud.yandex.com/en/docs/load-testing/concepts/agent).
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
    ///     var my_agent = new Yandex.LoadtestingAgent("my-agent", new()
    ///     {
    ///         ComputeInstance = new Yandex.Inputs.LoadtestingAgentComputeInstanceArgs
    ///         {
    ///             BootDisk = new Yandex.Inputs.LoadtestingAgentComputeInstanceBootDiskArgs
    ///             {
    ///                 AutoDelete = true,
    ///                 InitializeParams = new Yandex.Inputs.LoadtestingAgentComputeInstanceBootDiskInitializeParamsArgs
    ///                 {
    ///                     Size = 15,
    ///                 },
    ///             },
    ///             NetworkInterfaces = new[]
    ///             {
    ///                 new Yandex.Inputs.LoadtestingAgentComputeInstanceNetworkInterfaceArgs
    ///                 {
    ///                     SubnetId = yandex_vpc_subnet.My_subnet_a.Id,
    ///                 },
    ///             },
    ///             Resources = new Yandex.Inputs.LoadtestingAgentComputeInstanceResourcesArgs
    ///             {
    ///                 Cores = 2,
    ///                 Memory = 4,
    ///             },
    ///             ServiceAccountId = yandex_iam_service_account.Test_account.Id,
    ///             ZoneId = "ru-central1-b",
    ///         },
    ///         Description = "2 core 4 GB RAM agent",
    ///         FolderId = data.Yandex_resourcemanager_folder.Test_folder.Id,
    ///         Labels = 
    ///         {
    ///             { "jmeter", "5" },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [YandexResourceType("yandex:index/loadtestingAgent:LoadtestingAgent")]
    public partial class LoadtestingAgent : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The template for creating new compute instance running load testing agent. The structure is documented below.
        /// </summary>
        [Output("computeInstance")]
        public Output<Outputs.LoadtestingAgentComputeInstance> ComputeInstance { get; private set; } = null!;

        [Output("computeInstanceId")]
        public Output<string> ComputeInstanceId { get; private set; } = null!;

        /// <summary>
        /// A description of the load testing agent.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The ID of the folder that the resources belong to.
        /// </summary>
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// A set of key/value label pairs to assign to the agent.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// The name of the load testing agent. Must be unique within folder.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a LoadtestingAgent resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LoadtestingAgent(string name, LoadtestingAgentArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/loadtestingAgent:LoadtestingAgent", name, args ?? new LoadtestingAgentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LoadtestingAgent(string name, Input<string> id, LoadtestingAgentState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/loadtestingAgent:LoadtestingAgent", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LoadtestingAgent resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LoadtestingAgent Get(string name, Input<string> id, LoadtestingAgentState? state = null, CustomResourceOptions? options = null)
        {
            return new LoadtestingAgent(name, id, state, options);
        }
    }

    public sealed class LoadtestingAgentArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The template for creating new compute instance running load testing agent. The structure is documented below.
        /// </summary>
        [Input("computeInstance", required: true)]
        public Input<Inputs.LoadtestingAgentComputeInstanceArgs> ComputeInstance { get; set; } = null!;

        /// <summary>
        /// A description of the load testing agent.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The ID of the folder that the resources belong to.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the agent.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// The name of the load testing agent. Must be unique within folder.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public LoadtestingAgentArgs()
        {
        }
        public static new LoadtestingAgentArgs Empty => new LoadtestingAgentArgs();
    }

    public sealed class LoadtestingAgentState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The template for creating new compute instance running load testing agent. The structure is documented below.
        /// </summary>
        [Input("computeInstance")]
        public Input<Inputs.LoadtestingAgentComputeInstanceGetArgs>? ComputeInstance { get; set; }

        [Input("computeInstanceId")]
        public Input<string>? ComputeInstanceId { get; set; }

        /// <summary>
        /// A description of the load testing agent.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The ID of the folder that the resources belong to.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the agent.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// The name of the load testing agent. Must be unique within folder.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public LoadtestingAgentState()
        {
        }
        public static new LoadtestingAgentState Empty => new LoadtestingAgentState();
    }
}