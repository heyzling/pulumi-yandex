// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getAlbHttpRouter(args?: GetAlbHttpRouterArgs, opts?: pulumi.InvokeOptions): Promise<GetAlbHttpRouterResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getAlbHttpRouter:getAlbHttpRouter", {
        "description": args.description,
        "folderId": args.folderId,
        "httpRouterId": args.httpRouterId,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getAlbHttpRouter.
 */
export interface GetAlbHttpRouterArgs {
    description?: string;
    folderId?: string;
    httpRouterId?: string;
    name?: string;
}

/**
 * A collection of values returned by getAlbHttpRouter.
 */
export interface GetAlbHttpRouterResult {
    readonly createdAt: string;
    readonly description: string;
    readonly folderId: string;
    readonly httpRouterId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly name: string;
    readonly routeOptions: outputs.GetAlbHttpRouterRouteOption[];
}
export function getAlbHttpRouterOutput(args?: GetAlbHttpRouterOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAlbHttpRouterResult> {
    return pulumi.output(args).apply((a: any) => getAlbHttpRouter(a, opts))
}

/**
 * A collection of arguments for invoking getAlbHttpRouter.
 */
export interface GetAlbHttpRouterOutputArgs {
    description?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    httpRouterId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
}
