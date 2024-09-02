// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export function getKmsSymmetricKey(args?: GetKmsSymmetricKeyArgs, opts?: pulumi.InvokeOptions): Promise<GetKmsSymmetricKeyResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getKmsSymmetricKey:getKmsSymmetricKey", {
        "defaultAlgorithm": args.defaultAlgorithm,
        "deletionProtection": args.deletionProtection,
        "description": args.description,
        "folderId": args.folderId,
        "labels": args.labels,
        "name": args.name,
        "rotationPeriod": args.rotationPeriod,
        "symmetricKeyId": args.symmetricKeyId,
    }, opts);
}

/**
 * A collection of arguments for invoking getKmsSymmetricKey.
 */
export interface GetKmsSymmetricKeyArgs {
    defaultAlgorithm?: string;
    deletionProtection?: boolean;
    description?: string;
    folderId?: string;
    labels?: {[key: string]: string};
    name?: string;
    rotationPeriod?: string;
    symmetricKeyId?: string;
}

/**
 * A collection of values returned by getKmsSymmetricKey.
 */
export interface GetKmsSymmetricKeyResult {
    readonly createdAt: string;
    readonly defaultAlgorithm?: string;
    readonly deletionProtection?: boolean;
    readonly description?: string;
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels?: {[key: string]: string};
    readonly name?: string;
    readonly rotatedAt: string;
    readonly rotationPeriod?: string;
    readonly status: string;
    readonly symmetricKeyId?: string;
}
export function getKmsSymmetricKeyOutput(args?: GetKmsSymmetricKeyOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetKmsSymmetricKeyResult> {
    return pulumi.output(args).apply((a: any) => getKmsSymmetricKey(a, opts))
}

/**
 * A collection of arguments for invoking getKmsSymmetricKey.
 */
export interface GetKmsSymmetricKeyOutputArgs {
    defaultAlgorithm?: pulumi.Input<string>;
    deletionProtection?: pulumi.Input<boolean>;
    description?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    name?: pulumi.Input<string>;
    rotationPeriod?: pulumi.Input<string>;
    symmetricKeyId?: pulumi.Input<string>;
}
