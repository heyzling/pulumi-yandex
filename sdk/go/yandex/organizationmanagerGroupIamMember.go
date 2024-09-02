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

// Allows creation and management of a single member for a single binding within
// the IAM policy for an existing Yandex Organization Manager Group.
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
//			_, err := yandex.NewOrganizationmanagerGroupIamMember(ctx, "editor", &yandex.OrganizationmanagerGroupIamMemberArgs{
//				GroupId: pulumi.String("some_group_id"),
//				Member:  pulumi.String("userAccount:user_id"),
//				Role:    pulumi.String("editor"),
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
// IAM member imports use space-delimited identifiers; the resource in question, the role, and the account.
//
// This member resource can be imported using the `group_id`, role, and account, e.g.
//
// ```sh
// $ pulumi import yandex:index/organizationmanagerGroupIamMember:OrganizationmanagerGroupIamMember my_project "group_id viewer foo@example.com"
// ```
type OrganizationmanagerGroupIamMember struct {
	pulumi.CustomResourceState

	// ID of the organization to attach a policy to.
	GroupId pulumi.StringOutput `pulumi:"groupId"`
	// The identity that will be granted the privilege that is specified in the `role` field.
	// This field can have one of the following values:
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
	Member pulumi.StringOutput `pulumi:"member"`
	// The role that should be assigned.
	Role       pulumi.StringOutput `pulumi:"role"`
	SleepAfter pulumi.IntPtrOutput `pulumi:"sleepAfter"`
}

// NewOrganizationmanagerGroupIamMember registers a new resource with the given unique name, arguments, and options.
func NewOrganizationmanagerGroupIamMember(ctx *pulumi.Context,
	name string, args *OrganizationmanagerGroupIamMemberArgs, opts ...pulumi.ResourceOption) (*OrganizationmanagerGroupIamMember, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.GroupId == nil {
		return nil, errors.New("invalid value for required argument 'GroupId'")
	}
	if args.Member == nil {
		return nil, errors.New("invalid value for required argument 'Member'")
	}
	if args.Role == nil {
		return nil, errors.New("invalid value for required argument 'Role'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource OrganizationmanagerGroupIamMember
	err := ctx.RegisterResource("yandex:index/organizationmanagerGroupIamMember:OrganizationmanagerGroupIamMember", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOrganizationmanagerGroupIamMember gets an existing OrganizationmanagerGroupIamMember resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOrganizationmanagerGroupIamMember(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OrganizationmanagerGroupIamMemberState, opts ...pulumi.ResourceOption) (*OrganizationmanagerGroupIamMember, error) {
	var resource OrganizationmanagerGroupIamMember
	err := ctx.ReadResource("yandex:index/organizationmanagerGroupIamMember:OrganizationmanagerGroupIamMember", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering OrganizationmanagerGroupIamMember resources.
type organizationmanagerGroupIamMemberState struct {
	// ID of the organization to attach a policy to.
	GroupId *string `pulumi:"groupId"`
	// The identity that will be granted the privilege that is specified in the `role` field.
	// This field can have one of the following values:
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
	Member *string `pulumi:"member"`
	// The role that should be assigned.
	Role       *string `pulumi:"role"`
	SleepAfter *int    `pulumi:"sleepAfter"`
}

type OrganizationmanagerGroupIamMemberState struct {
	// ID of the organization to attach a policy to.
	GroupId pulumi.StringPtrInput
	// The identity that will be granted the privilege that is specified in the `role` field.
	// This field can have one of the following values:
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
	Member pulumi.StringPtrInput
	// The role that should be assigned.
	Role       pulumi.StringPtrInput
	SleepAfter pulumi.IntPtrInput
}

func (OrganizationmanagerGroupIamMemberState) ElementType() reflect.Type {
	return reflect.TypeOf((*organizationmanagerGroupIamMemberState)(nil)).Elem()
}

type organizationmanagerGroupIamMemberArgs struct {
	// ID of the organization to attach a policy to.
	GroupId string `pulumi:"groupId"`
	// The identity that will be granted the privilege that is specified in the `role` field.
	// This field can have one of the following values:
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
	Member string `pulumi:"member"`
	// The role that should be assigned.
	Role       string `pulumi:"role"`
	SleepAfter *int   `pulumi:"sleepAfter"`
}

// The set of arguments for constructing a OrganizationmanagerGroupIamMember resource.
type OrganizationmanagerGroupIamMemberArgs struct {
	// ID of the organization to attach a policy to.
	GroupId pulumi.StringInput
	// The identity that will be granted the privilege that is specified in the `role` field.
	// This field can have one of the following values:
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
	Member pulumi.StringInput
	// The role that should be assigned.
	Role       pulumi.StringInput
	SleepAfter pulumi.IntPtrInput
}

func (OrganizationmanagerGroupIamMemberArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*organizationmanagerGroupIamMemberArgs)(nil)).Elem()
}

type OrganizationmanagerGroupIamMemberInput interface {
	pulumi.Input

	ToOrganizationmanagerGroupIamMemberOutput() OrganizationmanagerGroupIamMemberOutput
	ToOrganizationmanagerGroupIamMemberOutputWithContext(ctx context.Context) OrganizationmanagerGroupIamMemberOutput
}

func (*OrganizationmanagerGroupIamMember) ElementType() reflect.Type {
	return reflect.TypeOf((**OrganizationmanagerGroupIamMember)(nil)).Elem()
}

func (i *OrganizationmanagerGroupIamMember) ToOrganizationmanagerGroupIamMemberOutput() OrganizationmanagerGroupIamMemberOutput {
	return i.ToOrganizationmanagerGroupIamMemberOutputWithContext(context.Background())
}

func (i *OrganizationmanagerGroupIamMember) ToOrganizationmanagerGroupIamMemberOutputWithContext(ctx context.Context) OrganizationmanagerGroupIamMemberOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrganizationmanagerGroupIamMemberOutput)
}

// OrganizationmanagerGroupIamMemberArrayInput is an input type that accepts OrganizationmanagerGroupIamMemberArray and OrganizationmanagerGroupIamMemberArrayOutput values.
// You can construct a concrete instance of `OrganizationmanagerGroupIamMemberArrayInput` via:
//
//	OrganizationmanagerGroupIamMemberArray{ OrganizationmanagerGroupIamMemberArgs{...} }
type OrganizationmanagerGroupIamMemberArrayInput interface {
	pulumi.Input

	ToOrganizationmanagerGroupIamMemberArrayOutput() OrganizationmanagerGroupIamMemberArrayOutput
	ToOrganizationmanagerGroupIamMemberArrayOutputWithContext(context.Context) OrganizationmanagerGroupIamMemberArrayOutput
}

type OrganizationmanagerGroupIamMemberArray []OrganizationmanagerGroupIamMemberInput

func (OrganizationmanagerGroupIamMemberArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OrganizationmanagerGroupIamMember)(nil)).Elem()
}

func (i OrganizationmanagerGroupIamMemberArray) ToOrganizationmanagerGroupIamMemberArrayOutput() OrganizationmanagerGroupIamMemberArrayOutput {
	return i.ToOrganizationmanagerGroupIamMemberArrayOutputWithContext(context.Background())
}

func (i OrganizationmanagerGroupIamMemberArray) ToOrganizationmanagerGroupIamMemberArrayOutputWithContext(ctx context.Context) OrganizationmanagerGroupIamMemberArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrganizationmanagerGroupIamMemberArrayOutput)
}

// OrganizationmanagerGroupIamMemberMapInput is an input type that accepts OrganizationmanagerGroupIamMemberMap and OrganizationmanagerGroupIamMemberMapOutput values.
// You can construct a concrete instance of `OrganizationmanagerGroupIamMemberMapInput` via:
//
//	OrganizationmanagerGroupIamMemberMap{ "key": OrganizationmanagerGroupIamMemberArgs{...} }
type OrganizationmanagerGroupIamMemberMapInput interface {
	pulumi.Input

	ToOrganizationmanagerGroupIamMemberMapOutput() OrganizationmanagerGroupIamMemberMapOutput
	ToOrganizationmanagerGroupIamMemberMapOutputWithContext(context.Context) OrganizationmanagerGroupIamMemberMapOutput
}

type OrganizationmanagerGroupIamMemberMap map[string]OrganizationmanagerGroupIamMemberInput

func (OrganizationmanagerGroupIamMemberMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OrganizationmanagerGroupIamMember)(nil)).Elem()
}

func (i OrganizationmanagerGroupIamMemberMap) ToOrganizationmanagerGroupIamMemberMapOutput() OrganizationmanagerGroupIamMemberMapOutput {
	return i.ToOrganizationmanagerGroupIamMemberMapOutputWithContext(context.Background())
}

func (i OrganizationmanagerGroupIamMemberMap) ToOrganizationmanagerGroupIamMemberMapOutputWithContext(ctx context.Context) OrganizationmanagerGroupIamMemberMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrganizationmanagerGroupIamMemberMapOutput)
}

type OrganizationmanagerGroupIamMemberOutput struct{ *pulumi.OutputState }

func (OrganizationmanagerGroupIamMemberOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OrganizationmanagerGroupIamMember)(nil)).Elem()
}

func (o OrganizationmanagerGroupIamMemberOutput) ToOrganizationmanagerGroupIamMemberOutput() OrganizationmanagerGroupIamMemberOutput {
	return o
}

func (o OrganizationmanagerGroupIamMemberOutput) ToOrganizationmanagerGroupIamMemberOutputWithContext(ctx context.Context) OrganizationmanagerGroupIamMemberOutput {
	return o
}

// ID of the organization to attach a policy to.
func (o OrganizationmanagerGroupIamMemberOutput) GroupId() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerGroupIamMember) pulumi.StringOutput { return v.GroupId }).(pulumi.StringOutput)
}

// The identity that will be granted the privilege that is specified in the `role` field.
// This field can have one of the following values:
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
func (o OrganizationmanagerGroupIamMemberOutput) Member() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerGroupIamMember) pulumi.StringOutput { return v.Member }).(pulumi.StringOutput)
}

// The role that should be assigned.
func (o OrganizationmanagerGroupIamMemberOutput) Role() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerGroupIamMember) pulumi.StringOutput { return v.Role }).(pulumi.StringOutput)
}

func (o OrganizationmanagerGroupIamMemberOutput) SleepAfter() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *OrganizationmanagerGroupIamMember) pulumi.IntPtrOutput { return v.SleepAfter }).(pulumi.IntPtrOutput)
}

type OrganizationmanagerGroupIamMemberArrayOutput struct{ *pulumi.OutputState }

func (OrganizationmanagerGroupIamMemberArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OrganizationmanagerGroupIamMember)(nil)).Elem()
}

func (o OrganizationmanagerGroupIamMemberArrayOutput) ToOrganizationmanagerGroupIamMemberArrayOutput() OrganizationmanagerGroupIamMemberArrayOutput {
	return o
}

func (o OrganizationmanagerGroupIamMemberArrayOutput) ToOrganizationmanagerGroupIamMemberArrayOutputWithContext(ctx context.Context) OrganizationmanagerGroupIamMemberArrayOutput {
	return o
}

func (o OrganizationmanagerGroupIamMemberArrayOutput) Index(i pulumi.IntInput) OrganizationmanagerGroupIamMemberOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *OrganizationmanagerGroupIamMember {
		return vs[0].([]*OrganizationmanagerGroupIamMember)[vs[1].(int)]
	}).(OrganizationmanagerGroupIamMemberOutput)
}

type OrganizationmanagerGroupIamMemberMapOutput struct{ *pulumi.OutputState }

func (OrganizationmanagerGroupIamMemberMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OrganizationmanagerGroupIamMember)(nil)).Elem()
}

func (o OrganizationmanagerGroupIamMemberMapOutput) ToOrganizationmanagerGroupIamMemberMapOutput() OrganizationmanagerGroupIamMemberMapOutput {
	return o
}

func (o OrganizationmanagerGroupIamMemberMapOutput) ToOrganizationmanagerGroupIamMemberMapOutputWithContext(ctx context.Context) OrganizationmanagerGroupIamMemberMapOutput {
	return o
}

func (o OrganizationmanagerGroupIamMemberMapOutput) MapIndex(k pulumi.StringInput) OrganizationmanagerGroupIamMemberOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *OrganizationmanagerGroupIamMember {
		return vs[0].(map[string]*OrganizationmanagerGroupIamMember)[vs[1].(string)]
	}).(OrganizationmanagerGroupIamMemberOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*OrganizationmanagerGroupIamMemberInput)(nil)).Elem(), &OrganizationmanagerGroupIamMember{})
	pulumi.RegisterInputType(reflect.TypeOf((*OrganizationmanagerGroupIamMemberArrayInput)(nil)).Elem(), OrganizationmanagerGroupIamMemberArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*OrganizationmanagerGroupIamMemberMapInput)(nil)).Elem(), OrganizationmanagerGroupIamMemberMap{})
	pulumi.RegisterOutputType(OrganizationmanagerGroupIamMemberOutput{})
	pulumi.RegisterOutputType(OrganizationmanagerGroupIamMemberArrayOutput{})
	pulumi.RegisterOutputType(OrganizationmanagerGroupIamMemberMapOutput{})
}
