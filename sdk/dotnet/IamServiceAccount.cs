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
    /// Allows management of a Yandex.Cloud IAM [service account](https://cloud.yandex.com/docs/iam/concepts/users/service-accounts).
    /// To assign roles and permissions, use the yandex_iam_service_account_iam_binding,
    /// yandex.IamServiceAccountIamMember and
    /// yandex.IamServiceAccountIamPolicy resources.
    /// 
    /// ## Example Usage
    /// 
    /// This snippet creates a service account.
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
    ///     var sa = new Yandex.IamServiceAccount("sa", new()
    ///     {
    ///         Description = "service account to manage VMs",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// A service account can be imported using the `id` of the resource, e.g.
    /// 
    /// ```sh
    /// $ pulumi import yandex:index/iamServiceAccount:IamServiceAccount sa account_id
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/iamServiceAccount:IamServiceAccount")]
    public partial class IamServiceAccount : global::Pulumi.CustomResource
    {
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// Description of the service account.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// ID of the folder that the service account will be created in.
        /// Defaults to the provider folder configuration.
        /// </summary>
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// Name of the service account.
        /// Can be updated without creating a new resource.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a IamServiceAccount resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IamServiceAccount(string name, IamServiceAccountArgs? args = null, CustomResourceOptions? options = null)
            : base("yandex:index/iamServiceAccount:IamServiceAccount", name, args ?? new IamServiceAccountArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IamServiceAccount(string name, Input<string> id, IamServiceAccountState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/iamServiceAccount:IamServiceAccount", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing IamServiceAccount resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IamServiceAccount Get(string name, Input<string> id, IamServiceAccountState? state = null, CustomResourceOptions? options = null)
        {
            return new IamServiceAccount(name, id, state, options);
        }
    }

    public sealed class IamServiceAccountArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the service account.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// ID of the folder that the service account will be created in.
        /// Defaults to the provider folder configuration.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// Name of the service account.
        /// Can be updated without creating a new resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public IamServiceAccountArgs()
        {
        }
        public static new IamServiceAccountArgs Empty => new IamServiceAccountArgs();
    }

    public sealed class IamServiceAccountState : global::Pulumi.ResourceArgs
    {
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// Description of the service account.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// ID of the folder that the service account will be created in.
        /// Defaults to the provider folder configuration.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// Name of the service account.
        /// Can be updated without creating a new resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public IamServiceAccountState()
        {
        }
        public static new IamServiceAccountState Empty => new IamServiceAccountState();
    }
}
