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

// Yandex Cloud Lockbox secret version resource. For more information, see
// [the official documentation](https://cloud.yandex.com/en/docs/lockbox/).
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
//			mySecret, err := yandex.NewLockboxSecret(ctx, "mySecret", nil)
//			if err != nil {
//				return err
//			}
//			_, err = yandex.NewLockboxSecretVersion(ctx, "myVersion", &yandex.LockboxSecretVersionArgs{
//				SecretId: mySecret.ID(),
//				Entries: yandex.LockboxSecretVersionEntryArray{
//					&yandex.LockboxSecretVersionEntryArgs{
//						Key:       pulumi.String("key1"),
//						TextValue: pulumi.String("value1"),
//					},
//					&yandex.LockboxSecretVersionEntryArgs{
//						Key: pulumi.String("k2"),
//						Command: &yandex.LockboxSecretVersionEntryCommandArgs{
//							Path: pulumi.String("my_secret_generator.sh"),
//						},
//					},
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
type LockboxSecretVersion struct {
	pulumi.CustomResourceState

	// The Yandex Cloud Lockbox secret version description.
	//
	// The `entries` block contains:
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// List of entries in the Yandex Cloud Lockbox secret version.
	Entries LockboxSecretVersionEntryArrayOutput `pulumi:"entries"`
	// The Yandex Cloud Lockbox secret ID where to add the version.
	SecretId pulumi.StringOutput `pulumi:"secretId"`
}

// NewLockboxSecretVersion registers a new resource with the given unique name, arguments, and options.
func NewLockboxSecretVersion(ctx *pulumi.Context,
	name string, args *LockboxSecretVersionArgs, opts ...pulumi.ResourceOption) (*LockboxSecretVersion, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Entries == nil {
		return nil, errors.New("invalid value for required argument 'Entries'")
	}
	if args.SecretId == nil {
		return nil, errors.New("invalid value for required argument 'SecretId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource LockboxSecretVersion
	err := ctx.RegisterResource("yandex:index/lockboxSecretVersion:LockboxSecretVersion", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLockboxSecretVersion gets an existing LockboxSecretVersion resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLockboxSecretVersion(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LockboxSecretVersionState, opts ...pulumi.ResourceOption) (*LockboxSecretVersion, error) {
	var resource LockboxSecretVersion
	err := ctx.ReadResource("yandex:index/lockboxSecretVersion:LockboxSecretVersion", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LockboxSecretVersion resources.
type lockboxSecretVersionState struct {
	// The Yandex Cloud Lockbox secret version description.
	//
	// The `entries` block contains:
	Description *string `pulumi:"description"`
	// List of entries in the Yandex Cloud Lockbox secret version.
	Entries []LockboxSecretVersionEntry `pulumi:"entries"`
	// The Yandex Cloud Lockbox secret ID where to add the version.
	SecretId *string `pulumi:"secretId"`
}

type LockboxSecretVersionState struct {
	// The Yandex Cloud Lockbox secret version description.
	//
	// The `entries` block contains:
	Description pulumi.StringPtrInput
	// List of entries in the Yandex Cloud Lockbox secret version.
	Entries LockboxSecretVersionEntryArrayInput
	// The Yandex Cloud Lockbox secret ID where to add the version.
	SecretId pulumi.StringPtrInput
}

func (LockboxSecretVersionState) ElementType() reflect.Type {
	return reflect.TypeOf((*lockboxSecretVersionState)(nil)).Elem()
}

type lockboxSecretVersionArgs struct {
	// The Yandex Cloud Lockbox secret version description.
	//
	// The `entries` block contains:
	Description *string `pulumi:"description"`
	// List of entries in the Yandex Cloud Lockbox secret version.
	Entries []LockboxSecretVersionEntry `pulumi:"entries"`
	// The Yandex Cloud Lockbox secret ID where to add the version.
	SecretId string `pulumi:"secretId"`
}

// The set of arguments for constructing a LockboxSecretVersion resource.
type LockboxSecretVersionArgs struct {
	// The Yandex Cloud Lockbox secret version description.
	//
	// The `entries` block contains:
	Description pulumi.StringPtrInput
	// List of entries in the Yandex Cloud Lockbox secret version.
	Entries LockboxSecretVersionEntryArrayInput
	// The Yandex Cloud Lockbox secret ID where to add the version.
	SecretId pulumi.StringInput
}

func (LockboxSecretVersionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*lockboxSecretVersionArgs)(nil)).Elem()
}

type LockboxSecretVersionInput interface {
	pulumi.Input

	ToLockboxSecretVersionOutput() LockboxSecretVersionOutput
	ToLockboxSecretVersionOutputWithContext(ctx context.Context) LockboxSecretVersionOutput
}

func (*LockboxSecretVersion) ElementType() reflect.Type {
	return reflect.TypeOf((**LockboxSecretVersion)(nil)).Elem()
}

func (i *LockboxSecretVersion) ToLockboxSecretVersionOutput() LockboxSecretVersionOutput {
	return i.ToLockboxSecretVersionOutputWithContext(context.Background())
}

func (i *LockboxSecretVersion) ToLockboxSecretVersionOutputWithContext(ctx context.Context) LockboxSecretVersionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LockboxSecretVersionOutput)
}

// LockboxSecretVersionArrayInput is an input type that accepts LockboxSecretVersionArray and LockboxSecretVersionArrayOutput values.
// You can construct a concrete instance of `LockboxSecretVersionArrayInput` via:
//
//	LockboxSecretVersionArray{ LockboxSecretVersionArgs{...} }
type LockboxSecretVersionArrayInput interface {
	pulumi.Input

	ToLockboxSecretVersionArrayOutput() LockboxSecretVersionArrayOutput
	ToLockboxSecretVersionArrayOutputWithContext(context.Context) LockboxSecretVersionArrayOutput
}

type LockboxSecretVersionArray []LockboxSecretVersionInput

func (LockboxSecretVersionArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*LockboxSecretVersion)(nil)).Elem()
}

func (i LockboxSecretVersionArray) ToLockboxSecretVersionArrayOutput() LockboxSecretVersionArrayOutput {
	return i.ToLockboxSecretVersionArrayOutputWithContext(context.Background())
}

func (i LockboxSecretVersionArray) ToLockboxSecretVersionArrayOutputWithContext(ctx context.Context) LockboxSecretVersionArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LockboxSecretVersionArrayOutput)
}

// LockboxSecretVersionMapInput is an input type that accepts LockboxSecretVersionMap and LockboxSecretVersionMapOutput values.
// You can construct a concrete instance of `LockboxSecretVersionMapInput` via:
//
//	LockboxSecretVersionMap{ "key": LockboxSecretVersionArgs{...} }
type LockboxSecretVersionMapInput interface {
	pulumi.Input

	ToLockboxSecretVersionMapOutput() LockboxSecretVersionMapOutput
	ToLockboxSecretVersionMapOutputWithContext(context.Context) LockboxSecretVersionMapOutput
}

type LockboxSecretVersionMap map[string]LockboxSecretVersionInput

func (LockboxSecretVersionMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*LockboxSecretVersion)(nil)).Elem()
}

func (i LockboxSecretVersionMap) ToLockboxSecretVersionMapOutput() LockboxSecretVersionMapOutput {
	return i.ToLockboxSecretVersionMapOutputWithContext(context.Background())
}

func (i LockboxSecretVersionMap) ToLockboxSecretVersionMapOutputWithContext(ctx context.Context) LockboxSecretVersionMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LockboxSecretVersionMapOutput)
}

type LockboxSecretVersionOutput struct{ *pulumi.OutputState }

func (LockboxSecretVersionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**LockboxSecretVersion)(nil)).Elem()
}

func (o LockboxSecretVersionOutput) ToLockboxSecretVersionOutput() LockboxSecretVersionOutput {
	return o
}

func (o LockboxSecretVersionOutput) ToLockboxSecretVersionOutputWithContext(ctx context.Context) LockboxSecretVersionOutput {
	return o
}

// The Yandex Cloud Lockbox secret version description.
//
// The `entries` block contains:
func (o LockboxSecretVersionOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *LockboxSecretVersion) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// List of entries in the Yandex Cloud Lockbox secret version.
func (o LockboxSecretVersionOutput) Entries() LockboxSecretVersionEntryArrayOutput {
	return o.ApplyT(func(v *LockboxSecretVersion) LockboxSecretVersionEntryArrayOutput { return v.Entries }).(LockboxSecretVersionEntryArrayOutput)
}

// The Yandex Cloud Lockbox secret ID where to add the version.
func (o LockboxSecretVersionOutput) SecretId() pulumi.StringOutput {
	return o.ApplyT(func(v *LockboxSecretVersion) pulumi.StringOutput { return v.SecretId }).(pulumi.StringOutput)
}

type LockboxSecretVersionArrayOutput struct{ *pulumi.OutputState }

func (LockboxSecretVersionArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*LockboxSecretVersion)(nil)).Elem()
}

func (o LockboxSecretVersionArrayOutput) ToLockboxSecretVersionArrayOutput() LockboxSecretVersionArrayOutput {
	return o
}

func (o LockboxSecretVersionArrayOutput) ToLockboxSecretVersionArrayOutputWithContext(ctx context.Context) LockboxSecretVersionArrayOutput {
	return o
}

func (o LockboxSecretVersionArrayOutput) Index(i pulumi.IntInput) LockboxSecretVersionOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *LockboxSecretVersion {
		return vs[0].([]*LockboxSecretVersion)[vs[1].(int)]
	}).(LockboxSecretVersionOutput)
}

type LockboxSecretVersionMapOutput struct{ *pulumi.OutputState }

func (LockboxSecretVersionMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*LockboxSecretVersion)(nil)).Elem()
}

func (o LockboxSecretVersionMapOutput) ToLockboxSecretVersionMapOutput() LockboxSecretVersionMapOutput {
	return o
}

func (o LockboxSecretVersionMapOutput) ToLockboxSecretVersionMapOutputWithContext(ctx context.Context) LockboxSecretVersionMapOutput {
	return o
}

func (o LockboxSecretVersionMapOutput) MapIndex(k pulumi.StringInput) LockboxSecretVersionOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *LockboxSecretVersion {
		return vs[0].(map[string]*LockboxSecretVersion)[vs[1].(string)]
	}).(LockboxSecretVersionOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*LockboxSecretVersionInput)(nil)).Elem(), &LockboxSecretVersion{})
	pulumi.RegisterInputType(reflect.TypeOf((*LockboxSecretVersionArrayInput)(nil)).Elem(), LockboxSecretVersionArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*LockboxSecretVersionMapInput)(nil)).Elem(), LockboxSecretVersionMap{})
	pulumi.RegisterOutputType(LockboxSecretVersionOutput{})
	pulumi.RegisterOutputType(LockboxSecretVersionArrayOutput{})
	pulumi.RegisterOutputType(LockboxSecretVersionMapOutput{})
}
