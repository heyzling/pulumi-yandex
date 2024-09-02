// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class OrganizationmanagerOsLoginSettingsSshCertificateSettings
    {
        /// <summary>
        /// Enables or disables usage of ssh certificates signed by trusted CA.
        /// </summary>
        public readonly bool? Enabled;

        [OutputConstructor]
        private OrganizationmanagerOsLoginSettingsSshCertificateSettings(bool? enabled)
        {
            Enabled = enabled;
        }
    }
}