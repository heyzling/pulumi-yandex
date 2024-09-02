// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Allows creation and management of a single member for a single binding within
 * the IAM policy for an existing Yandex Resource Manager cloud.
 *
 * > **Note:** Roles controlled by `yandex.ResourcemanagerCloudIamBinding`
 *    should not be assigned using `yandex.ResourcemanagerCloudIamMember`.
 *
 * > **Note:** When you delete `yandex.ResourcemanagerCloudIamBinding` resource,
 *    the roles can be deleted from other users within the cloud as well. Be careful!
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const department1 = yandex.getResourcemanagerCloud({
 *     name: "Department 1",
 * });
 * const admin = new yandex.ResourcemanagerCloudIamMember("admin", {
 *     cloudId: department1.then(department1 => department1.id),
 *     member: "userAccount:user_id",
 *     role: "editor",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * IAM member imports use space-delimited identifiers; the resource in question, the role, and the account.
 *
 * This member resource can be imported using the `cloud id`, role, and account, e.g.
 *
 * ```sh
 * $ pulumi import yandex:index/resourcemanagerCloudIamMember:ResourcemanagerCloudIamMember my_project "cloud_id viewer foo@example.com"
 * ```
 */
export class ResourcemanagerCloudIamMember extends pulumi.CustomResource {
    /**
     * Get an existing ResourcemanagerCloudIamMember resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ResourcemanagerCloudIamMemberState, opts?: pulumi.CustomResourceOptions): ResourcemanagerCloudIamMember {
        return new ResourcemanagerCloudIamMember(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/resourcemanagerCloudIamMember:ResourcemanagerCloudIamMember';

    /**
     * Returns true if the given object is an instance of ResourcemanagerCloudIamMember.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ResourcemanagerCloudIamMember {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ResourcemanagerCloudIamMember.__pulumiType;
    }

    /**
     * ID of the cloud to attach a policy to.
     */
    public readonly cloudId!: pulumi.Output<string>;
    /**
     * The identity that will be granted the privilege that is specified in the `role` field.
     * This field can have one of the following values:
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
    public readonly member!: pulumi.Output<string>;
    /**
     * The role that should be assigned.
     */
    public readonly role!: pulumi.Output<string>;
    public readonly sleepAfter!: pulumi.Output<number | undefined>;

    /**
     * Create a ResourcemanagerCloudIamMember resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ResourcemanagerCloudIamMemberArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ResourcemanagerCloudIamMemberArgs | ResourcemanagerCloudIamMemberState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ResourcemanagerCloudIamMemberState | undefined;
            resourceInputs["cloudId"] = state ? state.cloudId : undefined;
            resourceInputs["member"] = state ? state.member : undefined;
            resourceInputs["role"] = state ? state.role : undefined;
            resourceInputs["sleepAfter"] = state ? state.sleepAfter : undefined;
        } else {
            const args = argsOrState as ResourcemanagerCloudIamMemberArgs | undefined;
            if ((!args || args.cloudId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cloudId'");
            }
            if ((!args || args.member === undefined) && !opts.urn) {
                throw new Error("Missing required property 'member'");
            }
            if ((!args || args.role === undefined) && !opts.urn) {
                throw new Error("Missing required property 'role'");
            }
            resourceInputs["cloudId"] = args ? args.cloudId : undefined;
            resourceInputs["member"] = args ? args.member : undefined;
            resourceInputs["role"] = args ? args.role : undefined;
            resourceInputs["sleepAfter"] = args ? args.sleepAfter : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ResourcemanagerCloudIamMember.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ResourcemanagerCloudIamMember resources.
 */
export interface ResourcemanagerCloudIamMemberState {
    /**
     * ID of the cloud to attach a policy to.
     */
    cloudId?: pulumi.Input<string>;
    /**
     * The identity that will be granted the privilege that is specified in the `role` field.
     * This field can have one of the following values:
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
    member?: pulumi.Input<string>;
    /**
     * The role that should be assigned.
     */
    role?: pulumi.Input<string>;
    sleepAfter?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a ResourcemanagerCloudIamMember resource.
 */
export interface ResourcemanagerCloudIamMemberArgs {
    /**
     * ID of the cloud to attach a policy to.
     */
    cloudId: pulumi.Input<string>;
    /**
     * The identity that will be granted the privilege that is specified in the `role` field.
     * This field can have one of the following values:
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
    member: pulumi.Input<string>;
    /**
     * The role that should be assigned.
     */
    role: pulumi.Input<string>;
    sleepAfter?: pulumi.Input<number>;
}
