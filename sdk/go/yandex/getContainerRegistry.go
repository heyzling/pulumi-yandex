// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupContainerRegistry(ctx *pulumi.Context, args *LookupContainerRegistryArgs, opts ...pulumi.InvokeOption) (*LookupContainerRegistryResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupContainerRegistryResult
	err := ctx.Invoke("yandex:index/getContainerRegistry:getContainerRegistry", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getContainerRegistry.
type LookupContainerRegistryArgs struct {
	FolderId   *string           `pulumi:"folderId"`
	Labels     map[string]string `pulumi:"labels"`
	Name       *string           `pulumi:"name"`
	RegistryId *string           `pulumi:"registryId"`
}

// A collection of values returned by getContainerRegistry.
type LookupContainerRegistryResult struct {
	CreatedAt string `pulumi:"createdAt"`
	FolderId  string `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id         string            `pulumi:"id"`
	Labels     map[string]string `pulumi:"labels"`
	Name       string            `pulumi:"name"`
	RegistryId string            `pulumi:"registryId"`
	Status     string            `pulumi:"status"`
}

func LookupContainerRegistryOutput(ctx *pulumi.Context, args LookupContainerRegistryOutputArgs, opts ...pulumi.InvokeOption) LookupContainerRegistryResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupContainerRegistryResult, error) {
			args := v.(LookupContainerRegistryArgs)
			r, err := LookupContainerRegistry(ctx, &args, opts...)
			var s LookupContainerRegistryResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupContainerRegistryResultOutput)
}

// A collection of arguments for invoking getContainerRegistry.
type LookupContainerRegistryOutputArgs struct {
	FolderId   pulumi.StringPtrInput `pulumi:"folderId"`
	Labels     pulumi.StringMapInput `pulumi:"labels"`
	Name       pulumi.StringPtrInput `pulumi:"name"`
	RegistryId pulumi.StringPtrInput `pulumi:"registryId"`
}

func (LookupContainerRegistryOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupContainerRegistryArgs)(nil)).Elem()
}

// A collection of values returned by getContainerRegistry.
type LookupContainerRegistryResultOutput struct{ *pulumi.OutputState }

func (LookupContainerRegistryResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupContainerRegistryResult)(nil)).Elem()
}

func (o LookupContainerRegistryResultOutput) ToLookupContainerRegistryResultOutput() LookupContainerRegistryResultOutput {
	return o
}

func (o LookupContainerRegistryResultOutput) ToLookupContainerRegistryResultOutputWithContext(ctx context.Context) LookupContainerRegistryResultOutput {
	return o
}

func (o LookupContainerRegistryResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerRegistryResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupContainerRegistryResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerRegistryResult) string { return v.FolderId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupContainerRegistryResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerRegistryResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupContainerRegistryResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupContainerRegistryResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupContainerRegistryResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerRegistryResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupContainerRegistryResultOutput) RegistryId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerRegistryResult) string { return v.RegistryId }).(pulumi.StringOutput)
}

func (o LookupContainerRegistryResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupContainerRegistryResult) string { return v.Status }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupContainerRegistryResultOutput{})
}