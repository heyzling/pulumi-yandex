// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export function getComputeDiskPlacementGroup(args?: GetComputeDiskPlacementGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetComputeDiskPlacementGroupResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getComputeDiskPlacementGroup:getComputeDiskPlacementGroup", {
        "description": args.description,
        "folderId": args.folderId,
        "groupId": args.groupId,
        "labels": args.labels,
        "name": args.name,
        "zone": args.zone,
    }, opts);
}

/**
 * A collection of arguments for invoking getComputeDiskPlacementGroup.
 */
export interface GetComputeDiskPlacementGroupArgs {
    description?: string;
    folderId?: string;
    groupId?: string;
    labels?: {[key: string]: string};
    name?: string;
    zone?: string;
}

/**
 * A collection of values returned by getComputeDiskPlacementGroup.
 */
export interface GetComputeDiskPlacementGroupResult {
    readonly createdAt: string;
    readonly description?: string;
    readonly folderId: string;
    readonly groupId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels?: {[key: string]: string};
    readonly name?: string;
    readonly status: string;
    readonly zone?: string;
}
export function getComputeDiskPlacementGroupOutput(args?: GetComputeDiskPlacementGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetComputeDiskPlacementGroupResult> {
    return pulumi.output(args).apply((a: any) => getComputeDiskPlacementGroup(a, opts))
}

/**
 * A collection of arguments for invoking getComputeDiskPlacementGroup.
 */
export interface GetComputeDiskPlacementGroupOutputArgs {
    description?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    groupId?: pulumi.Input<string>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    name?: pulumi.Input<string>;
    zone?: pulumi.Input<string>;
}
