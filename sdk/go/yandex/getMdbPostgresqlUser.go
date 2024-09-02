// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package yandex

import (
	"context"
	"reflect"

	"github.com/heyzling/pulumi-yandex.git/sdk/go/yandex/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupMdbPostgresqlUser(ctx *pulumi.Context, args *LookupMdbPostgresqlUserArgs, opts ...pulumi.InvokeOption) (*LookupMdbPostgresqlUserResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupMdbPostgresqlUserResult
	err := ctx.Invoke("yandex:index/getMdbPostgresqlUser:getMdbPostgresqlUser", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getMdbPostgresqlUser.
type LookupMdbPostgresqlUserArgs struct {
	ClusterId          string            `pulumi:"clusterId"`
	ConnLimit          *int              `pulumi:"connLimit"`
	DeletionProtection *string           `pulumi:"deletionProtection"`
	Login              *bool             `pulumi:"login"`
	Name               string            `pulumi:"name"`
	Settings           map[string]string `pulumi:"settings"`
}

// A collection of values returned by getMdbPostgresqlUser.
type LookupMdbPostgresqlUserResult struct {
	ClusterId          string   `pulumi:"clusterId"`
	ConnLimit          *int     `pulumi:"connLimit"`
	DeletionProtection *string  `pulumi:"deletionProtection"`
	Grants             []string `pulumi:"grants"`
	// The provider-assigned unique ID for this managed resource.
	Id          string                           `pulumi:"id"`
	Login       *bool                            `pulumi:"login"`
	Name        string                           `pulumi:"name"`
	Password    string                           `pulumi:"password"`
	Permissions []GetMdbPostgresqlUserPermission `pulumi:"permissions"`
	Settings    map[string]string                `pulumi:"settings"`
}

func LookupMdbPostgresqlUserOutput(ctx *pulumi.Context, args LookupMdbPostgresqlUserOutputArgs, opts ...pulumi.InvokeOption) LookupMdbPostgresqlUserResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupMdbPostgresqlUserResult, error) {
			args := v.(LookupMdbPostgresqlUserArgs)
			r, err := LookupMdbPostgresqlUser(ctx, &args, opts...)
			var s LookupMdbPostgresqlUserResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupMdbPostgresqlUserResultOutput)
}

// A collection of arguments for invoking getMdbPostgresqlUser.
type LookupMdbPostgresqlUserOutputArgs struct {
	ClusterId          pulumi.StringInput    `pulumi:"clusterId"`
	ConnLimit          pulumi.IntPtrInput    `pulumi:"connLimit"`
	DeletionProtection pulumi.StringPtrInput `pulumi:"deletionProtection"`
	Login              pulumi.BoolPtrInput   `pulumi:"login"`
	Name               pulumi.StringInput    `pulumi:"name"`
	Settings           pulumi.StringMapInput `pulumi:"settings"`
}

func (LookupMdbPostgresqlUserOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMdbPostgresqlUserArgs)(nil)).Elem()
}

// A collection of values returned by getMdbPostgresqlUser.
type LookupMdbPostgresqlUserResultOutput struct{ *pulumi.OutputState }

func (LookupMdbPostgresqlUserResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMdbPostgresqlUserResult)(nil)).Elem()
}

func (o LookupMdbPostgresqlUserResultOutput) ToLookupMdbPostgresqlUserResultOutput() LookupMdbPostgresqlUserResultOutput {
	return o
}

func (o LookupMdbPostgresqlUserResultOutput) ToLookupMdbPostgresqlUserResultOutputWithContext(ctx context.Context) LookupMdbPostgresqlUserResultOutput {
	return o
}

func (o LookupMdbPostgresqlUserResultOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlUserResult) string { return v.ClusterId }).(pulumi.StringOutput)
}

func (o LookupMdbPostgresqlUserResultOutput) ConnLimit() pulumi.IntPtrOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlUserResult) *int { return v.ConnLimit }).(pulumi.IntPtrOutput)
}

func (o LookupMdbPostgresqlUserResultOutput) DeletionProtection() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlUserResult) *string { return v.DeletionProtection }).(pulumi.StringPtrOutput)
}

func (o LookupMdbPostgresqlUserResultOutput) Grants() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlUserResult) []string { return v.Grants }).(pulumi.StringArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupMdbPostgresqlUserResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlUserResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupMdbPostgresqlUserResultOutput) Login() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlUserResult) *bool { return v.Login }).(pulumi.BoolPtrOutput)
}

func (o LookupMdbPostgresqlUserResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlUserResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupMdbPostgresqlUserResultOutput) Password() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlUserResult) string { return v.Password }).(pulumi.StringOutput)
}

func (o LookupMdbPostgresqlUserResultOutput) Permissions() GetMdbPostgresqlUserPermissionArrayOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlUserResult) []GetMdbPostgresqlUserPermission { return v.Permissions }).(GetMdbPostgresqlUserPermissionArrayOutput)
}

func (o LookupMdbPostgresqlUserResultOutput) Settings() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupMdbPostgresqlUserResult) map[string]string { return v.Settings }).(pulumi.StringMapOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupMdbPostgresqlUserResultOutput{})
}
