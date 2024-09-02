// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getCdnResource(args?: GetCdnResourceArgs, opts?: pulumi.InvokeOptions): Promise<GetCdnResourceResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getCdnResource:getCdnResource", {
        "active": args.active,
        "cname": args.cname,
        "folderId": args.folderId,
        "options": args.options,
        "originGroupId": args.originGroupId,
        "originGroupName": args.originGroupName,
        "originProtocol": args.originProtocol,
        "resourceId": args.resourceId,
        "secondaryHostnames": args.secondaryHostnames,
        "sslCertificate": args.sslCertificate,
        "updatedAt": args.updatedAt,
    }, opts);
}

/**
 * A collection of arguments for invoking getCdnResource.
 */
export interface GetCdnResourceArgs {
    active?: boolean;
    cname?: string;
    folderId?: string;
    options?: inputs.GetCdnResourceOptions;
    originGroupId?: number;
    originGroupName?: string;
    originProtocol?: string;
    resourceId?: string;
    secondaryHostnames?: string[];
    sslCertificate?: inputs.GetCdnResourceSslCertificate;
    updatedAt?: string;
}

/**
 * A collection of values returned by getCdnResource.
 */
export interface GetCdnResourceResult {
    readonly active?: boolean;
    readonly cname: string;
    readonly createdAt: string;
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly options: outputs.GetCdnResourceOptions;
    readonly originGroupId?: number;
    readonly originGroupName?: string;
    readonly originProtocol?: string;
    readonly providerCname: string;
    readonly resourceId: string;
    readonly secondaryHostnames?: string[];
    readonly sslCertificate: outputs.GetCdnResourceSslCertificate;
    readonly updatedAt: string;
}
export function getCdnResourceOutput(args?: GetCdnResourceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCdnResourceResult> {
    return pulumi.output(args).apply((a: any) => getCdnResource(a, opts))
}

/**
 * A collection of arguments for invoking getCdnResource.
 */
export interface GetCdnResourceOutputArgs {
    active?: pulumi.Input<boolean>;
    cname?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    options?: pulumi.Input<inputs.GetCdnResourceOptionsArgs>;
    originGroupId?: pulumi.Input<number>;
    originGroupName?: pulumi.Input<string>;
    originProtocol?: pulumi.Input<string>;
    resourceId?: pulumi.Input<string>;
    secondaryHostnames?: pulumi.Input<pulumi.Input<string>[]>;
    sslCertificate?: pulumi.Input<inputs.GetCdnResourceSslCertificateArgs>;
    updatedAt?: pulumi.Input<string>;
}
