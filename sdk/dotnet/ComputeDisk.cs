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
    /// Persistent disks are used for data storage and function similarly to physical hard and solid state drives.
    /// 
    /// A disk can be attached or detached from the virtual machine and can be located locally. A disk can be moved between virtual machines within the same availability zone. Each disk can be attached to only one virtual machine at a time.
    /// 
    /// For more information about disks in Yandex.Cloud, see:
    /// 
    /// * [Documentation](https://cloud.yandex.com/docs/compute/concepts/disk)
    /// * How-to Guides
    ///     * [Attach and detach a disk](https://cloud.yandex.com/docs/compute/concepts/disk#attach-detach)
    ///     * [Backup operation](https://cloud.yandex.com/docs/compute/concepts/disk#backup)
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
    ///     var @default = new Yandex.ComputeDisk("default", new()
    ///     {
    ///         ImageId = "ubuntu-16.04-v20180727",
    ///         Labels = 
    ///         {
    ///             { "environment", "test" },
    ///         },
    ///         Type = "network-ssd",
    ///         Zone = "ru-central1-a",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ### Non-Replicated Disk
    /// 
    /// **Note**: Non-replicated disks are at the [Preview](https://cloud.yandex.com/docs/overview/concepts/launch-stages)
    ///           stage.
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
    ///     var @this = new Yandex.ComputeDiskPlacementGroup("this", new()
    ///     {
    ///         Zone = "ru-central1-b",
    ///     });
    /// 
    ///     var nr = new Yandex.ComputeDisk("nr", new()
    ///     {
    ///         Size = 93,
    ///         Type = "network-ssd-nonreplicated",
    ///         Zone = "ru-central1-b",
    ///         DiskPlacementPolicy = new Yandex.Inputs.ComputeDiskDiskPlacementPolicyArgs
    ///         {
    ///             DiskPlacementGroupId = @this.Id,
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// A disk can be imported using any of these accepted formats:
    /// 
    /// ```sh
    /// $ pulumi import yandex:index/computeDisk:ComputeDisk default disk_id
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/computeDisk:ComputeDisk")]
    public partial class ComputeDisk : global::Pulumi.CustomResource
    {
        [Output("allowRecreate")]
        public Output<bool?> AllowRecreate { get; private set; } = null!;

        /// <summary>
        /// Block size of the disk, specified in bytes.
        /// </summary>
        [Output("blockSize")]
        public Output<int?> BlockSize { get; private set; } = null!;

        /// <summary>
        /// Creation timestamp of the disk.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// (Optional) Description of the disk. Provide this property when
        /// you create a resource.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Disk placement policy configuration. The structure is documented below.
        /// </summary>
        [Output("diskPlacementPolicy")]
        public Output<Outputs.ComputeDiskDiskPlacementPolicy> DiskPlacementPolicy { get; private set; } = null!;

        /// <summary>
        /// (Optional) The ID of the folder that the disk belongs to.
        /// If it is not provided, the default provider folder is used.
        /// </summary>
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// The source image to use for disk creation.
        /// </summary>
        [Output("imageId")]
        public Output<string?> ImageId { get; private set; } = null!;

        /// <summary>
        /// Labels to assign to this disk. A list of key/value pairs.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// Name of the disk. Provide this property when
        /// you create a resource.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("productIds")]
        public Output<ImmutableArray<string>> ProductIds { get; private set; } = null!;

        /// <summary>
        /// Size of the persistent disk, specified in GB. You can specify this
        /// field when creating a persistent disk using the `image_id` or `snapshot_id`
        /// parameter, or specify it alone to create an empty persistent disk.
        /// If you specify this field along with `image_id` or `snapshot_id`,
        /// the size value must not be less than the size of the source image
        /// or the size of the snapshot.
        /// </summary>
        [Output("size")]
        public Output<int?> Size { get; private set; } = null!;

        /// <summary>
        /// The source snapshot to use for disk creation.
        /// </summary>
        [Output("snapshotId")]
        public Output<string?> SnapshotId { get; private set; } = null!;

        /// <summary>
        /// The status of the disk.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// Type of disk to create. Provide this when creating a disk.
        /// </summary>
        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;

        /// <summary>
        /// Availability zone where the disk will reside.
        /// </summary>
        [Output("zone")]
        public Output<string> Zone { get; private set; } = null!;


        /// <summary>
        /// Create a ComputeDisk resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ComputeDisk(string name, ComputeDiskArgs? args = null, CustomResourceOptions? options = null)
            : base("yandex:index/computeDisk:ComputeDisk", name, args ?? new ComputeDiskArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ComputeDisk(string name, Input<string> id, ComputeDiskState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/computeDisk:ComputeDisk", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ComputeDisk resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ComputeDisk Get(string name, Input<string> id, ComputeDiskState? state = null, CustomResourceOptions? options = null)
        {
            return new ComputeDisk(name, id, state, options);
        }
    }

    public sealed class ComputeDiskArgs : global::Pulumi.ResourceArgs
    {
        [Input("allowRecreate")]
        public Input<bool>? AllowRecreate { get; set; }

        /// <summary>
        /// Block size of the disk, specified in bytes.
        /// </summary>
        [Input("blockSize")]
        public Input<int>? BlockSize { get; set; }

        /// <summary>
        /// (Optional) Description of the disk. Provide this property when
        /// you create a resource.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Disk placement policy configuration. The structure is documented below.
        /// </summary>
        [Input("diskPlacementPolicy")]
        public Input<Inputs.ComputeDiskDiskPlacementPolicyArgs>? DiskPlacementPolicy { get; set; }

        /// <summary>
        /// (Optional) The ID of the folder that the disk belongs to.
        /// If it is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// The source image to use for disk creation.
        /// </summary>
        [Input("imageId")]
        public Input<string>? ImageId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Labels to assign to this disk. A list of key/value pairs.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the disk. Provide this property when
        /// you create a resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Size of the persistent disk, specified in GB. You can specify this
        /// field when creating a persistent disk using the `image_id` or `snapshot_id`
        /// parameter, or specify it alone to create an empty persistent disk.
        /// If you specify this field along with `image_id` or `snapshot_id`,
        /// the size value must not be less than the size of the source image
        /// or the size of the snapshot.
        /// </summary>
        [Input("size")]
        public Input<int>? Size { get; set; }

        /// <summary>
        /// The source snapshot to use for disk creation.
        /// </summary>
        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        /// <summary>
        /// Type of disk to create. Provide this when creating a disk.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Availability zone where the disk will reside.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public ComputeDiskArgs()
        {
        }
        public static new ComputeDiskArgs Empty => new ComputeDiskArgs();
    }

    public sealed class ComputeDiskState : global::Pulumi.ResourceArgs
    {
        [Input("allowRecreate")]
        public Input<bool>? AllowRecreate { get; set; }

        /// <summary>
        /// Block size of the disk, specified in bytes.
        /// </summary>
        [Input("blockSize")]
        public Input<int>? BlockSize { get; set; }

        /// <summary>
        /// Creation timestamp of the disk.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// (Optional) Description of the disk. Provide this property when
        /// you create a resource.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Disk placement policy configuration. The structure is documented below.
        /// </summary>
        [Input("diskPlacementPolicy")]
        public Input<Inputs.ComputeDiskDiskPlacementPolicyGetArgs>? DiskPlacementPolicy { get; set; }

        /// <summary>
        /// (Optional) The ID of the folder that the disk belongs to.
        /// If it is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// The source image to use for disk creation.
        /// </summary>
        [Input("imageId")]
        public Input<string>? ImageId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Labels to assign to this disk. A list of key/value pairs.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the disk. Provide this property when
        /// you create a resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("productIds")]
        private InputList<string>? _productIds;
        public InputList<string> ProductIds
        {
            get => _productIds ?? (_productIds = new InputList<string>());
            set => _productIds = value;
        }

        /// <summary>
        /// Size of the persistent disk, specified in GB. You can specify this
        /// field when creating a persistent disk using the `image_id` or `snapshot_id`
        /// parameter, or specify it alone to create an empty persistent disk.
        /// If you specify this field along with `image_id` or `snapshot_id`,
        /// the size value must not be less than the size of the source image
        /// or the size of the snapshot.
        /// </summary>
        [Input("size")]
        public Input<int>? Size { get; set; }

        /// <summary>
        /// The source snapshot to use for disk creation.
        /// </summary>
        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        /// <summary>
        /// The status of the disk.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Type of disk to create. Provide this when creating a disk.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Availability zone where the disk will reside.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public ComputeDiskState()
        {
        }
        public static new ComputeDiskState Empty => new ComputeDiskState();
    }
}
