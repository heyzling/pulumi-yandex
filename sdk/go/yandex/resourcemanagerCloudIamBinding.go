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

// Allows creation and management of a single binding within IAM policy for
// an existing Yandex Resource Manager cloud.
//
// ## Example Usage
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
//			project1, err := yandex.LookupResourcemanagerCloud(ctx, &yandex.LookupResourcemanagerCloudArgs{
//				Name: pulumi.StringRef("Project 1"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			_, err = yandex.NewResourcemanagerCloudIamBinding(ctx, "admin", &yandex.ResourcemanagerCloudIamBindingArgs{
//				CloudId: pulumi.String(project1.Id),
//				Members: pulumi.StringArray{
//					pulumi.String("userAccount:some_user_id"),
//				},
//				Role: pulumi.String("editor"),
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
// IAM binding imports use space-delimited identifiers; first the resource in question and then the role.
//
// These bindings can be imported using the `cloud_id` and role, e.g.
//
// ```sh
// $ pulumi import yandex:index/resourcemanagerCloudIamBinding:ResourcemanagerCloudIamBinding viewer "cloud_id viewer"
// ```
type ResourcemanagerCloudIamBinding struct {
	pulumi.CustomResourceState

	// ID of the cloud to attach the policy to.
	CloudId pulumi.StringOutput `pulumi:"cloudId"`
	// An array of identities that will be granted the privilege in the `role`.
	// Each entry can have one of the following values:
	// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
	// * **serviceAccount:{service_account_id}**: A unique service account ID.
	// * **federatedUser:{federated_user_id}**: A unique federated user ID.
	// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
	// * **group:{group_id}**: A unique group ID.
	// * **system:group:federation:{federation_id}:users**: All users in federation.
	// * **system:group:organization:{organization_id}:users**: All users in organization.
	// * **system:allAuthenticatedUsers**: All authenticated users.
	// * **system:allUsers**: All users, including unauthenticated ones.
	//
	// Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
	Members pulumi.StringArrayOutput `pulumi:"members"`
	// The role that should be assigned. Only one
	// `ResourcemanagerCloudIamBinding` can be used per role.
	Role       pulumi.StringOutput `pulumi:"role"`
	SleepAfter pulumi.IntPtrOutput `pulumi:"sleepAfter"`
}

// NewResourcemanagerCloudIamBinding registers a new resource with the given unique name, arguments, and options.
func NewResourcemanagerCloudIamBinding(ctx *pulumi.Context,
	name string, args *ResourcemanagerCloudIamBindingArgs, opts ...pulumi.ResourceOption) (*ResourcemanagerCloudIamBinding, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CloudId == nil {
		return nil, errors.New("invalid value for required argument 'CloudId'")
	}
	if args.Members == nil {
		return nil, errors.New("invalid value for required argument 'Members'")
	}
	if args.Role == nil {
		return nil, errors.New("invalid value for required argument 'Role'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ResourcemanagerCloudIamBinding
	err := ctx.RegisterResource("yandex:index/resourcemanagerCloudIamBinding:ResourcemanagerCloudIamBinding", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetResourcemanagerCloudIamBinding gets an existing ResourcemanagerCloudIamBinding resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetResourcemanagerCloudIamBinding(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ResourcemanagerCloudIamBindingState, opts ...pulumi.ResourceOption) (*ResourcemanagerCloudIamBinding, error) {
	var resource ResourcemanagerCloudIamBinding
	err := ctx.ReadResource("yandex:index/resourcemanagerCloudIamBinding:ResourcemanagerCloudIamBinding", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ResourcemanagerCloudIamBinding resources.
type resourcemanagerCloudIamBindingState struct {
	// ID of the cloud to attach the policy to.
	CloudId *string `pulumi:"cloudId"`
	// An array of identities that will be granted the privilege in the `role`.
	// Each entry can have one of the following values:
	// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
	// * **serviceAccount:{service_account_id}**: A unique service account ID.
	// * **federatedUser:{federated_user_id}**: A unique federated user ID.
	// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
	// * **group:{group_id}**: A unique group ID.
	// * **system:group:federation:{federation_id}:users**: All users in federation.
	// * **system:group:organization:{organization_id}:users**: All users in organization.
	// * **system:allAuthenticatedUsers**: All authenticated users.
	// * **system:allUsers**: All users, including unauthenticated ones.
	//
	// Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
	Members []string `pulumi:"members"`
	// The role that should be assigned. Only one
	// `ResourcemanagerCloudIamBinding` can be used per role.
	Role       *string `pulumi:"role"`
	SleepAfter *int    `pulumi:"sleepAfter"`
}

type ResourcemanagerCloudIamBindingState struct {
	// ID of the cloud to attach the policy to.
	CloudId pulumi.StringPtrInput
	// An array of identities that will be granted the privilege in the `role`.
	// Each entry can have one of the following values:
	// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
	// * **serviceAccount:{service_account_id}**: A unique service account ID.
	// * **federatedUser:{federated_user_id}**: A unique federated user ID.
	// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
	// * **group:{group_id}**: A unique group ID.
	// * **system:group:federation:{federation_id}:users**: All users in federation.
	// * **system:group:organization:{organization_id}:users**: All users in organization.
	// * **system:allAuthenticatedUsers**: All authenticated users.
	// * **system:allUsers**: All users, including unauthenticated ones.
	//
	// Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
	Members pulumi.StringArrayInput
	// The role that should be assigned. Only one
	// `ResourcemanagerCloudIamBinding` can be used per role.
	Role       pulumi.StringPtrInput
	SleepAfter pulumi.IntPtrInput
}

func (ResourcemanagerCloudIamBindingState) ElementType() reflect.Type {
	return reflect.TypeOf((*resourcemanagerCloudIamBindingState)(nil)).Elem()
}

type resourcemanagerCloudIamBindingArgs struct {
	// ID of the cloud to attach the policy to.
	CloudId string `pulumi:"cloudId"`
	// An array of identities that will be granted the privilege in the `role`.
	// Each entry can have one of the following values:
	// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
	// * **serviceAccount:{service_account_id}**: A unique service account ID.
	// * **federatedUser:{federated_user_id}**: A unique federated user ID.
	// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
	// * **group:{group_id}**: A unique group ID.
	// * **system:group:federation:{federation_id}:users**: All users in federation.
	// * **system:group:organization:{organization_id}:users**: All users in organization.
	// * **system:allAuthenticatedUsers**: All authenticated users.
	// * **system:allUsers**: All users, including unauthenticated ones.
	//
	// Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
	Members []string `pulumi:"members"`
	// The role that should be assigned. Only one
	// `ResourcemanagerCloudIamBinding` can be used per role.
	Role       string `pulumi:"role"`
	SleepAfter *int   `pulumi:"sleepAfter"`
}

// The set of arguments for constructing a ResourcemanagerCloudIamBinding resource.
type ResourcemanagerCloudIamBindingArgs struct {
	// ID of the cloud to attach the policy to.
	CloudId pulumi.StringInput
	// An array of identities that will be granted the privilege in the `role`.
	// Each entry can have one of the following values:
	// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
	// * **serviceAccount:{service_account_id}**: A unique service account ID.
	// * **federatedUser:{federated_user_id}**: A unique federated user ID.
	// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
	// * **group:{group_id}**: A unique group ID.
	// * **system:group:federation:{federation_id}:users**: All users in federation.
	// * **system:group:organization:{organization_id}:users**: All users in organization.
	// * **system:allAuthenticatedUsers**: All authenticated users.
	// * **system:allUsers**: All users, including unauthenticated ones.
	//
	// Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
	Members pulumi.StringArrayInput
	// The role that should be assigned. Only one
	// `ResourcemanagerCloudIamBinding` can be used per role.
	Role       pulumi.StringInput
	SleepAfter pulumi.IntPtrInput
}

func (ResourcemanagerCloudIamBindingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*resourcemanagerCloudIamBindingArgs)(nil)).Elem()
}

type ResourcemanagerCloudIamBindingInput interface {
	pulumi.Input

	ToResourcemanagerCloudIamBindingOutput() ResourcemanagerCloudIamBindingOutput
	ToResourcemanagerCloudIamBindingOutputWithContext(ctx context.Context) ResourcemanagerCloudIamBindingOutput
}

func (*ResourcemanagerCloudIamBinding) ElementType() reflect.Type {
	return reflect.TypeOf((**ResourcemanagerCloudIamBinding)(nil)).Elem()
}

func (i *ResourcemanagerCloudIamBinding) ToResourcemanagerCloudIamBindingOutput() ResourcemanagerCloudIamBindingOutput {
	return i.ToResourcemanagerCloudIamBindingOutputWithContext(context.Background())
}

func (i *ResourcemanagerCloudIamBinding) ToResourcemanagerCloudIamBindingOutputWithContext(ctx context.Context) ResourcemanagerCloudIamBindingOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourcemanagerCloudIamBindingOutput)
}

// ResourcemanagerCloudIamBindingArrayInput is an input type that accepts ResourcemanagerCloudIamBindingArray and ResourcemanagerCloudIamBindingArrayOutput values.
// You can construct a concrete instance of `ResourcemanagerCloudIamBindingArrayInput` via:
//
//	ResourcemanagerCloudIamBindingArray{ ResourcemanagerCloudIamBindingArgs{...} }
type ResourcemanagerCloudIamBindingArrayInput interface {
	pulumi.Input

	ToResourcemanagerCloudIamBindingArrayOutput() ResourcemanagerCloudIamBindingArrayOutput
	ToResourcemanagerCloudIamBindingArrayOutputWithContext(context.Context) ResourcemanagerCloudIamBindingArrayOutput
}

type ResourcemanagerCloudIamBindingArray []ResourcemanagerCloudIamBindingInput

func (ResourcemanagerCloudIamBindingArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ResourcemanagerCloudIamBinding)(nil)).Elem()
}

func (i ResourcemanagerCloudIamBindingArray) ToResourcemanagerCloudIamBindingArrayOutput() ResourcemanagerCloudIamBindingArrayOutput {
	return i.ToResourcemanagerCloudIamBindingArrayOutputWithContext(context.Background())
}

func (i ResourcemanagerCloudIamBindingArray) ToResourcemanagerCloudIamBindingArrayOutputWithContext(ctx context.Context) ResourcemanagerCloudIamBindingArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourcemanagerCloudIamBindingArrayOutput)
}

// ResourcemanagerCloudIamBindingMapInput is an input type that accepts ResourcemanagerCloudIamBindingMap and ResourcemanagerCloudIamBindingMapOutput values.
// You can construct a concrete instance of `ResourcemanagerCloudIamBindingMapInput` via:
//
//	ResourcemanagerCloudIamBindingMap{ "key": ResourcemanagerCloudIamBindingArgs{...} }
type ResourcemanagerCloudIamBindingMapInput interface {
	pulumi.Input

	ToResourcemanagerCloudIamBindingMapOutput() ResourcemanagerCloudIamBindingMapOutput
	ToResourcemanagerCloudIamBindingMapOutputWithContext(context.Context) ResourcemanagerCloudIamBindingMapOutput
}

type ResourcemanagerCloudIamBindingMap map[string]ResourcemanagerCloudIamBindingInput

func (ResourcemanagerCloudIamBindingMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ResourcemanagerCloudIamBinding)(nil)).Elem()
}

func (i ResourcemanagerCloudIamBindingMap) ToResourcemanagerCloudIamBindingMapOutput() ResourcemanagerCloudIamBindingMapOutput {
	return i.ToResourcemanagerCloudIamBindingMapOutputWithContext(context.Background())
}

func (i ResourcemanagerCloudIamBindingMap) ToResourcemanagerCloudIamBindingMapOutputWithContext(ctx context.Context) ResourcemanagerCloudIamBindingMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourcemanagerCloudIamBindingMapOutput)
}

type ResourcemanagerCloudIamBindingOutput struct{ *pulumi.OutputState }

func (ResourcemanagerCloudIamBindingOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ResourcemanagerCloudIamBinding)(nil)).Elem()
}

func (o ResourcemanagerCloudIamBindingOutput) ToResourcemanagerCloudIamBindingOutput() ResourcemanagerCloudIamBindingOutput {
	return o
}

func (o ResourcemanagerCloudIamBindingOutput) ToResourcemanagerCloudIamBindingOutputWithContext(ctx context.Context) ResourcemanagerCloudIamBindingOutput {
	return o
}

// ID of the cloud to attach the policy to.
func (o ResourcemanagerCloudIamBindingOutput) CloudId() pulumi.StringOutput {
	return o.ApplyT(func(v *ResourcemanagerCloudIamBinding) pulumi.StringOutput { return v.CloudId }).(pulumi.StringOutput)
}

// An array of identities that will be granted the privilege in the `role`.
// Each entry can have one of the following values:
// * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
// * **serviceAccount:{service_account_id}**: A unique service account ID.
// * **federatedUser:{federated_user_id}**: A unique federated user ID.
// * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
// * **group:{group_id}**: A unique group ID.
// * **system:group:federation:{federation_id}:users**: All users in federation.
// * **system:group:organization:{organization_id}:users**: All users in organization.
// * **system:allAuthenticatedUsers**: All authenticated users.
// * **system:allUsers**: All users, including unauthenticated ones.
//
// Note: for more information about system groups, see the [documentation](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group).
func (o ResourcemanagerCloudIamBindingOutput) Members() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *ResourcemanagerCloudIamBinding) pulumi.StringArrayOutput { return v.Members }).(pulumi.StringArrayOutput)
}

// The role that should be assigned. Only one
// `ResourcemanagerCloudIamBinding` can be used per role.
func (o ResourcemanagerCloudIamBindingOutput) Role() pulumi.StringOutput {
	return o.ApplyT(func(v *ResourcemanagerCloudIamBinding) pulumi.StringOutput { return v.Role }).(pulumi.StringOutput)
}

func (o ResourcemanagerCloudIamBindingOutput) SleepAfter() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ResourcemanagerCloudIamBinding) pulumi.IntPtrOutput { return v.SleepAfter }).(pulumi.IntPtrOutput)
}

type ResourcemanagerCloudIamBindingArrayOutput struct{ *pulumi.OutputState }

func (ResourcemanagerCloudIamBindingArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ResourcemanagerCloudIamBinding)(nil)).Elem()
}

func (o ResourcemanagerCloudIamBindingArrayOutput) ToResourcemanagerCloudIamBindingArrayOutput() ResourcemanagerCloudIamBindingArrayOutput {
	return o
}

func (o ResourcemanagerCloudIamBindingArrayOutput) ToResourcemanagerCloudIamBindingArrayOutputWithContext(ctx context.Context) ResourcemanagerCloudIamBindingArrayOutput {
	return o
}

func (o ResourcemanagerCloudIamBindingArrayOutput) Index(i pulumi.IntInput) ResourcemanagerCloudIamBindingOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ResourcemanagerCloudIamBinding {
		return vs[0].([]*ResourcemanagerCloudIamBinding)[vs[1].(int)]
	}).(ResourcemanagerCloudIamBindingOutput)
}

type ResourcemanagerCloudIamBindingMapOutput struct{ *pulumi.OutputState }

func (ResourcemanagerCloudIamBindingMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ResourcemanagerCloudIamBinding)(nil)).Elem()
}

func (o ResourcemanagerCloudIamBindingMapOutput) ToResourcemanagerCloudIamBindingMapOutput() ResourcemanagerCloudIamBindingMapOutput {
	return o
}

func (o ResourcemanagerCloudIamBindingMapOutput) ToResourcemanagerCloudIamBindingMapOutputWithContext(ctx context.Context) ResourcemanagerCloudIamBindingMapOutput {
	return o
}

func (o ResourcemanagerCloudIamBindingMapOutput) MapIndex(k pulumi.StringInput) ResourcemanagerCloudIamBindingOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ResourcemanagerCloudIamBinding {
		return vs[0].(map[string]*ResourcemanagerCloudIamBinding)[vs[1].(string)]
	}).(ResourcemanagerCloudIamBindingOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ResourcemanagerCloudIamBindingInput)(nil)).Elem(), &ResourcemanagerCloudIamBinding{})
	pulumi.RegisterInputType(reflect.TypeOf((*ResourcemanagerCloudIamBindingArrayInput)(nil)).Elem(), ResourcemanagerCloudIamBindingArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ResourcemanagerCloudIamBindingMapInput)(nil)).Elem(), ResourcemanagerCloudIamBindingMap{})
	pulumi.RegisterOutputType(ResourcemanagerCloudIamBindingOutput{})
	pulumi.RegisterOutputType(ResourcemanagerCloudIamBindingArrayOutput{})
	pulumi.RegisterOutputType(ResourcemanagerCloudIamBindingMapOutput{})
}
