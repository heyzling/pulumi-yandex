import * as pulumi from "@pulumi/pulumi";
import * as yandex from "@pulumi/yandex";
import { vpc } from "./vpc";
import * as config from "./config"

export const a = new yandex.VpcSubnet('a', {
  description: `Managed by Pulumi: ${config.program}/${config.stack}`,
  networkId: vpc.id,
  v4CidrBlocks: [`${config.subnetPrefix}.0.0/24`],
  zone: 'ru-central1-a',
})

export const b = new yandex.VpcSubnet('b', {
  description: `Managed by Pulumi: ${config.program}/${config.stack}`,
  networkId: vpc.id,
  v4CidrBlocks: [`${config.subnetPrefix}.1.0/24`],
  zone: 'ru-central1-b',
})

export const d = new yandex.VpcSubnet('d', {
  description: `Managed by Pulumi: ${config.program}/${config.stack}`,
  networkId: vpc.id,
  v4CidrBlocks: [`${config.subnetPrefix}.2.0/24`],
  zone: 'ru-central1-d',
})
