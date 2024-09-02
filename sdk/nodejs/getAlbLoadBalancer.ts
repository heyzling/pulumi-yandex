// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getAlbLoadBalancer(args?: GetAlbLoadBalancerArgs, opts?: pulumi.InvokeOptions): Promise<GetAlbLoadBalancerResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getAlbLoadBalancer:getAlbLoadBalancer", {
        "loadBalancerId": args.loadBalancerId,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getAlbLoadBalancer.
 */
export interface GetAlbLoadBalancerArgs {
    loadBalancerId?: string;
    name?: string;
}

/**
 * A collection of values returned by getAlbLoadBalancer.
 */
export interface GetAlbLoadBalancerResult {
    readonly allocationPolicies: outputs.GetAlbLoadBalancerAllocationPolicy[];
    readonly createdAt: string;
    readonly description: string;
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly listeners: outputs.GetAlbLoadBalancerListener[];
    readonly loadBalancerId: string;
    readonly logGroupId: string;
    readonly logOptions: outputs.GetAlbLoadBalancerLogOption[];
    readonly name: string;
    readonly networkId: string;
    readonly regionId: string;
    readonly securityGroupIds: string[];
    readonly status: string;
}
export function getAlbLoadBalancerOutput(args?: GetAlbLoadBalancerOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAlbLoadBalancerResult> {
    return pulumi.output(args).apply((a: any) => getAlbLoadBalancer(a, opts))
}

/**
 * A collection of arguments for invoking getAlbLoadBalancer.
 */
export interface GetAlbLoadBalancerOutputArgs {
    loadBalancerId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
}