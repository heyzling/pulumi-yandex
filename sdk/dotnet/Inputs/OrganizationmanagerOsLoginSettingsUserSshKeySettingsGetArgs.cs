// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class OrganizationmanagerOsLoginSettingsUserSshKeySettingsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If set to true subject is allowed to manage own ssh keys without having to be assigned specific permissions.
        /// </summary>
        [Input("allowManageOwnKeys")]
        public Input<bool>? AllowManageOwnKeys { get; set; }

        /// <summary>
        /// Enables or disables usage of ssh keys assigned to a specific subject.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        public OrganizationmanagerOsLoginSettingsUserSshKeySettingsGetArgs()
        {
        }
        public static new OrganizationmanagerOsLoginSettingsUserSshKeySettingsGetArgs Empty => new OrganizationmanagerOsLoginSettingsUserSshKeySettingsGetArgs();
    }
}
