// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getYdbDatabaseServerless(args?: GetYdbDatabaseServerlessArgs, opts?: pulumi.InvokeOptions): Promise<GetYdbDatabaseServerlessResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getYdbDatabaseServerless:getYdbDatabaseServerless", {
        "databaseId": args.databaseId,
        "deletionProtection": args.deletionProtection,
        "folderId": args.folderId,
        "name": args.name,
        "serverlessDatabases": args.serverlessDatabases,
    }, opts);
}

/**
 * A collection of arguments for invoking getYdbDatabaseServerless.
 */
export interface GetYdbDatabaseServerlessArgs {
    databaseId?: string;
    deletionProtection?: boolean;
    folderId?: string;
    name?: string;
    serverlessDatabases?: inputs.GetYdbDatabaseServerlessServerlessDatabase[];
}

/**
 * A collection of values returned by getYdbDatabaseServerless.
 */
export interface GetYdbDatabaseServerlessResult {
    readonly createdAt: string;
    readonly databaseId?: string;
    readonly databasePath: string;
    readonly deletionProtection: boolean;
    readonly description: string;
    readonly documentApiEndpoint: string;
    readonly folderId?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly locationId: string;
    readonly name?: string;
    readonly serverlessDatabases: outputs.GetYdbDatabaseServerlessServerlessDatabase[];
    readonly status: string;
    readonly tlsEnabled: boolean;
    readonly ydbApiEndpoint: string;
    readonly ydbFullEndpoint: string;
}
export function getYdbDatabaseServerlessOutput(args?: GetYdbDatabaseServerlessOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetYdbDatabaseServerlessResult> {
    return pulumi.output(args).apply((a: any) => getYdbDatabaseServerless(a, opts))
}

/**
 * A collection of arguments for invoking getYdbDatabaseServerless.
 */
export interface GetYdbDatabaseServerlessOutputArgs {
    databaseId?: pulumi.Input<string>;
    deletionProtection?: pulumi.Input<boolean>;
    folderId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    serverlessDatabases?: pulumi.Input<pulumi.Input<inputs.GetYdbDatabaseServerlessServerlessDatabaseArgs>[]>;
}
