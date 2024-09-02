// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getContainerRepositoryLifecyclePolicy(args?: GetContainerRepositoryLifecyclePolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetContainerRepositoryLifecyclePolicyResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getContainerRepositoryLifecyclePolicy:getContainerRepositoryLifecyclePolicy", {
        "lifecyclePolicyId": args.lifecyclePolicyId,
        "name": args.name,
        "repositoryId": args.repositoryId,
    }, opts);
}

/**
 * A collection of arguments for invoking getContainerRepositoryLifecyclePolicy.
 */
export interface GetContainerRepositoryLifecyclePolicyArgs {
    lifecyclePolicyId?: string;
    name?: string;
    repositoryId?: string;
}

/**
 * A collection of values returned by getContainerRepositoryLifecyclePolicy.
 */
export interface GetContainerRepositoryLifecyclePolicyResult {
    readonly createdAt: string;
    readonly description: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly lifecyclePolicyId: string;
    readonly name: string;
    readonly repositoryId: string;
    readonly rules: outputs.GetContainerRepositoryLifecyclePolicyRule[];
    readonly status: string;
}
export function getContainerRepositoryLifecyclePolicyOutput(args?: GetContainerRepositoryLifecyclePolicyOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetContainerRepositoryLifecyclePolicyResult> {
    return pulumi.output(args).apply((a: any) => getContainerRepositoryLifecyclePolicy(a, opts))
}

/**
 * A collection of arguments for invoking getContainerRepositoryLifecyclePolicy.
 */
export interface GetContainerRepositoryLifecyclePolicyOutputArgs {
    lifecyclePolicyId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    repositoryId?: pulumi.Input<string>;
}
