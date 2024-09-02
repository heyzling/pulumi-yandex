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
//			_, err := yandex.NewOrganizationmanagerUserSshKey(ctx, "myUserSshKey", &yandex.OrganizationmanagerUserSshKeyArgs{
//				Data:           pulumi.String("ssh_key_data"),
//				OrganizationId: pulumi.String("some_organization_id"),
//				SubjectId:      pulumi.String("some_subject_id"),
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
type OrganizationmanagerUserSshKey struct {
	pulumi.CustomResourceState

	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// Data of the user ssh key.
	Data pulumi.StringOutput `pulumi:"data"`
	// User ssh key will be no longer valid after expiration timestamp.
	ExpiresAt   pulumi.StringPtrOutput `pulumi:"expiresAt"`
	Fingerprint pulumi.StringOutput    `pulumi:"fingerprint"`
	// Name of the user ssh key.
	Name pulumi.StringOutput `pulumi:"name"`
	// Organization that the user ssh key belongs to.
	OrganizationId pulumi.StringOutput `pulumi:"organizationId"`
	// Subject that the user ssh key belongs to.
	SubjectId pulumi.StringOutput `pulumi:"subjectId"`
}

// NewOrganizationmanagerUserSshKey registers a new resource with the given unique name, arguments, and options.
func NewOrganizationmanagerUserSshKey(ctx *pulumi.Context,
	name string, args *OrganizationmanagerUserSshKeyArgs, opts ...pulumi.ResourceOption) (*OrganizationmanagerUserSshKey, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Data == nil {
		return nil, errors.New("invalid value for required argument 'Data'")
	}
	if args.OrganizationId == nil {
		return nil, errors.New("invalid value for required argument 'OrganizationId'")
	}
	if args.SubjectId == nil {
		return nil, errors.New("invalid value for required argument 'SubjectId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource OrganizationmanagerUserSshKey
	err := ctx.RegisterResource("yandex:index/organizationmanagerUserSshKey:OrganizationmanagerUserSshKey", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOrganizationmanagerUserSshKey gets an existing OrganizationmanagerUserSshKey resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOrganizationmanagerUserSshKey(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OrganizationmanagerUserSshKeyState, opts ...pulumi.ResourceOption) (*OrganizationmanagerUserSshKey, error) {
	var resource OrganizationmanagerUserSshKey
	err := ctx.ReadResource("yandex:index/organizationmanagerUserSshKey:OrganizationmanagerUserSshKey", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering OrganizationmanagerUserSshKey resources.
type organizationmanagerUserSshKeyState struct {
	CreatedAt *string `pulumi:"createdAt"`
	// Data of the user ssh key.
	Data *string `pulumi:"data"`
	// User ssh key will be no longer valid after expiration timestamp.
	ExpiresAt   *string `pulumi:"expiresAt"`
	Fingerprint *string `pulumi:"fingerprint"`
	// Name of the user ssh key.
	Name *string `pulumi:"name"`
	// Organization that the user ssh key belongs to.
	OrganizationId *string `pulumi:"organizationId"`
	// Subject that the user ssh key belongs to.
	SubjectId *string `pulumi:"subjectId"`
}

type OrganizationmanagerUserSshKeyState struct {
	CreatedAt pulumi.StringPtrInput
	// Data of the user ssh key.
	Data pulumi.StringPtrInput
	// User ssh key will be no longer valid after expiration timestamp.
	ExpiresAt   pulumi.StringPtrInput
	Fingerprint pulumi.StringPtrInput
	// Name of the user ssh key.
	Name pulumi.StringPtrInput
	// Organization that the user ssh key belongs to.
	OrganizationId pulumi.StringPtrInput
	// Subject that the user ssh key belongs to.
	SubjectId pulumi.StringPtrInput
}

func (OrganizationmanagerUserSshKeyState) ElementType() reflect.Type {
	return reflect.TypeOf((*organizationmanagerUserSshKeyState)(nil)).Elem()
}

type organizationmanagerUserSshKeyArgs struct {
	// Data of the user ssh key.
	Data string `pulumi:"data"`
	// User ssh key will be no longer valid after expiration timestamp.
	ExpiresAt *string `pulumi:"expiresAt"`
	// Name of the user ssh key.
	Name *string `pulumi:"name"`
	// Organization that the user ssh key belongs to.
	OrganizationId string `pulumi:"organizationId"`
	// Subject that the user ssh key belongs to.
	SubjectId string `pulumi:"subjectId"`
}

// The set of arguments for constructing a OrganizationmanagerUserSshKey resource.
type OrganizationmanagerUserSshKeyArgs struct {
	// Data of the user ssh key.
	Data pulumi.StringInput
	// User ssh key will be no longer valid after expiration timestamp.
	ExpiresAt pulumi.StringPtrInput
	// Name of the user ssh key.
	Name pulumi.StringPtrInput
	// Organization that the user ssh key belongs to.
	OrganizationId pulumi.StringInput
	// Subject that the user ssh key belongs to.
	SubjectId pulumi.StringInput
}

func (OrganizationmanagerUserSshKeyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*organizationmanagerUserSshKeyArgs)(nil)).Elem()
}

type OrganizationmanagerUserSshKeyInput interface {
	pulumi.Input

	ToOrganizationmanagerUserSshKeyOutput() OrganizationmanagerUserSshKeyOutput
	ToOrganizationmanagerUserSshKeyOutputWithContext(ctx context.Context) OrganizationmanagerUserSshKeyOutput
}

func (*OrganizationmanagerUserSshKey) ElementType() reflect.Type {
	return reflect.TypeOf((**OrganizationmanagerUserSshKey)(nil)).Elem()
}

func (i *OrganizationmanagerUserSshKey) ToOrganizationmanagerUserSshKeyOutput() OrganizationmanagerUserSshKeyOutput {
	return i.ToOrganizationmanagerUserSshKeyOutputWithContext(context.Background())
}

func (i *OrganizationmanagerUserSshKey) ToOrganizationmanagerUserSshKeyOutputWithContext(ctx context.Context) OrganizationmanagerUserSshKeyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrganizationmanagerUserSshKeyOutput)
}

// OrganizationmanagerUserSshKeyArrayInput is an input type that accepts OrganizationmanagerUserSshKeyArray and OrganizationmanagerUserSshKeyArrayOutput values.
// You can construct a concrete instance of `OrganizationmanagerUserSshKeyArrayInput` via:
//
//	OrganizationmanagerUserSshKeyArray{ OrganizationmanagerUserSshKeyArgs{...} }
type OrganizationmanagerUserSshKeyArrayInput interface {
	pulumi.Input

	ToOrganizationmanagerUserSshKeyArrayOutput() OrganizationmanagerUserSshKeyArrayOutput
	ToOrganizationmanagerUserSshKeyArrayOutputWithContext(context.Context) OrganizationmanagerUserSshKeyArrayOutput
}

type OrganizationmanagerUserSshKeyArray []OrganizationmanagerUserSshKeyInput

func (OrganizationmanagerUserSshKeyArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OrganizationmanagerUserSshKey)(nil)).Elem()
}

func (i OrganizationmanagerUserSshKeyArray) ToOrganizationmanagerUserSshKeyArrayOutput() OrganizationmanagerUserSshKeyArrayOutput {
	return i.ToOrganizationmanagerUserSshKeyArrayOutputWithContext(context.Background())
}

func (i OrganizationmanagerUserSshKeyArray) ToOrganizationmanagerUserSshKeyArrayOutputWithContext(ctx context.Context) OrganizationmanagerUserSshKeyArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrganizationmanagerUserSshKeyArrayOutput)
}

// OrganizationmanagerUserSshKeyMapInput is an input type that accepts OrganizationmanagerUserSshKeyMap and OrganizationmanagerUserSshKeyMapOutput values.
// You can construct a concrete instance of `OrganizationmanagerUserSshKeyMapInput` via:
//
//	OrganizationmanagerUserSshKeyMap{ "key": OrganizationmanagerUserSshKeyArgs{...} }
type OrganizationmanagerUserSshKeyMapInput interface {
	pulumi.Input

	ToOrganizationmanagerUserSshKeyMapOutput() OrganizationmanagerUserSshKeyMapOutput
	ToOrganizationmanagerUserSshKeyMapOutputWithContext(context.Context) OrganizationmanagerUserSshKeyMapOutput
}

type OrganizationmanagerUserSshKeyMap map[string]OrganizationmanagerUserSshKeyInput

func (OrganizationmanagerUserSshKeyMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OrganizationmanagerUserSshKey)(nil)).Elem()
}

func (i OrganizationmanagerUserSshKeyMap) ToOrganizationmanagerUserSshKeyMapOutput() OrganizationmanagerUserSshKeyMapOutput {
	return i.ToOrganizationmanagerUserSshKeyMapOutputWithContext(context.Background())
}

func (i OrganizationmanagerUserSshKeyMap) ToOrganizationmanagerUserSshKeyMapOutputWithContext(ctx context.Context) OrganizationmanagerUserSshKeyMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrganizationmanagerUserSshKeyMapOutput)
}

type OrganizationmanagerUserSshKeyOutput struct{ *pulumi.OutputState }

func (OrganizationmanagerUserSshKeyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OrganizationmanagerUserSshKey)(nil)).Elem()
}

func (o OrganizationmanagerUserSshKeyOutput) ToOrganizationmanagerUserSshKeyOutput() OrganizationmanagerUserSshKeyOutput {
	return o
}

func (o OrganizationmanagerUserSshKeyOutput) ToOrganizationmanagerUserSshKeyOutputWithContext(ctx context.Context) OrganizationmanagerUserSshKeyOutput {
	return o
}

func (o OrganizationmanagerUserSshKeyOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerUserSshKey) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// Data of the user ssh key.
func (o OrganizationmanagerUserSshKeyOutput) Data() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerUserSshKey) pulumi.StringOutput { return v.Data }).(pulumi.StringOutput)
}

// User ssh key will be no longer valid after expiration timestamp.
func (o OrganizationmanagerUserSshKeyOutput) ExpiresAt() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *OrganizationmanagerUserSshKey) pulumi.StringPtrOutput { return v.ExpiresAt }).(pulumi.StringPtrOutput)
}

func (o OrganizationmanagerUserSshKeyOutput) Fingerprint() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerUserSshKey) pulumi.StringOutput { return v.Fingerprint }).(pulumi.StringOutput)
}

// Name of the user ssh key.
func (o OrganizationmanagerUserSshKeyOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerUserSshKey) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Organization that the user ssh key belongs to.
func (o OrganizationmanagerUserSshKeyOutput) OrganizationId() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerUserSshKey) pulumi.StringOutput { return v.OrganizationId }).(pulumi.StringOutput)
}

// Subject that the user ssh key belongs to.
func (o OrganizationmanagerUserSshKeyOutput) SubjectId() pulumi.StringOutput {
	return o.ApplyT(func(v *OrganizationmanagerUserSshKey) pulumi.StringOutput { return v.SubjectId }).(pulumi.StringOutput)
}

type OrganizationmanagerUserSshKeyArrayOutput struct{ *pulumi.OutputState }

func (OrganizationmanagerUserSshKeyArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OrganizationmanagerUserSshKey)(nil)).Elem()
}

func (o OrganizationmanagerUserSshKeyArrayOutput) ToOrganizationmanagerUserSshKeyArrayOutput() OrganizationmanagerUserSshKeyArrayOutput {
	return o
}

func (o OrganizationmanagerUserSshKeyArrayOutput) ToOrganizationmanagerUserSshKeyArrayOutputWithContext(ctx context.Context) OrganizationmanagerUserSshKeyArrayOutput {
	return o
}

func (o OrganizationmanagerUserSshKeyArrayOutput) Index(i pulumi.IntInput) OrganizationmanagerUserSshKeyOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *OrganizationmanagerUserSshKey {
		return vs[0].([]*OrganizationmanagerUserSshKey)[vs[1].(int)]
	}).(OrganizationmanagerUserSshKeyOutput)
}

type OrganizationmanagerUserSshKeyMapOutput struct{ *pulumi.OutputState }

func (OrganizationmanagerUserSshKeyMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OrganizationmanagerUserSshKey)(nil)).Elem()
}

func (o OrganizationmanagerUserSshKeyMapOutput) ToOrganizationmanagerUserSshKeyMapOutput() OrganizationmanagerUserSshKeyMapOutput {
	return o
}

func (o OrganizationmanagerUserSshKeyMapOutput) ToOrganizationmanagerUserSshKeyMapOutputWithContext(ctx context.Context) OrganizationmanagerUserSshKeyMapOutput {
	return o
}

func (o OrganizationmanagerUserSshKeyMapOutput) MapIndex(k pulumi.StringInput) OrganizationmanagerUserSshKeyOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *OrganizationmanagerUserSshKey {
		return vs[0].(map[string]*OrganizationmanagerUserSshKey)[vs[1].(string)]
	}).(OrganizationmanagerUserSshKeyOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*OrganizationmanagerUserSshKeyInput)(nil)).Elem(), &OrganizationmanagerUserSshKey{})
	pulumi.RegisterInputType(reflect.TypeOf((*OrganizationmanagerUserSshKeyArrayInput)(nil)).Elem(), OrganizationmanagerUserSshKeyArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*OrganizationmanagerUserSshKeyMapInput)(nil)).Elem(), OrganizationmanagerUserSshKeyMap{})
	pulumi.RegisterOutputType(OrganizationmanagerUserSshKeyOutput{})
	pulumi.RegisterOutputType(OrganizationmanagerUserSshKeyArrayOutput{})
	pulumi.RegisterOutputType(OrganizationmanagerUserSshKeyMapOutput{})
}
