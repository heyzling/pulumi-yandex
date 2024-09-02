// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getLockboxSecret(args?: GetLockboxSecretArgs, opts?: pulumi.InvokeOptions): Promise<GetLockboxSecretResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getLockboxSecret:getLockboxSecret", {
        "folderId": args.folderId,
        "name": args.name,
        "secretId": args.secretId,
    }, opts);
}

/**
 * A collection of arguments for invoking getLockboxSecret.
 */
export interface GetLockboxSecretArgs {
    folderId?: string;
    name?: string;
    secretId?: string;
}

/**
 * A collection of values returned by getLockboxSecret.
 */
export interface GetLockboxSecretResult {
    readonly createdAt: string;
    readonly currentVersions: outputs.GetLockboxSecretCurrentVersion[];
    readonly deletionProtection: boolean;
    readonly description: string;
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly kmsKeyId: string;
    readonly labels: {[key: string]: string};
    readonly name: string;
    readonly secretId?: string;
    readonly status: string;
}
export function getLockboxSecretOutput(args?: GetLockboxSecretOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetLockboxSecretResult> {
    return pulumi.output(args).apply((a: any) => getLockboxSecret(a, opts))
}

/**
 * A collection of arguments for invoking getLockboxSecret.
 */
export interface GetLockboxSecretOutputArgs {
    folderId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    secretId?: pulumi.Input<string>;
}
