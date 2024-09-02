// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getComputeSnapshotSchedule(args?: GetComputeSnapshotScheduleArgs, opts?: pulumi.InvokeOptions): Promise<GetComputeSnapshotScheduleResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getComputeSnapshotSchedule:getComputeSnapshotSchedule", {
        "description": args.description,
        "diskIds": args.diskIds,
        "folderId": args.folderId,
        "labels": args.labels,
        "name": args.name,
        "retentionPeriod": args.retentionPeriod,
        "schedulePolicies": args.schedulePolicies,
        "snapshotCount": args.snapshotCount,
        "snapshotScheduleId": args.snapshotScheduleId,
        "snapshotSpecs": args.snapshotSpecs,
    }, opts);
}

/**
 * A collection of arguments for invoking getComputeSnapshotSchedule.
 */
export interface GetComputeSnapshotScheduleArgs {
    description?: string;
    diskIds?: string[];
    folderId?: string;
    labels?: {[key: string]: string};
    name?: string;
    retentionPeriod?: string;
    schedulePolicies?: inputs.GetComputeSnapshotScheduleSchedulePolicy[];
    snapshotCount?: number;
    snapshotScheduleId?: string;
    snapshotSpecs?: inputs.GetComputeSnapshotScheduleSnapshotSpec[];
}

/**
 * A collection of values returned by getComputeSnapshotSchedule.
 */
export interface GetComputeSnapshotScheduleResult {
    readonly createdAt: string;
    readonly description: string;
    readonly diskIds: string[];
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly name: string;
    readonly retentionPeriod: string;
    readonly schedulePolicies: outputs.GetComputeSnapshotScheduleSchedulePolicy[];
    readonly snapshotCount: number;
    readonly snapshotScheduleId: string;
    readonly snapshotSpecs: outputs.GetComputeSnapshotScheduleSnapshotSpec[];
    readonly status: string;
}
export function getComputeSnapshotScheduleOutput(args?: GetComputeSnapshotScheduleOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetComputeSnapshotScheduleResult> {
    return pulumi.output(args).apply((a: any) => getComputeSnapshotSchedule(a, opts))
}

/**
 * A collection of arguments for invoking getComputeSnapshotSchedule.
 */
export interface GetComputeSnapshotScheduleOutputArgs {
    description?: pulumi.Input<string>;
    diskIds?: pulumi.Input<pulumi.Input<string>[]>;
    folderId?: pulumi.Input<string>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    name?: pulumi.Input<string>;
    retentionPeriod?: pulumi.Input<string>;
    schedulePolicies?: pulumi.Input<pulumi.Input<inputs.GetComputeSnapshotScheduleSchedulePolicyArgs>[]>;
    snapshotCount?: pulumi.Input<number>;
    snapshotScheduleId?: pulumi.Input<string>;
    snapshotSpecs?: pulumi.Input<pulumi.Input<inputs.GetComputeSnapshotScheduleSnapshotSpecArgs>[]>;
}
