// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getMdbKafkaConnector(args: GetMdbKafkaConnectorArgs, opts?: pulumi.InvokeOptions): Promise<GetMdbKafkaConnectorResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getMdbKafkaConnector:getMdbKafkaConnector", {
        "clusterId": args.clusterId,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getMdbKafkaConnector.
 */
export interface GetMdbKafkaConnectorArgs {
    clusterId: string;
    name: string;
}

/**
 * A collection of values returned by getMdbKafkaConnector.
 */
export interface GetMdbKafkaConnectorResult {
    readonly clusterId: string;
    readonly connectorConfigMirrormakers: outputs.GetMdbKafkaConnectorConnectorConfigMirrormaker[];
    readonly connectorConfigS3Sinks: outputs.GetMdbKafkaConnectorConnectorConfigS3Sink[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
    readonly properties: {[key: string]: string};
    readonly tasksMax: number;
}
export function getMdbKafkaConnectorOutput(args: GetMdbKafkaConnectorOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetMdbKafkaConnectorResult> {
    return pulumi.output(args).apply((a: any) => getMdbKafkaConnector(a, opts))
}

/**
 * A collection of arguments for invoking getMdbKafkaConnector.
 */
export interface GetMdbKafkaConnectorOutputArgs {
    clusterId: pulumi.Input<string>;
    name: pulumi.Input<string>;
}
