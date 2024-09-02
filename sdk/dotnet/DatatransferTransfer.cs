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
    /// Manages a Data Transfer transfer. For more information, see [the official documentation](https://cloud.yandex.com/docs/data-transfer/).
    /// 
    /// ## Import
    /// 
    /// A transfer can be imported using the `id` of the resource, e.g.
    /// 
    /// ```sh
    /// $ pulumi import yandex:index/datatransferTransfer:DatatransferTransfer foo transfer_id
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/datatransferTransfer:DatatransferTransfer")]
    public partial class DatatransferTransfer : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Arbitrary description text for the transfer.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// ID of the folder to create the transfer in. If it is not provided, the default provider folder is used.
        /// </summary>
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// A set of key/value label pairs to assign to the Data Transfer transfer.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>> Labels { get; private set; } = null!;

        /// <summary>
        /// Name of the transfer.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Activation action on create a new incremental transfer.
        /// It is not part of the transfer parameter and is used only on create.
        /// One of "sync_activate", "async_activate", "dont_activate". The default is "sync_activate".
        /// 
        /// For the documentation of the runtime and transformation see below.
        /// </summary>
        [Output("onCreateActivateMode")]
        public Output<string?> OnCreateActivateMode { get; private set; } = null!;

        /// <summary>
        /// Runtime parameters for the transfer.
        /// </summary>
        [Output("runtime")]
        public Output<Outputs.DatatransferTransferRuntime> Runtime { get; private set; } = null!;

        /// <summary>
        /// ID of the source endpoint for the transfer.
        /// </summary>
        [Output("sourceId")]
        public Output<string> SourceId { get; private set; } = null!;

        /// <summary>
        /// ID of the target endpoint for the transfer.
        /// </summary>
        [Output("targetId")]
        public Output<string> TargetId { get; private set; } = null!;

        /// <summary>
        /// Transformation for the transfer.
        /// </summary>
        [Output("transformation")]
        public Output<Outputs.DatatransferTransferTransformation?> Transformation { get; private set; } = null!;

        /// <summary>
        /// Type of the transfer. One of "SNAPSHOT_ONLY", "INCREMENT_ONLY", "SNAPSHOT_AND_INCREMENT".
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// (Computed) Error description if transfer has any errors.
        /// </summary>
        [Output("warning")]
        public Output<string> Warning { get; private set; } = null!;


        /// <summary>
        /// Create a DatatransferTransfer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DatatransferTransfer(string name, DatatransferTransferArgs? args = null, CustomResourceOptions? options = null)
            : base("yandex:index/datatransferTransfer:DatatransferTransfer", name, args ?? new DatatransferTransferArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DatatransferTransfer(string name, Input<string> id, DatatransferTransferState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/datatransferTransfer:DatatransferTransfer", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DatatransferTransfer resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DatatransferTransfer Get(string name, Input<string> id, DatatransferTransferState? state = null, CustomResourceOptions? options = null)
        {
            return new DatatransferTransfer(name, id, state, options);
        }
    }

    public sealed class DatatransferTransferArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Arbitrary description text for the transfer.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// ID of the folder to create the transfer in. If it is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the Data Transfer transfer.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the transfer.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Activation action on create a new incremental transfer.
        /// It is not part of the transfer parameter and is used only on create.
        /// One of "sync_activate", "async_activate", "dont_activate". The default is "sync_activate".
        /// 
        /// For the documentation of the runtime and transformation see below.
        /// </summary>
        [Input("onCreateActivateMode")]
        public Input<string>? OnCreateActivateMode { get; set; }

        /// <summary>
        /// Runtime parameters for the transfer.
        /// </summary>
        [Input("runtime")]
        public Input<Inputs.DatatransferTransferRuntimeArgs>? Runtime { get; set; }

        /// <summary>
        /// ID of the source endpoint for the transfer.
        /// </summary>
        [Input("sourceId")]
        public Input<string>? SourceId { get; set; }

        /// <summary>
        /// ID of the target endpoint for the transfer.
        /// </summary>
        [Input("targetId")]
        public Input<string>? TargetId { get; set; }

        /// <summary>
        /// Transformation for the transfer.
        /// </summary>
        [Input("transformation")]
        public Input<Inputs.DatatransferTransferTransformationArgs>? Transformation { get; set; }

        /// <summary>
        /// Type of the transfer. One of "SNAPSHOT_ONLY", "INCREMENT_ONLY", "SNAPSHOT_AND_INCREMENT".
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public DatatransferTransferArgs()
        {
        }
        public static new DatatransferTransferArgs Empty => new DatatransferTransferArgs();
    }

    public sealed class DatatransferTransferState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Arbitrary description text for the transfer.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// ID of the folder to create the transfer in. If it is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the Data Transfer transfer.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the transfer.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Activation action on create a new incremental transfer.
        /// It is not part of the transfer parameter and is used only on create.
        /// One of "sync_activate", "async_activate", "dont_activate". The default is "sync_activate".
        /// 
        /// For the documentation of the runtime and transformation see below.
        /// </summary>
        [Input("onCreateActivateMode")]
        public Input<string>? OnCreateActivateMode { get; set; }

        /// <summary>
        /// Runtime parameters for the transfer.
        /// </summary>
        [Input("runtime")]
        public Input<Inputs.DatatransferTransferRuntimeGetArgs>? Runtime { get; set; }

        /// <summary>
        /// ID of the source endpoint for the transfer.
        /// </summary>
        [Input("sourceId")]
        public Input<string>? SourceId { get; set; }

        /// <summary>
        /// ID of the target endpoint for the transfer.
        /// </summary>
        [Input("targetId")]
        public Input<string>? TargetId { get; set; }

        /// <summary>
        /// Transformation for the transfer.
        /// </summary>
        [Input("transformation")]
        public Input<Inputs.DatatransferTransferTransformationGetArgs>? Transformation { get; set; }

        /// <summary>
        /// Type of the transfer. One of "SNAPSHOT_ONLY", "INCREMENT_ONLY", "SNAPSHOT_AND_INCREMENT".
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// (Computed) Error description if transfer has any errors.
        /// </summary>
        [Input("warning")]
        public Input<string>? Warning { get; set; }

        public DatatransferTransferState()
        {
        }
        public static new DatatransferTransferState Empty => new DatatransferTransferState();
    }
}
