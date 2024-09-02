// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export function getContainerRepository(args?: GetContainerRepositoryArgs, opts?: pulumi.InvokeOptions): Promise<GetContainerRepositoryResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getContainerRepository:getContainerRepository", {
        "name": args.name,
        "repositoryId": args.repositoryId,
    }, opts);
}

/**
 * A collection of arguments for invoking getContainerRepository.
 */
export interface GetContainerRepositoryArgs {
    name?: string;
    repositoryId?: string;
}

/**
 * A collection of values returned by getContainerRepository.
 */
export interface GetContainerRepositoryResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
    readonly repositoryId: string;
}
export function getContainerRepositoryOutput(args?: GetContainerRepositoryOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetContainerRepositoryResult> {
    return pulumi.output(args).apply((a: any) => getContainerRepository(a, opts))
}

/**
 * A collection of arguments for invoking getContainerRepository.
 */
export interface GetContainerRepositoryOutputArgs {
    name?: pulumi.Input<string>;
    repositoryId?: pulumi.Input<string>;
}