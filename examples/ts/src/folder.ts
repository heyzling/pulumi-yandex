import * as pulumi from "@pulumi/pulumi";
import * as yandex from "@pulumi/yandex";
import * as config from "./config"


// С папкой сложно сделать автоматическое тестирование
// потому что на стороне Yandex Cloud 
// она может удалятся очень долго.
// Закомментировано, вместо это используется предсозданная папка для тестов.
// export const workfolder = new yandex.ResourcemanagerFolder('workfolder', {
//   description: `Managed by Pulumi: ${config.program}/${config.stack}`
// })