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
    ///     var myUserSshKey = new Yandex.OrganizationmanagerUserSshKey("myUserSshKey", new()
    ///     {
    ///         Data = "ssh_key_data",
    ///         OrganizationId = "some_organization_id",
    ///         SubjectId = "some_subject_id",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [YandexResourceType("yandex:index/organizationmanagerUserSshKey:OrganizationmanagerUserSshKey")]
    public partial class OrganizationmanagerUserSshKey : global::Pulumi.CustomResource
    {
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// Data of the user ssh key.
        /// </summary>
        [Output("data")]
        public Output<string> Data { get; private set; } = null!;

        /// <summary>
        /// User ssh key will be no longer valid after expiration timestamp.
        /// </summary>
        [Output("expiresAt")]
        public Output<string?> ExpiresAt { get; private set; } = null!;

        [Output("fingerprint")]
        public Output<string> Fingerprint { get; private set; } = null!;

        /// <summary>
        /// Name of the user ssh key.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Organization that the user ssh key belongs to.
        /// </summary>
        [Output("organizationId")]
        public Output<string> OrganizationId { get; private set; } = null!;

        /// <summary>
        /// Subject that the user ssh key belongs to.
        /// </summary>
        [Output("subjectId")]
        public Output<string> SubjectId { get; private set; } = null!;


        /// <summary>
        /// Create a OrganizationmanagerUserSshKey resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public OrganizationmanagerUserSshKey(string name, OrganizationmanagerUserSshKeyArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/organizationmanagerUserSshKey:OrganizationmanagerUserSshKey", name, args ?? new OrganizationmanagerUserSshKeyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private OrganizationmanagerUserSshKey(string name, Input<string> id, OrganizationmanagerUserSshKeyState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/organizationmanagerUserSshKey:OrganizationmanagerUserSshKey", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing OrganizationmanagerUserSshKey resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static OrganizationmanagerUserSshKey Get(string name, Input<string> id, OrganizationmanagerUserSshKeyState? state = null, CustomResourceOptions? options = null)
        {
            return new OrganizationmanagerUserSshKey(name, id, state, options);
        }
    }

    public sealed class OrganizationmanagerUserSshKeyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Data of the user ssh key.
        /// </summary>
        [Input("data", required: true)]
        public Input<string> Data { get; set; } = null!;

        /// <summary>
        /// User ssh key will be no longer valid after expiration timestamp.
        /// </summary>
        [Input("expiresAt")]
        public Input<string>? ExpiresAt { get; set; }

        /// <summary>
        /// Name of the user ssh key.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Organization that the user ssh key belongs to.
        /// </summary>
        [Input("organizationId", required: true)]
        public Input<string> OrganizationId { get; set; } = null!;

        /// <summary>
        /// Subject that the user ssh key belongs to.
        /// </summary>
        [Input("subjectId", required: true)]
        public Input<string> SubjectId { get; set; } = null!;

        public OrganizationmanagerUserSshKeyArgs()
        {
        }
        public static new OrganizationmanagerUserSshKeyArgs Empty => new OrganizationmanagerUserSshKeyArgs();
    }

    public sealed class OrganizationmanagerUserSshKeyState : global::Pulumi.ResourceArgs
    {
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// Data of the user ssh key.
        /// </summary>
        [Input("data")]
        public Input<string>? Data { get; set; }

        /// <summary>
        /// User ssh key will be no longer valid after expiration timestamp.
        /// </summary>
        [Input("expiresAt")]
        public Input<string>? ExpiresAt { get; set; }

        [Input("fingerprint")]
        public Input<string>? Fingerprint { get; set; }

        /// <summary>
        /// Name of the user ssh key.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Organization that the user ssh key belongs to.
        /// </summary>
        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        /// <summary>
        /// Subject that the user ssh key belongs to.
        /// </summary>
        [Input("subjectId")]
        public Input<string>? SubjectId { get; set; }

        public OrganizationmanagerUserSshKeyState()
        {
        }
        public static new OrganizationmanagerUserSshKeyState Empty => new OrganizationmanagerUserSshKeyState();
    }
}