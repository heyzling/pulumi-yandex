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

// Manages a Elasticsearch cluster within the Yandex.Cloud. For more information, see
// [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/concepts).
//
// ## Example Usage
//
// Example of creating a Single Node Elasticsearch.
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
//			fooVpcNetwork, err := yandex.NewVpcNetwork(ctx, "fooVpcNetwork", nil)
//			if err != nil {
//				return err
//			}
//			fooVpcSubnet, err := yandex.NewVpcSubnet(ctx, "fooVpcSubnet", &yandex.VpcSubnetArgs{
//				NetworkId: fooVpcNetwork.ID(),
//				V4CidrBlocks: pulumi.StringArray{
//					pulumi.String("10.5.0.0/24"),
//				},
//				Zone: pulumi.String("ru-central1-a"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = yandex.NewMdbElasticsearchCluster(ctx, "fooMdbElasticsearchCluster", &yandex.MdbElasticsearchClusterArgs{
//				Config: &yandex.MdbElasticsearchClusterConfigArgs{
//					AdminPassword: pulumi.String("super-password"),
//					DataNode: &yandex.MdbElasticsearchClusterConfigDataNodeArgs{
//						Resources: &yandex.MdbElasticsearchClusterConfigDataNodeResourcesArgs{
//							DiskSize:         pulumi.Int(100),
//							DiskTypeId:       pulumi.String("network-ssd"),
//							ResourcePresetId: pulumi.String("s2.micro"),
//						},
//					},
//				},
//				Environment: pulumi.String("PRESTABLE"),
//				Hosts: yandex.MdbElasticsearchClusterHostArray{
//					&yandex.MdbElasticsearchClusterHostArgs{
//						AssignPublicIp: pulumi.Bool(true),
//						Name:           pulumi.String("node"),
//						SubnetId:       fooVpcSubnet.ID(),
//						Type:           pulumi.String("DATA_NODE"),
//						Zone:           pulumi.String("ru-central1-a"),
//					},
//				},
//				MaintenanceWindow: &yandex.MdbElasticsearchClusterMaintenanceWindowArgs{
//					Type: pulumi.String("ANYTIME"),
//				},
//				NetworkId: fooVpcNetwork.ID(),
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
// Example of creating a high available Elasticsearch Cluster.
//
// ## Import
//
// A cluster can be imported using the `id` of the resource, e.g.
//
// ```sh
// $ pulumi import yandex:index/mdbElasticsearchCluster:MdbElasticsearchCluster foo cluster_id
// ```
type MdbElasticsearchCluster struct {
	pulumi.CustomResourceState

	// Configuration of the Elasticsearch cluster. The structure is documented below.
	Config MdbElasticsearchClusterConfigOutput `pulumi:"config"`
	// Creation timestamp of the key.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// Inhibits deletion of the cluster.  Can be either `true` or `false`.
	//
	// ***
	DeletionProtection pulumi.BoolOutput `pulumi:"deletionProtection"`
	// Description of the Elasticsearch cluster.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Deployment environment of the Elasticsearch cluster. Can be either `PRESTABLE` or `PRODUCTION`.
	Environment pulumi.StringOutput `pulumi:"environment"`
	// The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
	FolderId pulumi.StringOutput `pulumi:"folderId"`
	// Aggregated health of the cluster. Can be either `ALIVE`, `DEGRADED`, `DEAD` or `HEALTH_UNKNOWN`.
	// For more information see `health` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
	Health pulumi.StringOutput `pulumi:"health"`
	// A host of the Elasticsearch cluster. The structure is documented below.
	//
	// ***
	Hosts MdbElasticsearchClusterHostArrayOutput `pulumi:"hosts"`
	// A set of key/value label pairs to assign to the Elasticsearch cluster.
	Labels            pulumi.StringMapOutput                         `pulumi:"labels"`
	MaintenanceWindow MdbElasticsearchClusterMaintenanceWindowOutput `pulumi:"maintenanceWindow"`
	// Name of the Elasticsearch cluster. Provided by the client when the cluster is created.
	Name pulumi.StringOutput `pulumi:"name"`
	// ID of the network, to which the Elasticsearch cluster belongs.
	NetworkId pulumi.StringOutput `pulumi:"networkId"`
	// A set of ids of security groups assigned to hosts of the cluster.
	SecurityGroupIds pulumi.StringArrayOutput `pulumi:"securityGroupIds"`
	// ID of the service account authorized for this cluster.
	ServiceAccountId pulumi.StringPtrOutput `pulumi:"serviceAccountId"`
	// Status of the cluster. Can be either `CREATING`, `STARTING`, `RUNNING`, `UPDATING`, `STOPPING`, `STOPPED`, `ERROR` or `STATUS_UNKNOWN`.
	// For more information see `status` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
	Status pulumi.StringOutput `pulumi:"status"`
}

// NewMdbElasticsearchCluster registers a new resource with the given unique name, arguments, and options.
func NewMdbElasticsearchCluster(ctx *pulumi.Context,
	name string, args *MdbElasticsearchClusterArgs, opts ...pulumi.ResourceOption) (*MdbElasticsearchCluster, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Config == nil {
		return nil, errors.New("invalid value for required argument 'Config'")
	}
	if args.Environment == nil {
		return nil, errors.New("invalid value for required argument 'Environment'")
	}
	if args.NetworkId == nil {
		return nil, errors.New("invalid value for required argument 'NetworkId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource MdbElasticsearchCluster
	err := ctx.RegisterResource("yandex:index/mdbElasticsearchCluster:MdbElasticsearchCluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMdbElasticsearchCluster gets an existing MdbElasticsearchCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMdbElasticsearchCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MdbElasticsearchClusterState, opts ...pulumi.ResourceOption) (*MdbElasticsearchCluster, error) {
	var resource MdbElasticsearchCluster
	err := ctx.ReadResource("yandex:index/mdbElasticsearchCluster:MdbElasticsearchCluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MdbElasticsearchCluster resources.
type mdbElasticsearchClusterState struct {
	// Configuration of the Elasticsearch cluster. The structure is documented below.
	Config *MdbElasticsearchClusterConfig `pulumi:"config"`
	// Creation timestamp of the key.
	CreatedAt *string `pulumi:"createdAt"`
	// Inhibits deletion of the cluster.  Can be either `true` or `false`.
	//
	// ***
	DeletionProtection *bool `pulumi:"deletionProtection"`
	// Description of the Elasticsearch cluster.
	Description *string `pulumi:"description"`
	// Deployment environment of the Elasticsearch cluster. Can be either `PRESTABLE` or `PRODUCTION`.
	Environment *string `pulumi:"environment"`
	// The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// Aggregated health of the cluster. Can be either `ALIVE`, `DEGRADED`, `DEAD` or `HEALTH_UNKNOWN`.
	// For more information see `health` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
	Health *string `pulumi:"health"`
	// A host of the Elasticsearch cluster. The structure is documented below.
	//
	// ***
	Hosts []MdbElasticsearchClusterHost `pulumi:"hosts"`
	// A set of key/value label pairs to assign to the Elasticsearch cluster.
	Labels            map[string]string                         `pulumi:"labels"`
	MaintenanceWindow *MdbElasticsearchClusterMaintenanceWindow `pulumi:"maintenanceWindow"`
	// Name of the Elasticsearch cluster. Provided by the client when the cluster is created.
	Name *string `pulumi:"name"`
	// ID of the network, to which the Elasticsearch cluster belongs.
	NetworkId *string `pulumi:"networkId"`
	// A set of ids of security groups assigned to hosts of the cluster.
	SecurityGroupIds []string `pulumi:"securityGroupIds"`
	// ID of the service account authorized for this cluster.
	ServiceAccountId *string `pulumi:"serviceAccountId"`
	// Status of the cluster. Can be either `CREATING`, `STARTING`, `RUNNING`, `UPDATING`, `STOPPING`, `STOPPED`, `ERROR` or `STATUS_UNKNOWN`.
	// For more information see `status` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
	Status *string `pulumi:"status"`
}

type MdbElasticsearchClusterState struct {
	// Configuration of the Elasticsearch cluster. The structure is documented below.
	Config MdbElasticsearchClusterConfigPtrInput
	// Creation timestamp of the key.
	CreatedAt pulumi.StringPtrInput
	// Inhibits deletion of the cluster.  Can be either `true` or `false`.
	//
	// ***
	DeletionProtection pulumi.BoolPtrInput
	// Description of the Elasticsearch cluster.
	Description pulumi.StringPtrInput
	// Deployment environment of the Elasticsearch cluster. Can be either `PRESTABLE` or `PRODUCTION`.
	Environment pulumi.StringPtrInput
	// The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// Aggregated health of the cluster. Can be either `ALIVE`, `DEGRADED`, `DEAD` or `HEALTH_UNKNOWN`.
	// For more information see `health` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
	Health pulumi.StringPtrInput
	// A host of the Elasticsearch cluster. The structure is documented below.
	//
	// ***
	Hosts MdbElasticsearchClusterHostArrayInput
	// A set of key/value label pairs to assign to the Elasticsearch cluster.
	Labels            pulumi.StringMapInput
	MaintenanceWindow MdbElasticsearchClusterMaintenanceWindowPtrInput
	// Name of the Elasticsearch cluster. Provided by the client when the cluster is created.
	Name pulumi.StringPtrInput
	// ID of the network, to which the Elasticsearch cluster belongs.
	NetworkId pulumi.StringPtrInput
	// A set of ids of security groups assigned to hosts of the cluster.
	SecurityGroupIds pulumi.StringArrayInput
	// ID of the service account authorized for this cluster.
	ServiceAccountId pulumi.StringPtrInput
	// Status of the cluster. Can be either `CREATING`, `STARTING`, `RUNNING`, `UPDATING`, `STOPPING`, `STOPPED`, `ERROR` or `STATUS_UNKNOWN`.
	// For more information see `status` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
	Status pulumi.StringPtrInput
}

func (MdbElasticsearchClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*mdbElasticsearchClusterState)(nil)).Elem()
}

type mdbElasticsearchClusterArgs struct {
	// Configuration of the Elasticsearch cluster. The structure is documented below.
	Config MdbElasticsearchClusterConfig `pulumi:"config"`
	// Inhibits deletion of the cluster.  Can be either `true` or `false`.
	//
	// ***
	DeletionProtection *bool `pulumi:"deletionProtection"`
	// Description of the Elasticsearch cluster.
	Description *string `pulumi:"description"`
	// Deployment environment of the Elasticsearch cluster. Can be either `PRESTABLE` or `PRODUCTION`.
	Environment string `pulumi:"environment"`
	// The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
	FolderId *string `pulumi:"folderId"`
	// A host of the Elasticsearch cluster. The structure is documented below.
	//
	// ***
	Hosts []MdbElasticsearchClusterHost `pulumi:"hosts"`
	// A set of key/value label pairs to assign to the Elasticsearch cluster.
	Labels            map[string]string                         `pulumi:"labels"`
	MaintenanceWindow *MdbElasticsearchClusterMaintenanceWindow `pulumi:"maintenanceWindow"`
	// Name of the Elasticsearch cluster. Provided by the client when the cluster is created.
	Name *string `pulumi:"name"`
	// ID of the network, to which the Elasticsearch cluster belongs.
	NetworkId string `pulumi:"networkId"`
	// A set of ids of security groups assigned to hosts of the cluster.
	SecurityGroupIds []string `pulumi:"securityGroupIds"`
	// ID of the service account authorized for this cluster.
	ServiceAccountId *string `pulumi:"serviceAccountId"`
}

// The set of arguments for constructing a MdbElasticsearchCluster resource.
type MdbElasticsearchClusterArgs struct {
	// Configuration of the Elasticsearch cluster. The structure is documented below.
	Config MdbElasticsearchClusterConfigInput
	// Inhibits deletion of the cluster.  Can be either `true` or `false`.
	//
	// ***
	DeletionProtection pulumi.BoolPtrInput
	// Description of the Elasticsearch cluster.
	Description pulumi.StringPtrInput
	// Deployment environment of the Elasticsearch cluster. Can be either `PRESTABLE` or `PRODUCTION`.
	Environment pulumi.StringInput
	// The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
	FolderId pulumi.StringPtrInput
	// A host of the Elasticsearch cluster. The structure is documented below.
	//
	// ***
	Hosts MdbElasticsearchClusterHostArrayInput
	// A set of key/value label pairs to assign to the Elasticsearch cluster.
	Labels            pulumi.StringMapInput
	MaintenanceWindow MdbElasticsearchClusterMaintenanceWindowPtrInput
	// Name of the Elasticsearch cluster. Provided by the client when the cluster is created.
	Name pulumi.StringPtrInput
	// ID of the network, to which the Elasticsearch cluster belongs.
	NetworkId pulumi.StringInput
	// A set of ids of security groups assigned to hosts of the cluster.
	SecurityGroupIds pulumi.StringArrayInput
	// ID of the service account authorized for this cluster.
	ServiceAccountId pulumi.StringPtrInput
}

func (MdbElasticsearchClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*mdbElasticsearchClusterArgs)(nil)).Elem()
}

type MdbElasticsearchClusterInput interface {
	pulumi.Input

	ToMdbElasticsearchClusterOutput() MdbElasticsearchClusterOutput
	ToMdbElasticsearchClusterOutputWithContext(ctx context.Context) MdbElasticsearchClusterOutput
}

func (*MdbElasticsearchCluster) ElementType() reflect.Type {
	return reflect.TypeOf((**MdbElasticsearchCluster)(nil)).Elem()
}

func (i *MdbElasticsearchCluster) ToMdbElasticsearchClusterOutput() MdbElasticsearchClusterOutput {
	return i.ToMdbElasticsearchClusterOutputWithContext(context.Background())
}

func (i *MdbElasticsearchCluster) ToMdbElasticsearchClusterOutputWithContext(ctx context.Context) MdbElasticsearchClusterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbElasticsearchClusterOutput)
}

// MdbElasticsearchClusterArrayInput is an input type that accepts MdbElasticsearchClusterArray and MdbElasticsearchClusterArrayOutput values.
// You can construct a concrete instance of `MdbElasticsearchClusterArrayInput` via:
//
//	MdbElasticsearchClusterArray{ MdbElasticsearchClusterArgs{...} }
type MdbElasticsearchClusterArrayInput interface {
	pulumi.Input

	ToMdbElasticsearchClusterArrayOutput() MdbElasticsearchClusterArrayOutput
	ToMdbElasticsearchClusterArrayOutputWithContext(context.Context) MdbElasticsearchClusterArrayOutput
}

type MdbElasticsearchClusterArray []MdbElasticsearchClusterInput

func (MdbElasticsearchClusterArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MdbElasticsearchCluster)(nil)).Elem()
}

func (i MdbElasticsearchClusterArray) ToMdbElasticsearchClusterArrayOutput() MdbElasticsearchClusterArrayOutput {
	return i.ToMdbElasticsearchClusterArrayOutputWithContext(context.Background())
}

func (i MdbElasticsearchClusterArray) ToMdbElasticsearchClusterArrayOutputWithContext(ctx context.Context) MdbElasticsearchClusterArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbElasticsearchClusterArrayOutput)
}

// MdbElasticsearchClusterMapInput is an input type that accepts MdbElasticsearchClusterMap and MdbElasticsearchClusterMapOutput values.
// You can construct a concrete instance of `MdbElasticsearchClusterMapInput` via:
//
//	MdbElasticsearchClusterMap{ "key": MdbElasticsearchClusterArgs{...} }
type MdbElasticsearchClusterMapInput interface {
	pulumi.Input

	ToMdbElasticsearchClusterMapOutput() MdbElasticsearchClusterMapOutput
	ToMdbElasticsearchClusterMapOutputWithContext(context.Context) MdbElasticsearchClusterMapOutput
}

type MdbElasticsearchClusterMap map[string]MdbElasticsearchClusterInput

func (MdbElasticsearchClusterMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MdbElasticsearchCluster)(nil)).Elem()
}

func (i MdbElasticsearchClusterMap) ToMdbElasticsearchClusterMapOutput() MdbElasticsearchClusterMapOutput {
	return i.ToMdbElasticsearchClusterMapOutputWithContext(context.Background())
}

func (i MdbElasticsearchClusterMap) ToMdbElasticsearchClusterMapOutputWithContext(ctx context.Context) MdbElasticsearchClusterMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MdbElasticsearchClusterMapOutput)
}

type MdbElasticsearchClusterOutput struct{ *pulumi.OutputState }

func (MdbElasticsearchClusterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**MdbElasticsearchCluster)(nil)).Elem()
}

func (o MdbElasticsearchClusterOutput) ToMdbElasticsearchClusterOutput() MdbElasticsearchClusterOutput {
	return o
}

func (o MdbElasticsearchClusterOutput) ToMdbElasticsearchClusterOutputWithContext(ctx context.Context) MdbElasticsearchClusterOutput {
	return o
}

// Configuration of the Elasticsearch cluster. The structure is documented below.
func (o MdbElasticsearchClusterOutput) Config() MdbElasticsearchClusterConfigOutput {
	return o.ApplyT(func(v *MdbElasticsearchCluster) MdbElasticsearchClusterConfigOutput { return v.Config }).(MdbElasticsearchClusterConfigOutput)
}

// Creation timestamp of the key.
func (o MdbElasticsearchClusterOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbElasticsearchCluster) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// Inhibits deletion of the cluster.  Can be either `true` or `false`.
//
// ***
func (o MdbElasticsearchClusterOutput) DeletionProtection() pulumi.BoolOutput {
	return o.ApplyT(func(v *MdbElasticsearchCluster) pulumi.BoolOutput { return v.DeletionProtection }).(pulumi.BoolOutput)
}

// Description of the Elasticsearch cluster.
func (o MdbElasticsearchClusterOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MdbElasticsearchCluster) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Deployment environment of the Elasticsearch cluster. Can be either `PRESTABLE` or `PRODUCTION`.
func (o MdbElasticsearchClusterOutput) Environment() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbElasticsearchCluster) pulumi.StringOutput { return v.Environment }).(pulumi.StringOutput)
}

// The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
func (o MdbElasticsearchClusterOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbElasticsearchCluster) pulumi.StringOutput { return v.FolderId }).(pulumi.StringOutput)
}

// Aggregated health of the cluster. Can be either `ALIVE`, `DEGRADED`, `DEAD` or `HEALTH_UNKNOWN`.
// For more information see `health` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
func (o MdbElasticsearchClusterOutput) Health() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbElasticsearchCluster) pulumi.StringOutput { return v.Health }).(pulumi.StringOutput)
}

// A host of the Elasticsearch cluster. The structure is documented below.
//
// ***
func (o MdbElasticsearchClusterOutput) Hosts() MdbElasticsearchClusterHostArrayOutput {
	return o.ApplyT(func(v *MdbElasticsearchCluster) MdbElasticsearchClusterHostArrayOutput { return v.Hosts }).(MdbElasticsearchClusterHostArrayOutput)
}

// A set of key/value label pairs to assign to the Elasticsearch cluster.
func (o MdbElasticsearchClusterOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v *MdbElasticsearchCluster) pulumi.StringMapOutput { return v.Labels }).(pulumi.StringMapOutput)
}

func (o MdbElasticsearchClusterOutput) MaintenanceWindow() MdbElasticsearchClusterMaintenanceWindowOutput {
	return o.ApplyT(func(v *MdbElasticsearchCluster) MdbElasticsearchClusterMaintenanceWindowOutput {
		return v.MaintenanceWindow
	}).(MdbElasticsearchClusterMaintenanceWindowOutput)
}

// Name of the Elasticsearch cluster. Provided by the client when the cluster is created.
func (o MdbElasticsearchClusterOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbElasticsearchCluster) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// ID of the network, to which the Elasticsearch cluster belongs.
func (o MdbElasticsearchClusterOutput) NetworkId() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbElasticsearchCluster) pulumi.StringOutput { return v.NetworkId }).(pulumi.StringOutput)
}

// A set of ids of security groups assigned to hosts of the cluster.
func (o MdbElasticsearchClusterOutput) SecurityGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *MdbElasticsearchCluster) pulumi.StringArrayOutput { return v.SecurityGroupIds }).(pulumi.StringArrayOutput)
}

// ID of the service account authorized for this cluster.
func (o MdbElasticsearchClusterOutput) ServiceAccountId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *MdbElasticsearchCluster) pulumi.StringPtrOutput { return v.ServiceAccountId }).(pulumi.StringPtrOutput)
}

// Status of the cluster. Can be either `CREATING`, `STARTING`, `RUNNING`, `UPDATING`, `STOPPING`, `STOPPED`, `ERROR` or `STATUS_UNKNOWN`.
// For more information see `status` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
func (o MdbElasticsearchClusterOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *MdbElasticsearchCluster) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type MdbElasticsearchClusterArrayOutput struct{ *pulumi.OutputState }

func (MdbElasticsearchClusterArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MdbElasticsearchCluster)(nil)).Elem()
}

func (o MdbElasticsearchClusterArrayOutput) ToMdbElasticsearchClusterArrayOutput() MdbElasticsearchClusterArrayOutput {
	return o
}

func (o MdbElasticsearchClusterArrayOutput) ToMdbElasticsearchClusterArrayOutputWithContext(ctx context.Context) MdbElasticsearchClusterArrayOutput {
	return o
}

func (o MdbElasticsearchClusterArrayOutput) Index(i pulumi.IntInput) MdbElasticsearchClusterOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *MdbElasticsearchCluster {
		return vs[0].([]*MdbElasticsearchCluster)[vs[1].(int)]
	}).(MdbElasticsearchClusterOutput)
}

type MdbElasticsearchClusterMapOutput struct{ *pulumi.OutputState }

func (MdbElasticsearchClusterMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MdbElasticsearchCluster)(nil)).Elem()
}

func (o MdbElasticsearchClusterMapOutput) ToMdbElasticsearchClusterMapOutput() MdbElasticsearchClusterMapOutput {
	return o
}

func (o MdbElasticsearchClusterMapOutput) ToMdbElasticsearchClusterMapOutputWithContext(ctx context.Context) MdbElasticsearchClusterMapOutput {
	return o
}

func (o MdbElasticsearchClusterMapOutput) MapIndex(k pulumi.StringInput) MdbElasticsearchClusterOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *MdbElasticsearchCluster {
		return vs[0].(map[string]*MdbElasticsearchCluster)[vs[1].(string)]
	}).(MdbElasticsearchClusterOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MdbElasticsearchClusterInput)(nil)).Elem(), &MdbElasticsearchCluster{})
	pulumi.RegisterInputType(reflect.TypeOf((*MdbElasticsearchClusterArrayInput)(nil)).Elem(), MdbElasticsearchClusterArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*MdbElasticsearchClusterMapInput)(nil)).Elem(), MdbElasticsearchClusterMap{})
	pulumi.RegisterOutputType(MdbElasticsearchClusterOutput{})
	pulumi.RegisterOutputType(MdbElasticsearchClusterArrayOutput{})
	pulumi.RegisterOutputType(MdbElasticsearchClusterMapOutput{})
}
