// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getKubernetesNodeGroup(args?: GetKubernetesNodeGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetKubernetesNodeGroupResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getKubernetesNodeGroup:getKubernetesNodeGroup", {
        "folderId": args.folderId,
        "name": args.name,
        "nodeGroupId": args.nodeGroupId,
    }, opts);
}

/**
 * A collection of arguments for invoking getKubernetesNodeGroup.
 */
export interface GetKubernetesNodeGroupArgs {
    folderId?: string;
    name?: string;
    nodeGroupId?: string;
}

/**
 * A collection of values returned by getKubernetesNodeGroup.
 */
export interface GetKubernetesNodeGroupResult {
    readonly allocationPolicies: outputs.GetKubernetesNodeGroupAllocationPolicy[];
    readonly allowedUnsafeSysctls: string[];
    readonly clusterId: string;
    readonly createdAt: string;
    readonly deployPolicies: outputs.GetKubernetesNodeGroupDeployPolicy[];
    readonly description: string;
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceGroupId: string;
    readonly instanceTemplates: outputs.GetKubernetesNodeGroupInstanceTemplate[];
    readonly labels: {[key: string]: string};
    readonly maintenancePolicies: outputs.GetKubernetesNodeGroupMaintenancePolicy[];
    readonly name: string;
    readonly nodeGroupId: string;
    readonly nodeLabels: {[key: string]: string};
    readonly nodeTaints: string[];
    readonly scalePolicies: outputs.GetKubernetesNodeGroupScalePolicy[];
    readonly status: string;
    readonly versionInfos: outputs.GetKubernetesNodeGroupVersionInfo[];
}
export function getKubernetesNodeGroupOutput(args?: GetKubernetesNodeGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetKubernetesNodeGroupResult> {
    return pulumi.output(args).apply((a: any) => getKubernetesNodeGroup(a, opts))
}

/**
 * A collection of arguments for invoking getKubernetesNodeGroup.
 */
export interface GetKubernetesNodeGroupOutputArgs {
    folderId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    nodeGroupId?: pulumi.Input<string>;
}
