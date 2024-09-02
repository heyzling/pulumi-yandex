// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class SwsSecurityProfile extends pulumi.CustomResource {
    /**
     * Get an existing SwsSecurityProfile resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SwsSecurityProfileState, opts?: pulumi.CustomResourceOptions): SwsSecurityProfile {
        return new SwsSecurityProfile(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/swsSecurityProfile:SwsSecurityProfile';

    /**
     * Returns true if the given object is an instance of SwsSecurityProfile.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SwsSecurityProfile {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SwsSecurityProfile.__pulumiType;
    }

    public readonly captchaId!: pulumi.Output<string | undefined>;
    public readonly cloudId!: pulumi.Output<string>;
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    public readonly defaultAction!: pulumi.Output<string | undefined>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly folderId!: pulumi.Output<string>;
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly securityRules!: pulumi.Output<outputs.SwsSecurityProfileSecurityRule[] | undefined>;

    /**
     * Create a SwsSecurityProfile resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: SwsSecurityProfileArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SwsSecurityProfileArgs | SwsSecurityProfileState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SwsSecurityProfileState | undefined;
            resourceInputs["captchaId"] = state ? state.captchaId : undefined;
            resourceInputs["cloudId"] = state ? state.cloudId : undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["defaultAction"] = state ? state.defaultAction : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["securityRules"] = state ? state.securityRules : undefined;
        } else {
            const args = argsOrState as SwsSecurityProfileArgs | undefined;
            resourceInputs["captchaId"] = args ? args.captchaId : undefined;
            resourceInputs["cloudId"] = args ? args.cloudId : undefined;
            resourceInputs["defaultAction"] = args ? args.defaultAction : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["securityRules"] = args ? args.securityRules : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SwsSecurityProfile.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SwsSecurityProfile resources.
 */
export interface SwsSecurityProfileState {
    captchaId?: pulumi.Input<string>;
    cloudId?: pulumi.Input<string>;
    createdAt?: pulumi.Input<string>;
    defaultAction?: pulumi.Input<string>;
    description?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    name?: pulumi.Input<string>;
    securityRules?: pulumi.Input<pulumi.Input<inputs.SwsSecurityProfileSecurityRule>[]>;
}

/**
 * The set of arguments for constructing a SwsSecurityProfile resource.
 */
export interface SwsSecurityProfileArgs {
    captchaId?: pulumi.Input<string>;
    cloudId?: pulumi.Input<string>;
    defaultAction?: pulumi.Input<string>;
    description?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    name?: pulumi.Input<string>;
    securityRules?: pulumi.Input<pulumi.Input<inputs.SwsSecurityProfileSecurityRule>[]>;
}
