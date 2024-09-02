// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getOrganizationmanagerGroup(args?: GetOrganizationmanagerGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetOrganizationmanagerGroupResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getOrganizationmanagerGroup:getOrganizationmanagerGroup", {
        "groupId": args.groupId,
        "name": args.name,
        "organizationId": args.organizationId,
    }, opts);
}

/**
 * A collection of arguments for invoking getOrganizationmanagerGroup.
 */
export interface GetOrganizationmanagerGroupArgs {
    groupId?: string;
    name?: string;
    organizationId?: string;
}

/**
 * A collection of values returned by getOrganizationmanagerGroup.
 */
export interface GetOrganizationmanagerGroupResult {
    readonly createdAt: string;
    readonly description: string;
    readonly groupId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly members: outputs.GetOrganizationmanagerGroupMember[];
    readonly name: string;
    readonly organizationId?: string;
}
export function getOrganizationmanagerGroupOutput(args?: GetOrganizationmanagerGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetOrganizationmanagerGroupResult> {
    return pulumi.output(args).apply((a: any) => getOrganizationmanagerGroup(a, opts))
}

/**
 * A collection of arguments for invoking getOrganizationmanagerGroup.
 */
export interface GetOrganizationmanagerGroupOutputArgs {
    groupId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    organizationId?: pulumi.Input<string>;
}