// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Yandex Cloud Lockbox secret version resource. For more information, see
 * [the official documentation](https://cloud.yandex.com/en/docs/lockbox/).
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const mySecret = new yandex.LockboxSecret("mySecret", {});
 * const myVersion = new yandex.LockboxSecretVersion("myVersion", {
 *     secretId: mySecret.id,
 *     entries: [
 *         {
 *             key: "key1",
 *             textValue: "value1",
 *         },
 *         {
 *             key: "k2",
 *             command: {
 *                 path: "my_secret_generator.sh",
 *             },
 *         },
 *     ],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class LockboxSecretVersion extends pulumi.CustomResource {
    /**
     * Get an existing LockboxSecretVersion resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LockboxSecretVersionState, opts?: pulumi.CustomResourceOptions): LockboxSecretVersion {
        return new LockboxSecretVersion(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/lockboxSecretVersion:LockboxSecretVersion';

    /**
     * Returns true if the given object is an instance of LockboxSecretVersion.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LockboxSecretVersion {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LockboxSecretVersion.__pulumiType;
    }

    /**
     * The Yandex Cloud Lockbox secret version description.
     *
     * The `entries` block contains:
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * List of entries in the Yandex Cloud Lockbox secret version.
     */
    public readonly entries!: pulumi.Output<outputs.LockboxSecretVersionEntry[]>;
    /**
     * The Yandex Cloud Lockbox secret ID where to add the version.
     */
    public readonly secretId!: pulumi.Output<string>;

    /**
     * Create a LockboxSecretVersion resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LockboxSecretVersionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LockboxSecretVersionArgs | LockboxSecretVersionState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as LockboxSecretVersionState | undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["entries"] = state ? state.entries : undefined;
            resourceInputs["secretId"] = state ? state.secretId : undefined;
        } else {
            const args = argsOrState as LockboxSecretVersionArgs | undefined;
            if ((!args || args.entries === undefined) && !opts.urn) {
                throw new Error("Missing required property 'entries'");
            }
            if ((!args || args.secretId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'secretId'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["entries"] = args ? args.entries : undefined;
            resourceInputs["secretId"] = args ? args.secretId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(LockboxSecretVersion.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LockboxSecretVersion resources.
 */
export interface LockboxSecretVersionState {
    /**
     * The Yandex Cloud Lockbox secret version description.
     *
     * The `entries` block contains:
     */
    description?: pulumi.Input<string>;
    /**
     * List of entries in the Yandex Cloud Lockbox secret version.
     */
    entries?: pulumi.Input<pulumi.Input<inputs.LockboxSecretVersionEntry>[]>;
    /**
     * The Yandex Cloud Lockbox secret ID where to add the version.
     */
    secretId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a LockboxSecretVersion resource.
 */
export interface LockboxSecretVersionArgs {
    /**
     * The Yandex Cloud Lockbox secret version description.
     *
     * The `entries` block contains:
     */
    description?: pulumi.Input<string>;
    /**
     * List of entries in the Yandex Cloud Lockbox secret version.
     */
    entries: pulumi.Input<pulumi.Input<inputs.LockboxSecretVersionEntry>[]>;
    /**
     * The Yandex Cloud Lockbox secret ID where to add the version.
     */
    secretId: pulumi.Input<string>;
}