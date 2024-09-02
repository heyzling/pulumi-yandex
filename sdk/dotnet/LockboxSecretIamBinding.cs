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
    /// ## yandex\_lockbox\_secret\_iam\_binding
    /// 
    /// Allows creation and management of a single binding within IAM policy for
    /// an existing Yandex Lockbox Secret.
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
    ///     var your_secret = new Yandex.LockboxSecret("your-secret");
    /// 
    ///     var viewer = new Yandex.LockboxSecretIamBinding("viewer", new()
    ///     {
    ///         SecretId = your_secret.Id,
    ///         Role = "viewer",
    ///         Members = new[]
    ///         {
    ///             "userAccount:foo_user_id",
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
    /// These bindings can be imported using the `secret_id` and role, e.g.
    /// 
    /// ```sh
    /// $ pulumi import yandex:index/lockboxSecretIamBinding:LockboxSecretIamBinding viewer "secret_id viewer"
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/lockboxSecretIamBinding:LockboxSecretIamBinding")]
    public partial class LockboxSecretIamBinding : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Identities that will be granted the privilege in `role`.
        /// Each entry can have one of the following values:
        /// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
        /// * **serviceAccount:{service_account_id}**: A unique service account ID.
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
        /// The role that should be applied. See [roles](https://cloud.yandex.com/docs/lockbox/security/).
        /// </summary>
        [Output("role")]
        public Output<string> Role { get; private set; } = null!;

        /// <summary>
        /// The [Yandex Lockbox Secret](https://cloud.yandex.com/docs/lockbox/) Secret ID to apply a binding to.
        /// </summary>
        [Output("secretId")]
        public Output<string> SecretId { get; private set; } = null!;

        [Output("sleepAfter")]
        public Output<int?> SleepAfter { get; private set; } = null!;


        /// <summary>
        /// Create a LockboxSecretIamBinding resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LockboxSecretIamBinding(string name, LockboxSecretIamBindingArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/lockboxSecretIamBinding:LockboxSecretIamBinding", name, args ?? new LockboxSecretIamBindingArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LockboxSecretIamBinding(string name, Input<string> id, LockboxSecretIamBindingState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/lockboxSecretIamBinding:LockboxSecretIamBinding", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LockboxSecretIamBinding resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LockboxSecretIamBinding Get(string name, Input<string> id, LockboxSecretIamBindingState? state = null, CustomResourceOptions? options = null)
        {
            return new LockboxSecretIamBinding(name, id, state, options);
        }
    }

    public sealed class LockboxSecretIamBindingArgs : global::Pulumi.ResourceArgs
    {
        [Input("members", required: true)]
        private InputList<string>? _members;

        /// <summary>
        /// Identities that will be granted the privilege in `role`.
        /// Each entry can have one of the following values:
        /// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
        /// * **serviceAccount:{service_account_id}**: A unique service account ID.
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
        /// The role that should be applied. See [roles](https://cloud.yandex.com/docs/lockbox/security/).
        /// </summary>
        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        /// <summary>
        /// The [Yandex Lockbox Secret](https://cloud.yandex.com/docs/lockbox/) Secret ID to apply a binding to.
        /// </summary>
        [Input("secretId", required: true)]
        public Input<string> SecretId { get; set; } = null!;

        [Input("sleepAfter")]
        public Input<int>? SleepAfter { get; set; }

        public LockboxSecretIamBindingArgs()
        {
        }
        public static new LockboxSecretIamBindingArgs Empty => new LockboxSecretIamBindingArgs();
    }

    public sealed class LockboxSecretIamBindingState : global::Pulumi.ResourceArgs
    {
        [Input("members")]
        private InputList<string>? _members;

        /// <summary>
        /// Identities that will be granted the privilege in `role`.
        /// Each entry can have one of the following values:
        /// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
        /// * **serviceAccount:{service_account_id}**: A unique service account ID.
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
        /// The role that should be applied. See [roles](https://cloud.yandex.com/docs/lockbox/security/).
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        /// <summary>
        /// The [Yandex Lockbox Secret](https://cloud.yandex.com/docs/lockbox/) Secret ID to apply a binding to.
        /// </summary>
        [Input("secretId")]
        public Input<string>? SecretId { get; set; }

        [Input("sleepAfter")]
        public Input<int>? SleepAfter { get; set; }

        public LockboxSecretIamBindingState()
        {
        }
        public static new LockboxSecretIamBindingState Empty => new LockboxSecretIamBindingState();
    }
}
