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
    /// ## yandex\_container\_registry\_iam\_binding
    /// 
    /// Allows creation and management of a single binding within IAM policy for
    /// an existing Yandex Container Registry.
    /// 
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
    ///     var your_registry = new Yandex.ContainerRegistry("your-registry", new()
    ///     {
    ///         FolderId = "your-folder-id",
    ///     });
    /// 
    ///     var puller = new Yandex.ContainerRegistryIamBinding("puller", new()
    ///     {
    ///         RegistryId = your_registry.Id,
    ///         Role = "container-registry.images.puller",
    ///         Members = new[]
    ///         {
    ///             "system:allUsers",
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// IAM binding imports use space-delimited identifiers; first the resource in question and then the role.
    /// 
    /// These bindings can be imported using the `registry_id` and role, e.g.
    /// 
    /// ```sh
    /// $ pulumi import yandex:index/containerRegistryIamBinding:ContainerRegistryIamBinding puller "registry_id container-registry.images.puller"
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/containerRegistryIamBinding:ContainerRegistryIamBinding")]
    public partial class ContainerRegistryIamBinding : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Identities that will be granted the privilege in `role`.
        /// Each entry can have one of the following values:
        /// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
        /// * **serviceAccount:{service_account_id}**: A unique service account ID.
        /// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
        /// * **group:{group_id}**: A unique group ID.
        /// * **system:group:federation:{federation_id}:users**: All users in federation.
        /// * **system:group:organization:{organization_id}:users**: All users in organization.
        /// * **system:allAuthenticatedUsers**: All authenticated users.
        /// * **system:allUsers**: All users, including unauthenticated ones.
        /// 
        /// Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
        /// </summary>
        [Output("members")]
        public Output<ImmutableArray<string>> Members { get; private set; } = null!;

        /// <summary>
        /// The [Yandex Container Registry](https://cloud.yandex.com/docs/container-registry/) ID to apply a binding to.
        /// </summary>
        [Output("registryId")]
        public Output<string> RegistryId { get; private set; } = null!;

        /// <summary>
        /// The role that should be applied. See [roles](https://cloud.yandex.com/docs/container-registry/security/).
        /// </summary>
        [Output("role")]
        public Output<string> Role { get; private set; } = null!;

        [Output("sleepAfter")]
        public Output<int?> SleepAfter { get; private set; } = null!;


        /// <summary>
        /// Create a ContainerRegistryIamBinding resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ContainerRegistryIamBinding(string name, ContainerRegistryIamBindingArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/containerRegistryIamBinding:ContainerRegistryIamBinding", name, args ?? new ContainerRegistryIamBindingArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ContainerRegistryIamBinding(string name, Input<string> id, ContainerRegistryIamBindingState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/containerRegistryIamBinding:ContainerRegistryIamBinding", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ContainerRegistryIamBinding resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ContainerRegistryIamBinding Get(string name, Input<string> id, ContainerRegistryIamBindingState? state = null, CustomResourceOptions? options = null)
        {
            return new ContainerRegistryIamBinding(name, id, state, options);
        }
    }

    public sealed class ContainerRegistryIamBindingArgs : global::Pulumi.ResourceArgs
    {
        [Input("members", required: true)]
        private InputList<string>? _members;

        /// <summary>
        /// Identities that will be granted the privilege in `role`.
        /// Each entry can have one of the following values:
        /// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
        /// * **serviceAccount:{service_account_id}**: A unique service account ID.
        /// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
        /// * **group:{group_id}**: A unique group ID.
        /// * **system:group:federation:{federation_id}:users**: All users in federation.
        /// * **system:group:organization:{organization_id}:users**: All users in organization.
        /// * **system:allAuthenticatedUsers**: All authenticated users.
        /// * **system:allUsers**: All users, including unauthenticated ones.
        /// 
        /// Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
        /// </summary>
        public InputList<string> Members
        {
            get => _members ?? (_members = new InputList<string>());
            set => _members = value;
        }

        /// <summary>
        /// The [Yandex Container Registry](https://cloud.yandex.com/docs/container-registry/) ID to apply a binding to.
        /// </summary>
        [Input("registryId", required: true)]
        public Input<string> RegistryId { get; set; } = null!;

        /// <summary>
        /// The role that should be applied. See [roles](https://cloud.yandex.com/docs/container-registry/security/).
        /// </summary>
        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        [Input("sleepAfter")]
        public Input<int>? SleepAfter { get; set; }

        public ContainerRegistryIamBindingArgs()
        {
        }
        public static new ContainerRegistryIamBindingArgs Empty => new ContainerRegistryIamBindingArgs();
    }

    public sealed class ContainerRegistryIamBindingState : global::Pulumi.ResourceArgs
    {
        [Input("members")]
        private InputList<string>? _members;

        /// <summary>
        /// Identities that will be granted the privilege in `role`.
        /// Each entry can have one of the following values:
        /// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
        /// * **serviceAccount:{service_account_id}**: A unique service account ID.
        /// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
        /// * **group:{group_id}**: A unique group ID.
        /// * **system:group:federation:{federation_id}:users**: All users in federation.
        /// * **system:group:organization:{organization_id}:users**: All users in organization.
        /// * **system:allAuthenticatedUsers**: All authenticated users.
        /// * **system:allUsers**: All users, including unauthenticated ones.
        /// 
        /// Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
        /// </summary>
        public InputList<string> Members
        {
            get => _members ?? (_members = new InputList<string>());
            set => _members = value;
        }

        /// <summary>
        /// The [Yandex Container Registry](https://cloud.yandex.com/docs/container-registry/) ID to apply a binding to.
        /// </summary>
        [Input("registryId")]
        public Input<string>? RegistryId { get; set; }

        /// <summary>
        /// The role that should be applied. See [roles](https://cloud.yandex.com/docs/container-registry/security/).
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("sleepAfter")]
        public Input<int>? SleepAfter { get; set; }

        public ContainerRegistryIamBindingState()
        {
        }
        public static new ContainerRegistryIamBindingState Empty => new ContainerRegistryIamBindingState();
    }
}