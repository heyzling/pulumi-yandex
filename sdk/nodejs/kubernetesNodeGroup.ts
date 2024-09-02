// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Creates a Yandex Kubernetes Node Group.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const myNodeGroup = new yandex.KubernetesNodeGroup("myNodeGroup", {
 *     allocationPolicy: {
 *         locations: [{
 *             zone: "ru-central1-a",
 *         }],
 *     },
 *     clusterId: yandex_kubernetes_cluster.my_cluster.id,
 *     description: "description",
 *     instanceTemplate: {
 *         bootDisk: {
 *             size: 64,
 *             type: "network-hdd",
 *         },
 *         containerRuntime: {
 *             type: "containerd",
 *         },
 *         networkInterfaces: [{
 *             nat: true,
 *             subnetIds: [yandex_vpc_subnet.my_subnet.id],
 *         }],
 *         platformId: "standard-v2",
 *         resources: {
 *             cores: 2,
 *             memory: 2,
 *         },
 *         schedulingPolicy: {
 *             preemptible: false,
 *         },
 *     },
 *     labels: {
 *         key: "value",
 *     },
 *     maintenancePolicy: {
 *         autoRepair: true,
 *         autoUpgrade: true,
 *         maintenanceWindows: [
 *             {
 *                 day: "monday",
 *                 duration: "3h",
 *                 startTime: "15:00",
 *             },
 *             {
 *                 day: "friday",
 *                 duration: "4h30m",
 *                 startTime: "10:00",
 *             },
 *         ],
 *     },
 *     scalePolicy: {
 *         fixedScale: {
 *             size: 1,
 *         },
 *     },
 *     version: "1.17",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * A Yandex Kubernetes Node Group can be imported using the `id` of the resource, e.g.:
 *
 * ```sh
 * $ pulumi import yandex:index/kubernetesNodeGroup:KubernetesNodeGroup default node_group_id
 * ```
 */
export class KubernetesNodeGroup extends pulumi.CustomResource {
    /**
     * Get an existing KubernetesNodeGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: KubernetesNodeGroupState, opts?: pulumi.CustomResourceOptions): KubernetesNodeGroup {
        return new KubernetesNodeGroup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/kubernetesNodeGroup:KubernetesNodeGroup';

    /**
     * Returns true if the given object is an instance of KubernetesNodeGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is KubernetesNodeGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === KubernetesNodeGroup.__pulumiType;
    }

    /**
     * This argument specify subnets (zones), that will be used by node group compute instances. The structure is documented below.
     */
    public readonly allocationPolicy!: pulumi.Output<outputs.KubernetesNodeGroupAllocationPolicy>;
    /**
     * A list of allowed unsafe sysctl parameters for this node group. For more details see [documentation](https://kubernetes.io/docs/tasks/administer-cluster/sysctl-cluster/).
     */
    public readonly allowedUnsafeSysctls!: pulumi.Output<string[] | undefined>;
    /**
     * The ID of the Kubernetes cluster that this node group belongs to.
     */
    public readonly clusterId!: pulumi.Output<string>;
    /**
     * (Computed) The Kubernetes node group creation timestamp.
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * Deploy policy of the node group. The structure is documented below.
     */
    public readonly deployPolicy!: pulumi.Output<outputs.KubernetesNodeGroupDeployPolicy>;
    /**
     * A description of the Kubernetes node group.
     */
    public readonly description!: pulumi.Output<string>;
    /**
     * ID of instance group that is used to manage this Kubernetes node group.
     */
    public /*out*/ readonly instanceGroupId!: pulumi.Output<string>;
    /**
     * Template used to create compute instances in this Kubernetes node group. The structure is documented below.
     */
    public readonly instanceTemplate!: pulumi.Output<outputs.KubernetesNodeGroupInstanceTemplate>;
    /**
     * A set of key/value label pairs assigned to the Kubernetes node group.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string}>;
    /**
     * (Computed) Maintenance policy for this Kubernetes node group.
     * If policy is omitted, automatic revision upgrades are enabled and could happen at any time.
     * Revision upgrades are performed only within the same minor version, e.g. 1.13.
     * Minor version upgrades (e.g. 1.13->1.14) should be performed manually. The structure is documented below.
     */
    public readonly maintenancePolicy!: pulumi.Output<outputs.KubernetesNodeGroupMaintenancePolicy>;
    /**
     * Name of a specific Kubernetes node group.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * A set of key/value label pairs, that are assigned to all the nodes of this Kubernetes node group.
     */
    public readonly nodeLabels!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * A list of Kubernetes taints, that are applied to all the nodes of this Kubernetes node group.
     */
    public readonly nodeTaints!: pulumi.Output<string[] | undefined>;
    /**
     * Scale policy of the node group. The structure is documented below.
     */
    public readonly scalePolicy!: pulumi.Output<outputs.KubernetesNodeGroupScalePolicy>;
    /**
     * (Computed) Status of the Kubernetes node group.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * Version of Kubernetes that will be used for Kubernetes node group.
     */
    public readonly version!: pulumi.Output<string>;
    /**
     * Information about Kubernetes node group version. The structure is documented below.
     */
    public /*out*/ readonly versionInfos!: pulumi.Output<outputs.KubernetesNodeGroupVersionInfo[]>;

    /**
     * Create a KubernetesNodeGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: KubernetesNodeGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: KubernetesNodeGroupArgs | KubernetesNodeGroupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as KubernetesNodeGroupState | undefined;
            resourceInputs["allocationPolicy"] = state ? state.allocationPolicy : undefined;
            resourceInputs["allowedUnsafeSysctls"] = state ? state.allowedUnsafeSysctls : undefined;
            resourceInputs["clusterId"] = state ? state.clusterId : undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["deployPolicy"] = state ? state.deployPolicy : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["instanceGroupId"] = state ? state.instanceGroupId : undefined;
            resourceInputs["instanceTemplate"] = state ? state.instanceTemplate : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["maintenancePolicy"] = state ? state.maintenancePolicy : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["nodeLabels"] = state ? state.nodeLabels : undefined;
            resourceInputs["nodeTaints"] = state ? state.nodeTaints : undefined;
            resourceInputs["scalePolicy"] = state ? state.scalePolicy : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["version"] = state ? state.version : undefined;
            resourceInputs["versionInfos"] = state ? state.versionInfos : undefined;
        } else {
            const args = argsOrState as KubernetesNodeGroupArgs | undefined;
            if ((!args || args.clusterId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterId'");
            }
            if ((!args || args.instanceTemplate === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceTemplate'");
            }
            if ((!args || args.scalePolicy === undefined) && !opts.urn) {
                throw new Error("Missing required property 'scalePolicy'");
            }
            resourceInputs["allocationPolicy"] = args ? args.allocationPolicy : undefined;
            resourceInputs["allowedUnsafeSysctls"] = args ? args.allowedUnsafeSysctls : undefined;
            resourceInputs["clusterId"] = args ? args.clusterId : undefined;
            resourceInputs["deployPolicy"] = args ? args.deployPolicy : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["instanceTemplate"] = args ? args.instanceTemplate : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["maintenancePolicy"] = args ? args.maintenancePolicy : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["nodeLabels"] = args ? args.nodeLabels : undefined;
            resourceInputs["nodeTaints"] = args ? args.nodeTaints : undefined;
            resourceInputs["scalePolicy"] = args ? args.scalePolicy : undefined;
            resourceInputs["version"] = args ? args.version : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["instanceGroupId"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
            resourceInputs["versionInfos"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(KubernetesNodeGroup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering KubernetesNodeGroup resources.
 */
export interface KubernetesNodeGroupState {
    /**
     * This argument specify subnets (zones), that will be used by node group compute instances. The structure is documented below.
     */
    allocationPolicy?: pulumi.Input<inputs.KubernetesNodeGroupAllocationPolicy>;
    /**
     * A list of allowed unsafe sysctl parameters for this node group. For more details see [documentation](https://kubernetes.io/docs/tasks/administer-cluster/sysctl-cluster/).
     */
    allowedUnsafeSysctls?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The ID of the Kubernetes cluster that this node group belongs to.
     */
    clusterId?: pulumi.Input<string>;
    /**
     * (Computed) The Kubernetes node group creation timestamp.
     */
    createdAt?: pulumi.Input<string>;
    /**
     * Deploy policy of the node group. The structure is documented below.
     */
    deployPolicy?: pulumi.Input<inputs.KubernetesNodeGroupDeployPolicy>;
    /**
     * A description of the Kubernetes node group.
     */
    description?: pulumi.Input<string>;
    /**
     * ID of instance group that is used to manage this Kubernetes node group.
     */
    instanceGroupId?: pulumi.Input<string>;
    /**
     * Template used to create compute instances in this Kubernetes node group. The structure is documented below.
     */
    instanceTemplate?: pulumi.Input<inputs.KubernetesNodeGroupInstanceTemplate>;
    /**
     * A set of key/value label pairs assigned to the Kubernetes node group.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * (Computed) Maintenance policy for this Kubernetes node group.
     * If policy is omitted, automatic revision upgrades are enabled and could happen at any time.
     * Revision upgrades are performed only within the same minor version, e.g. 1.13.
     * Minor version upgrades (e.g. 1.13->1.14) should be performed manually. The structure is documented below.
     */
    maintenancePolicy?: pulumi.Input<inputs.KubernetesNodeGroupMaintenancePolicy>;
    /**
     * Name of a specific Kubernetes node group.
     */
    name?: pulumi.Input<string>;
    /**
     * A set of key/value label pairs, that are assigned to all the nodes of this Kubernetes node group.
     */
    nodeLabels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * A list of Kubernetes taints, that are applied to all the nodes of this Kubernetes node group.
     */
    nodeTaints?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Scale policy of the node group. The structure is documented below.
     */
    scalePolicy?: pulumi.Input<inputs.KubernetesNodeGroupScalePolicy>;
    /**
     * (Computed) Status of the Kubernetes node group.
     */
    status?: pulumi.Input<string>;
    /**
     * Version of Kubernetes that will be used for Kubernetes node group.
     */
    version?: pulumi.Input<string>;
    /**
     * Information about Kubernetes node group version. The structure is documented below.
     */
    versionInfos?: pulumi.Input<pulumi.Input<inputs.KubernetesNodeGroupVersionInfo>[]>;
}

/**
 * The set of arguments for constructing a KubernetesNodeGroup resource.
 */
export interface KubernetesNodeGroupArgs {
    /**
     * This argument specify subnets (zones), that will be used by node group compute instances. The structure is documented below.
     */
    allocationPolicy?: pulumi.Input<inputs.KubernetesNodeGroupAllocationPolicy>;
    /**
     * A list of allowed unsafe sysctl parameters for this node group. For more details see [documentation](https://kubernetes.io/docs/tasks/administer-cluster/sysctl-cluster/).
     */
    allowedUnsafeSysctls?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The ID of the Kubernetes cluster that this node group belongs to.
     */
    clusterId: pulumi.Input<string>;
    /**
     * Deploy policy of the node group. The structure is documented below.
     */
    deployPolicy?: pulumi.Input<inputs.KubernetesNodeGroupDeployPolicy>;
    /**
     * A description of the Kubernetes node group.
     */
    description?: pulumi.Input<string>;
    /**
     * Template used to create compute instances in this Kubernetes node group. The structure is documented below.
     */
    instanceTemplate: pulumi.Input<inputs.KubernetesNodeGroupInstanceTemplate>;
    /**
     * A set of key/value label pairs assigned to the Kubernetes node group.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * (Computed) Maintenance policy for this Kubernetes node group.
     * If policy is omitted, automatic revision upgrades are enabled and could happen at any time.
     * Revision upgrades are performed only within the same minor version, e.g. 1.13.
     * Minor version upgrades (e.g. 1.13->1.14) should be performed manually. The structure is documented below.
     */
    maintenancePolicy?: pulumi.Input<inputs.KubernetesNodeGroupMaintenancePolicy>;
    /**
     * Name of a specific Kubernetes node group.
     */
    name?: pulumi.Input<string>;
    /**
     * A set of key/value label pairs, that are assigned to all the nodes of this Kubernetes node group.
     */
    nodeLabels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * A list of Kubernetes taints, that are applied to all the nodes of this Kubernetes node group.
     */
    nodeTaints?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Scale policy of the node group. The structure is documented below.
     */
    scalePolicy: pulumi.Input<inputs.KubernetesNodeGroupScalePolicy>;
    /**
     * Version of Kubernetes that will be used for Kubernetes node group.
     */
    version?: pulumi.Input<string>;
}