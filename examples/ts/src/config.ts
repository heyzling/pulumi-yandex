/** 
 * Глобальный конфиг всего кода. 
 * Здесь загружаются значения из стека, которые переиспользует весь проект.
 *  
*/

import * as pulumi from "@pulumi/pulumi";
import * as yandex from "@pulumi/yandex";

/** Название текущей программы (Pulumi.yaml -> .name) */
export const program = pulumi.getProject();

/** Название текущего стека */
export const stack = pulumi.getStack();

/** Конфигурация текущего стека, записанная в файле (см. в Pulumi.<имя стека>.yaml) */
export const config = new pulumi.Config()

pulumi.log.info(`Program name: ${program}`)
pulumi.log.info(`Stack name: ${stack}`)

/** Префикс сетки для тестов бриджа. Хардкод для упрощения запуска тестов */
export const subnetPrefix = `10.57`

/** Образ, который нужно создать. Хардкод, потому особо без разницы какой и он будет меняться редко. */
export const defaultVMImageId = "fd8v0s6adqu3ui3rsuap"

