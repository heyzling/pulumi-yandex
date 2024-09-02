// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupIotCoreBroker(ctx *pulumi.Context, args *LookupIotCoreBrokerArgs, opts ...pulumi.InvokeOption) (*LookupIotCoreBrokerResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupIotCoreBrokerResult
	err := ctx.Invoke("yandex:index/getIotCoreBroker:getIotCoreBroker", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getIotCoreBroker.
type LookupIotCoreBrokerArgs struct {
	BrokerId *string `pulumi:"brokerId"`
	FolderId *string `pulumi:"folderId"`
	Name     *string `pulumi:"name"`
}

// A collection of values returned by getIotCoreBroker.
type LookupIotCoreBrokerResult struct {
	BrokerId     *string  `pulumi:"brokerId"`
	Certificates []string `pulumi:"certificates"`
	CreatedAt    string   `pulumi:"createdAt"`
	Description  string   `pulumi:"description"`
	FolderId     *string  `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id         string                      `pulumi:"id"`
	Labels     map[string]string           `pulumi:"labels"`
	LogOptions []GetIotCoreBrokerLogOption `pulumi:"logOptions"`
	Name       *string                     `pulumi:"name"`
}

func LookupIotCoreBrokerOutput(ctx *pulumi.Context, args LookupIotCoreBrokerOutputArgs, opts ...pulumi.InvokeOption) LookupIotCoreBrokerResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupIotCoreBrokerResult, error) {
			args := v.(LookupIotCoreBrokerArgs)
			r, err := LookupIotCoreBroker(ctx, &args, opts...)
			var s LookupIotCoreBrokerResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupIotCoreBrokerResultOutput)
}

// A collection of arguments for invoking getIotCoreBroker.
type LookupIotCoreBrokerOutputArgs struct {
	BrokerId pulumi.StringPtrInput `pulumi:"brokerId"`
	FolderId pulumi.StringPtrInput `pulumi:"folderId"`
	Name     pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupIotCoreBrokerOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIotCoreBrokerArgs)(nil)).Elem()
}

// A collection of values returned by getIotCoreBroker.
type LookupIotCoreBrokerResultOutput struct{ *pulumi.OutputState }

func (LookupIotCoreBrokerResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIotCoreBrokerResult)(nil)).Elem()
}

func (o LookupIotCoreBrokerResultOutput) ToLookupIotCoreBrokerResultOutput() LookupIotCoreBrokerResultOutput {
	return o
}

func (o LookupIotCoreBrokerResultOutput) ToLookupIotCoreBrokerResultOutputWithContext(ctx context.Context) LookupIotCoreBrokerResultOutput {
	return o
}

func (o LookupIotCoreBrokerResultOutput) BrokerId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupIotCoreBrokerResult) *string { return v.BrokerId }).(pulumi.StringPtrOutput)
}

func (o LookupIotCoreBrokerResultOutput) Certificates() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupIotCoreBrokerResult) []string { return v.Certificates }).(pulumi.StringArrayOutput)
}

func (o LookupIotCoreBrokerResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIotCoreBrokerResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupIotCoreBrokerResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIotCoreBrokerResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupIotCoreBrokerResultOutput) FolderId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupIotCoreBrokerResult) *string { return v.FolderId }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupIotCoreBrokerResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIotCoreBrokerResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupIotCoreBrokerResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupIotCoreBrokerResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupIotCoreBrokerResultOutput) LogOptions() GetIotCoreBrokerLogOptionArrayOutput {
	return o.ApplyT(func(v LookupIotCoreBrokerResult) []GetIotCoreBrokerLogOption { return v.LogOptions }).(GetIotCoreBrokerLogOptionArrayOutput)
}

func (o LookupIotCoreBrokerResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupIotCoreBrokerResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupIotCoreBrokerResultOutput{})
}
