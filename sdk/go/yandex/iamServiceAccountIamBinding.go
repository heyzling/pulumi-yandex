// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"errors"
	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// When managing IAM roles, you can treat a service account either as a resource or as an identity.
// This resource is used to add IAM policy bindings to a service account resource to configure permissions
// that define who can edit the service account.
//
// There are three different resources that help you manage your IAM policy for a service account.
// Each of these resources is used for a different use case:
//
// * yandex_iam_service_account_iam_policy: Authoritative. Sets the IAM policy for the service account and replaces any existing policy already attached.
// * yandex_iam_service_account_iam_binding: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the service account are preserved.
// * yandex_iam_service_account_iam_member: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role of the service account are preserved.
//
// > **Note:** `IamServiceAccountIamPolicy` **cannot** be used in conjunction with `IamServiceAccountIamBinding` and `IamServiceAccountIamMember` or they will conflict over what your policy should be.
//
// > **Note:** `IamServiceAccountIamBinding` resources **can be** used in conjunction with `IamServiceAccountIamMember` resources **only if** they do not grant privileges to the same role.
//
// ## yandex\_service\_account\_iam\_binding
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := yandex.NewIamServiceAccountIamBinding(ctx, "admin-account-iam", &yandex.IamServiceAccountIamBindingArgs{
//				Members: pulumi.StringArray{
//					pulumi.String("userAccount:foo_user_id"),
//				},
//				Role:             pulumi.String("admin"),
//				ServiceAccountId: pulumi.String("your-service-account-id"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
//
// ## Import
//
// Service account IAM binding resources can be imported using the service account ID and role.
//
// ```sh
// $ pulumi import yandex:index/iamServiceAccountIamBinding:IamServiceAccountIamBinding admin-account-iam "service_account_id roles/editor"
// ```
type IamServiceAccountIamBinding struct {
	pulumi.CustomResourceState

	// Identities that will be granted the privilege in `role`.
	// Each entry can have one of the following values:
	// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
	// * **serviceAccount:{service_account_id}**: A unique service account ID.
	// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
	// * **group:{group_id}**: A unique group ID.
	// * **system:group:federation:{federation_id}:users**: All users in federation.
	// * **system:group:organization:{organization_id}:users**: All users in organization.
	// * **system:allAuthenticatedUsers**: All authenticated users.
	// * **system:allUsers**: All users, including unauthenticated ones.
	//
	// Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
	Members pulumi.StringArrayOutput `pulumi:"members"`
	// The role that should be applied. Only one
	// `IamServiceAccountIamBinding` can be used per role.
	Role pulumi.StringOutput `pulumi:"role"`
	// The service account ID to apply a binding to.
	ServiceAccountId pulumi.StringOutput `pulumi:"serviceAccountId"`
	SleepAfter       pulumi.IntPtrOutput `pulumi:"sleepAfter"`
}

// NewIamServiceAccountIamBinding registers a new resource with the given unique name, arguments, and options.
func NewIamServiceAccountIamBinding(ctx *pulumi.Context,
	name string, args *IamServiceAccountIamBindingArgs, opts ...pulumi.ResourceOption) (*IamServiceAccountIamBinding, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Members == nil {
		return nil, errors.New("invalid value for required argument 'Members'")
	}
	if args.Role == nil {
		return nil, errors.New("invalid value for required argument 'Role'")
	}
	if args.ServiceAccountId == nil {
		return nil, errors.New("invalid value for required argument 'ServiceAccountId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource IamServiceAccountIamBinding
	err := ctx.RegisterResource("yandex:index/iamServiceAccountIamBinding:IamServiceAccountIamBinding", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIamServiceAccountIamBinding gets an existing IamServiceAccountIamBinding resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIamServiceAccountIamBinding(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IamServiceAccountIamBindingState, opts ...pulumi.ResourceOption) (*IamServiceAccountIamBinding, error) {
	var resource IamServiceAccountIamBinding
	err := ctx.ReadResource("yandex:index/iamServiceAccountIamBinding:IamServiceAccountIamBinding", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IamServiceAccountIamBinding resources.
type iamServiceAccountIamBindingState struct {
	// Identities that will be granted the privilege in `role`.
	// Each entry can have one of the following values:
	// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
	// * **serviceAccount:{service_account_id}**: A unique service account ID.
	// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
	// * **group:{group_id}**: A unique group ID.
	// * **system:group:federation:{federation_id}:users**: All users in federation.
	// * **system:group:organization:{organization_id}:users**: All users in organization.
	// * **system:allAuthenticatedUsers**: All authenticated users.
	// * **system:allUsers**: All users, including unauthenticated ones.
	//
	// Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
	Members []string `pulumi:"members"`
	// The role that should be applied. Only one
	// `IamServiceAccountIamBinding` can be used per role.
	Role *string `pulumi:"role"`
	// The service account ID to apply a binding to.
	ServiceAccountId *string `pulumi:"serviceAccountId"`
	SleepAfter       *int    `pulumi:"sleepAfter"`
}

type IamServiceAccountIamBindingState struct {
	// Identities that will be granted the privilege in `role`.
	// Each entry can have one of the following values:
	// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
	// * **serviceAccount:{service_account_id}**: A unique service account ID.
	// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
	// * **group:{group_id}**: A unique group ID.
	// * **system:group:federation:{federation_id}:users**: All users in federation.
	// * **system:group:organization:{organization_id}:users**: All users in organization.
	// * **system:allAuthenticatedUsers**: All authenticated users.
	// * **system:allUsers**: All users, including unauthenticated ones.
	//
	// Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
	Members pulumi.StringArrayInput
	// The role that should be applied. Only one
	// `IamServiceAccountIamBinding` can be used per role.
	Role pulumi.StringPtrInput
	// The service account ID to apply a binding to.
	ServiceAccountId pulumi.StringPtrInput
	SleepAfter       pulumi.IntPtrInput
}

func (IamServiceAccountIamBindingState) ElementType() reflect.Type {
	return reflect.TypeOf((*iamServiceAccountIamBindingState)(nil)).Elem()
}

type iamServiceAccountIamBindingArgs struct {
	// Identities that will be granted the privilege in `role`.
	// Each entry can have one of the following values:
	// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
	// * **serviceAccount:{service_account_id}**: A unique service account ID.
	// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
	// * **group:{group_id}**: A unique group ID.
	// * **system:group:federation:{federation_id}:users**: All users in federation.
	// * **system:group:organization:{organization_id}:users**: All users in organization.
	// * **system:allAuthenticatedUsers**: All authenticated users.
	// * **system:allUsers**: All users, including unauthenticated ones.
	//
	// Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
	Members []string `pulumi:"members"`
	// The role that should be applied. Only one
	// `IamServiceAccountIamBinding` can be used per role.
	Role string `pulumi:"role"`
	// The service account ID to apply a binding to.
	ServiceAccountId string `pulumi:"serviceAccountId"`
	SleepAfter       *int   `pulumi:"sleepAfter"`
}

// The set of arguments for constructing a IamServiceAccountIamBinding resource.
type IamServiceAccountIamBindingArgs struct {
	// Identities that will be granted the privilege in `role`.
	// Each entry can have one of the following values:
	// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
	// * **serviceAccount:{service_account_id}**: A unique service account ID.
	// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
	// * **group:{group_id}**: A unique group ID.
	// * **system:group:federation:{federation_id}:users**: All users in federation.
	// * **system:group:organization:{organization_id}:users**: All users in organization.
	// * **system:allAuthenticatedUsers**: All authenticated users.
	// * **system:allUsers**: All users, including unauthenticated ones.
	//
	// Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
	Members pulumi.StringArrayInput
	// The role that should be applied. Only one
	// `IamServiceAccountIamBinding` can be used per role.
	Role pulumi.StringInput
	// The service account ID to apply a binding to.
	ServiceAccountId pulumi.StringInput
	SleepAfter       pulumi.IntPtrInput
}

func (IamServiceAccountIamBindingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*iamServiceAccountIamBindingArgs)(nil)).Elem()
}

type IamServiceAccountIamBindingInput interface {
	pulumi.Input

	ToIamServiceAccountIamBindingOutput() IamServiceAccountIamBindingOutput
	ToIamServiceAccountIamBindingOutputWithContext(ctx context.Context) IamServiceAccountIamBindingOutput
}

func (*IamServiceAccountIamBinding) ElementType() reflect.Type {
	return reflect.TypeOf((**IamServiceAccountIamBinding)(nil)).Elem()
}

func (i *IamServiceAccountIamBinding) ToIamServiceAccountIamBindingOutput() IamServiceAccountIamBindingOutput {
	return i.ToIamServiceAccountIamBindingOutputWithContext(context.Background())
}

func (i *IamServiceAccountIamBinding) ToIamServiceAccountIamBindingOutputWithContext(ctx context.Context) IamServiceAccountIamBindingOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IamServiceAccountIamBindingOutput)
}

// IamServiceAccountIamBindingArrayInput is an input type that accepts IamServiceAccountIamBindingArray and IamServiceAccountIamBindingArrayOutput values.
// You can construct a concrete instance of `IamServiceAccountIamBindingArrayInput` via:
//
//	IamServiceAccountIamBindingArray{ IamServiceAccountIamBindingArgs{...} }
type IamServiceAccountIamBindingArrayInput interface {
	pulumi.Input

	ToIamServiceAccountIamBindingArrayOutput() IamServiceAccountIamBindingArrayOutput
	ToIamServiceAccountIamBindingArrayOutputWithContext(context.Context) IamServiceAccountIamBindingArrayOutput
}

type IamServiceAccountIamBindingArray []IamServiceAccountIamBindingInput

func (IamServiceAccountIamBindingArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IamServiceAccountIamBinding)(nil)).Elem()
}

func (i IamServiceAccountIamBindingArray) ToIamServiceAccountIamBindingArrayOutput() IamServiceAccountIamBindingArrayOutput {
	return i.ToIamServiceAccountIamBindingArrayOutputWithContext(context.Background())
}

func (i IamServiceAccountIamBindingArray) ToIamServiceAccountIamBindingArrayOutputWithContext(ctx context.Context) IamServiceAccountIamBindingArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IamServiceAccountIamBindingArrayOutput)
}

// IamServiceAccountIamBindingMapInput is an input type that accepts IamServiceAccountIamBindingMap and IamServiceAccountIamBindingMapOutput values.
// You can construct a concrete instance of `IamServiceAccountIamBindingMapInput` via:
//
//	IamServiceAccountIamBindingMap{ "key": IamServiceAccountIamBindingArgs{...} }
type IamServiceAccountIamBindingMapInput interface {
	pulumi.Input

	ToIamServiceAccountIamBindingMapOutput() IamServiceAccountIamBindingMapOutput
	ToIamServiceAccountIamBindingMapOutputWithContext(context.Context) IamServiceAccountIamBindingMapOutput
}

type IamServiceAccountIamBindingMap map[string]IamServiceAccountIamBindingInput

func (IamServiceAccountIamBindingMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IamServiceAccountIamBinding)(nil)).Elem()
}

func (i IamServiceAccountIamBindingMap) ToIamServiceAccountIamBindingMapOutput() IamServiceAccountIamBindingMapOutput {
	return i.ToIamServiceAccountIamBindingMapOutputWithContext(context.Background())
}

func (i IamServiceAccountIamBindingMap) ToIamServiceAccountIamBindingMapOutputWithContext(ctx context.Context) IamServiceAccountIamBindingMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IamServiceAccountIamBindingMapOutput)
}

type IamServiceAccountIamBindingOutput struct{ *pulumi.OutputState }

func (IamServiceAccountIamBindingOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**IamServiceAccountIamBinding)(nil)).Elem()
}

func (o IamServiceAccountIamBindingOutput) ToIamServiceAccountIamBindingOutput() IamServiceAccountIamBindingOutput {
	return o
}

func (o IamServiceAccountIamBindingOutput) ToIamServiceAccountIamBindingOutputWithContext(ctx context.Context) IamServiceAccountIamBindingOutput {
	return o
}

// Identities that will be granted the privilege in `role`.
// Each entry can have one of the following values:
// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
// * **serviceAccount:{service_account_id}**: A unique service account ID.
// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
// * **group:{group_id}**: A unique group ID.
// * **system:group:federation:{federation_id}:users**: All users in federation.
// * **system:group:organization:{organization_id}:users**: All users in organization.
// * **system:allAuthenticatedUsers**: All authenticated users.
// * **system:allUsers**: All users, including unauthenticated ones.
//
// Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
func (o IamServiceAccountIamBindingOutput) Members() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *IamServiceAccountIamBinding) pulumi.StringArrayOutput { return v.Members }).(pulumi.StringArrayOutput)
}

// The role that should be applied. Only one
// `IamServiceAccountIamBinding` can be used per role.
func (o IamServiceAccountIamBindingOutput) Role() pulumi.StringOutput {
	return o.ApplyT(func(v *IamServiceAccountIamBinding) pulumi.StringOutput { return v.Role }).(pulumi.StringOutput)
}

// The service account ID to apply a binding to.
func (o IamServiceAccountIamBindingOutput) ServiceAccountId() pulumi.StringOutput {
	return o.ApplyT(func(v *IamServiceAccountIamBinding) pulumi.StringOutput { return v.ServiceAccountId }).(pulumi.StringOutput)
}

func (o IamServiceAccountIamBindingOutput) SleepAfter() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *IamServiceAccountIamBinding) pulumi.IntPtrOutput { return v.SleepAfter }).(pulumi.IntPtrOutput)
}

type IamServiceAccountIamBindingArrayOutput struct{ *pulumi.OutputState }

func (IamServiceAccountIamBindingArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IamServiceAccountIamBinding)(nil)).Elem()
}

func (o IamServiceAccountIamBindingArrayOutput) ToIamServiceAccountIamBindingArrayOutput() IamServiceAccountIamBindingArrayOutput {
	return o
}

func (o IamServiceAccountIamBindingArrayOutput) ToIamServiceAccountIamBindingArrayOutputWithContext(ctx context.Context) IamServiceAccountIamBindingArrayOutput {
	return o
}

func (o IamServiceAccountIamBindingArrayOutput) Index(i pulumi.IntInput) IamServiceAccountIamBindingOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *IamServiceAccountIamBinding {
		return vs[0].([]*IamServiceAccountIamBinding)[vs[1].(int)]
	}).(IamServiceAccountIamBindingOutput)
}

type IamServiceAccountIamBindingMapOutput struct{ *pulumi.OutputState }

func (IamServiceAccountIamBindingMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IamServiceAccountIamBinding)(nil)).Elem()
}

func (o IamServiceAccountIamBindingMapOutput) ToIamServiceAccountIamBindingMapOutput() IamServiceAccountIamBindingMapOutput {
	return o
}

func (o IamServiceAccountIamBindingMapOutput) ToIamServiceAccountIamBindingMapOutputWithContext(ctx context.Context) IamServiceAccountIamBindingMapOutput {
	return o
}

func (o IamServiceAccountIamBindingMapOutput) MapIndex(k pulumi.StringInput) IamServiceAccountIamBindingOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *IamServiceAccountIamBinding {
		return vs[0].(map[string]*IamServiceAccountIamBinding)[vs[1].(string)]
	}).(IamServiceAccountIamBindingOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*IamServiceAccountIamBindingInput)(nil)).Elem(), &IamServiceAccountIamBinding{})
	pulumi.RegisterInputType(reflect.TypeOf((*IamServiceAccountIamBindingArrayInput)(nil)).Elem(), IamServiceAccountIamBindingArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*IamServiceAccountIamBindingMapInput)(nil)).Elem(), IamServiceAccountIamBindingMap{})
	pulumi.RegisterOutputType(IamServiceAccountIamBindingOutput{})
	pulumi.RegisterOutputType(IamServiceAccountIamBindingArrayOutput{})
	pulumi.RegisterOutputType(IamServiceAccountIamBindingMapOutput{})
}