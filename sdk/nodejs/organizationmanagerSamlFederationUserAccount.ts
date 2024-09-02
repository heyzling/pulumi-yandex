// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const account = new yandex.OrganizationmanagerSamlFederationUserAccount("account", {
 *     federationId: "some_federation_id",
 *     nameId: "example@example.org",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * A Yandex SAML Federation user account can be imported using the `id` of the resource, e.g.:
 *
 * ```sh
 * $ pulumi import yandex:index/organizationmanagerSamlFederationUserAccount:OrganizationmanagerSamlFederationUserAccount account "user_id"
 * ```
 */
export class OrganizationmanagerSamlFederationUserAccount extends pulumi.CustomResource {
    /**
     * Get an existing OrganizationmanagerSamlFederationUserAccount resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: OrganizationmanagerSamlFederationUserAccountState, opts?: pulumi.CustomResourceOptions): OrganizationmanagerSamlFederationUserAccount {
        return new OrganizationmanagerSamlFederationUserAccount(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/organizationmanagerSamlFederationUserAccount:OrganizationmanagerSamlFederationUserAccount';

    /**
     * Returns true if the given object is an instance of OrganizationmanagerSamlFederationUserAccount.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is OrganizationmanagerSamlFederationUserAccount {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === OrganizationmanagerSamlFederationUserAccount.__pulumiType;
    }

    /**
     * ID of a SAML Federation.
     */
    public readonly federationId!: pulumi.Output<string>;
    /**
     * Name ID of the SAML federated user.
     * *
     */
    public readonly nameId!: pulumi.Output<string>;

    /**
     * Create a OrganizationmanagerSamlFederationUserAccount resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OrganizationmanagerSamlFederationUserAccountArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: OrganizationmanagerSamlFederationUserAccountArgs | OrganizationmanagerSamlFederationUserAccountState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as OrganizationmanagerSamlFederationUserAccountState | undefined;
            resourceInputs["federationId"] = state ? state.federationId : undefined;
            resourceInputs["nameId"] = state ? state.nameId : undefined;
        } else {
            const args = argsOrState as OrganizationmanagerSamlFederationUserAccountArgs | undefined;
            if ((!args || args.federationId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'federationId'");
            }
            if ((!args || args.nameId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'nameId'");
            }
            resourceInputs["federationId"] = args ? args.federationId : undefined;
            resourceInputs["nameId"] = args ? args.nameId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(OrganizationmanagerSamlFederationUserAccount.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering OrganizationmanagerSamlFederationUserAccount resources.
 */
export interface OrganizationmanagerSamlFederationUserAccountState {
    /**
     * ID of a SAML Federation.
     */
    federationId?: pulumi.Input<string>;
    /**
     * Name ID of the SAML federated user.
     * *
     */
    nameId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a OrganizationmanagerSamlFederationUserAccount resource.
 */
export interface OrganizationmanagerSamlFederationUserAccountArgs {
    /**
     * ID of a SAML Federation.
     */
    federationId: pulumi.Input<string>;
    /**
     * Name ID of the SAML federated user.
     * *
     */
    nameId: pulumi.Input<string>;
}