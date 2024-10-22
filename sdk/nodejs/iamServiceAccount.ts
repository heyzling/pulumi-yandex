// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Allows management of a Yandex.Cloud IAM [service account](https://cloud.yandex.com/docs/iam/concepts/users/service-accounts).
 * To assign roles and permissions, use the yandex_iam_service_account_iam_binding,
 * yandex.IamServiceAccountIamMember and
 * yandex.IamServiceAccountIamPolicy resources.
 *
 * ## Example Usage
 *
 * This snippet creates a service account.
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const sa = new yandex.IamServiceAccount("sa", {description: "service account to manage VMs"});
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * A service account can be imported using the `id` of the resource, e.g.
 *
 * ```sh
 * $ pulumi import yandex:index/iamServiceAccount:IamServiceAccount sa account_id
 * ```
 */
export class IamServiceAccount extends pulumi.CustomResource {
    /**
     * Get an existing IamServiceAccount resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: IamServiceAccountState, opts?: pulumi.CustomResourceOptions): IamServiceAccount {
        return new IamServiceAccount(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/iamServiceAccount:IamServiceAccount';

    /**
     * Returns true if the given object is an instance of IamServiceAccount.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IamServiceAccount {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IamServiceAccount.__pulumiType;
    }

    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * Description of the service account.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * ID of the folder that the service account will be created in.
     * Defaults to the provider folder configuration.
     */
    public readonly folderId!: pulumi.Output<string>;
    /**
     * Name of the service account.
     * Can be updated without creating a new resource.
     */
    public readonly name!: pulumi.Output<string>;

    /**
     * Create a IamServiceAccount resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: IamServiceAccountArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: IamServiceAccountArgs | IamServiceAccountState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as IamServiceAccountState | undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
        } else {
            const args = argsOrState as IamServiceAccountArgs | undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(IamServiceAccount.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering IamServiceAccount resources.
 */
export interface IamServiceAccountState {
    createdAt?: pulumi.Input<string>;
    /**
     * Description of the service account.
     */
    description?: pulumi.Input<string>;
    /**
     * ID of the folder that the service account will be created in.
     * Defaults to the provider folder configuration.
     */
    folderId?: pulumi.Input<string>;
    /**
     * Name of the service account.
     * Can be updated without creating a new resource.
     */
    name?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a IamServiceAccount resource.
 */
export interface IamServiceAccountArgs {
    /**
     * Description of the service account.
     */
    description?: pulumi.Input<string>;
    /**
     * ID of the folder that the service account will be created in.
     * Defaults to the provider folder configuration.
     */
    folderId?: pulumi.Input<string>;
    /**
     * Name of the service account.
     * Can be updated without creating a new resource.
     */
    name?: pulumi.Input<string>;
}
