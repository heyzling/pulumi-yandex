// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getSwsSecurityProfile(args?: GetSwsSecurityProfileArgs, opts?: pulumi.InvokeOptions): Promise<GetSwsSecurityProfileResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getSwsSecurityProfile:getSwsSecurityProfile", {
        "cloudId": args.cloudId,
        "folderId": args.folderId,
        "name": args.name,
        "securityProfileId": args.securityProfileId,
    }, opts);
}

/**
 * A collection of arguments for invoking getSwsSecurityProfile.
 */
export interface GetSwsSecurityProfileArgs {
    cloudId?: string;
    folderId?: string;
    name?: string;
    securityProfileId?: string;
}

/**
 * A collection of values returned by getSwsSecurityProfile.
 */
export interface GetSwsSecurityProfileResult {
    readonly captchaId: string;
    readonly cloudId: string;
    readonly createdAt: string;
    readonly defaultAction: string;
    readonly description: string;
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly name: string;
    readonly securityProfileId?: string;
    readonly securityRules: outputs.GetSwsSecurityProfileSecurityRule[];
}
export function getSwsSecurityProfileOutput(args?: GetSwsSecurityProfileOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSwsSecurityProfileResult> {
    return pulumi.output(args).apply((a: any) => getSwsSecurityProfile(a, opts))
}

/**
 * A collection of arguments for invoking getSwsSecurityProfile.
 */
export interface GetSwsSecurityProfileOutputArgs {
    cloudId?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    securityProfileId?: pulumi.Input<string>;
}
