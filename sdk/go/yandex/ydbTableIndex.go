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

type YdbTableIndex struct {
	pulumi.CustomResourceState

	Columns          pulumi.StringArrayOutput `pulumi:"columns"`
	ConnectionString pulumi.StringOutput      `pulumi:"connectionString"`
	Covers           pulumi.StringArrayOutput `pulumi:"covers"`
	Name             pulumi.StringOutput      `pulumi:"name"`
	TableId          pulumi.StringOutput      `pulumi:"tableId"`
	TablePath        pulumi.StringOutput      `pulumi:"tablePath"`
	Type             pulumi.StringOutput      `pulumi:"type"`
}

// NewYdbTableIndex registers a new resource with the given unique name, arguments, and options.
func NewYdbTableIndex(ctx *pulumi.Context,
	name string, args *YdbTableIndexArgs, opts ...pulumi.ResourceOption) (*YdbTableIndex, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Columns == nil {
		return nil, errors.New("invalid value for required argument 'Columns'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource YdbTableIndex
	err := ctx.RegisterResource("yandex:index/ydbTableIndex:YdbTableIndex", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetYdbTableIndex gets an existing YdbTableIndex resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetYdbTableIndex(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *YdbTableIndexState, opts ...pulumi.ResourceOption) (*YdbTableIndex, error) {
	var resource YdbTableIndex
	err := ctx.ReadResource("yandex:index/ydbTableIndex:YdbTableIndex", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering YdbTableIndex resources.
type ydbTableIndexState struct {
	Columns          []string `pulumi:"columns"`
	ConnectionString *string  `pulumi:"connectionString"`
	Covers           []string `pulumi:"covers"`
	Name             *string  `pulumi:"name"`
	TableId          *string  `pulumi:"tableId"`
	TablePath        *string  `pulumi:"tablePath"`
	Type             *string  `pulumi:"type"`
}

type YdbTableIndexState struct {
	Columns          pulumi.StringArrayInput
	ConnectionString pulumi.StringPtrInput
	Covers           pulumi.StringArrayInput
	Name             pulumi.StringPtrInput
	TableId          pulumi.StringPtrInput
	TablePath        pulumi.StringPtrInput
	Type             pulumi.StringPtrInput
}

func (YdbTableIndexState) ElementType() reflect.Type {
	return reflect.TypeOf((*ydbTableIndexState)(nil)).Elem()
}

type ydbTableIndexArgs struct {
	Columns          []string `pulumi:"columns"`
	ConnectionString *string  `pulumi:"connectionString"`
	Covers           []string `pulumi:"covers"`
	Name             *string  `pulumi:"name"`
	TableId          *string  `pulumi:"tableId"`
	TablePath        *string  `pulumi:"tablePath"`
	Type             string   `pulumi:"type"`
}

// The set of arguments for constructing a YdbTableIndex resource.
type YdbTableIndexArgs struct {
	Columns          pulumi.StringArrayInput
	ConnectionString pulumi.StringPtrInput
	Covers           pulumi.StringArrayInput
	Name             pulumi.StringPtrInput
	TableId          pulumi.StringPtrInput
	TablePath        pulumi.StringPtrInput
	Type             pulumi.StringInput
}

func (YdbTableIndexArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ydbTableIndexArgs)(nil)).Elem()
}

type YdbTableIndexInput interface {
	pulumi.Input

	ToYdbTableIndexOutput() YdbTableIndexOutput
	ToYdbTableIndexOutputWithContext(ctx context.Context) YdbTableIndexOutput
}

func (*YdbTableIndex) ElementType() reflect.Type {
	return reflect.TypeOf((**YdbTableIndex)(nil)).Elem()
}

func (i *YdbTableIndex) ToYdbTableIndexOutput() YdbTableIndexOutput {
	return i.ToYdbTableIndexOutputWithContext(context.Background())
}

func (i *YdbTableIndex) ToYdbTableIndexOutputWithContext(ctx context.Context) YdbTableIndexOutput {
	return pulumi.ToOutputWithContext(ctx, i).(YdbTableIndexOutput)
}

// YdbTableIndexArrayInput is an input type that accepts YdbTableIndexArray and YdbTableIndexArrayOutput values.
// You can construct a concrete instance of `YdbTableIndexArrayInput` via:
//
//	YdbTableIndexArray{ YdbTableIndexArgs{...} }
type YdbTableIndexArrayInput interface {
	pulumi.Input

	ToYdbTableIndexArrayOutput() YdbTableIndexArrayOutput
	ToYdbTableIndexArrayOutputWithContext(context.Context) YdbTableIndexArrayOutput
}

type YdbTableIndexArray []YdbTableIndexInput

func (YdbTableIndexArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*YdbTableIndex)(nil)).Elem()
}

func (i YdbTableIndexArray) ToYdbTableIndexArrayOutput() YdbTableIndexArrayOutput {
	return i.ToYdbTableIndexArrayOutputWithContext(context.Background())
}

func (i YdbTableIndexArray) ToYdbTableIndexArrayOutputWithContext(ctx context.Context) YdbTableIndexArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(YdbTableIndexArrayOutput)
}

// YdbTableIndexMapInput is an input type that accepts YdbTableIndexMap and YdbTableIndexMapOutput values.
// You can construct a concrete instance of `YdbTableIndexMapInput` via:
//
//	YdbTableIndexMap{ "key": YdbTableIndexArgs{...} }
type YdbTableIndexMapInput interface {
	pulumi.Input

	ToYdbTableIndexMapOutput() YdbTableIndexMapOutput
	ToYdbTableIndexMapOutputWithContext(context.Context) YdbTableIndexMapOutput
}

type YdbTableIndexMap map[string]YdbTableIndexInput

func (YdbTableIndexMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*YdbTableIndex)(nil)).Elem()
}

func (i YdbTableIndexMap) ToYdbTableIndexMapOutput() YdbTableIndexMapOutput {
	return i.ToYdbTableIndexMapOutputWithContext(context.Background())
}

func (i YdbTableIndexMap) ToYdbTableIndexMapOutputWithContext(ctx context.Context) YdbTableIndexMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(YdbTableIndexMapOutput)
}

type YdbTableIndexOutput struct{ *pulumi.OutputState }

func (YdbTableIndexOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**YdbTableIndex)(nil)).Elem()
}

func (o YdbTableIndexOutput) ToYdbTableIndexOutput() YdbTableIndexOutput {
	return o
}

func (o YdbTableIndexOutput) ToYdbTableIndexOutputWithContext(ctx context.Context) YdbTableIndexOutput {
	return o
}

func (o YdbTableIndexOutput) Columns() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *YdbTableIndex) pulumi.StringArrayOutput { return v.Columns }).(pulumi.StringArrayOutput)
}

func (o YdbTableIndexOutput) ConnectionString() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbTableIndex) pulumi.StringOutput { return v.ConnectionString }).(pulumi.StringOutput)
}

func (o YdbTableIndexOutput) Covers() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *YdbTableIndex) pulumi.StringArrayOutput { return v.Covers }).(pulumi.StringArrayOutput)
}

func (o YdbTableIndexOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbTableIndex) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o YdbTableIndexOutput) TableId() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbTableIndex) pulumi.StringOutput { return v.TableId }).(pulumi.StringOutput)
}

func (o YdbTableIndexOutput) TablePath() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbTableIndex) pulumi.StringOutput { return v.TablePath }).(pulumi.StringOutput)
}

func (o YdbTableIndexOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbTableIndex) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

type YdbTableIndexArrayOutput struct{ *pulumi.OutputState }

func (YdbTableIndexArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*YdbTableIndex)(nil)).Elem()
}

func (o YdbTableIndexArrayOutput) ToYdbTableIndexArrayOutput() YdbTableIndexArrayOutput {
	return o
}

func (o YdbTableIndexArrayOutput) ToYdbTableIndexArrayOutputWithContext(ctx context.Context) YdbTableIndexArrayOutput {
	return o
}

func (o YdbTableIndexArrayOutput) Index(i pulumi.IntInput) YdbTableIndexOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *YdbTableIndex {
		return vs[0].([]*YdbTableIndex)[vs[1].(int)]
	}).(YdbTableIndexOutput)
}

type YdbTableIndexMapOutput struct{ *pulumi.OutputState }

func (YdbTableIndexMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*YdbTableIndex)(nil)).Elem()
}

func (o YdbTableIndexMapOutput) ToYdbTableIndexMapOutput() YdbTableIndexMapOutput {
	return o
}

func (o YdbTableIndexMapOutput) ToYdbTableIndexMapOutputWithContext(ctx context.Context) YdbTableIndexMapOutput {
	return o
}

func (o YdbTableIndexMapOutput) MapIndex(k pulumi.StringInput) YdbTableIndexOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *YdbTableIndex {
		return vs[0].(map[string]*YdbTableIndex)[vs[1].(string)]
	}).(YdbTableIndexOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*YdbTableIndexInput)(nil)).Elem(), &YdbTableIndex{})
	pulumi.RegisterInputType(reflect.TypeOf((*YdbTableIndexArrayInput)(nil)).Elem(), YdbTableIndexArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*YdbTableIndexMapInput)(nil)).Elem(), YdbTableIndexMap{})
	pulumi.RegisterOutputType(YdbTableIndexOutput{})
	pulumi.RegisterOutputType(YdbTableIndexArrayOutput{})
	pulumi.RegisterOutputType(YdbTableIndexMapOutput{})
}