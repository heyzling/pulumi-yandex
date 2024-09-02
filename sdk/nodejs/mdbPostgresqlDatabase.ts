// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Manages a PostgreSQL database within the Yandex.Cloud. For more information, see
 * [the official documentation](https://cloud.yandex.com/docs/managed-postgresql/).
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const fooVpcNetwork = new yandex.VpcNetwork("fooVpcNetwork", {});
 * const fooVpcSubnet = new yandex.VpcSubnet("fooVpcSubnet", {
 *     zone: "ru-central1-a",
 *     networkId: fooVpcNetwork.id,
 *     v4CidrBlocks: ["10.5.0.0/24"],
 * });
 * const fooMdbPostgresqlCluster = new yandex.MdbPostgresqlCluster("fooMdbPostgresqlCluster", {
 *     environment: "PRESTABLE",
 *     networkId: fooVpcNetwork.id,
 *     config: {
 *         version: "15",
 *         resources: {
 *             resourcePresetId: "s2.micro",
 *             diskTypeId: "network-ssd",
 *             diskSize: 16,
 *         },
 *     },
 *     hosts: [{
 *         zone: "ru-central1-a",
 *         subnetId: fooVpcSubnet.id,
 *     }],
 * });
 * const fooMdbPostgresqlDatabase = new yandex.MdbPostgresqlDatabase("fooMdbPostgresqlDatabase", {
 *     clusterId: fooMdbPostgresqlCluster.id,
 *     owner: yandex_mdb_postgresql_user.alice.name,
 *     lcCollate: "en_US.UTF-8",
 *     lcType: "en_US.UTF-8",
 *     extensions: [
 *         {
 *             name: "uuid-ossp",
 *         },
 *         {
 *             name: "xml2",
 *         },
 *     ],
 * });
 * const fooMdbPostgresqlUser = new yandex.MdbPostgresqlUser("fooMdbPostgresqlUser", {
 *     clusterId: fooMdbPostgresqlCluster.id,
 *     password: "password",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * A PostgreSQL database can be imported using the following format:
 *
 * ```sh
 * $ pulumi import yandex:index/mdbPostgresqlDatabase:MdbPostgresqlDatabase foo {{cluster_id}}:{{database_name}}
 * ```
 */
export class MdbPostgresqlDatabase extends pulumi.CustomResource {
    /**
     * Get an existing MdbPostgresqlDatabase resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MdbPostgresqlDatabaseState, opts?: pulumi.CustomResourceOptions): MdbPostgresqlDatabase {
        return new MdbPostgresqlDatabase(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/mdbPostgresqlDatabase:MdbPostgresqlDatabase';

    /**
     * Returns true if the given object is an instance of MdbPostgresqlDatabase.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MdbPostgresqlDatabase {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MdbPostgresqlDatabase.__pulumiType;
    }

    public readonly clusterId!: pulumi.Output<string>;
    /**
     * Inhibits deletion of the database. Can either be `true`, `false` or `unspecified`.
     */
    public readonly deletionProtection!: pulumi.Output<string | undefined>;
    /**
     * Set of database extensions. The structure is documented below
     */
    public readonly extensions!: pulumi.Output<outputs.MdbPostgresqlDatabaseExtension[] | undefined>;
    /**
     * POSIX locale for string sorting order. Forbidden to change in an existing database.
     */
    public readonly lcCollate!: pulumi.Output<string | undefined>;
    /**
     * POSIX locale for character classification. Forbidden to change in an existing database.
     */
    public readonly lcType!: pulumi.Output<string | undefined>;
    /**
     * The name of the database.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Name of the user assigned as the owner of the database. Forbidden to change in an existing database.
     */
    public readonly owner!: pulumi.Output<string>;
    /**
     * Name of the template database.
     */
    public readonly templateDb!: pulumi.Output<string | undefined>;

    /**
     * Create a MdbPostgresqlDatabase resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MdbPostgresqlDatabaseArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MdbPostgresqlDatabaseArgs | MdbPostgresqlDatabaseState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as MdbPostgresqlDatabaseState | undefined;
            resourceInputs["clusterId"] = state ? state.clusterId : undefined;
            resourceInputs["deletionProtection"] = state ? state.deletionProtection : undefined;
            resourceInputs["extensions"] = state ? state.extensions : undefined;
            resourceInputs["lcCollate"] = state ? state.lcCollate : undefined;
            resourceInputs["lcType"] = state ? state.lcType : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["owner"] = state ? state.owner : undefined;
            resourceInputs["templateDb"] = state ? state.templateDb : undefined;
        } else {
            const args = argsOrState as MdbPostgresqlDatabaseArgs | undefined;
            if ((!args || args.clusterId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterId'");
            }
            if ((!args || args.owner === undefined) && !opts.urn) {
                throw new Error("Missing required property 'owner'");
            }
            resourceInputs["clusterId"] = args ? args.clusterId : undefined;
            resourceInputs["deletionProtection"] = args ? args.deletionProtection : undefined;
            resourceInputs["extensions"] = args ? args.extensions : undefined;
            resourceInputs["lcCollate"] = args ? args.lcCollate : undefined;
            resourceInputs["lcType"] = args ? args.lcType : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["owner"] = args ? args.owner : undefined;
            resourceInputs["templateDb"] = args ? args.templateDb : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(MdbPostgresqlDatabase.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering MdbPostgresqlDatabase resources.
 */
export interface MdbPostgresqlDatabaseState {
    clusterId?: pulumi.Input<string>;
    /**
     * Inhibits deletion of the database. Can either be `true`, `false` or `unspecified`.
     */
    deletionProtection?: pulumi.Input<string>;
    /**
     * Set of database extensions. The structure is documented below
     */
    extensions?: pulumi.Input<pulumi.Input<inputs.MdbPostgresqlDatabaseExtension>[]>;
    /**
     * POSIX locale for string sorting order. Forbidden to change in an existing database.
     */
    lcCollate?: pulumi.Input<string>;
    /**
     * POSIX locale for character classification. Forbidden to change in an existing database.
     */
    lcType?: pulumi.Input<string>;
    /**
     * The name of the database.
     */
    name?: pulumi.Input<string>;
    /**
     * Name of the user assigned as the owner of the database. Forbidden to change in an existing database.
     */
    owner?: pulumi.Input<string>;
    /**
     * Name of the template database.
     */
    templateDb?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a MdbPostgresqlDatabase resource.
 */
export interface MdbPostgresqlDatabaseArgs {
    clusterId: pulumi.Input<string>;
    /**
     * Inhibits deletion of the database. Can either be `true`, `false` or `unspecified`.
     */
    deletionProtection?: pulumi.Input<string>;
    /**
     * Set of database extensions. The structure is documented below
     */
    extensions?: pulumi.Input<pulumi.Input<inputs.MdbPostgresqlDatabaseExtension>[]>;
    /**
     * POSIX locale for string sorting order. Forbidden to change in an existing database.
     */
    lcCollate?: pulumi.Input<string>;
    /**
     * POSIX locale for character classification. Forbidden to change in an existing database.
     */
    lcType?: pulumi.Input<string>;
    /**
     * The name of the database.
     */
    name?: pulumi.Input<string>;
    /**
     * Name of the user assigned as the owner of the database. Forbidden to change in an existing database.
     */
    owner: pulumi.Input<string>;
    /**
     * Name of the template database.
     */
    templateDb?: pulumi.Input<string>;
}