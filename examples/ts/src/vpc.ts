import * as pulumi from "@pulumi/pulumi";
import * as yandex from "@pulumi/yandex";
import * as config from "./config"

export const vpc = new yandex.VpcNetwork('vpc', {
  description: `Managed by Pulumi: ${config.program}/${config.stack}`,
})