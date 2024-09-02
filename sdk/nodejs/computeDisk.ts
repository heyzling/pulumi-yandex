// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Persistent disks are used for data storage and function similarly to physical hard and solid state drives.
 *
 * A disk can be attached or detached from the virtual machine and can be located locally. A disk can be moved between virtual machines within the same availability zone. Each disk can be attached to only one virtual machine at a time.
 *
 * For more information about disks in Yandex.Cloud, see:
 *
 * * [Documentation](https://cloud.yandex.com/docs/compute/concepts/disk)
 * * How-to Guides
 *     * [Attach and detach a disk](https://cloud.yandex.com/docs/compute/concepts/disk#attach-detach)
 *     * [Backup operation](https://cloud.yandex.com/docs/compute/concepts/disk#backup)
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const _default = new yandex.ComputeDisk("default", {
 *     imageId: "ubuntu-16.04-v20180727",
 *     labels: {
 *         environment: "test",
 *     },
 *     type: "network-ssd",
 *     zone: "ru-central1-a",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Non-Replicated Disk
 *
 * **Note**: Non-replicated disks are at the [Preview](https://cloud.yandex.com/docs/overview/concepts/launch-stages)
 *           stage.
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const _this = new yandex.ComputeDiskPlacementGroup("this", {zone: "ru-central1-b"});
 * const nr = new yandex.ComputeDisk("nr", {
 *     size: 93,
 *     type: "network-ssd-nonreplicated",
 *     zone: "ru-central1-b",
 *     diskPlacementPolicy: {
 *         diskPlacementGroupId: _this.id,
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * A disk can be imported using any of these accepted formats:
 *
 * ```sh
 * $ pulumi import yandex:index/computeDisk:ComputeDisk default disk_id
 * ```
 */
export class ComputeDisk extends pulumi.CustomResource {
    /**
     * Get an existing ComputeDisk resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ComputeDiskState, opts?: pulumi.CustomResourceOptions): ComputeDisk {
        return new ComputeDisk(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/computeDisk:ComputeDisk';

    /**
     * Returns true if the given object is an instance of ComputeDisk.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ComputeDisk {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ComputeDisk.__pulumiType;
    }

    public readonly allowRecreate!: pulumi.Output<boolean | undefined>;
    /**
     * Block size of the disk, specified in bytes.
     */
    public readonly blockSize!: pulumi.Output<number | undefined>;
    /**
     * Creation timestamp of the disk.
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * (Optional) Description of the disk. Provide this property when
     * you create a resource.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Disk placement policy configuration. The structure is documented below.
     */
    public readonly diskPlacementPolicy!: pulumi.Output<outputs.ComputeDiskDiskPlacementPolicy>;
    /**
     * (Optional) The ID of the folder that the disk belongs to.
     * If it is not provided, the default provider folder is used.
     */
    public readonly folderId!: pulumi.Output<string>;
    /**
     * The source image to use for disk creation.
     */
    public readonly imageId!: pulumi.Output<string | undefined>;
    /**
     * Labels to assign to this disk. A list of key/value pairs.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Name of the disk. Provide this property when
     * you create a resource.
     */
    public readonly name!: pulumi.Output<string>;
    public /*out*/ readonly productIds!: pulumi.Output<string[]>;
    /**
     * Size of the persistent disk, specified in GB. You can specify this
     * field when creating a persistent disk using the `imageId` or `snapshotId`
     * parameter, or specify it alone to create an empty persistent disk.
     * If you specify this field along with `imageId` or `snapshotId`,
     * the size value must not be less than the size of the source image
     * or the size of the snapshot.
     */
    public readonly size!: pulumi.Output<number | undefined>;
    /**
     * The source snapshot to use for disk creation.
     */
    public readonly snapshotId!: pulumi.Output<string | undefined>;
    /**
     * The status of the disk.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * Type of disk to create. Provide this when creating a disk.
     */
    public readonly type!: pulumi.Output<string | undefined>;
    /**
     * Availability zone where the disk will reside.
     */
    public readonly zone!: pulumi.Output<string>;

    /**
     * Create a ComputeDisk resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ComputeDiskArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ComputeDiskArgs | ComputeDiskState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ComputeDiskState | undefined;
            resourceInputs["allowRecreate"] = state ? state.allowRecreate : undefined;
            resourceInputs["blockSize"] = state ? state.blockSize : undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["diskPlacementPolicy"] = state ? state.diskPlacementPolicy : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["imageId"] = state ? state.imageId : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["productIds"] = state ? state.productIds : undefined;
            resourceInputs["size"] = state ? state.size : undefined;
            resourceInputs["snapshotId"] = state ? state.snapshotId : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
            resourceInputs["zone"] = state ? state.zone : undefined;
        } else {
            const args = argsOrState as ComputeDiskArgs | undefined;
            resourceInputs["allowRecreate"] = args ? args.allowRecreate : undefined;
            resourceInputs["blockSize"] = args ? args.blockSize : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["diskPlacementPolicy"] = args ? args.diskPlacementPolicy : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["imageId"] = args ? args.imageId : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["size"] = args ? args.size : undefined;
            resourceInputs["snapshotId"] = args ? args.snapshotId : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["zone"] = args ? args.zone : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["productIds"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ComputeDisk.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ComputeDisk resources.
 */
export interface ComputeDiskState {
    allowRecreate?: pulumi.Input<boolean>;
    /**
     * Block size of the disk, specified in bytes.
     */
    blockSize?: pulumi.Input<number>;
    /**
     * Creation timestamp of the disk.
     */
    createdAt?: pulumi.Input<string>;
    /**
     * (Optional) Description of the disk. Provide this property when
     * you create a resource.
     */
    description?: pulumi.Input<string>;
    /**
     * Disk placement policy configuration. The structure is documented below.
     */
    diskPlacementPolicy?: pulumi.Input<inputs.ComputeDiskDiskPlacementPolicy>;
    /**
     * (Optional) The ID of the folder that the disk belongs to.
     * If it is not provided, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * The source image to use for disk creation.
     */
    imageId?: pulumi.Input<string>;
    /**
     * Labels to assign to this disk. A list of key/value pairs.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Name of the disk. Provide this property when
     * you create a resource.
     */
    name?: pulumi.Input<string>;
    productIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Size of the persistent disk, specified in GB. You can specify this
     * field when creating a persistent disk using the `imageId` or `snapshotId`
     * parameter, or specify it alone to create an empty persistent disk.
     * If you specify this field along with `imageId` or `snapshotId`,
     * the size value must not be less than the size of the source image
     * or the size of the snapshot.
     */
    size?: pulumi.Input<number>;
    /**
     * The source snapshot to use for disk creation.
     */
    snapshotId?: pulumi.Input<string>;
    /**
     * The status of the disk.
     */
    status?: pulumi.Input<string>;
    /**
     * Type of disk to create. Provide this when creating a disk.
     */
    type?: pulumi.Input<string>;
    /**
     * Availability zone where the disk will reside.
     */
    zone?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ComputeDisk resource.
 */
export interface ComputeDiskArgs {
    allowRecreate?: pulumi.Input<boolean>;
    /**
     * Block size of the disk, specified in bytes.
     */
    blockSize?: pulumi.Input<number>;
    /**
     * (Optional) Description of the disk. Provide this property when
     * you create a resource.
     */
    description?: pulumi.Input<string>;
    /**
     * Disk placement policy configuration. The structure is documented below.
     */
    diskPlacementPolicy?: pulumi.Input<inputs.ComputeDiskDiskPlacementPolicy>;
    /**
     * (Optional) The ID of the folder that the disk belongs to.
     * If it is not provided, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * The source image to use for disk creation.
     */
    imageId?: pulumi.Input<string>;
    /**
     * Labels to assign to this disk. A list of key/value pairs.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Name of the disk. Provide this property when
     * you create a resource.
     */
    name?: pulumi.Input<string>;
    /**
     * Size of the persistent disk, specified in GB. You can specify this
     * field when creating a persistent disk using the `imageId` or `snapshotId`
     * parameter, or specify it alone to create an empty persistent disk.
     * If you specify this field along with `imageId` or `snapshotId`,
     * the size value must not be less than the size of the source image
     * or the size of the snapshot.
     */
    size?: pulumi.Input<number>;
    /**
     * The source snapshot to use for disk creation.
     */
    snapshotId?: pulumi.Input<string>;
    /**
     * Type of disk to create. Provide this when creating a disk.
     */
    type?: pulumi.Input<string>;
    /**
     * Availability zone where the disk will reside.
     */
    zone?: pulumi.Input<string>;
}
