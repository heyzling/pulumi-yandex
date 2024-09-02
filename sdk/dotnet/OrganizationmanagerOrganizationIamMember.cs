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
    /// Allows creation and management of a single member for a single binding within
    /// the IAM policy for an existing Yandex Organization Manager organization.
    /// 
    /// &gt; **Note:** Roles controlled by `yandex.OrganizationmanagerOrganizationIamBinding`
    ///    should not be assigned using `yandex.OrganizationmanagerOrganizationIamMember`.
    /// 
    /// &gt; **Note:** When you delete `yandex.OrganizationmanagerOrganizationIamBinding` resource,
    ///    the roles can be deleted from other users within the organization as well. Be careful!
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
    ///     var editor = new Yandex.OrganizationmanagerOrganizationIamMember("editor", new()
    ///     {
    ///         Member = "userAccount:user_id",
    ///         OrganizationId = "some_organization_id",
    ///         Role = "editor",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// IAM member imports use space-delimited identifiers; the resource in question, the role, and the account.
    /// 
    /// This member resource can be imported using the `organization id`, role, and account, e.g.
    /// 
    /// ```sh
    /// $ pulumi import yandex:index/organizationmanagerOrganizationIamMember:OrganizationmanagerOrganizationIamMember my_project "organization_id viewer foo@example.com"
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/organizationmanagerOrganizationIamMember:OrganizationmanagerOrganizationIamMember")]
    public partial class OrganizationmanagerOrganizationIamMember : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The identity that will be granted the privilege that is specified in the `role` field.
        /// This field can have one of the following values:
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
        [Output("member")]
        public Output<string> Member { get; private set; } = null!;

        /// <summary>
        /// ID of the organization to attach a policy to.
        /// </summary>
        [Output("organizationId")]
        public Output<string> OrganizationId { get; private set; } = null!;

        /// <summary>
        /// The role that should be assigned.
        /// </summary>
        [Output("role")]
        public Output<string> Role { get; private set; } = null!;

        [Output("sleepAfter")]
        public Output<int?> SleepAfter { get; private set; } = null!;


        /// <summary>
        /// Create a OrganizationmanagerOrganizationIamMember resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public OrganizationmanagerOrganizationIamMember(string name, OrganizationmanagerOrganizationIamMemberArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/organizationmanagerOrganizationIamMember:OrganizationmanagerOrganizationIamMember", name, args ?? new OrganizationmanagerOrganizationIamMemberArgs(), MakeResourceOptions(options, ""))
        {
        }

        private OrganizationmanagerOrganizationIamMember(string name, Input<string> id, OrganizationmanagerOrganizationIamMemberState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/organizationmanagerOrganizationIamMember:OrganizationmanagerOrganizationIamMember", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing OrganizationmanagerOrganizationIamMember resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static OrganizationmanagerOrganizationIamMember Get(string name, Input<string> id, OrganizationmanagerOrganizationIamMemberState? state = null, CustomResourceOptions? options = null)
        {
            return new OrganizationmanagerOrganizationIamMember(name, id, state, options);
        }
    }

    public sealed class OrganizationmanagerOrganizationIamMemberArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The identity that will be granted the privilege that is specified in the `role` field.
        /// This field can have one of the following values:
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
        [Input("member", required: true)]
        public Input<string> Member { get; set; } = null!;

        /// <summary>
        /// ID of the organization to attach a policy to.
        /// </summary>
        [Input("organizationId", required: true)]
        public Input<string> OrganizationId { get; set; } = null!;

        /// <summary>
        /// The role that should be assigned.
        /// </summary>
        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        [Input("sleepAfter")]
        public Input<int>? SleepAfter { get; set; }

        public OrganizationmanagerOrganizationIamMemberArgs()
        {
        }
        public static new OrganizationmanagerOrganizationIamMemberArgs Empty => new OrganizationmanagerOrganizationIamMemberArgs();
    }

    public sealed class OrganizationmanagerOrganizationIamMemberState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The identity that will be granted the privilege that is specified in the `role` field.
        /// This field can have one of the following values:
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
        [Input("member")]
        public Input<string>? Member { get; set; }

        /// <summary>
        /// ID of the organization to attach a policy to.
        /// </summary>
        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        /// <summary>
        /// The role that should be assigned.
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("sleepAfter")]
        public Input<int>? SleepAfter { get; set; }

        public OrganizationmanagerOrganizationIamMemberState()
        {
        }
        public static new OrganizationmanagerOrganizationIamMemberState Empty => new OrganizationmanagerOrganizationIamMemberState();
    }
}