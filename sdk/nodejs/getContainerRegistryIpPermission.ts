// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export function getContainerRegistryIpPermission(args?: GetContainerRegistryIpPermissionArgs, opts?: pulumi.InvokeOptions): Promise<GetContainerRegistryIpPermissionResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getContainerRegistryIpPermission:getContainerRegistryIpPermission", {
        "registryId": args.registryId,
        "registryName": args.registryName,
    }, opts);
}

/**
 * A collection of arguments for invoking getContainerRegistryIpPermission.
 */
export interface GetContainerRegistryIpPermissionArgs {
    registryId?: string;
    registryName?: string;
}

/**
 * A collection of values returned by getContainerRegistryIpPermission.
 */
export interface GetContainerRegistryIpPermissionResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly pulls: string[];
    readonly pushes: string[];
    readonly registryId: string;
    readonly registryName: string;
}
export function getContainerRegistryIpPermissionOutput(args?: GetContainerRegistryIpPermissionOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetContainerRegistryIpPermissionResult> {
    return pulumi.output(args).apply((a: any) => getContainerRegistryIpPermission(a, opts))
}

/**
 * A collection of arguments for invoking getContainerRegistryIpPermission.
 */
export interface GetContainerRegistryIpPermissionOutputArgs {
    registryId?: pulumi.Input<string>;
    registryName?: pulumi.Input<string>;
}