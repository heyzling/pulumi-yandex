// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getOrganizationmanagerOsLoginSettings(args?: GetOrganizationmanagerOsLoginSettingsArgs, opts?: pulumi.InvokeOptions): Promise<GetOrganizationmanagerOsLoginSettingsResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("yandex:index/getOrganizationmanagerOsLoginSettings:getOrganizationmanagerOsLoginSettings", {
        "organizationId": args.organizationId,
        "sshCertificateSettings": args.sshCertificateSettings,
        "userSshKeySettings": args.userSshKeySettings,
    }, opts);
}

/**
 * A collection of arguments for invoking getOrganizationmanagerOsLoginSettings.
 */
export interface GetOrganizationmanagerOsLoginSettingsArgs {
    organizationId?: string;
    sshCertificateSettings?: inputs.GetOrganizationmanagerOsLoginSettingsSshCertificateSettings;
    userSshKeySettings?: inputs.GetOrganizationmanagerOsLoginSettingsUserSshKeySettings;
}

/**
 * A collection of values returned by getOrganizationmanagerOsLoginSettings.
 */
export interface GetOrganizationmanagerOsLoginSettingsResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly organizationId: string;
    readonly sshCertificateSettings?: outputs.GetOrganizationmanagerOsLoginSettingsSshCertificateSettings;
    readonly userSshKeySettings?: outputs.GetOrganizationmanagerOsLoginSettingsUserSshKeySettings;
}
export function getOrganizationmanagerOsLoginSettingsOutput(args?: GetOrganizationmanagerOsLoginSettingsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetOrganizationmanagerOsLoginSettingsResult> {
    return pulumi.output(args).apply((a: any) => getOrganizationmanagerOsLoginSettings(a, opts))
}

/**
 * A collection of arguments for invoking getOrganizationmanagerOsLoginSettings.
 */
export interface GetOrganizationmanagerOsLoginSettingsOutputArgs {
    organizationId?: pulumi.Input<string>;
    sshCertificateSettings?: pulumi.Input<inputs.GetOrganizationmanagerOsLoginSettingsSshCertificateSettingsArgs>;
    userSshKeySettings?: pulumi.Input<inputs.GetOrganizationmanagerOsLoginSettingsUserSshKeySettingsArgs>;
}
