// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Creates a new container repository lifecycle policy. For more information, see
 * [the official documentation](https://cloud.yandex.com/en-ru/docs/container-registry/concepts/lifecycle-policy)
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const myRegistry = new yandex.ContainerRegistry("myRegistry", {});
 * const myRepository = new yandex.ContainerRepository("myRepository", {});
 * const myLifecyclePolicy = new yandex.ContainerRepositoryLifecyclePolicy("myLifecyclePolicy", {
 *     status: "active",
 *     repositoryId: myRepository.id,
 *     rules: [{
 *         description: "my description",
 *         untagged: true,
 *         tagRegexp: ".*",
 *         retainedTop: 1,
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * A lifecycle policy can be imported using the `id` of the resource, e.g.
 *
 * bash
 *
 * ```sh
 * $ pulumi import yandex:index/containerRepositoryLifecyclePolicy:ContainerRepositoryLifecyclePolicy my_lifecycle_policy lifecycle_policy_id
 * ```
 */
export class ContainerRepositoryLifecyclePolicy extends pulumi.CustomResource {
    /**
     * Get an existing ContainerRepositoryLifecyclePolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ContainerRepositoryLifecyclePolicyState, opts?: pulumi.CustomResourceOptions): ContainerRepositoryLifecyclePolicy {
        return new ContainerRepositoryLifecyclePolicy(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/containerRepositoryLifecyclePolicy:ContainerRepositoryLifecyclePolicy';

    /**
     * Returns true if the given object is an instance of ContainerRepositoryLifecyclePolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ContainerRepositoryLifecyclePolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ContainerRepositoryLifecyclePolicy.__pulumiType;
    }

    /**
     * Creation timestamp of the instance.
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * Description of the lifecycle policy.
     */
    public readonly description!: pulumi.Output<string>;
    /**
     * Lifecycle policy name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The ID of the repository that the resource belongs to.
     */
    public readonly repositoryId!: pulumi.Output<string>;
    public readonly rules!: pulumi.Output<outputs.ContainerRepositoryLifecyclePolicyRule[]>;
    /**
     * The status of lifecycle policy. Must be `active` or `disabled`.
     */
    public readonly status!: pulumi.Output<string>;

    /**
     * Create a ContainerRepositoryLifecyclePolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ContainerRepositoryLifecyclePolicyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ContainerRepositoryLifecyclePolicyArgs | ContainerRepositoryLifecyclePolicyState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ContainerRepositoryLifecyclePolicyState | undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["repositoryId"] = state ? state.repositoryId : undefined;
            resourceInputs["rules"] = state ? state.rules : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
        } else {
            const args = argsOrState as ContainerRepositoryLifecyclePolicyArgs | undefined;
            if ((!args || args.repositoryId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'repositoryId'");
            }
            if ((!args || args.status === undefined) && !opts.urn) {
                throw new Error("Missing required property 'status'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["repositoryId"] = args ? args.repositoryId : undefined;
            resourceInputs["rules"] = args ? args.rules : undefined;
            resourceInputs["status"] = args ? args.status : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ContainerRepositoryLifecyclePolicy.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ContainerRepositoryLifecyclePolicy resources.
 */
export interface ContainerRepositoryLifecyclePolicyState {
    /**
     * Creation timestamp of the instance.
     */
    createdAt?: pulumi.Input<string>;
    /**
     * Description of the lifecycle policy.
     */
    description?: pulumi.Input<string>;
    /**
     * Lifecycle policy name.
     */
    name?: pulumi.Input<string>;
    /**
     * The ID of the repository that the resource belongs to.
     */
    repositoryId?: pulumi.Input<string>;
    rules?: pulumi.Input<pulumi.Input<inputs.ContainerRepositoryLifecyclePolicyRule>[]>;
    /**
     * The status of lifecycle policy. Must be `active` or `disabled`.
     */
    status?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ContainerRepositoryLifecyclePolicy resource.
 */
export interface ContainerRepositoryLifecyclePolicyArgs {
    /**
     * Description of the lifecycle policy.
     */
    description?: pulumi.Input<string>;
    /**
     * Lifecycle policy name.
     */
    name?: pulumi.Input<string>;
    /**
     * The ID of the repository that the resource belongs to.
     */
    repositoryId: pulumi.Input<string>;
    rules?: pulumi.Input<pulumi.Input<inputs.ContainerRepositoryLifecyclePolicyRule>[]>;
    /**
     * The status of lifecycle policy. Must be `active` or `disabled`.
     */
    status: pulumi.Input<string>;
}
