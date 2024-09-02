// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## yandex\_function\_iam\_binding
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const function_iam = new yandex.FunctionIamBinding("function-iam", {
 *     functionId: "your-function-id",
 *     members: ["system:allUsers"],
 *     role: "serverless.functions.invoker",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class FunctionIamBinding extends pulumi.CustomResource {
    /**
     * Get an existing FunctionIamBinding resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FunctionIamBindingState, opts?: pulumi.CustomResourceOptions): FunctionIamBinding {
        return new FunctionIamBinding(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/functionIamBinding:FunctionIamBinding';

    /**
     * Returns true if the given object is an instance of FunctionIamBinding.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FunctionIamBinding {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FunctionIamBinding.__pulumiType;
    }

    /**
     * The [Yandex Cloud Function](https://cloud.yandex.com/docs/functions/) ID to apply a binding to.
     */
    public readonly functionId!: pulumi.Output<string>;
    /**
     * Identities that will be granted the privilege in `role`.
     * Each entry can have one of the following values:
     * * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
     * * **serviceAccount:{service_account_id}**: A unique service account ID.
     * * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
     * * **group:{group_id}**: A unique group ID.
     * * **system:group:federation:{federation_id}:users**: All users in federation.
     * * **system:group:organization:{organization_id}:users**: All users in organization.
     * * **system:allAuthenticatedUsers**: All authenticated users.
     * * **system:allUsers**: All users, including unauthenticated ones.
     *
     * Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
     */
    public readonly members!: pulumi.Output<string[]>;
    /**
     * The role that should be applied. See [roles](https://cloud.yandex.com/docs/functions/security/)
     */
    public readonly role!: pulumi.Output<string>;
    public readonly sleepAfter!: pulumi.Output<number | undefined>;

    /**
     * Create a FunctionIamBinding resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FunctionIamBindingArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FunctionIamBindingArgs | FunctionIamBindingState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as FunctionIamBindingState | undefined;
            resourceInputs["functionId"] = state ? state.functionId : undefined;
            resourceInputs["members"] = state ? state.members : undefined;
            resourceInputs["role"] = state ? state.role : undefined;
            resourceInputs["sleepAfter"] = state ? state.sleepAfter : undefined;
        } else {
            const args = argsOrState as FunctionIamBindingArgs | undefined;
            if ((!args || args.functionId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'functionId'");
            }
            if ((!args || args.members === undefined) && !opts.urn) {
                throw new Error("Missing required property 'members'");
            }
            if ((!args || args.role === undefined) && !opts.urn) {
                throw new Error("Missing required property 'role'");
            }
            resourceInputs["functionId"] = args ? args.functionId : undefined;
            resourceInputs["members"] = args ? args.members : undefined;
            resourceInputs["role"] = args ? args.role : undefined;
            resourceInputs["sleepAfter"] = args ? args.sleepAfter : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(FunctionIamBinding.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering FunctionIamBinding resources.
 */
export interface FunctionIamBindingState {
    /**
     * The [Yandex Cloud Function](https://cloud.yandex.com/docs/functions/) ID to apply a binding to.
     */
    functionId?: pulumi.Input<string>;
    /**
     * Identities that will be granted the privilege in `role`.
     * Each entry can have one of the following values:
     * * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
     * * **serviceAccount:{service_account_id}**: A unique service account ID.
     * * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
     * * **group:{group_id}**: A unique group ID.
     * * **system:group:federation:{federation_id}:users**: All users in federation.
     * * **system:group:organization:{organization_id}:users**: All users in organization.
     * * **system:allAuthenticatedUsers**: All authenticated users.
     * * **system:allUsers**: All users, including unauthenticated ones.
     *
     * Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
     */
    members?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The role that should be applied. See [roles](https://cloud.yandex.com/docs/functions/security/)
     */
    role?: pulumi.Input<string>;
    sleepAfter?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a FunctionIamBinding resource.
 */
export interface FunctionIamBindingArgs {
    /**
     * The [Yandex Cloud Function](https://cloud.yandex.com/docs/functions/) ID to apply a binding to.
     */
    functionId: pulumi.Input<string>;
    /**
     * Identities that will be granted the privilege in `role`.
     * Each entry can have one of the following values:
     * * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
     * * **serviceAccount:{service_account_id}**: A unique service account ID.
     * * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
     * * **group:{group_id}**: A unique group ID.
     * * **system:group:federation:{federation_id}:users**: All users in federation.
     * * **system:group:organization:{organization_id}:users**: All users in organization.
     * * **system:allAuthenticatedUsers**: All authenticated users.
     * * **system:allUsers**: All users, including unauthenticated ones.
     *
     * Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
     */
    members: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The role that should be applied. See [roles](https://cloud.yandex.com/docs/functions/security/)
     */
    role: pulumi.Input<string>;
    sleepAfter?: pulumi.Input<number>;
}