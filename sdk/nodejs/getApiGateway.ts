// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getApiGateway(args?: GetApiGatewayArgs, opts?: pulumi.InvokeOptions): Promise<GetApiGatewayResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getApiGateway:getApiGateway", {
        "apiGatewayId": args.apiGatewayId,
        "canary": args.canary,
        "connectivity": args.connectivity,
        "customDomains": args.customDomains,
        "executionTimeout": args.executionTimeout,
        "folderId": args.folderId,
        "name": args.name,
        "variables": args.variables,
    }, opts);
}

/**
 * A collection of arguments for invoking getApiGateway.
 */
export interface GetApiGatewayArgs {
    apiGatewayId?: string;
    canary?: inputs.GetApiGatewayCanary;
    connectivity?: inputs.GetApiGatewayConnectivity;
    customDomains?: inputs.GetApiGatewayCustomDomain[];
    executionTimeout?: string;
    folderId?: string;
    name?: string;
    variables?: {[key: string]: string};
}

/**
 * A collection of values returned by getApiGateway.
 */
export interface GetApiGatewayResult {
    readonly apiGatewayId?: string;
    readonly canary?: outputs.GetApiGatewayCanary;
    readonly connectivity?: outputs.GetApiGatewayConnectivity;
    readonly createdAt: string;
    readonly customDomains?: outputs.GetApiGatewayCustomDomain[];
    readonly description: string;
    readonly domain: string;
    readonly executionTimeout: string;
    readonly folderId?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly logGroupId: string;
    readonly logOptions: outputs.GetApiGatewayLogOption[];
    readonly name?: string;
    readonly status: string;
    /**
     * @deprecated The 'user_domains' field has been deprecated. Please use 'custom_domains' instead.
     */
    readonly userDomains: string[];
    readonly variables?: {[key: string]: string};
}
export function getApiGatewayOutput(args?: GetApiGatewayOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetApiGatewayResult> {
    return pulumi.output(args).apply((a: any) => getApiGateway(a, opts))
}

/**
 * A collection of arguments for invoking getApiGateway.
 */
export interface GetApiGatewayOutputArgs {
    apiGatewayId?: pulumi.Input<string>;
    canary?: pulumi.Input<inputs.GetApiGatewayCanaryArgs>;
    connectivity?: pulumi.Input<inputs.GetApiGatewayConnectivityArgs>;
    customDomains?: pulumi.Input<pulumi.Input<inputs.GetApiGatewayCustomDomainArgs>[]>;
    executionTimeout?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    variables?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
