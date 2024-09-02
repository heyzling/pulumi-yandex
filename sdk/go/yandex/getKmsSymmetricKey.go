// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupKmsSymmetricKey(ctx *pulumi.Context, args *LookupKmsSymmetricKeyArgs, opts ...pulumi.InvokeOption) (*LookupKmsSymmetricKeyResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupKmsSymmetricKeyResult
	err := ctx.Invoke("yandex:index/getKmsSymmetricKey:getKmsSymmetricKey", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getKmsSymmetricKey.
type LookupKmsSymmetricKeyArgs struct {
	DefaultAlgorithm   *string           `pulumi:"defaultAlgorithm"`
	DeletionProtection *bool             `pulumi:"deletionProtection"`
	Description        *string           `pulumi:"description"`
	FolderId           *string           `pulumi:"folderId"`
	Labels             map[string]string `pulumi:"labels"`
	Name               *string           `pulumi:"name"`
	RotationPeriod     *string           `pulumi:"rotationPeriod"`
	SymmetricKeyId     *string           `pulumi:"symmetricKeyId"`
}

// A collection of values returned by getKmsSymmetricKey.
type LookupKmsSymmetricKeyResult struct {
	CreatedAt          string  `pulumi:"createdAt"`
	DefaultAlgorithm   *string `pulumi:"defaultAlgorithm"`
	DeletionProtection *bool   `pulumi:"deletionProtection"`
	Description        *string `pulumi:"description"`
	FolderId           string  `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id             string            `pulumi:"id"`
	Labels         map[string]string `pulumi:"labels"`
	Name           *string           `pulumi:"name"`
	RotatedAt      string            `pulumi:"rotatedAt"`
	RotationPeriod *string           `pulumi:"rotationPeriod"`
	Status         string            `pulumi:"status"`
	SymmetricKeyId *string           `pulumi:"symmetricKeyId"`
}

func LookupKmsSymmetricKeyOutput(ctx *pulumi.Context, args LookupKmsSymmetricKeyOutputArgs, opts ...pulumi.InvokeOption) LookupKmsSymmetricKeyResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupKmsSymmetricKeyResult, error) {
			args := v.(LookupKmsSymmetricKeyArgs)
			r, err := LookupKmsSymmetricKey(ctx, &args, opts...)
			var s LookupKmsSymmetricKeyResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupKmsSymmetricKeyResultOutput)
}

// A collection of arguments for invoking getKmsSymmetricKey.
type LookupKmsSymmetricKeyOutputArgs struct {
	DefaultAlgorithm   pulumi.StringPtrInput `pulumi:"defaultAlgorithm"`
	DeletionProtection pulumi.BoolPtrInput   `pulumi:"deletionProtection"`
	Description        pulumi.StringPtrInput `pulumi:"description"`
	FolderId           pulumi.StringPtrInput `pulumi:"folderId"`
	Labels             pulumi.StringMapInput `pulumi:"labels"`
	Name               pulumi.StringPtrInput `pulumi:"name"`
	RotationPeriod     pulumi.StringPtrInput `pulumi:"rotationPeriod"`
	SymmetricKeyId     pulumi.StringPtrInput `pulumi:"symmetricKeyId"`
}

func (LookupKmsSymmetricKeyOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupKmsSymmetricKeyArgs)(nil)).Elem()
}

// A collection of values returned by getKmsSymmetricKey.
type LookupKmsSymmetricKeyResultOutput struct{ *pulumi.OutputState }

func (LookupKmsSymmetricKeyResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupKmsSymmetricKeyResult)(nil)).Elem()
}

func (o LookupKmsSymmetricKeyResultOutput) ToLookupKmsSymmetricKeyResultOutput() LookupKmsSymmetricKeyResultOutput {
	return o
}

func (o LookupKmsSymmetricKeyResultOutput) ToLookupKmsSymmetricKeyResultOutputWithContext(ctx context.Context) LookupKmsSymmetricKeyResultOutput {
	return o
}

func (o LookupKmsSymmetricKeyResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKmsSymmetricKeyResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupKmsSymmetricKeyResultOutput) DefaultAlgorithm() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupKmsSymmetricKeyResult) *string { return v.DefaultAlgorithm }).(pulumi.StringPtrOutput)
}

func (o LookupKmsSymmetricKeyResultOutput) DeletionProtection() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupKmsSymmetricKeyResult) *bool { return v.DeletionProtection }).(pulumi.BoolPtrOutput)
}

func (o LookupKmsSymmetricKeyResultOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupKmsSymmetricKeyResult) *string { return v.Description }).(pulumi.StringPtrOutput)
}

func (o LookupKmsSymmetricKeyResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKmsSymmetricKeyResult) string { return v.FolderId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupKmsSymmetricKeyResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKmsSymmetricKeyResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupKmsSymmetricKeyResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupKmsSymmetricKeyResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupKmsSymmetricKeyResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupKmsSymmetricKeyResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func (o LookupKmsSymmetricKeyResultOutput) RotatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKmsSymmetricKeyResult) string { return v.RotatedAt }).(pulumi.StringOutput)
}

func (o LookupKmsSymmetricKeyResultOutput) RotationPeriod() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupKmsSymmetricKeyResult) *string { return v.RotationPeriod }).(pulumi.StringPtrOutput)
}

func (o LookupKmsSymmetricKeyResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKmsSymmetricKeyResult) string { return v.Status }).(pulumi.StringOutput)
}

func (o LookupKmsSymmetricKeyResultOutput) SymmetricKeyId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupKmsSymmetricKeyResult) *string { return v.SymmetricKeyId }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupKmsSymmetricKeyResultOutput{})
}
