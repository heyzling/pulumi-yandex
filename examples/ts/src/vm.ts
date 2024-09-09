import * as pulumi from "@pulumi/pulumi";
import * as yandex from "@pulumi/yandex";
import * as config from "./config";
import * as subnets from "./subnets";

export const vm = new yandex.ComputeInstance('vm', {
  description: `Managed by Pulumi: ${config.program}/${config.stack}`,
  bootDisk: { initializeParams: { imageId: config.defaultVMImageId },  },
  zone: subnets.a.zone,
  networkInterfaces: [{
      subnetId: subnets.a.id,
      nat: false, // не нужен лишний белый адрес в тестах
  }],
  platformId: "standard-v3",
  resources: {
      cores: 2,
      memory: 4,
      coreFraction: 20 // 20% мощности - дешевле
  },
  schedulingPolicy: {
    preemptible: true // прерываемая ВМ - дешевле.
  },
});