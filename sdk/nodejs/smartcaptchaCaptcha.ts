// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class SmartcaptchaCaptcha extends pulumi.CustomResource {
    /**
     * Get an existing SmartcaptchaCaptcha resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SmartcaptchaCaptchaState, opts?: pulumi.CustomResourceOptions): SmartcaptchaCaptcha {
        return new SmartcaptchaCaptcha(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/smartcaptchaCaptcha:SmartcaptchaCaptcha';

    /**
     * Returns true if the given object is an instance of SmartcaptchaCaptcha.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SmartcaptchaCaptcha {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SmartcaptchaCaptcha.__pulumiType;
    }

    public readonly allowedSites!: pulumi.Output<string[] | undefined>;
    public readonly challengeType!: pulumi.Output<string | undefined>;
    public /*out*/ readonly clientKey!: pulumi.Output<string>;
    public readonly cloudId!: pulumi.Output<string>;
    public readonly complexity!: pulumi.Output<string | undefined>;
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    public readonly deletionProtection!: pulumi.Output<boolean | undefined>;
    public readonly folderId!: pulumi.Output<string>;
    public readonly name!: pulumi.Output<string>;
    public readonly overrideVariants!: pulumi.Output<outputs.SmartcaptchaCaptchaOverrideVariant[] | undefined>;
    public readonly preCheckType!: pulumi.Output<string | undefined>;
    public readonly securityRules!: pulumi.Output<outputs.SmartcaptchaCaptchaSecurityRule[] | undefined>;
    public readonly styleJson!: pulumi.Output<string | undefined>;
    public /*out*/ readonly suspend!: pulumi.Output<boolean>;
    public readonly turnOffHostnameCheck!: pulumi.Output<boolean | undefined>;

    /**
     * Create a SmartcaptchaCaptcha resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: SmartcaptchaCaptchaArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SmartcaptchaCaptchaArgs | SmartcaptchaCaptchaState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SmartcaptchaCaptchaState | undefined;
            resourceInputs["allowedSites"] = state ? state.allowedSites : undefined;
            resourceInputs["challengeType"] = state ? state.challengeType : undefined;
            resourceInputs["clientKey"] = state ? state.clientKey : undefined;
            resourceInputs["cloudId"] = state ? state.cloudId : undefined;
            resourceInputs["complexity"] = state ? state.complexity : undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["deletionProtection"] = state ? state.deletionProtection : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["overrideVariants"] = state ? state.overrideVariants : undefined;
            resourceInputs["preCheckType"] = state ? state.preCheckType : undefined;
            resourceInputs["securityRules"] = state ? state.securityRules : undefined;
            resourceInputs["styleJson"] = state ? state.styleJson : undefined;
            resourceInputs["suspend"] = state ? state.suspend : undefined;
            resourceInputs["turnOffHostnameCheck"] = state ? state.turnOffHostnameCheck : undefined;
        } else {
            const args = argsOrState as SmartcaptchaCaptchaArgs | undefined;
            resourceInputs["allowedSites"] = args ? args.allowedSites : undefined;
            resourceInputs["challengeType"] = args ? args.challengeType : undefined;
            resourceInputs["cloudId"] = args ? args.cloudId : undefined;
            resourceInputs["complexity"] = args ? args.complexity : undefined;
            resourceInputs["deletionProtection"] = args ? args.deletionProtection : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["overrideVariants"] = args ? args.overrideVariants : undefined;
            resourceInputs["preCheckType"] = args ? args.preCheckType : undefined;
            resourceInputs["securityRules"] = args ? args.securityRules : undefined;
            resourceInputs["styleJson"] = args ? args.styleJson : undefined;
            resourceInputs["turnOffHostnameCheck"] = args ? args.turnOffHostnameCheck : undefined;
            resourceInputs["clientKey"] = undefined /*out*/;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["suspend"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SmartcaptchaCaptcha.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SmartcaptchaCaptcha resources.
 */
export interface SmartcaptchaCaptchaState {
    allowedSites?: pulumi.Input<pulumi.Input<string>[]>;
    challengeType?: pulumi.Input<string>;
    clientKey?: pulumi.Input<string>;
    cloudId?: pulumi.Input<string>;
    complexity?: pulumi.Input<string>;
    createdAt?: pulumi.Input<string>;
    deletionProtection?: pulumi.Input<boolean>;
    folderId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    overrideVariants?: pulumi.Input<pulumi.Input<inputs.SmartcaptchaCaptchaOverrideVariant>[]>;
    preCheckType?: pulumi.Input<string>;
    securityRules?: pulumi.Input<pulumi.Input<inputs.SmartcaptchaCaptchaSecurityRule>[]>;
    styleJson?: pulumi.Input<string>;
    suspend?: pulumi.Input<boolean>;
    turnOffHostnameCheck?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a SmartcaptchaCaptcha resource.
 */
export interface SmartcaptchaCaptchaArgs {
    allowedSites?: pulumi.Input<pulumi.Input<string>[]>;
    challengeType?: pulumi.Input<string>;
    cloudId?: pulumi.Input<string>;
    complexity?: pulumi.Input<string>;
    deletionProtection?: pulumi.Input<boolean>;
    folderId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    overrideVariants?: pulumi.Input<pulumi.Input<inputs.SmartcaptchaCaptchaOverrideVariant>[]>;
    preCheckType?: pulumi.Input<string>;
    securityRules?: pulumi.Input<pulumi.Input<inputs.SmartcaptchaCaptchaSecurityRule>[]>;
    styleJson?: pulumi.Input<string>;
    turnOffHostnameCheck?: pulumi.Input<boolean>;
}