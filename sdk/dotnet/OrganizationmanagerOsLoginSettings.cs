// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    /// <summary>
    /// ## Example Usage
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Yandex = Pulumi.Yandex;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var myOsLoginSettings = new Yandex.OrganizationmanagerOsLoginSettings("myOsLoginSettings", new()
    ///     {
    ///         OrganizationId = "sdf4*********3fr",
    ///         SshCertificateSettings = new Yandex.Inputs.OrganizationmanagerOsLoginSettingsSshCertificateSettingsArgs
    ///         {
    ///             Enabled = true,
    ///         },
    ///         UserSshKeySettings = new Yandex.Inputs.OrganizationmanagerOsLoginSettingsUserSshKeySettingsArgs
    ///         {
    ///             AllowManageOwnKeys = true,
    ///             Enabled = true,
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [YandexResourceType("yandex:index/organizationmanagerOsLoginSettings:OrganizationmanagerOsLoginSettings")]
    public partial class OrganizationmanagerOsLoginSettings : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The organization to manage it's OsLogin Settings.
        /// </summary>
        [Output("organizationId")]
        public Output<string> OrganizationId { get; private set; } = null!;

        /// <summary>
        /// The structure is documented below.
        /// </summary>
        [Output("sshCertificateSettings")]
        public Output<Outputs.OrganizationmanagerOsLoginSettingsSshCertificateSettings?> SshCertificateSettings { get; private set; } = null!;

        /// <summary>
        /// The structure is documented below.
        /// </summary>
        [Output("userSshKeySettings")]
        public Output<Outputs.OrganizationmanagerOsLoginSettingsUserSshKeySettings?> UserSshKeySettings { get; private set; } = null!;


        /// <summary>
        /// Create a OrganizationmanagerOsLoginSettings resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public OrganizationmanagerOsLoginSettings(string name, OrganizationmanagerOsLoginSettingsArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/organizationmanagerOsLoginSettings:OrganizationmanagerOsLoginSettings", name, args ?? new OrganizationmanagerOsLoginSettingsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private OrganizationmanagerOsLoginSettings(string name, Input<string> id, OrganizationmanagerOsLoginSettingsState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/organizationmanagerOsLoginSettings:OrganizationmanagerOsLoginSettings", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/heyzling/pulumi-yandex/releases/",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing OrganizationmanagerOsLoginSettings resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static OrganizationmanagerOsLoginSettings Get(string name, Input<string> id, OrganizationmanagerOsLoginSettingsState? state = null, CustomResourceOptions? options = null)
        {
            return new OrganizationmanagerOsLoginSettings(name, id, state, options);
        }
    }

    public sealed class OrganizationmanagerOsLoginSettingsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The organization to manage it's OsLogin Settings.
        /// </summary>
        [Input("organizationId", required: true)]
        public Input<string> OrganizationId { get; set; } = null!;

        /// <summary>
        /// The structure is documented below.
        /// </summary>
        [Input("sshCertificateSettings")]
        public Input<Inputs.OrganizationmanagerOsLoginSettingsSshCertificateSettingsArgs>? SshCertificateSettings { get; set; }

        /// <summary>
        /// The structure is documented below.
        /// </summary>
        [Input("userSshKeySettings")]
        public Input<Inputs.OrganizationmanagerOsLoginSettingsUserSshKeySettingsArgs>? UserSshKeySettings { get; set; }

        public OrganizationmanagerOsLoginSettingsArgs()
        {
        }
        public static new OrganizationmanagerOsLoginSettingsArgs Empty => new OrganizationmanagerOsLoginSettingsArgs();
    }

    public sealed class OrganizationmanagerOsLoginSettingsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The organization to manage it's OsLogin Settings.
        /// </summary>
        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        /// <summary>
        /// The structure is documented below.
        /// </summary>
        [Input("sshCertificateSettings")]
        public Input<Inputs.OrganizationmanagerOsLoginSettingsSshCertificateSettingsGetArgs>? SshCertificateSettings { get; set; }

        /// <summary>
        /// The structure is documented below.
        /// </summary>
        [Input("userSshKeySettings")]
        public Input<Inputs.OrganizationmanagerOsLoginSettingsUserSshKeySettingsGetArgs>? UserSshKeySettings { get; set; }

        public OrganizationmanagerOsLoginSettingsState()
        {
        }
        public static new OrganizationmanagerOsLoginSettingsState Empty => new OrganizationmanagerOsLoginSettingsState();
    }
}