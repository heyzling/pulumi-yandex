// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupKubernetesCluster(ctx *pulumi.Context, args *LookupKubernetesClusterArgs, opts ...pulumi.InvokeOption) (*LookupKubernetesClusterResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupKubernetesClusterResult
	err := ctx.Invoke("yandex:index/getKubernetesCluster:getKubernetesCluster", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getKubernetesCluster.
type LookupKubernetesClusterArgs struct {
	ClusterId *string `pulumi:"clusterId"`
	FolderId  *string `pulumi:"folderId"`
	Name      *string `pulumi:"name"`
}

// A collection of values returned by getKubernetesCluster.
type LookupKubernetesClusterResult struct {
	ClusterId        string `pulumi:"clusterId"`
	ClusterIpv4Range string `pulumi:"clusterIpv4Range"`
	ClusterIpv6Range string `pulumi:"clusterIpv6Range"`
	CreatedAt        string `pulumi:"createdAt"`
	Description      string `pulumi:"description"`
	FolderId         string `pulumi:"folderId"`
	Health           string `pulumi:"health"`
	// The provider-assigned unique ID for this managed resource.
	Id                     string                                      `pulumi:"id"`
	KmsProviders           []GetKubernetesClusterKmsProvider           `pulumi:"kmsProviders"`
	Labels                 map[string]string                           `pulumi:"labels"`
	LogGroupId             string                                      `pulumi:"logGroupId"`
	Masters                []GetKubernetesClusterMaster                `pulumi:"masters"`
	Name                   string                                      `pulumi:"name"`
	NetworkId              string                                      `pulumi:"networkId"`
	NetworkImplementations []GetKubernetesClusterNetworkImplementation `pulumi:"networkImplementations"`
	NetworkPolicyProvider  string                                      `pulumi:"networkPolicyProvider"`
	NodeIpv4CidrMaskSize   int                                         `pulumi:"nodeIpv4CidrMaskSize"`
	NodeServiceAccountId   string                                      `pulumi:"nodeServiceAccountId"`
	ReleaseChannel         string                                      `pulumi:"releaseChannel"`
	ServiceAccountId       string                                      `pulumi:"serviceAccountId"`
	ServiceIpv4Range       string                                      `pulumi:"serviceIpv4Range"`
	ServiceIpv6Range       string                                      `pulumi:"serviceIpv6Range"`
	Status                 string                                      `pulumi:"status"`
}

func LookupKubernetesClusterOutput(ctx *pulumi.Context, args LookupKubernetesClusterOutputArgs, opts ...pulumi.InvokeOption) LookupKubernetesClusterResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupKubernetesClusterResult, error) {
			args := v.(LookupKubernetesClusterArgs)
			r, err := LookupKubernetesCluster(ctx, &args, opts...)
			var s LookupKubernetesClusterResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupKubernetesClusterResultOutput)
}

// A collection of arguments for invoking getKubernetesCluster.
type LookupKubernetesClusterOutputArgs struct {
	ClusterId pulumi.StringPtrInput `pulumi:"clusterId"`
	FolderId  pulumi.StringPtrInput `pulumi:"folderId"`
	Name      pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupKubernetesClusterOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupKubernetesClusterArgs)(nil)).Elem()
}

// A collection of values returned by getKubernetesCluster.
type LookupKubernetesClusterResultOutput struct{ *pulumi.OutputState }

func (LookupKubernetesClusterResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupKubernetesClusterResult)(nil)).Elem()
}

func (o LookupKubernetesClusterResultOutput) ToLookupKubernetesClusterResultOutput() LookupKubernetesClusterResultOutput {
	return o
}

func (o LookupKubernetesClusterResultOutput) ToLookupKubernetesClusterResultOutputWithContext(ctx context.Context) LookupKubernetesClusterResultOutput {
	return o
}

func (o LookupKubernetesClusterResultOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.ClusterId }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) ClusterIpv4Range() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.ClusterIpv4Range }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) ClusterIpv6Range() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.ClusterIpv6Range }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.FolderId }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) Health() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.Health }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupKubernetesClusterResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) KmsProviders() GetKubernetesClusterKmsProviderArrayOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) []GetKubernetesClusterKmsProvider { return v.KmsProviders }).(GetKubernetesClusterKmsProviderArrayOutput)
}

func (o LookupKubernetesClusterResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupKubernetesClusterResultOutput) LogGroupId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.LogGroupId }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) Masters() GetKubernetesClusterMasterArrayOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) []GetKubernetesClusterMaster { return v.Masters }).(GetKubernetesClusterMasterArrayOutput)
}

func (o LookupKubernetesClusterResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) NetworkId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.NetworkId }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) NetworkImplementations() GetKubernetesClusterNetworkImplementationArrayOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) []GetKubernetesClusterNetworkImplementation {
		return v.NetworkImplementations
	}).(GetKubernetesClusterNetworkImplementationArrayOutput)
}

func (o LookupKubernetesClusterResultOutput) NetworkPolicyProvider() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.NetworkPolicyProvider }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) NodeIpv4CidrMaskSize() pulumi.IntOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) int { return v.NodeIpv4CidrMaskSize }).(pulumi.IntOutput)
}

func (o LookupKubernetesClusterResultOutput) NodeServiceAccountId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.NodeServiceAccountId }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) ReleaseChannel() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.ReleaseChannel }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) ServiceAccountId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.ServiceAccountId }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) ServiceIpv4Range() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.ServiceIpv4Range }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) ServiceIpv6Range() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.ServiceIpv6Range }).(pulumi.StringOutput)
}

func (o LookupKubernetesClusterResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKubernetesClusterResult) string { return v.Status }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupKubernetesClusterResultOutput{})
}