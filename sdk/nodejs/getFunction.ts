// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getFunction(args?: GetFunctionArgs, opts?: pulumi.InvokeOptions): Promise<GetFunctionResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getFunction:getFunction", {
        "concurrency": args.concurrency,
        "connectivity": args.connectivity,
        "folderId": args.folderId,
        "functionId": args.functionId,
        "name": args.name,
        "secrets": args.secrets,
        "storageMounts": args.storageMounts,
    }, opts);
}

/**
 * A collection of arguments for invoking getFunction.
 */
export interface GetFunctionArgs {
    concurrency?: number;
    connectivity?: inputs.GetFunctionConnectivity;
    folderId?: string;
    functionId?: string;
    name?: string;
    secrets?: inputs.GetFunctionSecret[];
    storageMounts?: inputs.GetFunctionStorageMount[];
}

/**
 * A collection of values returned by getFunction.
 */
export interface GetFunctionResult {
    readonly asyncInvocations: outputs.GetFunctionAsyncInvocation[];
    readonly concurrency: number;
    readonly connectivity?: outputs.GetFunctionConnectivity;
    readonly createdAt: string;
    readonly description: string;
    readonly entrypoint: string;
    readonly environment: {[key: string]: string};
    readonly executionTimeout: string;
    readonly folderId?: string;
    readonly functionId?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly imageSize: number;
    readonly labels: {[key: string]: string};
    readonly logOptions: outputs.GetFunctionLogOption[];
    readonly memory: number;
    readonly name?: string;
    readonly runtime: string;
    readonly secrets: outputs.GetFunctionSecret[];
    readonly serviceAccountId: string;
    readonly storageMounts: outputs.GetFunctionStorageMount[];
    readonly tags: string[];
    readonly tmpfsSize: number;
    readonly version: string;
}
export function getFunctionOutput(args?: GetFunctionOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetFunctionResult> {
    return pulumi.output(args).apply((a: any) => getFunction(a, opts))
}

/**
 * A collection of arguments for invoking getFunction.
 */
export interface GetFunctionOutputArgs {
    concurrency?: pulumi.Input<number>;
    connectivity?: pulumi.Input<inputs.GetFunctionConnectivityArgs>;
    folderId?: pulumi.Input<string>;
    functionId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    secrets?: pulumi.Input<pulumi.Input<inputs.GetFunctionSecretArgs>[]>;
    storageMounts?: pulumi.Input<pulumi.Input<inputs.GetFunctionStorageMountArgs>[]>;
}