// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Allows creation and management of a single member for a single binding within
 * the IAM policy for an existing Yandex Organization Manager Group.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const editor = new yandex.OrganizationmanagerGroupIamMember("editor", {
 *     groupId: "some_group_id",
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
 * This member resource can be imported using the `group_id`, role, and account, e.g.
 *
 * ```sh
 * $ pulumi import yandex:index/organizationmanagerGroupIamMember:OrganizationmanagerGroupIamMember my_project "group_id viewer foo@example.com"
 * ```
 */
export class OrganizationmanagerGroupIamMember extends pulumi.CustomResource {
    /**
     * Get an existing OrganizationmanagerGroupIamMember resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: OrganizationmanagerGroupIamMemberState, opts?: pulumi.CustomResourceOptions): OrganizationmanagerGroupIamMember {
        return new OrganizationmanagerGroupIamMember(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/organizationmanagerGroupIamMember:OrganizationmanagerGroupIamMember';

    /**
     * Returns true if the given object is an instance of OrganizationmanagerGroupIamMember.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is OrganizationmanagerGroupIamMember {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === OrganizationmanagerGroupIamMember.__pulumiType;
    }

    /**
     * ID of the organization to attach a policy to.
     */
    public readonly groupId!: pulumi.Output<string>;
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
     * Create a OrganizationmanagerGroupIamMember resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OrganizationmanagerGroupIamMemberArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: OrganizationmanagerGroupIamMemberArgs | OrganizationmanagerGroupIamMemberState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as OrganizationmanagerGroupIamMemberState | undefined;
            resourceInputs["groupId"] = state ? state.groupId : undefined;
            resourceInputs["member"] = state ? state.member : undefined;
            resourceInputs["role"] = state ? state.role : undefined;
            resourceInputs["sleepAfter"] = state ? state.sleepAfter : undefined;
        } else {
            const args = argsOrState as OrganizationmanagerGroupIamMemberArgs | undefined;
            if ((!args || args.groupId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'groupId'");
            }
            if ((!args || args.member === undefined) && !opts.urn) {
                throw new Error("Missing required property 'member'");
            }
            if ((!args || args.role === undefined) && !opts.urn) {
                throw new Error("Missing required property 'role'");
            }
            resourceInputs["groupId"] = args ? args.groupId : undefined;
            resourceInputs["member"] = args ? args.member : undefined;
            resourceInputs["role"] = args ? args.role : undefined;
            resourceInputs["sleepAfter"] = args ? args.sleepAfter : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(OrganizationmanagerGroupIamMember.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering OrganizationmanagerGroupIamMember resources.
 */
export interface OrganizationmanagerGroupIamMemberState {
    /**
     * ID of the organization to attach a policy to.
     */
    groupId?: pulumi.Input<string>;
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
 * The set of arguments for constructing a OrganizationmanagerGroupIamMember resource.
 */
export interface OrganizationmanagerGroupIamMemberArgs {
    /**
     * ID of the organization to attach a policy to.
     */
    groupId: pulumi.Input<string>;
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