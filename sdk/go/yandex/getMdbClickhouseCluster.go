// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupMdbClickhouseCluster(ctx *pulumi.Context, args *LookupMdbClickhouseClusterArgs, opts ...pulumi.InvokeOption) (*LookupMdbClickhouseClusterResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupMdbClickhouseClusterResult
	err := ctx.Invoke("yandex:index/getMdbClickhouseCluster:getMdbClickhouseCluster", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getMdbClickhouseCluster.
type LookupMdbClickhouseClusterArgs struct {
	Access                *GetMdbClickhouseClusterAccess            `pulumi:"access"`
	AdminPassword         *string                                   `pulumi:"adminPassword"`
	BackupWindowStart     *GetMdbClickhouseClusterBackupWindowStart `pulumi:"backupWindowStart"`
	Clickhouse            *GetMdbClickhouseClusterClickhouse        `pulumi:"clickhouse"`
	CloudStorage          *GetMdbClickhouseClusterCloudStorage      `pulumi:"cloudStorage"`
	ClusterId             *string                                   `pulumi:"clusterId"`
	CopySchemaOnNewHosts  *bool                                     `pulumi:"copySchemaOnNewHosts"`
	CreatedAt             *string                                   `pulumi:"createdAt"`
	Databases             []GetMdbClickhouseClusterDatabase         `pulumi:"databases"`
	DeletionProtection    *bool                                     `pulumi:"deletionProtection"`
	Description           *string                                   `pulumi:"description"`
	EmbeddedKeeper        *bool                                     `pulumi:"embeddedKeeper"`
	Environment           *string                                   `pulumi:"environment"`
	FolderId              *string                                   `pulumi:"folderId"`
	FormatSchemas         []GetMdbClickhouseClusterFormatSchema     `pulumi:"formatSchemas"`
	Health                *string                                   `pulumi:"health"`
	Hosts                 []GetMdbClickhouseClusterHost             `pulumi:"hosts"`
	Labels                map[string]string                         `pulumi:"labels"`
	MaintenanceWindow     *GetMdbClickhouseClusterMaintenanceWindow `pulumi:"maintenanceWindow"`
	MlModels              []GetMdbClickhouseClusterMlModel          `pulumi:"mlModels"`
	Name                  *string                                   `pulumi:"name"`
	NetworkId             *string                                   `pulumi:"networkId"`
	SecurityGroupIds      []string                                  `pulumi:"securityGroupIds"`
	ServiceAccountId      *string                                   `pulumi:"serviceAccountId"`
	ShardGroups           []GetMdbClickhouseClusterShardGroup       `pulumi:"shardGroups"`
	Shards                []GetMdbClickhouseClusterShard            `pulumi:"shards"`
	SqlDatabaseManagement *bool                                     `pulumi:"sqlDatabaseManagement"`
	SqlUserManagement     *bool                                     `pulumi:"sqlUserManagement"`
	Status                *string                                   `pulumi:"status"`
	Users                 []GetMdbClickhouseClusterUser             `pulumi:"users"`
	Version               *string                                   `pulumi:"version"`
	Zookeeper             *GetMdbClickhouseClusterZookeeper         `pulumi:"zookeeper"`
}

// A collection of values returned by getMdbClickhouseCluster.
type LookupMdbClickhouseClusterResult struct {
	Access               GetMdbClickhouseClusterAccess            `pulumi:"access"`
	AdminPassword        *string                                  `pulumi:"adminPassword"`
	BackupWindowStart    GetMdbClickhouseClusterBackupWindowStart `pulumi:"backupWindowStart"`
	Clickhouse           GetMdbClickhouseClusterClickhouse        `pulumi:"clickhouse"`
	CloudStorage         GetMdbClickhouseClusterCloudStorage      `pulumi:"cloudStorage"`
	ClusterId            string                                   `pulumi:"clusterId"`
	CopySchemaOnNewHosts *bool                                    `pulumi:"copySchemaOnNewHosts"`
	CreatedAt            string                                   `pulumi:"createdAt"`
	Databases            []GetMdbClickhouseClusterDatabase        `pulumi:"databases"`
	DeletionProtection   bool                                     `pulumi:"deletionProtection"`
	Description          *string                                  `pulumi:"description"`
	EmbeddedKeeper       bool                                     `pulumi:"embeddedKeeper"`
	Environment          *string                                  `pulumi:"environment"`
	FolderId             string                                   `pulumi:"folderId"`
	FormatSchemas        []GetMdbClickhouseClusterFormatSchema    `pulumi:"formatSchemas"`
	Health               string                                   `pulumi:"health"`
	Hosts                []GetMdbClickhouseClusterHost            `pulumi:"hosts"`
	// The provider-assigned unique ID for this managed resource.
	Id                    string                                   `pulumi:"id"`
	Labels                map[string]string                        `pulumi:"labels"`
	MaintenanceWindow     GetMdbClickhouseClusterMaintenanceWindow `pulumi:"maintenanceWindow"`
	MlModels              []GetMdbClickhouseClusterMlModel         `pulumi:"mlModels"`
	Name                  *string                                  `pulumi:"name"`
	NetworkId             *string                                  `pulumi:"networkId"`
	SecurityGroupIds      []string                                 `pulumi:"securityGroupIds"`
	ServiceAccountId      string                                   `pulumi:"serviceAccountId"`
	ShardGroups           []GetMdbClickhouseClusterShardGroup      `pulumi:"shardGroups"`
	Shards                []GetMdbClickhouseClusterShard           `pulumi:"shards"`
	SqlDatabaseManagement bool                                     `pulumi:"sqlDatabaseManagement"`
	SqlUserManagement     bool                                     `pulumi:"sqlUserManagement"`
	Status                string                                   `pulumi:"status"`
	Users                 []GetMdbClickhouseClusterUser            `pulumi:"users"`
	Version               string                                   `pulumi:"version"`
	Zookeeper             GetMdbClickhouseClusterZookeeper         `pulumi:"zookeeper"`
}

func LookupMdbClickhouseClusterOutput(ctx *pulumi.Context, args LookupMdbClickhouseClusterOutputArgs, opts ...pulumi.InvokeOption) LookupMdbClickhouseClusterResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupMdbClickhouseClusterResult, error) {
			args := v.(LookupMdbClickhouseClusterArgs)
			r, err := LookupMdbClickhouseCluster(ctx, &args, opts...)
			var s LookupMdbClickhouseClusterResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupMdbClickhouseClusterResultOutput)
}

// A collection of arguments for invoking getMdbClickhouseCluster.
type LookupMdbClickhouseClusterOutputArgs struct {
	Access                GetMdbClickhouseClusterAccessPtrInput            `pulumi:"access"`
	AdminPassword         pulumi.StringPtrInput                            `pulumi:"adminPassword"`
	BackupWindowStart     GetMdbClickhouseClusterBackupWindowStartPtrInput `pulumi:"backupWindowStart"`
	Clickhouse            GetMdbClickhouseClusterClickhousePtrInput        `pulumi:"clickhouse"`
	CloudStorage          GetMdbClickhouseClusterCloudStoragePtrInput      `pulumi:"cloudStorage"`
	ClusterId             pulumi.StringPtrInput                            `pulumi:"clusterId"`
	CopySchemaOnNewHosts  pulumi.BoolPtrInput                              `pulumi:"copySchemaOnNewHosts"`
	CreatedAt             pulumi.StringPtrInput                            `pulumi:"createdAt"`
	Databases             GetMdbClickhouseClusterDatabaseArrayInput        `pulumi:"databases"`
	DeletionProtection    pulumi.BoolPtrInput                              `pulumi:"deletionProtection"`
	Description           pulumi.StringPtrInput                            `pulumi:"description"`
	EmbeddedKeeper        pulumi.BoolPtrInput                              `pulumi:"embeddedKeeper"`
	Environment           pulumi.StringPtrInput                            `pulumi:"environment"`
	FolderId              pulumi.StringPtrInput                            `pulumi:"folderId"`
	FormatSchemas         GetMdbClickhouseClusterFormatSchemaArrayInput    `pulumi:"formatSchemas"`
	Health                pulumi.StringPtrInput                            `pulumi:"health"`
	Hosts                 GetMdbClickhouseClusterHostArrayInput            `pulumi:"hosts"`
	Labels                pulumi.StringMapInput                            `pulumi:"labels"`
	MaintenanceWindow     GetMdbClickhouseClusterMaintenanceWindowPtrInput `pulumi:"maintenanceWindow"`
	MlModels              GetMdbClickhouseClusterMlModelArrayInput         `pulumi:"mlModels"`
	Name                  pulumi.StringPtrInput                            `pulumi:"name"`
	NetworkId             pulumi.StringPtrInput                            `pulumi:"networkId"`
	SecurityGroupIds      pulumi.StringArrayInput                          `pulumi:"securityGroupIds"`
	ServiceAccountId      pulumi.StringPtrInput                            `pulumi:"serviceAccountId"`
	ShardGroups           GetMdbClickhouseClusterShardGroupArrayInput      `pulumi:"shardGroups"`
	Shards                GetMdbClickhouseClusterShardArrayInput           `pulumi:"shards"`
	SqlDatabaseManagement pulumi.BoolPtrInput                              `pulumi:"sqlDatabaseManagement"`
	SqlUserManagement     pulumi.BoolPtrInput                              `pulumi:"sqlUserManagement"`
	Status                pulumi.StringPtrInput                            `pulumi:"status"`
	Users                 GetMdbClickhouseClusterUserArrayInput            `pulumi:"users"`
	Version               pulumi.StringPtrInput                            `pulumi:"version"`
	Zookeeper             GetMdbClickhouseClusterZookeeperPtrInput         `pulumi:"zookeeper"`
}

func (LookupMdbClickhouseClusterOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMdbClickhouseClusterArgs)(nil)).Elem()
}

// A collection of values returned by getMdbClickhouseCluster.
type LookupMdbClickhouseClusterResultOutput struct{ *pulumi.OutputState }

func (LookupMdbClickhouseClusterResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMdbClickhouseClusterResult)(nil)).Elem()
}

func (o LookupMdbClickhouseClusterResultOutput) ToLookupMdbClickhouseClusterResultOutput() LookupMdbClickhouseClusterResultOutput {
	return o
}

func (o LookupMdbClickhouseClusterResultOutput) ToLookupMdbClickhouseClusterResultOutputWithContext(ctx context.Context) LookupMdbClickhouseClusterResultOutput {
	return o
}

func (o LookupMdbClickhouseClusterResultOutput) Access() GetMdbClickhouseClusterAccessOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) GetMdbClickhouseClusterAccess { return v.Access }).(GetMdbClickhouseClusterAccessOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) AdminPassword() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) *string { return v.AdminPassword }).(pulumi.StringPtrOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) BackupWindowStart() GetMdbClickhouseClusterBackupWindowStartOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) GetMdbClickhouseClusterBackupWindowStart {
		return v.BackupWindowStart
	}).(GetMdbClickhouseClusterBackupWindowStartOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) Clickhouse() GetMdbClickhouseClusterClickhouseOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) GetMdbClickhouseClusterClickhouse { return v.Clickhouse }).(GetMdbClickhouseClusterClickhouseOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) CloudStorage() GetMdbClickhouseClusterCloudStorageOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) GetMdbClickhouseClusterCloudStorage { return v.CloudStorage }).(GetMdbClickhouseClusterCloudStorageOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) string { return v.ClusterId }).(pulumi.StringOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) CopySchemaOnNewHosts() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) *bool { return v.CopySchemaOnNewHosts }).(pulumi.BoolPtrOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) Databases() GetMdbClickhouseClusterDatabaseArrayOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) []GetMdbClickhouseClusterDatabase { return v.Databases }).(GetMdbClickhouseClusterDatabaseArrayOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) DeletionProtection() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) bool { return v.DeletionProtection }).(pulumi.BoolOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) *string { return v.Description }).(pulumi.StringPtrOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) EmbeddedKeeper() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) bool { return v.EmbeddedKeeper }).(pulumi.BoolOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) Environment() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) *string { return v.Environment }).(pulumi.StringPtrOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) string { return v.FolderId }).(pulumi.StringOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) FormatSchemas() GetMdbClickhouseClusterFormatSchemaArrayOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) []GetMdbClickhouseClusterFormatSchema { return v.FormatSchemas }).(GetMdbClickhouseClusterFormatSchemaArrayOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) Health() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) string { return v.Health }).(pulumi.StringOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) Hosts() GetMdbClickhouseClusterHostArrayOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) []GetMdbClickhouseClusterHost { return v.Hosts }).(GetMdbClickhouseClusterHostArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupMdbClickhouseClusterResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) MaintenanceWindow() GetMdbClickhouseClusterMaintenanceWindowOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) GetMdbClickhouseClusterMaintenanceWindow {
		return v.MaintenanceWindow
	}).(GetMdbClickhouseClusterMaintenanceWindowOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) MlModels() GetMdbClickhouseClusterMlModelArrayOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) []GetMdbClickhouseClusterMlModel { return v.MlModels }).(GetMdbClickhouseClusterMlModelArrayOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) NetworkId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) *string { return v.NetworkId }).(pulumi.StringPtrOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) SecurityGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) []string { return v.SecurityGroupIds }).(pulumi.StringArrayOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) ServiceAccountId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) string { return v.ServiceAccountId }).(pulumi.StringOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) ShardGroups() GetMdbClickhouseClusterShardGroupArrayOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) []GetMdbClickhouseClusterShardGroup { return v.ShardGroups }).(GetMdbClickhouseClusterShardGroupArrayOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) Shards() GetMdbClickhouseClusterShardArrayOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) []GetMdbClickhouseClusterShard { return v.Shards }).(GetMdbClickhouseClusterShardArrayOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) SqlDatabaseManagement() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) bool { return v.SqlDatabaseManagement }).(pulumi.BoolOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) SqlUserManagement() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) bool { return v.SqlUserManagement }).(pulumi.BoolOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) string { return v.Status }).(pulumi.StringOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) Users() GetMdbClickhouseClusterUserArrayOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) []GetMdbClickhouseClusterUser { return v.Users }).(GetMdbClickhouseClusterUserArrayOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) Version() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) string { return v.Version }).(pulumi.StringOutput)
}

func (o LookupMdbClickhouseClusterResultOutput) Zookeeper() GetMdbClickhouseClusterZookeeperOutput {
	return o.ApplyT(func(v LookupMdbClickhouseClusterResult) GetMdbClickhouseClusterZookeeper { return v.Zookeeper }).(GetMdbClickhouseClusterZookeeperOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupMdbClickhouseClusterResultOutput{})
}
