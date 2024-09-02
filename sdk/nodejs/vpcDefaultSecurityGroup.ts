// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const lab_net = new yandex.VpcNetwork("lab-net", {});
 * const default_sg = new yandex.VpcDefaultSecurityGroup("default-sg", {
 *     description: "description for default security group",
 *     egresses: [
 *         {
 *             description: "rule2 description",
 *             fromPort: 8090,
 *             protocol: "ANY",
 *             toPort: 8099,
 *             v4CidrBlocks: [
 *                 "10.0.1.0/24",
 *                 "10.0.2.0/24",
 *             ],
 *         },
 *         {
 *             description: "rule3 description",
 *             fromPort: 8090,
 *             protocol: "UDP",
 *             toPort: 8099,
 *             v4CidrBlocks: ["10.0.1.0/24"],
 *         },
 *     ],
 *     ingresses: [{
 *         description: "rule1 description",
 *         port: 8080,
 *         protocol: "TCP",
 *         v4CidrBlocks: [
 *             "10.0.1.0/24",
 *             "10.0.2.0/24",
 *         ],
 *     }],
 *     labels: {
 *         "my-label": "my-label-value",
 *     },
 *     networkId: lab_net.id,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class VpcDefaultSecurityGroup extends pulumi.CustomResource {
    /**
     * Get an existing VpcDefaultSecurityGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VpcDefaultSecurityGroupState, opts?: pulumi.CustomResourceOptions): VpcDefaultSecurityGroup {
        return new VpcDefaultSecurityGroup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/vpcDefaultSecurityGroup:VpcDefaultSecurityGroup';

    /**
     * Returns true if the given object is an instance of VpcDefaultSecurityGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VpcDefaultSecurityGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VpcDefaultSecurityGroup.__pulumiType;
    }

    /**
     * Creation timestamp of this security group.
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * Description of the security group.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * A list of egress rules. The structure is documented below.
     */
    public readonly egresses!: pulumi.Output<outputs.VpcDefaultSecurityGroupEgress[]>;
    /**
     * ID of the folder this security group belongs to.
     */
    public readonly folderId!: pulumi.Output<string>;
    /**
     * A list of ingress rules.
     */
    public readonly ingresses!: pulumi.Output<outputs.VpcDefaultSecurityGroupIngress[]>;
    /**
     * Labels to assign to this security group.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string}>;
    /**
     * Name of this security group.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * ID of the network this security group belongs to.
     */
    public readonly networkId!: pulumi.Output<string>;
    /**
     * Status of this security group.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;

    /**
     * Create a VpcDefaultSecurityGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VpcDefaultSecurityGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VpcDefaultSecurityGroupArgs | VpcDefaultSecurityGroupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as VpcDefaultSecurityGroupState | undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["egresses"] = state ? state.egresses : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["ingresses"] = state ? state.ingresses : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["networkId"] = state ? state.networkId : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
        } else {
            const args = argsOrState as VpcDefaultSecurityGroupArgs | undefined;
            if ((!args || args.networkId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'networkId'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["egresses"] = args ? args.egresses : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["ingresses"] = args ? args.ingresses : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["networkId"] = args ? args.networkId : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(VpcDefaultSecurityGroup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering VpcDefaultSecurityGroup resources.
 */
export interface VpcDefaultSecurityGroupState {
    /**
     * Creation timestamp of this security group.
     */
    createdAt?: pulumi.Input<string>;
    /**
     * Description of the security group.
     */
    description?: pulumi.Input<string>;
    /**
     * A list of egress rules. The structure is documented below.
     */
    egresses?: pulumi.Input<pulumi.Input<inputs.VpcDefaultSecurityGroupEgress>[]>;
    /**
     * ID of the folder this security group belongs to.
     */
    folderId?: pulumi.Input<string>;
    /**
     * A list of ingress rules.
     */
    ingresses?: pulumi.Input<pulumi.Input<inputs.VpcDefaultSecurityGroupIngress>[]>;
    /**
     * Labels to assign to this security group.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Name of this security group.
     */
    name?: pulumi.Input<string>;
    /**
     * ID of the network this security group belongs to.
     */
    networkId?: pulumi.Input<string>;
    /**
     * Status of this security group.
     */
    status?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a VpcDefaultSecurityGroup resource.
 */
export interface VpcDefaultSecurityGroupArgs {
    /**
     * Description of the security group.
     */
    description?: pulumi.Input<string>;
    /**
     * A list of egress rules. The structure is documented below.
     */
    egresses?: pulumi.Input<pulumi.Input<inputs.VpcDefaultSecurityGroupEgress>[]>;
    /**
     * ID of the folder this security group belongs to.
     */
    folderId?: pulumi.Input<string>;
    /**
     * A list of ingress rules.
     */
    ingresses?: pulumi.Input<pulumi.Input<inputs.VpcDefaultSecurityGroupIngress>[]>;
    /**
     * Labels to assign to this security group.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * ID of the network this security group belongs to.
     */
    networkId: pulumi.Input<string>;
}
