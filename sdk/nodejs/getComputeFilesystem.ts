// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export function getComputeFilesystem(args?: GetComputeFilesystemArgs, opts?: pulumi.InvokeOptions): Promise<GetComputeFilesystemResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getComputeFilesystem:getComputeFilesystem", {
        "filesystemId": args.filesystemId,
        "folderId": args.folderId,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getComputeFilesystem.
 */
export interface GetComputeFilesystemArgs {
    filesystemId?: string;
    folderId?: string;
    name?: string;
}

/**
 * A collection of values returned by getComputeFilesystem.
 */
export interface GetComputeFilesystemResult {
    readonly blockSize: number;
    readonly createdAt: string;
    readonly description: string;
    readonly filesystemId: string;
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly name: string;
    readonly size: number;
    readonly status: string;
    readonly type: string;
    readonly zone: string;
}
export function getComputeFilesystemOutput(args?: GetComputeFilesystemOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetComputeFilesystemResult> {
    return pulumi.output(args).apply((a: any) => getComputeFilesystem(a, opts))
}

/**
 * A collection of arguments for invoking getComputeFilesystem.
 */
export interface GetComputeFilesystemOutputArgs {
    filesystemId?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
}