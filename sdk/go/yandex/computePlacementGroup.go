// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// A Placement group resource. For more information, see
// [the official documentation](https://cloud.yandex.com/docs/compute/concepts/placement-groups).
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
//			_, err := yandex.NewComputePlacementGroup(ctx, "group1", &yandex.ComputePlacementGroupArgs{
//				Description: pulumi.String("my description"),
//				FolderId:    pulumi.String("abc*********123"),
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
// A Placement Group can be imported using any of these accepted formats:
//
// ```sh
// $ pulumi import yandex:index/computePlacementGroup:ComputePlacementGroup default placement_group_id
// ```
type ComputePlacementGroup struct {
	pulumi.CustomResourceState

	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// A description of the Placement Group.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId pulumi.StringOutput `pulumi:"folderId"`
	// A set of key/value label pairs to assign to the Placement Group.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// The name of the Placement Group.
	Name pulumi.StringOutput `pulumi:"name"`
	// A number of partitions in the placement strategy with partitions policy of the Placement Group (conflicts with placement_strategy_spread).
	PlacementStrategyPartitions pulumi.IntPtrOutput `pulumi:"placementStrategyPartitions"`
	// A placement strategy with spread policy of the Placement Group. Should be true or unset (conflicts with placement_strategy_partitions).
	PlacementStrategySpread pulumi.BoolPtrOutput `pulumi:"placementStrategySpread"`
}

// NewComputePlacementGroup registers a new resource with the given unique name, arguments, and options.
func NewComputePlacementGroup(ctx *pulumi.Context,
	name string, args *ComputePlacementGroupArgs, opts ...pulumi.ResourceOption) (*ComputePlacementGroup, error) {
	if args == nil {
		args = &ComputePlacementGroupArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ComputePlacementGroup
	err := ctx.RegisterResource("yandex:index/computePlacementGroup:ComputePlacementGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetComputePlacementGroup gets an existing ComputePlacementGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetComputePlacementGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ComputePlacementGroupState, opts ...pulumi.ResourceOption) (*ComputePlacementGroup, error) {
	var resource ComputePlacementGroup
	err := ctx.ReadResource("yandex:index/computePlacementGroup:ComputePlacementGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ComputePlacementGroup resources.
type computePlacementGroupState struct {
	CreatedAt *string `pulumi:"createdAt"`
	// A description of the Placement Group.
	Description *string `pulumi:"description"`
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// A set of key/value label pairs to assign to the Placement Group.
	Labels map[string]string `pulumi:"labels"`
	// The name of the Placement Group.
	Name *string `pulumi:"name"`
	// A number of partitions in the placement strategy with partitions policy of the Placement Group (conflicts with placement_strategy_spread).
	PlacementStrategyPartitions *int `pulumi:"placementStrategyPartitions"`
	// A placement strategy with spread policy of the Placement Group. Should be true or unset (conflicts with placement_strategy_partitions).
	PlacementStrategySpread *bool `pulumi:"placementStrategySpread"`
}

type ComputePlacementGroupState struct {
	CreatedAt pulumi.StringPtrInput
	// A description of the Placement Group.
	Description pulumi.StringPtrInput
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// A set of key/value label pairs to assign to the Placement Group.
	Labels pulumi.StringMapInput
	// The name of the Placement Group.
	Name pulumi.StringPtrInput
	// A number of partitions in the placement strategy with partitions policy of the Placement Group (conflicts with placement_strategy_spread).
	PlacementStrategyPartitions pulumi.IntPtrInput
	// A placement strategy with spread policy of the Placement Group. Should be true or unset (conflicts with placement_strategy_partitions).
	PlacementStrategySpread pulumi.BoolPtrInput
}

func (ComputePlacementGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*computePlacementGroupState)(nil)).Elem()
}

type computePlacementGroupArgs struct {
	// A description of the Placement Group.
	Description *string `pulumi:"description"`
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// A set of key/value label pairs to assign to the Placement Group.
	Labels map[string]string `pulumi:"labels"`
	// The name of the Placement Group.
	Name *string `pulumi:"name"`
	// A number of partitions in the placement strategy with partitions policy of the Placement Group (conflicts with placement_strategy_spread).
	PlacementStrategyPartitions *int `pulumi:"placementStrategyPartitions"`
	// A placement strategy with spread policy of the Placement Group. Should be true or unset (conflicts with placement_strategy_partitions).
	PlacementStrategySpread *bool `pulumi:"placementStrategySpread"`
}

// The set of arguments for constructing a ComputePlacementGroup resource.
type ComputePlacementGroupArgs struct {
	// A description of the Placement Group.
	Description pulumi.StringPtrInput
	// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// A set of key/value label pairs to assign to the Placement Group.
	Labels pulumi.StringMapInput
	// The name of the Placement Group.
	Name pulumi.StringPtrInput
	// A number of partitions in the placement strategy with partitions policy of the Placement Group (conflicts with placement_strategy_spread).
	PlacementStrategyPartitions pulumi.IntPtrInput
	// A placement strategy with spread policy of the Placement Group. Should be true or unset (conflicts with placement_strategy_partitions).
	PlacementStrategySpread pulumi.BoolPtrInput
}

func (ComputePlacementGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*computePlacementGroupArgs)(nil)).Elem()
}

type ComputePlacementGroupInput interface {
	pulumi.Input

	ToComputePlacementGroupOutput() ComputePlacementGroupOutput
	ToComputePlacementGroupOutputWithContext(ctx context.Context) ComputePlacementGroupOutput
}

func (*ComputePlacementGroup) ElementType() reflect.Type {
	return reflect.TypeOf((**ComputePlacementGroup)(nil)).Elem()
}

func (i *ComputePlacementGroup) ToComputePlacementGroupOutput() ComputePlacementGroupOutput {
	return i.ToComputePlacementGroupOutputWithContext(context.Background())
}

func (i *ComputePlacementGroup) ToComputePlacementGroupOutputWithContext(ctx context.Context) ComputePlacementGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComputePlacementGroupOutput)
}

// ComputePlacementGroupArrayInput is an input type that accepts ComputePlacementGroupArray and ComputePlacementGroupArrayOutput values.
// You can construct a concrete instance of `ComputePlacementGroupArrayInput` via:
//
//	ComputePlacementGroupArray{ ComputePlacementGroupArgs{...} }
type ComputePlacementGroupArrayInput interface {
	pulumi.Input

	ToComputePlacementGroupArrayOutput() ComputePlacementGroupArrayOutput
	ToComputePlacementGroupArrayOutputWithContext(context.Context) ComputePlacementGroupArrayOutput
}

type ComputePlacementGroupArray []ComputePlacementGroupInput

func (ComputePlacementGroupArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ComputePlacementGroup)(nil)).Elem()
}

func (i ComputePlacementGroupArray) ToComputePlacementGroupArrayOutput() ComputePlacementGroupArrayOutput {
	return i.ToComputePlacementGroupArrayOutputWithContext(context.Background())
}

func (i ComputePlacementGroupArray) ToComputePlacementGroupArrayOutputWithContext(ctx context.Context) ComputePlacementGroupArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComputePlacementGroupArrayOutput)
}

// ComputePlacementGroupMapInput is an input type that accepts ComputePlacementGroupMap and ComputePlacementGroupMapOutput values.
// You can construct a concrete instance of `ComputePlacementGroupMapInput` via:
//
//	ComputePlacementGroupMap{ "key": ComputePlacementGroupArgs{...} }
type ComputePlacementGroupMapInput interface {
	pulumi.Input

	ToComputePlacementGroupMapOutput() ComputePlacementGroupMapOutput
	ToComputePlacementGroupMapOutputWithContext(context.Context) ComputePlacementGroupMapOutput
}

type ComputePlacementGroupMap map[string]ComputePlacementGroupInput

func (ComputePlacementGroupMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ComputePlacementGroup)(nil)).Elem()
}

func (i ComputePlacementGroupMap) ToComputePlacementGroupMapOutput() ComputePlacementGroupMapOutput {
	return i.ToComputePlacementGroupMapOutputWithContext(context.Background())
}

func (i ComputePlacementGroupMap) ToComputePlacementGroupMapOutputWithContext(ctx context.Context) ComputePlacementGroupMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComputePlacementGroupMapOutput)
}

type ComputePlacementGroupOutput struct{ *pulumi.OutputState }

func (ComputePlacementGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ComputePlacementGroup)(nil)).Elem()
}

func (o ComputePlacementGroupOutput) ToComputePlacementGroupOutput() ComputePlacementGroupOutput {
	return o
}

func (o ComputePlacementGroupOutput) ToComputePlacementGroupOutputWithContext(ctx context.Context) ComputePlacementGroupOutput {
	return o
}

func (o ComputePlacementGroupOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputePlacementGroup) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// A description of the Placement Group.
func (o ComputePlacementGroupOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ComputePlacementGroup) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
func (o ComputePlacementGroupOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputePlacementGroup) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

// A set of key/value label pairs to assign to the Placement Group.
func (o ComputePlacementGroupOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *ComputePlacementGroup) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

// The name of the Placement Group.
func (o ComputePlacementGroupOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ComputePlacementGroup) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// A number of partitions in the placement strategy with partitions policy of the Placement Group (conflicts with placement_strategy_spread).
func (o ComputePlacementGroupOutput) PlacementStrategyPartitions() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ComputePlacementGroup) pulumi.IntPtrOutput { return v.PlacementStrategyPartitions }).(pulumi.IntPtrOutput)
}

// A placement strategy with spread policy of the Placement Group. Should be true or unset (conflicts with placement_strategy_partitions).
func (o ComputePlacementGroupOutput) PlacementStrategySpread() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *ComputePlacementGroup) pulumi.BoolPtrOutput { return v.PlacementStrategySpread }).(pulumi.BoolPtrOutput)
}

type ComputePlacementGroupArrayOutput struct{ *pulumi.OutputState }

func (ComputePlacementGroupArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ComputePlacementGroup)(nil)).Elem()
}

func (o ComputePlacementGroupArrayOutput) ToComputePlacementGroupArrayOutput() ComputePlacementGroupArrayOutput {
	return o
}

func (o ComputePlacementGroupArrayOutput) ToComputePlacementGroupArrayOutputWithContext(ctx context.Context) ComputePlacementGroupArrayOutput {
	return o
}

func (o ComputePlacementGroupArrayOutput) Index(i pulumi.IntInput) ComputePlacementGroupOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ComputePlacementGroup {
		return vs[0].([]*ComputePlacementGroup)[vs[1].(int)]
	}).(ComputePlacementGroupOutput)
}

type ComputePlacementGroupMapOutput struct{ *pulumi.OutputState }

func (ComputePlacementGroupMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ComputePlacementGroup)(nil)).Elem()
}

func (o ComputePlacementGroupMapOutput) ToComputePlacementGroupMapOutput() ComputePlacementGroupMapOutput {
	return o
}

func (o ComputePlacementGroupMapOutput) ToComputePlacementGroupMapOutputWithContext(ctx context.Context) ComputePlacementGroupMapOutput {
	return o
}

func (o ComputePlacementGroupMapOutput) MapIndex(k pulumi.StringInput) ComputePlacementGroupOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ComputePlacementGroup {
		return vs[0].(map[string]*ComputePlacementGroup)[vs[1].(string)]
	}).(ComputePlacementGroupOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ComputePlacementGroupInput)(nil)).Elem(), &ComputePlacementGroup{})
	pulumi.RegisterInputType(reflect.TypeOf((*ComputePlacementGroupArrayInput)(nil)).Elem(), ComputePlacementGroupArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ComputePlacementGroupMapInput)(nil)).Elem(), ComputePlacementGroupMap{})
	pulumi.RegisterOutputType(ComputePlacementGroupOutput{})
	pulumi.RegisterOutputType(ComputePlacementGroupArrayOutput{})
	pulumi.RegisterOutputType(ComputePlacementGroupMapOutput{})
}
