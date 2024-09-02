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

// ## yandex\_container\_repository\_iam\_binding
//
// Allows creation and management of a single binding within IAM policy for
// an existing Yandex Container Repository.
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
//			_, err := yandex.NewContainerRegistry(ctx, "your-registry", &yandex.ContainerRegistryArgs{
//				FolderId: pulumi.String("your-folder-id"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = yandex.NewContainerRepository(ctx, "repo-1", nil)
//			if err != nil {
//				return err
//			}
//			_, err = yandex.NewContainerRepositoryIamBinding(ctx, "puller", &yandex.ContainerRepositoryIamBindingArgs{
//				RepositoryId: repo_1.ID(),
//				Role:         pulumi.String("container-registry.images.puller"),
//				Members: pulumi.StringArray{
//					pulumi.String("system:allUsers"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			repo_2, err := yandex.LookupContainerRepository(ctx, &yandex.LookupContainerRepositoryArgs{
//				Name: pulumi.StringRef("some_repository_name"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			_, err = yandex.NewContainerRepositoryIamBinding(ctx, "pusher", &yandex.ContainerRepositoryIamBindingArgs{
//				RepositoryId: pulumi.String(repo_2.Id),
//				Role:         pulumi.String("container-registry.images.pusher"),
//				Members: pulumi.StringArray{
//					pulumi.String("serviceAccount:your-service-account-id"),
//				},
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
// These bindings can be imported using the `repository_id` and role, e.g.
//
// ```sh
// $ pulumi import yandex:index/containerRepositoryIamBinding:ContainerRepositoryIamBinding puller "repository_id container-registry.images.puller"
// ```
type ContainerRepositoryIamBinding struct {
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
	// The [Yandex Container Repository](https://cloud.yandex.com/docs/container-registry/concepts/repository) ID to apply a binding to.
	RepositoryId pulumi.StringOutput `pulumi:"repositoryId"`
	// The role that should be applied. See [roles](https://cloud.yandex.com/docs/container-registry/security/).
	Role       pulumi.StringOutput `pulumi:"role"`
	SleepAfter pulumi.IntPtrOutput `pulumi:"sleepAfter"`
}

// NewContainerRepositoryIamBinding registers a new resource with the given unique name, arguments, and options.
func NewContainerRepositoryIamBinding(ctx *pulumi.Context,
	name string, args *ContainerRepositoryIamBindingArgs, opts ...pulumi.ResourceOption) (*ContainerRepositoryIamBinding, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Members == nil {
		return nil, errors.New("invalid value for required argument 'Members'")
	}
	if args.RepositoryId == nil {
		return nil, errors.New("invalid value for required argument 'RepositoryId'")
	}
	if args.Role == nil {
		return nil, errors.New("invalid value for required argument 'Role'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ContainerRepositoryIamBinding
	err := ctx.RegisterResource("yandex:index/containerRepositoryIamBinding:ContainerRepositoryIamBinding", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetContainerRepositoryIamBinding gets an existing ContainerRepositoryIamBinding resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetContainerRepositoryIamBinding(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ContainerRepositoryIamBindingState, opts ...pulumi.ResourceOption) (*ContainerRepositoryIamBinding, error) {
	var resource ContainerRepositoryIamBinding
	err := ctx.ReadResource("yandex:index/containerRepositoryIamBinding:ContainerRepositoryIamBinding", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ContainerRepositoryIamBinding resources.
type containerRepositoryIamBindingState struct {
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
	// The [Yandex Container Repository](https://cloud.yandex.com/docs/container-registry/concepts/repository) ID to apply a binding to.
	RepositoryId *string `pulumi:"repositoryId"`
	// The role that should be applied. See [roles](https://cloud.yandex.com/docs/container-registry/security/).
	Role       *string `pulumi:"role"`
	SleepAfter *int    `pulumi:"sleepAfter"`
}

type ContainerRepositoryIamBindingState struct {
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
	// The [Yandex Container Repository](https://cloud.yandex.com/docs/container-registry/concepts/repository) ID to apply a binding to.
	RepositoryId pulumi.StringPtrInput
	// The role that should be applied. See [roles](https://cloud.yandex.com/docs/container-registry/security/).
	Role       pulumi.StringPtrInput
	SleepAfter pulumi.IntPtrInput
}

func (ContainerRepositoryIamBindingState) ElementType() reflect.Type {
	return reflect.TypeOf((*containerRepositoryIamBindingState)(nil)).Elem()
}

type containerRepositoryIamBindingArgs struct {
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
	// The [Yandex Container Repository](https://cloud.yandex.com/docs/container-registry/concepts/repository) ID to apply a binding to.
	RepositoryId string `pulumi:"repositoryId"`
	// The role that should be applied. See [roles](https://cloud.yandex.com/docs/container-registry/security/).
	Role       string `pulumi:"role"`
	SleepAfter *int   `pulumi:"sleepAfter"`
}

// The set of arguments for constructing a ContainerRepositoryIamBinding resource.
type ContainerRepositoryIamBindingArgs struct {
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
	// The [Yandex Container Repository](https://cloud.yandex.com/docs/container-registry/concepts/repository) ID to apply a binding to.
	RepositoryId pulumi.StringInput
	// The role that should be applied. See [roles](https://cloud.yandex.com/docs/container-registry/security/).
	Role       pulumi.StringInput
	SleepAfter pulumi.IntPtrInput
}

func (ContainerRepositoryIamBindingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*containerRepositoryIamBindingArgs)(nil)).Elem()
}

type ContainerRepositoryIamBindingInput interface {
	pulumi.Input

	ToContainerRepositoryIamBindingOutput() ContainerRepositoryIamBindingOutput
	ToContainerRepositoryIamBindingOutputWithContext(ctx context.Context) ContainerRepositoryIamBindingOutput
}

func (*ContainerRepositoryIamBinding) ElementType() reflect.Type {
	return reflect.TypeOf((**ContainerRepositoryIamBinding)(nil)).Elem()
}

func (i *ContainerRepositoryIamBinding) ToContainerRepositoryIamBindingOutput() ContainerRepositoryIamBindingOutput {
	return i.ToContainerRepositoryIamBindingOutputWithContext(context.Background())
}

func (i *ContainerRepositoryIamBinding) ToContainerRepositoryIamBindingOutputWithContext(ctx context.Context) ContainerRepositoryIamBindingOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerRepositoryIamBindingOutput)
}

// ContainerRepositoryIamBindingArrayInput is an input type that accepts ContainerRepositoryIamBindingArray and ContainerRepositoryIamBindingArrayOutput values.
// You can construct a concrete instance of `ContainerRepositoryIamBindingArrayInput` via:
//
//	ContainerRepositoryIamBindingArray{ ContainerRepositoryIamBindingArgs{...} }
type ContainerRepositoryIamBindingArrayInput interface {
	pulumi.Input

	ToContainerRepositoryIamBindingArrayOutput() ContainerRepositoryIamBindingArrayOutput
	ToContainerRepositoryIamBindingArrayOutputWithContext(context.Context) ContainerRepositoryIamBindingArrayOutput
}

type ContainerRepositoryIamBindingArray []ContainerRepositoryIamBindingInput

func (ContainerRepositoryIamBindingArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ContainerRepositoryIamBinding)(nil)).Elem()
}

func (i ContainerRepositoryIamBindingArray) ToContainerRepositoryIamBindingArrayOutput() ContainerRepositoryIamBindingArrayOutput {
	return i.ToContainerRepositoryIamBindingArrayOutputWithContext(context.Background())
}

func (i ContainerRepositoryIamBindingArray) ToContainerRepositoryIamBindingArrayOutputWithContext(ctx context.Context) ContainerRepositoryIamBindingArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerRepositoryIamBindingArrayOutput)
}

// ContainerRepositoryIamBindingMapInput is an input type that accepts ContainerRepositoryIamBindingMap and ContainerRepositoryIamBindingMapOutput values.
// You can construct a concrete instance of `ContainerRepositoryIamBindingMapInput` via:
//
//	ContainerRepositoryIamBindingMap{ "key": ContainerRepositoryIamBindingArgs{...} }
type ContainerRepositoryIamBindingMapInput interface {
	pulumi.Input

	ToContainerRepositoryIamBindingMapOutput() ContainerRepositoryIamBindingMapOutput
	ToContainerRepositoryIamBindingMapOutputWithContext(context.Context) ContainerRepositoryIamBindingMapOutput
}

type ContainerRepositoryIamBindingMap map[string]ContainerRepositoryIamBindingInput

func (ContainerRepositoryIamBindingMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ContainerRepositoryIamBinding)(nil)).Elem()
}

func (i ContainerRepositoryIamBindingMap) ToContainerRepositoryIamBindingMapOutput() ContainerRepositoryIamBindingMapOutput {
	return i.ToContainerRepositoryIamBindingMapOutputWithContext(context.Background())
}

func (i ContainerRepositoryIamBindingMap) ToContainerRepositoryIamBindingMapOutputWithContext(ctx context.Context) ContainerRepositoryIamBindingMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContainerRepositoryIamBindingMapOutput)
}

type ContainerRepositoryIamBindingOutput struct{ *pulumi.OutputState }

func (ContainerRepositoryIamBindingOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ContainerRepositoryIamBinding)(nil)).Elem()
}

func (o ContainerRepositoryIamBindingOutput) ToContainerRepositoryIamBindingOutput() ContainerRepositoryIamBindingOutput {
	return o
}

func (o ContainerRepositoryIamBindingOutput) ToContainerRepositoryIamBindingOutputWithContext(ctx context.Context) ContainerRepositoryIamBindingOutput {
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
func (o ContainerRepositoryIamBindingOutput) Members() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *ContainerRepositoryIamBinding) pulumi.StringArrayOutput { return v.Members }).(pulumi.StringArrayOutput)
}

// The [Yandex Container Repository](https://cloud.yandex.com/docs/container-registry/concepts/repository) ID to apply a binding to.
func (o ContainerRepositoryIamBindingOutput) RepositoryId() pulumi.StringOutput {
	return o.ApplyT(func(v *ContainerRepositoryIamBinding) pulumi.StringOutput { return v.RepositoryId }).(pulumi.StringOutput)
}

// The role that should be applied. See [roles](https://cloud.yandex.com/docs/container-registry/security/).
func (o ContainerRepositoryIamBindingOutput) Role() pulumi.StringOutput {
	return o.ApplyT(func(v *ContainerRepositoryIamBinding) pulumi.StringOutput { return v.Role }).(pulumi.StringOutput)
}

func (o ContainerRepositoryIamBindingOutput) SleepAfter() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ContainerRepositoryIamBinding) pulumi.IntPtrOutput { return v.SleepAfter }).(pulumi.IntPtrOutput)
}

type ContainerRepositoryIamBindingArrayOutput struct{ *pulumi.OutputState }

func (ContainerRepositoryIamBindingArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ContainerRepositoryIamBinding)(nil)).Elem()
}

func (o ContainerRepositoryIamBindingArrayOutput) ToContainerRepositoryIamBindingArrayOutput() ContainerRepositoryIamBindingArrayOutput {
	return o
}

func (o ContainerRepositoryIamBindingArrayOutput) ToContainerRepositoryIamBindingArrayOutputWithContext(ctx context.Context) ContainerRepositoryIamBindingArrayOutput {
	return o
}

func (o ContainerRepositoryIamBindingArrayOutput) Index(i pulumi.IntInput) ContainerRepositoryIamBindingOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ContainerRepositoryIamBinding {
		return vs[0].([]*ContainerRepositoryIamBinding)[vs[1].(int)]
	}).(ContainerRepositoryIamBindingOutput)
}

type ContainerRepositoryIamBindingMapOutput struct{ *pulumi.OutputState }

func (ContainerRepositoryIamBindingMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ContainerRepositoryIamBinding)(nil)).Elem()
}

func (o ContainerRepositoryIamBindingMapOutput) ToContainerRepositoryIamBindingMapOutput() ContainerRepositoryIamBindingMapOutput {
	return o
}

func (o ContainerRepositoryIamBindingMapOutput) ToContainerRepositoryIamBindingMapOutputWithContext(ctx context.Context) ContainerRepositoryIamBindingMapOutput {
	return o
}

func (o ContainerRepositoryIamBindingMapOutput) MapIndex(k pulumi.StringInput) ContainerRepositoryIamBindingOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ContainerRepositoryIamBinding {
		return vs[0].(map[string]*ContainerRepositoryIamBinding)[vs[1].(string)]
	}).(ContainerRepositoryIamBindingOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ContainerRepositoryIamBindingInput)(nil)).Elem(), &ContainerRepositoryIamBinding{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContainerRepositoryIamBindingArrayInput)(nil)).Elem(), ContainerRepositoryIamBindingArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContainerRepositoryIamBindingMapInput)(nil)).Elem(), ContainerRepositoryIamBindingMap{})
	pulumi.RegisterOutputType(ContainerRepositoryIamBindingOutput{})
	pulumi.RegisterOutputType(ContainerRepositoryIamBindingArrayOutput{})
	pulumi.RegisterOutputType(ContainerRepositoryIamBindingMapOutput{})
}
