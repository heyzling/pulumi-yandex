// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Manages a network within the Yandex.Cloud. For more information, see
 * [the official documentation](https://cloud.yandex.com/docs/vpc/concepts/network#network).
 *
 * * How-to Guides
 *     * [Cloud Networking](https://cloud.yandex.com/docs/vpc/)
 *     * [VPC Addressing](https://cloud.yandex.com/docs/vpc/concepts/address)
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const _default = new yandex.VpcNetwork("default", {});
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * A network can be imported using the `id` of the resource, e.g.
 *
 * ```sh
 * $ pulumi import yandex:index/vpcNetwork:VpcNetwork default network_id
 * ```
 */
export class VpcNetwork extends pulumi.CustomResource {
    /**
     * Get an existing VpcNetwork resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VpcNetworkState, opts?: pulumi.CustomResourceOptions): VpcNetwork {
        return new VpcNetwork(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/vpcNetwork:VpcNetwork';

    /**
     * Returns true if the given object is an instance of VpcNetwork.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VpcNetwork {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VpcNetwork.__pulumiType;
    }

    /**
     * Creation timestamp of the key.
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * ID of default Security Group of this network.
     */
    public /*out*/ readonly defaultSecurityGroupId!: pulumi.Output<string>;
    /**
     * An optional description of this resource. Provide this property when
     * you create the resource.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * ID of the folder that the resource belongs to. If it
     * is not provided, the default provider folder is used.
     */
    public readonly folderId!: pulumi.Output<string>;
    /**
     * Labels to apply to this network. A list of key/value pairs.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string}>;
    /**
     * Name of the network. Provided by the client when the network is created.
     */
    public readonly name!: pulumi.Output<string>;
    public /*out*/ readonly subnetIds!: pulumi.Output<string[]>;

    /**
     * Create a VpcNetwork resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: VpcNetworkArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VpcNetworkArgs | VpcNetworkState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as VpcNetworkState | undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["defaultSecurityGroupId"] = state ? state.defaultSecurityGroupId : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["subnetIds"] = state ? state.subnetIds : undefined;
        } else {
            const args = argsOrState as VpcNetworkArgs | undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["defaultSecurityGroupId"] = undefined /*out*/;
            resourceInputs["subnetIds"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(VpcNetwork.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering VpcNetwork resources.
 */
export interface VpcNetworkState {
    /**
     * Creation timestamp of the key.
     */
    createdAt?: pulumi.Input<string>;
    /**
     * ID of default Security Group of this network.
     */
    defaultSecurityGroupId?: pulumi.Input<string>;
    /**
     * An optional description of this resource. Provide this property when
     * you create the resource.
     */
    description?: pulumi.Input<string>;
    /**
     * ID of the folder that the resource belongs to. If it
     * is not provided, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * Labels to apply to this network. A list of key/value pairs.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Name of the network. Provided by the client when the network is created.
     */
    name?: pulumi.Input<string>;
    subnetIds?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a VpcNetwork resource.
 */
export interface VpcNetworkArgs {
    /**
     * An optional description of this resource. Provide this property when
     * you create the resource.
     */
    description?: pulumi.Input<string>;
    /**
     * ID of the folder that the resource belongs to. If it
     * is not provided, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * Labels to apply to this network. A list of key/value pairs.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Name of the network. Provided by the client when the network is created.
     */
    name?: pulumi.Input<string>;
}
