// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetOrganizationmanagerOsLoginSettings
    {
        public static Task<GetOrganizationmanagerOsLoginSettingsResult> InvokeAsync(GetOrganizationmanagerOsLoginSettingsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetOrganizationmanagerOsLoginSettingsResult>("yandex:index/getOrganizationmanagerOsLoginSettings:getOrganizationmanagerOsLoginSettings", args ?? new GetOrganizationmanagerOsLoginSettingsArgs(), options.WithDefaults());

        public static Output<GetOrganizationmanagerOsLoginSettingsResult> Invoke(GetOrganizationmanagerOsLoginSettingsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetOrganizationmanagerOsLoginSettingsResult>("yandex:index/getOrganizationmanagerOsLoginSettings:getOrganizationmanagerOsLoginSettings", args ?? new GetOrganizationmanagerOsLoginSettingsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetOrganizationmanagerOsLoginSettingsArgs : global::Pulumi.InvokeArgs
    {
        [Input("organizationId")]
        public string? OrganizationId { get; set; }

        [Input("sshCertificateSettings")]
        public Inputs.GetOrganizationmanagerOsLoginSettingsSshCertificateSettingsArgs? SshCertificateSettings { get; set; }

        [Input("userSshKeySettings")]
        public Inputs.GetOrganizationmanagerOsLoginSettingsUserSshKeySettingsArgs? UserSshKeySettings { get; set; }

        public GetOrganizationmanagerOsLoginSettingsArgs()
        {
        }
        public static new GetOrganizationmanagerOsLoginSettingsArgs Empty => new GetOrganizationmanagerOsLoginSettingsArgs();
    }

    public sealed class GetOrganizationmanagerOsLoginSettingsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        [Input("sshCertificateSettings")]
        public Input<Inputs.GetOrganizationmanagerOsLoginSettingsSshCertificateSettingsInputArgs>? SshCertificateSettings { get; set; }

        [Input("userSshKeySettings")]
        public Input<Inputs.GetOrganizationmanagerOsLoginSettingsUserSshKeySettingsInputArgs>? UserSshKeySettings { get; set; }

        public GetOrganizationmanagerOsLoginSettingsInvokeArgs()
        {
        }
        public static new GetOrganizationmanagerOsLoginSettingsInvokeArgs Empty => new GetOrganizationmanagerOsLoginSettingsInvokeArgs();
    }


    [OutputType]
    public sealed class GetOrganizationmanagerOsLoginSettingsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string OrganizationId;
        public readonly Outputs.GetOrganizationmanagerOsLoginSettingsSshCertificateSettingsResult? SshCertificateSettings;
        public readonly Outputs.GetOrganizationmanagerOsLoginSettingsUserSshKeySettingsResult? UserSshKeySettings;

        [OutputConstructor]
        private GetOrganizationmanagerOsLoginSettingsResult(
            string id,

            string organizationId,

            Outputs.GetOrganizationmanagerOsLoginSettingsSshCertificateSettingsResult? sshCertificateSettings,

            Outputs.GetOrganizationmanagerOsLoginSettingsUserSshKeySettingsResult? userSshKeySettings)
        {
            Id = id;
            OrganizationId = organizationId;
            SshCertificateSettings = sshCertificateSettings;
            UserSshKeySettings = userSshKeySettings;
        }
    }
}
