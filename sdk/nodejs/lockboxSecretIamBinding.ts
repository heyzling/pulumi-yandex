// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## yandex\_lockbox\_secret\_iam\_binding
 *
 * Allows creation and management of a single binding within IAM policy for
 * an existing Yandex Lockbox Secret.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const your_secret = new yandex.LockboxSecret("your-secret", {});
 * const viewer = new yandex.LockboxSecretIamBinding("viewer", {
 *     secretId: your_secret.id,
 *     role: "viewer",
 *     members: ["userAccount:foo_user_id"],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * IAM binding imports use space-delimited identifiers; first the resource in question and then the role.
 *
 * These bindings can be imported using the `secret_id` and role, e.g.
 *
 * ```sh
 * $ pulumi import yandex:index/lockboxSecretIamBinding:LockboxSecretIamBinding viewer "secret_id viewer"
 * ```
 */
export class LockboxSecretIamBinding extends pulumi.CustomResource {
    /**
     * Get an existing LockboxSecretIamBinding resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LockboxSecretIamBindingState, opts?: pulumi.CustomResourceOptions): LockboxSecretIamBinding {
        return new LockboxSecretIamBinding(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/lockboxSecretIamBinding:LockboxSecretIamBinding';

    /**
     * Returns true if the given object is an instance of LockboxSecretIamBinding.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LockboxSecretIamBinding {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LockboxSecretIamBinding.__pulumiType;
    }

    /**
     * Identities that will be granted the privilege in `role`.
     * Each entry can have one of the following values:
     * * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
     * * **serviceAccount:{service_account_id}**: A unique service account ID.
     * * **system:group:federation:{federation_id}:users**: All users in federation.
     * * **system:group:organization:{organization_id}:users**: All users in organization.
     * * **system:allAuthenticatedUsers**: All authenticated users.
     * * **system:allUsers**: All users, including unauthenticated ones.
     *
     * Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
     */
    public readonly members!: pulumi.Output<string[]>;
    /**
     * The role that should be applied. See [roles](https://cloud.yandex.com/docs/lockbox/security/).
     */
    public readonly role!: pulumi.Output<string>;
    /**
     * The [Yandex Lockbox Secret](https://cloud.yandex.com/docs/lockbox/) Secret ID to apply a binding to.
     */
    public readonly secretId!: pulumi.Output<string>;
    public readonly sleepAfter!: pulumi.Output<number | undefined>;

    /**
     * Create a LockboxSecretIamBinding resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LockboxSecretIamBindingArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LockboxSecretIamBindingArgs | LockboxSecretIamBindingState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as LockboxSecretIamBindingState | undefined;
            resourceInputs["members"] = state ? state.members : undefined;
            resourceInputs["role"] = state ? state.role : undefined;
            resourceInputs["secretId"] = state ? state.secretId : undefined;
            resourceInputs["sleepAfter"] = state ? state.sleepAfter : undefined;
        } else {
            const args = argsOrState as LockboxSecretIamBindingArgs | undefined;
            if ((!args || args.members === undefined) && !opts.urn) {
                throw new Error("Missing required property 'members'");
            }
            if ((!args || args.role === undefined) && !opts.urn) {
                throw new Error("Missing required property 'role'");
            }
            if ((!args || args.secretId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'secretId'");
            }
            resourceInputs["members"] = args ? args.members : undefined;
            resourceInputs["role"] = args ? args.role : undefined;
            resourceInputs["secretId"] = args ? args.secretId : undefined;
            resourceInputs["sleepAfter"] = args ? args.sleepAfter : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(LockboxSecretIamBinding.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LockboxSecretIamBinding resources.
 */
export interface LockboxSecretIamBindingState {
    /**
     * Identities that will be granted the privilege in `role`.
     * Each entry can have one of the following values:
     * * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
     * * **serviceAccount:{service_account_id}**: A unique service account ID.
     * * **system:group:federation:{federation_id}:users**: All users in federation.
     * * **system:group:organization:{organization_id}:users**: All users in organization.
     * * **system:allAuthenticatedUsers**: All authenticated users.
     * * **system:allUsers**: All users, including unauthenticated ones.
     *
     * Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
     */
    members?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The role that should be applied. See [roles](https://cloud.yandex.com/docs/lockbox/security/).
     */
    role?: pulumi.Input<string>;
    /**
     * The [Yandex Lockbox Secret](https://cloud.yandex.com/docs/lockbox/) Secret ID to apply a binding to.
     */
    secretId?: pulumi.Input<string>;
    sleepAfter?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a LockboxSecretIamBinding resource.
 */
export interface LockboxSecretIamBindingArgs {
    /**
     * Identities that will be granted the privilege in `role`.
     * Each entry can have one of the following values:
     * * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
     * * **serviceAccount:{service_account_id}**: A unique service account ID.
     * * **system:group:federation:{federation_id}:users**: All users in federation.
     * * **system:group:organization:{organization_id}:users**: All users in organization.
     * * **system:allAuthenticatedUsers**: All authenticated users.
     * * **system:allUsers**: All users, including unauthenticated ones.
     *
     * Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
     */
    members: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The role that should be applied. See [roles](https://cloud.yandex.com/docs/lockbox/security/).
     */
    role: pulumi.Input<string>;
    /**
     * The [Yandex Lockbox Secret](https://cloud.yandex.com/docs/lockbox/) Secret ID to apply a binding to.
     */
    secretId: pulumi.Input<string>;
    sleepAfter?: pulumi.Input<number>;
}
