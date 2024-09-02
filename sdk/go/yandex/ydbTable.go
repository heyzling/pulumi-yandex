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

// Yandex Database table resource.
type YdbTable struct {
	pulumi.CustomResourceState

	// A map of table attributes.
	Attributes pulumi.StringMapOutput `pulumi:"attributes"`
	// A list of column configuration options.
	// The structure is documented below.
	Columns YdbTableColumnArrayOutput `pulumi:"columns"`
	// Connection string for database.
	ConnectionString pulumi.StringOutput `pulumi:"connectionString"`
	// A list of column group configuration options.
	// The structure is documented below.
	Families YdbTableFamilyArrayOutput `pulumi:"families"`
	// Use the Bloom filter for the primary key
	KeyBloomFilter pulumi.BoolOutput `pulumi:"keyBloomFilter"`
	// Table partiotioning settings
	// The structure is documented below.
	PartitioningSettings YdbTablePartitioningSettingsOutput `pulumi:"partitioningSettings"`
	// Table path.
	Path pulumi.StringOutput `pulumi:"path"`
	// A list of table columns to be uased as primary key.
	PrimaryKeys pulumi.StringArrayOutput `pulumi:"primaryKeys"`
	// Read replication settings
	ReadReplicasSettings pulumi.StringOutput `pulumi:"readReplicasSettings"`
	// ttl		TTL settings
	// The structure is documented below.
	Ttl YdbTableTtlPtrOutput `pulumi:"ttl"`
}

// NewYdbTable registers a new resource with the given unique name, arguments, and options.
func NewYdbTable(ctx *pulumi.Context,
	name string, args *YdbTableArgs, opts ...pulumi.ResourceOption) (*YdbTable, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Columns == nil {
		return nil, errors.New("invalid value for required argument 'Columns'")
	}
	if args.ConnectionString == nil {
		return nil, errors.New("invalid value for required argument 'ConnectionString'")
	}
	if args.Path == nil {
		return nil, errors.New("invalid value for required argument 'Path'")
	}
	if args.PrimaryKeys == nil {
		return nil, errors.New("invalid value for required argument 'PrimaryKeys'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource YdbTable
	err := ctx.RegisterResource("yandex:index/ydbTable:YdbTable", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetYdbTable gets an existing YdbTable resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetYdbTable(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *YdbTableState, opts ...pulumi.ResourceOption) (*YdbTable, error) {
	var resource YdbTable
	err := ctx.ReadResource("yandex:index/ydbTable:YdbTable", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering YdbTable resources.
type ydbTableState struct {
	// A map of table attributes.
	Attributes map[string]string `pulumi:"attributes"`
	// A list of column configuration options.
	// The structure is documented below.
	Columns []YdbTableColumn `pulumi:"columns"`
	// Connection string for database.
	ConnectionString *string `pulumi:"connectionString"`
	// A list of column group configuration options.
	// The structure is documented below.
	Families []YdbTableFamily `pulumi:"families"`
	// Use the Bloom filter for the primary key
	KeyBloomFilter *bool `pulumi:"keyBloomFilter"`
	// Table partiotioning settings
	// The structure is documented below.
	PartitioningSettings *YdbTablePartitioningSettings `pulumi:"partitioningSettings"`
	// Table path.
	Path *string `pulumi:"path"`
	// A list of table columns to be uased as primary key.
	PrimaryKeys []string `pulumi:"primaryKeys"`
	// Read replication settings
	ReadReplicasSettings *string `pulumi:"readReplicasSettings"`
	// ttl		TTL settings
	// The structure is documented below.
	Ttl *YdbTableTtl `pulumi:"ttl"`
}

type YdbTableState struct {
	// A map of table attributes.
	Attributes pulumi.StringMapInput
	// A list of column configuration options.
	// The structure is documented below.
	Columns YdbTableColumnArrayInput
	// Connection string for database.
	ConnectionString pulumi.StringPtrInput
	// A list of column group configuration options.
	// The structure is documented below.
	Families YdbTableFamilyArrayInput
	// Use the Bloom filter for the primary key
	KeyBloomFilter pulumi.BoolPtrInput
	// Table partiotioning settings
	// The structure is documented below.
	PartitioningSettings YdbTablePartitioningSettingsPtrInput
	// Table path.
	Path pulumi.StringPtrInput
	// A list of table columns to be uased as primary key.
	PrimaryKeys pulumi.StringArrayInput
	// Read replication settings
	ReadReplicasSettings pulumi.StringPtrInput
	// ttl		TTL settings
	// The structure is documented below.
	Ttl YdbTableTtlPtrInput
}

func (YdbTableState) ElementType() reflect.Type {
	return reflect.TypeOf((*ydbTableState)(nil)).Elem()
}

type ydbTableArgs struct {
	// A map of table attributes.
	Attributes map[string]string `pulumi:"attributes"`
	// A list of column configuration options.
	// The structure is documented below.
	Columns []YdbTableColumn `pulumi:"columns"`
	// Connection string for database.
	ConnectionString string `pulumi:"connectionString"`
	// A list of column group configuration options.
	// The structure is documented below.
	Families []YdbTableFamily `pulumi:"families"`
	// Use the Bloom filter for the primary key
	KeyBloomFilter *bool `pulumi:"keyBloomFilter"`
	// Table partiotioning settings
	// The structure is documented below.
	PartitioningSettings *YdbTablePartitioningSettings `pulumi:"partitioningSettings"`
	// Table path.
	Path string `pulumi:"path"`
	// A list of table columns to be uased as primary key.
	PrimaryKeys []string `pulumi:"primaryKeys"`
	// Read replication settings
	ReadReplicasSettings *string `pulumi:"readReplicasSettings"`
	// ttl		TTL settings
	// The structure is documented below.
	Ttl *YdbTableTtl `pulumi:"ttl"`
}

// The set of arguments for constructing a YdbTable resource.
type YdbTableArgs struct {
	// A map of table attributes.
	Attributes pulumi.StringMapInput
	// A list of column configuration options.
	// The structure is documented below.
	Columns YdbTableColumnArrayInput
	// Connection string for database.
	ConnectionString pulumi.StringInput
	// A list of column group configuration options.
	// The structure is documented below.
	Families YdbTableFamilyArrayInput
	// Use the Bloom filter for the primary key
	KeyBloomFilter pulumi.BoolPtrInput
	// Table partiotioning settings
	// The structure is documented below.
	PartitioningSettings YdbTablePartitioningSettingsPtrInput
	// Table path.
	Path pulumi.StringInput
	// A list of table columns to be uased as primary key.
	PrimaryKeys pulumi.StringArrayInput
	// Read replication settings
	ReadReplicasSettings pulumi.StringPtrInput
	// ttl		TTL settings
	// The structure is documented below.
	Ttl YdbTableTtlPtrInput
}

func (YdbTableArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ydbTableArgs)(nil)).Elem()
}

type YdbTableInput interface {
	pulumi.Input

	ToYdbTableOutput() YdbTableOutput
	ToYdbTableOutputWithContext(ctx context.Context) YdbTableOutput
}

func (*YdbTable) ElementType() reflect.Type {
	return reflect.TypeOf((**YdbTable)(nil)).Elem()
}

func (i *YdbTable) ToYdbTableOutput() YdbTableOutput {
	return i.ToYdbTableOutputWithContext(context.Background())
}

func (i *YdbTable) ToYdbTableOutputWithContext(ctx context.Context) YdbTableOutput {
	return pulumi.ToOutputWithContext(ctx, i).(YdbTableOutput)
}

// YdbTableArrayInput is an input type that accepts YdbTableArray and YdbTableArrayOutput values.
// You can construct a concrete instance of `YdbTableArrayInput` via:
//
//	YdbTableArray{ YdbTableArgs{...} }
type YdbTableArrayInput interface {
	pulumi.Input

	ToYdbTableArrayOutput() YdbTableArrayOutput
	ToYdbTableArrayOutputWithContext(context.Context) YdbTableArrayOutput
}

type YdbTableArray []YdbTableInput

func (YdbTableArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*YdbTable)(nil)).Elem()
}

func (i YdbTableArray) ToYdbTableArrayOutput() YdbTableArrayOutput {
	return i.ToYdbTableArrayOutputWithContext(context.Background())
}

func (i YdbTableArray) ToYdbTableArrayOutputWithContext(ctx context.Context) YdbTableArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(YdbTableArrayOutput)
}

// YdbTableMapInput is an input type that accepts YdbTableMap and YdbTableMapOutput values.
// You can construct a concrete instance of `YdbTableMapInput` via:
//
//	YdbTableMap{ "key": YdbTableArgs{...} }
type YdbTableMapInput interface {
	pulumi.Input

	ToYdbTableMapOutput() YdbTableMapOutput
	ToYdbTableMapOutputWithContext(context.Context) YdbTableMapOutput
}

type YdbTableMap map[string]YdbTableInput

func (YdbTableMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*YdbTable)(nil)).Elem()
}

func (i YdbTableMap) ToYdbTableMapOutput() YdbTableMapOutput {
	return i.ToYdbTableMapOutputWithContext(context.Background())
}

func (i YdbTableMap) ToYdbTableMapOutputWithContext(ctx context.Context) YdbTableMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(YdbTableMapOutput)
}

type YdbTableOutput struct{ *pulumi.OutputState }

func (YdbTableOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**YdbTable)(nil)).Elem()
}

func (o YdbTableOutput) ToYdbTableOutput() YdbTableOutput {
	return o
}

func (o YdbTableOutput) ToYdbTableOutputWithContext(ctx context.Context) YdbTableOutput {
	return o
}

// A map of table attributes.
func (o YdbTableOutput) Attributes() pulumi.StringMapOutput {
	return o.ApplyT(func(v *YdbTable) pulumi.StringMapOutput { return v.Attributes }).(pulumi.StringMapOutput)
}

// A list of column configuration options.
// The structure is documented below.
func (o YdbTableOutput) Columns() YdbTableColumnArrayOutput {
	return o.ApplyT(func(v *YdbTable) YdbTableColumnArrayOutput { return v.Columns }).(YdbTableColumnArrayOutput)
}

// Connection string for database.
func (o YdbTableOutput) ConnectionString() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbTable) pulumi.StringOutput { return v.ConnectionString }).(pulumi.StringOutput)
}

// A list of column group configuration options.
// The structure is documented below.
func (o YdbTableOutput) Families() YdbTableFamilyArrayOutput {
	return o.ApplyT(func(v *YdbTable) YdbTableFamilyArrayOutput { return v.Families }).(YdbTableFamilyArrayOutput)
}

// Use the Bloom filter for the primary key
func (o YdbTableOutput) KeyBloomFilter() pulumi.BoolOutput {
	return o.ApplyT(func(v *YdbTable) pulumi.BoolOutput { return v.KeyBloomFilter }).(pulumi.BoolOutput)
}

// Table partiotioning settings
// The structure is documented below.
func (o YdbTableOutput) PartitioningSettings() YdbTablePartitioningSettingsOutput {
	return o.ApplyT(func(v *YdbTable) YdbTablePartitioningSettingsOutput { return v.PartitioningSettings }).(YdbTablePartitioningSettingsOutput)
}

// Table path.
func (o YdbTableOutput) Path() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbTable) pulumi.StringOutput { return v.Path }).(pulumi.StringOutput)
}

// A list of table columns to be uased as primary key.
func (o YdbTableOutput) PrimaryKeys() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *YdbTable) pulumi.StringArrayOutput { return v.PrimaryKeys }).(pulumi.StringArrayOutput)
}

// Read replication settings
func (o YdbTableOutput) ReadReplicasSettings() pulumi.StringOutput {
	return o.ApplyT(func(v *YdbTable) pulumi.StringOutput { return v.ReadReplicasSettings }).(pulumi.StringOutput)
}

// ttl		TTL settings
// The structure is documented below.
func (o YdbTableOutput) Ttl() YdbTableTtlPtrOutput {
	return o.ApplyT(func(v *YdbTable) YdbTableTtlPtrOutput { return v.Ttl }).(YdbTableTtlPtrOutput)
}

type YdbTableArrayOutput struct{ *pulumi.OutputState }

func (YdbTableArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*YdbTable)(nil)).Elem()
}

func (o YdbTableArrayOutput) ToYdbTableArrayOutput() YdbTableArrayOutput {
	return o
}

func (o YdbTableArrayOutput) ToYdbTableArrayOutputWithContext(ctx context.Context) YdbTableArrayOutput {
	return o
}

func (o YdbTableArrayOutput) Index(i pulumi.IntInput) YdbTableOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *YdbTable {
		return vs[0].([]*YdbTable)[vs[1].(int)]
	}).(YdbTableOutput)
}

type YdbTableMapOutput struct{ *pulumi.OutputState }

func (YdbTableMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*YdbTable)(nil)).Elem()
}

func (o YdbTableMapOutput) ToYdbTableMapOutput() YdbTableMapOutput {
	return o
}

func (o YdbTableMapOutput) ToYdbTableMapOutputWithContext(ctx context.Context) YdbTableMapOutput {
	return o
}

func (o YdbTableMapOutput) MapIndex(k pulumi.StringInput) YdbTableOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *YdbTable {
		return vs[0].(map[string]*YdbTable)[vs[1].(string)]
	}).(YdbTableOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*YdbTableInput)(nil)).Elem(), &YdbTable{})
	pulumi.RegisterInputType(reflect.TypeOf((*YdbTableArrayInput)(nil)).Elem(), YdbTableArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*YdbTableMapInput)(nil)).Elem(), YdbTableMap{})
	pulumi.RegisterOutputType(YdbTableOutput{})
	pulumi.RegisterOutputType(YdbTableArrayOutput{})
	pulumi.RegisterOutputType(YdbTableMapOutput{})
}