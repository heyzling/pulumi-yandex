// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Manages a user of a Kafka cluster within the Yandex.Cloud. For more information, see
 * [the official documentation](https://cloud.yandex.com/docs/managed-kafka/concepts).
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const foo = new yandex.MdbKafkaCluster("foo", {
 *     networkId: "c64vs98keiqc7f24pvkd",
 *     config: {
 *         version: "2.8",
 *         zones: ["ru-central1-a"],
 *         kafka: {
 *             resources: {
 *                 resourcePresetId: "s2.micro",
 *                 diskTypeId: "network-hdd",
 *                 diskSize: 16,
 *             },
 *         },
 *     },
 * });
 * const events = new yandex.MdbKafkaTopic("events", {
 *     clusterId: foo.id,
 *     partitions: 4,
 *     replicationFactor: 1,
 * });
 * const userEvents = new yandex.MdbKafkaUser("userEvents", {
 *     clusterId: foo.id,
 *     password: "pass1231232332",
 *     permissions: [
 *         {
 *             topicName: "events",
 *             role: "ACCESS_ROLE_CONSUMER",
 *             allowHosts: [
 *                 "host1.db.yandex.net",
 *                 "host2.db.yandex.net",
 *             ],
 *         },
 *         {
 *             topicName: "events",
 *             role: "ACCESS_ROLE_PRODUCER",
 *         },
 *     ],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * Kafka user can be imported using following format:
 *
 * ```sh
 * $ pulumi import yandex:index/mdbKafkaUser:MdbKafkaUser foo {{cluster_id}}:{{user_name}}
 * ```
 */
export class MdbKafkaUser extends pulumi.CustomResource {
    /**
     * Get an existing MdbKafkaUser resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MdbKafkaUserState, opts?: pulumi.CustomResourceOptions): MdbKafkaUser {
        return new MdbKafkaUser(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/mdbKafkaUser:MdbKafkaUser';

    /**
     * Returns true if the given object is an instance of MdbKafkaUser.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MdbKafkaUser {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MdbKafkaUser.__pulumiType;
    }

    public readonly clusterId!: pulumi.Output<string>;
    /**
     * The name of the user.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The password of the user.
     */
    public readonly password!: pulumi.Output<string>;
    /**
     * Set of permissions granted to the user. The structure is documented below.
     */
    public readonly permissions!: pulumi.Output<outputs.MdbKafkaUserPermission[] | undefined>;

    /**
     * Create a MdbKafkaUser resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MdbKafkaUserArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MdbKafkaUserArgs | MdbKafkaUserState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as MdbKafkaUserState | undefined;
            resourceInputs["clusterId"] = state ? state.clusterId : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["password"] = state ? state.password : undefined;
            resourceInputs["permissions"] = state ? state.permissions : undefined;
        } else {
            const args = argsOrState as MdbKafkaUserArgs | undefined;
            if ((!args || args.clusterId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterId'");
            }
            if ((!args || args.password === undefined) && !opts.urn) {
                throw new Error("Missing required property 'password'");
            }
            resourceInputs["clusterId"] = args ? args.clusterId : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["password"] = args?.password ? pulumi.secret(args.password) : undefined;
            resourceInputs["permissions"] = args ? args.permissions : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["password"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(MdbKafkaUser.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering MdbKafkaUser resources.
 */
export interface MdbKafkaUserState {
    clusterId?: pulumi.Input<string>;
    /**
     * The name of the user.
     */
    name?: pulumi.Input<string>;
    /**
     * The password of the user.
     */
    password?: pulumi.Input<string>;
    /**
     * Set of permissions granted to the user. The structure is documented below.
     */
    permissions?: pulumi.Input<pulumi.Input<inputs.MdbKafkaUserPermission>[]>;
}

/**
 * The set of arguments for constructing a MdbKafkaUser resource.
 */
export interface MdbKafkaUserArgs {
    clusterId: pulumi.Input<string>;
    /**
     * The name of the user.
     */
    name?: pulumi.Input<string>;
    /**
     * The password of the user.
     */
    password: pulumi.Input<string>;
    /**
     * Set of permissions granted to the user. The structure is documented below.
     */
    permissions?: pulumi.Input<pulumi.Input<inputs.MdbKafkaUserPermission>[]>;
}
