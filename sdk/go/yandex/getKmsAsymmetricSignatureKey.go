// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupKmsAsymmetricSignatureKey(ctx *pulumi.Context, args *LookupKmsAsymmetricSignatureKeyArgs, opts ...pulumi.InvokeOption) (*LookupKmsAsymmetricSignatureKeyResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupKmsAsymmetricSignatureKeyResult
	err := ctx.Invoke("yandex:index/getKmsAsymmetricSignatureKey:getKmsAsymmetricSignatureKey", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getKmsAsymmetricSignatureKey.
type LookupKmsAsymmetricSignatureKeyArgs struct {
	AsymmetricSignatureKeyId string            `pulumi:"asymmetricSignatureKeyId"`
	DeletionProtection       *bool             `pulumi:"deletionProtection"`
	Description              *string           `pulumi:"description"`
	FolderId                 *string           `pulumi:"folderId"`
	Labels                   map[string]string `pulumi:"labels"`
	Name                     *string           `pulumi:"name"`
	SignatureAlgorithm       *string           `pulumi:"signatureAlgorithm"`
}

// A collection of values returned by getKmsAsymmetricSignatureKey.
type LookupKmsAsymmetricSignatureKeyResult struct {
	AsymmetricSignatureKeyId string  `pulumi:"asymmetricSignatureKeyId"`
	CreatedAt                string  `pulumi:"createdAt"`
	DeletionProtection       *bool   `pulumi:"deletionProtection"`
	Description              *string `pulumi:"description"`
	FolderId                 string  `pulumi:"folderId"`
	// The provider-assigned unique ID for this managed resource.
	Id                 string            `pulumi:"id"`
	Labels             map[string]string `pulumi:"labels"`
	Name               *string           `pulumi:"name"`
	SignatureAlgorithm *string           `pulumi:"signatureAlgorithm"`
	Status             string            `pulumi:"status"`
}

func LookupKmsAsymmetricSignatureKeyOutput(ctx *pulumi.Context, args LookupKmsAsymmetricSignatureKeyOutputArgs, opts ...pulumi.InvokeOption) LookupKmsAsymmetricSignatureKeyResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupKmsAsymmetricSignatureKeyResult, error) {
			args := v.(LookupKmsAsymmetricSignatureKeyArgs)
			r, err := LookupKmsAsymmetricSignatureKey(ctx, &args, opts...)
			var s LookupKmsAsymmetricSignatureKeyResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupKmsAsymmetricSignatureKeyResultOutput)
}

// A collection of arguments for invoking getKmsAsymmetricSignatureKey.
type LookupKmsAsymmetricSignatureKeyOutputArgs struct {
	AsymmetricSignatureKeyId pulumi.StringInput    `pulumi:"asymmetricSignatureKeyId"`
	DeletionProtection       pulumi.BoolPtrInput   `pulumi:"deletionProtection"`
	Description              pulumi.StringPtrInput `pulumi:"description"`
	FolderId                 pulumi.StringPtrInput `pulumi:"folderId"`
	Labels                   pulumi.StringMapInput `pulumi:"labels"`
	Name                     pulumi.StringPtrInput `pulumi:"name"`
	SignatureAlgorithm       pulumi.StringPtrInput `pulumi:"signatureAlgorithm"`
}

func (LookupKmsAsymmetricSignatureKeyOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupKmsAsymmetricSignatureKeyArgs)(nil)).Elem()
}

// A collection of values returned by getKmsAsymmetricSignatureKey.
type LookupKmsAsymmetricSignatureKeyResultOutput struct{ *pulumi.OutputState }

func (LookupKmsAsymmetricSignatureKeyResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupKmsAsymmetricSignatureKeyResult)(nil)).Elem()
}

func (o LookupKmsAsymmetricSignatureKeyResultOutput) ToLookupKmsAsymmetricSignatureKeyResultOutput() LookupKmsAsymmetricSignatureKeyResultOutput {
	return o
}

func (o LookupKmsAsymmetricSignatureKeyResultOutput) ToLookupKmsAsymmetricSignatureKeyResultOutputWithContext(ctx context.Context) LookupKmsAsymmetricSignatureKeyResultOutput {
	return o
}

func (o LookupKmsAsymmetricSignatureKeyResultOutput) AsymmetricSignatureKeyId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKmsAsymmetricSignatureKeyResult) string { return v.AsymmetricSignatureKeyId }).(pulumi.StringOutput)
}

func (o LookupKmsAsymmetricSignatureKeyResultOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKmsAsymmetricSignatureKeyResult) string { return v.CreatedAt }).(pulumi.StringOutput)
}

func (o LookupKmsAsymmetricSignatureKeyResultOutput) DeletionProtection() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupKmsAsymmetricSignatureKeyResult) *bool { return v.DeletionProtection }).(pulumi.BoolPtrOutput)
}

func (o LookupKmsAsymmetricSignatureKeyResultOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupKmsAsymmetricSignatureKeyResult) *string { return v.Description }).(pulumi.StringPtrOutput)
}

func (o LookupKmsAsymmetricSignatureKeyResultOutput) FolderId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKmsAsymmetricSignatureKeyResult) string { return v.FolderId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupKmsAsymmetricSignatureKeyResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKmsAsymmetricSignatureKeyResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupKmsAsymmetricSignatureKeyResultOutput) Labels() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupKmsAsymmetricSignatureKeyResult) map[string]string { return v.Labels }).(pulumi.StringMapOutput)
}

func (o LookupKmsAsymmetricSignatureKeyResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupKmsAsymmetricSignatureKeyResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func (o LookupKmsAsymmetricSignatureKeyResultOutput) SignatureAlgorithm() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupKmsAsymmetricSignatureKeyResult) *string { return v.SignatureAlgorithm }).(pulumi.StringPtrOutput)
}

func (o LookupKmsAsymmetricSignatureKeyResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKmsAsymmetricSignatureKeyResult) string { return v.Status }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupKmsAsymmetricSignatureKeyResultOutput{})
}